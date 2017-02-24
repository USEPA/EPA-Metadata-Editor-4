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
    public class ClearMetadata : ESRI.ArcGIS.Desktop.AddIns.Button
    {
        private string gxName;
        private StringBuilder processedRecords;

        public ClearMetadata()
        {
        }

        protected override void OnClick()
        {
            try
            {
                if (MessageBox.Show("Existing metadata will be erased. Are you sure you want to clear?", "Please Confirm",
                       MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    IGxSelection selection = ArcCatalog.ThisApplication.Selection;
                    IEnumGxObject selectedObjects = selection.SelectedObjects as IEnumGxObject;
                    processedRecords = new StringBuilder();
                    
                    ////XmlDocument xDoc = new XmlDocument();
                    if (selection.Count > 0)
                    {
                        for (int i = 0; i < selection.Count; ++i)
                        {
                            clearMetadataForSelected(selectedObjects.Next());
                        }
                        MessageBox.Show("Records Cleared:" + System.Environment.NewLine + processedRecords.ToString());

                    }
                    else if (selection.Count == 0)
                    {
                        IGxObject gxo = (IGxObject)ArcCatalog.ThisApplication.SelectedObject;
                        clearMetadataForSelected(gxo);
                        MessageBox.Show("Records Cleared:" + System.Environment.NewLine + processedRecords.ToString());

                    }
                    else
                    {
                        MessageBox.Show("Error with selection.  Please try again.");
                    }                    
                }

            }
            catch (Exception e)
            {
                string eString = "Error processing selection. Please try another selection.";
                if (!string.IsNullOrEmpty(gxName))
                {
                    eString += System.Environment.NewLine + "Current Selection: " + gxName;
                }
                MessageBox.Show(eString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void clearMetadataForSelected(IGxObject selectedObject)
        {
            gxName = selectedObject.Name;

            if (selectedObject.Category != "XML Document")
            {
                IMetadata gxMetadata = (IMetadata)selectedObject.InternalObjectName;
                if (gxMetadata != null)
                {
                    IXmlPropertySet2 xmlPropSet2 = gxMetadata.Metadata as IXmlPropertySet2;
                    string emptyXml = "<metadata></metadata>";
                    xmlPropSet2.SetXml(emptyXml);
                    gxMetadata.Metadata = xmlPropSet2 as IPropertySet;
                    processedRecords.Append(System.Environment.NewLine + gxName);
                }             
            }
            
        }

        protected override void OnUpdate()
        {
        }
    }
}
