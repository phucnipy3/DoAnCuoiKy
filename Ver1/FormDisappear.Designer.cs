namespace Ver1
{
    partial class FormDisappear
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDisappear));
            this.lblTxtScore = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblTextHi = new System.Windows.Forms.Label();
            this.lblHi = new System.Windows.Forms.Label();
            this.btnLife3 = new System.Windows.Forms.Button();
            this.btnLife2 = new System.Windows.Forms.Button();
            this.btnLife1 = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.ptbPlay = new System.Windows.Forms.PictureBox();
            this.timerCreate = new System.Windows.Forms.Timer(this.components);
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.timerHarder = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ptbPlay)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTxtScore
            // 
            this.lblTxtScore.AutoSize = true;
            this.lblTxtScore.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxtScore.Location = new System.Drawing.Point(33, 18);
            this.lblTxtScore.Name = "lblTxtScore";
            this.lblTxtScore.Size = new System.Drawing.Size(78, 33);
            this.lblTxtScore.TabIndex = 0;
            this.lblTxtScore.Text = "Score: ";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Script MT Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(98, 22);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(23, 25);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "0";
            // 
            // lblTextHi
            // 
            this.lblTextHi.AutoSize = true;
            this.lblTextHi.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextHi.Location = new System.Drawing.Point(487, 18);
            this.lblTextHi.Name = "lblTextHi";
            this.lblTextHi.Size = new System.Drawing.Size(46, 33);
            this.lblTextHi.TabIndex = 0;
            this.lblTextHi.Text = "Hi:";
            // 
            // lblHi
            // 
            this.lblHi.AutoSize = true;
            this.lblHi.Font = new System.Drawing.Font("Script MT Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHi.Location = new System.Drawing.Point(530, 22);
            this.lblHi.Name = "lblHi";
            this.lblHi.Size = new System.Drawing.Size(23, 25);
            this.lblHi.TabIndex = 1;
            this.lblHi.Text = "0";
            // 
            // btnLife3
            // 
            this.btnLife3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLife3.BackgroundImage")));
            this.btnLife3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLife3.FlatAppearance.BorderSize = 0;
            this.btnLife3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLife3.Location = new System.Drawing.Point(340, 12);
            this.btnLife3.Name = "btnLife3";
            this.btnLife3.Size = new System.Drawing.Size(35, 31);
            this.btnLife3.TabIndex = 2;
            this.btnLife3.UseVisualStyleBackColor = true;
            // 
            // btnLife2
            // 
            this.btnLife2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLife2.BackgroundImage")));
            this.btnLife2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLife2.FlatAppearance.BorderSize = 0;
            this.btnLife2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLife2.Location = new System.Drawing.Point(289, 12);
            this.btnLife2.Name = "btnLife2";
            this.btnLife2.Size = new System.Drawing.Size(35, 31);
            this.btnLife2.TabIndex = 2;
            this.btnLife2.UseVisualStyleBackColor = true;
            // 
            // btnLife1
            // 
            this.btnLife1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLife1.BackgroundImage")));
            this.btnLife1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLife1.FlatAppearance.BorderSize = 0;
            this.btnLife1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLife1.Location = new System.Drawing.Point(240, 12);
            this.btnLife1.Name = "btnLife1";
            this.btnLife1.Size = new System.Drawing.Size(35, 31);
            this.btnLife1.TabIndex = 2;
            this.btnLife1.UseVisualStyleBackColor = true;
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.Transparent;
            this.btnPause.BackgroundImage = global::Ver1.Properties.Resources.Pause;
            this.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPause.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPause.FlatAppearance.BorderSize = 0;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Location = new System.Drawing.Point(685, 15);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(35, 31);
            this.btnPause.TabIndex = 2;
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // ptbPlay
            // 
            this.ptbPlay.BackColor = System.Drawing.SystemColors.Control;
            this.ptbPlay.Location = new System.Drawing.Point(28, 62);
            this.ptbPlay.Name = "ptbPlay";
            this.ptbPlay.Size = new System.Drawing.Size(692, 297);
            this.ptbPlay.TabIndex = 3;
            this.ptbPlay.TabStop = false;
            this.ptbPlay.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ptbPlay_MouseClick);
            // 
            // timerCreate
            // 
            this.timerCreate.Enabled = true;
            this.timerCreate.Interval = 1000;
            this.timerCreate.Tick += new System.EventHandler(this.timerCreate_Tick);
            // 
            // timerGame
            // 
            this.timerGame.Enabled = true;
            this.timerGame.Tick += new System.EventHandler(this.timerGame_Tick);
            // 
            // timerHarder
            // 
            this.timerHarder.Enabled = true;
            this.timerHarder.Interval = 10000;
            this.timerHarder.Tick += new System.EventHandler(this.timerHarder_Tick);
            // 
            // FormDisappear
            // 
            this.AcceptButton = this.btnPause;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.CancelButton = this.btnPause;
            this.ClientSize = new System.Drawing.Size(745, 376);
            this.ControlBox = false;
            this.Controls.Add(this.ptbPlay);
            this.Controls.Add(this.btnLife3);
            this.Controls.Add(this.btnLife2);
            this.Controls.Add(this.btnLife1);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.lblHi);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblTextHi);
            this.Controls.Add(this.lblTxtScore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximumSize = new System.Drawing.Size(765, 419);
            this.MinimumSize = new System.Drawing.Size(765, 419);
            this.Name = "FormDisappear";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Disappear Circle";
            this.Load += new System.EventHandler(this.FormDisappear_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbPlay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTxtScore;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Label lblTextHi;
        private System.Windows.Forms.Label lblHi;
        private System.Windows.Forms.Button btnLife1;
        private System.Windows.Forms.Button btnLife2;
        private System.Windows.Forms.Button btnLife3;
        private System.Windows.Forms.PictureBox ptbPlay;
        private System.Windows.Forms.Timer timerCreate;
        private System.Windows.Forms.Timer timerGame;
        private System.Windows.Forms.Timer timerHarder;
    }
}

