
namespace WebsiteMailScraping
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
            this.txtAdresler = new System.Windows.Forms.TextBox();
            this.lbxAdresler = new System.Windows.Forms.ListBox();
            this.btnBasla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAdresler
            // 
            this.txtAdresler.Location = new System.Drawing.Point(12, 12);
            this.txtAdresler.Multiline = true;
            this.txtAdresler.Name = "txtAdresler";
            this.txtAdresler.Size = new System.Drawing.Size(276, 226);
            this.txtAdresler.TabIndex = 0;
            // 
            // lbxAdresler
            // 
            this.lbxAdresler.FormattingEnabled = true;
            this.lbxAdresler.Location = new System.Drawing.Point(294, 12);
            this.lbxAdresler.Name = "lbxAdresler";
            this.lbxAdresler.Size = new System.Drawing.Size(200, 225);
            this.lbxAdresler.TabIndex = 1;
            // 
            // btnBasla
            // 
            this.btnBasla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBasla.Location = new System.Drawing.Point(12, 244);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(482, 39);
            this.btnBasla.TabIndex = 2;
            this.btnBasla.Text = "BAŞLA";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 295);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.lbxAdresler);
            this.Controls.Add(this.txtAdresler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdresler;
        private System.Windows.Forms.ListBox lbxAdresler;
        private System.Windows.Forms.Button btnBasla;
    }
}

