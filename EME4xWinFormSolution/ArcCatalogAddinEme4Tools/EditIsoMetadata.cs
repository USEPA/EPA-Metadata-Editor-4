using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml;
using EmeLibrary;
using ESRI.ArcGIS.Catalog;
using ESRI.ArcGIS.CatalogUI;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;
using System.Windows.Forms;


namespace ArcCatalogAddinEme4Tools
{
    public class EditIsoMetadata : ESRI.ArcGIS.Desktop.AddIns.Button
    {
        private XmlDocument esriXmlDoc = new XmlDocument();
        private IMetadata gxMetadata;
        private string esriXmlString;
        private string gxName;

        public EditIsoMetadata()
        {
        }

        protected override void OnClick()
        {
            //MessageBox.Show("Clicked");
            //MessageBox.Show("Addin: " + Directory.GetCurrentDirectory());
            try
            {
                
                IGxSelection selection = ArcCatalog.ThisApplication.Selection;
                IEnumGxObject selectedObjects = selection.SelectedObjects as IEnumGxObject;

                if (selection.Count == 1)                
                {
                    //Get the selection from the contents tab
                    loadXmlFromSelection(selectedObjects.Next());                    
                }
                else if (selection.Count == 0)
                {
                    //If no selection from Contents Tab, try from the TreeView
                    IGxObject gxo = (IGxObject)ArcCatalog.ThisApplication.SelectedObject;                    
                    loadXmlFromSelection(gxo);
                }
                else
                {
                    MessageBox.Show("You can edit only one metadata record at a time. Please select one item with metadata.");
                }
                
            }
            catch (Exception e)
            {
                string eString = "File type not supported. Please try another selection.";
                if (!string.IsNullOrEmpty(gxName))
                {
                    eString += System.Environment.NewLine+ "Current Selection: " + gxName;
                }

                MessageBox.Show(eString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //I haven't see a better way to check for this.  Examples welcome!
            }
        }

        private void loadXmlFromSelection(IGxObject selectedObject)
        {
            gxName = selectedObject.Name;
            EmeLT emeForm = new EmeLT();
            
            //If it is raw xml then load form in stand-alone mode
            if (selectedObject.Category == "XML Document")
            {
                emeForm.AddDocument(selectedObject.FullName);
            }
            else
            {
                //MessageBox.Show(gxName);
                gxMetadata = (IMetadata)selectedObject.InternalObjectName;
                //gxMetadata = (IMetadata)selection.Location.InternalObjectName;  //.Location works also, but could be different that contents tab!
                if (gxMetadata != null)
                {
                    IXmlPropertySet2 xmlPropSet2 = gxMetadata.Metadata as IXmlPropertySet2;
                    esriXmlString = xmlPropSet2.GetXml("/");

                    IGxDataset gxDataSet = (IGxDataset)selectedObject;
                    IGeoDataset geoDataSet = (IGeoDataset)gxDataSet.Dataset;
                    geographicExtentBoundingBox gdbBB = new geographicExtentBoundingBox();

                    if (!geoDataSet.Extent.IsEmpty)
                    {
                        ISpatialReferenceFactory spatialReferenceFactory = new SpatialReferenceEnvironmentClass();
                        ISpatialReference spatialReferenceWGS84 = spatialReferenceFactory.CreateGeographicCoordinateSystem(4326);
                        IEnvelope projectedExtentWGS84 = geoDataSet.Extent;
                        projectedExtentWGS84.Project(spatialReferenceWGS84);

                        #region test Area
                        //    StringBuilder sbExtent = new StringBuilder();
                        //    sbExtent.Append("Boundary in its own georeference: " + System.Environment.NewLine);
                        //    sbExtent.Append("North: " + geoDataSet.Extent.UpperLeft.Y.ToString() + System.Environment.NewLine);
                        //    sbExtent.Append("East: " + geoDataSet.Extent.LowerRight.X.ToString() + System.Environment.NewLine);
                        //    sbExtent.Append("South: " + geoDataSet.Extent.LowerRight.Y.ToString() + System.Environment.NewLine);
                        //    sbExtent.Append("West: " + geoDataSet.Extent.UpperLeft.X.ToString() + System.Environment.NewLine);

                        //    sbExtent.Append("------------------------------------" + System.Environment.NewLine);

                        //    sbExtent.Append("Boundary in Lat long: " + System.Environment.NewLine);
                        //    sbExtent.Append("North: " + projectedExtentWGS84.UpperLeft.Y.ToString() + System.Environment.NewLine);
                        //    sbExtent.Append("East: " + projectedExtentWGS84.LowerRight.X.ToString() + System.Environment.NewLine);
                        //    sbExtent.Append("South: " + projectedExtentWGS84.LowerRight.Y.ToString() + System.Environment.NewLine);
                        //    sbExtent.Append("West: " + projectedExtentWGS84.UpperLeft.X.ToString() + System.Environment.NewLine);
                        #endregion

                        gdbBB.Description = "Feature Class Extent";
                        gdbBB.NorthLat = projectedExtentWGS84.UpperLeft.Y;
                        gdbBB.SouthLat = projectedExtentWGS84.LowerRight.Y;
                        gdbBB.WestLong = projectedExtentWGS84.UpperLeft.X;
                        gdbBB.EastLong = projectedExtentWGS84.LowerRight.X;
                    }

                    emeForm.SaveEvent += new SaveEventHandler(EmeLT_SaveEvent);
                    if (!string.IsNullOrEmpty(gdbBB.Description))
                    {
                        //Load with Extent Data
                        emeForm.AddDocument(ref esriXmlString, selectedObject.FullName, gdbBB);
                    }
                    else
                    {
                        //Load without Extent Data
                        MessageBox.Show("Extent not found for selected item. Opening record without bounding box data");
                        emeForm.AddDocument(ref esriXmlString, selectedObject.FullName);
                    }

                    //MessageBox.Show("Metadata: " + System.Environment.NewLine + esriXmlString);                                    
                }
                else
                {
                    MessageBox.Show("Error retrieving metadata for selection.  Please try another selection.");
                }
            }
        }


        protected override void OnUpdate()
        {
            Enabled = ArcCatalog.Application != null;
        }

        private void EmeLT_SaveEvent(object sender, SaveEventArgs e)
        {
            try
            {
                if (gxMetadata != null)
                {
                    IXmlPropertySet2 xmlPropSet2 = gxMetadata.Metadata as IXmlPropertySet2;
                    xmlPropSet2.SetXml(e.XML);
                    gxMetadata.Metadata = xmlPropSet2 as IPropertySet;
                    ArcCatalog.Application.StatusBar.set_Message(0, "*********Metadata Updated for " + gxName + "*********");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Saving Metadata for " + gxName);
            }

        }
    }
}
