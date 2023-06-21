namespace ChatroomStudioForWindows
{
	partial class frmLoader
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			tabcLoader = new TabControl();
			tabpLoadInputText = new TabPage();
			tabpLoadLines = new TabPage();
			tabpLoadFilteredRows = new TabPage();
			btnLoadFiltered = new Button();
			dataGridView1 = new DataGridView();
			tabpLoadPostList = new TabPage();
			dataGridView2 = new DataGridView();
			tabpAudioControlPanel = new TabPage();
			tabpEtc = new TabPage();
			btnFilterRows = new Button();
			openFileDialog1 = new OpenFileDialog();
			ofdOpenFileDialogue = new OpenFileDialog();
			fbdInputFolder = new FolderBrowserDialog();
			bdsLines = new BindingSource(components);
			mcPostDateRange = new MonthCalendar();
			btnToRows = new Button();
			txtMemberHandle = new TextBox();
			lblRows = new Label();
			chkPostType = new CheckedListBox();
			grpDataset = new GroupBox();
			nddPostIndex = new NumericUpDown();
			txtPostContent = new TextBox();
			lblMemberHandle = new Label();
			dtpPostDate = new DateTimePicker();
			dgvChatroomTextLines = new DataGridView();
			grpSynth = new GroupBox();
			txtTextToSpeak = new TextBox();
			btnNewPost = new Button();
			grpAdjustments = new GroupBox();
			TrackBar2 = new TrackBar();
			TrackBar1 = new TrackBar();
			lblVolume = new Label();
			lblRate = new Label();
			BtnSpeak = new Button();
			lblVoice = new Label();
			chkRecord = new CheckBox();
			ddlVoices = new ComboBox();
			txtToWaveFile = new TextBox();
			groupBox1 = new GroupBox();
			label1 = new Label();
			txtFilePath = new TextBox();
			lblFilePath = new Label();
			txtWhatsAppFile = new TextBox();
			btnOpenFile = new Button();
			btnLoadPosts = new Button();
			tabcLoader.SuspendLayout();
			tabpLoadFilteredRows.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			tabpLoadPostList.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
			((System.ComponentModel.ISupportInitialize)bdsLines).BeginInit();
			grpDataset.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)nddPostIndex).BeginInit();
			((System.ComponentModel.ISupportInitialize)dgvChatroomTextLines).BeginInit();
			((System.ComponentModel.ISupportInitialize)TrackBar2).BeginInit();
			((System.ComponentModel.ISupportInitialize)TrackBar1).BeginInit();
			SuspendLayout();
			// 
			// tabcLoader
			// 
			tabcLoader.Controls.Add(tabpLoadInputText);
			tabcLoader.Controls.Add(tabpLoadLines);
			tabcLoader.Controls.Add(tabpLoadFilteredRows);
			tabcLoader.Controls.Add(tabpLoadPostList);
			tabcLoader.Controls.Add(tabpAudioControlPanel);
			tabcLoader.Controls.Add(tabpEtc);
			tabcLoader.Location = new Point(12, 12);
			tabcLoader.Name = "tabcLoader";
			tabcLoader.SelectedIndex = 0;
			tabcLoader.Size = new Size(1217, 679);
			tabcLoader.TabIndex = 0;
			// 
			// tabpLoadInputText
			// 
			tabpLoadInputText.Location = new Point(4, 24);
			tabpLoadInputText.Name = "tabpLoadInputText";
			tabpLoadInputText.Padding = new Padding(3);
			tabpLoadInputText.Size = new Size(1209, 651);
			tabpLoadInputText.TabIndex = 0;
			tabpLoadInputText.Text = "Input File";
			tabpLoadInputText.UseVisualStyleBackColor = true;
			// 
			// tabpLoadLines
			// 
			tabpLoadLines.Location = new Point(4, 24);
			tabpLoadLines.Name = "tabpLoadLines";
			tabpLoadLines.Padding = new Padding(3);
			tabpLoadLines.Size = new Size(1209, 651);
			tabpLoadLines.TabIndex = 1;
			tabpLoadLines.Text = "Input Lines";
			tabpLoadLines.UseVisualStyleBackColor = true;
			// 
			// tabpLoadFilteredRows
			// 
			tabpLoadFilteredRows.Controls.Add(btnLoadFiltered);
			tabpLoadFilteredRows.Controls.Add(dataGridView1);
			tabpLoadFilteredRows.Location = new Point(4, 24);
			tabpLoadFilteredRows.Name = "tabpLoadFilteredRows";
			tabpLoadFilteredRows.Padding = new Padding(3);
			tabpLoadFilteredRows.Size = new Size(1209, 651);
			tabpLoadFilteredRows.TabIndex = 2;
			tabpLoadFilteredRows.Text = "Filtered Lines";
			tabpLoadFilteredRows.UseVisualStyleBackColor = true;
			// 
			// btnLoadFiltered
			// 
			btnLoadFiltered.AutoSize = true;
			btnLoadFiltered.Location = new Point(385, 212);
			btnLoadFiltered.Name = "btnLoadFiltered";
			btnLoadFiltered.Size = new Size(181, 25);
			btnLoadFiltered.TabIndex = 26;
			btnLoadFiltered.Text = "Load Filtered";
			btnLoadFiltered.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(6, 21);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowTemplate.Height = 25;
			dataGridView1.Size = new Size(560, 163);
			dataGridView1.TabIndex = 13;
			// 
			// tabpLoadPostList
			// 
			tabpLoadPostList.Controls.Add(dataGridView2);
			tabpLoadPostList.Location = new Point(4, 24);
			tabpLoadPostList.Name = "tabpLoadPostList";
			tabpLoadPostList.Size = new Size(1209, 651);
			tabpLoadPostList.TabIndex = 3;
			tabpLoadPostList.Text = "Post List";
			tabpLoadPostList.UseVisualStyleBackColor = true;
			tabpLoadPostList.Controls.SetChildIndex(dataGridView2, 0);
			// 
			// dataGridView2
			// 
			dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView2.Location = new Point(14, 20);
			dataGridView2.Name = "dataGridView2";
			dataGridView2.RowTemplate.Height = 25;
			dataGridView2.Size = new Size(560, 163);
			dataGridView2.TabIndex = 14;
			// 
			// tabpAudioControlPanel
			// 
			tabpAudioControlPanel.Location = new Point(4, 24);
			tabpAudioControlPanel.Name = "tabpAudioControlPanel";
			tabpAudioControlPanel.Size = new Size(1209, 651);
			tabpAudioControlPanel.TabIndex = 4;
			tabpAudioControlPanel.Text = "Audio Controler";
			tabpAudioControlPanel.UseVisualStyleBackColor = true;
			// 
			// tabpEtc
			// 
			tabpEtc.Location = new Point(4, 24);
			tabpEtc.Name = "tabpEtc";
			tabpEtc.Size = new Size(1209, 651);
			tabpEtc.TabIndex = 5;
			tabpEtc.Text = "ETC";
			tabpEtc.UseVisualStyleBackColor = true;
			// 
			// btnFilterRows
			// 
			btnFilterRows.AutoSize = true;
			btnFilterRows.Location = new Point(401, 479);
			btnFilterRows.Name = "btnFilterRows";
			btnFilterRows.Size = new Size(181, 25);
			btnFilterRows.TabIndex = 25;
			btnFilterRows.Text = "Filter Rows";
			btnFilterRows.UseVisualStyleBackColor = true;
			// 
			// openFileDialog1
			// 
			openFileDialog1.FileName = "openFileDialog1";
			// 
			// ofdOpenFileDialogue
			// 
			ofdOpenFileDialogue.FileName = "WhatsApp Chat with Lenny.txt";
			ofdOpenFileDialogue.Filter = "WhatsApp Export File|WhatsApp Chat with *.txt|All Files|*.*";
			ofdOpenFileDialogue.Title = "Open WhatsApp Export File";
			// 
			// mcPostDateRange
			// 
			mcPostDateRange.AccessibleDescription = "Displays the range of days spanning the Chatroom Thread";
			mcPostDateRange.AccessibleName = "Chatroom thread of days covered in the export file; range in date from start to finish inclusively";
			mcPostDateRange.Location = new Point(22, 436);
			mcPostDateRange.Name = "mcPostDateRange";
			mcPostDateRange.TabIndex = 22;
			// 
			// btnToRows
			// 
			btnToRows.AutoSize = true;
			btnToRows.Location = new Point(401, 436);
			btnToRows.Name = "btnToRows";
			btnToRows.Size = new Size(181, 25);
			btnToRows.TabIndex = 24;
			btnToRows.Text = "Load Rows";
			btnToRows.UseVisualStyleBackColor = true;
			// 
			// txtMemberHandle
			// 
			txtMemberHandle.Location = new Point(228, 50);
			txtMemberHandle.Name = "txtMemberHandle";
			txtMemberHandle.Size = new Size(213, 23);
			txtMemberHandle.TabIndex = 21;
			txtMemberHandle.Text = "memberHandle_sadamski";
			// 
			// lblRows
			// 
			lblRows.AutoSize = true;
			lblRows.Location = new Point(22, 275);
			lblRows.Name = "lblRows";
			lblRows.Size = new Size(51, 15);
			lblRows.TabIndex = 20;
			lblRows.Text = "Row List";
			// 
			// chkPostType
			// 
			chkPostType.FormattingEnabled = true;
			chkPostType.Location = new Point(22, 80);
			chkPostType.Name = "chkPostType";
			chkPostType.Size = new Size(120, 166);
			chkPostType.TabIndex = 19;
			// 
			// grpDataset
			// 
			grpDataset.BackColor = SystemColors.ControlLight;
			grpDataset.Controls.Add(btnFilterRows);
			grpDataset.Controls.Add(mcPostDateRange);
			grpDataset.Controls.Add(btnToRows);
			grpDataset.Controls.Add(txtMemberHandle);
			grpDataset.Controls.Add(lblRows);
			grpDataset.Controls.Add(chkPostType);
			grpDataset.Location = new Point(6, 6);
			grpDataset.Name = "grpDataset";
			grpDataset.Size = new Size(588, 626);
			grpDataset.TabIndex = 23;
			grpDataset.TabStop = false;
			grpDataset.Text = "DataSet Group";
			grpDataset.Controls.SetChildIndex(chkPostType, 0);
			grpDataset.Controls.SetChildIndex(lblRows, 0);
			grpDataset.Controls.SetChildIndex(txtMemberHandle, 0);
			grpDataset.Controls.SetChildIndex(btnToRows, 0);
			grpDataset.Controls.SetChildIndex(mcPostDateRange, 0);
			grpDataset.Controls.SetChildIndex(btnFilterRows, 0);
			// 
			// nddPostIndex
			// 
			nddPostIndex.Location = new Point(462, 51);
			nddPostIndex.Name = "nddPostIndex";
			nddPostIndex.Size = new Size(120, 23);
			nddPostIndex.TabIndex = 18;
			// 
			// txtPostContent
			// 
			txtPostContent.Location = new Point(163, 80);
			txtPostContent.Multiline = true;
			txtPostContent.Name = "txtPostContent";
			txtPostContent.Size = new Size(419, 166);
			txtPostContent.TabIndex = 16;
			txtPostContent.Text = "WaksWorks presents Chatroom Studio Editor for windows";
			// 
			// lblMemberHandle
			// 
			lblMemberHandle.AutoSize = true;
			lblMemberHandle.Location = new Point(228, 29);
			lblMemberHandle.Name = "lblMemberHandle";
			lblMemberHandle.Size = new Size(90, 15);
			lblMemberHandle.TabIndex = 15;
			lblMemberHandle.Text = "MemberHandle";
			// 
			// dtpPostDate
			// 
			dtpPostDate.Location = new Point(22, 51);
			dtpPostDate.Name = "dtpPostDate";
			dtpPostDate.Size = new Size(200, 23);
			dtpPostDate.TabIndex = 14;
			// 
			// dgvChatroomTextLines
			// 
			dgvChatroomTextLines.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvChatroomTextLines.Location = new Point(22, 261);
			dgvChatroomTextLines.Name = "dgvChatroomTextLines";
			dgvChatroomTextLines.RowTemplate.Height = 25;
			dgvChatroomTextLines.Size = new Size(560, 163);
			dgvChatroomTextLines.TabIndex = 12;
			// 
			// grpSynth
			// 
			grpSynth.BackColor = SystemColors.Control;
			grpSynth.ForeColor = SystemColors.ActiveBorder;
			grpSynth.Location = new Point(12, 16);
			grpSynth.Name = "grpSynth";
			grpSynth.Size = new Size(579, 319);
			grpSynth.TabIndex = 25;
			grpSynth.TabStop = false;
			grpSynth.Text = "Synthesiser Group";
			// 
			// txtTextToSpeak
			// 
			txtTextToSpeak.Location = new Point(6, 44);
			txtTextToSpeak.Multiline = true;
			txtTextToSpeak.Name = "txtTextToSpeak";
			txtTextToSpeak.Size = new Size(542, 66);
			txtTextToSpeak.TabIndex = 12;
			txtTextToSpeak.Text = "WaksWorks presents Chatroom Studio Editor for windows";
			// 
			// btnNewPost
			// 
			btnNewPost.BackColor = SystemColors.Control;
			btnNewPost.Location = new Point(102, 119);
			btnNewPost.Name = "btnNewPost";
			btnNewPost.Size = new Size(75, 23);
			btnNewPost.TabIndex = 20;
			btnNewPost.Text = "Create New Post";
			btnNewPost.UseVisualStyleBackColor = false;
			// 
			// grpAdjustments
			// 
			grpAdjustments.BackColor = SystemColors.ControlLight;
			grpAdjustments.Location = new Point(7, 147);
			grpAdjustments.Name = "grpAdjustments";
			grpAdjustments.Size = new Size(541, 163);
			grpAdjustments.TabIndex = 11;
			grpAdjustments.TabStop = false;
			grpAdjustments.Text = "Adjustments";
			// 
			// TrackBar2
			// 
			TrackBar2.BackColor = SystemColors.ControlLightLight;
			TrackBar2.Location = new Point(-1, 91);
			TrackBar2.Name = "TrackBar2";
			TrackBar2.Size = new Size(340, 45);
			TrackBar2.TabIndex = 6;
			// 
			// TrackBar1
			// 
			TrackBar1.BackColor = SystemColors.ControlLightLight;
			TrackBar1.Location = new Point(-1, 25);
			TrackBar1.Name = "TrackBar1";
			TrackBar1.Size = new Size(340, 45);
			TrackBar1.TabIndex = 5;
			// 
			// lblVolume
			// 
			lblVolume.AutoSize = true;
			lblVolume.Location = new Point(356, 91);
			lblVolume.Name = "lblVolume";
			lblVolume.Size = new Size(47, 15);
			lblVolume.TabIndex = 9;
			lblVolume.Text = "Volume";
			// 
			// lblRate
			// 
			lblRate.AutoSize = true;
			lblRate.Location = new Point(356, 25);
			lblRate.Name = "lblRate";
			lblRate.Size = new Size(30, 15);
			lblRate.TabIndex = 10;
			lblRate.Text = "Rate";
			// 
			// BtnSpeak
			// 
			BtnSpeak.AutoSize = true;
			BtnSpeak.BackColor = SystemColors.Control;
			BtnSpeak.Location = new Point(7, 118);
			BtnSpeak.Name = "BtnSpeak";
			BtnSpeak.Size = new Size(75, 25);
			BtnSpeak.TabIndex = 0;
			BtnSpeak.Text = "Speak";
			BtnSpeak.UseVisualStyleBackColor = false;
			// 
			// lblVoice
			// 
			lblVoice.AutoSize = true;
			lblVoice.Location = new Point(281, -7);
			lblVoice.Name = "lblVoice";
			lblVoice.Size = new Size(35, 15);
			lblVoice.TabIndex = 15;
			lblVoice.Text = "Voice";
			// 
			// chkRecord
			// 
			chkRecord.AutoSize = true;
			chkRecord.BackColor = SystemColors.ControlLightLight;
			chkRecord.Location = new Point(432, 119);
			chkRecord.Name = "chkRecord";
			chkRecord.Size = new Size(116, 19);
			chkRecord.TabIndex = 13;
			chkRecord.Text = "Record Wave File";
			chkRecord.UseVisualStyleBackColor = false;
			// 
			// ddlVoices
			// 
			ddlVoices.FormattingEnabled = true;
			ddlVoices.Location = new Point(322, 15);
			ddlVoices.Name = "ddlVoices";
			ddlVoices.Size = new Size(226, 23);
			ddlVoices.TabIndex = 7;
			// 
			// txtToWaveFile
			// 
			txtToWaveFile.Location = new Point(183, 119);
			txtToWaveFile.Name = "txtToWaveFile";
			txtToWaveFile.Size = new Size(233, 23);
			txtToWaveFile.TabIndex = 14;
			txtToWaveFile.Text = "SampleWave.wav";
			// 
			// groupBox1
			// 
			groupBox1.Location = new Point(6, 21);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(570, 397);
			groupBox1.TabIndex = 28;
			groupBox1.TabStop = false;
			groupBox1.Text = "IO Group";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(3, 267);
			label1.Name = "label1";
			label1.Size = new Size(74, 15);
			label1.TabIndex = 25;
			label1.Text = "Text Content";
			// 
			// txtFilePath
			// 
			txtFilePath.Location = new Point(188, 24);
			txtFilePath.Name = "txtFilePath";
			txtFilePath.Size = new Size(213, 23);
			txtFilePath.TabIndex = 23;
			txtFilePath.Text = "WhatsApp Chat With _.txt";
			// 
			// lblFilePath
			// 
			lblFilePath.AutoSize = true;
			lblFilePath.Location = new Point(407, 27);
			lblFilePath.Name = "lblFilePath";
			lblFilePath.Size = new Size(52, 15);
			lblFilePath.TabIndex = 22;
			lblFilePath.Text = "File Path";
			// 
			// txtWhatsAppFile
			// 
			txtWhatsAppFile.Location = new Point(3, 54);
			txtWhatsAppFile.Multiline = true;
			txtWhatsAppFile.Name = "txtWhatsAppFile";
			txtWhatsAppFile.Size = new Size(546, 207);
			txtWhatsAppFile.TabIndex = 1;
			// 
			// btnOpenFile
			// 
			btnOpenFile.AutoSize = true;
			btnOpenFile.Location = new Point(6, 22);
			btnOpenFile.Name = "btnOpenFile";
			btnOpenFile.Size = new Size(181, 25);
			btnOpenFile.TabIndex = 0;
			btnOpenFile.Text = "Load Text";
			btnOpenFile.UseVisualStyleBackColor = true;
			// 
			// btnLoadPosts
			// 
			btnLoadPosts.AutoSize = true;
			btnLoadPosts.Location = new Point(393, 204);
			btnLoadPosts.Name = "btnLoadPosts";
			btnLoadPosts.Size = new Size(181, 25);
			btnLoadPosts.TabIndex = 25;
			btnLoadPosts.Text = "Load Posts";
			btnLoadPosts.UseVisualStyleBackColor = true;
			btnLoadPosts.Click += btnLoadPosts_Click;
			// 
			// frmLoader
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1289, 805);
			Controls.Add(tabcLoader);
			Name = "frmLoader";
			Text = "frmLoader";
			tabcLoader.ResumeLayout(false);
			tabpLoadFilteredRows.ResumeLayout(false);
			tabpLoadFilteredRows.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			tabpLoadPostList.ResumeLayout(false);
			tabpLoadPostList.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
			((System.ComponentModel.ISupportInitialize)bdsLines).EndInit();
			grpDataset.ResumeLayout(false);
			grpDataset.PerformLayout();
			((System.ComponentModel.ISupportInitialize)nddPostIndex).EndInit();
			((System.ComponentModel.ISupportInitialize)dgvChatroomTextLines).EndInit();
			((System.ComponentModel.ISupportInitialize)TrackBar2).EndInit();
			((System.ComponentModel.ISupportInitialize)TrackBar1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private TabControl tabcLoader;
		private TabPage tabpLoadInputText;
		private TabPage tabpLoadLines;
		private TabPage tabpLoadFilteredRows;
		private TabPage tabpLoadPostList;
		private TabPage tabpAudioControlPanel;
		private TabPage tabpEtc;
		private GroupBox grpDataset;
		private Button btnFilterRows;
		private MonthCalendar mcPostDateRange;
		private Button btnToRows;
		private TextBox txtMemberHandle;
		private Label lblRows;
		private CheckedListBox chkPostType;
		private NumericUpDown nddPostIndex;
		private TextBox txtPostContent;
		private Label lblMemberHandle;
		private DateTimePicker dtpPostDate;
		private DataGridView dgvChatroomTextLines;
		private OpenFileDialog openFileDialog1;
		private OpenFileDialog ofdOpenFileDialogue;
		private FolderBrowserDialog fbdInputFolder;
		private BindingSource bdsLines;
		private GroupBox grpSynth;
		private TextBox txtTextToSpeak;
		private Button btnNewPost;
		private GroupBox grpAdjustments;
		private TrackBar TrackBar2;
		private TrackBar TrackBar1;
		private Label lblVolume;
		private Label lblRate;
		private Button BtnSpeak;
		private Label lblVoice;
		private CheckBox chkRecord;
		private ComboBox ddlVoices;
		private TextBox txtToWaveFile;
		private GroupBox groupBox1;
		private Label label1;
		private TextBox txtFilePath;
		private Label lblFilePath;
		private TextBox txtWhatsAppFile;
		private Button btnOpenFile;
		private DataGridView dataGridView2;
		private Button btnLoadFiltered;
		private DataGridView dataGridView1;
		private Button btnLoadPosts;
	}
}