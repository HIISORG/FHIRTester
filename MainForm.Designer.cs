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
			this.textBoxURL = new System.Windows.Forms.TextBox();
			this.buttonGo = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.labelResponse = new System.Windows.Forms.Label();
			this.labelType = new System.Windows.Forms.Label();
			this.radioButtonTypeRead = new System.Windows.Forms.RadioButton();
			this.radioButtonTypeVRead = new System.Windows.Forms.RadioButton();
			this.groupBoxAPIType = new System.Windows.Forms.GroupBox();
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
			this.labelURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.916231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelURL.Location = new System.Drawing.Point(12, 43);
			this.labelURL.Name = "labelURL";
			this.labelURL.Size = new System.Drawing.Size(66, 26);
			this.labelURL.TabIndex = 1;
			this.labelURL.Text = "URL:";
			// 
			// textBoxURL
			// 
			this.textBoxURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.916231F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxURL.Location = new System.Drawing.Point(84, 43);
			this.textBoxURL.Name = "textBoxURL";
			this.textBoxURL.Size = new System.Drawing.Size(1556, 31);
			this.textBoxURL.TabIndex = 2;
			// 
			// buttonGo
			// 
			this.buttonGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.916231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonGo.Location = new System.Drawing.Point(1646, 43);
			this.buttonGo.Name = "buttonGo";
			this.buttonGo.Size = new System.Drawing.Size(75, 71);
			this.buttonGo.TabIndex = 3;
			this.buttonGo.Text = "GO";
			this.buttonGo.UseVisualStyleBackColor = true;
			this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
			// 
			// textBox1
			// 
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Location = new System.Drawing.Point(12, 589);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(1709, 618);
			this.textBox1.TabIndex = 4;
			// 
			// labelResponse
			// 
			this.labelResponse.AutoSize = true;
			this.labelResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.916231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelResponse.Location = new System.Drawing.Point(12, 560);
			this.labelResponse.Name = "labelResponse";
			this.labelResponse.Size = new System.Drawing.Size(202, 26);
			this.labelResponse.TabIndex = 5;
			this.labelResponse.Text = "Server Response:";
			// 
			// labelType
			// 
			this.labelType.AutoSize = true;
			this.labelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.916231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelType.Location = new System.Drawing.Point(12, 108);
			this.labelType.Name = "labelType";
			this.labelType.Size = new System.Drawing.Size(116, 26);
			this.labelType.TabIndex = 6;
			this.labelType.Text = "API Type:";
			// 
			// radioButtonTypeRead
			// 
			this.radioButtonTypeRead.AutoSize = true;
			this.radioButtonTypeRead.Checked = true;
			this.radioButtonTypeRead.Location = new System.Drawing.Point(20, 25);
			this.radioButtonTypeRead.Name = "radioButtonTypeRead";
			this.radioButtonTypeRead.Size = new System.Drawing.Size(80, 30);
			this.radioButtonTypeRead.TabIndex = 7;
			this.radioButtonTypeRead.TabStop = true;
			this.radioButtonTypeRead.Text = "read";
			this.radioButtonTypeRead.UseVisualStyleBackColor = true;
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
			// 
			// groupBoxAPIType
			// 
			this.groupBoxAPIType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
			// radioButtonTypeBatch
			// 
			this.radioButtonTypeBatch.AutoSize = true;
			this.radioButtonTypeBatch.Location = new System.Drawing.Point(967, 25);
			this.radioButtonTypeBatch.Name = "radioButtonTypeBatch";
			this.radioButtonTypeBatch.Size = new System.Drawing.Size(202, 30);
			this.radioButtonTypeBatch.TabIndex = 15;
			this.radioButtonTypeBatch.Text = "batch/transaction";
			this.radioButtonTypeBatch.UseVisualStyleBackColor = true;
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
			// 
			// labelSecurity
			// 
			this.labelSecurity.AutoSize = true;
			this.labelSecurity.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.916231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
			this.textBoxToken.Size = new System.Drawing.Size(539, 31);
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
			this.textBoxUserName.Size = new System.Drawing.Size(207, 31);
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
			this.textBoxPassword.Size = new System.Drawing.Size(237, 31);
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
			this.labelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.916231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelData.Location = new System.Drawing.Point(7, 273);
			this.labelData.Name = "labelData";
			this.labelData.Size = new System.Drawing.Size(69, 26);
			this.labelData.TabIndex = 18;
			this.labelData.Text = "Data:";
			// 
			// textBoxData
			// 
			this.textBoxData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxData.Location = new System.Drawing.Point(12, 302);
			this.textBoxData.Multiline = true;
			this.textBoxData.Name = "textBoxData";
			this.textBoxData.Size = new System.Drawing.Size(1709, 255);
			this.textBoxData.TabIndex = 19;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(191F, 191F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(1733, 1219);
			this.Controls.Add(this.textBoxURL);
			this.Controls.Add(this.textBoxData);
			this.Controls.Add(this.labelData);
			this.Controls.Add(this.groupBoxSecurityOption);
			this.Controls.Add(this.labelSecurity);
			this.Controls.Add(this.groupBoxAPIType);
			this.Controls.Add(this.labelType);
			this.Controls.Add(this.labelResponse);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.buttonGo);
			this.Controls.Add(this.labelURL);
			this.Controls.Add(this.mainMenu);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.916231F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
		private System.Windows.Forms.TextBox textBoxURL;
		private System.Windows.Forms.Button buttonGo;
		private System.Windows.Forms.TextBox textBox1;
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
	}
}

