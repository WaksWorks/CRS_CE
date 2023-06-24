namespace ChatroomStudioForWindows
{
	partial class Form1
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
			txtTextToSpeak = new TextBox();
			grpAdjustments = new GroupBox();
			TrackBar2 = new TrackBar();
			TrackBar1 = new TrackBar();
			lblVolume = new Label();
			lblRate = new Label();
			ddlVoices = new ComboBox();
			BtnSpeak = new Button();
			chkRecord = new CheckBox();
			txtToWaveFile = new TextBox();
			lblVoice = new Label();
			grpDataset = new GroupBox();
			dgvFilteredRows = new DataGridView();
			bbtnSaveFilteredRows = new Button();
			btnFilterRows = new Button();
			btnLoadPosts = new Button();
			btnToRows = new Button();
			txtMemberHandle = new TextBox();
			chkPostType = new CheckedListBox();
			nddPostIndex = new NumericUpDown();
			txtPostContent = new TextBox();
			lblMemberHandle = new Label();
			dtpPostDate = new DateTimePicker();
			dgvChatroomTextLines = new DataGridView();
			btnNewPost = new Button();
			grpSynth = new GroupBox();
			fbdInputFolder = new FolderBrowserDialog();
			ofdOpenFileDialogue = new OpenFileDialog();
			groupBox1 = new GroupBox();
			label1 = new Label();
			txtFilePath = new TextBox();
			lblFilePath = new Label();
			txtWhatsAppFile = new TextBox();
			btnOpenFile = new Button();
			openFileDialog1 = new OpenFileDialog();
			bdsLines = new BindingSource(components);
			tabControl1 = new TabControl();
			tabpLoadInputText = new TabPage();
			tabpToLines = new TabPage();
			btnSaveLines = new Button();
			tabpToFilteredRows = new TabPage();
			tabpToPosts = new TabPage();
			monthCalendar1 = new MonthCalendar();
			dgvPosts = new DataGridView();
			btnSavePosts = new Button();
			tabpAudioSettings = new TabPage();
			helpProvider1 = new HelpProvider();
			fileSystemWatcher1 = new FileSystemWatcher();
			folderBrowserDialog1 = new FolderBrowserDialog();
			pageSetupDialog1 = new PageSetupDialog();
			saveFileDialog1 = new SaveFileDialog();
			timer1 = new System.Windows.Forms.Timer(components);
			tooltTransitions = new ToolTip(components);
			tabpPackage = new TabPage();
			btnSaveAllPacked = new Button();
			grpAdjustments.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)TrackBar2).BeginInit();
			((System.ComponentModel.ISupportInitialize)TrackBar1).BeginInit();
			grpDataset.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvFilteredRows).BeginInit();
			((System.ComponentModel.ISupportInitialize)nddPostIndex).BeginInit();
			((System.ComponentModel.ISupportInitialize)dgvChatroomTextLines).BeginInit();
			grpSynth.SuspendLayout();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)bdsLines).BeginInit();
			tabControl1.SuspendLayout();
			tabpLoadInputText.SuspendLayout();
			tabpToLines.SuspendLayout();
			tabpToFilteredRows.SuspendLayout();
			tabpToPosts.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvPosts).BeginInit();
			tabpAudioSettings.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
			tabpPackage.SuspendLayout();
			SuspendLayout();
			// 
			// txtTextToSpeak
			// 
			txtTextToSpeak.Location = new Point(27, 22);
			txtTextToSpeak.Multiline = true;
			txtTextToSpeak.Name = "txtTextToSpeak";
			txtTextToSpeak.Size = new Size(542, 324);
			txtTextToSpeak.TabIndex = 12;
			txtTextToSpeak.Text = "WaksWorks presents Chatroom Studio Editor for windows";
			// 
			// grpAdjustments
			// 
			grpAdjustments.BackColor = SystemColors.ControlLight;
			grpAdjustments.Controls.Add(TrackBar2);
			grpAdjustments.Controls.Add(TrackBar1);
			grpAdjustments.Controls.Add(lblVolume);
			grpAdjustments.Controls.Add(lblRate);
			grpAdjustments.Location = new Point(28, 434);
			grpAdjustments.Name = "grpAdjustments";
			grpAdjustments.Size = new Size(541, 163);
			grpAdjustments.TabIndex = 11;
			grpAdjustments.TabStop = false;
			grpAdjustments.Text = "Adjustments";
			grpAdjustments.Enter += grpAdjustments_Enter;
			// 
			// TrackBar2
			// 
			TrackBar2.BackColor = SystemColors.ControlLightLight;
			TrackBar2.Location = new Point(-1, 91);
			TrackBar2.Name = "TrackBar2";
			TrackBar2.Size = new Size(340, 45);
			TrackBar2.TabIndex = 6;
			TrackBar2.Scroll += TrackBar2_Scroll_1;
			TrackBar2.ValueChanged += TrackBar2ValueChanged;
			// 
			// TrackBar1
			// 
			TrackBar1.BackColor = SystemColors.ControlLightLight;
			TrackBar1.Location = new Point(-1, 25);
			TrackBar1.Name = "TrackBar1";
			TrackBar1.Size = new Size(340, 45);
			TrackBar1.TabIndex = 5;
			TrackBar1.ValueChanged += TrackBar1ValueChanged;
			// 
			// lblVolume
			// 
			lblVolume.AutoSize = true;
			lblVolume.BackColor = SystemColors.ButtonFace;
			lblVolume.Location = new Point(356, 91);
			lblVolume.Name = "lblVolume";
			lblVolume.Size = new Size(47, 15);
			lblVolume.TabIndex = 9;
			lblVolume.Text = "Volume";
			// 
			// lblRate
			// 
			lblRate.AutoSize = true;
			lblRate.BackColor = SystemColors.ButtonFace;
			lblRate.Location = new Point(356, 25);
			lblRate.Name = "lblRate";
			lblRate.Size = new Size(30, 15);
			lblRate.TabIndex = 10;
			lblRate.Text = "Rate";
			// 
			// ddlVoices
			// 
			ddlVoices.FormattingEnabled = true;
			ddlVoices.Location = new Point(28, 363);
			ddlVoices.Name = "ddlVoices";
			ddlVoices.Size = new Size(540, 23);
			ddlVoices.TabIndex = 7;
			// 
			// BtnSpeak
			// 
			BtnSpeak.AutoSize = true;
			BtnSpeak.BackColor = SystemColors.ButtonFace;
			BtnSpeak.Location = new Point(28, 389);
			BtnSpeak.Name = "BtnSpeak";
			BtnSpeak.Size = new Size(75, 25);
			BtnSpeak.TabIndex = 0;
			BtnSpeak.Text = "Speak";
			BtnSpeak.UseVisualStyleBackColor = false;
			BtnSpeak.Click += BtnSpeakClick;
			// 
			// chkRecord
			// 
			chkRecord.AutoSize = true;
			chkRecord.BackColor = SystemColors.ButtonFace;
			chkRecord.Location = new Point(452, 396);
			chkRecord.Name = "chkRecord";
			chkRecord.Size = new Size(116, 19);
			chkRecord.TabIndex = 13;
			chkRecord.Text = "Record Wave File";
			chkRecord.UseVisualStyleBackColor = false;
			// 
			// txtToWaveFile
			// 
			txtToWaveFile.Location = new Point(109, 392);
			txtToWaveFile.Name = "txtToWaveFile";
			txtToWaveFile.Size = new Size(233, 23);
			txtToWaveFile.TabIndex = 14;
			txtToWaveFile.Text = "SampleWave.wav";
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
			// grpDataset
			// 
			grpDataset.BackColor = Color.Orange;
			grpDataset.Controls.Add(dgvFilteredRows);
			grpDataset.Controls.Add(bbtnSaveFilteredRows);
			grpDataset.Controls.Add(btnFilterRows);
			grpDataset.Location = new Point(6, 6);
			grpDataset.Name = "grpDataset";
			grpDataset.Size = new Size(667, 660);
			grpDataset.TabIndex = 16;
			grpDataset.TabStop = false;
			grpDataset.Text = "DataSet Group";
			// 
			// dgvFilteredRows
			// 
			dgvFilteredRows.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvFilteredRows.Location = new Point(31, 47);
			dgvFilteredRows.Name = "dgvFilteredRows";
			dgvFilteredRows.RowTemplate.Height = 25;
			dgvFilteredRows.Size = new Size(560, 520);
			dgvFilteredRows.TabIndex = 30;
			// 
			// bbtnSaveFilteredRows
			// 
			bbtnSaveFilteredRows.AutoSize = true;
			bbtnSaveFilteredRows.Location = new Point(401, 597);
			bbtnSaveFilteredRows.Name = "bbtnSaveFilteredRows";
			bbtnSaveFilteredRows.Size = new Size(181, 25);
			bbtnSaveFilteredRows.TabIndex = 28;
			bbtnSaveFilteredRows.Text = "Save Filter Rows";
			bbtnSaveFilteredRows.UseVisualStyleBackColor = true;
			bbtnSaveFilteredRows.Click += bbtnSaveFilteredRows_Click;
			// 
			// btnFilterRows
			// 
			btnFilterRows.AutoSize = true;
			btnFilterRows.Location = new Point(31, 597);
			btnFilterRows.Name = "btnFilterRows";
			btnFilterRows.Size = new Size(181, 25);
			btnFilterRows.TabIndex = 25;
			btnFilterRows.Text = "Filter Rows";
			btnFilterRows.UseVisualStyleBackColor = true;
			btnFilterRows.Click += btnFilterRows_Click;
			// 
			// btnLoadPosts
			// 
			btnLoadPosts.AutoSize = true;
			btnLoadPosts.Location = new Point(37, 669);
			btnLoadPosts.Name = "btnLoadPosts";
			btnLoadPosts.Size = new Size(120, 25);
			btnLoadPosts.TabIndex = 26;
			btnLoadPosts.Text = "Load Posts";
			btnLoadPosts.UseVisualStyleBackColor = true;
			btnLoadPosts.Click += btnLoadPosts_Click;
			// 
			// btnToRows
			// 
			btnToRows.AutoSize = true;
			btnToRows.Location = new Point(33, 613);
			btnToRows.Name = "btnToRows";
			btnToRows.Size = new Size(181, 25);
			btnToRows.TabIndex = 24;
			btnToRows.Text = "Load Lines";
			btnToRows.UseVisualStyleBackColor = true;
			btnToRows.Click += btnToRows_Click;
			// 
			// txtMemberHandle
			// 
			txtMemberHandle.Location = new Point(173, 66);
			txtMemberHandle.Name = "txtMemberHandle";
			txtMemberHandle.Size = new Size(257, 23);
			txtMemberHandle.TabIndex = 21;
			txtMemberHandle.Text = "memberHandle_sadamski";
			// 
			// chkPostType
			// 
			chkPostType.FormattingEnabled = true;
			chkPostType.Location = new Point(37, 96);
			chkPostType.Name = "chkPostType";
			chkPostType.Size = new Size(120, 166);
			chkPostType.TabIndex = 19;
			// 
			// nddPostIndex
			// 
			nddPostIndex.Location = new Point(441, 67);
			nddPostIndex.Name = "nddPostIndex";
			nddPostIndex.Size = new Size(227, 23);
			nddPostIndex.TabIndex = 18;
			// 
			// txtPostContent
			// 
			txtPostContent.Location = new Point(173, 96);
			txtPostContent.Multiline = true;
			txtPostContent.Name = "txtPostContent";
			txtPostContent.Size = new Size(257, 166);
			txtPostContent.TabIndex = 16;
			txtPostContent.Text = "WaksWorks presents Chatroom Studio Editor for windows";
			// 
			// lblMemberHandle
			// 
			lblMemberHandle.AutoSize = true;
			lblMemberHandle.Location = new Point(274, 48);
			lblMemberHandle.Name = "lblMemberHandle";
			lblMemberHandle.Size = new Size(90, 15);
			lblMemberHandle.TabIndex = 15;
			lblMemberHandle.Text = "MemberHandle";
			// 
			// dtpPostDate
			// 
			dtpPostDate.Location = new Point(37, 67);
			dtpPostDate.Name = "dtpPostDate";
			dtpPostDate.Size = new Size(120, 23);
			dtpPostDate.TabIndex = 14;
			dtpPostDate.ValueChanged += dtpPostDate_ValueChanged;
			// 
			// dgvChatroomTextLines
			// 
			dgvChatroomTextLines.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvChatroomTextLines.Location = new Point(33, 41);
			dgvChatroomTextLines.Name = "dgvChatroomTextLines";
			dgvChatroomTextLines.RowTemplate.Height = 25;
			dgvChatroomTextLines.Size = new Size(560, 535);
			dgvChatroomTextLines.TabIndex = 12;
			dgvChatroomTextLines.CellContentClick += dbgRows_CellContentClick;
			// 
			// btnNewPost
			// 
			btnNewPost.BackColor = SystemColors.ButtonFace;
			btnNewPost.Location = new Point(350, 396);
			btnNewPost.Name = "btnNewPost";
			btnNewPost.Size = new Size(75, 23);
			btnNewPost.TabIndex = 20;
			btnNewPost.Text = "Record";
			btnNewPost.UseVisualStyleBackColor = false;
			// 
			// grpSynth
			// 
			grpSynth.BackColor = Color.Orange;
			grpSynth.Controls.Add(txtTextToSpeak);
			grpSynth.Controls.Add(btnNewPost);
			grpSynth.Controls.Add(grpAdjustments);
			grpSynth.Controls.Add(BtnSpeak);
			grpSynth.Controls.Add(lblVoice);
			grpSynth.Controls.Add(chkRecord);
			grpSynth.Controls.Add(ddlVoices);
			grpSynth.Controls.Add(txtToWaveFile);
			grpSynth.ForeColor = SystemColors.ActiveBorder;
			grpSynth.Location = new Point(29, 33);
			grpSynth.Name = "grpSynth";
			grpSynth.Size = new Size(628, 638);
			grpSynth.TabIndex = 21;
			grpSynth.TabStop = false;
			grpSynth.Text = "Synthesiser Group";
			// 
			// ofdOpenFileDialogue
			// 
			ofdOpenFileDialogue.FileName = "WhatsApp Chat with Lenny.txt";
			ofdOpenFileDialogue.Filter = "WhatsApp Export File|WhatsApp Chat with *.txt|All Files|*.*";
			ofdOpenFileDialogue.Title = "Open WhatsApp Export File";
			ofdOpenFileDialogue.FileOk += ofdOpenFileDialogue_FileOk;
			// 
			// groupBox1
			// 
			groupBox1.BackColor = Color.Orange;
			groupBox1.Controls.Add(label1);
			groupBox1.Controls.Add(txtFilePath);
			groupBox1.Controls.Add(lblFilePath);
			groupBox1.Controls.Add(txtWhatsAppFile);
			groupBox1.Controls.Add(btnOpenFile);
			groupBox1.Location = new Point(21, 19);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(625, 653);
			groupBox1.TabIndex = 22;
			groupBox1.TabStop = false;
			groupBox1.Text = "IO Group";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(31, 478);
			label1.Name = "label1";
			label1.Size = new Size(74, 15);
			label1.TabIndex = 25;
			label1.Text = "Text Content";
			// 
			// txtFilePath
			// 
			txtFilePath.Location = new Point(31, 35);
			txtFilePath.Name = "txtFilePath";
			txtFilePath.Size = new Size(546, 23);
			txtFilePath.TabIndex = 23;
			txtFilePath.Text = "WhatsApp Chat With _.txt";
			// 
			// lblFilePath
			// 
			lblFilePath.AutoSize = true;
			lblFilePath.Location = new Point(525, 19);
			lblFilePath.Name = "lblFilePath";
			lblFilePath.Size = new Size(52, 15);
			lblFilePath.TabIndex = 22;
			lblFilePath.Text = "File Path";
			// 
			// txtWhatsAppFile
			// 
			txtWhatsAppFile.Location = new Point(31, 77);
			txtWhatsAppFile.Multiline = true;
			txtWhatsAppFile.Name = "txtWhatsAppFile";
			txtWhatsAppFile.Size = new Size(546, 502);
			txtWhatsAppFile.TabIndex = 1;
			// 
			// btnOpenFile
			// 
			btnOpenFile.AutoSize = true;
			btnOpenFile.Location = new Point(421, 604);
			btnOpenFile.Name = "btnOpenFile";
			btnOpenFile.Size = new Size(156, 25);
			btnOpenFile.TabIndex = 0;
			btnOpenFile.Text = "Load Text";
			btnOpenFile.UseVisualStyleBackColor = true;
			btnOpenFile.Click += btnOpenFile_Click;
			// 
			// openFileDialog1
			// 
			openFileDialog1.FileName = "openFileDialog1";
			// 
			// tabControl1
			// 
			tabControl1.Controls.Add(tabpLoadInputText);
			tabControl1.Controls.Add(tabpToLines);
			tabControl1.Controls.Add(tabpToFilteredRows);
			tabControl1.Controls.Add(tabpToPosts);
			tabControl1.Controls.Add(tabpAudioSettings);
			tabControl1.Controls.Add(tabpPackage);
			tabControl1.Location = new Point(27, 12);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size(688, 728);
			tabControl1.TabIndex = 23;
			// 
			// tabpLoadInputText
			// 
			tabpLoadInputText.Controls.Add(groupBox1);
			tabpLoadInputText.Location = new Point(4, 24);
			tabpLoadInputText.Name = "tabpLoadInputText";
			tabpLoadInputText.Padding = new Padding(3);
			tabpLoadInputText.Size = new Size(680, 700);
			tabpLoadInputText.TabIndex = 0;
			tabpLoadInputText.Text = "Load Input File";
			tabpLoadInputText.UseVisualStyleBackColor = true;
			// 
			// tabpToLines
			// 
			tabpToLines.Controls.Add(dgvChatroomTextLines);
			tabpToLines.Controls.Add(btnToRows);
			tabpToLines.Controls.Add(btnSaveLines);
			tabpToLines.Location = new Point(4, 24);
			tabpToLines.Name = "tabpToLines";
			tabpToLines.Padding = new Padding(3);
			tabpToLines.Size = new Size(680, 700);
			tabpToLines.TabIndex = 1;
			tabpToLines.Text = "Transform To Lines";
			tabpToLines.UseVisualStyleBackColor = true;
			// 
			// btnSaveLines
			// 
			btnSaveLines.AutoSize = true;
			btnSaveLines.Location = new Point(412, 613);
			btnSaveLines.Name = "btnSaveLines";
			btnSaveLines.Size = new Size(181, 25);
			btnSaveLines.TabIndex = 27;
			btnSaveLines.Text = "Save Lines";
			btnSaveLines.UseVisualStyleBackColor = true;
			btnSaveLines.Click += btnSaveLines_Click;
			// 
			// tabpToFilteredRows
			// 
			tabpToFilteredRows.Controls.Add(grpDataset);
			tabpToFilteredRows.Location = new Point(4, 24);
			tabpToFilteredRows.Name = "tabpToFilteredRows";
			tabpToFilteredRows.Padding = new Padding(3);
			tabpToFilteredRows.Size = new Size(680, 700);
			tabpToFilteredRows.TabIndex = 2;
			tabpToFilteredRows.Text = "To Filtered";
			tabpToFilteredRows.UseVisualStyleBackColor = true;
			// 
			// tabpToPosts
			// 
			tabpToPosts.Controls.Add(monthCalendar1);
			tabpToPosts.Controls.Add(dgvPosts);
			tabpToPosts.Controls.Add(txtPostContent);
			tabpToPosts.Controls.Add(dtpPostDate);
			tabpToPosts.Controls.Add(btnLoadPosts);
			tabpToPosts.Controls.Add(txtMemberHandle);
			tabpToPosts.Controls.Add(btnSavePosts);
			tabpToPosts.Controls.Add(lblMemberHandle);
			tabpToPosts.Controls.Add(chkPostType);
			tabpToPosts.Controls.Add(nddPostIndex);
			tabpToPosts.Location = new Point(4, 24);
			tabpToPosts.Name = "tabpToPosts";
			tabpToPosts.Padding = new Padding(3);
			tabpToPosts.Size = new Size(680, 700);
			tabpToPosts.TabIndex = 3;
			tabpToPosts.Text = "To Posts";
			tabpToPosts.UseVisualStyleBackColor = true;
			// 
			// monthCalendar1
			// 
			monthCalendar1.Location = new Point(441, 96);
			monthCalendar1.Name = "monthCalendar1";
			monthCalendar1.TabIndex = 31;
			monthCalendar1.DateChanged += monthCalendar1_DateChanged;
			// 
			// dgvPosts
			// 
			dgvPosts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvPosts.Location = new Point(37, 277);
			dgvPosts.Name = "dgvPosts";
			dgvPosts.RowTemplate.Height = 25;
			dgvPosts.Size = new Size(631, 365);
			dgvPosts.TabIndex = 30;
			dgvPosts.CellContentClick += dgvPosts_CellContentClick;
			// 
			// btnSavePosts
			// 
			btnSavePosts.AutoSize = true;
			btnSavePosts.Location = new Point(547, 660);
			btnSavePosts.Name = "btnSavePosts";
			btnSavePosts.Size = new Size(121, 25);
			btnSavePosts.TabIndex = 29;
			btnSavePosts.Text = "Save Posts";
			btnSavePosts.UseVisualStyleBackColor = true;
			btnSavePosts.Click += btnSavePosts_Click;
			// 
			// tabpAudioSettings
			// 
			tabpAudioSettings.Controls.Add(grpSynth);
			tabpAudioSettings.Location = new Point(4, 24);
			tabpAudioSettings.Name = "tabpAudioSettings";
			tabpAudioSettings.Size = new Size(680, 700);
			tabpAudioSettings.TabIndex = 4;
			tabpAudioSettings.Text = "Audio Settings";
			tabpAudioSettings.UseVisualStyleBackColor = true;
			// 
			// fileSystemWatcher1
			// 
			fileSystemWatcher1.EnableRaisingEvents = true;
			fileSystemWatcher1.SynchronizingObject = this;
			// 
			// tooltTransitions
			// 
			tooltTransitions.ToolTipIcon = ToolTipIcon.Info;
			tooltTransitions.ToolTipTitle = "Transition Help";
			tooltTransitions.Popup += tooltTransitions_Popup;
			// 
			// tabpPackage
			// 
			tabpPackage.Controls.Add(btnSaveAllPacked);
			tabpPackage.Location = new Point(4, 24);
			tabpPackage.Name = "tabpPackage";
			tabpPackage.Padding = new Padding(3);
			tabpPackage.Size = new Size(680, 700);
			tabpPackage.TabIndex = 5;
			tabpPackage.Text = "Package";
			tabpPackage.UseVisualStyleBackColor = true;
			// 
			// btnSaveAllPacked
			// 
			btnSaveAllPacked.AutoSize = true;
			btnSaveAllPacked.Location = new Point(427, 66);
			btnSaveAllPacked.Name = "btnSaveAllPacked";
			btnSaveAllPacked.Size = new Size(156, 25);
			btnSaveAllPacked.TabIndex = 1;
			btnSaveAllPacked.Text = "Save All";
			btnSaveAllPacked.UseVisualStyleBackColor = true;
			btnSaveAllPacked.Click += btnSaveAllPacked_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.RoyalBlue;
			ClientSize = new Size(744, 770);
			Controls.Add(tabControl1);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			grpAdjustments.ResumeLayout(false);
			grpAdjustments.PerformLayout();
			((System.ComponentModel.ISupportInitialize)TrackBar2).EndInit();
			((System.ComponentModel.ISupportInitialize)TrackBar1).EndInit();
			grpDataset.ResumeLayout(false);
			grpDataset.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dgvFilteredRows).EndInit();
			((System.ComponentModel.ISupportInitialize)nddPostIndex).EndInit();
			((System.ComponentModel.ISupportInitialize)dgvChatroomTextLines).EndInit();
			grpSynth.ResumeLayout(false);
			grpSynth.PerformLayout();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)bdsLines).EndInit();
			tabControl1.ResumeLayout(false);
			tabpLoadInputText.ResumeLayout(false);
			tabpToLines.ResumeLayout(false);
			tabpToLines.PerformLayout();
			tabpToFilteredRows.ResumeLayout(false);
			tabpToPosts.ResumeLayout(false);
			tabpToPosts.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dgvPosts).EndInit();
			tabpAudioSettings.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
			tabpPackage.ResumeLayout(false);
			tabpPackage.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TextBox txtTextToSpeak;
		private GroupBox grpAdjustments;
		private ComboBox ddlVoices;
		private TrackBar TrackBar2;
		private TrackBar TrackBar1;
		private Label lblVolume;
		private Label lblRate;
		private Button BtnSpeak;
		private CheckBox chkRecord;
		private TextBox txtToWaveFile;
		private Label lblVoice;
		private GroupBox grpDataset;
		private DateTimePicker dtpPostDate;
		private DataGridView dgvChatroomTextLines;
		private TextBox txtMemberHandle;
		private CheckedListBox chkPostType;
		private NumericUpDown nddPostIndex;
		private TextBox txtPostContent;
		private Label lblMemberHandle;
		private Button btnNewPost;
		private GroupBox grpSynth;
		private FolderBrowserDialog fbdInputFolder;
		private OpenFileDialog ofdOpenFileDialogue;
		private GroupBox groupBox1;
		private Button btnOpenFile;
		private TextBox txtWhatsAppFile;
		private TextBox txtFilePath;
		private Label lblFilePath;
		private OpenFileDialog openFileDialog1;
		private Button btnToRows;
		private Label label1;
		private BindingSource bdsLines;
		private Button btnFilterRows;
		private Button btnLoadPosts;
		private TabControl tabControl1;
		private TabPage tabpLoadInputText;
		private TabPage tabpToLines;
		private TabPage tabpToFilteredRows;
		private Button btnSavePosts;
		private Button bbtnSaveFilteredRows;
		private Button btnSaveLines;
		private TabPage tabpToPosts;
		private TabPage tabpAudioSettings;
		private DataGridView dgvFilteredRows;
		private DataGridView dgvPosts;
		private HelpProvider helpProvider1;
		private FileSystemWatcher fileSystemWatcher1;
		private FolderBrowserDialog folderBrowserDialog1;
		private PageSetupDialog pageSetupDialog1;
		private SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.Timer timer1;
		private ToolTip tooltTransitions;
		private MonthCalendar monthCalendar1;
		private TabPage tabpPackage;
		private Button btnSaveAllPacked;
	}
}