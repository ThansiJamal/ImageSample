namespace ImageSample
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
            this.txtText = new System.Windows.Forms.TextBox();
            this.picP1 = new System.Windows.Forms.PictureBox();
            this.btnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picP1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(105, 12);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(186, 20);
            this.txtText.TabIndex = 0;
            // 
            // picP1
            // 
            this.picP1.Location = new System.Drawing.Point(105, 55);
            this.picP1.Name = "picP1";
            this.picP1.Size = new System.Drawing.Size(267, 229);
            this.picP1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picP1.TabIndex = 1;
            this.picP1.TabStop = false;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(297, 12);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.picP1);
            this.Controls.Add(this.txtText);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picP1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.PictureBox picP1;
        private System.Windows.Forms.Button btnOk;
    }
}

