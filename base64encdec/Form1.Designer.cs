namespace base64encdec
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnEncode = new System.Windows.Forms.Button();
            this.btnDecode = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMnuPicture = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxClose = new System.Windows.Forms.ToolStripMenuItem();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnViewImageFile = new System.Windows.Forms.Button();
            this.btnEncodeFromFile = new System.Windows.Forms.Button();
            this.btnDecodeToFile = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMnuPicture.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Tip";
            // 
            // btnEncode
            // 
            this.btnEncode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEncode.AutoSize = true;
            this.btnEncode.BackColor = System.Drawing.Color.DimGray;
            this.btnEncode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncode.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncode.ForeColor = System.Drawing.Color.White;
            this.btnEncode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEncode.Location = new System.Drawing.Point(18, 344);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(109, 32);
            this.btnEncode.TabIndex = 1;
            this.btnEncode.Text = "&Encode";
            this.btnEncode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnEncode, "Click here to Encode displayed Text to Base64 data");
            this.btnEncode.UseVisualStyleBackColor = false;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // btnDecode
            // 
            this.btnDecode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDecode.BackColor = System.Drawing.Color.DimGray;
            this.btnDecode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecode.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecode.ForeColor = System.Drawing.Color.White;
            this.btnDecode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDecode.Location = new System.Drawing.Point(18, 381);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(109, 32);
            this.btnDecode.TabIndex = 3;
            this.btnDecode.Text = "&Decode";
            this.btnDecode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnDecode, "Click here to Decode displayed Base64 data");
            this.btnDecode.UseVisualStyleBackColor = false;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.ContextMenuStrip = this.contextMnuPicture;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(658, 328);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // contextMnuPicture
            // 
            this.contextMnuPicture.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxClose});
            this.contextMnuPicture.Name = "contextMenuStrip1";
            this.contextMnuPicture.Size = new System.Drawing.Size(140, 26);
            // 
            // ctxClose
            // 
            this.ctxClose.Name = "ctxClose";
            this.ctxClose.Size = new System.Drawing.Size(139, 22);
            this.ctxClose.Text = "Close &Image";
            this.ctxClose.Click += new System.EventHandler(this.ctxClose_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInfo.BackColor = System.Drawing.Color.DimGray;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.ForeColor = System.Drawing.Color.White;
            this.btnInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfo.Location = new System.Drawing.Point(554, 344);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(92, 32);
            this.btnInfo.TabIndex = 7;
            this.btnInfo.Text = "Abou&t";
            this.btnInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnViewImageFile
            // 
            this.btnViewImageFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewImageFile.BackColor = System.Drawing.Color.DimGray;
            this.btnViewImageFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewImageFile.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewImageFile.ForeColor = System.Drawing.Color.White;
            this.btnViewImageFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewImageFile.Location = new System.Drawing.Point(331, 344);
            this.btnViewImageFile.Name = "btnViewImageFile";
            this.btnViewImageFile.Padding = new System.Windows.Forms.Padding(3);
            this.btnViewImageFile.Size = new System.Drawing.Size(130, 68);
            this.btnViewImageFile.TabIndex = 5;
            this.btnViewImageFile.Text = "&View Image";
            this.btnViewImageFile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnViewImageFile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnViewImageFile.UseVisualStyleBackColor = false;
            this.btnViewImageFile.Click += new System.EventHandler(this.btnViewImageFile_Click);
            // 
            // btnEncodeFromFile
            // 
            this.btnEncodeFromFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEncodeFromFile.BackColor = System.Drawing.Color.DimGray;
            this.btnEncodeFromFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncodeFromFile.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncodeFromFile.ForeColor = System.Drawing.Color.White;
            this.btnEncodeFromFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEncodeFromFile.Location = new System.Drawing.Point(133, 344);
            this.btnEncodeFromFile.Name = "btnEncodeFromFile";
            this.btnEncodeFromFile.Size = new System.Drawing.Size(192, 32);
            this.btnEncodeFromFile.TabIndex = 2;
            this.btnEncodeFromFile.Text = "Encode From File";
            this.btnEncodeFromFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEncodeFromFile.UseVisualStyleBackColor = false;
            this.btnEncodeFromFile.Click += new System.EventHandler(this.btnEncodeFromFile_Click);
            // 
            // btnDecodeToFile
            // 
            this.btnDecodeToFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDecodeToFile.BackColor = System.Drawing.Color.DimGray;
            this.btnDecodeToFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecodeToFile.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecodeToFile.ForeColor = System.Drawing.Color.White;
            this.btnDecodeToFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDecodeToFile.Location = new System.Drawing.Point(133, 381);
            this.btnDecodeToFile.Name = "btnDecodeToFile";
            this.btnDecodeToFile.Size = new System.Drawing.Size(192, 31);
            this.btnDecodeToFile.TabIndex = 4;
            this.btnDecodeToFile.Text = "Decode To File";
            this.btnDecodeToFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDecodeToFile.UseVisualStyleBackColor = false;
            this.btnDecodeToFile.Click += new System.EventHandler(this.btnDecodeToFile_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHelp.BackColor = System.Drawing.Color.DimGray;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.Location = new System.Drawing.Point(467, 344);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(81, 32);
            this.btnHelp.TabIndex = 6;
            this.btnHelp.Text = "&Help";
            this.btnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox1.ShowSelectionMargin = true;
            this.richTextBox1.Size = new System.Drawing.Size(658, 328);
            this.richTextBox1.TabIndex = 17;
            this.richTextBox1.Text = "Test string";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(628, 65);
            this.label1.TabIndex = 20;
            this.label1.Text = " #";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuit.BackColor = System.Drawing.Color.DimGray;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.Color.White;
            this.btnQuit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuit.Location = new System.Drawing.Point(554, 381);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(92, 32);
            this.btnQuit.TabIndex = 21;
            this.btnQuit.Text = "&Quit";
            this.btnQuit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.DimGray;
            this.btnCancel.Enabled = false;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(467, 381);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(81, 32);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(658, 490);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnViewImageFile);
            this.Controls.Add(this.btnEncodeFromFile);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDecodeToFile);
            this.Controls.Add(this.btnEncode);
            this.Controls.Add(this.btnDecode);
            this.Name = "Form1";
            this.Text = "Base64 Encoder / Decoder";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMnuPicture.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDecodeToFile;
        private System.Windows.Forms.Button btnEncodeFromFile;
        private System.Windows.Forms.ContextMenuStrip contextMnuPicture;
        private System.Windows.Forms.ToolStripMenuItem ctxClose;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnHelp;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Button btnViewImageFile;
        internal System.Windows.Forms.ToolTip toolTip1;
        internal System.Windows.Forms.RichTextBox richTextBox1;
    }
}

