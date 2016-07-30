namespace vidlooper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.vidlocationtextBox = new System.Windows.Forms.TextBox();
            this.applybutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.browsebutton = new System.Windows.Forms.Button();
            this.vidfolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.startbutton = new System.Windows.Forms.Button();
            this.autostartcheckBox = new System.Windows.Forms.CheckBox();
            this.vidlistBox = new System.Windows.Forms.ListBox();
            this.stopbutton = new System.Windows.Forms.Button();
            this.tflbutton = new System.Windows.Forms.Button();
            this.exitfulscrbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.mutecheckBox = new System.Windows.Forms.CheckBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // vidlocationtextBox
            // 
            this.vidlocationtextBox.Location = new System.Drawing.Point(12, 383);
            this.vidlocationtextBox.Name = "vidlocationtextBox";
            this.vidlocationtextBox.Size = new System.Drawing.Size(485, 20);
            this.vidlocationtextBox.TabIndex = 1;
            this.vidlocationtextBox.TextChanged += new System.EventHandler(this.vidlocationtextBox_TextChanged);
            // 
            // applybutton
            // 
            this.applybutton.Location = new System.Drawing.Point(335, 409);
            this.applybutton.Name = "applybutton";
            this.applybutton.Size = new System.Drawing.Size(68, 20);
            this.applybutton.TabIndex = 2;
            this.applybutton.Text = "Apply";
            this.applybutton.UseVisualStyleBackColor = true;
            this.applybutton.Click += new System.EventHandler(this.applybutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(12, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vid Location:";
            // 
            // browsebutton
            // 
            this.browsebutton.Location = new System.Drawing.Point(440, 357);
            this.browsebutton.Name = "browsebutton";
            this.browsebutton.Size = new System.Drawing.Size(57, 20);
            this.browsebutton.TabIndex = 4;
            this.browsebutton.Text = "browse";
            this.browsebutton.UseVisualStyleBackColor = true;
            this.browsebutton.Click += new System.EventHandler(this.browsebutton_Click);
            // 
            // cancelbutton
            // 
            this.cancelbutton.Location = new System.Drawing.Point(429, 409);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(68, 20);
            this.cancelbutton.TabIndex = 5;
            this.cancelbutton.Text = "Cancel";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 457);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(695, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Black;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(58, 17);
            this.toolStripStatusLabel1.Text = "Vidlooper";
            // 
            // startbutton
            // 
            this.startbutton.Location = new System.Drawing.Point(520, 357);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(67, 20);
            this.startbutton.TabIndex = 7;
            this.startbutton.Text = "Auto play";
            this.startbutton.UseVisualStyleBackColor = true;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // autostartcheckBox
            // 
            this.autostartcheckBox.AutoSize = true;
            this.autostartcheckBox.ForeColor = System.Drawing.Color.Red;
            this.autostartcheckBox.Location = new System.Drawing.Point(600, 395);
            this.autostartcheckBox.Name = "autostartcheckBox";
            this.autostartcheckBox.Size = new System.Drawing.Size(67, 17);
            this.autostartcheckBox.TabIndex = 8;
            this.autostartcheckBox.Text = "autostart";
            this.autostartcheckBox.UseVisualStyleBackColor = true;
            this.autostartcheckBox.CheckedChanged += new System.EventHandler(this.autostartcheckBox_CheckedChanged);
            // 
            // vidlistBox
            // 
            this.vidlistBox.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.vidlistBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.vidlistBox.BackColor = System.Drawing.Color.Black;
            this.vidlistBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vidlistBox.ForeColor = System.Drawing.Color.DarkGray;
            this.vidlistBox.FormattingEnabled = true;
            this.vidlistBox.Location = new System.Drawing.Point(444, 12);
            this.vidlistBox.Name = "vidlistBox";
            this.vidlistBox.Size = new System.Drawing.Size(236, 325);
            this.vidlistBox.TabIndex = 9;
            // 
            // stopbutton
            // 
            this.stopbutton.Location = new System.Drawing.Point(519, 383);
            this.stopbutton.Name = "stopbutton";
            this.stopbutton.Size = new System.Drawing.Size(67, 20);
            this.stopbutton.TabIndex = 10;
            this.stopbutton.Text = "Stop";
            this.stopbutton.UseVisualStyleBackColor = true;
            this.stopbutton.Click += new System.EventHandler(this.stopbutton_Click);
            // 
            // tflbutton
            // 
            this.tflbutton.Location = new System.Drawing.Point(519, 409);
            this.tflbutton.Name = "tflbutton";
            this.tflbutton.Size = new System.Drawing.Size(68, 20);
            this.tflbutton.TabIndex = 11;
            this.tflbutton.Text = "Fullsrceen";
            this.tflbutton.UseVisualStyleBackColor = true;
            this.tflbutton.Click += new System.EventHandler(this.tflbutton_Click);
            // 
            // exitfulscrbutton
            // 
            this.exitfulscrbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitfulscrbutton.Location = new System.Drawing.Point(608, 12);
            this.exitfulscrbutton.Name = "exitfulscrbutton";
            this.exitfulscrbutton.Size = new System.Drawing.Size(75, 23);
            this.exitfulscrbutton.TabIndex = 12;
            this.exitfulscrbutton.Text = "Restore";
            this.exitfulscrbutton.UseVisualStyleBackColor = true;
            this.exitfulscrbutton.Visible = false;
            this.exitfulscrbutton.Click += new System.EventHandler(this.exitfulscrbutton_Click);
            this.exitfulscrbutton.MouseEnter += new System.EventHandler(this.exitfulscrbutton_MouseEnter);
            this.exitfulscrbutton.MouseLeave += new System.EventHandler(this.exitfulscrbutton_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(570, 438);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Start playback at launch.";
            // 
            // mutecheckBox
            // 
            this.mutecheckBox.AutoSize = true;
            this.mutecheckBox.ForeColor = System.Drawing.Color.DarkGray;
            this.mutecheckBox.Location = new System.Drawing.Point(600, 372);
            this.mutecheckBox.Name = "mutecheckBox";
            this.mutecheckBox.Size = new System.Drawing.Size(78, 17);
            this.mutecheckBox.TabIndex = 14;
            this.mutecheckBox.Text = "Mute for all";
            this.mutecheckBox.UseVisualStyleBackColor = true;
            this.mutecheckBox.CheckedChanged += new System.EventHandler(this.mutecheckBox_CheckedChanged);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 12);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(426, 329);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
            this.axWindowsMediaPlayer1.DoubleClickEvent += new AxWMPLib._WMPOCXEvents_DoubleClickEventHandler(this.axWindowsMediaPlayer1_DoubleClickEvent);
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.Red;
            this.checkBox1.Location = new System.Drawing.Point(600, 418);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(87, 17);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Auto Fullscrn";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(695, 479);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.mutecheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exitfulscrbutton);
            this.Controls.Add(this.tflbutton);
            this.Controls.Add(this.stopbutton);
            this.Controls.Add(this.vidlistBox);
            this.Controls.Add(this.autostartcheckBox);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.browsebutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.applybutton);
            this.Controls.Add(this.vidlocationtextBox);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "vidlooper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.TextBox vidlocationtextBox;
        private System.Windows.Forms.Button applybutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button browsebutton;
        private System.Windows.Forms.FolderBrowserDialog vidfolderBrowserDialog;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.CheckBox autostartcheckBox;
        private System.Windows.Forms.ListBox vidlistBox;
        private System.Windows.Forms.Button stopbutton;
        private System.Windows.Forms.Button tflbutton;
        private System.Windows.Forms.Button exitfulscrbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox mutecheckBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

