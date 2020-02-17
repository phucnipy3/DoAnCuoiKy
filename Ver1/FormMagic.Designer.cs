namespace Ver1
{
    partial class FormMagic
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
            this.tabCrlMain = new System.Windows.Forms.TabControl();
            this.tabPagePlay = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHi = new System.Windows.Forms.Button();
            this.btnScore = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.ptbPlay = new System.Windows.Forms.PictureBox();
            this.ptbPickUp = new System.Windows.Forms.PictureBox();
            this.tabPageLose = new System.Windows.Forms.TabPage();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.timerPickUp = new System.Windows.Forms.Timer(this.components);
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.timerMoving = new System.Windows.Forms.Timer(this.components);
            this.tabCrlMain.SuspendLayout();
            this.tabPagePlay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPickUp)).BeginInit();
            this.tabPageLose.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCrlMain
            // 
            this.tabCrlMain.Controls.Add(this.tabPagePlay);
            this.tabCrlMain.Controls.Add(this.tabPageLose);
            this.tabCrlMain.Location = new System.Drawing.Point(-3, -22);
            this.tabCrlMain.Name = "tabCrlMain";
            this.tabCrlMain.SelectedIndex = 0;
            this.tabCrlMain.Size = new System.Drawing.Size(434, 651);
            this.tabCrlMain.TabIndex = 0;
            // 
            // tabPagePlay
            // 
            this.tabPagePlay.BackColor = System.Drawing.Color.Transparent;
            this.tabPagePlay.BackgroundImage = global::Ver1.Properties.Resources.backgroundMagic;
            this.tabPagePlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPagePlay.Controls.Add(this.pictureBox1);
            this.tabPagePlay.Controls.Add(this.btnHi);
            this.tabPagePlay.Controls.Add(this.btnScore);
            this.tabPagePlay.Controls.Add(this.btnPause);
            this.tabPagePlay.Controls.Add(this.ptbPlay);
            this.tabPagePlay.Controls.Add(this.ptbPickUp);
            this.tabPagePlay.Location = new System.Drawing.Point(4, 22);
            this.tabPagePlay.Name = "tabPagePlay";
            this.tabPagePlay.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePlay.Size = new System.Drawing.Size(426, 625);
            this.tabPagePlay.TabIndex = 0;
            this.tabPagePlay.Text = "tabPagePlay";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Ver1.Properties.Resources.Cup;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(13, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 41);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnHi
            // 
            this.btnHi.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnHi.Font = new System.Drawing.Font("Script MT Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHi.ForeColor = System.Drawing.Color.Gold;
            this.btnHi.Location = new System.Drawing.Point(49, 15);
            this.btnHi.Name = "btnHi";
            this.btnHi.Size = new System.Drawing.Size(100, 40);
            this.btnHi.TabIndex = 0;
            this.btnHi.Text = "0";
            this.btnHi.UseVisualStyleBackColor = false;
            // 
            // btnScore
            // 
            this.btnScore.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnScore.Font = new System.Drawing.Font("Script MT Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScore.ForeColor = System.Drawing.Color.Gold;
            this.btnScore.Location = new System.Drawing.Point(161, 15);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(120, 40);
            this.btnScore.TabIndex = 0;
            this.btnScore.Text = "0";
            this.btnScore.UseVisualStyleBackColor = false;
            // 
            // btnPause
            // 
            this.btnPause.BackgroundImage = global::Ver1.Properties.Resources.pauseMagic;
            this.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPause.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPause.Location = new System.Drawing.Point(292, 16);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(120, 40);
            this.btnPause.TabIndex = 0;
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // ptbPlay
            // 
            this.ptbPlay.BackColor = System.Drawing.SystemColors.Control;
            this.ptbPlay.Location = new System.Drawing.Point(10, 70);
            this.ptbPlay.Name = "ptbPlay";
            this.ptbPlay.Size = new System.Drawing.Size(400, 400);
            this.ptbPlay.TabIndex = 0;
            this.ptbPlay.TabStop = false;
            // 
            // ptbPickUp
            // 
            this.ptbPickUp.BackColor = System.Drawing.Color.Transparent;
            this.ptbPickUp.Location = new System.Drawing.Point(24, 498);
            this.ptbPickUp.Name = "ptbPickUp";
            this.ptbPickUp.Size = new System.Drawing.Size(380, 100);
            this.ptbPickUp.TabIndex = 0;
            this.ptbPickUp.TabStop = false;
            this.ptbPickUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ptbPickUp_MouseDown);
            this.ptbPickUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ptbPickUp_MouseUp);
            // 
            // tabPageLose
            // 
            this.tabPageLose.Controls.Add(this.lblGameOver);
            this.tabPageLose.Location = new System.Drawing.Point(4, 22);
            this.tabPageLose.Name = "tabPageLose";
            this.tabPageLose.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLose.Size = new System.Drawing.Size(426, 625);
            this.tabPageLose.TabIndex = 1;
            this.tabPageLose.Text = "tabPage2";
            this.tabPageLose.UseVisualStyleBackColor = true;
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.Location = new System.Drawing.Point(69, 46);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(306, 54);
            this.lblGameOver.TabIndex = 0;
            this.lblGameOver.Text = "GAME OVER";
            // 
            // timerPickUp
            // 
            this.timerPickUp.Interval = 10;
            this.timerPickUp.Tick += new System.EventHandler(this.timerPickUp_Tick);
            // 
            // timerGame
            // 
            this.timerGame.Enabled = true;
            this.timerGame.Interval = 1;
            this.timerGame.Tick += new System.EventHandler(this.timerGame_Tick);
            // 
            // timerMoving
            // 
            this.timerMoving.Interval = 1;
            this.timerMoving.Tick += new System.EventHandler(this.timerMoving_Tick);
            // 
            // FormMagic
            // 
            this.AcceptButton = this.btnPause;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnPause;
            this.ClientSize = new System.Drawing.Size(423, 620);
            this.ControlBox = false;
            this.Controls.Add(this.tabCrlMain);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximumSize = new System.Drawing.Size(443, 663);
            this.MinimumSize = new System.Drawing.Size(443, 663);
            this.Name = "FormMagic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Magic Square";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMagic_FormClosed);
            this.Load += new System.EventHandler(this.FormMagic_Load);
            this.tabCrlMain.ResumeLayout(false);
            this.tabPagePlay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPickUp)).EndInit();
            this.tabPageLose.ResumeLayout(false);
            this.tabPageLose.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCrlMain;
        private System.Windows.Forms.TabPage tabPagePlay;
        private System.Windows.Forms.Button btnHi;
        private System.Windows.Forms.Button btnScore;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.TabPage tabPageLose;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.PictureBox ptbPlay;
        private System.Windows.Forms.PictureBox ptbPickUp;
        private System.Windows.Forms.Timer timerPickUp;
        private System.Windows.Forms.Timer timerGame;
        private System.Windows.Forms.Timer timerMoving;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}