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
    
    public partial class uc_ResponsibleParty : UserControl
    {
        private List<CI_ResponsibleParty> _incomingRPList;
        private int incomingRPListIndex;

        //Expanding
        private int expandHeight;
        private int collapseHeight;
        private string expandedSymbol = "\u25BC"; //25BC //25E2
        private string collapsedSymbol = "\u25B6";
        private string _validation_modeEmeLt;
       

        //[Bindable(false)]
        //[EditorBrowsable(EditorBrowsableState.Always)]
        //[Browsable(true)]
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        //public string myString { get; set; }

        [Bindable(false)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string mylabel
        {
            get
            {
                return uc_ResponsibleParty_lbl.Text;
            }
            set
            {
                uc_ResponsibleParty_lbl.Text = value;
            }
        }
        public string rp_mode { get; set; }
        public string validation_modeEmeLt
        {
            get { return _validation_modeEmeLt; }
            set
            {
                _validation_modeEmeLt = value;
                setValidationModeTags();
            }
        }

        public List<CI_ResponsibleParty> CI_ResponsiblePartyList
        {
            get
            {
                //Call bindToClass here and pass in the index of the RP visible in the form to ensure it gets saved.
                //binds the current responsibleParty visible in repeater to the class when save is called in pageController.
                if (_incomingRPList != null)
                {
                    if (_incomingRPList.Count != 0)
                    {
                        bindToClass(_incomingRPList[incomingRPListIndex]);
                    }
                }
                //else { _incomingRPList = new List<CI_ResponsibleParty>(); }
                return _incomingRPList;
            }
            set { _incomingRPList = value; }
        }        

        //public List<CI_ResponsibleParty> contact_CI_ResponsibleParty
        //{
        //    get { return contactRpSection; }
        //    set { contactRpSection = value; }
        //}
        // private CI_ResponsibleParty incomingCI_ResponsibleParty;

        public uc_ResponsibleParty()
        {
            InitializeComponent();

            rp_expander_btn.Text = collapsedSymbol;            
            CI_ContactExpand_btn.Text = collapsedSymbol;

            

        }

        private void bindToFields(CI_ResponsibleParty incomingCIRP)
        {
            pagerLbl.Text = (incomingRPListIndex + 1).ToString() + " of " + _incomingRPList.Count;

            if (incomingCIRP.role == null)
                role.SelectedIndex = -1;
            else
            {
                role.SelectedItem = incomingCIRP.role;
            }
            if (incomingCIRP.dcatProgramCode == null)
            {
                dcatProgramCode.SelectedValue = -1;
            }
            else
            {
                dcatProgramCode.SelectedValue = incomingCIRP.dcatProgramCode;
            }
            individualName.Text = incomingCIRP.individualName;
            organisationName.Text = incomingCIRP.organisationName;
            positionName.Text = incomingCIRP.positionName;
            contactInfo__CI_Contact__address__CI_Address__deliveryPoint.Text = incomingCIRP.contactInfo__CI_Contact__address__CI_Address__deliveryPoint;
            contactInfo__CI_Contact__address__CI_Address__city.Text = incomingCIRP.contactInfo__CI_Contact__address__CI_Address__city;
            contactInfo__CI_Contact__address__CI_Address__administrativeArea.Text = incomingCIRP.contactInfo__CI_Contact__address__CI_Address__administrativeArea;
            contactInfo__CI_Contact__address__CI_Address__postalCode.Text = incomingCIRP.contactInfo__CI_Contact__address__CI_Address__postalCode;
            contactInfo__CI_Contact__address__CI_Address__county.Text = incomingCIRP.contactInfo__CI_Contact__address__CI_Address__country;
            contactInfo__CI_Contact__phone__CI_Telephone__voice.Text = incomingCIRP.contactInfo__CI_Contact__phone__CI_Telephone__voice;
            contactInfo__CI_Contact__phone__CI_Telephone__facsimile.Text = incomingCIRP.contactInfo__CI_Contact__phone__CI_Telephone__facsimile;
            contactInfo__CI_Contact__address__CI_Address__electronicMailAddress.Text = incomingCIRP.contactInfo__CI_Contact__address__CI_Address__electronicMailAddress;
            contactInfo__CI_Contact__onlineResource__CI_OnlineResource__linkage.Text = incomingCIRP.contactInfo__CI_Contact__onlineResource__CI_OnlineResource__linkage;
            if (incomingCIRP.contactInfo__CI_Contact__onlineResource__CI_OnlineResource__function == null)
            {
                contactInfo__CI_Contact__onlineResource__CI_OnlineResource__functionCode.SelectedIndex = -1;
            }
            else
            {
                contactInfo__CI_Contact__onlineResource__CI_OnlineResource__functionCode.SelectedItem =
                    incomingCIRP.contactInfo__CI_Contact__onlineResource__CI_OnlineResource__function;
            }
            contactInfo__CI_Contact__hoursOfService.Text = incomingCIRP.contactInfo__CI_Contact__hoursOfService;
            contactInfo__CI_Contact__contactInstructions.Text = incomingCIRP.contactInfo__CI_Contact__contactInstructions;
            val_RP_frmControls(this.Controls);

        }

        private void bindToClass(CI_ResponsibleParty outgoingCIRP)
        {

            if (role.SelectedItem != null)
            {
                outgoingCIRP.role = role.SelectedItem.ToString();
            }
            outgoingCIRP.dcatProgramCode = getSelectedProgramCode(dcatProgramCode.Text);
            outgoingCIRP.individualName = individualName.Text;
            outgoingCIRP.organisationName = organisationName.Text;
            outgoingCIRP.positionName = positionName.Text;
            outgoingCIRP.contactInfo__CI_Contact__address__CI_Address__deliveryPoint = contactInfo__CI_Contact__address__CI_Address__deliveryPoint.Text;
            outgoingCIRP.contactInfo__CI_Contact__address__CI_Address__city = contactInfo__CI_Contact__address__CI_Address__city.Text;
            outgoingCIRP.contactInfo__CI_Contact__address__CI_Address__administrativeArea = contactInfo__CI_Contact__address__CI_Address__administrativeArea.Text;
            outgoingCIRP.contactInfo__CI_Contact__address__CI_Address__postalCode = contactInfo__CI_Contact__address__CI_Address__postalCode.Text;
            outgoingCIRP.contactInfo__CI_Contact__address__CI_Address__country = contactInfo__CI_Contact__address__CI_Address__county.Text;
            outgoingCIRP.contactInfo__CI_Contact__phone__CI_Telephone__voice = contactInfo__CI_Contact__phone__CI_Telephone__voice.Text;
            outgoingCIRP.contactInfo__CI_Contact__phone__CI_Telephone__facsimile = contactInfo__CI_Contact__phone__CI_Telephone__facsimile.Text;
            outgoingCIRP.contactInfo__CI_Contact__address__CI_Address__electronicMailAddress = contactInfo__CI_Contact__address__CI_Address__electronicMailAddress.Text;
            outgoingCIRP.contactInfo__CI_Contact__onlineResource__CI_OnlineResource__linkage = contactInfo__CI_Contact__onlineResource__CI_OnlineResource__linkage.Text;
            if (contactInfo__CI_Contact__onlineResource__CI_OnlineResource__functionCode.SelectedItem != null)
            {
                outgoingCIRP.contactInfo__CI_Contact__onlineResource__CI_OnlineResource__function =
                    contactInfo__CI_Contact__onlineResource__CI_OnlineResource__functionCode.SelectedItem.ToString();
            }
            outgoingCIRP.contactInfo__CI_Contact__hoursOfService = contactInfo__CI_Contact__hoursOfService.Text;
            outgoingCIRP.contactInfo__CI_Contact__contactInstructions = contactInfo__CI_Contact__contactInstructions.Text;
            CI_ResponsiblePartyList = _incomingRPList;

        }
   

        private void uc_ResponsibleParty_Load(object sender, EventArgs e)
        {
            
            //MessageBox.Show("RP Load");
            expandHeight = 510;
            //intermediateHeight
            
            collapseHeight = 35;
            
            if (rp_mode != "distribution")            
            {
                 addRP_Btn.Enabled = true;
            }
            
            //if (Utils1.emeDataSet == null)
            //{
            //    Utils1.setEmeDataSets();
            //}

            //if (dcatProgramCode.DataSource == null)
            //{
            //    DataTable subTable2 = //new DataTable();
            //    DataTable subTable2 = Utils1.emeDataSet.Tables["ProgramCode"].Select().CopyToDataTable();
            //    dcatProgramCode.DataSource = subTable2;
            //    dcatProgramCode.DisplayMember = "programName";
            //    dcatProgramCode.ValueMember = "pCode";
            //}
        }


        public void loadList(List<CI_ResponsibleParty> CI_ResponsiblePartyList)
        {
            //reset();
            bindControlsToEMEdatabase();
            
            _incomingRPList = CI_ResponsiblePartyList;
            //MessageBox.Show(_incomingRPList.Count().ToString());
            if (_incomingRPList.Count < 1)
            {
                pagerUpBtn.Visible = false;
                pagerDownBtn.Visible = false;
                deleteRP_Btn.Enabled = false;
                addRP_Btn.Enabled = true;
                panel3.Enabled = false;
                rp_expander_btn.Enabled = false;
                rp_expander_btn.Text = collapsedSymbol;
                this.Height = 35;
            }
            else if (_incomingRPList.Count == 1)
            {
                deleteRP_Btn.Enabled = true;
                incomingRPListIndex = 0;
                bindToFields(_incomingRPList[incomingRPListIndex]);
                panel3.Enabled = true;
                rp_expander_btn.Enabled = true;
            }
            else if (_incomingRPList.Count > 1)
            {
                pagerUpBtn.Visible = true;
                pagerDownBtn.Visible = true;
                deleteRP_Btn.Enabled = true;
                incomingRPListIndex = 0;
                bindToFields(_incomingRPList[incomingRPListIndex]);
                panel3.Enabled = true;
                rp_expander_btn.Enabled = true;
            }

            
        }

        //public void loadList(CI_ResponsibleParty ci_RP)
        //{
        //    if (ci_RP != null)
        //    {
        //        incomingRPList = new List<CI_ResponsibleParty>();
        //        incomingRPList.Add(ci_RP);
        //        //MessageBox.Show(incomingRPList.Count().ToString());

        //        pagerUpBtn.Visible = false;
        //        pagerDownBtn.Visible = false;
        //        deleteRP_Btn.Enabled = false;
        //        addRP_Btn.Enabled = false;

        //        incomingRPListIndex = 0;

        //        bindToFields(ci_RP);
        //    }
        //    else
        //    {
        //        reset();
        //    }

        //}

        public void reset()
        {
            _incomingRPList = null;
            incomingRPListIndex = 0;
            pagerLbl.Text = "0 of 0";
            role.SelectedIndex = -1;
            dcatProgramCode.SelectedIndex = -1;
            individualName.Text = "";
            organisationName.Text = "";
            positionName.Text = "";
            contactInfo__CI_Contact__address__CI_Address__deliveryPoint.Text = "";
            contactInfo__CI_Contact__address__CI_Address__city.Text = "";
            contactInfo__CI_Contact__address__CI_Address__administrativeArea.Text = "";
            contactInfo__CI_Contact__address__CI_Address__postalCode.Text = "";
            contactInfo__CI_Contact__address__CI_Address__county.Text = "";
            contactInfo__CI_Contact__phone__CI_Telephone__voice.Text = "";
            contactInfo__CI_Contact__phone__CI_Telephone__facsimile.Text = "";
            contactInfo__CI_Contact__address__CI_Address__electronicMailAddress.Text = "";
            contactInfo__CI_Contact__onlineResource__CI_OnlineResource__linkage.Text = "";
            contactInfo__CI_Contact__onlineResource__CI_OnlineResource__functionCode.Text = "";
            contactInfo__CI_Contact__onlineResource__CI_OnlineResource__functionCode.SelectedIndex = -1;
            contactInfo__CI_Contact__hoursOfService.Text = "";
            contactInfo__CI_Contact__contactInstructions.Text = "";
            //bindToFields(incomingRPList[incomingRPListIndex]);
            comboBox1.SelectedIndex = -1;
            //comboBox1.Visible = false;
            deleteRP_Btn.Enabled = false;
            addRP_Btn.Enabled = true;
            if (rp_mode == "distribution")
            {
                addRP_Btn.Enabled = false;
            }
            panel3.Enabled = false;
            rp_expander_btn.Enabled = false;
            rp_expander_btn.Text = collapsedSymbol;
            this.Height = 35;
            pagerDownBtn.Visible = false;
            pagerUpBtn.Visible = false;
           
        }

        /// <summary>
        /// Use to control behavior while inside a distribution user control.  This enables and disables buttons.
        /// </summary>
        /// <param name="distributorCount"></param>
        public void adjustRPControl(int distributorCount)
        {
            
            if (distributorCount < 1)
            {
               // MessageBox.Show("made it");
                reset();
                //addRP_Btn.Enabled = false;
                deleteRP_Btn.Enabled = false;
                panel3.Enabled = false;
                rp_expander_btn.Enabled = false;
                this.Height = 35;
            }
            else
            {
                
                if (_incomingRPList.Count < 1)
                {
                    //User should be able to add one contact
                    addRP_Btn.Enabled = true;
                    deleteRP_Btn.Enabled = false;
                    this.Height = 35;
                }
                else
                {
                    //Only get one contact, so they should not be able to add another if
                    //one already exists
                    addRP_Btn.Enabled = false;
                    deleteRP_Btn.Enabled = true;
                }
                
            }
            //button2.Text = "+";
            //this.Height = collapseHeight;

        }

        private void pagerDownBtn_Click(object sender, EventArgs e)
        {

            if (incomingRPListIndex == 0)
            {
                pagerDownBtn.Enabled = false;
                pagerUpBtn.Focus();
                //panel3.Enabled = false; 
            }
            else
            {
                bindToClass(_incomingRPList[incomingRPListIndex]);

                incomingRPListIndex--;
                pagerUpBtn.Enabled = true;
                bindToFields(_incomingRPList[incomingRPListIndex]);
                panel3.Enabled = true;
                rp_expander_btn.Enabled = true;
            }
        }

        private void pagerUpBtn_Click(object sender, EventArgs e)
        {

            if (incomingRPListIndex >= _incomingRPList.Count - 1)
            {
                pagerUpBtn.Enabled = false;
                pagerDownBtn.Focus();
                //panel3.Enabled = false;
            }
            else
            {
                bindToClass(_incomingRPList[incomingRPListIndex]);
                incomingRPListIndex++;
                pagerDownBtn.Enabled = true;
                bindToFields(_incomingRPList[incomingRPListIndex]);
                //panel3.Enabled = true;
            }

        }

        private void addRP_Btn_Click(object sender, EventArgs e)
        {
            
            //CI_ResponsibleParty newRP = new CI_ResponsibleParty();
            CI_ResponsibleParty ci_RP = new CI_ResponsibleParty();

            if (_incomingRPList == null || _incomingRPList.Count == 0)
            { 
                _incomingRPList = new List<CI_ResponsibleParty>();
                incomingRPListIndex = 0;
                _incomingRPList.Add(ci_RP);
                //enable delete button
                deleteRP_Btn.Enabled = true;
                if (rp_mode == "distribution")
                {
                    addRP_Btn.Enabled = false;
                    //rp_expander_btn.Text = expandedSymbol; //"-";
                    //this.Height = 200;
                } 
            }
            else
            {
                if (rp_mode == "distribution")
                {
                    MessageBox.Show("Only allowed one");
                }
                else
                {
                    //enable pager buttons
                    pagerDownBtn.Visible = true;
                    pagerUpBtn.Visible = true;

                    bindToClass(_incomingRPList[incomingRPListIndex]);
                    _incomingRPList.Add(ci_RP);
                    incomingRPListIndex++;
                    incomingRPListIndex = _incomingRPList.Count - 1;
                }
            }

            panel3.Enabled = true;
            rp_expander_btn.Enabled = true;
            bindToFields(_incomingRPList[incomingRPListIndex]);
            Control ctrl = (Control)sender;
            rp_Validating(ctrl);
            
            bindControlsToEMEdatabase();
        }

        private void deleteRP_Btn_Click(object sender, EventArgs e)
        {
            _incomingRPList.RemoveAt(incomingRPListIndex);
            if (_incomingRPList.Count == 0)
            {
                incomingRPListIndex = 0;
                _incomingRPList.Clear();
                pagerLbl.Text = "0 of 0";
                role.SelectedIndex = -1;
                dcatProgramCode.SelectedIndex = -1;
                individualName.Text = "";
                organisationName.Text = "";
                positionName.Text = "";
                contactInfo__CI_Contact__address__CI_Address__deliveryPoint.Text = "";
                contactInfo__CI_Contact__address__CI_Address__city.Text = "";
                contactInfo__CI_Contact__address__CI_Address__administrativeArea.Text = "";
                contactInfo__CI_Contact__address__CI_Address__postalCode.Text = "";
                contactInfo__CI_Contact__address__CI_Address__county.Text = "";
                contactInfo__CI_Contact__phone__CI_Telephone__voice.Text = "";
                contactInfo__CI_Contact__phone__CI_Telephone__facsimile.Text = "";
                contactInfo__CI_Contact__address__CI_Address__electronicMailAddress.Text = "";
                contactInfo__CI_Contact__onlineResource__CI_OnlineResource__linkage.Text = "";
                //contactInfo__CI_Contact__onlineResource__CI_OnlineResource__functionCode.SelectedText = "";
                contactInfo__CI_Contact__hoursOfService.Text = "";
                contactInfo__CI_Contact__contactInstructions.Text = "";
                //bindToFields(incomingRPList[incomingRPListIndex]);
                deleteRP_Btn.Enabled = false;
                addRP_Btn.Enabled = true;
                rp_expander_btn.Text = collapsedSymbol; //"+";
                this.Height = 35;
                panel3.Enabled = false;
                rp_expander_btn.Enabled = false;
                
            }
            else if (_incomingRPList.Count == 1)
            {
                pagerDownBtn.Visible = false;
                pagerUpBtn.Visible = false;
                incomingRPListIndex = 0;
                bindToFields(_incomingRPList[incomingRPListIndex]);
                panel3.Enabled = true;
                rp_expander_btn.Enabled = true;
            }
            else
            {
                //Count is greater than 1
                if (incomingRPListIndex > 0)
                {
                    incomingRPListIndex--;
                }
                bindToFields(_incomingRPList[incomingRPListIndex]);
                panel3.Enabled = true;
                rp_expander_btn.Enabled = true;
            }
            Control ctrl = (Control)sender;
            rp_Validating(ctrl);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Utils1.setEmeDataSets();
            DataTable subTable = Utils1.emeDataSet.Tables["Contact_Information"].Select().CopyToDataTable();

            //concatinate Name and oraganization so that we have a display field
            subTable.Columns.Add("display", typeof(string));

            //concatinate and add person and organization to new field
            foreach (DataRow dr in subTable.Rows)
            {
                dr["display"] = dr["individualName"] + " | " + dr["organizationName"];
            }

            if (comboBox1.Visible == true)
            {
                comboBox1.Visible = false;
            }
            else
            {

                comboBox1.DataSource = subTable;
                comboBox1.ValueMember = "display";
                comboBox1.DisplayMember = "display";
                comboBox1.SelectedIndex = -1;
                comboBox1.Visible = true;
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //DataTable subTable = Utils1.emeDataSet.Tables["Contact_Information"].Select().CopyToDataTable();


            if (comboBox1.SelectedIndex != -1) //&& comboBox1.Visible == true)
            {
                DataRowView drv = (DataRowView)comboBox1.SelectedItem;
                Console.WriteLine(drv["positionName"].ToString());

                //CI_ResponsibleParty newRP = new CI_ResponsibleParty();

                individualName.Text = drv["individualName"].ToString();
                organisationName.Text = drv["organizationName"].ToString();
                positionName.Text = drv["positionName"].ToString();
                contactInfo__CI_Contact__address__CI_Address__deliveryPoint.Text = drv["deliveryPoint"].ToString();
                if (!string.IsNullOrEmpty(drv["address2"].ToString()))
                {
                    contactInfo__CI_Contact__address__CI_Address__deliveryPoint.Text += "; "+ drv["address2"].ToString();
                }
                contactInfo__CI_Contact__address__CI_Address__city.Text = drv["city"].ToString();
                contactInfo__CI_Contact__address__CI_Address__administrativeArea.Text = drv["administrativeArea"].ToString();
                contactInfo__CI_Contact__address__CI_Address__postalCode.Text = drv["postalCode"].ToString();
                contactInfo__CI_Contact__phone__CI_Telephone__facsimile.Text = drv["facsimile"].ToString();
                contactInfo__CI_Contact__phone__CI_Telephone__voice.Text = drv["voice"].ToString();
                contactInfo__CI_Contact__address__CI_Address__electronicMailAddress.Text = drv["electronicMailAddress"].ToString();
                contactInfo__CI_Contact__onlineResource__CI_OnlineResource__linkage.Text = drv["linkage"].ToString();
                contactInfo__CI_Contact__onlineResource__CI_OnlineResource__functionCode.Text = drv["linkageType"].ToString();
                contactInfo__CI_Contact__hoursOfService.Text = drv["hoursOfService"].ToString();
                contactInfo__CI_Contact__contactInstructions.Text = drv["contactInstructions"].ToString();
                //contactInfo__CI_Contact__contactInstructions.Text = drv["cntinst"].ToString();
            }
            val_RP_frmControls(this.Controls);
            comboBox1.SelectedIndexChanged -= new EventHandler(comboBox1_SelectedIndexChanged_1);            
            comboBox1.SelectedIndex = -1;
            comboBox1.SelectedIndexChanged += new EventHandler(comboBox1_SelectedIndexChanged_1);
        }

        private void responsibleParty_TextChangedValidation(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            rp_Validating(ctrl);            
        }
               

        private void responsibleParty_Validating(object sender, CancelEventArgs e)
        {
            Control ctrl = (Control)sender;         
            
            rp_Validating(ctrl);
            
        }

        private void rp_Validating(Control ctrl)
        {
            string tag = (ctrl.Tag != null) ? ctrl.Tag.ToString() : "";
            errorProvider_RP.BlinkStyle = ErrorBlinkStyle.NeverBlink;

            if (tag == "required")
            {
                if (ctrl.GetType() == typeof(TextBox))
                {
                    if (ctrl.Text == string.Empty)
                    {

                        errorProvider_RP.SetError(ctrl, "This is a required Field");
                    }
                    else
                    {
                        errorProvider_RP.SetError(ctrl, "");
                    }
                }
                else if (ctrl.GetType() == typeof(ComboBox))
                {
                    ComboBox cbo = (ComboBox)ctrl;
                    if (cbo.SelectedIndex == -1)
                    {
                        errorProvider_RP.SetError(ctrl, "This is a required Field");
                    }
                    else
                    {
                        errorProvider_RP.SetError(ctrl, "");
                    }
                }
                else if (ctrl.GetType() == typeof(Button))
                {
                    //uc_responsibleParty tag property
                    string responsiblePartyTag = (this.Tag != null) ? this.Tag.ToString() : "";
                    if (responsiblePartyTag == "required")
                    {
                        if (_incomingRPList == null || _incomingRPList.Count == 0)
                        {
                            
                            errorProvider_RP.SetError(this.uc_ResponsibleParty_lbl, "Need at least 1");
                            
                        }
                        else
                        {
                            errorProvider_RP.SetError(this.uc_ResponsibleParty_lbl, "");
                        }
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
                        errorProvider_RP.SetError(parent, "");
                    }
                    else
                    {
                        errorProvider_RP.SetError(parent, "Need at least " + requiredCount.ToString());
                    }
                }
            }
            else
            {
                errorProvider_RP.SetError(ctrl, "");
            }
        }

        private void setValidationModeTags()
        {
            if (_validation_modeEmeLt == "EPA/EDG (ISO19115)")
            {
                errorProvider_RP.SetError(positionName, System.String.Empty);
                errorProvider_RP.SetError(individualName, System.String.Empty);
                errorProvider_RP.SetError(organisationName, System.String.Empty);
                errorProvider_RP.SetError(positionName.Parent, System.String.Empty);
                individualName.Tag = "required1";
                organisationName.Tag = "required1";
                positionName.Tag = "required1";
            }
            else if (_validation_modeEmeLt == "DCAT/Common Core")
            {
                errorProvider_RP.SetError(positionName, System.String.Empty);
                errorProvider_RP.SetError(individualName, System.String.Empty);
                errorProvider_RP.SetError(organisationName, System.String.Empty);
                errorProvider_RP.SetError(positionName.Parent, System.String.Empty);
                individualName.Tag = "required";
                organisationName.Tag = "required";
                positionName.Tag = "";
                positionName.Parent.Tag = "";
            }

        }
        public void val_RP_frmControls(Control.ControlCollection cControls)
        {
            //MessageBox.Show(cControls.Count.ToString());
            //errorProvider_RP.Clear();
            foreach (Control c in cControls)
            {
                if (c.HasChildren)
                {
                    rp_Validating(c);
                    val_RP_frmControls(c.Controls);

                    //if (c.GetType() == typeof(uc_ResponsibleParty))
                    //{
                    //    rp_Validating(c);
                    //    uc_ResponsibleParty rp = (uc_ResponsibleParty)c;

                    //}
                    //else
                    //{
                    //    rp_Validating(c);
                    //    val_RP_frmControls(c.Controls);
                    //}

                }
                else
                {
                    //Console.WriteLine(c.Name);
                    if (c.Tag != null)
                    {
                        rp_Validating(c);
                    }
                }
            }
        }

        private void Expander_Click(object sender, EventArgs e)
        {
            Button expand = (Button)sender;
            if (expand.Name == "rp_expander_btn")
            {
                //if (expand.Text == "+")
                if (expand.Text == collapsedSymbol)
                {
                    //expand.Text = "-";
                    //http://www.fileformat.info/info/unicode/block/geometric_shapes/images.htm
                    expand.Text = expandedSymbol; //"\u25BC"; //"\u25C2";
                    if (CI_ContactExpand_btn.Text == collapsedSymbol) //"+")
                    {
                        this.Height = 220;
                    }
                    else
                    {
                        this.Height = 510;
                    }
                }
                else
                {
                    //expand.Text = "+";
                    expand.Text = collapsedSymbol; //"\u25B7";
                    this.Height = collapseHeight;
                }
            }
            else if (expand.Name == "CI_ContactExpand_btn")
            {
                if (expand.Text == collapsedSymbol)// "+")
                {
                    expand.Text = expandedSymbol; //"-";
                    this.Height = 510;
                    //panel3.Height = 
                    groupBox1.Height = 325;
                }
                else
                {
                    expand.Text = collapsedSymbol; //"+";
                    this.Height = 220;
                    groupBox1.Height = 22;
                }
            }
        }

        private void uc_ResponsibleParty_Leave(object sender, EventArgs e)
        {
            //MessageBox.Show("Leaving");

            //if (_incomingRPList != null)
            //{
            //    if (_incomingRPList.Count != 0)
            //    {
            //        bindToClass(_incomingRPList[incomingRPListIndex]);
            //    }
            //}
        }

        
        private void bindControlsToEMEdatabase()
        {
            if (Utils1.emeDataSet == null)
            {
                Utils1.setEmeDataSets();
            }
            if (dcatProgramCode.DataSource == null)
            {
                //DataTable subTable2 = //new DataTable();
                DataTable subTable2 = Utils1.emeDataSet.Tables["ProgramCode"].Select().CopyToDataTable();
                dcatProgramCode.DataSource = subTable2;
                dcatProgramCode.DisplayMember = "programName";
                dcatProgramCode.ValueMember = "pCode";
            }
            dcatProgramCode.SelectedIndex = -1;

            DataTable subTable = Utils1.emeDataSet.Tables["Contact_Information"].Select().CopyToDataTable();

            //concatinate Name and oraganization so that we have a display field
            subTable.Columns.Add("display", typeof(string));

            //concatinate and add person and organization to new field
            foreach (DataRow dr in subTable.Rows)
            {
                dr["display"] = dr["individualName"] + " | " + dr["organizationName"];
            }
                        
            comboBox1.SelectedIndexChanged -= new EventHandler(comboBox1_SelectedIndexChanged_1);
            comboBox1.DataSource = subTable;
            comboBox1.ValueMember = "display";
            comboBox1.DisplayMember = "display";
            comboBox1.SelectedIndex = -1;
            comboBox1.SelectedIndexChanged += new EventHandler(comboBox1_SelectedIndexChanged_1);
           
        }
       
        private string getSelectedProgramCode(string selectedDisplayValue)
        {
            int i = dcatProgramCode.FindStringExact(selectedDisplayValue);

            DataRowView drv = (DataRowView)dcatProgramCode.Items[i];
            string pcodeValue = drv["pCode"].ToString();
            return pcodeValue;
                
        }

        private void responsible_party_d_Click(object sender, EventArgs e)
        {
            //comboBox1.SelectedIndex = 3;
            for (int i = 0; i < comboBox1.Items.Count; i++)
            {
                DataRowView drv = (DataRowView)comboBox1.Items[i];
                bool d = (bool)drv["default"];
                if (d)
                {
                    comboBox1.SelectedIndex = i;
                }
            }
            if (this.Name == "contact_CI_ResponsibleParty")
            {
                role.Text = "author";
            }
            else if (this.Name == "idInfo_pointOfContact")
            {
                role.Text = "owner";
            }
            else if (this.Name == "idInfo_citation_citedResponsibleParty")
            {
                role.Text = "originator";
            }
             else if (this.Name == "distributor_Contact")
            {
                role.Text = "distributor";
            }
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
