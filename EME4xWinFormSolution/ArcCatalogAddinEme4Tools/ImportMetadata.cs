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
using System.Windows.Forms;



namespace ArcCatalogAddinEme4Tools
{
    public class ImportMetadata : ESRI.ArcGIS.Desktop.AddIns.Button
    {
        private string gxName;
        private StringBuilder processedRecords;

        public ImportMetadata()
        {
        }

        protected override void OnClick()
        {

            try
            {
                if (MessageBox.Show("Any existing metadata will be erased. Are you sure you want to import?", "Please Confirm Import",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    IGxSelection selection = ArcCatalog.ThisApplication.Selection;
                    IEnumGxObject selectedObjects = selection.SelectedObjects as IEnumGxObject;
                    processedRecords = new StringBuilder();

                    ////XmlDocument xDoc = new XmlDocument();
                    if (selection.Count == 1)
                    {
                        //for (int i = 0; i < selection.Count; ++i)
                        //{
                            importMetadataforSelection(selectedObjects.Next());
                        //}
                        //MessageBox.Show("Imported Metadata for:" + System.Environment.NewLine + processedRecords.ToString());

                    }
                    else if (selection.Count == 0)
                    {
                        IGxObject gxo = (IGxObject)ArcCatalog.ThisApplication.SelectedObject;
                        importMetadataforSelection(gxo);

                    }
                    else
                    {
                        MessageBox.Show("You can edit only one metadata record at a time. Please select one item");
                    }
                }
            }
            catch (Exception e)
            {                
                string eString = "File type not supported. Please try another selection.";
                if (!string.IsNullOrEmpty(gxName))
                {
                    eString += System.Environment.NewLine + "Current Selection: " + gxName;
                }
                MessageBox.Show(eString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void importMetadataforSelection(IGxObject selectedObject)
        {
            gxName = selectedObject.Name;

            if (selectedObject.Category != "XML Document")            
            {
                IMetadata gxMetadata = (IMetadata)selectedObject.InternalObjectName;
                if (gxMetadata != null)
                {
                    //gxMetadata.Synchronize(esriMetadataSyncAction.esriMSACreated);
                                       

                        OpenFileDialog ofd = new OpenFileDialog();
                        ofd.Filter = "XML Metadata (*.XML)|*.XML";
                        ofd.Title = "Select an ISO 19115/19115-2 metadata xml record";
                        ofd.Multiselect = false;
                        if (ofd.ShowDialog() == DialogResult.OK)
                        {
                            XmlDocument importXmlRecord = new XmlDocument();
                            importXmlRecord.Load(ofd.FileName);

                            string isoRootNode = importXmlRecord.DocumentElement.Name;
                            if (isoRootNode.ToLower() == "gmi:mi_metadata" || isoRootNode.ToLower() == "gmd:md_metadata")
                            {
                                //sourceXmlFormat = "ISO19115-2";
                                StringWriter sw = new StringWriter();
                                XmlTextWriter xw = new XmlTextWriter(sw);
                                xw.Formatting = Formatting.Indented;
                                importXmlRecord.WriteTo(xw);

                                IXmlPropertySet2 xmlPropSet2 = gxMetadata.Metadata as IXmlPropertySet2;
                                xmlPropSet2.SetXml(sw.ToString());
                                gxMetadata.Metadata = xmlPropSet2 as IPropertySet;
                                processedRecords.Append(gxName);
                                //ArcCatalog.Application.StatusBar.set_Message(0, "*********Metadata Imported for " + selectedObject.Name + "*********");
                            }
                            else
                            {
                                MessageBox.Show("Please load an ISO 19115 or 19115-2 record.");
                            }
                        }
                                       
                }
                else
                {
                    MessageBox.Show("Error importing metadata for "+ gxName);
                }
            }
        }

        protected override void OnUpdate()
        {
            //Enabled = ArcCatalog.Application != null;
        }
    }
}
