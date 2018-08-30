namespace LightsOut
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.LightsOutLabel = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LightBulbPicture = new System.Windows.Forms.PictureBox();
            this.OKButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LightBulbPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // LightsOutLabel
            // 
            this.LightsOutLabel.AutoSize = true;
            this.LightsOutLabel.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LightsOutLabel.ForeColor = System.Drawing.Color.Navy;
            this.LightsOutLabel.Location = new System.Drawing.Point(110, 35);
            this.LightsOutLabel.Name = "LightsOutLabel";
            this.LightsOutLabel.Size = new System.Drawing.Size(130, 33);
            this.LightsOutLabel.TabIndex = 0;
            this.LightsOutLabel.Text = "Lights Out!";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorLabel.Location = new System.Drawing.Point(113, 71);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(127, 18);
            this.AuthorLabel.TabIndex = 1;
            this.AuthorLabel.Text = "By Caleb Herring";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Turn off all the light boxes to win the game!";
            // 
            // LightBulbPicture
            // 
            this.LightBulbPicture.Image = ((System.Drawing.Image)(resources.GetObject("LightBulbPicture.Image")));
            this.LightBulbPicture.Location = new System.Drawing.Point(12, 12);
            this.LightBulbPicture.Name = "LightBulbPicture";
            this.LightBulbPicture.Size = new System.Drawing.Size(75, 77);
            this.LightBulbPicture.TabIndex = 3;
            this.LightBulbPicture.TabStop = false;
            // 
            // OKButton
            // 
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButton.Location = new System.Drawing.Point(93, 182);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 4;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.LightBulbPicture);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.LightsOutLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.LightBulbPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LightsOutLabel;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox LightBulbPicture;
        private System.Windows.Forms.Button OKButton;
    }
}