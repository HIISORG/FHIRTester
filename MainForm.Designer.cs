namespace FHIRTester {
	partial class MainForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.mainMenu = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.uRLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.labelURL = new System.Windows.Forms.Label();
			this.buttonGo = new System.Windows.Forms.Button();
			this.textBoxResponse = new System.Windows.Forms.TextBox();
			this.labelResponse = new System.Windows.Forms.Label();
			this.labelType = new System.Windows.Forms.Label();
			this.radioButtonTypeRead = new System.Windows.Forms.RadioButton();
			this.radioButtonTypeVRead = new System.Windows.Forms.RadioButton();
			this.groupBoxAPIType = new System.Windows.Forms.GroupBox();
			this.radioButtonTypeCustom = new System.Windows.Forms.RadioButton();
			this.radioButtonTypeBatch = new System.Windows.Forms.RadioButton();
			this.radioButtonTypeConformance = new System.Windows.Forms.RadioButton();
			this.radioButtonTypeSearch = new System.Windows.Forms.RadioButton();
			this.radioButtonTypeCreate = new System.Windows.Forms.RadioButton();
			this.radioButtonTypeHistory = new System.Windows.Forms.RadioButton();
			this.radioButtonTypeDelete = new System.Windows.Forms.RadioButton();
			this.radioButtonTypeUpdate = new System.Windows.Forms.RadioButton();
			this.labelSecurity = new System.Windows.Forms.Label();
			this.groupBoxSecurityOption = new System.Windows.Forms.GroupBox();
			this.radioButtonSecurityToken = new System.Windows.Forms.RadioButton();
			this.radioButtonSecurityUser = new System.Windows.Forms.RadioButton();
			this.textBoxToken = new System.Windows.Forms.TextBox();
			this.labelUserName = new System.Windows.Forms.Label();
			this.textBoxUserName = new System.Windows.Forms.TextBox();
			this.labelPassword = new System.Windows.Forms.Label();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.labelToken = new System.Windows.Forms.Label();
			this.labelData = new System.Windows.Forms.Label();
			this.textBoxData = new System.Windows.Forms.TextBox();
			this.labelResponseFormat = new System.Windows.Forms.Label();
			this.comboBoxResponseFormat = new System.Windows.Forms.ComboBox();
			this.labelRequestVerb = new System.Windows.Forms.Label();
			this.comboBoxRequestVerb = new System.Windows.Forms.ComboBox();
			this.labelContentType = new System.Windows.Forms.Label();
			this.comboBoxContentType = new System.Windows.Forms.ComboBox();
			this.buttonValueSet = new System.Windows.Forms.Button();
			this.comboBoxValueSet = new System.Windows.Forms.ComboBox();
			this.labelValueSet = new System.Windows.Forms.Label();
			this.buttonTest = new System.Windows.Forms.Button();
			this.labelResource = new System.Windows.Forms.Label();
			this.textBoxResource = new System.Windows.Forms.TextBox();
			this.buttonPushData = new System.Windows.Forms.Button();
			this.buttonGetData = new System.Windows.Forms.Button();
			this.comboBoxServer = new System.Windows.Forms.ComboBox();
			this.mainMenu.SuspendLayout();
			this.groupBoxAPIType.SuspendLayout();
			this.groupBoxSecurityOption.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainMenu
			// 
			this.mainMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.mainMenu.Location = new System.Drawing.Point(0, 0);
			this.mainMenu.Name = "mainMenu";
			this.mainMenu.Size = new System.Drawing.Size(1733, 43);
			this.mainMenu.TabIndex = 0;
			this.mainMenu.Text = "Main Menu";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 39);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uRLToolStripMenuItem});
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
			this.openToolStripMenuItem.Size = new System.Drawing.Size(257, 40);
			this.openToolStripMenuItem.Text = "Open";
			// 
			// uRLToolStripMenuItem
			// 
			this.uRLToolStripMenuItem.Name = "uRLToolStripMenuItem";
			this.uRLToolStripMenuItem.Size = new System.Drawing.Size(159, 40);
			this.uRLToolStripMenuItem.Text = "URL";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(254, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(257, 40);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// labelURL
			// 
			this.labelURL.AutoSize = true;
			this.labelURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelURL.Location = new System.Drawing.Point(12, 43);
			this.labelURL.Name = "labelURL";
			this.labelURL.Size = new System.Drawing.Size(66, 26);
			this.labelURL.TabIndex = 1;
			this.labelURL.Text = "URL:";
			// 
			// buttonGo
			// 
			this.buttonGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonGo.Location = new System.Drawing.Point(1646, 43);
			this.buttonGo.Name = "buttonGo";
			this.buttonGo.Size = new System.Drawing.Size(75, 71);
			this.buttonGo.TabIndex = 3;
			this.buttonGo.Text = "GO";
			this.buttonGo.UseVisualStyleBackColor = true;
			this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
			// 
			// textBoxResponse
			// 
			this.textBoxResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxResponse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxResponse.Location = new System.Drawing.Point(12, 589);
			this.textBoxResponse.Multiline = true;
			this.textBoxResponse.Name = "textBoxResponse";
			this.textBoxResponse.ReadOnly = true;
			this.textBoxResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxResponse.Size = new System.Drawing.Size(1709, 475);
			this.textBoxResponse.TabIndex = 4;
			this.textBoxResponse.DoubleClick += new System.EventHandler(this.textBoxResponse_DoubleClick);
			// 
			// labelResponse
			// 
			this.labelResponse.AutoSize = true;
			this.labelResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelResponse.Location = new System.Drawing.Point(12, 560);
			this.labelResponse.Name = "labelResponse";
			this.labelResponse.Size = new System.Drawing.Size(202, 26);
			this.labelResponse.TabIndex = 5;
			this.labelResponse.Text = "Server Response:";
			// 
			// labelType
			// 
			this.labelType.AutoSize = true;
			this.labelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelType.Location = new System.Drawing.Point(12, 108);
			this.labelType.Name = "labelType";
			this.labelType.Size = new System.Drawing.Size(116, 26);
			this.labelType.TabIndex = 6;
			this.labelType.Text = "API Type:";
			// 
			// radioButtonTypeRead
			// 
			this.radioButtonTypeRead.AutoSize = true;
			this.radioButtonTypeRead.Location = new System.Drawing.Point(20, 25);
			this.radioButtonTypeRead.Name = "radioButtonTypeRead";
			this.radioButtonTypeRead.Size = new System.Drawing.Size(80, 30);
			this.radioButtonTypeRead.TabIndex = 7;
			this.radioButtonTypeRead.Text = "read";
			this.radioButtonTypeRead.UseVisualStyleBackColor = true;
			this.radioButtonTypeRead.CheckedChanged += new System.EventHandler(this.radioButtonTypeRead_CheckedChanged);
			// 
			// radioButtonTypeVRead
			// 
			this.radioButtonTypeVRead.AutoSize = true;
			this.radioButtonTypeVRead.Location = new System.Drawing.Point(106, 25);
			this.radioButtonTypeVRead.Name = "radioButtonTypeVRead";
			this.radioButtonTypeVRead.Size = new System.Drawing.Size(91, 30);
			this.radioButtonTypeVRead.TabIndex = 8;
			this.radioButtonTypeVRead.Text = "vread";
			this.radioButtonTypeVRead.UseVisualStyleBackColor = true;
			this.radioButtonTypeVRead.CheckedChanged += new System.EventHandler(this.radioButtonTypeVRead_CheckedChanged);
			// 
			// groupBoxAPIType
			// 
			this.groupBoxAPIType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBoxAPIType.Controls.Add(this.radioButtonTypeCustom);
			this.groupBoxAPIType.Controls.Add(this.radioButtonTypeBatch);
			this.groupBoxAPIType.Controls.Add(this.radioButtonTypeConformance);
			this.groupBoxAPIType.Controls.Add(this.radioButtonTypeSearch);
			this.groupBoxAPIType.Controls.Add(this.radioButtonTypeCreate);
			this.groupBoxAPIType.Controls.Add(this.radioButtonTypeHistory);
			this.groupBoxAPIType.Controls.Add(this.radioButtonTypeDelete);
			this.groupBoxAPIType.Controls.Add(this.radioButtonTypeUpdate);
			this.groupBoxAPIType.Controls.Add(this.radioButtonTypeRead);
			this.groupBoxAPIType.Controls.Add(this.radioButtonTypeVRead);
			this.groupBoxAPIType.Location = new System.Drawing.Point(134, 80);
			this.groupBoxAPIType.Name = "groupBoxAPIType";
			this.groupBoxAPIType.Size = new System.Drawing.Size(1506, 72);
			this.groupBoxAPIType.TabIndex = 9;
			this.groupBoxAPIType.TabStop = false;
			// 
			// radioButtonTypeCustom
			// 
			this.radioButtonTypeCustom.AutoSize = true;
			this.radioButtonTypeCustom.Checked = true;
			this.radioButtonTypeCustom.Location = new System.Drawing.Point(1230, 25);
			this.radioButtonTypeCustom.Name = "radioButtonTypeCustom";
			this.radioButtonTypeCustom.Size = new System.Drawing.Size(108, 30);
			this.radioButtonTypeCustom.TabIndex = 16;
			this.radioButtonTypeCustom.TabStop = true;
			this.radioButtonTypeCustom.Text = "custom";
			this.radioButtonTypeCustom.UseVisualStyleBackColor = true;
			// 
			// radioButtonTypeBatch
			// 
			this.radioButtonTypeBatch.AutoSize = true;
			this.radioButtonTypeBatch.Location = new System.Drawing.Point(967, 25);
			this.radioButtonTypeBatch.Name = "radioButtonTypeBatch";
			this.radioButtonTypeBatch.Size = new System.Drawing.Size(202, 30);
			this.radioButtonTypeBatch.TabIndex = 15;
			this.radioButtonTypeBatch.Text = "batch/transaction";
			this.radioButtonTypeBatch.UseVisualStyleBackColor = true;
			this.radioButtonTypeBatch.CheckedChanged += new System.EventHandler(this.radioButtonTypeBatch_CheckedChanged);
			// 
			// radioButtonTypeConformance
			// 
			this.radioButtonTypeConformance.AutoSize = true;
			this.radioButtonTypeConformance.Location = new System.Drawing.Point(798, 25);
			this.radioButtonTypeConformance.Name = "radioButtonTypeConformance";
			this.radioButtonTypeConformance.Size = new System.Drawing.Size(163, 30);
			this.radioButtonTypeConformance.TabIndex = 14;
			this.radioButtonTypeConformance.Text = "conformance";
			this.radioButtonTypeConformance.UseVisualStyleBackColor = true;
			// 
			// radioButtonTypeSearch
			// 
			this.radioButtonTypeSearch.AutoSize = true;
			this.radioButtonTypeSearch.Location = new System.Drawing.Point(690, 25);
			this.radioButtonTypeSearch.Name = "radioButtonTypeSearch";
			this.radioButtonTypeSearch.Size = new System.Drawing.Size(102, 30);
			this.radioButtonTypeSearch.TabIndex = 13;
			this.radioButtonTypeSearch.Text = "search";
			this.radioButtonTypeSearch.UseVisualStyleBackColor = true;
			this.radioButtonTypeSearch.CheckedChanged += new System.EventHandler(this.radioButtonTypeSearch_CheckedChanged);
			// 
			// radioButtonTypeCreate
			// 
			this.radioButtonTypeCreate.AutoSize = true;
			this.radioButtonTypeCreate.Location = new System.Drawing.Point(587, 25);
			this.radioButtonTypeCreate.Name = "radioButtonTypeCreate";
			this.radioButtonTypeCreate.Size = new System.Drawing.Size(97, 30);
			this.radioButtonTypeCreate.TabIndex = 12;
			this.radioButtonTypeCreate.Text = "create";
			this.radioButtonTypeCreate.UseVisualStyleBackColor = true;
			this.radioButtonTypeCreate.CheckedChanged += new System.EventHandler(this.radioButtonTypeCreate_CheckedChanged);
			// 
			// radioButtonTypeHistory
			// 
			this.radioButtonTypeHistory.AutoSize = true;
			this.radioButtonTypeHistory.Location = new System.Drawing.Point(414, 25);
			this.radioButtonTypeHistory.Name = "radioButtonTypeHistory";
			this.radioButtonTypeHistory.Size = new System.Drawing.Size(101, 30);
			this.radioButtonTypeHistory.TabIndex = 11;
			this.radioButtonTypeHistory.Text = "history";
			this.radioButtonTypeHistory.UseVisualStyleBackColor = true;
			this.radioButtonTypeHistory.CheckedChanged += new System.EventHandler(this.radioButtonTypeHistory_CheckedChanged);
			// 
			// radioButtonTypeDelete
			// 
			this.radioButtonTypeDelete.AutoSize = true;
			this.radioButtonTypeDelete.Location = new System.Drawing.Point(312, 25);
			this.radioButtonTypeDelete.Name = "radioButtonTypeDelete";
			this.radioButtonTypeDelete.Size = new System.Drawing.Size(96, 30);
			this.radioButtonTypeDelete.TabIndex = 10;
			this.radioButtonTypeDelete.Text = "delete";
			this.radioButtonTypeDelete.UseVisualStyleBackColor = true;
			this.radioButtonTypeDelete.CheckedChanged += new System.EventHandler(this.radioButtonTypeDelete_CheckedChanged);
			// 
			// radioButtonTypeUpdate
			// 
			this.radioButtonTypeUpdate.AutoSize = true;
			this.radioButtonTypeUpdate.Location = new System.Drawing.Point(203, 25);
			this.radioButtonTypeUpdate.Name = "radioButtonTypeUpdate";
			this.radioButtonTypeUpdate.Size = new System.Drawing.Size(103, 30);
			this.radioButtonTypeUpdate.TabIndex = 9;
			this.radioButtonTypeUpdate.Text = "update";
			this.radioButtonTypeUpdate.UseVisualStyleBackColor = true;
			this.radioButtonTypeUpdate.CheckedChanged += new System.EventHandler(this.radioButtonTypeUpdate_CheckedChanged);
			// 
			// labelSecurity
			// 
			this.labelSecurity.AutoSize = true;
			this.labelSecurity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelSecurity.Location = new System.Drawing.Point(7, 176);
			this.labelSecurity.Name = "labelSecurity";
			this.labelSecurity.Size = new System.Drawing.Size(183, 26);
			this.labelSecurity.TabIndex = 10;
			this.labelSecurity.Text = "Security Option:";
			// 
			// groupBoxSecurityOption
			// 
			this.groupBoxSecurityOption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBoxSecurityOption.Controls.Add(this.radioButtonSecurityToken);
			this.groupBoxSecurityOption.Controls.Add(this.radioButtonSecurityUser);
			this.groupBoxSecurityOption.Controls.Add(this.textBoxToken);
			this.groupBoxSecurityOption.Controls.Add(this.labelUserName);
			this.groupBoxSecurityOption.Controls.Add(this.textBoxUserName);
			this.groupBoxSecurityOption.Controls.Add(this.labelPassword);
			this.groupBoxSecurityOption.Controls.Add(this.textBoxPassword);
			this.groupBoxSecurityOption.Controls.Add(this.labelToken);
			this.groupBoxSecurityOption.Location = new System.Drawing.Point(201, 153);
			this.groupBoxSecurityOption.Name = "groupBoxSecurityOption";
			this.groupBoxSecurityOption.Size = new System.Drawing.Size(1439, 126);
			this.groupBoxSecurityOption.TabIndex = 11;
			this.groupBoxSecurityOption.TabStop = false;
			// 
			// radioButtonSecurityToken
			// 
			this.radioButtonSecurityToken.AutoSize = true;
			this.radioButtonSecurityToken.Location = new System.Drawing.Point(267, 20);
			this.radioButtonSecurityToken.Name = "radioButtonSecurityToken";
			this.radioButtonSecurityToken.Size = new System.Drawing.Size(90, 30);
			this.radioButtonSecurityToken.TabIndex = 1;
			this.radioButtonSecurityToken.Text = "token";
			this.radioButtonSecurityToken.UseVisualStyleBackColor = true;
			this.radioButtonSecurityToken.CheckedChanged += new System.EventHandler(this.radioButtonSecurityToken_CheckedChanged);
			// 
			// radioButtonSecurityUser
			// 
			this.radioButtonSecurityUser.AutoSize = true;
			this.radioButtonSecurityUser.Checked = true;
			this.radioButtonSecurityUser.Location = new System.Drawing.Point(19, 20);
			this.radioButtonSecurityUser.Name = "radioButtonSecurityUser";
			this.radioButtonSecurityUser.Size = new System.Drawing.Size(233, 30);
			this.radioButtonSecurityUser.TabIndex = 0;
			this.radioButtonSecurityUser.TabStop = true;
			this.radioButtonSecurityUser.Text = "username/password";
			this.radioButtonSecurityUser.UseVisualStyleBackColor = true;
			this.radioButtonSecurityUser.CheckedChanged += new System.EventHandler(this.radioButtonSecurityUser_CheckedChanged);
			// 
			// textBoxToken
			// 
			this.textBoxToken.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxToken.Location = new System.Drawing.Point(875, 71);
			this.textBoxToken.Name = "textBoxToken";
			this.textBoxToken.ReadOnly = true;
			this.textBoxToken.Size = new System.Drawing.Size(539, 32);
			this.textBoxToken.TabIndex = 17;
			// 
			// labelUserName
			// 
			this.labelUserName.AutoSize = true;
			this.labelUserName.Location = new System.Drawing.Point(14, 74);
			this.labelUserName.Name = "labelUserName";
			this.labelUserName.Size = new System.Drawing.Size(129, 26);
			this.labelUserName.TabIndex = 12;
			this.labelUserName.Text = "User Name:";
			// 
			// textBoxUserName
			// 
			this.textBoxUserName.Location = new System.Drawing.Point(149, 71);
			this.textBoxUserName.Name = "textBoxUserName";
			this.textBoxUserName.Size = new System.Drawing.Size(207, 32);
			this.textBoxUserName.TabIndex = 13;
			// 
			// labelPassword
			// 
			this.labelPassword.AutoSize = true;
			this.labelPassword.Location = new System.Drawing.Point(372, 74);
			this.labelPassword.Name = "labelPassword";
			this.labelPassword.Size = new System.Drawing.Size(114, 26);
			this.labelPassword.TabIndex = 14;
			this.labelPassword.Text = "Password:";
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.Location = new System.Drawing.Point(492, 71);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.PasswordChar = '*';
			this.textBoxPassword.Size = new System.Drawing.Size(237, 32);
			this.textBoxPassword.TabIndex = 15;
			this.textBoxPassword.UseSystemPasswordChar = true;
			// 
			// labelToken
			// 
			this.labelToken.AutoSize = true;
			this.labelToken.Location = new System.Drawing.Point(792, 74);
			this.labelToken.Name = "labelToken";
			this.labelToken.Size = new System.Drawing.Size(77, 26);
			this.labelToken.TabIndex = 16;
			this.labelToken.Text = "Token:";
			// 
			// labelData
			// 
			this.labelData.AutoSize = true;
			this.labelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelData.Location = new System.Drawing.Point(9, 335);
			this.labelData.Name = "labelData";
			this.labelData.Size = new System.Drawing.Size(69, 26);
			this.labelData.TabIndex = 18;
			this.labelData.Text = "Data:";
			// 
			// textBoxData
			// 
			this.textBoxData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxData.Location = new System.Drawing.Point(12, 364);
			this.textBoxData.Multiline = true;
			this.textBoxData.Name = "textBoxData";
			this.textBoxData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxData.Size = new System.Drawing.Size(1518, 193);
			this.textBoxData.TabIndex = 19;
			// 
			// labelResponseFormat
			// 
			this.labelResponseFormat.AutoSize = true;
			this.labelResponseFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelResponseFormat.Location = new System.Drawing.Point(952, 294);
			this.labelResponseFormat.Name = "labelResponseFormat";
			this.labelResponseFormat.Size = new System.Drawing.Size(207, 26);
			this.labelResponseFormat.TabIndex = 20;
			this.labelResponseFormat.Text = "Response Format:";
			// 
			// comboBoxResponseFormat
			// 
			this.comboBoxResponseFormat.FormattingEnabled = true;
			this.comboBoxResponseFormat.Items.AddRange(new object[] {
            "JSON",
            "XML",
            "RDF"});
			this.comboBoxResponseFormat.Location = new System.Drawing.Point(1165, 291);
			this.comboBoxResponseFormat.Name = "comboBoxResponseFormat";
			this.comboBoxResponseFormat.Size = new System.Drawing.Size(192, 33);
			this.comboBoxResponseFormat.TabIndex = 21;
			this.comboBoxResponseFormat.Text = "JSON";
			// 
			// labelRequestVerb
			// 
			this.labelRequestVerb.AutoSize = true;
			this.labelRequestVerb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelRequestVerb.Location = new System.Drawing.Point(12, 294);
			this.labelRequestVerb.Name = "labelRequestVerb";
			this.labelRequestVerb.Size = new System.Drawing.Size(164, 26);
			this.labelRequestVerb.TabIndex = 22;
			this.labelRequestVerb.Text = "Request Verb:";
			// 
			// comboBoxRequestVerb
			// 
			this.comboBoxRequestVerb.FormattingEnabled = true;
			this.comboBoxRequestVerb.Items.AddRange(new object[] {
            "GET",
            "POST",
            "PUT",
            "DELETE"});
			this.comboBoxRequestVerb.Location = new System.Drawing.Point(182, 291);
			this.comboBoxRequestVerb.Name = "comboBoxRequestVerb";
			this.comboBoxRequestVerb.Size = new System.Drawing.Size(149, 33);
			this.comboBoxRequestVerb.TabIndex = 23;
			this.comboBoxRequestVerb.Text = "POST";
			this.comboBoxRequestVerb.TextChanged += new System.EventHandler(this.comboBoxRequestVerb_TextChanged);
			// 
			// labelContentType
			// 
			this.labelContentType.AutoSize = true;
			this.labelContentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelContentType.Location = new System.Drawing.Point(345, 294);
			this.labelContentType.Name = "labelContentType";
			this.labelContentType.Size = new System.Drawing.Size(160, 26);
			this.labelContentType.TabIndex = 24;
			this.labelContentType.Text = "Content Type:";
			// 
			// comboBoxContentType
			// 
			this.comboBoxContentType.FormattingEnabled = true;
			this.comboBoxContentType.Items.AddRange(new object[] {
            "application/x-www-form-urlencoded",
            "application/json+fhir",
            "application/xml+fhir",
            "text/plain"});
			this.comboBoxContentType.Location = new System.Drawing.Point(511, 291);
			this.comboBoxContentType.Name = "comboBoxContentType";
			this.comboBoxContentType.Size = new System.Drawing.Size(419, 33);
			this.comboBoxContentType.TabIndex = 25;
			// 
			// buttonValueSet
			// 
			this.buttonValueSet.Location = new System.Drawing.Point(1540, 364);
			this.buttonValueSet.Name = "buttonValueSet";
			this.buttonValueSet.Size = new System.Drawing.Size(181, 47);
			this.buttonValueSet.TabIndex = 26;
			this.buttonValueSet.Text = "ValueSet Gen";
			this.buttonValueSet.UseVisualStyleBackColor = true;
			this.buttonValueSet.Click += new System.EventHandler(this.buttonValueSet_Click);
			// 
			// comboBoxValueSet
			// 
			this.comboBoxValueSet.FormattingEnabled = true;
			this.comboBoxValueSet.Location = new System.Drawing.Point(578, 1136);
			this.comboBoxValueSet.Name = "comboBoxValueSet";
			this.comboBoxValueSet.Size = new System.Drawing.Size(806, 33);
			this.comboBoxValueSet.TabIndex = 27;
			// 
			// labelValueSet
			// 
			this.labelValueSet.AutoSize = true;
			this.labelValueSet.Location = new System.Drawing.Point(337, 1136);
			this.labelValueSet.Name = "labelValueSet";
			this.labelValueSet.Size = new System.Drawing.Size(222, 26);
			this.labelValueSet.TabIndex = 28;
			this.labelValueSet.Text = "ValueSet Test Result:";
			// 
			// buttonTest
			// 
			this.buttonTest.Location = new System.Drawing.Point(1455, 1125);
			this.buttonTest.Name = "buttonTest";
			this.buttonTest.Size = new System.Drawing.Size(75, 53);
			this.buttonTest.TabIndex = 29;
			this.buttonTest.Text = "Test";
			this.buttonTest.UseVisualStyleBackColor = true;
			this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
			// 
			// labelResource
			// 
			this.labelResource.AutoSize = true;
			this.labelResource.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelResource.Location = new System.Drawing.Point(846, 46);
			this.labelResource.Name = "labelResource";
			this.labelResource.Size = new System.Drawing.Size(120, 26);
			this.labelResource.TabIndex = 30;
			this.labelResource.Text = "Resource:";
			// 
			// textBoxResource
			// 
			this.textBoxResource.Location = new System.Drawing.Point(972, 46);
			this.textBoxResource.Name = "textBoxResource";
			this.textBoxResource.Size = new System.Drawing.Size(643, 32);
			this.textBoxResource.TabIndex = 31;
			// 
			// buttonPushData
			// 
			this.buttonPushData.Location = new System.Drawing.Point(1540, 511);
			this.buttonPushData.Name = "buttonPushData";
			this.buttonPushData.Size = new System.Drawing.Size(181, 46);
			this.buttonPushData.TabIndex = 32;
			this.buttonPushData.Text = "Push Data";
			this.buttonPushData.UseVisualStyleBackColor = true;
			this.buttonPushData.Click += new System.EventHandler(this.buttonPushData_Click);
			// 
			// buttonGetData
			// 
			this.buttonGetData.Location = new System.Drawing.Point(1540, 457);
			this.buttonGetData.Name = "buttonGetData";
			this.buttonGetData.Size = new System.Drawing.Size(181, 48);
			this.buttonGetData.TabIndex = 33;
			this.buttonGetData.Text = "Get Data";
			this.buttonGetData.UseVisualStyleBackColor = true;
			this.buttonGetData.Click += new System.EventHandler(this.buttonGetData_Click);
			// 
			// comboBoxServer
			// 
			this.comboBoxServer.FormattingEnabled = true;
			this.comboBoxServer.Items.AddRange(new object[] {
            "https://mrd2.melanoma.org.au/fhir",
            "",
            "http://fhir2.healthintersections.com.au/open",
            "http://52.62.87.143:8080/fhir",
            "http://terminology.hl7.org.au/open",
            "http://sqlonfhir-dstu2.azurewebsites.net/fhir",
            "http://fhir.ext.apelon.com:8081/DtsOnFhirDemo/logon/ForwardToLogon.action",
            "http://192.168.55.91:81/Blaze/fhirapi"});
			this.comboBoxServer.Location = new System.Drawing.Point(84, 39);
			this.comboBoxServer.Name = "comboBoxServer";
			this.comboBoxServer.Size = new System.Drawing.Size(734, 33);
			this.comboBoxServer.TabIndex = 34;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(191F, 191F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(1733, 1219);
			this.Controls.Add(this.comboBoxServer);
			this.Controls.Add(this.buttonGetData);
			this.Controls.Add(this.buttonPushData);
			this.Controls.Add(this.textBoxResource);
			this.Controls.Add(this.labelResource);
			this.Controls.Add(this.buttonTest);
			this.Controls.Add(this.labelValueSet);
			this.Controls.Add(this.comboBoxValueSet);
			this.Controls.Add(this.buttonValueSet);
			this.Controls.Add(this.comboBoxContentType);
			this.Controls.Add(this.labelContentType);
			this.Controls.Add(this.comboBoxRequestVerb);
			this.Controls.Add(this.labelRequestVerb);
			this.Controls.Add(this.comboBoxResponseFormat);
			this.Controls.Add(this.labelResponseFormat);
			this.Controls.Add(this.textBoxData);
			this.Controls.Add(this.labelData);
			this.Controls.Add(this.groupBoxSecurityOption);
			this.Controls.Add(this.labelSecurity);
			this.Controls.Add(this.groupBoxAPIType);
			this.Controls.Add(this.labelType);
			this.Controls.Add(this.labelResponse);
			this.Controls.Add(this.textBoxResponse);
			this.Controls.Add(this.buttonGo);
			this.Controls.Add(this.labelURL);
			this.Controls.Add(this.mainMenu);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.mainMenu;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FHIR Tester";
			this.mainMenu.ResumeLayout(false);
			this.mainMenu.PerformLayout();
			this.groupBoxAPIType.ResumeLayout(false);
			this.groupBoxAPIType.PerformLayout();
			this.groupBoxSecurityOption.ResumeLayout(false);
			this.groupBoxSecurityOption.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip mainMenu;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem uRLToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.Label labelURL;
		private System.Windows.Forms.Button buttonGo;
		private System.Windows.Forms.TextBox textBoxResponse;
		private System.Windows.Forms.Label labelResponse;
		private System.Windows.Forms.Label labelType;
		private System.Windows.Forms.RadioButton radioButtonTypeRead;
		private System.Windows.Forms.RadioButton radioButtonTypeVRead;
		private System.Windows.Forms.GroupBox groupBoxAPIType;
		private System.Windows.Forms.RadioButton radioButtonTypeHistory;
		private System.Windows.Forms.RadioButton radioButtonTypeDelete;
		private System.Windows.Forms.RadioButton radioButtonTypeUpdate;
		private System.Windows.Forms.RadioButton radioButtonTypeBatch;
		private System.Windows.Forms.RadioButton radioButtonTypeConformance;
		private System.Windows.Forms.RadioButton radioButtonTypeSearch;
		private System.Windows.Forms.RadioButton radioButtonTypeCreate;
		private System.Windows.Forms.Label labelSecurity;
		private System.Windows.Forms.GroupBox groupBoxSecurityOption;
		private System.Windows.Forms.RadioButton radioButtonSecurityToken;
		private System.Windows.Forms.RadioButton radioButtonSecurityUser;
		private System.Windows.Forms.Label labelUserName;
		private System.Windows.Forms.TextBox textBoxUserName;
		private System.Windows.Forms.Label labelPassword;
		private System.Windows.Forms.TextBox textBoxPassword;
		private System.Windows.Forms.Label labelToken;
		private System.Windows.Forms.TextBox textBoxToken;
		private System.Windows.Forms.Label labelData;
		private System.Windows.Forms.TextBox textBoxData;
		private System.Windows.Forms.Label labelResponseFormat;
		private System.Windows.Forms.ComboBox comboBoxResponseFormat;
		private System.Windows.Forms.RadioButton radioButtonTypeCustom;
		private System.Windows.Forms.Label labelRequestVerb;
		private System.Windows.Forms.ComboBox comboBoxRequestVerb;
		private System.Windows.Forms.Label labelContentType;
		private System.Windows.Forms.ComboBox comboBoxContentType;
		private System.Windows.Forms.Button buttonValueSet;
		private System.Windows.Forms.ComboBox comboBoxValueSet;
		private System.Windows.Forms.Label labelValueSet;
		private System.Windows.Forms.Button buttonTest;
		private System.Windows.Forms.Label labelResource;
		private System.Windows.Forms.TextBox textBoxResource;
		private System.Windows.Forms.Button buttonPushData;
		private System.Windows.Forms.Button buttonGetData;
		private System.Windows.Forms.ComboBox comboBoxServer;
	}
}

