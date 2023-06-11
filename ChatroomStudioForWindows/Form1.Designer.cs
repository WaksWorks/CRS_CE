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
			this.components = new System.ComponentModel.Container();
			this.txtTextToSpeak = new System.Windows.Forms.TextBox();
			this.grpAdjustments = new System.Windows.Forms.GroupBox();
			this.TrackBar2 = new System.Windows.Forms.TrackBar();
			this.TrackBar1 = new System.Windows.Forms.TrackBar();
			this.lblVolume = new System.Windows.Forms.Label();
			this.lblRate = new System.Windows.Forms.Label();
			this.ddlVoices = new System.Windows.Forms.ComboBox();
			this.BtnSpeak = new System.Windows.Forms.Button();
			this.chkRecord = new System.Windows.Forms.CheckBox();
			this.txtToWaveFile = new System.Windows.Forms.TextBox();
			this.lblVoice = new System.Windows.Forms.Label();
			this.grpDataset = new System.Windows.Forms.GroupBox();
			this.mcPostDateRange = new System.Windows.Forms.MonthCalendar();
			this.btnToRows = new System.Windows.Forms.Button();
			this.txtMemberHandle = new System.Windows.Forms.TextBox();
			this.lblRows = new System.Windows.Forms.Label();
			this.chkPostType = new System.Windows.Forms.CheckedListBox();
			this.nddPostIndex = new System.Windows.Forms.NumericUpDown();
			this.txtPostContent = new System.Windows.Forms.TextBox();
			this.lblMemberHandle = new System.Windows.Forms.Label();
			this.dtpPostDate = new System.Windows.Forms.DateTimePicker();
			this.dgvChatroomTextLines = new System.Windows.Forms.DataGridView();
			this.btnNewPost = new System.Windows.Forms.Button();
			this.grpSynth = new System.Windows.Forms.GroupBox();
			this.fbdInputFolder = new System.Windows.Forms.FolderBrowserDialog();
			this.ofdOpenFileDialogue = new System.Windows.Forms.OpenFileDialog();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtFilePath = new System.Windows.Forms.TextBox();
			this.lblFilePath = new System.Windows.Forms.Label();
			this.txtWhatsAppFile = new System.Windows.Forms.TextBox();
			this.btnOpenFile = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.bdsLines = new System.Windows.Forms.BindingSource(this.components);
			this.grpAdjustments.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.TrackBar2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TrackBar1)).BeginInit();
			this.grpDataset.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nddPostIndex)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvChatroomTextLines)).BeginInit();
			this.grpSynth.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bdsLines)).BeginInit();
			this.SuspendLayout();
			// 
			// txtTextToSpeak
			// 
			this.txtTextToSpeak.Location = new System.Drawing.Point(6, 44);
			this.txtTextToSpeak.Multiline = true;
			this.txtTextToSpeak.Name = "txtTextToSpeak";
			this.txtTextToSpeak.Size = new System.Drawing.Size(542, 66);
			this.txtTextToSpeak.TabIndex = 12;
			this.txtTextToSpeak.Text = "WaksWorks presents Chatroom Studio Editor for windows";
			// 
			// grpAdjustments
			// 
			this.grpAdjustments.BackColor = System.Drawing.SystemColors.ControlLight;
			this.grpAdjustments.Controls.Add(this.TrackBar2);
			this.grpAdjustments.Controls.Add(this.TrackBar1);
			this.grpAdjustments.Controls.Add(this.lblVolume);
			this.grpAdjustments.Controls.Add(this.lblRate);
			this.grpAdjustments.Location = new System.Drawing.Point(7, 147);
			this.grpAdjustments.Name = "grpAdjustments";
			this.grpAdjustments.Size = new System.Drawing.Size(541, 163);
			this.grpAdjustments.TabIndex = 11;
			this.grpAdjustments.TabStop = false;
			this.grpAdjustments.Text = "Adjustments";
			this.grpAdjustments.Enter += new System.EventHandler(this.grpAdjustments_Enter);
			// 
			// TrackBar2
			// 
			this.TrackBar2.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.TrackBar2.Location = new System.Drawing.Point(-1, 91);
			this.TrackBar2.Name = "TrackBar2";
			this.TrackBar2.Size = new System.Drawing.Size(340, 45);
			this.TrackBar2.TabIndex = 6;
			this.TrackBar2.Scroll += new System.EventHandler(this.TrackBar2_Scroll_1);
			this.TrackBar2.ValueChanged += new System.EventHandler(this.TrackBar2ValueChanged);
			// 
			// TrackBar1
			// 
			this.TrackBar1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.TrackBar1.Location = new System.Drawing.Point(-1, 25);
			this.TrackBar1.Name = "TrackBar1";
			this.TrackBar1.Size = new System.Drawing.Size(340, 45);
			this.TrackBar1.TabIndex = 5;
			this.TrackBar1.ValueChanged += new System.EventHandler(this.TrackBar1ValueChanged);
			// 
			// lblVolume
			// 
			this.lblVolume.AutoSize = true;
			this.lblVolume.Location = new System.Drawing.Point(356, 91);
			this.lblVolume.Name = "lblVolume";
			this.lblVolume.Size = new System.Drawing.Size(47, 15);
			this.lblVolume.TabIndex = 9;
			this.lblVolume.Text = "Volume";
			// 
			// lblRate
			// 
			this.lblRate.AutoSize = true;
			this.lblRate.Location = new System.Drawing.Point(356, 25);
			this.lblRate.Name = "lblRate";
			this.lblRate.Size = new System.Drawing.Size(30, 15);
			this.lblRate.TabIndex = 10;
			this.lblRate.Text = "Rate";
			// 
			// ddlVoices
			// 
			this.ddlVoices.FormattingEnabled = true;
			this.ddlVoices.Location = new System.Drawing.Point(322, 15);
			this.ddlVoices.Name = "ddlVoices";
			this.ddlVoices.Size = new System.Drawing.Size(226, 23);
			this.ddlVoices.TabIndex = 7;
			// 
			// BtnSpeak
			// 
			this.BtnSpeak.AutoSize = true;
			this.BtnSpeak.BackColor = System.Drawing.SystemColors.Control;
			this.BtnSpeak.Location = new System.Drawing.Point(7, 118);
			this.BtnSpeak.Name = "BtnSpeak";
			this.BtnSpeak.Size = new System.Drawing.Size(75, 25);
			this.BtnSpeak.TabIndex = 0;
			this.BtnSpeak.Text = "Speak";
			this.BtnSpeak.UseVisualStyleBackColor = false;
			this.BtnSpeak.Click += new System.EventHandler(this.BtnSpeakClick);
			// 
			// chkRecord
			// 
			this.chkRecord.AutoSize = true;
			this.chkRecord.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.chkRecord.Location = new System.Drawing.Point(432, 119);
			this.chkRecord.Name = "chkRecord";
			this.chkRecord.Size = new System.Drawing.Size(116, 19);
			this.chkRecord.TabIndex = 13;
			this.chkRecord.Text = "Record Wave File";
			this.chkRecord.UseVisualStyleBackColor = false;
			// 
			// txtToWaveFile
			// 
			this.txtToWaveFile.Location = new System.Drawing.Point(183, 119);
			this.txtToWaveFile.Name = "txtToWaveFile";
			this.txtToWaveFile.Size = new System.Drawing.Size(233, 23);
			this.txtToWaveFile.TabIndex = 14;
			this.txtToWaveFile.Text = "SampleWave.wav";
			// 
			// lblVoice
			// 
			this.lblVoice.AutoSize = true;
			this.lblVoice.Location = new System.Drawing.Point(281, -7);
			this.lblVoice.Name = "lblVoice";
			this.lblVoice.Size = new System.Drawing.Size(35, 15);
			this.lblVoice.TabIndex = 15;
			this.lblVoice.Text = "Voice";
			// 
			// grpDataset
			// 
			this.grpDataset.BackColor = System.Drawing.SystemColors.ControlLight;
			this.grpDataset.Controls.Add(this.mcPostDateRange);
			this.grpDataset.Controls.Add(this.btnToRows);
			this.grpDataset.Controls.Add(this.txtMemberHandle);
			this.grpDataset.Controls.Add(this.lblRows);
			this.grpDataset.Controls.Add(this.chkPostType);
			this.grpDataset.Controls.Add(this.nddPostIndex);
			this.grpDataset.Controls.Add(this.txtPostContent);
			this.grpDataset.Controls.Add(this.lblMemberHandle);
			this.grpDataset.Controls.Add(this.dtpPostDate);
			this.grpDataset.Controls.Add(this.dgvChatroomTextLines);
			this.grpDataset.Location = new System.Drawing.Point(622, 12);
			this.grpDataset.Name = "grpDataset";
			this.grpDataset.Size = new System.Drawing.Size(588, 626);
			this.grpDataset.TabIndex = 16;
			this.grpDataset.TabStop = false;
			this.grpDataset.Text = "DataSet Group";
			// 
			// mcPostDateRange
			// 
			this.mcPostDateRange.AccessibleDescription = "Displays the range of days spanning the Chatroom Thread";
			this.mcPostDateRange.AccessibleName = "Chatroom thread of days covered in the export file; range in date from start to f" +
    "inish inclusively";
			this.mcPostDateRange.Location = new System.Drawing.Point(22, 436);
			this.mcPostDateRange.Name = "mcPostDateRange";
			this.mcPostDateRange.TabIndex = 22;
			// 
			// btnToRows
			// 
			this.btnToRows.AutoSize = true;
			this.btnToRows.Location = new System.Drawing.Point(401, 436);
			this.btnToRows.Name = "btnToRows";
			this.btnToRows.Size = new System.Drawing.Size(181, 25);
			this.btnToRows.TabIndex = 24;
			this.btnToRows.Text = "Load Rows";
			this.btnToRows.UseVisualStyleBackColor = true;
			this.btnToRows.Click += new System.EventHandler(this.btnToRows_Click);
			// 
			// txtMemberHandle
			// 
			this.txtMemberHandle.Location = new System.Drawing.Point(228, 50);
			this.txtMemberHandle.Name = "txtMemberHandle";
			this.txtMemberHandle.Size = new System.Drawing.Size(213, 23);
			this.txtMemberHandle.TabIndex = 21;
			this.txtMemberHandle.Text = "memberHandle_sadamski";
			// 
			// lblRows
			// 
			this.lblRows.AutoSize = true;
			this.lblRows.Location = new System.Drawing.Point(22, 275);
			this.lblRows.Name = "lblRows";
			this.lblRows.Size = new System.Drawing.Size(51, 15);
			this.lblRows.TabIndex = 20;
			this.lblRows.Text = "Row List";
			// 
			// chkPostType
			// 
			this.chkPostType.FormattingEnabled = true;
			this.chkPostType.Location = new System.Drawing.Point(22, 80);
			this.chkPostType.Name = "chkPostType";
			this.chkPostType.Size = new System.Drawing.Size(120, 166);
			this.chkPostType.TabIndex = 19;
			// 
			// nddPostIndex
			// 
			this.nddPostIndex.Location = new System.Drawing.Point(462, 51);
			this.nddPostIndex.Name = "nddPostIndex";
			this.nddPostIndex.Size = new System.Drawing.Size(120, 23);
			this.nddPostIndex.TabIndex = 18;
			// 
			// txtPostContent
			// 
			this.txtPostContent.Location = new System.Drawing.Point(163, 80);
			this.txtPostContent.Multiline = true;
			this.txtPostContent.Name = "txtPostContent";
			this.txtPostContent.Size = new System.Drawing.Size(419, 166);
			this.txtPostContent.TabIndex = 16;
			this.txtPostContent.Text = "WaksWorks presents Chatroom Studio Editor for windows";
			// 
			// lblMemberHandle
			// 
			this.lblMemberHandle.AutoSize = true;
			this.lblMemberHandle.Location = new System.Drawing.Point(228, 29);
			this.lblMemberHandle.Name = "lblMemberHandle";
			this.lblMemberHandle.Size = new System.Drawing.Size(90, 15);
			this.lblMemberHandle.TabIndex = 15;
			this.lblMemberHandle.Text = "MemberHandle";
			// 
			// dtpPostDate
			// 
			this.dtpPostDate.Location = new System.Drawing.Point(22, 51);
			this.dtpPostDate.Name = "dtpPostDate";
			this.dtpPostDate.Size = new System.Drawing.Size(200, 23);
			this.dtpPostDate.TabIndex = 14;
			// 
			// dgvChatroomTextLines
			// 
			this.dgvChatroomTextLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvChatroomTextLines.Location = new System.Drawing.Point(22, 261);
			this.dgvChatroomTextLines.Name = "dgvChatroomTextLines";
			this.dgvChatroomTextLines.RowTemplate.Height = 25;
			this.dgvChatroomTextLines.Size = new System.Drawing.Size(560, 163);
			this.dgvChatroomTextLines.TabIndex = 12;
			this.dgvChatroomTextLines.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbgRows_CellContentClick);
			// 
			// btnNewPost
			// 
			this.btnNewPost.BackColor = System.Drawing.SystemColors.Control;
			this.btnNewPost.Location = new System.Drawing.Point(102, 119);
			this.btnNewPost.Name = "btnNewPost";
			this.btnNewPost.Size = new System.Drawing.Size(75, 23);
			this.btnNewPost.TabIndex = 20;
			this.btnNewPost.Text = "Create New Post";
			this.btnNewPost.UseVisualStyleBackColor = false;
			// 
			// grpSynth
			// 
			this.grpSynth.BackColor = System.Drawing.SystemColors.Control;
			this.grpSynth.Controls.Add(this.txtTextToSpeak);
			this.grpSynth.Controls.Add(this.btnNewPost);
			this.grpSynth.Controls.Add(this.grpAdjustments);
			this.grpSynth.Controls.Add(this.BtnSpeak);
			this.grpSynth.Controls.Add(this.lblVoice);
			this.grpSynth.Controls.Add(this.chkRecord);
			this.grpSynth.Controls.Add(this.ddlVoices);
			this.grpSynth.Controls.Add(this.txtToWaveFile);
			this.grpSynth.ForeColor = System.Drawing.SystemColors.ActiveBorder;
			this.grpSynth.Location = new System.Drawing.Point(12, 12);
			this.grpSynth.Name = "grpSynth";
			this.grpSynth.Size = new System.Drawing.Size(579, 319);
			this.grpSynth.TabIndex = 21;
			this.grpSynth.TabStop = false;
			this.grpSynth.Text = "Synthesiser Group";
			// 
			// ofdOpenFileDialogue
			// 
			this.ofdOpenFileDialogue.FileName = "WhatsApp Chat with Lenny.txt";
			this.ofdOpenFileDialogue.Filter = "WhatsApp Export File|WhatsApp Chat with *.txt|All Files|*.*";
			this.ofdOpenFileDialogue.Title = "Open WhatsApp Export File";
			this.ofdOpenFileDialogue.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdOpenFileDialogue_FileOk);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtFilePath);
			this.groupBox1.Controls.Add(this.lblFilePath);
			this.groupBox1.Controls.Add(this.txtWhatsAppFile);
			this.groupBox1.Controls.Add(this.btnOpenFile);
			this.groupBox1.Location = new System.Drawing.Point(21, 346);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(570, 352);
			this.groupBox1.TabIndex = 22;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "IO Group";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 267);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 15);
			this.label1.TabIndex = 25;
			this.label1.Text = "Text Content";
			// 
			// txtFilePath
			// 
			this.txtFilePath.Location = new System.Drawing.Point(188, 24);
			this.txtFilePath.Name = "txtFilePath";
			this.txtFilePath.Size = new System.Drawing.Size(213, 23);
			this.txtFilePath.TabIndex = 23;
			this.txtFilePath.Text = "WhatsApp Chat With _.txt";
			// 
			// lblFilePath
			// 
			this.lblFilePath.AutoSize = true;
			this.lblFilePath.Location = new System.Drawing.Point(407, 27);
			this.lblFilePath.Name = "lblFilePath";
			this.lblFilePath.Size = new System.Drawing.Size(52, 15);
			this.lblFilePath.TabIndex = 22;
			this.lblFilePath.Text = "File Path";
			// 
			// txtWhatsAppFile
			// 
			this.txtWhatsAppFile.Location = new System.Drawing.Point(3, 54);
			this.txtWhatsAppFile.Multiline = true;
			this.txtWhatsAppFile.Name = "txtWhatsAppFile";
			this.txtWhatsAppFile.Size = new System.Drawing.Size(546, 207);
			this.txtWhatsAppFile.TabIndex = 1;
			// 
			// btnOpenFile
			// 
			this.btnOpenFile.AutoSize = true;
			this.btnOpenFile.Location = new System.Drawing.Point(6, 22);
			this.btnOpenFile.Name = "btnOpenFile";
			this.btnOpenFile.Size = new System.Drawing.Size(181, 25);
			this.btnOpenFile.TabIndex = 0;
			this.btnOpenFile.Text = "Load Text";
			this.btnOpenFile.UseVisualStyleBackColor = true;
			this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1222, 729);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.grpSynth);
			this.Controls.Add(this.grpDataset);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.grpAdjustments.ResumeLayout(false);
			this.grpAdjustments.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.TrackBar2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TrackBar1)).EndInit();
			this.grpDataset.ResumeLayout(false);
			this.grpDataset.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nddPostIndex)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvChatroomTextLines)).EndInit();
			this.grpSynth.ResumeLayout(false);
			this.grpSynth.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bdsLines)).EndInit();
			this.ResumeLayout(false);

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
        private Label lblRows;
        private CheckedListBox chkPostType;
        private NumericUpDown nddPostIndex;
        private TextBox txtPostContent;
        private Label lblMemberHandle;
        private Button btnNewPost;
        private GroupBox grpSynth;
        private MonthCalendar mcPostDateRange;
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
	}
}