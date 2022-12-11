namespace zh3
{
    partial class UserControl2
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.instructorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.instructorSkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salutationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusFkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employementFkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employementFkNavigationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lessonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusFkNavigationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(322, 219);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tanár hozzáadás";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.instructorSkDataGridViewTextBoxColumn,
            this.salutationDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.statusFkDataGridViewTextBoxColumn,
            this.employementFkDataGridViewTextBoxColumn,
            this.employementFkNavigationDataGridViewTextBoxColumn,
            this.lessonDataGridViewTextBoxColumn,
            this.statusFkNavigationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.instructorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(427, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(721, 496);
            this.dataGridView1.TabIndex = 1;
            // 
            // instructorBindingSource
            // 
            this.instructorBindingSource.DataSource = typeof(zh3.Models.Instructor);
            // 
            // instructorSkDataGridViewTextBoxColumn
            // 
            this.instructorSkDataGridViewTextBoxColumn.DataPropertyName = "InstructorSk";
            this.instructorSkDataGridViewTextBoxColumn.HeaderText = "InstructorSk";
            this.instructorSkDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.instructorSkDataGridViewTextBoxColumn.Name = "instructorSkDataGridViewTextBoxColumn";
            this.instructorSkDataGridViewTextBoxColumn.Width = 125;
            // 
            // salutationDataGridViewTextBoxColumn
            // 
            this.salutationDataGridViewTextBoxColumn.DataPropertyName = "Salutation";
            this.salutationDataGridViewTextBoxColumn.HeaderText = "Salutation";
            this.salutationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.salutationDataGridViewTextBoxColumn.Name = "salutationDataGridViewTextBoxColumn";
            this.salutationDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusFkDataGridViewTextBoxColumn
            // 
            this.statusFkDataGridViewTextBoxColumn.DataPropertyName = "StatusFk";
            this.statusFkDataGridViewTextBoxColumn.HeaderText = "StatusFk";
            this.statusFkDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusFkDataGridViewTextBoxColumn.Name = "statusFkDataGridViewTextBoxColumn";
            this.statusFkDataGridViewTextBoxColumn.Width = 125;
            // 
            // employementFkDataGridViewTextBoxColumn
            // 
            this.employementFkDataGridViewTextBoxColumn.DataPropertyName = "EmployementFk";
            this.employementFkDataGridViewTextBoxColumn.HeaderText = "EmployementFk";
            this.employementFkDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employementFkDataGridViewTextBoxColumn.Name = "employementFkDataGridViewTextBoxColumn";
            this.employementFkDataGridViewTextBoxColumn.Visible = false;
            this.employementFkDataGridViewTextBoxColumn.Width = 125;
            // 
            // employementFkNavigationDataGridViewTextBoxColumn
            // 
            this.employementFkNavigationDataGridViewTextBoxColumn.DataPropertyName = "EmployementFkNavigation";
            this.employementFkNavigationDataGridViewTextBoxColumn.HeaderText = "EmployementFkNavigation";
            this.employementFkNavigationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employementFkNavigationDataGridViewTextBoxColumn.Name = "employementFkNavigationDataGridViewTextBoxColumn";
            this.employementFkNavigationDataGridViewTextBoxColumn.Visible = false;
            this.employementFkNavigationDataGridViewTextBoxColumn.Width = 125;
            // 
            // lessonDataGridViewTextBoxColumn
            // 
            this.lessonDataGridViewTextBoxColumn.DataPropertyName = "Lesson";
            this.lessonDataGridViewTextBoxColumn.HeaderText = "Lesson";
            this.lessonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lessonDataGridViewTextBoxColumn.Name = "lessonDataGridViewTextBoxColumn";
            this.lessonDataGridViewTextBoxColumn.ReadOnly = true;
            this.lessonDataGridViewTextBoxColumn.Visible = false;
            this.lessonDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusFkNavigationDataGridViewTextBoxColumn
            // 
            this.statusFkNavigationDataGridViewTextBoxColumn.DataPropertyName = "StatusFkNavigation";
            this.statusFkNavigationDataGridViewTextBoxColumn.HeaderText = "StatusFkNavigation";
            this.statusFkNavigationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusFkNavigationDataGridViewTextBoxColumn.Name = "statusFkNavigationDataGridViewTextBoxColumn";
            this.statusFkNavigationDataGridViewTextBoxColumn.Visible = false;
            this.statusFkNavigationDataGridViewTextBoxColumn.Width = 125;
            // 
            // UserControl2
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(1288, 880);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn instructorSkDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salutationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusFkDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn employementFkDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn employementFkNavigationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lessonDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusFkNavigationDataGridViewTextBoxColumn;
        private BindingSource instructorBindingSource;
    }
}
