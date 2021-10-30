namespace BulbApplication
{
    partial class BulbApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BulbApp));
            this.offBulb = new System.Windows.Forms.PictureBox();
            this.onBulb = new System.Windows.Forms.PictureBox();
            this.onButton = new System.Windows.Forms.Button();
            this.offButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.offBulb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onBulb)).BeginInit();
            this.SuspendLayout();
            // 
            // offBulb
            // 
            this.offBulb.Image = ((System.Drawing.Image)(resources.GetObject("offBulb.Image")));
            this.offBulb.Location = new System.Drawing.Point(12, 12);
            this.offBulb.Name = "offBulb";
            this.offBulb.Size = new System.Drawing.Size(171, 248);
            this.offBulb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.offBulb.TabIndex = 0;
            this.offBulb.TabStop = false;
            // 
            // onBulb
            // 
            this.onBulb.Image = ((System.Drawing.Image)(resources.GetObject("onBulb.Image")));
            this.onBulb.Location = new System.Drawing.Point(189, 12);
            this.onBulb.Name = "onBulb";
            this.onBulb.Size = new System.Drawing.Size(165, 248);
            this.onBulb.TabIndex = 1;
            this.onBulb.TabStop = false;
            this.onBulb.Visible = false;
            // 
            // onButton
            // 
            this.onButton.Location = new System.Drawing.Point(58, 282);
            this.onButton.Name = "onButton";
            this.onButton.Size = new System.Drawing.Size(75, 23);
            this.onButton.TabIndex = 2;
            this.onButton.Text = "Switch On";
            this.onButton.UseVisualStyleBackColor = true;
            this.onButton.Click += new System.EventHandler(this.onButton_Click);
            // 
            // offButton
            // 
            this.offButton.Location = new System.Drawing.Point(230, 282);
            this.offButton.Name = "offButton";
            this.offButton.Size = new System.Drawing.Size(75, 23);
            this.offButton.TabIndex = 3;
            this.offButton.Text = "Switch Off";
            this.offButton.UseVisualStyleBackColor = true;
            this.offButton.Click += new System.EventHandler(this.offButton_Click);
            // 
            // BulbApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 334);
            this.Controls.Add(this.offButton);
            this.Controls.Add(this.onButton);
            this.Controls.Add(this.onBulb);
            this.Controls.Add(this.offBulb);
            this.Name = "BulbApp";
            this.Text = "Bulb Application";
            ((System.ComponentModel.ISupportInitialize)(this.offBulb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onBulb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox offBulb;
        private System.Windows.Forms.PictureBox onBulb;
        private System.Windows.Forms.Button onButton;
        private System.Windows.Forms.Button offButton;
    }
}

