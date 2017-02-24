using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Reflection;
using System.ComponentModel;
using System.Xml;
using System.Windows.Forms;
using System.Data;



namespace EmeLibrary
{
    public class PageController : System.IComparable
    {
        private static SortedDictionary<string, PageController> HiveMind = new SortedDictionary<string, PageController>();
        private static bool HiveMindInitialized = false;
        private static Hashtable emeControlTable = new Hashtable();
        private long orderedID;
        private string tag;
        private string scrTable;
        private string srcField;
        private string dspField;
        private string DCATrequiredCtrl;
        private string EPArequiredCtrl;
        private string formFieldName_;


        public PageController(long orderedID, string tag, string srcTable, string srcField, string dspField, string DCATrequiredCtrl, string EPArequiredCtrl)
        :base()
        {
            //int tabNo, bool spellcheck, string cluster, bool clusterUpdate, string help
            this.orderedID = orderedID;
            this.tag = tag;
            this.scrTable = srcTable;
            this.srcField = srcField;
            this.dspField = dspField;
            this.DCATrequiredCtrl = DCATrequiredCtrl;
            this.EPArequiredCtrl = EPArequiredCtrl;
            this.formFieldName_ = tag;
            HiveMind.Add(formFieldName_, this);         

        }

        public static PageController thatControls(string ctrlName)
        {
            PageController pc;
            HiveMind.TryGetValue(ctrlName, out pc);
            return pc;
        }
        
        /// <summary>
        /// This get called first and finds the name of the form control based on the name in the database
        /// and stores in page controller allong with potential events to wire up.        
        /// </summary>
        public static void readFromDB()
        {
            PageController p; // = new PageController();
            if (HiveMindInitialized) { return; }
            HiveMindInitialized = true;

            //David's Code
            XmlNodeXpathtoElements IsoNodeXpaths = new XmlNodeXpathtoElements();
            //Get field from xml table EME
            Utils1.setEmeSettingsDataset();
            DataTable subTable = Utils1.emeSettingsDataset.Tables["emeControl"].Select().CopyToDataTable();
            //classFieldBindingNames = new List<string>();
            object obj = IsoNodeXpaths;
            int i = 0;
            foreach (DataRow dr in subTable.Rows)
            {
                //MessageBox.Show(dr["propName"].ToString() + Environment.NewLine + dr["srcTable"].ToString() + Environment.NewLine + dr["spellcheck"].ToString());
                //Parse from the list so that IdInfo_citation_TitleXpath, becomes IdInfo_citation_Title and IdInfo_citation_TitleXpath_txt
                string cntrlName;
                int index = dr["controlName"].ToString().IndexOf("Xpath");
                string cleanPath = (index < 0)
                    ? dr["controlName"].ToString()
                    : dr["controlName"].ToString().Remove(index, "Xpath".Length);
                cntrlName = cleanPath;
                
                //Console.WriteLine(cntrlName);
                //Add new page controller object for each record in database
                p = new PageController(i, cntrlName, dr["sourceTable"].ToString(), dr["sourceField"].ToString(), dr["displayField"].ToString(),
                    dr["DCATrequired"].ToString(), dr["EPArequired"].ToString());

                i++;
            }
        }

