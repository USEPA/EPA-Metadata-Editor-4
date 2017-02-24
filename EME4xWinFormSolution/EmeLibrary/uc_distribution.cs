using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EmeLibrary
{
    public partial class uc_distribution : UserControl
    {
        //List that contains distributor objects and an index for the list
        private int _distributorList_idx;
        private List<MD_Distributor> _distributorList;

        private CI_ResponsibleParty _distributorContact;

        //List of Distribution Formatts and an index for the list
        private int _distributionFormat_idx;
        private List<MD_Format> _distributionFormat;

        //List of StandardOrderProcess objects and an index for the list
        private int _standardOrderProcess_idx;
        private List<MD_StandardOrderProcess> _standardOrderProcess;

        //List of DigitalTransferOptions objects and an index for the list
        private int _digitalTransferOptions_idx;
        private List<MD_DigitalTransferOptions> _digitalTransferOptions;

        private string expandedSymbol = "\u25BC"; //E
        private string collapsedSymbol = "\u25B6";

        public List<MD_Distributor> distributorList
        {
            get 
            {
                //ToDo Call Save Method Here  bind_MD_Dist_Class(MD_Distributor dist)
                if (_distributorList != null)
                {
                    if (_distributorList.Count > 0)
                    {
                        bind_MD_Dist_Class(_distributorList[_distributorList_idx]);
                    }
                }
                return _distributorList;
            }
            set { _distributorList = value; }
        }

        //public List<MD_Format> distributionFormat
        //{
        //    get { return _distributionFormat; }
        //    set { _distributionFormat = value; }
        //}

        //public List<MD_StandardOrderProcess> standardOrderProcess
        //{
        //    get { return _standardOrderProcess; }
        //    set { _standardOrderProcess = value; }
        //}

        //public List<MD_DigitalTransferOptions> digitalTransferOptions
        //{
        //    get { return _digitalTransferOptions; }
        //    set { _digitalTransferOptions = value; }
        //}

        [Bindable(false)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string mylabel
        {
            get
            {
                return uc_distribution_lbl.Text;
            }
            set
            {
                uc_distribution_lbl.Text = value;
            }
        }

        public uc_distribution()
        {
            
            InitializeComponent();
            expand_MD_DTO_btn.Text = collapsedSymbol;
            expand_MD_Format_btn.Text = collapsedSymbol;
            expand_MD_SOP_btn.Text = collapsedSymbol;
            offline_resource_expandBtn.Text = collapsedSymbol;
            //_distributorList = new List<MD_Distributor>(); 
            //_distributorContact = new CI_ResponsibleParty();

            //if (Utils1.emeDataSet == null)
            //{
            //    Utils1.setEmeDataSets();
            //}
        }   

        //MD_Distributor region contains the events for the controls that control paging through distributors 
        #region MD_Distributor pager Events

        /// <summary>
        /// this method is used to load the distributor list coming from the metada into the gui (pager)
        /// </summary>
        /// <param name="distributors"></param>
        public void loadDistributors(List<MD_Distributor> distributors)
        {
            //set user control list to list passed in
            _distributorList = distributors;
            //Adjust pager controls based on the number of pagers
            if (_distributorList.Count() < 1)
            {
                pgU_MD_Dist_btn.Visible = false;
                pgD_MD_Dist_btn.Visible = false;
                del_MD_Dist_btn.Enabled = false;

                distributor_gbx.Enabled = false;
            }
            else if (_distributorList.Count() == 1)
            {
                del_MD_Dist_btn.Enabled = true;
                
                distributor_gbx.Enabled = true;
            }
            else if (_distributorList.Count() > 1)
            {
                pgU_MD_Dist_btn.Visible = true;
                pgD_MD_Dist_btn.Visible = true;
                del_MD_Dist_btn.Enabled = true;
                
                distributor_gbx.Enabled = true;
            }
            //set the current index to the beginning of the list
            _distributorList_idx = 0;
            //populate the distributor contorls
            bind_MD_Dist_Field(_distributorList[_distributorList_idx]);
            //_distributorList[_distributorList_idx].distributorContact__CI_ResponsibleParty
            
            //ds
            distributor_Contact.adjustRPControl(_distributorList.Count);
            
        }


        /// <summary>
        /// This method is an event fired when the user clicks on the add distributor button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void add_MD_Dist_btn_Click(object sender, EventArgs e)
        {
            //Create new distributor
            MD_Distributor d1 = new MD_Distributor();
            //d1.distributorContact = null;
            d1.distributorContact = new CI_ResponsibleParty();
            //d1.distributorTransferOptions__MD_DigitalTransferOptions

            //if first in list add to the list otherwise save current information in controls then add new to list
            if (_distributorList == null)
            {
                _distributorList = new List<MD_Distributor>();
                _distributorList_idx = 0;
                _distributorList.Add(d1);
            }
            else if(_distributorList.Count == 0)
            {
                _distributorList = new List<MD_Distributor>();
                _distributorList_idx = 0;
                _distributorList.Add(d1);
                               
            }
            else
            {
                //save existing
                bind_MD_Dist_Class(_distributorList[_distributorList_idx]);
                //Add new distributor
                _distributorList.Add(d1);
                //Adjust index
                _distributorList_idx = _distributorList.Count - 1;
            }
            //Adjust controls in sub pagers based on the distributor list
            adjustPagers(MD_Dist, _distributorList);
            //Bind new distributor to controls
            bind_MD_Dist_Field(_distributorList[_distributorList_idx]);
            distributor_gbx.Enabled = true;
            
            //adds a DTO section too.
            add_DTO();
           
            //distributor_Contact.Tag = "required";
            //val_Distribution_frmControls(this.Controls);
        }

        /// <summary>
        /// This method is an event that fires when user clicks to delete a distributor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void del_MD_Dist_btn_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to delete an entire Distributor Section?", "Please Confirm Deletion",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                

                //Remove the distributor from the list at the current index
                _distributorList.RemoveAt(_distributorList_idx);
                //Depending on distributor list count adjust distributor pager controls
                if (_distributorList.Count == 0)
                {
                    _distributorList_idx = 0;   //reset index
                    MD_Dist_lbl.Text = "0 of 0";    //reset label
                    del_MD_Dist_btn.Enabled = false;
                    _distributorList.Clear();
                    //clear field in all sub pagers
                    clearFields("All");
                    distributor_gbx.Enabled = false;
                }
                else if (_distributorList.Count == 1)
                {
                    //adjust pager elements for a list of 1
                    pgD_MD_Dist_btn.Visible = false;
                    pgU_MD_Dist_btn.Visible = false;
                    _distributorList_idx = 0;
                    //Load the next distributor in the list
                    bind_MD_Dist_Field(_distributorList[_distributorList_idx]);
                    distributor_gbx.Enabled = true;
                }
                else
                {
                    //Adjust index and load next distributor in the list
                    if (_distributorList_idx > 0)
                    {
                        _distributorList_idx--;
                    }
                    bind_MD_Dist_Field(_distributorList[_distributorList_idx]);
                    distributor_gbx.Enabled = true;
                }
                //Adjust controls in sub pagers
                distributor_Contact.adjustRPControl(_distributorList.Count);
                adjustPagers(MD_Format, _distributionFormat);
                adjustPagers(MD_SOP, _standardOrderProcess);
                adjustPagers(MD_DTO, _digitalTransferOptions);
            }
        }

        /// <summary>
        /// This Method is fired when the user clicks the page down button for the distributor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pgD_MD_Dist_Click(object sender, EventArgs e)
        {
            //If the index is currently at the bottom of the list adjust pager controls
            //Otherwise save current vales and page down
            if (_distributorList_idx == 0)
            {
                pgD_MD_Dist_btn.Enabled = false;
                pgU_MD_Dist_btn.Focus();
            }
            else
            {
                //Save current values
                bind_MD_Dist_Class(_distributorList[_distributorList_idx]);
                _distributorList_idx--;     //decrease the index
                pgU_MD_Dist_btn.Enabled = true;
                //bind values of the next distributor to controls
                bind_MD_Dist_Field(_distributorList[_distributorList_idx]);
            }
        }

        /// <summary>
        /// This method fires the page up event for the distribution pager
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pgU_MD_Dist_Click(object sender, EventArgs e)
        {
            //If already to the top of the list adjust pager
            //otherwise save current distributor and display the next
            if (_distributorList_idx >= _distributorList.Count - 1)
            {
                pgU_MD_Dist_btn.Enabled = false;
                pgD_MD_Dist_btn.Focus();
            }
            else
            {
                //Save current distributor
                bind_MD_Dist_Class(_distributorList[_distributorList_idx]);
                _distributorList_idx++;     //increase the index
                pgD_MD_Dist_btn.Enabled = true;
                //Display the next distributor
                bind_MD_Dist_Field(_distributorList[_distributorList_idx]);
            }
        }

        /// <summary>
        /// This method binds the current values in the distributor contorls (sub-pagers) to the class
        /// </summary>
        /// <param name="dist"></param>
        private void bind_MD_Dist_Class(MD_Distributor dist)
        {
            //If there is a distributor contact save to distributor class
            if (distributor_Contact.CI_ResponsiblePartyList.Count == 1)
            {
                dist.distributorContact = distributor_Contact.CI_ResponsiblePartyList[0];
                
            }
            //If there is a distributor Formatt bind in the MD_Format pager
            if (_distributionFormat.Count != 0)
            {
                bind_MD_Format_Class(_distributionFormat[_distributionFormat_idx]);
            }
            //If there is a distributor digital transfer option call bind in MD_DTO pager
            if (_digitalTransferOptions.Count != 0)
            {
                bind_MD_DTO_Class(_digitalTransferOptions[_digitalTransferOptions_idx]);
            }
            //If ther is a distributor standard order process call bind in MD_SOP pager
            if (_standardOrderProcess.Count != 0)
            {
                bind_MD_SOP_Class(_standardOrderProcess[_standardOrderProcess_idx]);
            }
            //Save sub lists to the class
            dist.distributorFormat__MD_Format = _distributionFormat;
            dist.distributionOrderProcess__MD_StandardOrderProcess = _standardOrderProcess;
            dist.distributorTransferOptions__MD_DigitalTransferOptions = _digitalTransferOptions;
        }

        /// <summary>
        /// This method bind values in class to the distributor lists for contact, format, digital transfer options, and standard order process
        /// </summary>
        /// <param name="dist"></param>
        private void bind_MD_Dist_Field(MD_Distributor dist)
        {
            //clear all field in the distribution user control
            clearFields("All");
            distributor_Contact.reset();    //reset uc_ResponsibleParty control
            //Set pager label
            MD_Dist_lbl.Text = (_distributorList_idx + 1).ToString() + " of " + _distributorList.Count().ToString();
            
            //Distributor contact -- ci_responsibleParty
            //Set up the distributor contact control (uc_ResponsibleParty)
            List<CI_ResponsibleParty> dist_contactList = new List<CI_ResponsibleParty>();
            if(dist.distributorContact != null)
            {
                dist_contactList.Add(dist.distributorContact);
            }
            
            //Bind lists for pagers
           _distributionFormat = dist.distributorFormat__MD_Format;
           _standardOrderProcess = dist.distributionOrderProcess__MD_StandardOrderProcess;
           _digitalTransferOptions = dist.distributorTransferOptions__MD_DigitalTransferOptions;

           //Load add distributor contact info to the distributor_contact control
            distributor_Contact.loadList(dist_contactList);
            distributor_Contact.adjustRPControl(_distributorList.Count);
            //Call load methods for each pager, and call method to adjustPagers
            _distributionFormat = dist.distributorFormat__MD_Format;
            _standardOrderProcess = dist.distributionOrderProcess__MD_StandardOrderProcess;
            _digitalTransferOptions = dist.distributorTransferOptions__MD_DigitalTransferOptions;

            //_distributionFormat_idx = 0;
            load_MD_format();
            adjustPagers(MD_Format, _distributionFormat);
            load_MD_SOP();
            adjustPagers(MD_SOP, _standardOrderProcess);
            load_MD_DTO();
            adjustPagers(MD_DTO, _digitalTransferOptions);

        }

        #endregion 
        //MD_Format region contains the events for the elements that control paging through formats for each distributor
        #region MD_Format Pager Events

        /// <summary>
        /// This method fire when the user clicks to add a distribution format for a distributor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Add_MD_Format_Click(object sender, EventArgs e)
        {
            MD_Format md_format = new MD_Format();
            //Adjust pager depending on count
            if (_distributionFormat.Count() == 0)
            {
                _distributionFormat = new List<MD_Format>();
                _distributionFormat_idx = 0;
                _distributionFormat.Add(md_format);
            }
            else
            {
                bind_MD_Format_Class(_distributionFormat[_distributionFormat_idx]);
                _distributionFormat.Add(md_format);
                //_distributionFormat_idx++;
                _distributionFormat_idx = _distributionFormat.Count - 1;
                
            }
            //Adjust pager and bind from class to controls
            adjustPagers(MD_Format, _distributionFormat);
            bind_MD_format_Fields( _distributionFormat[_distributionFormat_idx]);
        }

        /// <summary>
        /// This Method fires when user clicks to delete a distribution format for a distributor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void del_MD_Format_btn_Click(object sender, EventArgs e)
        {
            //remove the current MD_Format from the list
            _distributionFormat.RemoveAt(_distributionFormat_idx);
            if (_distributionFormat.Count == 0)
            {
                _distributionFormat_idx = 0;
                _distributionFormat.Clear();
                MD_format_lbl.Text = "0 of 0";
                //delete all fields
                clearFields("MD_Format");
            }
            else if (_distributionFormat.Count == 1)
            {
                _distributionFormat_idx = 0;
                bind_MD_format_Fields(_distributionFormat[_distributionFormat_idx]);
            }
            else
            {
                if (_distributionFormat_idx > 0)
                {
                    _distributionFormat_idx--;
                }
                bind_MD_format_Fields(_distributionFormat[_distributionFormat_idx]);
            }
            //Adjust MD_Format pager controls
            adjustPagers(MD_Format, _distributionFormat);
        }

        /// <summary>
        /// This method fired when user clicks to page down in the distribution format pager
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pgD_MD_Format_btn_Click(object sender, EventArgs e)
        {
            if (_distributionFormat_idx == 0)
            {
                pgD_MD_Format_btn.Enabled = false;
                pgU_MD_Format_btn.Focus();
            }
            else
            {
                //Bind currnet format values to class
                bind_MD_Format_Class(_distributionFormat[_distributionFormat_idx]);
                _distributionFormat_idx--;
                pgU_MD_Format_btn.Enabled = true;
                //Bind new value to controls
                bind_MD_format_Fields(_distributionFormat[_distributionFormat_idx]);
            }
        }

        /// <summary>
        /// This method fires when user clicks to page up in the distribution format pager
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pgU_MD_Format_btn_Click(object sender, EventArgs e)
        {
            if (_distributionFormat_idx >= _distributionFormat.Count - 1)
            {
                pgU_MD_Format_btn.Enabled = false;
                pgD_MD_Format_btn.Focus();
            }
            else
            {
                //Bind current values to class
                bind_MD_Format_Class(_distributionFormat[_distributionFormat_idx]);
                _distributionFormat_idx++;  //Increase index
                pgD_MD_Format_btn.Enabled = true;
                //Bind new values to controls
                bind_MD_format_Fields(_distributionFormat[_distributionFormat_idx]);
            }
        }

        /// <summary>
        /// This method binds properties from MD_Format class to associated MD_Format controls.
        /// </summary>
        /// <param name="dist"></param>
        private void bind_MD_format_Fields(MD_Format dist)
        {
            //Set MD_format pager label
            MD_format_lbl.Text = (_distributionFormat_idx + 1).ToString() + " of " + _distributionFormat.Count().ToString(); 

            //Bind
            md_format_name_txt.Text = dist.name;
            md_format_version_txt.Text = dist.version;
            md_format_AmendmentNumber_txt.Text = dist.amendmentNumber;
            md_format_Specification_txt.Text = dist.specification;
            md_format_decompressionTechnique_txt.Text = dist.fileDecompressionTechnique;

        }

        /// <summary>
        /// This method binds values from MD_Format controls to their associated class properites
        /// </summary>
        /// <param name="data"></param>
        private void bind_MD_Format_Class(MD_Format data)
        {
            //Bind
            data.name = md_format_name_txt.Text;
            data.version = md_format_version_txt.Text;
            data.amendmentNumber = md_format_AmendmentNumber_txt.Text;
            data.specification = md_format_Specification_txt.Text;
            data.fileDecompressionTechnique = md_format_decompressionTechnique_txt.Text;
        }

        /// <summary>
        /// This method loads an MD_format object into the pager
        /// </summary>
        private void load_MD_format()
        {
            _distributionFormat_idx = 0;

            if (_distributionFormat.Count >= 1)
            {
                bind_MD_format_Fields(_distributionFormat[_distributionFormat_idx]);
            } 
        }

       

        #endregion


        #region MD_StandardOrderProcess pager events

        private void add_md_SOP_Click(object sender, EventArgs e)
        {
            MD_StandardOrderProcess md_sop = new MD_StandardOrderProcess();
            if (_standardOrderProcess == null || _standardOrderProcess.Count == 0)
            {
                _standardOrderProcess = new List<MD_StandardOrderProcess>();
                _standardOrderProcess_idx = 0;
                _standardOrderProcess.Add(md_sop);
                //enable delete button
                //del_MD_SOP_btn.Enabled = true;
            }
            else
            {
                bind_MD_SOP_Class(_standardOrderProcess[_standardOrderProcess_idx]);
                //enable pager buttons
                //pgD_MD_SOP_btn.Visible = true;
                //pgU_MD_SOP_btn.Visible = true;

                //bindToClass(incomingRPList[incomingRPListIndex]);
                _standardOrderProcess.Add(md_sop);
                //_distributionFormat_idx++;
                _standardOrderProcess_idx = _standardOrderProcess.Count - 1;

            }
            adjustPagers(MD_SOP, _standardOrderProcess);
            bind_MD_SOP_Fields(_standardOrderProcess[_standardOrderProcess_idx]);
            
            //expand_MD_SOP_btn.Enabled = true;
        }

        private void bind_MD_SOP_Fields(MD_StandardOrderProcess md_sop)
        {
            MD_SOP_lbl.Text = (_standardOrderProcess_idx + 1).ToString() + " of " + _standardOrderProcess.Count().ToString();

            md_SOP_Fees_txt.Text = md_sop.fees;
            md_SOP_AvailableDate_txt.Text = md_sop.plannedAvailableDateTime;
            md_SOP_Ordering_txt.Text = md_sop.orderingInstructions;
            md_SOP_Turnaround_txt.Text = md_sop.turnaround;
        }

        private void bind_MD_SOP_Class(MD_StandardOrderProcess data)
        {
            data.fees = md_SOP_Fees_txt.Text;
            data.plannedAvailableDateTime = md_SOP_AvailableDate_txt.Text;
            data.orderingInstructions = md_SOP_Ordering_txt.Text;
            data.turnaround = md_SOP_Turnaround_txt.Text;
        }

        private void del_MD_SOP_Click(object sender, EventArgs e)
        {
            _standardOrderProcess.RemoveAt(_standardOrderProcess_idx);
            if (_standardOrderProcess.Count == 0)
            {
                _standardOrderProcess_idx = 0;
                _standardOrderProcess.Clear();
                //_standardOrderProcess = null;
                MD_SOP_lbl.Text = "0 of 0";
                clearFields("MD_SOP");
                //del_MD_SOP_btn.Enabled = false;
            }
            else if (_standardOrderProcess.Count == 1)
            {
                //pgD_MD_SOP_btn.Visible = false;
                //pgU_MD_SOP_btn.Visible = false;
                _standardOrderProcess_idx = 0;
                bind_MD_SOP_Fields(_standardOrderProcess[_standardOrderProcess_idx]);
            }
            else
            {
                if (_standardOrderProcess_idx > 0)
                {
                    _standardOrderProcess_idx--;
                }
                bind_MD_SOP_Fields(_standardOrderProcess[_standardOrderProcess_idx]);
            }
            adjustPagers(MD_SOP, _standardOrderProcess);
        }

        private void pgU_MD_SOP_Click(object sender, EventArgs e)
        {
            if (_standardOrderProcess_idx >= _standardOrderProcess.Count - 1)
            {
                pgU_MD_SOP_btn.Enabled = false;
                pgD_MD_SOP_btn.Focus();
            }
            else
            {
                bind_MD_SOP_Class(_standardOrderProcess[_standardOrderProcess_idx]);
                _standardOrderProcess_idx++;
                pgD_MD_SOP_btn.Enabled = true;
                bind_MD_SOP_Fields(_standardOrderProcess[_standardOrderProcess_idx]);
            }
        }

        private void pgD_MD_SOP_Click(object sender, EventArgs e)
        {
            if (_standardOrderProcess_idx == 0)
            {
                pgD_MD_SOP_btn.Enabled = false;
                pgU_MD_SOP_btn.Focus();
            }
            else
            {
                bind_MD_SOP_Class(_standardOrderProcess[_standardOrderProcess_idx]);
                _standardOrderProcess_idx--;
                pgU_MD_SOP_btn.Enabled = true;
                bind_MD_SOP_Fields(_standardOrderProcess[_standardOrderProcess_idx]);
            }
        }

        private void load_MD_SOP()
        {
            _standardOrderProcess_idx = 0;

            if (_standardOrderProcess.Count >= 1)
            {
                bind_MD_SOP_Fields(_standardOrderProcess[_standardOrderProcess_idx]);
            }
            //_standardOrderProcess_idx = 0;
            //if (_standardOrderProcess.Count() < 1)
            //{
            //    pgU_MD_SOP_btn.Visible = false;
            //    pgD_MD_SOP_btn.Visible = false;
            //    del_MD_SOP_btn.Enabled = false;
            //    MD_SOP_lbl.Text = "0 of 0";
            //}
            //else if (_standardOrderProcess.Count() == 1)
            //{
            //    del_MD_SOP_btn.Enabled = true;
            //    bind_MD_SOP_Fields(_standardOrderProcess[_standardOrderProcess_idx]);
            //}
            //else if (_standardOrderProcess.Count() > 1)
            //{
            //    pgU_MD_SOP_btn.Visible = true;
            //    pgD_MD_SOP_btn.Visible = true;
            //    del_MD_SOP_btn.Enabled = true;
            //    bind_MD_SOP_Fields(_standardOrderProcess[_standardOrderProcess_idx]);
            //}
        }

        private void available_dtp_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker ctrl = (DateTimePicker)sender;
            md_SOP_AvailableDate_txt.Text = ctrl.Value.ToString("yyyy-MM-dd");
            //tbox.Text = ctrl.Value.ToString("yyyy-MM-dd");
        }

        private void availabelDate_clear_btn_Click(object sender, EventArgs e)
        {
            md_SOP_AvailableDate_txt.Clear();
        }

        #endregion


        #region MD_digitalTransferOptions pager events

        private void add_DTO_Click(object sender, EventArgs e)
        {
            add_DTO();
                           
        }
        private void add_DTO()
        {
            MD_DigitalTransferOptions md_DTO = new MD_DigitalTransferOptions();
            if (_digitalTransferOptions.Count == 0)
            {
                _digitalTransferOptions = new List<MD_DigitalTransferOptions>();
                _digitalTransferOptions_idx = 0;
                _digitalTransferOptions.Add(md_DTO);
            }
            else
            {
                bind_MD_DTO_Class(_digitalTransferOptions[_digitalTransferOptions_idx]);
                _digitalTransferOptions.Add(md_DTO);
                //_distributionFormat_idx++;
                _digitalTransferOptions_idx = _digitalTransferOptions.Count - 1;
            }
            adjustPagers(MD_DTO, _digitalTransferOptions);
            bind_MD_DTO_Fields(_digitalTransferOptions[_digitalTransferOptions_idx]); 
        }

        private void del_MD_DTO_Click(object sender, EventArgs e)
        {
            _digitalTransferOptions.RemoveAt(_digitalTransferOptions_idx);
            if (_digitalTransferOptions.Count == 0)
            {
                _digitalTransferOptions_idx = 0;
                //_digitalTransferOptions = null;
                MD_DTO_lbl.Text = "0 of 0";
                clearFields("MD_DTO");
                //del_MD_DTO_btn.Enabled = false;
            }
            else if (_digitalTransferOptions.Count == 1)
            {
                //pgD_MD_DTO_btn.Visible = false;
                //pgU_MD_DTO_btn.Visible = false;
                _digitalTransferOptions_idx = 0;
                bind_MD_DTO_Fields(_digitalTransferOptions[_digitalTransferOptions_idx]);
            }
            else
            {
                if (_digitalTransferOptions_idx > 0)
                {
                    _digitalTransferOptions_idx--;
                }
                bind_MD_DTO_Fields(_digitalTransferOptions[_digitalTransferOptions_idx]);
            }
            adjustPagers(MD_DTO, _digitalTransferOptions);
        }

        private void pgD_MD_DTO_Click(object sender, EventArgs e)
        {
            if (_digitalTransferOptions_idx == 0)
            {
                pgD_MD_DTO_btn.Enabled = false;
                pgU_MD_DTO_btn.Focus();
            }
            else
            {
                bind_MD_DTO_Class(_digitalTransferOptions[_digitalTransferOptions_idx]);
                _digitalTransferOptions_idx--;
                pgU_MD_DTO_btn.Enabled = true;
                bind_MD_DTO_Fields(_digitalTransferOptions[_digitalTransferOptions_idx]);
            }
        }

        private void pgU_MD_DTO_Click(object sender, EventArgs e)
        {
            if (_digitalTransferOptions_idx >= _digitalTransferOptions.Count - 1)
            {
                pgU_MD_DTO_btn.Enabled = false;
                pgD_MD_DTO_btn.Focus();
            }
            else
            {
                bind_MD_DTO_Class(_digitalTransferOptions[_digitalTransferOptions_idx]);
                _digitalTransferOptions_idx++;
                pgD_MD_DTO_btn.Enabled = true;
                bind_MD_DTO_Fields(_digitalTransferOptions[_digitalTransferOptions_idx]);
            }
        }

        private void bind_MD_DTO_Fields(MD_DigitalTransferOptions md_DTO)
        {
           // MD_Dist_lbl.Text = (_distributorList_idx + 1).ToString() + " of " + _distributorList.Count().ToString();
            MD_DTO_lbl.Text = (_digitalTransferOptions_idx + 1).ToString() + " of " + _digitalTransferOptions.Count().ToString();

            md_digitalTransferOptions_UnitsOfDistribution_txt.Text = md_DTO.unitsOfDistribution;
            md_digitalTransferOptions_transferSize_txt.Text = md_DTO.transferSize;
            onLine__CI_OnlineResource__linkage__URL_txt.Text = md_DTO.onLine__CI_OnlineResource__linkage__URL;
            onLine__CI_OnlineResource__protocol_txt.Text = md_DTO.onLine__CI_OnlineResource__protocol; 
            onLine__CI_OnlineResource__applicationProfile_txt.Text = md_DTO.onLine__CI_OnlineResource__applicationProfile;
            onLine__CI_OnlineResource__name_txt.Text = md_DTO.onLine__CI_OnlineResource__name;
            onLine__CI_OnlineResource__description_txt.Text = md_DTO.onLine__CI_OnlineResource__description;
            onLine__CI_OnlineResource__function_txt.Text = md_DTO.onLine__CI_OnlineResource__function;
            offLine__MD_Medium__name_txt.Text = md_DTO.offLine__MD_Medium__name;
            offLine__MD_Medium__density__Real_txt.Text = md_DTO.offLine__MD_Medium__density__Real;
            offLine__MD_Medium__densityUnits_txt.Text = md_DTO.offLine__MD_Medium__densityUnits;
            offLine__MD_Medium__volumes_txt.Text = md_DTO.offLine__MD_Medium__volumes;
            offLine__MD_Medium__mediumFormat_txt.Text = md_DTO.offLine__MD_Medium__mediumFormat;
            offLine__MD_Medium__mediumNode_txt.Text = md_DTO.offLine__MD_Medium__mediumNote;

        }

        private void bind_MD_DTO_Class(MD_DigitalTransferOptions data)
        {
            data.unitsOfDistribution = md_digitalTransferOptions_UnitsOfDistribution_txt.Text;
            data.transferSize = md_digitalTransferOptions_transferSize_txt.Text;

            data.onLine__CI_OnlineResource__linkage__URL = onLine__CI_OnlineResource__linkage__URL_txt.Text;
            data.onLine__CI_OnlineResource__protocol = onLine__CI_OnlineResource__protocol_txt.Text;
            data.onLine__CI_OnlineResource__applicationProfile = onLine__CI_OnlineResource__applicationProfile_txt.Text;
            data.onLine__CI_OnlineResource__name = onLine__CI_OnlineResource__name_txt.Text;
            data.onLine__CI_OnlineResource__description = onLine__CI_OnlineResource__description_txt.Text;
            data.onLine__CI_OnlineResource__function = onLine__CI_OnlineResource__function_txt.Text;

            data.offLine__MD_Medium__name = offLine__MD_Medium__name_txt.Text;
            data.offLine__MD_Medium__density__Real = offLine__MD_Medium__density__Real_txt.Text;
            data.offLine__MD_Medium__densityUnits = offLine__MD_Medium__densityUnits_txt.Text;
            data.offLine__MD_Medium__volumes = offLine__MD_Medium__volumes_txt.Text;
            data.offLine__MD_Medium__mediumFormat = offLine__MD_Medium__mediumFormat_txt.Text;
            //data.offLine__MD_Medium__mediumNode = offLine__MD_Medium__mediumNode_txt.Text;
        }

        private void load_MD_DTO()
        {
            _digitalTransferOptions_idx = 0;

            if (_digitalTransferOptions.Count >= 1)
            {
                bind_MD_DTO_Fields(_digitalTransferOptions[_digitalTransferOptions_idx]);
            }
            //_digitalTransferOptions_idx = 0;
            //if (_digitalTransferOptions.Count() < 1)
            //{
            //    pgU_MD_DTO_btn.Visible = false;
            //    pgD_MD_DTO_btn.Visible = false;
            //    del_MD_DTO_btn.Enabled = false;
            //    MD_DTO_lbl.Text = "0 of 0";
            //}
            //else if (_digitalTransferOptions.Count() == 1)
            //{
            //    del_MD_DTO_btn.Enabled = true;
            //    bind_MD_DTO_Field(_digitalTransferOptions[_digitalTransferOptions_idx]);
            //}
            //else if (_digitalTransferOptions.Count() > 1)
            //{
            //    pgU_MD_DTO_btn.Visible = true;
            //    pgD_MD_DTO_btn.Visible = true;
            //    del_MD_DTO_btn.Enabled = true;
            //    bind_MD_DTO_Field(_digitalTransferOptions[_digitalTransferOptions_idx]);
            //}
        }

        #endregion


        public void resetDist()
        {
            //distributor
            _distributorList_idx = 0;
            _distributorList = new List<MD_Distributor>();
            adjustPagers(MD_Dist, _distributorList);
            add_MD_Dist_btn.Enabled = true;
            //contact
            _distributorContact = null;
            distributor_Contact.reset();
            distributor_Contact.adjustRPControl(0);
            //distribution format
            _distributionFormat_idx = 0;
            _distributionFormat = new List<MD_Format>();
            adjustPagers(MD_Format, _distributionFormat); 
            //Standard Order Process
            _standardOrderProcess_idx = 0;
            _standardOrderProcess = new List<MD_StandardOrderProcess>();
            adjustPagers(MD_SOP, _standardOrderProcess);
            //digital Transfer Options
            _digitalTransferOptions_idx = 0;
            _digitalTransferOptions = new List<MD_DigitalTransferOptions>();
            adjustPagers(MD_DTO, _digitalTransferOptions);

            clearFields("All");
        }

        /// <summary>
        /// This method clear the text in the controls for the given section specified. The section string variable represent the grouping (pager) 
        /// name. For example if the section string variable is set to "MD_Format" control in that section will be cleared.
        /// </summary>
        /// <param name="section"></param>
        private void clearFields(string section)
        {
            if (section == "MD_Format" || section == "All")
            {
                md_format_name_txt.Clear();
                md_format_version_txt.Clear();
                md_format_AmendmentNumber_txt.Clear();
                md_format_Specification_txt.Clear();
                md_format_decompressionTechnique_txt.Clear();
            }
            if (section == "MD_SOP" || section == "All")
            {
                md_SOP_Fees_txt.Clear();
                md_SOP_AvailableDate_txt.Clear();
                md_SOP_Ordering_txt.Clear();
                md_SOP_Turnaround_txt.Clear();
            }
            if (section == "MD_DTO" || section == "All")
            {
                md_digitalTransferOptions_UnitsOfDistribution_txt.Clear();
                md_digitalTransferOptions_transferSize_txt.Clear();

                onLine__CI_OnlineResource__linkage__URL_txt.Clear();
                onLine__CI_OnlineResource__protocol_txt.Clear();
                onLine__CI_OnlineResource__applicationProfile_txt.Clear();
                onLine__CI_OnlineResource__name_txt.Clear();
                onLine__CI_OnlineResource__description_txt.Clear();
                //onLine__CI_OnlineResource__function_txt.Clear();

                offLine__MD_Medium__name_txt.Clear();
                offLine__MD_Medium__density__Real_txt.Clear();
                offLine__MD_Medium__densityUnits_txt.Clear();
                offLine__MD_Medium__volumes_txt.Clear();
                offLine__MD_Medium__mediumFormat_txt.Clear();
                offLine__MD_Medium__mediumNode_txt.Clear();
            }
        }

        /// <summary>
        /// This method is used as the generic event triggered by the expander buttons for each pager they expand and 
        /// collapse the panel that contains the controls for each pager section
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void expand_Click(object sender, EventArgs e)
        {
            Button expand = (Button)sender;
            int expHeight = 210;
            int cHeight = 35;
            if (expand.Name == "expand_MD_DTO_btn")
            {
                if (offline_resource_expandBtn.Text == collapsedSymbol)
                {
                    expHeight = 520 - 160;
                }
                else
                {
                    expHeight = 520;
                    //cHeight = ;
                }
            }
            
            if (expand.Text == collapsedSymbol) //"+")
            {
                expand.Text = expandedSymbol; //"-";
                expand.Parent.Height = expHeight;
                //this.Height = 250;
            }
            else
            {
                expand.Text = collapsedSymbol; // "+";
                expand.Parent.Height = cHeight;
                //this.Height = 35;
            }
        }

        private void offline_resource_expandBtn_Click(object sender, EventArgs e)
        {
            int offlineExpHight = 203;
            int offlinecHight = 65;
            int expHeight = 520;
            int cHeight = 30;

            if (offline_resource_expandBtn.Text == collapsedSymbol) //"+")
            {
                offline_resource_expandBtn.Text = expandedSymbol; //"-";
                offline_resource_expandBtn.Parent.Height = offlineExpHight;
                digitalTransferOptions_pnl.Height = expHeight;
                //this.Height = 250;
            }
            else
            {
                offline_resource_expandBtn.Text = collapsedSymbol; // "+";
                offline_resource_expandBtn.Parent.Height = cHeight;
                digitalTransferOptions_pnl.Height = expHeight - 160;
            }

        }

        /// <summary>
        /// This method is a generic method to adjust the visibility, enable/diable, and reset pager controls based
        /// on the name of the panel that the pager controls are contained and the name of the list associated to that
        /// pager. This method is called regularly when user adds, deletes or pages one of the pagers.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="pager"></param>
        /// <param name="pagerList"></param>
        private void adjustPagers<T>(Panel pager, List<T> pagerList)
        {
            //Check if there
            if (_distributorList.Count == 0)
            {
                pager.Controls["Add_" + pager.Name + "_btn"].Enabled = false;
                pager.Controls[pager.Name + "_lbl"].Text = "0 of 0";
                pager.Controls["del_" + pager.Name + "_btn"].Enabled = false;
                pager.Controls["pgU_" + pager.Name + "_btn"].Visible = false;
                pager.Controls["pgD_" + pager.Name + "_btn"].Visible = false;
                
                if (pager.Name != "MD_Dist")
                {
                    //expand_MD_Format_btn.Enabled = false;
                    Button Expanderbtn = (Button)this.Controls.Find("expand_" + pager.Name + "_btn", true)[0];
                    Expanderbtn.Enabled = false;
                    Expanderbtn.Text = collapsedSymbol; // "+";
                    Expanderbtn.Parent.Height = 35;
                }

            }
            else
            {
                pager.Controls["Add_" + pager.Name + "_btn"].Enabled = true;
                if (pagerList.Count() < 1)
                {
                    pager.Controls["pgU_" + pager.Name + "_btn"].Visible = false;
                    pager.Controls["pgD_" + pager.Name + "_btn"].Visible = false;
                    pager.Controls["del_" + pager.Name + "_btn"].Enabled = false;
                    pager.Controls[pager.Name + "_lbl"].Text = "0 of 0";
                    if (pager.Name != "MD_Dist")
                    {                        
                        //expand_MD_Format_btn.Enabled = false;
                        Button Expanderbtn = (Button) this.Controls.Find("expand_" + pager.Name + "_btn",true)[0];                        
                        Expanderbtn.Enabled = false;
                        Expanderbtn.Text = collapsedSymbol; //"+";
                        Expanderbtn.Parent.Height = 35;
                    }
                }
                else if (pagerList.Count() == 1)
                {
                    pager.Controls["del_" + pager.Name + "_btn"].Enabled = true;
                    if (pager.Name != "MD_Dist")
                    {
                        //expand_MD_Format_btn.Enabled = false;
                        Button Expanderbtn = (Button)this.Controls.Find("expand_" + pager.Name + "_btn", true)[0];
                        Expanderbtn.Enabled = true;                        
                    }

                }
                else if (pagerList.Count() > 1)
                {
                    pager.Controls["pgU_" + pager.Name + "_btn"].Visible = true;
                    pager.Controls["pgD_" + pager.Name + "_btn"].Visible = true;
                    pager.Controls["del_" + pager.Name + "_btn"].Enabled = true;
                    if (pager.Name != "MD_Dist")
                    {
                        //expand_MD_Format_btn.Enabled = false;
                        Button Expanderbtn = (Button)this.Controls.Find("expand_" + pager.Name + "_btn", true)[0];
                        Expanderbtn.Enabled = true;                        
                    }
                }
            }
        }

        #region Validation

        private void distribution_Validating(object sender, CancelEventArgs e)
        {
            Control ctrl = (Control)sender;
            Dist_Validating(ctrl);
        }

        private void Dist_Validating(Control ctrl)
        {
            string tag = (ctrl.Tag != null) ? ctrl.Tag.ToString() : "";
            errorProvider_Distribution.BlinkStyle = ErrorBlinkStyle.NeverBlink;

            if (tag == "required")
            {
                if (ctrl.GetType() == typeof(TextBox))
                {
                    if (ctrl.Text == string.Empty)
                    {

                        errorProvider_Distribution.SetError(ctrl, "This is a required Field");
                    }
                    else
                    {
                        errorProvider_Distribution.SetError(ctrl, "");
                    }
                }
                else if (ctrl.GetType() == typeof(ComboBox))
                {
                    ComboBox cbo = (ComboBox)ctrl;
                    if (cbo.SelectedIndex == -1)
                    {
                        errorProvider_Distribution.SetError(ctrl, "This is a required Field");
                    }
                    else
                    {
                        errorProvider_Distribution.SetError(ctrl, "");
                    }
                }
                
            }
            else if (tag.Contains("required"))
            {
                //get required control count
                string requiredCount;
                int index = ctrl.Tag.ToString().IndexOf("required");
                string cleanPath = (index < 0)
                    ? ctrl.Tag.ToString()
                    : ctrl.Tag.ToString().Remove(index, "required".Length);
                requiredCount = (cleanPath != null) ? cleanPath : "";
                //Console.WriteLine(requiredCount.ToString());

                if (requiredCount != "")
                {
                    int count = 0;
                    Control parent = ctrl.Parent;
                    foreach (Control c in parent.Controls)
                    {
                        if (c.Tag != null)
                        {
                            if (c.Tag.ToString() == tag && c.Text != string.Empty)
                            {
                                count++;
                            }
                        }
                    }
                    if (count >= Convert.ToInt16(requiredCount))
                    {
                        errorProvider_Distribution.SetError(parent, "");
                    }
                    else
                    {
                        errorProvider_Distribution.SetError(parent, "Need at least " + requiredCount.ToString());
                    }
                }
            }

        }

        public void val_Distribution_frmControls(Control.ControlCollection cControls)
        {
            foreach (Control c in cControls)
            {
                if (c.HasChildren)
                {
                    if (c.GetType() == typeof(uc_ResponsibleParty))
                    {
                        Dist_Validating(c);
                        uc_ResponsibleParty rp = (uc_ResponsibleParty)c;
                        rp.val_RP_frmControls(rp.Controls);
                    }
                    else
                    {
                        Dist_Validating(c);
                        val_Distribution_frmControls(c.Controls);
                    }

                }
                else
                {
                    //Console.WriteLine(c.Name);
                    if (c.Tag != null)
                    {
                        Dist_Validating(c);
                    }
                }
            }
        }

        #endregion

        private void distributor_gbx_Leave(object sender, EventArgs e)
        {
            
            
        }

        private void flowLayoutPanel6_Leave(object sender, EventArgs e)
        {

        }

        private void uc_distribution_lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Utils1.HelpSeeker("t3_distinfo.html", ref Utils1.globalHelpProc);
        }

        private void genericOpenHelpFromLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Windows.Forms.LinkLabel helpLink = (System.Windows.Forms.LinkLabel)sender;
            if (helpLink.Tag != null)
            {
                string n = helpLink.Tag.ToString(); //helpLink.Name.ToString().Replace("_lbl", "");


                //MessageBox.Show(n);
                Utils1.HelpSeeker("/" + n, ref Utils1.globalHelpProc);
            }
            //else { Utils1.HelpSeeker("/Help_Main.html", ref Utils1.globalHelpProc); }

        }

        private void genericSpaciousEntryForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Control genericControl = (Control)sender;


            //TextBox clickedTextBox = (TextBox)sender;

            //LinkLabel tbxLinkLabel
            string tbxName = genericControl.Name; //clickedTextBox.Name;            
            tbxName = tbxName.Replace("_txt", "");
            string tbxText = genericControl.Text; //clickedTextBox.Text;
            Control[] foundControl = this.Controls.Find(tbxName + "_lbl", true);
            if (foundControl.Length > 0)
            {
                //LinkLabel tbxLabel = (LinkLabel)foundControl[0];

                tbxName = foundControl[0].Text;
            }

            if (Utils1.spaciousInputBox(tbxName, tbxName, ref tbxText) == DialogResult.OK)
            {
                //clickedTextBox.Text = tbxText;
                genericControl.Text = tbxText;
            }

        }

    }
}
