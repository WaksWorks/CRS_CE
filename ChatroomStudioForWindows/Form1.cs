using Microsoft.VisualBasic;
using System.Globalization;
using System.Speech.Synthesis;
using CSR;
using CSR.Entities;
using CSR.Entities.Extensions;
using System.Windows.Forms;
using System;
using CSR.Collections;
using System.ComponentModel.Design;

namespace ChatroomStudioForWindows
{
	public partial class Form1 : Form
	{
		private int _speechRate = 0;
		private int _speechVolume = 50;
		public Form1()
		{
			InitializeComponent();

			lblRate.Text =
			   _speechRate.ToString(CultureInfo.InvariantCulture);
			lblVolume.Text =
			   _speechVolume.ToString(CultureInfo.InvariantCulture);
			AddInstalledVoicesToList();
		}
		private void BtnSpeakClick(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtTextToSpeak.Text))
			{
				MessageBox.Show(@"Please enter some text in the   
                   text box before trying to speak");
				return;
			}

			using (SpeechSynthesizer synth = new SpeechSynthesizer
			{
				Volume =
			   _speechVolume,
				Rate = _speechRate
			})
			{
				if (chkRecord.Checked)
				{
					// Configure the audio output. 
					synth.SetOutputToWaveFile(txtToWaveFile.Text);

					// Create a SoundPlayer instance to play the output audio file.
					System.Media.SoundPlayer m_SoundPlayer =
					  new System.Media.SoundPlayer(txtToWaveFile.Text);
				}
				{
					synth.SelectVoice(ddlVoices.Text);
					grpAdjustments.Enabled = false;
					synth.Speak(txtTextToSpeak.Text);
					grpAdjustments.Enabled = true;
				}
			}
		}
		private void TrackBar1ValueChanged(object sender, EventArgs e)
		{
			_speechRate = TrackBar1.Value;
			lblRate.Text =
			   _speechRate.ToString(CultureInfo.InvariantCulture);
		}
		private void TrackBar2ValueChanged(object sender, EventArgs e)
		{
			_speechVolume = TrackBar2.Value;
			lblVolume.Text =
			   _speechVolume.ToString(CultureInfo.InvariantCulture);
		}
		private void AddInstalledVoicesToList()
		{
			using (SpeechSynthesizer synth = new SpeechSynthesizer())
			{
				foreach (var voice in synth.GetInstalledVoices())
				{
					ddlVoices.Items.Add(voice.VoiceInfo.Name);
				}
			}
			ddlVoices.SelectedIndex = 0;
		}

		private void grpAdjustments_Enter(object sender, EventArgs e)
		{

		}

		private void btnSpeak_Click(object sender, EventArgs e)
		{
			BtnSpeakClick(sender, e);
		}

		private void trackBar1_Scroll(object sender, EventArgs e)
		{

		}

		private void TrackBar2_Scroll(object sender, EventArgs e)
		{

		}

		private void TrackBar2_Scroll_1(object sender, EventArgs e)
		{

		}

		private void dbgRows_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			var str = (string)dgvChatroomTextLines.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
			var p = str.ToPost();
			MessageBox.Show(p.Message);
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void ofdOpenFileDialogue_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{

		}

		private void btnOpenFile_Click(object sender, EventArgs e)
		{
			var fileContent = string.Empty;
			var filePath = string.Empty;
			//>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
			using (openFileDialog1 = new OpenFileDialog())
			{
				openFileDialog1.RestoreDirectory = true;

				if (openFileDialog1.ShowDialog() == DialogResult.OK)
				{
					//Get the path of specified file
					filePath = openFileDialog1.FileName;

					//Read the contents of the file into a stream
					var fileStream = openFileDialog1.OpenFile();

					using (StreamReader reader = new StreamReader(fileStream))
					{
						fileContent = reader.ReadToEnd();
					}
				}
			}
			//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
			txtWhatsAppFile.Text = fileContent;
			txtFilePath.Text = filePath;
		}

		[Obsolete]
		private void btnToRows_Click(object sender, EventArgs e)
		{
			dgvChatroomTextLines.AutoGenerateColumns = true;
			var lines = File.ReadAllLines(txtFilePath.Text);
			var filtered = lines.GetFilteredRows();
			this.bdsLines.DataSource = filtered.Select(s => new { Row = s }).ToList();
			dgvChatroomTextLines.DataSource = bdsLines;

		}

		private void btnFilterRows_Click(object sender, EventArgs e)
		{
			ChatRecordSet crs = new ChatRecordSet();
			crs.Load(txtFilePath.Text);
			if (crs.IsLoaded)
			{
				dgvFilteredRows.AutoGenerateColumns = true;

				this.bdsLines.DataSource = crs.FilteredRows.ToList();
				dgvFilteredRows.DataSource = bdsLines;
			}
		}

		private void btnLoadPosts_Click(object sender, EventArgs e)
		{

			var rs = new PostList(txtFilePath.Text);
			rs.LoadOriginalText();

			dgvPosts.AutoGenerateColumns = true;

			this.bdsLines.DataSource = rs;
			dgvPosts.DataSource = bdsLines;
			dgvPosts.BeginInvoke(new MethodInvoker(delegate
			{
				dgvPosts.FirstDisplayedScrollingRowIndex = dgvPosts.RowCount - 1;
			}));
		}

		private void dgvPosts_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			//load post members to seperate controls
			var p = (Post)dgvPosts.Rows[e.RowIndex].DataBoundItem;
			txtPostContent.Text = p.Message;
			txtMemberHandle.Text = p.MemberHandle;
			monthCalendar1.SetDate(p.TimePosted.GetValueOrDefault());
			//set p.timeposted to a winform control
			dtpPostDate.Value = p.TimePosted.GetValueOrDefault();

		}

		private void tooltTransitions_Popup(object sender, PopupEventArgs e)
		{
			tooltTransitions.SetToolTip(txtFilePath, "Speak the text in the text box");
		}

		private void dtpPostDate_ValueChanged(object sender, EventArgs e)
		{

		}

		private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
		{

		}

		private void btnSaveLines_Click(object sender, EventArgs e)
		{
			File.WriteAllLines(Path.ChangeExtension(txtFilePath.Text, ".crslines"), txtWhatsAppFile.Lines);
		}

		private void bbtnSaveFilteredRows_Click(object sender, EventArgs e)
		{
			var fl = new FilteredRowList(txtFilePath.Text);
			fl.LoadOriginalText();
			fl.SaveJson();
		}

		private void btnSavePosts_Click(object sender, EventArgs e)
		{
			var pl = new PostList(txtFilePath.Text);
			pl.LoadOriginalText();
			pl.SaveJson();
			pl.SaveCSV();
		}

		private void btnSaveAllPacked_Click(object sender, EventArgs e)
		{
			var pl = new PostList(txtFilePath.Text);
			pl.LoadOriginalText();
			pl.SaveJson();
			pl.SaveCSV();
			var fl = new FilteredRowList(txtFilePath.Text);
			fl.LoadOriginalText();
			fl.SaveJson();
			`
		}
	}
}

