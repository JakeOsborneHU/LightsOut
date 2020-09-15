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
            this.okButton = new System.Windows.Forms.Button();
            this.appDescription = new System.Windows.Forms.Label();
            this.appName = new System.Windows.Forms.Label();
            this.creatorName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(91, 172);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(155, 61);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // appDescription
            // 
            this.appDescription.AutoSize = true;
            this.appDescription.ForeColor = System.Drawing.Color.DimGray;
            this.appDescription.Location = new System.Drawing.Point(34, 112);
            this.appDescription.Name = "appDescription";
            this.appDescription.Size = new System.Drawing.Size(185, 20);
            this.appDescription.TabIndex = 1;
            this.appDescription.Text = "Turn out the lights to win!";
            // 
            // appName
            // 
            this.appName.AutoSize = true;
            this.appName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.appName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.appName.Location = new System.Drawing.Point(31, 29);
            this.appName.Name = "appName";
            this.appName.Size = new System.Drawing.Size(164, 37);
            this.appName.TabIndex = 2;
            this.appName.Text = "Lights Out";
            // 
            // creatorName
            // 
            this.creatorName.AutoSize = true;
            this.creatorName.Location = new System.Drawing.Point(67, 66);
            this.creatorName.Name = "creatorName";
            this.creatorName.Size = new System.Drawing.Size(128, 20);
            this.creatorName.TabIndex = 3;
            this.creatorName.Text = "by Jake Osborne";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LightsOut.Properties.Resources.lightsOutIcon_1;
            this.pictureBox1.Location = new System.Drawing.Point(213, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 57);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 266);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.creatorName);
            this.Controls.Add(this.appName);
            this.Controls.Add(this.appDescription);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.Padding = new System.Windows.Forms.Padding(14);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label appDescription;
        private System.Windows.Forms.Label appName;
        private System.Windows.Forms.Label creatorName;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
