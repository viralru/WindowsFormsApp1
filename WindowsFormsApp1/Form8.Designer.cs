
namespace WindowsFormsApp1
{
    partial class Form8
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.proektDataSet1 = new WindowsFormsApp1.proektDataSet1();
            this.workersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workersTableAdapter = new WindowsFormsApp1.proektDataSet1TableAdapters.WorkersTableAdapter();
            this.vacationsTableAdapter = new WindowsFormsApp1.proektDataSet1TableAdapters.VacationsTableAdapter();
            this.workersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idAccessGroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSignDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.fKVacationsWorkersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.proektDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKVacationsWorkersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Информация о сотрудниках";
            // 
            // proektDataSet1
            // 
            this.proektDataSet1.DataSetName = "proektDataSet1";
            this.proektDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workersBindingSource
            // 
            this.workersBindingSource.DataMember = "Workers";
            this.workersBindingSource.DataSource = this.proektDataSet1;
            // 
            // workersTableAdapter
            // 
            this.workersTableAdapter.ClearBeforeFill = true;
            // 
            // vacationsTableAdapter
            // 
            this.vacationsTableAdapter.ClearBeforeFill = true;
            // 
            // workersBindingSource1
            // 
            this.workersBindingSource1.DataMember = "Workers";
            this.workersBindingSource1.DataSource = this.proektDataSet1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.middleNameDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.isActiveDataGridViewCheckBoxColumn,
            this.idAccessGroupDataGridViewTextBoxColumn,
            this.idSignDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.workersBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(26, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1143, 317);
            this.dataGridView1.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // middleNameDataGridViewTextBoxColumn
            // 
            this.middleNameDataGridViewTextBoxColumn.DataPropertyName = "MiddleName";
            this.middleNameDataGridViewTextBoxColumn.HeaderText = "MiddleName";
            this.middleNameDataGridViewTextBoxColumn.Name = "middleNameDataGridViewTextBoxColumn";
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "Department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "Department";
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Position";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Login";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // isActiveDataGridViewCheckBoxColumn
            // 
            this.isActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.HeaderText = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.Name = "isActiveDataGridViewCheckBoxColumn";
            // 
            // idAccessGroupDataGridViewTextBoxColumn
            // 
            this.idAccessGroupDataGridViewTextBoxColumn.DataPropertyName = "id_AccessGroup";
            this.idAccessGroupDataGridViewTextBoxColumn.HeaderText = "id_AccessGroup";
            this.idAccessGroupDataGridViewTextBoxColumn.Name = "idAccessGroupDataGridViewTextBoxColumn";
            // 
            // idSignDataGridViewTextBoxColumn
            // 
            this.idSignDataGridViewTextBoxColumn.DataPropertyName = "id_Sign";
            this.idSignDataGridViewTextBoxColumn.HeaderText = "id_Sign";
            this.idSignDataGridViewTextBoxColumn.Name = "idSignDataGridViewTextBoxColumn";
            // 
            // workersBindingSource2
            // 
            this.workersBindingSource2.DataMember = "Workers";
            this.workersBindingSource2.DataSource = this.proektDataSet1;
            // 
            // fKVacationsWorkersBindingSource
            // 
            this.fKVacationsWorkersBindingSource.DataMember = "FK_Vacations_Workers";
            this.fKVacationsWorkersBindingSource.DataSource = this.workersBindingSource;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form8";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proektDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKVacationsWorkersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private proektDataSet1 proektDataSet1;
        private System.Windows.Forms.BindingSource workersBindingSource;
        private proektDataSet1TableAdapters.WorkersTableAdapter workersTableAdapter;
        private System.Windows.Forms.BindingSource fKVacationsWorkersBindingSource;
        private proektDataSet1TableAdapters.VacationsTableAdapter vacationsTableAdapter;
        private System.Windows.Forms.BindingSource workersBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAccessGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSignDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource workersBindingSource2;
    }
}