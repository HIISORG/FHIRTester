using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FHIRTester {
	public partial class MainForm : Form {
		public MainForm() {
			InitializeComponent();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
			this.Dispose();
			Application.Exit();
		}

		private void radioButtonSecurityUser_CheckedChanged(object sender, EventArgs e) {
			textBoxUserName.ReadOnly = false;
			textBoxPassword.ReadOnly = false;
			textBoxToken.ReadOnly = true;
			textBoxToken.Text = string.Empty;
			textBoxUserName.Focus();
		}

		private void radioButtonSecurityToken_CheckedChanged(object sender, EventArgs e) {
			textBoxUserName.ReadOnly = true;
			textBoxUserName.Text = string.Empty;
			textBoxPassword.ReadOnly = true;
			textBoxPassword.Text = string.Empty;
			textBoxToken.ReadOnly = false;
			textBoxToken.Focus();
		}

		private void buttonGo_Click(object sender, EventArgs e) {
			if (string.IsNullOrWhiteSpace(textBoxURL.Text)) {
				MessageBox.Show("Server URL cannot be empty.", "Server URL");
				textBoxURL.Focus();
			} else {

			}
		}
	}
}
