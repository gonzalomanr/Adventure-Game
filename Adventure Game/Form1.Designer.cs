namespace Adventure_Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.outputLabel = new System.Windows.Forms.Label();
            this.redPictureBox = new System.Windows.Forms.PictureBox();
            this.bluePictureBox = new System.Windows.Forms.PictureBox();
            this.yellowPictureBox = new System.Windows.Forms.PictureBox();
            this.redLabel = new System.Windows.Forms.Label();
            this.blueLabel = new System.Windows.Forms.Label();
            this.yellowLabel = new System.Windows.Forms.Label();
            this.picturesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.redPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.Transparent;
            this.outputLabel.Font = new System.Drawing.Font("Segoe Script", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.outputLabel.Location = new System.Drawing.Point(25, 20);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(583, 267);
            this.outputLabel.TabIndex = 0;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // redPictureBox
            // 
            this.redPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.redPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("redPictureBox.BackgroundImage")));
            this.redPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.redPictureBox.Location = new System.Drawing.Point(24, 353);
            this.redPictureBox.Name = "redPictureBox";
            this.redPictureBox.Size = new System.Drawing.Size(80, 58);
            this.redPictureBox.TabIndex = 3;
            this.redPictureBox.TabStop = false;
            // 
            // bluePictureBox
            // 
            this.bluePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.bluePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bluePictureBox.BackgroundImage")));
            this.bluePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bluePictureBox.Location = new System.Drawing.Point(47, 310);
            this.bluePictureBox.Name = "bluePictureBox";
            this.bluePictureBox.Size = new System.Drawing.Size(42, 43);
            this.bluePictureBox.TabIndex = 4;
            this.bluePictureBox.TabStop = false;
            // 
            // yellowPictureBox
            // 
            this.yellowPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.yellowPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("yellowPictureBox.BackgroundImage")));
            this.yellowPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.yellowPictureBox.Location = new System.Drawing.Point(38, 417);
            this.yellowPictureBox.Name = "yellowPictureBox";
            this.yellowPictureBox.Size = new System.Drawing.Size(51, 37);
            this.yellowPictureBox.TabIndex = 5;
            this.yellowPictureBox.TabStop = false;
            // 
            // redLabel
            // 
            this.redLabel.BackColor = System.Drawing.Color.Transparent;
            this.redLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redLabel.ForeColor = System.Drawing.Color.White;
            this.redLabel.Location = new System.Drawing.Point(95, 368);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(206, 29);
            this.redLabel.TabIndex = 6;
            // 
            // blueLabel
            // 
            this.blueLabel.BackColor = System.Drawing.Color.Transparent;
            this.blueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueLabel.ForeColor = System.Drawing.Color.White;
            this.blueLabel.Location = new System.Drawing.Point(95, 321);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(206, 29);
            this.blueLabel.TabIndex = 7;
            // 
            // yellowLabel
            // 
            this.yellowLabel.BackColor = System.Drawing.Color.Transparent;
            this.yellowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yellowLabel.ForeColor = System.Drawing.Color.White;
            this.yellowLabel.Location = new System.Drawing.Point(95, 417);
            this.yellowLabel.Name = "yellowLabel";
            this.yellowLabel.Size = new System.Drawing.Size(206, 29);
            this.yellowLabel.TabIndex = 8;
            // 
            // picturesLabel
            // 
            this.picturesLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picturesLabel.ForeColor = System.Drawing.Color.Transparent;
            this.picturesLabel.Location = new System.Drawing.Point(365, 300);
            this.picturesLabel.Name = "picturesLabel";
            this.picturesLabel.Size = new System.Drawing.Size(243, 160);
            this.picturesLabel.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(631, 469);
            this.Controls.Add(this.picturesLabel);
            this.Controls.Add(this.yellowLabel);
            this.Controls.Add(this.blueLabel);
            this.Controls.Add(this.redLabel);
            this.Controls.Add(this.yellowPictureBox);
            this.Controls.Add(this.bluePictureBox);
            this.Controls.Add(this.redPictureBox);
            this.Controls.Add(this.outputLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.redPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.PictureBox redPictureBox;
        private System.Windows.Forms.PictureBox bluePictureBox;
        private System.Windows.Forms.PictureBox yellowPictureBox;
        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.Label blueLabel;
        private System.Windows.Forms.Label yellowLabel;
        private System.Windows.Forms.Label picturesLabel;
    }
}

