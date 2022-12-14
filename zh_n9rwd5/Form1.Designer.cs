namespace zh_n9rwd5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonVevők = new System.Windows.Forms.Button();
            this.buttonÜgynökök = new System.Windows.Forms.Button();
            this.buttonRendelések = new System.Windows.Forms.Button();
            this.buttonExcel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonVevők
            // 
            this.buttonVevők.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonVevők.Location = new System.Drawing.Point(40, 44);
            this.buttonVevők.Name = "buttonVevők";
            this.buttonVevők.Size = new System.Drawing.Size(144, 23);
            this.buttonVevők.TabIndex = 0;
            this.buttonVevők.Text = "Vevők";
            this.buttonVevők.UseVisualStyleBackColor = true;
            this.buttonVevők.Click += new System.EventHandler(this.buttonVevők_Click);
            // 
            // buttonÜgynökök
            // 
            this.buttonÜgynökök.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonÜgynökök.Location = new System.Drawing.Point(40, 99);
            this.buttonÜgynökök.Name = "buttonÜgynökök";
            this.buttonÜgynökök.Size = new System.Drawing.Size(144, 23);
            this.buttonÜgynökök.TabIndex = 1;
            this.buttonÜgynökök.Text = "Ügynökök";
            this.buttonÜgynökök.UseVisualStyleBackColor = true;
            this.buttonÜgynökök.Click += new System.EventHandler(this.buttonÜgynökök_Click);
            // 
            // buttonRendelések
            // 
            this.buttonRendelések.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRendelések.Location = new System.Drawing.Point(40, 159);
            this.buttonRendelések.Name = "buttonRendelések";
            this.buttonRendelések.Size = new System.Drawing.Size(144, 23);
            this.buttonRendelések.TabIndex = 2;
            this.buttonRendelések.Text = "Rendelések";
            this.buttonRendelések.UseVisualStyleBackColor = true;
            this.buttonRendelések.Click += new System.EventHandler(this.buttonRendelések_Click);
            // 
            // buttonExcel
            // 
            this.buttonExcel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExcel.Location = new System.Drawing.Point(40, 228);
            this.buttonExcel.Name = "buttonExcel";
            this.buttonExcel.Size = new System.Drawing.Size(144, 23);
            this.buttonExcel.TabIndex = 3;
            this.buttonExcel.Text = "Excel Megnyitása";
            this.buttonExcel.UseVisualStyleBackColor = true;
            this.buttonExcel.Click += new System.EventHandler(this.buttonExcel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 312);
            this.Controls.Add(this.buttonExcel);
            this.Controls.Add(this.buttonRendelések);
            this.Controls.Add(this.buttonÜgynökök);
            this.Controls.Add(this.buttonVevők);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing_1);
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonVevők;
        private Button buttonÜgynökök;
        private Button buttonRendelések;
        private Button buttonExcel;
    }
}