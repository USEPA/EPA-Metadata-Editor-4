namespace EmeLibrary
{
    partial class uc_ResponsibleParty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_ResponsibleParty));
            this.positionName = new System.Windows.Forms.TextBox();
            this.organisationName = new System.Windows.Forms.TextBox();
            this.contactInfo__CI_Contact__phone__CI_Telephone__voice = new System.Windows.Forms.TextBox();
            this.role = new System.Windows.Forms.ComboBox();
            this.individualName_lbl = new System.Windows.Forms.Label();
            this.organisationName_lbl = new System.Windows.Forms.Label();
            this.positionName_lbl = new System.Windows.Forms.Label();
            this.contactInfo__CI_Contact__phone__CI_Telephone__voice_lbl = new System.Windows.Forms.Label();
            this.contactInfo__CI_Contact__phone__CI_Telephone__facsimile_lbl = new System.Windows.Forms.Label();
            this.contactInfo__CI_Contact__phone__CI_Telephone__facsimile = new System.Windows.Forms.TextBox();
            this.individualName = new System.Windows.Forms.TextBox();
            this.contactInfo__CI_Contact__address__CI_Address__deliveryPoint_lbl = new System.Windows.Forms.Label();
            this.contactInfo__CI_Contact__address__CI_Address__deliveryPoint = new System.Windows.Forms.TextBox();
            this.contactInfo__CI_Contact__address__CI_Address__city_lbl = new System.Windows.Forms.Label();
            this.contactInfo__CI_Contact__address__CI_Address__city = new System.Windows.Forms.TextBox();
            this.contactInfo__CI_Contact__address__CI_Address__administrativeArea_lbl = new System.Windows.Forms.Label();
            this.contactInfo__CI_Contact__address__CI_Address__administrativeArea = new System.Windows.Forms.TextBox();
            this.contactInfo__CI_Contact__address__CI_Address__postalCode_lbl = new System.Windows.Forms.Label();
            this.contactInfo__CI_Contact__address__CI_Address__postalCode = new System.Windows.Forms.TextBox();
            this.contactInfo__CI_Contact__address__CI_Address__county_lbl = new System.Windows.Forms.Label();
            this.contactInfo__CI_Contact__address__CI_Address__county = new System.Windows.Forms.TextBox();
            this.contactInfo__CI_Contact__address__CI_Address__electronicMailAddress_lbl = new System.Windows.Forms.Label();
            this.contactInfo__CI_Contact__address__CI_Address__electronicMailAddress = new System.Windows.Forms.TextBox();
            this.contactInfo__CI_Contact__onlineResource__CI_OnlineResource__linkage = new System.Windows.Forms.TextBox();
            this.contactInfo__CI_Contact__hoursOfService = new System.Windows.Forms.TextBox();
            this.contactInfo__CI_Contact__hoursOfService_lbl = new System.Windows.Forms.Label();
            this.contactInfo__CI_Contact__contactInstructions_lbl = new System.Windows.Forms.Label();
            this.contactInfo__CI_Contact__contactInstructions = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CI_ContactExpand_btn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.contactInfo__CI_Contact__onlineResource__CI_OnlineResource__functionCode_lbl = new System.Windows.Forms.LinkLabel();
            this.contactInfo__CI_Contact__onlineResource__CI_OnlineResource__linkage_lbl = new System.Windows.Forms.LinkLabel();
            this.contactInfo__CI_Contact__onlineResource__CI_OnlineResource__functionCode = new System.Windows.Forms.ComboBox();
            this.pagerLbl = new System.Windows.Forms.Label();
            this.pagerDownBtn = new System.Windows.Forms.Button();
            this.pagerUpBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.deleteRP_Btn = new System.Windows.Forms.Button();
            this.addRP_Btn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.roleCode_lbl = new System.Windows.Forms.LinkLabel();
            this.dcatProgramCode = new System.Windows.Forms.ComboBox();
            this.errorProvider_RP = new System.Windows.Forms.ErrorProvider(this.components);
            this.rp_expander_btn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dcatProgramCode_lbl = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.contact_list = new System.Windows.Forms.Label();
            this.responsible_party_d = new System.Windows.Forms.Button();
            this.uc_ResponsibleParty_lbl = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_RP)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // positionName
            // 
            this.positionName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.positionName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionName.Location = new System.Drawing.Point(85, 58);
            this.positionName.Margin = new System.Windows.Forms.Padding(0);
            this.positionName.Name = "positionName";
            this.positionName.Size = new System.Drawing.Size(178, 21);
            this.positionName.TabIndex = 7;
            this.positionName.Tag = "required1";
            this.positionName.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.genericSpaciousEntryForm_MouseDoubleClick);
            this.positionName.Validating += new System.ComponentModel.CancelEventHandler(this.responsibleParty_Validating);
            // 
            // organisationName
            // 
            this.organisationName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.organisationName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.organisationName.Location = new System.Drawing.Point(85, 32);
            this.organisationName.Margin = new System.Windows.Forms.Padding(0);
            this.organisationName.Name = "organisationName";
            this.organisationName.Size = new System.Drawing.Size(178, 21);
            this.organisationName.TabIndex = 6;
            this.organisationName.Tag = "required1";
            this.organisationName.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.genericSpaciousEntryForm_MouseDoubleClick);
            this.organisationName.Validating += new System.ComponentModel.CancelEventHandler(this.responsibleParty_Validating);
            // 
            // contactInfo__CI_Contact__phone__CI_Telephone__voice
            // 
            this.contactInfo__CI_Contact__phone__CI_Telephone__voice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contactInfo__CI_Contact__phone__CI_Telephone__voice.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactInfo__CI_Contact__phone__CI_Telephone__voice.Location = new System.Drawing.Point(98, 90);
            this.contactInfo__CI_Contact__phone__CI_Telephone__voice.Name = "contactInfo__CI_Contact__phone__CI_Telephone__voice";
            this.contactInfo__CI_Contact__phone__CI_Telephone__voice.Size = new System.Drawing.Size(186, 21);
            this.contactInfo__CI_Contact__phone__CI_Telephone__voice.TabIndex = 6;
            this.contactInfo__CI_Contact__phone__CI_Telephone__voice.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.genericSpaciousEntryForm_MouseDoubleClick);
            // 
            // role
            // 
            this.role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.role.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.role.FormattingEnabled = true;
            this.role.Items.AddRange(new object[] {
            "resourceProvider",
            "custodian",
            "owner",
            "sponsor",
            "user",
            "distributor",
            "originator",
            "pointOfContact",
            "principalInvestigator",
            "processor",
            "publisher",
            "author",
            "collaborator"});
            this.role.Location = new System.Drawing.Point(85, 5);
            this.role.Margin = new System.Windows.Forms.Padding(0);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(178, 21);
            this.role.TabIndex = 4;
            this.role.Tag = "required";
            this.role.TextChanged += new System.EventHandler(this.responsibleParty_TextChangedValidation);
            this.role.Validating += new System.ComponentModel.CancelEventHandler(this.responsibleParty_Validating);
            // 
            // individualName_lbl
            // 
            this.individualName_lbl.AutoSize = true;
            this.individualName_lbl.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.individualName_lbl.Location = new System.Drawing.Point(24, 10);
            this.individualName_lbl.Margin = new System.Windows.Forms.Padding(0);
            this.individualName_lbl.Name = "individualName_lbl";
            this.individualName_lbl.Size = new System.Drawing.Size(53, 13);
            this.individualName_lbl.TabIndex = 8;
            this.individualName_lbl.Text = "Individual";
            this.individualName_lbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // organisationName_lbl
            // 
            this.organisationName_lbl.AutoSize = true;
            this.organisationName_lbl.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.organisationName_lbl.Location = new System.Drawing.Point(10, 36);
            this.organisationName_lbl.Margin = new System.Windows.Forms.Padding(0);
            this.organisationName_lbl.Name = "organisationName_lbl";
            this.organisationName_lbl.Size = new System.Drawing.Size(68, 13);
            this.organisationName_lbl.TabIndex = 9;
            this.organisationName_lbl.Text = "Organization";
            this.organisationName_lbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // positionName_lbl
            // 
            this.positionName_lbl.AutoSize = true;
            this.positionName_lbl.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionName_lbl.Location = new System.Drawing.Point(32, 60);
            this.positionName_lbl.Margin = new System.Windows.Forms.Padding(0);
            this.positionName_lbl.Name = "positionName_lbl";
            this.positionName_lbl.Size = new System.Drawing.Size(44, 13);
            this.positionName_lbl.TabIndex = 10;
            this.positionName_lbl.Text = "Position";
            this.positionName_lbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // contactInfo__CI_Contact__phone__CI_Telephone__voice_lbl
            // 
            this.contactInfo__CI_Contact__phone__CI_Telephone__voice_lbl.AutoSize = true;
            this.contactInfo__CI_Contact__phone__CI_Telephone__voice_lbl.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactInfo__CI_Contact__phone__CI_Telephone__voice_lbl.Location = new System.Drawing.Point(51, 92);
            this.contactInfo__CI_Contact__phone__CI_Telephone__voice_lbl.Name = "contactInfo__CI_Contact__phone__CI_Telephone__voice_lbl";
            this.contactInfo__CI_Contact__phone__CI_Telephone__voice_lbl.Size = new System.Drawing.Size(37, 13);
            this.contactInfo__CI_Contact__phone__CI_Telephone__voice_lbl.TabIndex = 11;
            this.contactInfo__CI_Contact__phone__CI_Telephone__voice_lbl.Text = "Phone";
            this.contactInfo__CI_Contact__phone__CI_Telephone__voice_lbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // contactInfo__CI_Contact__phone__CI_Telephone__facsimile_lbl
            // 
            this.contactInfo__CI_Contact__phone__CI_Telephone__facsimile_lbl.AutoSize = true;
            this.contactInfo__CI_Contact__phone__CI_Telephone__facsimile_lbl.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactInfo__CI_Contact__phone__CI_Telephone__facsimile_lbl.Location = new System.Drawing.Point(65, 118);
            this.contactInfo__CI_Contact__phone__CI_Telephone__facsimile_lbl.Name = "contactInfo__CI_Contact__phone__CI_Telephone__facsimile_lbl";
            this.contactInfo__CI_Contact__phone__CI_Telephone__facsimile_lbl.Size = new System.Drawing.Size(25, 13);
            this.contactInfo__CI_Contact__phone__CI_Telephone__facsimile_lbl.TabIndex = 13;
            this.contactInfo__CI_Contact__phone__CI_Telephone__facsimile_lbl.Text = "Fax";
            this.contactInfo__CI_Contact__phone__CI_Telephone__facsimile_lbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // contactInfo__CI_Contact__phone__CI_Telephone__facsimile
            // 
            this.contactInfo__CI_Contact__phone__CI_Telephone__facsimile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contactInfo__CI_Contact__phone__CI_Telephone__facsimile.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactInfo__CI_Contact__phone__CI_Telephone__facsimile.Location = new System.Drawing.Point(98, 116);
            this.contactInfo__CI_Contact__phone__CI_Telephone__facsimile.Name = "contactInfo__CI_Contact__phone__CI_Telephone__facsimile";
            this.contactInfo__CI_Contact__phone__CI_Telephone__facsimile.Size = new System.Drawing.Size(186, 21);
            this.contactInfo__CI_Contact__phone__CI_Telephone__facsimile.TabIndex = 7;
            this.contactInfo__CI_Contact__phone__CI_Telephone__facsimile.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.genericSpaciousEntryForm_MouseDoubleClick);
            // 
            // individualName
            // 
            this.individualName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.individualName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.individualName.Location = new System.Drawing.Point(85, 8);
            this.individualName.Margin = new System.Windows.Forms.Padding(0);
            this.individualName.Name = "individualName";
            this.individualName.Size = new System.Drawing.Size(178, 21);
            this.individualName.TabIndex = 5;
            this.individualName.Tag = "required1";
            this.individualName.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.genericSpaciousEntryForm_MouseDoubleClick);
            this.individualName.Validating += new System.ComponentModel.CancelEventHandler(this.responsibleParty_Validating);
            // 
            // contactInfo__CI_Contact__address__CI_Address__deliveryPoint_lbl
            // 
            this.contactInfo__CI_Contact__address__CI_Address__deliveryPoint_lbl.AutoSize = true;
            this.contactInfo__CI_Contact__address__CI_Address__deliveryPoint_lbl.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactInfo__CI_Contact__address__CI_Address__deliveryPoint_lbl.Location = new System.Drawing.Point(44, 12);
            this.contactInfo__CI_Contact__address__CI_Address__deliveryPoint_lbl.Name = "contactInfo__CI_Contact__address__CI_Address__deliveryPoint_lbl";
            this.contactInfo__CI_Contact__address__CI_Address__deliveryPoint_lbl.Size = new System.Drawing.Size(46, 13);
            this.contactInfo__CI_Contact__address__CI_Address__deliveryPoint_lbl.TabIndex = 16;
            this.contactInfo__CI_Contact__address__CI_Address__deliveryPoint_lbl.Text = "Address";
            this.contactInfo__CI_Contact__address__CI_Address__deliveryPoint_lbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // contactInfo__CI_Contact__address__CI_Address__deliveryPoint
            // 
            this.contactInfo__CI_Contact__address__CI_Address__deliveryPoint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contactInfo__CI_Contact__address__CI_Address__deliveryPoint.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactInfo__CI_Contact__address__CI_Address__deliveryPoint.Location = new System.Drawing.Point(98, 10);
            this.contactInfo__CI_Contact__address__CI_Address__deliveryPoint.Name = "contactInfo__CI_Contact__address__CI_Address__deliveryPoint";
            this.contactInfo__CI_Contact__address__CI_Address__deliveryPoint.Size = new System.Drawing.Size(315, 21);
            this.contactInfo__CI_Contact__address__CI_Address__deliveryPoint.TabIndex = 1;
            this.contactInfo__CI_Contact__address__CI_Address__deliveryPoint.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.genericSpaciousEntryForm_MouseDoubleClick);
            // 
            // contactInfo__CI_Contact__address__CI_Address__city_lbl
            // 
            this.contactInfo__CI_Contact__address__CI_Address__city_lbl.AutoSize = true;
            this.contactInfo__CI_Contact__address__CI_Address__city_lbl.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactInfo__CI_Contact__address__CI_Address__city_lbl.Location = new System.Drawing.Point(65, 38);
            this.contactInfo__CI_Contact__address__CI_Address__city_lbl.Name = "contactInfo__CI_Contact__address__CI_Address__city_lbl";
            this.contactInfo__CI_Contact__address__CI_Address__city_lbl.Size = new System.Drawing.Size(26, 13);
            this.contactInfo__CI_Contact__address__CI_Address__city_lbl.TabIndex = 18;
            this.contactInfo__CI_Contact__address__CI_Address__city_lbl.Text = "City";
            this.contactInfo__CI_Contact__address__CI_Address__city_lbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // contactInfo__CI_Contact__address__CI_Address__city
            // 
            this.contactInfo__CI_Contact__address__CI_Address__city.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contactInfo__CI_Contact__address__CI_Address__city.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactInfo__CI_Contact__address__CI_Address__city.Location = new System.Drawing.Point(98, 36);
            this.contactInfo__CI_Contact__address__CI_Address__city.Name = "contactInfo__CI_Contact__address__CI_Address__city";
            this.contactInfo__CI_Contact__address__CI_Address__city.Size = new System.Drawing.Size(100, 21);
            this.contactInfo__CI_Contact__address__CI_Address__city.TabIndex = 2;
            this.contactInfo__CI_Contact__address__CI_Address__city.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.genericSpaciousEntryForm_MouseDoubleClick);
            // 
            // contactInfo__CI_Contact__address__CI_Address__administrativeArea_lbl
            // 
            this.contactInfo__CI_Contact__address__CI_Address__administrativeArea_lbl.AutoSize = true;
            this.contactInfo__CI_Contact__address__CI_Address__administrativeArea_lbl.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactInfo__CI_Contact__address__CI_Address__administrativeArea_lbl.Location = new System.Drawing.Point(201, 38);
            this.contactInfo__CI_Contact__address__CI_Address__administrativeArea_lbl.Name = "contactInfo__CI_Contact__address__CI_Address__administrativeArea_lbl";
            this.contactInfo__CI_Contact__address__CI_Address__administrativeArea_lbl.Size = new System.Drawing.Size(78, 13);
            this.contactInfo__CI_Contact__address__CI_Address__administrativeArea_lbl.TabIndex = 20;
            this.contactInfo__CI_Contact__address__CI_Address__administrativeArea_lbl.Text = "State/Province";
            // 
            // contactInfo__CI_Contact__address__CI_Address__administrativeArea
            // 
            this.contactInfo__CI_Contact__address__CI_Address__administrativeArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contactInfo__CI_Contact__address__CI_Address__administrativeArea.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactInfo__CI_Contact__address__CI_Address__administrativeArea.Location = new System.Drawing.Point(282, 36);
            this.contactInfo__CI_Contact__address__CI_Address__administrativeArea.Name = "contactInfo__CI_Contact__address__CI_Address__administrativeArea";
            this.contactInfo__CI_Contact__address__CI_Address__administrativeArea.Size = new System.Drawing.Size(37, 21);
            this.contactInfo__CI_Contact__address__CI_Address__administrativeArea.TabIndex = 3;
            // 
            // contactInfo__CI_Contact__address__CI_Address__postalCode_lbl
            // 
            this.contactInfo__CI_Contact__address__CI_Address__postalCode_lbl.AutoSize = true;
            this.contactInfo__CI_Contact__address__CI_Address__postalCode_lbl.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactInfo__CI_Contact__address__CI_Address__postalCode_lbl.Location = new System.Drawing.Point(323, 38);
            this.contactInfo__CI_Contact__address__CI_Address__postalCode_lbl.Name = "contactInfo__CI_Contact__address__CI_Address__postalCode_lbl";
            this.contactInfo__CI_Contact__address__CI_Address__postalCode_lbl.Size = new System.Drawing.Size(21, 13);
            this.contactInfo__CI_Contact__address__CI_Address__postalCode_lbl.TabIndex = 22;
            this.contactInfo__CI_Contact__address__CI_Address__postalCode_lbl.Text = "Zip";
            // 
            // contactInfo__CI_Contact__address__CI_Address__postalCode
            // 
            this.contactInfo__CI_Contact__address__CI_Address__postalCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contactInfo__CI_Contact__address__CI_Address__postalCode.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactInfo__CI_Contact__address__CI_Address__postalCode.Location = new System.Drawing.Point(348, 36);
            this.contactInfo__CI_Contact__address__CI_Address__postalCode.Name = "contactInfo__CI_Contact__address__CI_Address__postalCode";
            this.contactInfo__CI_Contact__address__CI_Address__postalCode.Size = new System.Drawing.Size(65, 21);
            this.contactInfo__CI_Contact__address__CI_Address__postalCode.TabIndex = 4;
            // 
            // contactInfo__CI_Contact__address__CI_Address__county_lbl
            // 
            this.contactInfo__CI_Contact__address__CI_Address__county_lbl.AutoSize = true;
            this.contactInfo__CI_Contact__address__CI_Address__county_lbl.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactInfo__CI_Contact__address__CI_Address__county_lbl.Location = new System.Drawing.Point(46, 64);
            this.contactInfo__CI_Contact__address__CI_Address__county_lbl.Name = "contactInfo__CI_Contact__address__CI_Address__county_lbl";
            this.contactInfo__CI_Contact__address__CI_Address__county_lbl.Size = new System.Drawing.Size(46, 13);
            this.contactInfo__CI_Contact__address__CI_Address__county_lbl.TabIndex = 24;
            this.contactInfo__CI_Contact__address__CI_Address__county_lbl.Text = "Country";
            this.contactInfo__CI_Contact__address__CI_Address__county_lbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // contactInfo__CI_Contact__address__CI_Address__county
            // 
            this.contactInfo__CI_Contact__address__CI_Address__county.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contactInfo__CI_Contact__address__CI_Address__county.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactInfo__CI_Contact__address__CI_Address__county.Location = new System.Drawing.Point(98, 62);
            this.contactInfo__CI_Contact__address__CI_Address__county.Name = "contactInfo__CI_Contact__address__CI_Address__county";
            this.contactInfo__CI_Contact__address__CI_Address__county.Size = new System.Drawing.Size(150, 21);
            this.contactInfo__CI_Contact__address__CI_Address__county.TabIndex = 5;
            this.contactInfo__CI_Contact__address__CI_Address__county.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.genericSpaciousEntryForm_MouseDoubleClick);
            // 
            // contactInfo__CI_Contact__address__CI_Address__electronicMailAddress_lbl
            // 
            this.contactInfo__CI_Contact__address__CI_Address__electronicMailAddress_lbl.AutoSize = true;
            this.contactInfo__CI_Contact__address__CI_Address__electronicMailAddress_lbl.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactInfo__CI_Contact__address__CI_Address__electronicMailAddress_lbl.Location = new System.Drawing.Point(53, 144);
            this.contactInfo__CI_Contact__address__CI_Address__electronicMailAddress_lbl.Name = "contactInfo__CI_Contact__address__CI_Address__electronicMailAddress_lbl";
            this.contactInfo__CI_Contact__address__CI_Address__electronicMailAddress_lbl.Size = new System.Drawing.Size(35, 13);
            this.contactInfo__CI_Contact__address__CI_Address__electronicMailAddress_lbl.TabIndex = 26;
            this.contactInfo__CI_Contact__address__CI_Address__electronicMailAddress_lbl.Text = "E-Mail";
            this.contactInfo__CI_Contact__address__CI_Address__electronicMailAddress_lbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // contactInfo__CI_Contact__address__CI_Address__electronicMailAddress
            // 
            this.contactInfo__CI_Contact__address__CI_Address__electronicMailAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contactInfo__CI_Contact__address__CI_Address__electronicMailAddress.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactInfo__CI_Contact__address__CI_Address__electronicMailAddress.Location = new System.Drawing.Point(98, 142);
            this.contactInfo__CI_Contact__address__CI_Address__electronicMailAddress.Name = "contactInfo__CI_Contact__address__CI_Address__electronicMailAddress";
            this.contactInfo__CI_Contact__address__CI_Address__electronicMailAddress.Size = new System.Drawing.Size(186, 21);
            this.contactInfo__CI_Contact__address__CI_Address__electronicMailAddress.TabIndex = 8;
            this.contactInfo__CI_Contact__address__CI_Address__electronicMailAddress.Tag = "required";
            this.contactInfo__CI_Contact__address__CI_Address__electronicMailAddress.TextChanged += new System.EventHandler(this.responsibleParty_TextChangedValidation);
            this.contactInfo__CI_Contact__address__CI_Address__electronicMailAddress.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.genericSpaciousEntryForm_MouseDoubleClick);
            // 
            // contactInfo__CI_Contact__onlineResource__CI_OnlineResource__linkage
            // 
            this.contactInfo__CI_Contact__onlineResource__CI_OnlineResource__linkage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contactInfo__CI_Contact__onlineResource__CI_OnlineResource__linkage.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactInfo__CI_Contact__onlineResource__CI_OnlineResource__linkage.Location = new System.Drawing.Point(98, 168);
            this.contactInfo__CI_Contact__onlineResource__CI_OnlineResource__linkage.Name = "contactInfo__CI_Contact__onlineResource__CI_OnlineResource__linkage";
            this.contactInfo__CI_Contact__onlineResource__CI_OnlineResource__linkage.Size = new System.Drawing.Size(186, 21);
            this.contactInfo__CI_Contact__onlineResource__CI_OnlineResource__linkage.TabIndex = 9;
            this.contactInfo__CI_Contact__onlineResource__CI_OnlineResource__linkage.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.genericSpaciousEntryForm_MouseDoubleClick);
            // 
            // contactInfo__CI_Contact__hoursOfService
            // 
            this.contactInfo__CI_Contact__hoursOfService.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contactInfo__CI_Contact__hoursOfService.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactInfo__CI_Contact__hoursOfService.Location = new System.Drawing.Point(98, 221);
            this.contactInfo__CI_Contact__hoursOfService.Name = "contactInfo__CI_Contact__hoursOfService";
            this.contactInfo__CI_Contact__hoursOfService.Size = new System.Drawing.Size(186, 21);
            this.contactInfo__CI_Contact__hoursOfService.TabIndex = 11;
            this.contactInfo__CI_Contact__hoursOfService.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.genericSpaciousEntryForm_MouseDoubleClick);
            // 
            // contactInfo__CI_Contact__hoursOfService_lbl
            // 
            this.contactInfo__CI_Contact__hoursOfService_lbl.AutoSize = true;
            this.contactInfo__CI_Contact__hoursOfService_lbl.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactInfo__CI_Contact__hoursOfService_lbl.Location = new System.Drawing.Point(3, 222);
            this.contactInfo__CI_Contact__hoursOfService_lbl.Name = "contactInfo__CI_Contact__hoursOfService_lbl";
            this.contactInfo__CI_Contact__hoursOfService_lbl.Size = new System.Drawing.Size(86, 13);
            this.contactInfo__CI_Contact__hoursOfService_lbl.TabIndex = 32;
            this.contactInfo__CI_Contact__hoursOfService_lbl.Text = "Hours of Service";
            this.contactInfo__CI_Contact__hoursOfService_lbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // contactInfo__CI_Contact__contactInstructions_lbl
            // 
            this.contactInfo__CI_Contact__contactInstructions_lbl.AutoSize = true;
            this.contactInfo__CI_Contact__contactInstructions_lbl.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactInfo__CI_Contact__contactInstructions_lbl.Location = new System.Drawing.Point(28, 248);
            this.contactInfo__CI_Contact__contactInstructions_lbl.Name = "contactInfo__CI_Contact__contactInstructions_lbl";
            this.contactInfo__CI_Contact__contactInstructions_lbl.Size = new System.Drawing.Size(64, 26);
            this.contactInfo__CI_Contact__contactInstructions_lbl.TabIndex = 34;
            this.contactInfo__CI_Contact__contactInstructions_lbl.Text = "Contact\r\nInstructions";
            this.contactInfo__CI_Contact__contactInstructions_lbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // contactInfo__CI_Contact__contactInstructions
            // 
            this.contactInfo__CI_Contact__contactInstructions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contactInfo__CI_Contact__contactInstructions.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactInfo__CI_Contact__contactInstructions.Location = new System.Drawing.Point(98, 246);
            this.contactInfo__CI_Contact__contactInstructions.Multiline = true;
            this.contactInfo__CI_Contact__contactInstructions.Name = "contactInfo__CI_Contact__contactInstructions";
            this.contactInfo__CI_Contact__contactInstructions.Size = new System.Drawing.Size(315, 53);
            this.contactInfo__CI_Contact__contactInstructions.TabIndex = 12;
            this.contactInfo__CI_Contact__contactInstructions.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.genericSpaciousEntryForm_MouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CI_ContactExpand_btn);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Location = new System.Drawing.Point(3, 130);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 22);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "                                 ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Contact Details";
            // 
            // CI_ContactExpand_btn
            // 
            this.CI_ContactExpand_btn.BackColor = System.Drawing.SystemColors.Control;
            this.CI_ContactExpand_btn.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.CI_ContactExpand_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CI_ContactExpand_btn.Font = new System.Drawing.Font("Arial Unicode MS", 10F);
            this.CI_ContactExpand_btn.Location = new System.Drawing.Point(4, -1);
            this.CI_ContactExpand_btn.Name = "CI_ContactExpand_btn";
            this.CI_ContactExpand_btn.Size = new System.Drawing.Size(22, 22);
            this.CI_ContactExpand_btn.TabIndex = 0;
            this.CI_ContactExpand_btn.Text = "+";
            this.CI_ContactExpand_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.CI_ContactExpand_btn.UseVisualStyleBackColor = false;
            this.CI_ContactExpand_btn.Click += new System.EventHandler(this.Expander_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel4.Controls.Add(this.contactInfo__CI_Contact__onlineResource__CI_OnlineResource__functionCode_lbl);
            this.panel4.Controls.Add(this.contactInfo__CI_Contact__onlineResource__CI_OnlineResource__linkage_lbl);
            this.panel4.Controls.Add(this.contactInfo__CI_Contact__address__CI_Address__deliveryPoint_lbl);
            this.panel4.Controls.Add(this.contactInfo__CI_Contact__onlineResource__CI_OnlineResource__functionCode);
            this.panel4.Controls.Add(this.contactInfo__CI_Contact__phone__CI_Telephone__voice);
            this.panel4.Controls.Add(this.contactInfo__CI_Contact__address__CI_Address__deliveryPoint);
            this.panel4.Controls.Add(this.contactInfo__CI_Contact__address__CI_Address__electronicMailAddress);
            this.panel4.Controls.Add(this.contactInfo__CI_Contact__address__CI_Address__electronicMailAddress_lbl);
            this.panel4.Controls.Add(this.contactInfo__CI_Contact__contactInstructions_lbl);
            this.panel4.Controls.Add(this.contactInfo__CI_Contact__address__CI_Address__county_lbl);
            this.panel4.Controls.Add(this.contactInfo__CI_Contact__address__CI_Address__city);
            this.panel4.Controls.Add(this.contactInfo__CI_Contact__phone__CI_Telephone__voice_lbl);
            this.panel4.Controls.Add(this.contactInfo__CI_Contact__onlineResource__CI_OnlineResource__linkage);
            this.panel4.Controls.Add(this.contactInfo__CI_Contact__contactInstructions);
            this.panel4.Controls.Add(this.contactInfo__CI_Contact__phone__CI_Telephone__facsimile);
            this.panel4.Controls.Add(this.contactInfo__CI_Contact__address__CI_Address__city_lbl);
            this.panel4.Controls.Add(this.contactInfo__CI_Contact__address__CI_Address__county);
            this.panel4.Controls.Add(this.contactInfo__CI_Contact__hoursOfService_lbl);
            this.panel4.Controls.Add(this.contactInfo__CI_Contact__phone__CI_Telephone__facsimile_lbl);
            this.panel4.Controls.Add(this.contactInfo__CI_Contact__address__CI_Address__administrativeArea);
            this.panel4.Controls.Add(this.contactInfo__CI_Contact__address__CI_Address__administrativeArea_lbl);
            this.panel4.Controls.Add(this.contactInfo__CI_Contact__address__CI_Address__postalCode_lbl);
            this.panel4.Controls.Add(this.contactInfo__CI_Contact__hoursOfService);
            this.panel4.Controls.Add(this.contactInfo__CI_Contact__address__CI_Address__postalCode);
            this.panel4.Location = new System.Drawing.Point(0, 22);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(419, 307);
            this.panel4.TabIndex = 35;
            // 
            // contactInfo__CI_Contact__onlineResource__CI_OnlineResource__functionCode_lbl
            // 
            this.contactInfo__CI_Contact__onlineResource__CI_OnlineResource__functionCode_lbl.AutoSize = true;
            this.contactInfo__CI_Contact__onlineResource__CI_OnlineResource__functionCode_lbl.Location = new System.Drawing.Point(17, 197);
            this.contactInfo__CI_Contact__onlineResource__CI_OnlineResource__functionCode_lbl.Name = "contactInfo__CI_Contact__onlineResource__CI_OnlineResource__functionCode_lbl";
            this.contactInfo__CI_Contact__onlineResource__CI_OnlineResource__functionCode_lbl.Size = new System.Drawing.Size(72, 13);
            this.contactInfo__CI_Contact__onlineResource__CI_OnlineResource__functionCode_lbl.TabIndex = 37;
            this.contactInfo__CI_Contact__onlineResource__CI_OnlineResource__functionCode_lbl.TabStop = true;
            this.contactInfo__CI_Contact__onlineResource__CI_OnlineResource__functionCode_lbl.Text = "Linkage Type";
            this.contactInfo__CI_Contact__onlineResource__CI_OnlineResource__functionCode_lbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.genericOpenHelpFromLinkLabel_LinkClicked);
            // 
            // contactInfo__CI_Contact__onlineResource__CI_OnlineResource__linkage_lbl
            // 
            this.contactInfo__CI_Contact__onlineResource__CI_OnlineResource__linkage_lbl.AutoSize = true;
            this.contactInfo__CI_Contact__onlineResource__CI_OnlineResource__linkage_lbl.Location = new System.Drawing.Point(43, 171);
            this.contactInfo__CI_Contact__onlineResource__CI_OnlineResource__linkage_lbl.Name = "contactInfo__CI_Contact__onlineResource__CI_OnlineResource__linkage_lbl";
            this.contactInfo__CI_Contact__onlineResource__CI_OnlineResource__linkage_lbl.Size = new System.Drawing.Size(45, 13);
            this.contactInfo__CI_Contact__onlineResource__CI_OnlineResource__linkage_lbl.TabIndex = 36;
            this.contactInfo__CI_Contact__onlineResource__CI_OnlineResource__linkage_lbl.TabStop = true;
            this.contactInfo__CI_Contact__onlineResource__CI_OnlineResource__linkage_lbl.Text = "Linkage";
            this.contactInfo__CI_Contact__onlineResource__CI_OnlineResource__linkage_lbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.genericOpenHelpFromLinkLabel_LinkClicked);
            // 
            // contactInfo__CI_Contact__onlineResource__CI_OnlineResource__functionCode
            // 
            this.contactInfo__CI_Contact__onlineResource__CI_OnlineResource__functionCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.contactInfo__CI_Contact__onlineResource__CI_OnlineResource__functionCode.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactInfo__CI_Contact__onlineResource__CI_OnlineResource__functionCode.FormattingEnabled = true;
            this.contactInfo__CI_Contact__onlineResource__CI_OnlineResource__functionCode.Items.AddRange(new object[] {
            "",
            "download",
            "information",
            "offlineAccess",
            "order",
            "search"});
            this.contactInfo__CI_Contact__onlineResource__CI_OnlineResource__functionCode.Location = new System.Drawing.Point(98, 194);
            this.contactInfo__CI_Contact__onlineResource__CI_OnlineResource__functionCode.Name = "contactInfo__CI_Contact__onlineResource__CI_OnlineResource__functionCode";
            this.contactInfo__CI_Contact__onlineResource__CI_OnlineResource__functionCode.Size = new System.Drawing.Size(186, 21);
            this.contactInfo__CI_Contact__onlineResource__CI_OnlineResource__functionCode.TabIndex = 10;
            // 
            // pagerLbl
            // 
            this.pagerLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pagerLbl.AutoSize = true;
            this.pagerLbl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagerLbl.Location = new System.Drawing.Point(104, 6);
            this.pagerLbl.Name = "pagerLbl";
            this.pagerLbl.Size = new System.Drawing.Size(41, 16);
            this.pagerLbl.TabIndex = 0;
            this.pagerLbl.Text = "0 of 0";
            this.pagerLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pagerDownBtn
            // 
            this.pagerDownBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.pagerDownBtn.FlatAppearance.BorderSize = 0;
            this.pagerDownBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pagerDownBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagerDownBtn.Location = new System.Drawing.Point(75, 3);
            this.pagerDownBtn.Name = "pagerDownBtn";
            this.pagerDownBtn.Size = new System.Drawing.Size(23, 23);
            this.pagerDownBtn.TabIndex = 0;
            this.pagerDownBtn.TabStop = false;
            this.pagerDownBtn.Text = "<";
            this.pagerDownBtn.UseVisualStyleBackColor = false;
            this.pagerDownBtn.Visible = false;
            this.pagerDownBtn.Click += new System.EventHandler(this.pagerDownBtn_Click);
            // 
            // pagerUpBtn
            // 
            this.pagerUpBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.pagerUpBtn.FlatAppearance.BorderSize = 0;
            this.pagerUpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pagerUpBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagerUpBtn.Location = new System.Drawing.Point(151, 3);
            this.pagerUpBtn.Name = "pagerUpBtn";
            this.pagerUpBtn.Size = new System.Drawing.Size(23, 23);
            this.pagerUpBtn.TabIndex = 0;
            this.pagerUpBtn.TabStop = false;
            this.pagerUpBtn.Text = ">";
            this.pagerUpBtn.UseVisualStyleBackColor = false;
            this.pagerUpBtn.Visible = false;
            this.pagerUpBtn.Click += new System.EventHandler(this.pagerUpBtn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.deleteRP_Btn);
            this.flowLayoutPanel1.Controls.Add(this.addRP_Btn);
            this.flowLayoutPanel1.Controls.Add(this.pagerUpBtn);
            this.flowLayoutPanel1.Controls.Add(this.pagerLbl);
            this.flowLayoutPanel1.Controls.Add(this.pagerDownBtn);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(201, 3);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(235, 30);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.TabStop = true;
            // 
            // deleteRP_Btn
            // 
            this.deleteRP_Btn.Enabled = false;
            this.deleteRP_Btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.deleteRP_Btn.FlatAppearance.BorderSize = 0;
            this.deleteRP_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteRP_Btn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteRP_Btn.Image = ((System.Drawing.Image)(resources.GetObject("deleteRP_Btn.Image")));
            this.deleteRP_Btn.Location = new System.Drawing.Point(209, 3);
            this.deleteRP_Btn.Name = "deleteRP_Btn";
            this.deleteRP_Btn.Size = new System.Drawing.Size(23, 23);
            this.deleteRP_Btn.TabIndex = 0;
            this.deleteRP_Btn.TabStop = false;
            this.deleteRP_Btn.Tag = "required";
            this.deleteRP_Btn.UseVisualStyleBackColor = true;
            this.deleteRP_Btn.Click += new System.EventHandler(this.deleteRP_Btn_Click);
            // 
            // addRP_Btn
            // 
            this.addRP_Btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addRP_Btn.Enabled = false;
            this.addRP_Btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addRP_Btn.FlatAppearance.BorderSize = 0;
            this.addRP_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addRP_Btn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRP_Btn.Image = ((System.Drawing.Image)(resources.GetObject("addRP_Btn.Image")));
            this.addRP_Btn.Location = new System.Drawing.Point(180, 3);
            this.addRP_Btn.Name = "addRP_Btn";
            this.addRP_Btn.Size = new System.Drawing.Size(23, 23);
            this.addRP_Btn.TabIndex = 0;
            this.addRP_Btn.Tag = "required";
            this.addRP_Btn.UseVisualStyleBackColor = true;
            this.addRP_Btn.Click += new System.EventHandler(this.addRP_Btn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.DropDownWidth = 600;
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(19, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.individualName);
            this.panel1.Controls.Add(this.positionName);
            this.panel1.Controls.Add(this.positionName_lbl);
            this.panel1.Controls.Add(this.organisationName_lbl);
            this.panel1.Controls.Add(this.organisationName);
            this.panel1.Controls.Add(this.individualName_lbl);
            this.errorProvider_RP.SetIconPadding(this.panel1, -15);
            this.panel1.Location = new System.Drawing.Point(3, 36);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 90);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.roleCode_lbl);
            this.panel2.Controls.Add(this.role);
            this.panel2.Location = new System.Drawing.Point(3, 5);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 33);
            this.panel2.TabIndex = 4;
            // 
            // roleCode_lbl
            // 
            this.roleCode_lbl.AutoSize = true;
            this.roleCode_lbl.Location = new System.Drawing.Point(47, 8);
            this.roleCode_lbl.Name = "roleCode_lbl";
            this.roleCode_lbl.Size = new System.Drawing.Size(29, 13);
            this.roleCode_lbl.TabIndex = 35;
            this.roleCode_lbl.TabStop = true;
            this.roleCode_lbl.Text = "Role";
            this.roleCode_lbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.genericOpenHelpFromLinkLabel_LinkClicked);
            // 
            // dcatProgramCode
            // 
            this.dcatProgramCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dcatProgramCode.DropDownWidth = 600;
            this.dcatProgramCode.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dcatProgramCode.FormattingEnabled = true;
            this.dcatProgramCode.Location = new System.Drawing.Point(12, 84);
            this.dcatProgramCode.Name = "dcatProgramCode";
            this.dcatProgramCode.Size = new System.Drawing.Size(112, 21);
            this.dcatProgramCode.TabIndex = 3;
            this.dcatProgramCode.Tag = "";
            // 
            // errorProvider_RP
            // 
            this.errorProvider_RP.ContainerControl = this;
            // 
            // rp_expander_btn
            // 
            this.rp_expander_btn.Enabled = false;
            this.rp_expander_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rp_expander_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rp_expander_btn.Font = new System.Drawing.Font("Arial Unicode MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rp_expander_btn.Location = new System.Drawing.Point(7, 6);
            this.rp_expander_btn.Margin = new System.Windows.Forms.Padding(0);
            this.rp_expander_btn.Name = "rp_expander_btn";
            this.rp_expander_btn.Size = new System.Drawing.Size(22, 22);
            this.rp_expander_btn.TabIndex = 1;
            this.rp_expander_btn.Text = "+";
            this.rp_expander_btn.UseVisualStyleBackColor = true;
            this.rp_expander_btn.Click += new System.EventHandler(this.Expander_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Location = new System.Drawing.Point(2, 36);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(435, 464);
            this.panel3.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel5.Controls.Add(this.dcatProgramCode_lbl);
            this.panel5.Controls.Add(this.groupBox2);
            this.panel5.Controls.Add(this.dcatProgramCode);
            this.panel5.Location = new System.Drawing.Point(292, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(133, 116);
            this.panel5.TabIndex = 38;
            // 
            // dcatProgramCode_lbl
            // 
            this.dcatProgramCode_lbl.AutoSize = true;
            this.dcatProgramCode_lbl.Location = new System.Drawing.Point(31, 68);
            this.dcatProgramCode_lbl.Name = "dcatProgramCode_lbl";
            this.dcatProgramCode_lbl.Size = new System.Drawing.Size(74, 13);
            this.dcatProgramCode_lbl.TabIndex = 37;
            this.dcatProgramCode_lbl.TabStop = true;
            this.dcatProgramCode_lbl.Text = "Program Code";
            this.dcatProgramCode_lbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.genericOpenHelpFromLinkLabel_LinkClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.contact_list);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.responsible_party_d);
            this.groupBox2.Location = new System.Drawing.Point(23, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(94, 60);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // contact_list
            // 
            this.contact_list.AutoSize = true;
            this.contact_list.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact_list.Location = new System.Drawing.Point(10, 11);
            this.contact_list.Name = "contact_list";
            this.contact_list.Size = new System.Drawing.Size(77, 13);
            this.contact_list.TabIndex = 2;
            this.contact_list.Text = "Select Contact";
            this.contact_list.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // responsible_party_d
            // 
            this.responsible_party_d.BackColor = System.Drawing.SystemColors.Control;
            this.responsible_party_d.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.responsible_party_d.Location = new System.Drawing.Point(50, 29);
            this.responsible_party_d.Name = "responsible_party_d";
            this.responsible_party_d.Size = new System.Drawing.Size(28, 22);
            this.responsible_party_d.TabIndex = 1;
            this.responsible_party_d.Text = "D";
            this.responsible_party_d.UseVisualStyleBackColor = false;
            this.responsible_party_d.Click += new System.EventHandler(this.responsible_party_d_Click);
            // 
            // uc_ResponsibleParty_lbl
            // 
            this.uc_ResponsibleParty_lbl.AutoSize = true;
            this.uc_ResponsibleParty_lbl.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_ResponsibleParty_lbl.Location = new System.Drawing.Point(33, 9);
            this.uc_ResponsibleParty_lbl.Name = "uc_ResponsibleParty_lbl";
            this.uc_ResponsibleParty_lbl.Size = new System.Drawing.Size(0, 13);
            this.uc_ResponsibleParty_lbl.TabIndex = 45;
            this.uc_ResponsibleParty_lbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.genericOpenHelpFromLinkLabel_LinkClicked);
            // 
            // uc_ResponsibleParty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.uc_ResponsibleParty_lbl);
            this.Controls.Add(this.rp_expander_btn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "uc_ResponsibleParty";
            this.Size = new System.Drawing.Size(439, 500);
            this.Load += new System.EventHandler(this.uc_ResponsibleParty_Load);
            this.Leave += new System.EventHandler(this.uc_ResponsibleParty_Leave);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_RP)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox positionName;
        private System.Windows.Forms.TextBox organisationName;
        private System.Windows.Forms.TextBox contactInfo__CI_Contact__phone__CI_Telephone__voice;
        private System.Windows.Forms.ComboBox role;
        private System.Windows.Forms.Label individualName_lbl;
        private System.Windows.Forms.Label organisationName_lbl;
        private System.Windows.Forms.Label positionName_lbl;
        private System.Windows.Forms.Label contactInfo__CI_Contact__phone__CI_Telephone__voice_lbl;
        private System.Windows.Forms.Label contactInfo__CI_Contact__phone__CI_Telephone__facsimile_lbl;
        private System.Windows.Forms.TextBox contactInfo__CI_Contact__phone__CI_Telephone__facsimile;
        private System.Windows.Forms.TextBox individualName;
        private System.Windows.Forms.Label contactInfo__CI_Contact__address__CI_Address__deliveryPoint_lbl;
        private System.Windows.Forms.TextBox contactInfo__CI_Contact__address__CI_Address__deliveryPoint;
        private System.Windows.Forms.Label contactInfo__CI_Contact__address__CI_Address__city_lbl;
        private System.Windows.Forms.TextBox contactInfo__CI_Contact__address__CI_Address__city;
        private System.Windows.Forms.Label contactInfo__CI_Contact__address__CI_Address__administrativeArea_lbl;
        private System.Windows.Forms.TextBox contactInfo__CI_Contact__address__CI_Address__administrativeArea;
        private System.Windows.Forms.Label contactInfo__CI_Contact__address__CI_Address__postalCode_lbl;
        private System.Windows.Forms.TextBox contactInfo__CI_Contact__address__CI_Address__postalCode;
        private System.Windows.Forms.Label contactInfo__CI_Contact__address__CI_Address__county_lbl;
        private System.Windows.Forms.TextBox contactInfo__CI_Contact__address__CI_Address__county;
        private System.Windows.Forms.Label contactInfo__CI_Contact__address__CI_Address__electronicMailAddress_lbl;
        private System.Windows.Forms.TextBox contactInfo__CI_Contact__address__CI_Address__electronicMailAddress;
        private System.Windows.Forms.TextBox contactInfo__CI_Contact__onlineResource__CI_OnlineResource__linkage;
        private System.Windows.Forms.TextBox contactInfo__CI_Contact__hoursOfService;
        private System.Windows.Forms.Label contactInfo__CI_Contact__hoursOfService_lbl;
        private System.Windows.Forms.Label contactInfo__CI_Contact__contactInstructions_lbl;
        private System.Windows.Forms.TextBox contactInfo__CI_Contact__contactInstructions;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox contactInfo__CI_Contact__onlineResource__CI_OnlineResource__functionCode;
        private System.Windows.Forms.Label pagerLbl;
        private System.Windows.Forms.Button pagerDownBtn;
        private System.Windows.Forms.Button pagerUpBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button addRP_Btn;
        private System.Windows.Forms.Button deleteRP_Btn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ErrorProvider errorProvider_RP;
        private System.Windows.Forms.Button rp_expander_btn;
        private System.Windows.Forms.Button CI_ContactExpand_btn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox dcatProgramCode;
        private System.Windows.Forms.Button responsible_party_d;
        private System.Windows.Forms.Label contact_list;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel uc_ResponsibleParty_lbl;
        private System.Windows.Forms.LinkLabel roleCode_lbl;
        private System.Windows.Forms.LinkLabel dcatProgramCode_lbl;
        private System.Windows.Forms.LinkLabel contactInfo__CI_Contact__onlineResource__CI_OnlineResource__functionCode_lbl;
        private System.Windows.Forms.LinkLabel contactInfo__CI_Contact__onlineResource__CI_OnlineResource__linkage_lbl;
    }
}
