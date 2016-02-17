using System;
using System.Net;
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
		private Interaction interaction;
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
			textBoxToken.Text = "6e6f606e-b6b4-465d-8bbd-545718719198";
			comboBoxServer.Text = "http://smudev01.smu.org.net/fhir/Query/3456";
			textBoxToken.Focus();
		}

		private void buttonGo_Click(object sender, EventArgs e) {
			if (string.IsNullOrWhiteSpace(comboBoxServer.Text)) {
				MessageBox.Show("Server URL cannot be empty.", "Server URL");
				comboBoxServer.Focus();
			} else {
				#region Construct URL
				string url = string.Empty;
				switch (interaction) {
					case Interaction.read:
						url = comboBoxServer.Text + "/read/" + textBoxData.Text;
						break;
					case Interaction.vread:
						/// TODO: Add history version id
						url = comboBoxServer.Text + "/vread/" + textBoxData.Text + "/_history/";
						break;
					case Interaction.update:
						url = comboBoxServer.Text + "/update/" + textBoxData.Text;
						break;
					case Interaction.delete:
						url = comboBoxServer.Text + "/delete/" + textBoxData.Text;
						break;
					case Interaction.create:
						url = comboBoxServer.Text + "/create";
						break;
					case Interaction.search:
						if (comboBoxRequestVerb.Text == "GET") {
							url = comboBoxServer.Text + "/search?" + textBoxData.Text;
						} else {
							url = comboBoxServer.Text + "/search/_search?" + textBoxData.Text;
						}
						break;
					case Interaction.searchAll:
						if (comboBoxRequestVerb.Text == "GET") {
							url = comboBoxServer.Text + "/_search?" + textBoxData.Text;
						} else {
							/// TODO: Add conformance type
						}
						break;
					case Interaction.transaction:
						url = comboBoxServer.Text;
						break;
					case Interaction.history:
						url = comboBoxServer.Text + "/history/" + textBoxData.Text + "/_history";
						break;
					case Interaction.historyType:
						url = comboBoxServer.Text + "/history-type/_history";
						break;
					case Interaction.historyAll:
						url = comboBoxServer.Text + "/_history";
						break;
					default:
						MessageBox.Show("Incorrect request type.", "Request Type");
						return;
				}
				#endregion

				using (System.Net.WebClient w = new System.Net.WebClient()) {
					Cursor = Cursors.WaitCursor;
					if (radioButtonSecurityToken.Checked) {
						w.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
						textBoxResponse.Text = w.UploadString(comboBoxServer.Text, "POST", textBoxToken.Text);
					} else {
						switch (comboBoxRequestVerb.Text) {
							case "DELETE":
								break;
							case "POST":
								textBoxResponse.Text = w.UploadString(comboBoxServer.Text, "POST", "");
								break;
							case "PUT":
								break;
							default: // GET request
								textBoxResponse.Text = w.DownloadString(comboBoxServer.Text);
								break;
						}
						textBoxResponse.Text = w.DownloadString(comboBoxServer.Text);
					}
					Cursor = Cursors.Default;
				}
			}
		}

		private void textBoxResponse_DoubleClick(object sender, EventArgs e) {
			if (!string.IsNullOrWhiteSpace(textBoxResponse.Text)) {
				Clipboard.SetText(textBoxResponse.Text);

				ToolTip tt = new ToolTip();
				IWin32Window win = this;
				tt.Show("Server response has been copied to clipboard.", win, Cursor.Position, 1000);
			}
		}

		private void radioButtonTypeRead_CheckedChanged(object sender, EventArgs e) {
			comboBoxRequestVerb.Items.Clear();
			comboBoxRequestVerb.Items.AddRange(new object[] {
				"GET"
			});
			comboBoxRequestVerb.Text = "GET";
			comboBoxContentType.Text = "";
			comboBoxContentType.Enabled = false;
			interaction = Interaction.read;
		}

		private void radioButtonTypeVRead_CheckedChanged(object sender, EventArgs e) {
			interaction = Interaction.vread;
			comboBoxRequestVerb.Items.Clear();
			comboBoxRequestVerb.Items.AddRange(new object[] {
				"GET"
			});
			comboBoxRequestVerb.Text = "GET";
			comboBoxContentType.Text = "";
			comboBoxContentType.Enabled = false;
		}

		private void radioButtonTypeUpdate_CheckedChanged(object sender, EventArgs e) {
			interaction = Interaction.update;
			comboBoxRequestVerb.Items.Clear();
			comboBoxRequestVerb.Items.AddRange(new object[] {
				"PUT"
			});
			comboBoxRequestVerb.Text = "PUT";
			comboBoxContentType.Enabled = true;
		}

		private void radioButtonTypeDelete_CheckedChanged(object sender, EventArgs e) {
			interaction = Interaction.delete;
			comboBoxRequestVerb.Items.Clear();
			comboBoxRequestVerb.Items.AddRange(new object[] {
				"DELETE"
			});
			comboBoxRequestVerb.Text = "DELETE";
			comboBoxContentType.Text = "";
			comboBoxContentType.Enabled = false;
		}

		private void radioButtonTypeHistory_CheckedChanged(object sender, EventArgs e) {
			interaction = Interaction.history;
			comboBoxRequestVerb.Items.Clear();
			comboBoxRequestVerb.Items.AddRange(new object[] {
				"GET"
			});
			comboBoxRequestVerb.Text = "GET";
			comboBoxContentType.Text = "";
			comboBoxContentType.Enabled = false;
		}

		private void radioButtonTypeCreate_CheckedChanged(object sender, EventArgs e) {
			interaction = Interaction.create;
			comboBoxRequestVerb.Items.Clear();
			comboBoxRequestVerb.Items.AddRange(new object[] {
				"POST"
			});
			comboBoxRequestVerb.Text = "POST";
			comboBoxContentType.Enabled = true;
		}

		private void radioButtonTypeSearch_CheckedChanged(object sender, EventArgs e) {
			interaction = Interaction.search;
			comboBoxRequestVerb.Items.Clear();
			comboBoxRequestVerb.Items.AddRange(new object[] {
				"GET", "POST"
			});
			comboBoxContentType.Enabled = true;
			comboBoxRequestVerb.Text = "GET";
			comboBoxContentType.Text = "application/x-www-form-urlencoded";
		}

		private void radioButtonTypeBatch_CheckedChanged(object sender, EventArgs e) {
			interaction = Interaction.transaction;
			comboBoxRequestVerb.Items.Clear();
			comboBoxRequestVerb.Items.AddRange(new object[] {
				"POST"
			});
			comboBoxRequestVerb.Text = "POST";
			comboBoxContentType.Enabled = true;
		}

		private void comboBoxRequestVerb_TextChanged(object sender, EventArgs e) {
			if (comboBoxRequestVerb.Text == "GET") {
				comboBoxContentType.Text = "";
				comboBoxContentType.Enabled = false;
			} else {
				comboBoxContentType.Enabled = true;
			}
		}

		private void buttonValueSet_Click(object sender, EventArgs e) {
			ValueSet v = new ValueSet();
			v.ShowDialog(this);
		}

		private void buttonTest_Click(object sender, EventArgs e) {
			Cursor = Cursors.WaitCursor;
			Hl7.Fhir.Model.ValueSet vs;
			List<object> z = new List<object>();
			if (textBoxResource.Text.Contains("$")) {
				// Need to handle the expension
				using (WebClient w = new WebClient()) {
					string url = string.Empty;
					if (!comboBoxServer.Text.EndsWith("/")) {
						url = comboBoxServer.Text + "/" + textBoxResource.Text;
					} else {
						url = comboBoxServer.Text + textBoxResource.Text;
					}

					string x = w.DownloadString(url);

					vs = (Hl7.Fhir.Model.ValueSet)Hl7.Fhir.Serialization.FhirParser.ParseResourceFromJson(x);
					textBoxResponse.Text = Hl7.Fhir.Serialization.FhirSerializer.SerializeResourceToJson(vs);
				}
			} else {
				var client = new Hl7.Fhir.Rest.FhirClient(comboBoxServer.Text);
				client.PreferredFormat = Hl7.Fhir.Rest.ResourceFormat.Json;
				vs = client.Read<Hl7.Fhir.Model.ValueSet>(textBoxResource.Text);

				textBoxResponse.Text = Hl7.Fhir.Serialization.FhirSerializer.SerializeResourceToJson(vs);
			}

			if (vs.Expansion != null) {
				for (int i = 0; i < vs.Expansion.Contains.Count; i++) {
					z.Add(vs.Expansion.Contains[i].Display);
				}
			} else {
				if (vs.CodeSystem != null) {
					for (int i = 0; i < vs.CodeSystem.Concept.Count; i++) {
						z.Add(vs.CodeSystem.Concept[i].Display);
					}
				}
				if (vs.Compose != null) {
					for (int i = 0; i < vs.Compose.Include.Count; i++) {
						for (int j = 0; j < vs.Compose.Include[i].Concept.Count; j++) {
							z.Add(vs.Compose.Include[i].Concept[j].Display);
						}
					}
				}
			}
			comboBoxValueSet.Items.Clear();
			comboBoxValueSet.Items.AddRange(z.ToArray());
			
			Cursor = Cursors.Default;
		}

		private void buttonPushData_Click(object sender, EventArgs e) {
			// Push data to the server
			if (string.IsNullOrWhiteSpace(comboBoxServer.Text)) {
				MessageBox.Show("Server Root cannot be empty.");
			} else {
				if (!comboBoxServer.Text.EndsWith("/")) {
					comboBoxServer.Text = comboBoxServer.Text + "/";
				}
				string url = comboBoxServer.Text + textBoxResource.Text;
				Cursor = Cursors.WaitCursor;
				using (WebClient w = new WebClient()) {
					try {
						switch (comboBoxRequestVerb.Text) {
							case "PUT":
								if (url.Contains("?")) {
									url += "&_format=" + comboBoxContentType.Text;
								} else {
									url += "?_format=" + comboBoxContentType.Text;
								}
								break;
							case "POST":
								if (url.Contains("?")) {
									url += "&_format=" + comboBoxContentType.Text;
								} else {
									url += "?_format=" + comboBoxContentType.Text;
								}
								break;
							default:
								if (!string.IsNullOrWhiteSpace(comboBoxContentType.Text)) {
									w.Headers.Add("Content-Type", comboBoxContentType.Text);
								}
								break;
						}
						string x = w.UploadString(url, comboBoxRequestVerb.Text, textBoxData.Text);
						System.Xml.XmlDocument d = new System.Xml.XmlDocument();
						d.LoadXml(x);
						string json = Newtonsoft.Json.JsonConvert.SerializeXmlNode(d);
						textBoxResponse.Text = x;
					} catch(Exception ex) {
						MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace);
					}
				}
				Cursor = Cursors.Default;
			}
		}

		private void buttonGetData_Click(object sender, EventArgs e) {
			if (string.IsNullOrWhiteSpace(comboBoxServer.Text)) {
				MessageBox.Show("Server Root cannot be empty.");
			} else {
				if (!comboBoxServer.Text.EndsWith("/")) {
					comboBoxServer.Text = comboBoxServer.Text + "/";
				}
				string url = comboBoxServer.Text + textBoxResource.Text;
				Cursor = Cursors.WaitCursor;
				using (WebClient w = new WebClient()) {
					try {
						if (!string.IsNullOrWhiteSpace(comboBoxContentType.Text)) {
							w.Headers.Add("Content-Type", comboBoxContentType.Text);
						}
						textBoxResponse.Text = w.DownloadString(url);
					} catch (Exception ex) {
						MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace);
					}
				}
				Cursor = Cursors.Default;
			}
		}
	}

	enum Interaction {
		read,
		vread,
		update,
		delete,
		create,
		search,
		searchAll,
		transaction,
		history,
		historyType,
		historyAll
	}
}
