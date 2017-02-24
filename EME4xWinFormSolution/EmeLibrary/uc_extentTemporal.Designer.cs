namespace EmeLibrary
{
    partial class uc_extentTemporal
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_extentTemporal));
            this.temporalExtent = new System.Windows.Forms.GroupBox();
            this.temporalExtent_lbl = new System.Windows.Forms.LinkLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.timePeriod = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.extent__TimePeriod__endPosition_btn = new System.Windows.Forms.Button();
            this.extent__TimePeriod__beginPosition_cbo = new System.Windows.Forms.ComboBox();
            this.extent__TimePeriod__endPosition_dtP = new System.Windows.Forms.DateTimePicker();
            this.extent__TimePeriod__endPosition = new System.Windows.Forms.TextBox();
            this.timePeriod_Begin_lbl = new System.Windows.Forms.Label();
            this.extent__TimePeriod__endPosition_cbo = new System.Windows.Forms.ComboBox();
            this.timePeriod_End_lbl = new System.Windows.Forms.Label();
            this.extent__TimePeriod__beginPosition_btn = new System.Windows.Forms.Button();
            this.extent__TimePeriod__beginPosition_dtP = new System.Windows.Forms.DateTimePicker();
            this.extent__TimePeriod__beginPosition = new System.Windows.Forms.TextBox();
            this.extent__TimePeriod__description_lbl = new System.Windows.Forms.Label();
            this.extent__TimePeriod__description = new System.Windows.Forms.TextBox();
            this.extent__TimePeriod__timeIntervalUnit_cbo = new System.Windows.Forms.ComboBox();
            this.timePeriod_Interval_lbl = new System.Windows.Forms.Label();
            this.extent__TimePeriod__timeInterval = new System.Windows.Forms.TextBox();
            this.timeInstant = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.extent__TimeInstant__timePosition_btn = new System.Windows.Forms.Button();
            this.extent__TimeInstant__timePosition_cbo = new System.Windows.Forms.ComboBox();
            this.extent__TimeInstant__timePosition_dtP = new System.Windows.Forms.DateTimePicker();
            this.timeInstant_timePosition_lbl = new System.Windows.Forms.Label();
            this.extent__TimeInstant__timePosition = new System.Windows.Forms.TextBox();
            this.extent__TimeInstant__description_lbl = new System.Windows.Forms.Label();
            this.extent__TimeInstant__description = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.temporalExtent.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.timePeriod.SuspendLayout();
            this.panel1.SuspendLayout();
            this.timeInstant.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // temporalExtent
            // 
            this.temporalExtent.BackColor = System.Drawing.Color.Transparent;
            this.temporalExtent.Controls.Add(this.temporalExtent_lbl);
            this.temporalExtent.Controls.Add(this.tabControl1);
            this.temporalExtent.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temporalExtent.Location = new System.Drawing.Point(3, 3);
            this.temporalExtent.Name = "temporalExtent";
            this.temporalExtent.Size = new System.Drawing.Size(346, 173);
            this.temporalExtent.TabIndex = 0;
            this.temporalExtent.TabStop = false;
            this.temporalExtent.Text = "                                                        ";
            // 
            // temporalExtent_lbl
            // 
            this.temporalExtent_lbl.AutoSize = true;
            this.temporalExtent_lbl.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.temporalExtent_lbl.Location = new System.Drawing.Point(7, -1);
            this.temporalExtent_lbl.Name = "temporalExtent_lbl";
            this.temporalExtent_lbl.Size = new System.Drawing.Size(171, 13);
            this.temporalExtent_lbl.TabIndex = 0;
            this.temporalExtent_lbl.TabStop = true;
            this.temporalExtent_lbl.Text = "Temporal Extent of Resource";
            this.temporalExtent_lbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.genericOpenHelpFromLinkLabel_LinkClicked);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.timePeriod);
            this.tabControl1.Controls.Add(this.timeInstant);
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(10, 15);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.ShowToolTips = true;
            this.tabControl1.Size = new System.Drawing.Size(330, 150);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.TabStop = false;
            this.toolTip1.SetToolTip(this.tabControl1, "Chose One Date Type");
            // 
            // timePeriod
            // 
            this.timePeriod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.timePeriod.Controls.Add(this.panel1);
            this.timePeriod.Controls.Add(this.extent__TimePeriod__description_lbl);
            this.timePeriod.Controls.Add(this.extent__TimePeriod__description);
            this.timePeriod.Controls.Add(this.extent__TimePeriod__timeIntervalUnit_cbo);
            this.timePeriod.Controls.Add(this.timePeriod_Interval_lbl);
            this.timePeriod.Controls.Add(this.extent__TimePeriod__timeInterval);
            this.timePeriod.Location = new System.Drawing.Point(4, 22);
            this.timePeriod.Name = "timePeriod";
            this.timePeriod.Padding = new System.Windows.Forms.Padding(3);
            this.timePeriod.Size = new System.Drawing.Size(322, 124);
            this.timePeriod.TabIndex = 1;
            this.timePeriod.Text = "Time Period";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.extent__TimePeriod__endPosition_btn);
            this.panel1.Controls.Add(this.extent__TimePeriod__beginPosition_cbo);
            this.panel1.Controls.Add(this.extent__TimePeriod__endPosition_dtP);
            this.panel1.Controls.Add(this.extent__TimePeriod__endPosition);
            this.panel1.Controls.Add(this.timePeriod_Begin_lbl);
            this.panel1.Controls.Add(this.extent__TimePeriod__endPosition_cbo);
            this.panel1.Controls.Add(this.timePeriod_End_lbl);
            this.panel1.Controls.Add(this.extent__TimePeriod__beginPosition_btn);
            this.panel1.Controls.Add(this.extent__TimePeriod__beginPosition_dtP);
            this.panel1.Controls.Add(this.extent__TimePeriod__beginPosition);
            this.panel1.Location = new System.Drawing.Point(24, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 59);
            this.panel1.TabIndex = 1;
            this.panel1.TabStop = true;
            // 
            // extent__TimePeriod__endPosition_btn
            // 
            this.extent__TimePeriod__endPosition_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.extent__TimePeriod__endPosition_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.extent__TimePeriod__endPosition_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.extent__TimePeriod__endPosition_btn.FlatAppearance.BorderSize = 0;
            this.extent__TimePeriod__endPosition_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.extent__TimePeriod__endPosition_btn.Image = ((System.Drawing.Image)(resources.GetObject("extent__TimePeriod__endPosition_btn.Image")));
            this.extent__TimePeriod__endPosition_btn.Location = new System.Drawing.Point(148, 33);
            this.extent__TimePeriod__endPosition_btn.Name = "extent__TimePeriod__endPosition_btn";
            this.extent__TimePeriod__endPosition_btn.Size = new System.Drawing.Size(16, 16);
            this.extent__TimePeriod__endPosition_btn.TabIndex = 4;
            this.extent__TimePeriod__endPosition_btn.UseVisualStyleBackColor = false;
            this.extent__TimePeriod__endPosition_btn.Click += new System.EventHandler(this.ClearTextbox_Click);
            // 
            // extent__TimePeriod__beginPosition_cbo
            // 
            this.extent__TimePeriod__beginPosition_cbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.extent__TimePeriod__beginPosition_cbo.FormattingEnabled = true;
            this.extent__TimePeriod__beginPosition_cbo.Items.AddRange(new object[] {
            "unknown",
            "now",
            "after",
            "before"});
            this.extent__TimePeriod__beginPosition_cbo.Location = new System.Drawing.Point(196, 6);
            this.extent__TimePeriod__beginPosition_cbo.Name = "extent__TimePeriod__beginPosition_cbo";
            this.extent__TimePeriod__beginPosition_cbo.Size = new System.Drawing.Size(87, 21);
            this.extent__TimePeriod__beginPosition_cbo.TabIndex = 3;
            this.toolTip1.SetToolTip(this.extent__TimePeriod__beginPosition_cbo, "Choose an Indeterminate Date");
            this.extent__TimePeriod__beginPosition_cbo.SelectedIndexChanged += new System.EventHandler(this.cbo_ValueChanged);
            // 
            // extent__TimePeriod__endPosition_dtP
            // 
            this.extent__TimePeriod__endPosition_dtP.CustomFormat = "";
            this.extent__TimePeriod__endPosition_dtP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.extent__TimePeriod__endPosition_dtP.Location = new System.Drawing.Point(172, 31);
            this.extent__TimePeriod__endPosition_dtP.Name = "extent__TimePeriod__endPosition_dtP";
            this.extent__TimePeriod__endPosition_dtP.Size = new System.Drawing.Size(16, 21);
            this.extent__TimePeriod__endPosition_dtP.TabIndex = 5;
            this.toolTip1.SetToolTip(this.extent__TimePeriod__endPosition_dtP, "Choose an Exact Date");
            this.extent__TimePeriod__endPosition_dtP.ValueChanged += new System.EventHandler(this.dtP_ValueChanged);
            // 
            // extent__TimePeriod__endPosition
            // 
            this.extent__TimePeriod__endPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.extent__TimePeriod__endPosition.Location = new System.Drawing.Point(43, 31);
            this.extent__TimePeriod__endPosition.Name = "extent__TimePeriod__endPosition";
            this.extent__TimePeriod__endPosition.ReadOnly = true;
            this.extent__TimePeriod__endPosition.Size = new System.Drawing.Size(123, 21);
            this.extent__TimePeriod__endPosition.TabIndex = 4;
            this.extent__TimePeriod__endPosition.TabStop = false;
            this.toolTip1.SetToolTip(this.extent__TimePeriod__endPosition, "Choose an Exact Date or Indeterminate Value");
            // 
            // timePeriod_Begin_lbl
            // 
            this.timePeriod_Begin_lbl.AutoSize = true;
            this.timePeriod_Begin_lbl.Location = new System.Drawing.Point(6, 9);
            this.timePeriod_Begin_lbl.Name = "timePeriod_Begin_lbl";
            this.timePeriod_Begin_lbl.Size = new System.Drawing.Size(33, 13);
            this.timePeriod_Begin_lbl.TabIndex = 3;
            this.timePeriod_Begin_lbl.Text = "Begin";
            // 
            // extent__TimePeriod__endPosition_cbo
            // 
            this.extent__TimePeriod__endPosition_cbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.extent__TimePeriod__endPosition_cbo.FormattingEnabled = true;
            this.extent__TimePeriod__endPosition_cbo.Items.AddRange(new object[] {
            "unknown",
            "now",
            "after",
            "before"});
            this.extent__TimePeriod__endPosition_cbo.Location = new System.Drawing.Point(196, 31);
            this.extent__TimePeriod__endPosition_cbo.Name = "extent__TimePeriod__endPosition_cbo";
            this.extent__TimePeriod__endPosition_cbo.Size = new System.Drawing.Size(87, 21);
            this.extent__TimePeriod__endPosition_cbo.TabIndex = 6;
            this.toolTip1.SetToolTip(this.extent__TimePeriod__endPosition_cbo, "Choose an Indeterminate Date");
            this.extent__TimePeriod__endPosition_cbo.SelectedIndexChanged += new System.EventHandler(this.cbo_ValueChanged);
            // 
            // timePeriod_End_lbl
            // 
            this.timePeriod_End_lbl.AutoSize = true;
            this.timePeriod_End_lbl.Location = new System.Drawing.Point(14, 32);
            this.timePeriod_End_lbl.Name = "timePeriod_End_lbl";
            this.timePeriod_End_lbl.Size = new System.Drawing.Size(25, 13);
            this.timePeriod_End_lbl.TabIndex = 4;
            this.timePeriod_End_lbl.Text = "End";
            // 
            // extent__TimePeriod__beginPosition_btn
            // 
            this.extent__TimePeriod__beginPosition_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.extent__TimePeriod__beginPosition_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.extent__TimePeriod__beginPosition_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.extent__TimePeriod__beginPosition_btn.FlatAppearance.BorderSize = 0;
            this.extent__TimePeriod__beginPosition_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.extent__TimePeriod__beginPosition_btn.Image = ((System.Drawing.Image)(resources.GetObject("extent__TimePeriod__beginPosition_btn.Image")));
            this.extent__TimePeriod__beginPosition_btn.Location = new System.Drawing.Point(148, 8);
            this.extent__TimePeriod__beginPosition_btn.Name = "extent__TimePeriod__beginPosition_btn";
            this.extent__TimePeriod__beginPosition_btn.Size = new System.Drawing.Size(16, 16);
            this.extent__TimePeriod__beginPosition_btn.TabIndex = 1;
            this.extent__TimePeriod__beginPosition_btn.UseVisualStyleBackColor = false;
            this.extent__TimePeriod__beginPosition_btn.Click += new System.EventHandler(this.ClearTextbox_Click);
            // 
            // extent__TimePeriod__beginPosition_dtP
            // 
            this.extent__TimePeriod__beginPosition_dtP.CustomFormat = "";
            this.extent__TimePeriod__beginPosition_dtP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.extent__TimePeriod__beginPosition_dtP.Location = new System.Drawing.Point(172, 6);
            this.extent__TimePeriod__beginPosition_dtP.Name = "extent__TimePeriod__beginPosition_dtP";
            this.extent__TimePeriod__beginPosition_dtP.Size = new System.Drawing.Size(16, 21);
            this.extent__TimePeriod__beginPosition_dtP.TabIndex = 2;
            this.toolTip1.SetToolTip(this.extent__TimePeriod__beginPosition_dtP, "Choose an Exact Date");
            this.extent__TimePeriod__beginPosition_dtP.ValueChanged += new System.EventHandler(this.dtP_ValueChanged);
            // 
            // extent__TimePeriod__beginPosition
            // 
            this.extent__TimePeriod__beginPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.extent__TimePeriod__beginPosition.Location = new System.Drawing.Point(43, 6);
            this.extent__TimePeriod__beginPosition.Name = "extent__TimePeriod__beginPosition";
            this.extent__TimePeriod__beginPosition.ReadOnly = true;
            this.extent__TimePeriod__beginPosition.Size = new System.Drawing.Size(123, 21);
            this.extent__TimePeriod__beginPosition.TabIndex = 1;
            this.extent__TimePeriod__beginPosition.TabStop = false;
            this.toolTip1.SetToolTip(this.extent__TimePeriod__beginPosition, "Choose an Exact Date or Indeterminate Value");
            // 
            // extent__TimePeriod__description_lbl
            // 
            this.extent__TimePeriod__description_lbl.AutoSize = true;
            this.extent__TimePeriod__description_lbl.Location = new System.Drawing.Point(5, 9);
            this.extent__TimePeriod__description_lbl.Name = "extent__TimePeriod__description_lbl";
            this.extent__TimePeriod__description_lbl.Size = new System.Drawing.Size(60, 13);
            this.extent__TimePeriod__description_lbl.TabIndex = 45;
            this.extent__TimePeriod__description_lbl.Text = "Description";
            // 
            // extent__TimePeriod__description
            // 
            this.extent__TimePeriod__description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.extent__TimePeriod__description.Location = new System.Drawing.Point(68, 6);
            this.extent__TimePeriod__description.Name = "extent__TimePeriod__description";
            this.extent__TimePeriod__description.Size = new System.Drawing.Size(240, 21);
            this.extent__TimePeriod__description.TabIndex = 0;
            this.extent__TimePeriod__description.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.genericSpaciousEntryForm_MouseDoubleClick);
            // 
            // extent__TimePeriod__timeIntervalUnit_cbo
            // 
            this.extent__TimePeriod__timeIntervalUnit_cbo.FormattingEnabled = true;
            this.extent__TimePeriod__timeIntervalUnit_cbo.Items.AddRange(new object[] {
            "hours",
            "days",
            "weeks",
            "months",
            "years"});
            this.extent__TimePeriod__timeIntervalUnit_cbo.Location = new System.Drawing.Point(198, 97);
            this.extent__TimePeriod__timeIntervalUnit_cbo.Name = "extent__TimePeriod__timeIntervalUnit_cbo";
            this.extent__TimePeriod__timeIntervalUnit_cbo.Size = new System.Drawing.Size(111, 21);
            this.extent__TimePeriod__timeIntervalUnit_cbo.TabIndex = 8;
            this.toolTip1.SetToolTip(this.extent__TimePeriod__timeIntervalUnit_cbo, "Type of Units for Interval");
            // 
            // timePeriod_Interval_lbl
            // 
            this.timePeriod_Interval_lbl.AutoSize = true;
            this.timePeriod_Interval_lbl.Location = new System.Drawing.Point(23, 100);
            this.timePeriod_Interval_lbl.Name = "timePeriod_Interval_lbl";
            this.timePeriod_Interval_lbl.Size = new System.Drawing.Size(45, 13);
            this.timePeriod_Interval_lbl.TabIndex = 5;
            this.timePeriod_Interval_lbl.Text = "Interval";
            // 
            // extent__TimePeriod__timeInterval
            // 
            this.extent__TimePeriod__timeInterval.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.extent__TimePeriod__timeInterval.Location = new System.Drawing.Point(68, 97);
            this.extent__TimePeriod__timeInterval.Name = "extent__TimePeriod__timeInterval";
            this.extent__TimePeriod__timeInterval.Size = new System.Drawing.Size(123, 21);
            this.extent__TimePeriod__timeInterval.TabIndex = 7;
            // 
            // timeInstant
            // 
            this.timeInstant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.timeInstant.Controls.Add(this.panel2);
            this.timeInstant.Controls.Add(this.extent__TimeInstant__description_lbl);
            this.timeInstant.Controls.Add(this.extent__TimeInstant__description);
            this.timeInstant.ForeColor = System.Drawing.SystemColors.ControlText;
            this.timeInstant.Location = new System.Drawing.Point(4, 22);
            this.timeInstant.Name = "timeInstant";
            this.timeInstant.Padding = new System.Windows.Forms.Padding(3);
            this.timeInstant.Size = new System.Drawing.Size(322, 124);
            this.timeInstant.TabIndex = 0;
            this.timeInstant.Text = "Single Date";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.extent__TimeInstant__timePosition_btn);
            this.panel2.Controls.Add(this.extent__TimeInstant__timePosition_cbo);
            this.panel2.Controls.Add(this.extent__TimeInstant__timePosition_dtP);
            this.panel2.Controls.Add(this.timeInstant_timePosition_lbl);
            this.panel2.Controls.Add(this.extent__TimeInstant__timePosition);
            this.panel2.Location = new System.Drawing.Point(24, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 34);
            this.panel2.TabIndex = 46;
            // 
            // extent__TimeInstant__timePosition_btn
            // 
            this.extent__TimeInstant__timePosition_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.extent__TimeInstant__timePosition_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.extent__TimeInstant__timePosition_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.extent__TimeInstant__timePosition_btn.FlatAppearance.BorderSize = 0;
            this.extent__TimeInstant__timePosition_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.extent__TimeInstant__timePosition_btn.Image = ((System.Drawing.Image)(resources.GetObject("extent__TimeInstant__timePosition_btn.Image")));
            this.extent__TimeInstant__timePosition_btn.Location = new System.Drawing.Point(147, 8);
            this.extent__TimeInstant__timePosition_btn.Name = "extent__TimeInstant__timePosition_btn";
            this.extent__TimeInstant__timePosition_btn.Size = new System.Drawing.Size(16, 16);
            this.extent__TimeInstant__timePosition_btn.TabIndex = 1;
            this.extent__TimeInstant__timePosition_btn.UseVisualStyleBackColor = false;
            this.extent__TimeInstant__timePosition_btn.Click += new System.EventHandler(this.ClearTextbox_Click);
            // 
            // extent__TimeInstant__timePosition_cbo
            // 
            this.extent__TimeInstant__timePosition_cbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.extent__TimeInstant__timePosition_cbo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.extent__TimeInstant__timePosition_cbo.FormattingEnabled = true;
            this.extent__TimeInstant__timePosition_cbo.Items.AddRange(new object[] {
            "unknown",
            "after",
            "before",
            "now"});
            this.extent__TimeInstant__timePosition_cbo.Location = new System.Drawing.Point(196, 6);
            this.extent__TimeInstant__timePosition_cbo.Name = "extent__TimeInstant__timePosition_cbo";
            this.extent__TimeInstant__timePosition_cbo.Size = new System.Drawing.Size(87, 21);
            this.extent__TimeInstant__timePosition_cbo.TabIndex = 3;
            this.toolTip1.SetToolTip(this.extent__TimeInstant__timePosition_cbo, "Choose an Indeterminate Date");
            this.extent__TimeInstant__timePosition_cbo.SelectedIndexChanged += new System.EventHandler(this.cbo_ValueChanged);
            // 
            // extent__TimeInstant__timePosition_dtP
            // 
            this.extent__TimeInstant__timePosition_dtP.CustomFormat = "";
            this.extent__TimeInstant__timePosition_dtP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.extent__TimeInstant__timePosition_dtP.Location = new System.Drawing.Point(172, 6);
            this.extent__TimeInstant__timePosition_dtP.Name = "extent__TimeInstant__timePosition_dtP";
            this.extent__TimeInstant__timePosition_dtP.Size = new System.Drawing.Size(16, 21);
            this.extent__TimeInstant__timePosition_dtP.TabIndex = 2;
            this.toolTip1.SetToolTip(this.extent__TimeInstant__timePosition_dtP, "Choose an Exact Date");
            this.extent__TimeInstant__timePosition_dtP.ValueChanged += new System.EventHandler(this.dtP_ValueChanged);
            // 
            // timeInstant_timePosition_lbl
            // 
            this.timeInstant_timePosition_lbl.AutoSize = true;
            this.timeInstant_timePosition_lbl.Location = new System.Drawing.Point(10, 9);
            this.timeInstant_timePosition_lbl.Name = "timeInstant_timePosition_lbl";
            this.timeInstant_timePosition_lbl.Size = new System.Drawing.Size(30, 13);
            this.timeInstant_timePosition_lbl.TabIndex = 3;
            this.timeInstant_timePosition_lbl.Text = "Date";
            // 
            // extent__TimeInstant__timePosition
            // 
            this.extent__TimeInstant__timePosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.extent__TimeInstant__timePosition.Location = new System.Drawing.Point(43, 6);
            this.extent__TimeInstant__timePosition.Name = "extent__TimeInstant__timePosition";
            this.extent__TimeInstant__timePosition.ReadOnly = true;
            this.extent__TimeInstant__timePosition.Size = new System.Drawing.Size(123, 21);
            this.extent__TimeInstant__timePosition.TabIndex = 1;
            this.extent__TimeInstant__timePosition.TabStop = false;
            this.toolTip1.SetToolTip(this.extent__TimeInstant__timePosition, "Choose an Exact Date or Indeterminate Value");
            // 
            // extent__TimeInstant__description_lbl
            // 
            this.extent__TimeInstant__description_lbl.AutoSize = true;
            this.extent__TimeInstant__description_lbl.Location = new System.Drawing.Point(5, 9);
            this.extent__TimeInstant__description_lbl.Name = "extent__TimeInstant__description_lbl";
            this.extent__TimeInstant__description_lbl.Size = new System.Drawing.Size(60, 13);
            this.extent__TimeInstant__description_lbl.TabIndex = 45;
            this.extent__TimeInstant__description_lbl.Text = "Description";
            // 
            // extent__TimeInstant__description
            // 
            this.extent__TimeInstant__description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.extent__TimeInstant__description.Location = new System.Drawing.Point(68, 6);
            this.extent__TimeInstant__description.Name = "extent__TimeInstant__description";
            this.extent__TimeInstant__description.Size = new System.Drawing.Size(240, 21);
            this.extent__TimeInstant__description.TabIndex = 0;
            this.extent__TimeInstant__description.Tag = "";
            this.extent__TimeInstant__description.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.genericSpaciousEntryForm_MouseDoubleClick);
            // 
            // uc_extentTemporal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.temporalExtent);
            this.Name = "uc_extentTemporal";
            this.Size = new System.Drawing.Size(354, 182);
            this.temporalExtent.ResumeLayout(false);
            this.temporalExtent.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.timePeriod.ResumeLayout(false);
            this.timePeriod.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.timeInstant.ResumeLayout(false);
            this.timeInstant.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox temporalExtent;
        private System.Windows.Forms.ComboBox extent__TimePeriod__beginPosition_cbo;
        private System.Windows.Forms.ComboBox extent__TimePeriod__timeIntervalUnit_cbo;
        private System.Windows.Forms.TextBox extent__TimePeriod__timeInterval;
        private System.Windows.Forms.Label timePeriod_Interval_lbl;
        private System.Windows.Forms.Label timePeriod_End_lbl;
        private System.Windows.Forms.Label timePeriod_Begin_lbl;
        private System.Windows.Forms.TextBox extent__TimePeriod__beginPosition;
        private System.Windows.Forms.DateTimePicker extent__TimePeriod__beginPosition_dtP;
        private System.Windows.Forms.Button extent__TimePeriod__beginPosition_btn;
        private System.Windows.Forms.TextBox extent__TimePeriod__description;
        private System.Windows.Forms.Button extent__TimePeriod__endPosition_btn;
        private System.Windows.Forms.DateTimePicker extent__TimePeriod__endPosition_dtP;
        private System.Windows.Forms.TextBox extent__TimePeriod__endPosition;
        private System.Windows.Forms.ComboBox extent__TimePeriod__endPosition_cbo;
        private System.Windows.Forms.Label extent__TimePeriod__description_lbl;
        private System.Windows.Forms.Label extent__TimeInstant__description_lbl;
        private System.Windows.Forms.TextBox extent__TimeInstant__description;
        private System.Windows.Forms.Button extent__TimeInstant__timePosition_btn;
        private System.Windows.Forms.DateTimePicker extent__TimeInstant__timePosition_dtP;
        private System.Windows.Forms.TextBox extent__TimeInstant__timePosition;
        private System.Windows.Forms.Label timeInstant_timePosition_lbl;
        private System.Windows.Forms.ComboBox extent__TimeInstant__timePosition_cbo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage timeInstant;
        private System.Windows.Forms.TabPage timePeriod;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel temporalExtent_lbl;

    }
}
