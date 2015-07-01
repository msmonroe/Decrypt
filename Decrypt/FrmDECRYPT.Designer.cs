namespace Decrypt
{
    partial class FrmDECRYPT
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
            this.btnDECRYPT = new System.Windows.Forms.Button();
            this.lblDECRYPT = new System.Windows.Forms.Label();
            this.txtBxDECRYPT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDECRYPT
            // 
            this.btnDECRYPT.Location = new System.Drawing.Point(13, 57);
            this.btnDECRYPT.Name = "btnDECRYPT";
            this.btnDECRYPT.Size = new System.Drawing.Size(259, 23);
            this.btnDECRYPT.TabIndex = 0;
            this.btnDECRYPT.Text = "DECRYPT";
            this.btnDECRYPT.UseVisualStyleBackColor = true;
            this.btnDECRYPT.Click += new System.EventHandler(this.btnDECRYPT_Click);
            // 
            // lblDECRYPT
            // 
            this.lblDECRYPT.AutoSize = true;
            this.lblDECRYPT.Location = new System.Drawing.Point(16, 8);
            this.lblDECRYPT.Name = "lblDECRYPT";
            this.lblDECRYPT.Size = new System.Drawing.Size(0, 13);
            this.lblDECRYPT.TabIndex = 1;
            // 
            // txtBxDECRYPT
            // 
            this.txtBxDECRYPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxDECRYPT.Location = new System.Drawing.Point(13, 27);
            this.txtBxDECRYPT.Name = "txtBxDECRYPT";
            this.txtBxDECRYPT.Size = new System.Drawing.Size(259, 24);
            this.txtBxDECRYPT.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 88);
            this.Controls.Add(this.txtBxDECRYPT);
            this.Controls.Add(this.lblDECRYPT);
            this.Controls.Add(this.btnDECRYPT);
            this.Name = "Form1";
            this.Text = "Decrypter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDECRYPT;
        private System.Windows.Forms.Label lblDECRYPT;
        private System.Windows.Forms.TextBox txtBxDECRYPT;
    }
}

