namespace FHIRTester {
	partial class ValueSet {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ValueSet));
			this.labelURI = new System.Windows.Forms.Label();
			this.textBoxURI = new System.Windows.Forms.TextBox();
			this.labelIdentifier = new System.Windows.Forms.Label();
			this.labelVersion = new System.Windows.Forms.Label();
			this.textBoxVersion = new System.Windows.Forms.TextBox();
			this.labelName = new System.Windows.Forms.Label();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.labelStatus = new System.Windows.Forms.Label();
			this.comboBoxStatus = new System.Windows.Forms.ComboBox();
			this.checkBoxExperimental = new System.Windows.Forms.CheckBox();
			this.labelPublisher = new System.Windows.Forms.Label();
			this.textBoxPulisher = new System.Windows.Forms.TextBox();
			this.labelDescription = new System.Windows.Forms.Label();
			this.textBoxDescription = new System.Windows.Forms.TextBox();
			this.labelDate = new System.Windows.Forms.Label();
			this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
			this.labelLockedDate = new System.Windows.Forms.Label();
			this.dateTimePickerLockedDate = new System.Windows.Forms.DateTimePicker();
			this.dateTimePickerTime = new System.Windows.Forms.DateTimePicker();
			this.checkBoxImmutable = new System.Windows.Forms.CheckBox();
			this.checkBoxExtensible = new System.Windows.Forms.CheckBox();
			this.groupBoxCodeSystem = new System.Windows.Forms.GroupBox();
			this.checkBoxCSSensitive = new System.Windows.Forms.CheckBox();
			this.textBoxCSVersion = new System.Windows.Forms.TextBox();
			this.labelCSVersion = new System.Windows.Forms.Label();
			this.comboBoxCSURI = new System.Windows.Forms.ComboBox();
			this.labelCSURI = new System.Windows.Forms.Label();
			this.groupBoxCodeSystem.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelURI
			// 
			this.labelURI.AutoSize = true;
			this.labelURI.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.916231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelURI.Location = new System.Drawing.Point(12, 9);
			this.labelURI.Name = "labelURI";
			this.labelURI.Size = new System.Drawing.Size(60, 26);
			this.labelURI.TabIndex = 0;
			this.labelURI.Text = "URI:";
			// 
			// textBoxURI
			// 
			this.textBoxURI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxURI.Location = new System.Drawing.Point(78, 4);
			this.textBoxURI.Name = "textBoxURI";
			this.textBoxURI.Size = new System.Drawing.Size(1938, 31);
			this.textBoxURI.TabIndex = 1;
			// 
			// labelIdentifier
			// 
			this.labelIdentifier.AutoSize = true;
			this.labelIdentifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.916231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelIdentifier.Location = new System.Drawing.Point(12, 47);
			this.labelIdentifier.Name = "labelIdentifier";
			this.labelIdentifier.Size = new System.Drawing.Size(112, 26);
			this.labelIdentifier.TabIndex = 2;
			this.labelIdentifier.Text = "Identifier:";
			// 
			// labelVersion
			// 
			this.labelVersion.AutoSize = true;
			this.labelVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.916231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelVersion.Location = new System.Drawing.Point(12, 89);
			this.labelVersion.Name = "labelVersion";
			this.labelVersion.Size = new System.Drawing.Size(100, 26);
			this.labelVersion.TabIndex = 3;
			this.labelVersion.Text = "Version:";
			// 
			// textBoxVersion
			// 
			this.textBoxVersion.Location = new System.Drawing.Point(118, 86);
			this.textBoxVersion.Name = "textBoxVersion";
			this.textBoxVersion.Size = new System.Drawing.Size(294, 31);
			this.textBoxVersion.TabIndex = 4;
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.916231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelName.Location = new System.Drawing.Point(12, 136);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(82, 26);
			this.labelName.TabIndex = 5;
			this.labelName.Text = "Name:";
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(118, 133);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(676, 31);
			this.textBoxName.TabIndex = 6;
			// 
			// labelStatus
			// 
			this.labelStatus.AutoSize = true;
			this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.916231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelStatus.Location = new System.Drawing.Point(502, 89);
			this.labelStatus.Name = "labelStatus";
			this.labelStatus.Size = new System.Drawing.Size(87, 26);
			this.labelStatus.TabIndex = 7;
			this.labelStatus.Text = "Status:";
			// 
			// comboBoxStatus
			// 
			this.comboBoxStatus.FormattingEnabled = true;
			this.comboBoxStatus.Items.AddRange(new object[] {
            "draft",
            "active",
            "retired"});
			this.comboBoxStatus.Location = new System.Drawing.Point(595, 86);
			this.comboBoxStatus.Name = "comboBoxStatus";
			this.comboBoxStatus.Size = new System.Drawing.Size(199, 33);
			this.comboBoxStatus.TabIndex = 8;
			this.comboBoxStatus.Text = "draft";
			// 
			// checkBoxExperimental
			// 
			this.checkBoxExperimental.AutoSize = true;
			this.checkBoxExperimental.Location = new System.Drawing.Point(847, 87);
			this.checkBoxExperimental.Name = "checkBoxExperimental";
			this.checkBoxExperimental.Size = new System.Drawing.Size(163, 30);
			this.checkBoxExperimental.TabIndex = 9;
			this.checkBoxExperimental.Text = "experimental";
			this.checkBoxExperimental.UseVisualStyleBackColor = true;
			// 
			// labelPublisher
			// 
			this.labelPublisher.AutoSize = true;
			this.labelPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.916231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPublisher.Location = new System.Drawing.Point(1356, 89);
			this.labelPublisher.Name = "labelPublisher";
			this.labelPublisher.Size = new System.Drawing.Size(119, 26);
			this.labelPublisher.TabIndex = 10;
			this.labelPublisher.Text = "Publisher:";
			// 
			// textBoxPulisher
			// 
			this.textBoxPulisher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxPulisher.Location = new System.Drawing.Point(1481, 86);
			this.textBoxPulisher.Name = "textBoxPulisher";
			this.textBoxPulisher.Size = new System.Drawing.Size(535, 31);
			this.textBoxPulisher.TabIndex = 11;
			this.textBoxPulisher.Text = "Melanoma Institute Australia";
			// 
			// labelDescription
			// 
			this.labelDescription.AutoSize = true;
			this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.916231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelDescription.Location = new System.Drawing.Point(12, 189);
			this.labelDescription.Name = "labelDescription";
			this.labelDescription.Size = new System.Drawing.Size(139, 26);
			this.labelDescription.TabIndex = 12;
			this.labelDescription.Text = "Description:";
			// 
			// textBoxDescription
			// 
			this.textBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxDescription.Location = new System.Drawing.Point(157, 186);
			this.textBoxDescription.Name = "textBoxDescription";
			this.textBoxDescription.Size = new System.Drawing.Size(1859, 31);
			this.textBoxDescription.TabIndex = 13;
			// 
			// labelDate
			// 
			this.labelDate.AutoSize = true;
			this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.916231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelDate.Location = new System.Drawing.Point(1055, 136);
			this.labelDate.Name = "labelDate";
			this.labelDate.Size = new System.Drawing.Size(69, 26);
			this.labelDate.TabIndex = 14;
			this.labelDate.Text = "Date:";
			// 
			// dateTimePickerDate
			// 
			this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerDate.Location = new System.Drawing.Point(1153, 133);
			this.dateTimePickerDate.Name = "dateTimePickerDate";
			this.dateTimePickerDate.Size = new System.Drawing.Size(200, 31);
			this.dateTimePickerDate.TabIndex = 15;
			// 
			// labelLockedDate
			// 
			this.labelLockedDate.AutoSize = true;
			this.labelLockedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.916231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelLockedDate.Location = new System.Drawing.Point(1635, 136);
			this.labelLockedDate.Name = "labelLockedDate";
			this.labelLockedDate.Size = new System.Drawing.Size(152, 26);
			this.labelLockedDate.TabIndex = 16;
			this.labelLockedDate.Text = "Locked Date:";
			// 
			// dateTimePickerLockedDate
			// 
			this.dateTimePickerLockedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerLockedDate.Location = new System.Drawing.Point(1816, 133);
			this.dateTimePickerLockedDate.Name = "dateTimePickerLockedDate";
			this.dateTimePickerLockedDate.Size = new System.Drawing.Size(200, 31);
			this.dateTimePickerLockedDate.TabIndex = 17;
			// 
			// dateTimePickerTime
			// 
			this.dateTimePickerTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dateTimePickerTime.Location = new System.Drawing.Point(1375, 133);
			this.dateTimePickerTime.Name = "dateTimePickerTime";
			this.dateTimePickerTime.ShowUpDown = true;
			this.dateTimePickerTime.Size = new System.Drawing.Size(179, 31);
			this.dateTimePickerTime.TabIndex = 18;
			// 
			// checkBoxImmutable
			// 
			this.checkBoxImmutable.AutoSize = true;
			this.checkBoxImmutable.Location = new System.Drawing.Point(1030, 87);
			this.checkBoxImmutable.Name = "checkBoxImmutable";
			this.checkBoxImmutable.Size = new System.Drawing.Size(140, 30);
			this.checkBoxImmutable.TabIndex = 19;
			this.checkBoxImmutable.Text = "immutable";
			this.checkBoxImmutable.UseVisualStyleBackColor = true;
			// 
			// checkBoxExtensible
			// 
			this.checkBoxExtensible.AutoSize = true;
			this.checkBoxExtensible.Location = new System.Drawing.Point(1185, 86);
			this.checkBoxExtensible.Name = "checkBoxExtensible";
			this.checkBoxExtensible.Size = new System.Drawing.Size(136, 30);
			this.checkBoxExtensible.TabIndex = 20;
			this.checkBoxExtensible.Text = "extensible";
			this.checkBoxExtensible.UseVisualStyleBackColor = true;
			// 
			// groupBoxCodeSystem
			// 
			this.groupBoxCodeSystem.Controls.Add(this.checkBoxCSSensitive);
			this.groupBoxCodeSystem.Controls.Add(this.textBoxCSVersion);
			this.groupBoxCodeSystem.Controls.Add(this.labelCSVersion);
			this.groupBoxCodeSystem.Controls.Add(this.comboBoxCSURI);
			this.groupBoxCodeSystem.Controls.Add(this.labelCSURI);
			this.groupBoxCodeSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.916231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBoxCodeSystem.Location = new System.Drawing.Point(12, 234);
			this.groupBoxCodeSystem.Name = "groupBoxCodeSystem";
			this.groupBoxCodeSystem.Size = new System.Drawing.Size(2004, 235);
			this.groupBoxCodeSystem.TabIndex = 21;
			this.groupBoxCodeSystem.TabStop = false;
			this.groupBoxCodeSystem.Text = "Code System:";
			// 
			// checkBoxCSSensitive
			// 
			this.checkBoxCSSensitive.AutoSize = true;
			this.checkBoxCSSensitive.Location = new System.Drawing.Point(654, 39);
			this.checkBoxCSSensitive.Name = "checkBoxCSSensitive";
			this.checkBoxCSSensitive.Size = new System.Drawing.Size(198, 30);
			this.checkBoxCSSensitive.TabIndex = 24;
			this.checkBoxCSSensitive.Text = "Case Sensitive";
			this.checkBoxCSSensitive.UseVisualStyleBackColor = true;
			// 
			// textBoxCSVersion
			// 
			this.textBoxCSVersion.Location = new System.Drawing.Point(463, 38);
			this.textBoxCSVersion.Name = "textBoxCSVersion";
			this.textBoxCSVersion.Size = new System.Drawing.Size(170, 31);
			this.textBoxCSVersion.TabIndex = 22;
			// 
			// labelCSVersion
			// 
			this.labelCSVersion.AutoSize = true;
			this.labelCSVersion.Location = new System.Drawing.Point(357, 36);
			this.labelCSVersion.Name = "labelCSVersion";
			this.labelCSVersion.Size = new System.Drawing.Size(100, 26);
			this.labelCSVersion.TabIndex = 23;
			this.labelCSVersion.Text = "Version:";
			// 
			// comboBoxCSURI
			// 
			this.comboBoxCSURI.FormattingEnabled = true;
			this.comboBoxCSURI.Location = new System.Drawing.Point(72, 36);
			this.comboBoxCSURI.Name = "comboBoxCSURI";
			this.comboBoxCSURI.Size = new System.Drawing.Size(263, 33);
			this.comboBoxCSURI.TabIndex = 22;
			// 
			// labelCSURI
			// 
			this.labelCSURI.AutoSize = true;
			this.labelCSURI.Location = new System.Drawing.Point(6, 39);
			this.labelCSURI.Name = "labelCSURI";
			this.labelCSURI.Size = new System.Drawing.Size(60, 26);
			this.labelCSURI.TabIndex = 0;
			this.labelCSURI.Text = "URI:";
			// 
			// ValueSet
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(191F, 191F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(2028, 1091);
			this.Controls.Add(this.groupBoxCodeSystem);
			this.Controls.Add(this.checkBoxExtensible);
			this.Controls.Add(this.checkBoxImmutable);
			this.Controls.Add(this.dateTimePickerTime);
			this.Controls.Add(this.dateTimePickerLockedDate);
			this.Controls.Add(this.labelLockedDate);
			this.Controls.Add(this.dateTimePickerDate);
			this.Controls.Add(this.labelDate);
			this.Controls.Add(this.textBoxDescription);
			this.Controls.Add(this.labelDescription);
			this.Controls.Add(this.textBoxPulisher);
			this.Controls.Add(this.labelPublisher);
			this.Controls.Add(this.checkBoxExperimental);
			this.Controls.Add(this.comboBoxStatus);
			this.Controls.Add(this.labelStatus);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.labelName);
			this.Controls.Add(this.textBoxVersion);
			this.Controls.Add(this.labelVersion);
			this.Controls.Add(this.labelIdentifier);
			this.Controls.Add(this.textBoxURI);
			this.Controls.Add(this.labelURI);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ValueSet";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ValueSet Editor";
			this.groupBoxCodeSystem.ResumeLayout(false);
			this.groupBoxCodeSystem.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelURI;
		private System.Windows.Forms.TextBox textBoxURI;
		private System.Windows.Forms.Label labelIdentifier;
		private System.Windows.Forms.Label labelVersion;
		private System.Windows.Forms.TextBox textBoxVersion;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.Label labelStatus;
		private System.Windows.Forms.ComboBox comboBoxStatus;
		private System.Windows.Forms.CheckBox checkBoxExperimental;
		private System.Windows.Forms.Label labelPublisher;
		private System.Windows.Forms.TextBox textBoxPulisher;
		private System.Windows.Forms.Label labelDescription;
		private System.Windows.Forms.TextBox textBoxDescription;
		private System.Windows.Forms.Label labelDate;
		private System.Windows.Forms.DateTimePicker dateTimePickerDate;
		private System.Windows.Forms.Label labelLockedDate;
		private System.Windows.Forms.DateTimePicker dateTimePickerLockedDate;
		private System.Windows.Forms.DateTimePicker dateTimePickerTime;
		private System.Windows.Forms.CheckBox checkBoxImmutable;
		private System.Windows.Forms.CheckBox checkBoxExtensible;
		private System.Windows.Forms.GroupBox groupBoxCodeSystem;
		private System.Windows.Forms.CheckBox checkBoxCSSensitive;
		private System.Windows.Forms.TextBox textBoxCSVersion;
		private System.Windows.Forms.Label labelCSVersion;
		private System.Windows.Forms.ComboBox comboBoxCSURI;
		private System.Windows.Forms.Label labelCSURI;
	}
}