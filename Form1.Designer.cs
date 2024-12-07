namespace Music
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        /// 
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnRemoveSong = new System.Windows.Forms.Button();
            this.txtbSong = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnRemoveSong);
            this.splitContainer1.Panel1.Controls.Add(this.listBox1);
            this.splitContainer1.Panel1.Controls.Add(this.btnAdd);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 154;
            this.splitContainer1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(154, 405);
            this.listBox1.TabIndex = 1;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAdd.Location = new System.Drawing.Point(0, 405);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(154, 45);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.axWindowsMediaPlayer1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btnSearch);
            this.splitContainer2.Panel2.Controls.Add(this.txtbSong);
            this.splitContainer2.Panel2.Controls.Add(this.btnNext);
            this.splitContainer2.Panel2.Controls.Add(this.btnPrevious);
            this.splitContainer2.Panel2.Controls.Add(this.btnPlay);
            this.splitContainer2.Panel2.Controls.Add(this.btnRandom);
            this.splitContainer2.Size = new System.Drawing.Size(642, 450);
            this.splitContainer2.SplitterDistance = 303;
            this.splitContainer2.TabIndex = 6;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(642, 303);
            this.axWindowsMediaPlayer1.TabIndex = 1;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(241, -1);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(134, 53);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(0, -1);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(129, 53);
            this.btnPrevious.TabIndex = 3;
            this.btnPrevious.Text = "Prev";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackgroundImage = global::Music.Properties.Resources.playIcon;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPlay.Location = new System.Drawing.Point(125, -1);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(119, 53);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(371, -1);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(147, 53);
            this.btnRandom.TabIndex = 5;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnRemoveSong
            // 
            this.btnRemoveSong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRemoveSong.Location = new System.Drawing.Point(0, 358);
            this.btnRemoveSong.Name = "btnRemoveSong";
            this.btnRemoveSong.Size = new System.Drawing.Size(154, 47);
            this.btnRemoveSong.TabIndex = 2;
            this.btnRemoveSong.Text = "Remove";
            this.btnRemoveSong.UseVisualStyleBackColor = true;
            this.btnRemoveSong.Click += new System.EventHandler(this.btnRemoveSong_Click);
            // 
            // txtbSong
            // 
            this.txtbSong.Location = new System.Drawing.Point(15, 59);
            this.txtbSong.Name = "txtbSong";
            this.txtbSong.Size = new System.Drawing.Size(229, 26);
            this.txtbSong.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(266, 61);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 24);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button btnRemoveSong;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtbSong;
    }
}

