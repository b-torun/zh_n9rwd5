namespace zh_n9rwd5
{
    partial class UserControl3
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
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rendelésAzonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rendelésiMennyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.előlegDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rendelésiDátumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vásárlóAzonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ügynökAzonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rendelésekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rendelésekBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(22, 44);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(176, 364);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(546, 44);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(180, 364);
            this.listBox2.TabIndex = 1;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(546, 15);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(180, 23);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
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
            this.rendelésAzonDataGridViewTextBoxColumn,
            this.rendelésiMennyDataGridViewTextBoxColumn,
            this.előlegDataGridViewTextBoxColumn,
            this.rendelésiDátumDataGridViewTextBoxColumn,
            this.vásárlóAzonDataGridViewTextBoxColumn,
            this.ügynökAzonDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rendelésekBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(204, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(336, 393);
            this.dataGridView1.TabIndex = 4;
            // 
            // rendelésAzonDataGridViewTextBoxColumn
            // 
            this.rendelésAzonDataGridViewTextBoxColumn.DataPropertyName = "RendelésAzon";
            this.rendelésAzonDataGridViewTextBoxColumn.HeaderText = "RendelésAzon";
            this.rendelésAzonDataGridViewTextBoxColumn.Name = "rendelésAzonDataGridViewTextBoxColumn";
            // 
            // rendelésiMennyDataGridViewTextBoxColumn
            // 
            this.rendelésiMennyDataGridViewTextBoxColumn.DataPropertyName = "RendelésiMenny";
            this.rendelésiMennyDataGridViewTextBoxColumn.HeaderText = "RendelésiMenny";
            this.rendelésiMennyDataGridViewTextBoxColumn.Name = "rendelésiMennyDataGridViewTextBoxColumn";
            // 
            // előlegDataGridViewTextBoxColumn
            // 
            this.előlegDataGridViewTextBoxColumn.DataPropertyName = "Előleg";
            this.előlegDataGridViewTextBoxColumn.HeaderText = "Előleg";
            this.előlegDataGridViewTextBoxColumn.Name = "előlegDataGridViewTextBoxColumn";
            // 
            // rendelésiDátumDataGridViewTextBoxColumn
            // 
            this.rendelésiDátumDataGridViewTextBoxColumn.DataPropertyName = "RendelésiDátum";
            this.rendelésiDátumDataGridViewTextBoxColumn.HeaderText = "RendelésiDátum";
            this.rendelésiDátumDataGridViewTextBoxColumn.Name = "rendelésiDátumDataGridViewTextBoxColumn";
            // 
            // vásárlóAzonDataGridViewTextBoxColumn
            // 
            this.vásárlóAzonDataGridViewTextBoxColumn.DataPropertyName = "VásárlóAzon";
            this.vásárlóAzonDataGridViewTextBoxColumn.HeaderText = "VásárlóAzon";
            this.vásárlóAzonDataGridViewTextBoxColumn.Name = "vásárlóAzonDataGridViewTextBoxColumn";
            // 
            // ügynökAzonDataGridViewTextBoxColumn
            // 
            this.ügynökAzonDataGridViewTextBoxColumn.DataPropertyName = "ÜgynökAzon";
            this.ügynökAzonDataGridViewTextBoxColumn.HeaderText = "ÜgynökAzon";
            this.ügynökAzonDataGridViewTextBoxColumn.Name = "ügynökAzonDataGridViewTextBoxColumn";
            // 
            // rendelésekBindingSource
            // 
            this.rendelésekBindingSource.DataSource = typeof(zh_n9rwd5.Models.Rendelések);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Location = new System.Drawing.Point(521, 420);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDel.Location = new System.Drawing.Point(628, 422);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 23);
            this.buttonDel.TabIndex = 6;
            this.buttonDel.Text = "-";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // UserControl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "UserControl3";
            this.Size = new System.Drawing.Size(729, 476);
            this.Load += new System.EventHandler(this.UserControl3_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rendelésekBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBox1;
        private ListBox listBox2;
        private TextBox textBox1;
        private TextBox textBox2;
        private DataGridView dataGridView1;
        private Button buttonAdd;
        private Button buttonDel;
        private DataGridViewTextBoxColumn rendelésAzonDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rendelésiMennyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn előlegDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rendelésiDátumDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vásárlóAzonDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ügynökAzonDataGridViewTextBoxColumn;
        private BindingSource rendelésekBindingSource;
    }
}
