namespace Ver1
{
    partial class FormGameOver
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblHi = new System.Windows.Forms.Label();
            this.lblTextHi = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.BtnContinue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightCyan;
            this.label1.Location = new System.Drawing.Point(57, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "GAME OVER";
            // 
            // lblScore
            // 
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Script MT Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.LightCyan;
            this.lblScore.Location = new System.Drawing.Point(66, 71);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(278, 40);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "0";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHi
            // 
            this.lblHi.BackColor = System.Drawing.Color.Transparent;
            this.lblHi.Font = new System.Drawing.Font("Script MT Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHi.ForeColor = System.Drawing.Color.LightCyan;
            this.lblHi.Location = new System.Drawing.Point(66, 110);
            this.lblHi.Name = "lblHi";
            this.lblHi.Size = new System.Drawing.Size(278, 31);
            this.lblHi.TabIndex = 3;
            this.lblHi.Text = "0";
            this.lblHi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTextHi
            // 
            this.lblTextHi.AutoSize = true;
            this.lblTextHi.BackColor = System.Drawing.Color.Transparent;
            this.lblTextHi.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextHi.ForeColor = System.Drawing.Color.LightCyan;
            this.lblTextHi.Location = new System.Drawing.Point(144, 110);
            this.lblTextHi.Name = "lblTextHi";
            this.lblTextHi.Size = new System.Drawing.Size(46, 33);
            this.lblTextHi.TabIndex = 2;
            this.lblTextHi.Text = "Hi:";
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::Ver1.Properties.Resources.exit;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.Location = new System.Drawing.Point(221, 162);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(160, 57);
            this.btnExit.TabIndex = 4;
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // BtnContinue
            // 
            this.BtnContinue.BackgroundImage = global::Ver1.Properties.Resources.retry;
            this.BtnContinue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnContinue.Location = new System.Drawing.Point(23, 162);
            this.BtnContinue.Name = "BtnContinue";
            this.BtnContinue.Size = new System.Drawing.Size(160, 57);
            this.BtnContinue.TabIndex = 5;
            this.BtnContinue.UseVisualStyleBackColor = true;
            // 
            // FormGameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(392, 238);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.BtnContinue);
            this.Controls.Add(this.lblTextHi);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormGameOver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormGameOver_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblHi;
        private System.Windows.Forms.Label lblTextHi;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button BtnContinue;
    }
}