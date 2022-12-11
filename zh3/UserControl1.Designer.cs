namespace zh3
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.oraClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kurzusNévDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.napNévDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idősávDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teremDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oraClassBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(74, 339);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(384, 27);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(74, 401);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(384, 484);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kurzusNévDataGridViewTextBoxColumn,
            this.napNévDataGridViewTextBoxColumn,
            this.idősávDataGridViewTextBoxColumn,
            this.teremDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.oraClassBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(533, 394);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(566, 491);
            this.dataGridView1.TabIndex = 2;
            // 
            // oraClassBindingSource
            // 
            this.oraClassBindingSource.DataSource = typeof(zh3.OraClass);
            // 
            // kurzusNévDataGridViewTextBoxColumn
            // 
            this.kurzusNévDataGridViewTextBoxColumn.DataPropertyName = "KurzusNév";
            this.kurzusNévDataGridViewTextBoxColumn.HeaderText = "KurzusNév";
            this.kurzusNévDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kurzusNévDataGridViewTextBoxColumn.Name = "kurzusNévDataGridViewTextBoxColumn";
            this.kurzusNévDataGridViewTextBoxColumn.Width = 125;
            // 
            // napNévDataGridViewTextBoxColumn
            // 
            this.napNévDataGridViewTextBoxColumn.DataPropertyName = "NapNév";
            this.napNévDataGridViewTextBoxColumn.HeaderText = "NapNév";
            this.napNévDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.napNévDataGridViewTextBoxColumn.Name = "napNévDataGridViewTextBoxColumn";
            this.napNévDataGridViewTextBoxColumn.Width = 125;
            // 
            // idősávDataGridViewTextBoxColumn
            // 
            this.idősávDataGridViewTextBoxColumn.DataPropertyName = "Idősáv";
            this.idősávDataGridViewTextBoxColumn.HeaderText = "Idősáv";
            this.idősávDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idősávDataGridViewTextBoxColumn.Name = "idősávDataGridViewTextBoxColumn";
            this.idősávDataGridViewTextBoxColumn.Width = 125;
            // 
            // teremDataGridViewTextBoxColumn
            // 
            this.teremDataGridViewTextBoxColumn.DataPropertyName = "Terem";
            this.teremDataGridViewTextBoxColumn.HeaderText = "Terem";
            this.teremDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.teremDataGridViewTextBoxColumn.Name = "teremDataGridViewTextBoxColumn";
            this.teremDataGridViewTextBoxColumn.Width = 125;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1139, 996);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oraClassBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private ListBox listBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn kurzusNévDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn napNévDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idősávDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn teremDataGridViewTextBoxColumn;
        private BindingSource oraClassBindingSource;
    }
}
