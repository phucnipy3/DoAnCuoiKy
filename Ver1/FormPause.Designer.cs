namespace Ver1
{
    partial class FormPause
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
            this.BtnContinue = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAgain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnContinue
            // 
            this.BtnContinue.BackgroundImage = global::Ver1.Properties.Resources._continue;
            this.BtnContinue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnContinue.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnContinue.Location = new System.Drawing.Point(122, 13);
            this.BtnContinue.Name = "BtnContinue";
            this.BtnContinue.Size = new System.Drawing.Size(183, 56);
            this.BtnContinue.TabIndex = 0;
            this.BtnContinue.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::Ver1.Properties.Resources.exit;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(122, 175);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(183, 56);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnAgain
            // 
            this.btnAgain.BackgroundImage = global::Ver1.Properties.Resources.retry;
            this.btnAgain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgain.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.btnAgain.Location = new System.Drawing.Point(122, 93);
            this.btnAgain.Name = "btnAgain";
            this.btnAgain.Size = new System.Drawing.Size(183, 56);
            this.btnAgain.TabIndex = 0;
            this.btnAgain.UseVisualStyleBackColor = true;
            // 
            // FormPause
            // 
            this.AcceptButton = this.BtnContinue;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.BtnContinue;
            this.ClientSize = new System.Drawing.Size(421, 262);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.BtnContinue);
            this.Controls.Add(this.btnAgain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormPause";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pause";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgain;
        private System.Windows.Forms.Button BtnContinue;
        private System.Windows.Forms.Button btnExit;
    }
}