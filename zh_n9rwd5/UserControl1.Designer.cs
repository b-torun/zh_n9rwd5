namespace zh_n9rwd5
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vásárlóBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vásárlóAzonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vásárlóNévDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vásárlóOrszágDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ügynökAzonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vásárlóBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(182, 409);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vásárlóAzonDataGridViewTextBoxColumn,
            this.vásárlóNévDataGridViewTextBoxColumn,
            this.vásárlóOrszágDataGridViewTextBoxColumn,
            this.ügynökAzonDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vásárlóBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(200, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(529, 438);
            this.dataGridView1.TabIndex = 2;
            // 
            // vásárlóBindingSource
            // 
            this.vásárlóBindingSource.DataSource = typeof(zh_n9rwd5.Models.Vásárló);
            // 
            // vásárlóAzonDataGridViewTextBoxColumn
            // 
            this.vásárlóAzonDataGridViewTextBoxColumn.DataPropertyName = "VásárlóAzon";
            this.vásárlóAzonDataGridViewTextBoxColumn.HeaderText = "VásárlóAzon";
            this.vásárlóAzonDataGridViewTextBoxColumn.Name = "vásárlóAzonDataGridViewTextBoxColumn";
            // 
            // vásárlóNévDataGridViewTextBoxColumn
            // 
            this.vásárlóNévDataGridViewTextBoxColumn.DataPropertyName = "VásárlóNév";
            this.vásárlóNévDataGridViewTextBoxColumn.HeaderText = "VásárlóNév";
            this.vásárlóNévDataGridViewTextBoxColumn.Name = "vásárlóNévDataGridViewTextBoxColumn";
            // 
            // vásárlóOrszágDataGridViewTextBoxColumn
            // 
            this.vásárlóOrszágDataGridViewTextBoxColumn.DataPropertyName = "VásárlóOrszág";
            this.vásárlóOrszágDataGridViewTextBoxColumn.HeaderText = "VásárlóOrszág";
            this.vásárlóOrszágDataGridViewTextBoxColumn.Name = "vásárlóOrszágDataGridViewTextBoxColumn";
            // 
            // ügynökAzonDataGridViewTextBoxColumn
            // 
            this.ügynökAzonDataGridViewTextBoxColumn.DataPropertyName = "ÜgynökAzon";
            this.ügynökAzonDataGridViewTextBoxColumn.HeaderText = "ÜgynökAzon";
            this.ügynökAzonDataGridViewTextBoxColumn.Name = "ügynökAzonDataGridViewTextBoxColumn";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(732, 469);
            this.Load += new System.EventHandler(this.UserControl1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vásárlóBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBox1;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private BindingSource vásárlóBindingSource;
        private DataGridViewTextBoxColumn vásárlóAzonDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vásárlóNévDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vásárlóOrszágDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ügynökAzonDataGridViewTextBoxColumn;
    }
}