        /// <summary>
        /// This pulls values from the IsoNodes class after a metadata record has been loaded
        /// </summary>
        /// <param name="frm"></param>
        public static void ElementPopulator(EmeLT frm)
        {
            try
            {
                foreach (PageController pc in HiveMind.Values)
                {

                    pc.populate(frm);                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void populate(EmeLT frm)
        {
            
            //Console.WriteLine(formFieldName_);
            Control ctrl;
            
            ctrl = frm.getControlForTag(formFieldName_);
            object obj = frm.localXdoc;

            //get validation type from user setting
            string validateVal = DCATrequiredCtrl;
            if (frm.validationSetting == "EPA/EDG (ISO19115)")
            {
                validateVal = EPArequiredCtrl;
            }
            else if (frm.validationSetting == "DCAT/Common Core")
            {
                validateVal = DCATrequiredCtrl;
            }
            
            if (ctrl != null)
            {
                //MessageBox.Show(ctrl.Name);
                if (ctrl.GetType() == typeof(uc_ResponsibleParty))
                {
                    uc_ResponsibleParty incoming_ResponsibleParty = (uc_ResponsibleParty)ctrl;
                    incoming_ResponsibleParty.reset();
                    List<CI_ResponsibleParty> ci_RP = (List<CI_ResponsibleParty>)frm.localXdoc.GetType().GetProperty(ctrl.Name).GetValue(obj, null);
                    if (ci_RP != null && ci_RP.Count != 0)
                    {
                        incoming_ResponsibleParty.loadList(ci_RP);
                    }
                    ctrl.Tag = validateVal;
                    setValidationPanelColor(frm, ctrl.Name + "_colorPnl", validateVal);
                }
                else if (ctrl.GetType() == typeof(uc_distribution))
                {
                    #region test uc_distribution
                    //Console.WriteLine("Found Distribution");
                    //test
                    //List<MD_Distributor> distList = new List<MD_Distributor>();
                    //MD_Distributor dim1 = new MD_Distributor();
                    //MD_Distributor dim2 = new MD_Distributor();
                    //MD_Distributor dim3 = new MD_Distributor();

                    //CI_ResponsibleParty ci1 = new CI_ResponsibleParty();
                    //ci1.individualName = "David Yarnell";
                    //dim1.distributorContact__CI_ResponsibleParty = ci1;

                    //List<MD_StandardOrderProcess> sopList = new List<MD_StandardOrderProcess>();
                    //MD_StandardOrderProcess sop1 = new MD_StandardOrderProcess();
                    //MD_StandardOrderProcess sop2 = new MD_StandardOrderProcess();
                    //sopList.Add(sop1);
                    //sopList.Add(sop2);
                    //dim2.distributionOrderProcess__MD_StandardOrderProcess = sopList;

                    //List<MD_Format> formatlist = new List<MD_Format>();
                    //MD_Format format1 = new MD_Format();
                    //MD_Format format2 = new MD_Format();
                    //formatlist.Add(format1);
                    //formatlist.Add(format2);
                    //dim1.distributorFormat__MD_Format = formatlist;

                    //List<MD_DigitalTransferOptions> dtoList = new List<MD_DigitalTransferOptions>();
                    //MD_DigitalTransferOptions dto1 = new MD_DigitalTransferOptions();
                    //MD_DigitalTransferOptions dto2 = new MD_DigitalTransferOptions();
                    //MD_DigitalTransferOptions dto3 = new MD_DigitalTransferOptions();
                    //dtoList.Add(dto1);
                    //dtoList.Add(dto2);
                    //dtoList.Add(dto3);
                    //dim3.distributorTransferOptions__MD_DigitalTransferOptions = dtoList;

                    //distList.Add(dim1);
                    //distList.Add(dim2);
                    //distList.Add(dim3);

                    #endregion test uc_distribution

                    uc_distribution distCtrl = (uc_distribution)ctrl;
                    distCtrl.resetDist();
                    List<MD_Distributor> distList = (List<MD_Distributor>)frm.localXdoc.GetType().GetProperty(ctrl.Name).GetValue(obj, null);
                    if (distList != null && distList.Count != 0)
                    {
                        distCtrl.loadDistributors(distList);
                    }
                    ctrl.Tag = validateVal;
                }
                else if (ctrl.GetType() == typeof(uc_extentTemporal))
                {
                    uc_extentTemporal temporalExtentCtrl = (uc_extentTemporal)ctrl;
                    //need to reset to clear controls
                    //temporalExtentCtrl.reset();
                    temporalElement__EX_TemporalExtent inboundExtentObject = (temporalElement__EX_TemporalExtent)frm.localXdoc.GetType().GetProperty
                        (ctrl.Name).GetValue(obj, null);
                    temporalExtentCtrl.loadTemporalExtent(inboundExtentObject);
                    ctrl.Tag = validateVal;
                    setValidationPanelColor(frm, ctrl.Name + "_colorPnl", validateVal);
                }
                else if (ctrl.GetType() == typeof(ListBox))
                {
                    ListBox topic = (ListBox)ctrl;
                    List<string> list = (List<string>)frm.localXdoc.GetType().GetProperty(ctrl.Name).GetValue(obj, null);
                    ctrl.Tag = validateVal;
                    if (scrTable != "")
                    {
                        //Bind system table to listbox
                        topic.DataSource = Utils1.emeDataSet.Tables[scrTable];                        
                        topic.DisplayMember = srcField;
                        topic.ClearSelected();
                        if (ctrl.Name == "idInfo_keywordsUser" || ctrl.Name == "idInfo_keywordsPlace")
                        {
                            foreach (string k in list)
                            {
                                int w = topic.FindStringExact(k);
                                if (w == -1)
                                {
                                    topic.BeginUpdate();
                                    DataRow dr = Utils1.emeDataSet.Tables[scrTable].NewRow();
                                    dr[srcField] = k;
                                    Utils1.emeDataSet.Tables[scrTable].Rows.Add(dr);
                                    topic.EndUpdate();
                                }
                            }
                        }
                        foreach (string r in list)
                        {
                            int p = topic.FindStringExact(r);
                            topic.SetSelected(p, true);
                        }
                    }
                }
                else if (ctrl.GetType() == typeof(ComboBox))
                {
                    //Note:
                    //If combo boxes are bound to a data table use the comboBox.SelectedValue to bind the incoming metadata value
                    //with the valueMember (as opposed to the Display Member).  If combo box items are not from a data table bind
                    //then use the comboBox.SelectedItem.
                    //Some combo boxes allow free text and additional items if not found in the list while others are tied to a domain
                    //and should not accept additional values.
                  
                    ComboBox boxCbo = (ComboBox)ctrl;

                    //c = The inbound value from the metadata record
                    string c = (frm.localXdoc.GetType().GetProperty(ctrl.Name).GetValue(obj, null) != null) ?
                        frm.localXdoc.GetType().GetProperty(ctrl.Name).GetValue(obj, null).ToString().Trim() : "";
                    ctrl.Tag = validateVal;
                    //boxCbo.BeginUpdate();
                    boxCbo.SelectedIndex = -1;
                    boxCbo.Text = ""; //clears free existing free text

                    if (scrTable != "")
                    {
                        DataTable subTable = Utils1.emeDataSet.Tables[scrTable].Select().CopyToDataTable();

                        if (string.IsNullOrEmpty(dspField)) { dspField = srcField; } //make sure dspField has been set for Dropdown lists

                        if (c != "")
                        {
                            //If it has incoming value, find in drop box and select.  Othewise append the value to the drop box
                            //Some drop boxes allow free text while others do not.  Check for this setting to determine if value
                            //should be appended to the drop box.  Also, some drop boxes may have different dispay and value members. This 
                            //setting should be handled in the EME Settings xml file.                            

                            //boxCbo.Text = c;
                            foreach (DataRow dr in subTable.Rows)
                            {
                                
                                if (dr[srcField].ToString() == c.ToString())
                                {
                                //    //Console.WriteLine("Found");
                                    boxCbo.DataSource = subTable;
                                    boxCbo.ValueMember = srcField;
                                //    boxCbo.DisplayMember = srcField;
                                    boxCbo.DisplayMember = dspField;
                                    boxCbo.SelectedValue = c;  //dr[srcField].ToString();
                                    //break;
                                    return;
                                }
                            }
                            if (boxCbo.DropDownStyle != ComboBoxStyle.DropDownList)
                            {
                                DataRow row = subTable.NewRow();
                                row[srcField] = c;
                                row[dspField] = c;
                                subTable.Rows.InsertAt(row, 0);//Add(row);  At the row to the top row.
                                boxCbo.DataSource = subTable;
                                boxCbo.ValueMember = srcField;
                                //boxCbo.DisplayMember = srcField;
                                boxCbo.DisplayMember = dspField;
                                boxCbo.SelectedValue = c;
                            }
                            else
                            {
                                boxCbo.DataSource = subTable;
                                boxCbo.ValueMember = srcField;
                                boxCbo.DisplayMember = dspField;
                                boxCbo.SelectedIndex = -1;
                            }
                        }
                        else
                        {
                            //No incoming value, just databind to the table
                            boxCbo.DataSource = subTable;
                            boxCbo.ValueMember = srcField;                            
                            boxCbo.DisplayMember = dspField;
                            boxCbo.SelectedIndex = -1;
                        }
                    }
                    else
                    {
                        
                        int i = boxCbo.FindStringExact(c);
                        if (i > -1)
                        {
                            boxCbo.SelectedItem = c;
                        }
                        else 
                        {
                            //add the text to cbo if not found in list
                            //This does not work if the cbo does not have an editable portion enabled.
                            boxCbo.SelectedText = c;
                        }

                    }
                    //boxCbo.EndUpdate();


                    //boxCbo.Focus();     //Need to figure out why it need focus to save
                }
                else if (ctrl.GetType() == typeof(TextBox))
                {
                    string s = (frm.localXdoc.GetType().GetProperty(ctrl.Name).GetValue(obj, null) != null) ?
                        frm.localXdoc.GetType().GetProperty(ctrl.Name).GetValue(obj, null).ToString() : "";

                    if (ctrl.Name.Contains("idInfo_extent_geographicBoundingBox"))
                    {
                        if (s == "0")
                        {
                            s = "";                            
                        }
                    }

                    ctrl.Text = s;
                    ctrl.Tag = validateVal;
                    setValidationPanelColor(frm, ctrl.Name + "_colorPnl", validateVal);
                }
            }
        }

        /// <summary>
        /// Save all PageControllers back to metadata record.
        /// </summary>
        /// <param name="frm">Editor form</param>
        public static void PageSaver(EmeLT frm)
        {
            foreach (PageController pc in HiveMind.Values)
            {
                //Console.WriteLine(pc.formFieldName_);
                pc.save(frm);
            }
        }

        /// <summary>
        /// Save this PageController back to metadata record.
        /// </summary>
        /// <param name="frm">the form</param>
        private void save(EmeLT frm)
        {
            Control ctrl;
            ctrl = frm.getControlForTag(formFieldName_);
            object obj = frm.localXdoc;

            if (ctrl != null)
            {
                if (ctrl.GetType() == typeof(uc_ResponsibleParty))
                {
                    uc_ResponsibleParty outgoing_ResponsibleParty = (uc_ResponsibleParty)ctrl;
                    frm.localXdoc.GetType().GetProperty(ctrl.Name).SetValue(obj, outgoing_ResponsibleParty.CI_ResponsiblePartyList, null);
                    //Console.WriteLine(outgoing_ResponsibleParty.incomingCI_ResponsiblePartyList.Count());
                    //Console.WriteLine(outgoing_ResponsibleParty.incomingCI_ResponsiblePartyList[].individualName);
                    //List<CI_ResponsibleParty> ci_RP = (List<CI_ResponsibleParty>)frm.localXdoc.GetType().GetProperty(ctrl.Name).GetValue(obj, null);
                }
                else if (ctrl.GetType() == typeof(uc_distribution))                
                {
                    uc_distribution outgoing_distribution = (uc_distribution)ctrl;
                    frm.localXdoc.GetType().GetProperty(ctrl.Name).SetValue(obj, outgoing_distribution.distributorList, null);
                }
                else if (ctrl.GetType() == typeof(uc_extentTemporal))
                {
                    uc_extentTemporal outgoing_extentTemporal = (uc_extentTemporal)ctrl;
                    frm.localXdoc.GetType().GetProperty(ctrl.Name).SetValue(obj, outgoing_extentTemporal.temporalElement, null);
                }
                else if (ctrl.GetType() == typeof(ComboBox))
                {
                    ComboBox boxCbo = (ComboBox)ctrl;
                    string selectedCboValue = "";
                    selectedCboValue = boxCbo.Text;
                    
                    if (!string.IsNullOrEmpty(selectedCboValue))
                    {
                        if (boxCbo.DataSource != null)
                        {
                            int i = boxCbo.FindStringExact(selectedCboValue);
                            //Find the displayed value index
                            //If -1, then just go with the display value since that combobox might allow free text
                            if (i > -1)
                            {
                                DataRowView drv = (DataRowView)boxCbo.Items[i];
                                selectedCboValue = drv[boxCbo.ValueMember.ToString()].ToString();
                            }
                        }
                    }

                    frm.localXdoc.GetType().GetProperty(ctrl.Name).SetValue(obj, selectedCboValue, null);

                }
                else if (ctrl.GetType() == typeof(TextBox))
                {
                    //idInfo_extent_geographicBoundingBox_northLatDD
                    if (ctrl.Name.Contains("idInfo_extent_geographicBoundingBox"))
                    {
                        double testVal;
                        bool isDouble = double.TryParse(ctrl.Text, out testVal);
                        double v = (isDouble) ? testVal : 0;
                        //double v = (!string.IsNullOrEmpty(ctrl.Text)) ? Convert.ToDouble(ctrl.Text) : 0;                        
                        frm.localXdoc.GetType().GetProperty(ctrl.Name).SetValue(obj, v, null);
                    }
                    else
                    {
                        //Console.WriteLine(frm.localXdoc.GetType().GetProperty(ctrl.Name).GetValue(obj, null).ToString() + "   " + ctrl.Text);
                        frm.localXdoc.GetType().GetProperty(ctrl.Name).SetValue(obj, ctrl.Text, null);
                        //MessageBox.Show(frm.localXdoc.idInfo_citation_Title.ToString());
                    }

                    //Console.WriteLine(ctrl.Text);
                }
                else if (ctrl.GetType() == typeof(ListBox))
                {
                    ListBox lstBox = (ListBox)ctrl;
                    //MessageBox.Show(lstBox.Name);

                    List<string> saveList = (List<string>)frm.localXdoc.GetType().GetProperty(ctrl.Name).GetValue(obj, null);
                    saveList.Clear();
                    foreach (DataRowView dRow in lstBox.SelectedItems)
                    {
                        saveList.Add(dRow[srcField].ToString());
                    }

                    frm.localXdoc.GetType().GetProperty(ctrl.Name).SetValue(obj, saveList, null);
                }

            }
        }

        public void setDefault(EmeLT frm)
        {
            Control ctrl;
            ctrl = frm.getControlForTag(formFieldName_);

            if (scrTable != "")
            {
                if (ctrl.GetType() == typeof(ComboBox))
                {
                    ComboBox cbx = (ComboBox)ctrl;
                    for (int i = 0; i < cbx.Items.Count; i++)
                    {
                        DataRowView dr = (DataRowView)cbx.Items[i];
                        bool d = (bool)dr["default"];
                        if (d)
                        {
                            cbx.SelectedIndex = i;
                        }
                    }
                }
            }
        }

        int IComparable.CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Sets validation mode, error icon, and color of panels for controls.
        /// </summary>
        /// <param name="frm"></param>
        public static void validatePopulator(EmeLT frm)
        {
            try
            {
                foreach (PageController pc in HiveMind.Values)
                {

                    pc.populateVal(frm);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void populateVal(EmeLT frm)
        {

            //Console.WriteLine(formFieldName_ + "val");
            Control ctrl;

            ctrl = frm.getControlForTag(formFieldName_);
            object obj = frm.localXdoc;

            //get validation type from user setting
            string validateVal = DCATrequiredCtrl;
            if (frm.validationSetting == "EPA/EDG (ISO19115)")
            {
                validateVal = EPArequiredCtrl;
            }
            else if (frm.validationSetting == "DCAT/Common Core")
            {
                validateVal = DCATrequiredCtrl;
            }

            if (ctrl != null)
            {
                //MessageBox.Show(ctrl.Name);
                if (ctrl.GetType() == typeof(uc_ResponsibleParty))
                {
                    uc_ResponsibleParty incoming_ResponsibleParty = (uc_ResponsibleParty)ctrl;
                    
                    ctrl.Tag = validateVal;
                    
                    //Set the color panel to yellow or blue
                    setValidationPanelColor(frm, ctrl.Name + "_colorPnl", validateVal);       

                }
                else if (ctrl.GetType() == typeof(uc_distribution))
                {
                   
                    uc_distribution distCtrl = (uc_distribution)ctrl;
                    
                    ctrl.Tag = validateVal;
                }
                else if (ctrl.GetType() == typeof(uc_extentTemporal))
                {
                    uc_extentTemporal timeExtent = (uc_extentTemporal)ctrl;
                    ctrl.Tag = validateVal;
                    setValidationPanelColor(frm, ctrl.Name + "_colorPnl", validateVal);
                    
                }
                else if (ctrl.GetType() == typeof(ListBox))
                {
                    ListBox topic = (ListBox)ctrl;
                    ctrl.Tag = validateVal;
                }
                else if (ctrl.GetType() == typeof(ComboBox))
                {

                    ComboBox boxCbo = (ComboBox)ctrl;
                    ctrl.Tag = validateVal;
                    
                }
                else if (ctrl.GetType() == typeof(TextBox))
                {
                    ctrl.Tag = validateVal;
                    setValidationPanelColor(frm, ctrl.Name + "_colorPnl", validateVal);
                }
            }
        }

        private void setValidationPanelColor(EmeLT frmRef, string controlName, string valiationValue)
        {
            
            Control[] colorPanelCollection = frmRef.Controls.Find(controlName, true);
            if (colorPanelCollection.Length > 0)
            {
                Panel pnlColor = (Panel)colorPanelCollection[0];

                if (valiationValue.Contains("require"))
                {

                    pnlColor.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
                    pnlColor.Refresh();
                }
                else
                {
                    pnlColor.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
                    pnlColor.Refresh();
                }
            }       


        }
    }   
}
