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
    public partial class uc_extentTemporal : UserControl
    {
        private timeInstantExtent _timeInstantExtent;
        private timePeriodExtent _timePeriodExtent;
        private temporalElement__EX_TemporalExtent _temporalElement;
        
        public temporalElement__EX_TemporalExtent temporalElement
        {
            get
            {
                saveFormValuesToClass();
                return _temporalElement;
            }
            set { _temporalElement = value; }
        }

        public uc_extentTemporal()
        {
            InitializeComponent();
        }
        public void loadTemporalExtent(temporalElement__EX_TemporalExtent incomingTemporalElement)
        {
            //Prevent this event from firing when first loading a record
            this.tabControl1.Deselecting -=new TabControlCancelEventHandler(tabControl1_Deselecting);

            _temporalElement = incomingTemporalElement;
            if (_temporalElement.TimePeriod != null)
            {
                //load time Period
                _timePeriodExtent = _temporalElement.TimePeriod;
                tabControl1.SelectTab("timePeriod");
                setTimePeriodtoForm();
            }
            else if (_temporalElement.TimeInstant != null)
            {
                _timeInstantExtent = _temporalElement.TimeInstant;
                tabControl1.SelectTab("timeInstant");
                setTimeInstanttoForm();
            }
            else
            {
                //red blinky
                clearTimePeriod();
                clearTimeInstant();
                tabControl1.SelectTab("timePeriod");
                //setTimePeriodtoForm();
            }

            //Set the event to fire
            this.tabControl1.Deselecting += new TabControlCancelEventHandler(tabControl1_Deselecting);            
            //this.tabControl1.Deselecting += delegate(object sender, TabControlCancelEventArgs e) { tabControl1_Deselecting(sender, e); };                

        }

        private void saveFormValuesToClass()
        {
            temporalElement__EX_TemporalExtent outgoingTemporalExtent = new temporalElement__EX_TemporalExtent();

            //Check if any one item has a value then do something, otherwise leave each time object null
            if (tabControl1.SelectedTab.Name == "timePeriod")
            {                
                if (!string.IsNullOrEmpty(extent__TimePeriod__description.Text.Trim())
                    | !string.IsNullOrEmpty(extent__TimePeriod__beginPosition.Text.Trim())
                    | !string.IsNullOrEmpty(extent__TimePeriod__endPosition.Text.Trim())
                    | !string.IsNullOrEmpty(extent__TimePeriod__timeInterval.Text.Trim())
                    )
                {
                    timePeriodExtent outTp = new timePeriodExtent();
                    outTp.extent__TimePeriod__description = extent__TimePeriod__description.Text.Trim();
                    outTp.extent__TimePeriod__beginPosition = (extent__TimePeriod__beginPosition.Text.Trim() != "" ?
                        extent__TimePeriod__beginPosition.Text.Trim() : "unknown");
                    outTp.extent__TimePeriod__endPosition = (extent__TimePeriod__endPosition.Text.Trim() != "" ?
                        extent__TimePeriod__endPosition.Text.Trim() : "unknown");
                    if (extent__TimePeriod__timeInterval.Text.Trim() !="")
                    {
                        outTp.extent__TimePeriod__timeInterval = extent__TimePeriod__timeInterval.Text.Trim();                        
                        
                        outTp.extent__TimePeriod__timeIntervalUnit = (extent__TimePeriod__timeIntervalUnit_cbo.Text != "" ?
                            extent__TimePeriod__timeIntervalUnit_cbo.Text : "unspecified");
                    }
                    outgoingTemporalExtent.TimePeriod = outTp;
                }
            }
            else if (tabControl1.SelectedTab.Name == "timeInstant")
            {
                if (!string.IsNullOrEmpty(extent__TimeInstant__description.Text.Trim())
                    | !string.IsNullOrEmpty(extent__TimeInstant__timePosition.Text.Trim())
                    )
                {
                    timeInstantExtent outTi = new timeInstantExtent();
                    outTi.extent__TimeInstant__description = extent__TimeInstant__description.Text.Trim();
                    outTi.extent__TimeInstant__timePosition = (extent__TimeInstant__timePosition.Text.Trim() != "" ?
                        extent__TimeInstant__timePosition.Text.Trim() : "unknown");
                    
                    outgoingTemporalExtent.TimeInstant = outTi;
                }
            }
            _temporalElement = outgoingTemporalExtent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //temporalElement__EX_TemporalExtent testTE = new temporalElement__EX_TemporalExtent();
            //timeInstantExtent ti = new timeInstantExtent();
            //ti.extent__TimeInstant__description = "Sample Description";
            //ti.extent__TimeInstant__timePosition = "2012-08-22";
            //testTE.TimeInstant = ti;
            //loadTemporalExtent(testTE);

            //temporalElement__EX_TemporalExtent test = temporalElement;

            //string s = temporalElement.TimePeriod.extent__TimePeriod__description + System.Environment.NewLine;

            //MessageBox.Show("Test");


        }
        private void button2_Click(object sender, EventArgs e)
        {
            ////create a test timePeriod and load
            //temporalElement__EX_TemporalExtent testTE = new temporalElement__EX_TemporalExtent();
            //timePeriodExtent tp = new timePeriodExtent();
            //tp.extent__TimePeriod__description = "Test Description";
            //tp.extent__TimePeriod__beginPosition = "unknown";
            //tp.extent__TimePeriod__endPosition = "2012-08-22";
            //tp.extent__TimePeriod__timeInterval = "1";
            //tp.extent__TimePeriod__timeIntervalUnit = "Test1";
            //testTE.TimePeriod = tp;

            //loadTemporalExtent(testTE);
            
            //temporalElement__EX_TemporalExtent junk = temporalElement;
            //MessageBox.Show("test");
            
        }

        private void dtP_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker ctrl = (DateTimePicker)sender;
            string name = ctrl.Name.Substring(0, ctrl.Name.Length - 4);
            TextBox tbox = (TextBox)this.Controls.Find(name, true)[0];//this.getControlForTag(name);
            tbox.Text = ctrl.Value.ToString("yyyy-MM-dd");
            //idInfo_citation_date_creation.Text = idInfo_citation_date_creation_dtP.Value.ToString("yyyy-MM-dd");
            ComboBox cboCtrl = (ComboBox)this.Controls.Find(name + "_cbo", true)[0];
            cboCtrl.SelectedIndex = -1;
        }
        private void ClearTextbox_Click(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            string name = ctrl.Name.Substring(0, ctrl.Name.Length - 4);
            TextBox tbox = (TextBox)this.Controls.Find(name, true)[0];//this.getControlForTag(name);
            tbox.Clear();
            ComboBox cboCtrl = (ComboBox)this.Controls.Find(name + "_cbo", true)[0];
            cboCtrl.SelectedIndex = -1;

        }
        private void cbo_ValueChanged(object sender, EventArgs e)
        {
            ComboBox ctrl = (ComboBox)sender;
            string name = ctrl.Name.Substring(0, ctrl.Name.Length - 4);
            TextBox tbox = (TextBox)this.Controls.Find(name, true)[0];//this.getControlForTag(name);            
            if (ctrl.SelectedItem != null) { tbox.Text = ctrl.SelectedItem.ToString(); }
        }
                
        private void setTimePeriodtoForm()
        {
            extent__TimePeriod__description.Text = _timePeriodExtent.extent__TimePeriod__description;
            extent__TimePeriod__beginPosition.Text = _timePeriodExtent.extent__TimePeriod__beginPosition;
            
            //need logic here for dates vs indeterminate values for the drop list
            DateTime testDt;
            bool isDate = DateTime.TryParse(_timePeriodExtent.extent__TimePeriod__beginPosition, out testDt);
            if (!isDate) { extent__TimePeriod__beginPosition_cbo.SelectedItem = _timePeriodExtent.extent__TimePeriod__beginPosition; }
            else { extent__TimePeriod__beginPosition_cbo.SelectedIndex = -1; }

            isDate = DateTime.TryParse(_timePeriodExtent.extent__TimePeriod__endPosition, out testDt);
            if (!isDate) { extent__TimePeriod__endPosition_cbo.SelectedItem = _timePeriodExtent.extent__TimePeriod__endPosition; }
            else { extent__TimePeriod__endPosition_cbo.SelectedIndex = -1; }

            extent__TimePeriod__endPosition.Text = _timePeriodExtent.extent__TimePeriod__endPosition;
            //extent__TimePeriod__endPosition_cbo.SelectedIndex = -1;
            extent__TimePeriod__timeInterval.Text = _timePeriodExtent.extent__TimePeriod__timeInterval;
            extent__TimePeriod__timeIntervalUnit_cbo.SelectedIndex = -1;
            extent__TimePeriod__timeIntervalUnit_cbo.Text = ""; //clears free text
            int unitPosition = extent__TimePeriod__timeIntervalUnit_cbo.FindString(_timePeriodExtent.extent__TimePeriod__timeIntervalUnit);
            if (unitPosition > -1)
            {
                extent__TimePeriod__timeIntervalUnit_cbo.SelectedItem = _timePeriodExtent.extent__TimePeriod__timeIntervalUnit;
            }
            else { extent__TimePeriod__timeIntervalUnit_cbo.SelectedText = _timePeriodExtent.extent__TimePeriod__timeIntervalUnit; }
        }
        private void clearTimePeriod()
        {
            _timePeriodExtent = new timePeriodExtent();           
            setTimePeriodtoForm();
        }
        private void setTimeInstanttoForm()
        {
            extent__TimeInstant__description.Text = _timeInstantExtent.extent__TimeInstant__description;
            extent__TimeInstant__timePosition.Text = _timeInstantExtent.extent__TimeInstant__timePosition;
            DateTime testDt;
            bool isDate = DateTime.TryParse(_timeInstantExtent.extent__TimeInstant__timePosition, out testDt);
            if (!isDate) { extent__TimeInstant__timePosition_cbo.SelectedItem = _timeInstantExtent.extent__TimeInstant__timePosition; }
            else { extent__TimeInstant__timePosition_cbo.SelectedIndex = -1; }

        }
        private void clearTimeInstant()
        {
            _timeInstantExtent = new timeInstantExtent();
            setTimeInstanttoForm();
                        
        }
        
        private void tabControl1_Deselecting(object sender, TabControlCancelEventArgs e)
        {
            ////MessageBox.Show(tabControl1.SelectedTab.Name);
            
            //ToDo:  How prevent this from beeing called when the form is loading?

            if (MessageBox.Show("Are you sure you want to switch? Data on this tab will be erased", "Please Choose One Date Type",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                //textBox1.Text = tabControl1.SelectedTab.Name;
                if (tabControl1.SelectedTab.Text == "Single Date")
                { clearTimePeriod(); }
                else if (tabControl1.SelectedTab.Text == "Time Period")
                { clearTimeInstant(); }
            }
            else
            {
                e.Cancel = true;
            }
        }

        public void reset()
        {
            clearTimePeriod();
            clearTimeInstant();
            tabControl1.SelectedIndex = 0;
        }

        public void validateControls()
        {
             
        // _timePeriodExtent;
            if (_timeInstantExtent == null)
            {
                //MessageBox.Show("hey its got null");
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
