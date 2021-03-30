
namespace WindowsFormsApp1
{
    partial class Form10
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
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label middleNameLabel;
            System.Windows.Forms.Label departmentLabel;
            System.Windows.Forms.Label positionLabel;
            System.Windows.Forms.Label loginLabel;
            System.Windows.Forms.Label passwordLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.proektDataSet1 = new WindowsFormsApp1.proektDataSet1();
            this.workersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workersTableAdapter = new WindowsFormsApp1.proektDataSet1TableAdapters.WorkersTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.proektDataSet1TableAdapters.TableAdapterManager();
            this.lastNameComboBox = new System.Windows.Forms.ComboBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.middleNameTextBox = new System.Windows.Forms.TextBox();
            this.departmentTextBox = new System.Windows.Forms.TextBox();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.proektDataSet2 = new WindowsFormsApp1.proektDataSet2();
            this.workersTableAdapter1 = new WindowsFormsApp1.proektDataSet2TableAdapters.WorkersTableAdapter();
            this.tableAdapterManager1 = new WindowsFormsApp1.proektDataSet2TableAdapters.TableAdapterManager();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            lastNameLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            middleNameLabel = new System.Windows.Forms.Label();
            departmentLabel = new System.Windows.Forms.Label();
            positionLabel = new System.Windows.Forms.Label();
            loginLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.proektDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proektDataSet2)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(467, 81);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(61, 13);
            lastNameLabel.TabIndex = 22;
            lastNameLabel.Text = "Last Name:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(468, 116);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(60, 13);
            firstNameLabel.TabIndex = 23;
            firstNameLabel.Text = "First Name:";
            // 
            // middleNameLabel
            // 
            middleNameLabel.AutoSize = true;
            middleNameLabel.Location = new System.Drawing.Point(467, 154);
            middleNameLabel.Name = "middleNameLabel";
            middleNameLabel.Size = new System.Drawing.Size(72, 13);
            middleNameLabel.TabIndex = 24;
            middleNameLabel.Text = "Middle Name:";
            // 
            // departmentLabel
            // 
            departmentLabel.AutoSize = true;
            departmentLabel.Location = new System.Drawing.Point(468, 188);
            departmentLabel.Name = "departmentLabel";
            departmentLabel.Size = new System.Drawing.Size(65, 13);
            departmentLabel.TabIndex = 25;
            departmentLabel.Text = "Department:";
            // 
            // positionLabel
            // 
            positionLabel.AutoSize = true;
            positionLabel.Location = new System.Drawing.Point(481, 214);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new System.Drawing.Size(47, 13);
            positionLabel.TabIndex = 26;
            positionLabel.Text = "Position:";
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new System.Drawing.Point(481, 288);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new System.Drawing.Size(36, 13);
            loginLabel.TabIndex = 27;
            loginLabel.Text = "Login:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(477, 323);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(56, 13);
            passwordLabel.TabIndex = 28;
            passwordLabel.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Настройки";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(58, 147);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(116, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(225, 147);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(116, 20);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(531, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Информация об учетной записи";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(620, 344);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(97, 13);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Изменить пароль";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Выберите делегата";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Дата начала";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(222, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Дата окончания";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "В отпуске";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(150, 85);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 19;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccessGroupsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DocumentsTableAdapter = null;
            this.tableAdapterManager.LettersOfWorkersTableAdapter = null;
            this.tableAdapterManager.LettersTableAdapter = null;
            this.tableAdapterManager.LetterStatusTableAdapter = null;
            this.tableAdapterManager.SignsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.proektDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VacationsTableAdapter = null;
            this.tableAdapterManager.WorkersTableAdapter = this.workersTableAdapter;
            // 
            // lastNameComboBox
            // 
            this.lastNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workersBindingSource, "LastName", true));
            this.lastNameComboBox.FormattingEnabled = true;
            this.lastNameComboBox.Location = new System.Drawing.Point(61, 228);
            this.lastNameComboBox.Name = "lastNameComboBox";
            this.lastNameComboBox.Size = new System.Drawing.Size(121, 21);
            this.lastNameComboBox.TabIndex = 22;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workersBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(539, 78);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 23;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workersBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(539, 113);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextBox.TabIndex = 24;
            // 
            // middleNameTextBox
            // 
            this.middleNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workersBindingSource, "MiddleName", true));
            this.middleNameTextBox.Location = new System.Drawing.Point(539, 151);
            this.middleNameTextBox.Name = "middleNameTextBox";
            this.middleNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.middleNameTextBox.TabIndex = 25;
            // 
            // departmentTextBox
            // 
            this.departmentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workersBindingSource, "Department", true));
            this.departmentTextBox.Location = new System.Drawing.Point(539, 185);
            this.departmentTextBox.Name = "departmentTextBox";
            this.departmentTextBox.Size = new System.Drawing.Size(100, 20);
            this.departmentTextBox.TabIndex = 26;
            // 
            // positionTextBox
            // 
            this.positionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workersBindingSource, "Position", true));
            this.positionTextBox.Location = new System.Drawing.Point(539, 214);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(100, 20);
            this.positionTextBox.TabIndex = 27;
            // 
            // loginTextBox
            // 
            this.loginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workersBindingSource, "Login", true));
            this.loginTextBox.Enabled = false;
            this.loginTextBox.Location = new System.Drawing.Point(539, 281);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(100, 20);
            this.loginTextBox.TabIndex = 28;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workersBindingSource, "Password", true));
            this.passwordTextBox.Enabled = false;
            this.passwordTextBox.Location = new System.Drawing.Point(539, 316);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 29;
            // 
            // proektDataSet2
            // 
            this.proektDataSet2.DataSetName = "proektDataSet2";
            this.proektDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workersTableAdapter1
            // 
            this.workersTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.AccessGroupsTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.DocumentsTableAdapter = null;
            this.tableAdapterManager1.LettersOfWorkersTableAdapter = null;
            this.tableAdapterManager1.LettersTableAdapter = null;
            this.tableAdapterManager1.LetterStatusTableAdapter = null;
            this.tableAdapterManager1.SignsTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = WindowsFormsApp1.proektDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.VacationsTableAdapter = null;
            this.tableAdapterManager1.WorkersTableAdapter = this.workersTableAdapter1;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(111, 25);
            this.fillByToolStrip.TabIndex = 30;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(loginLabel);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(positionLabel);
            this.Controls.Add(this.positionTextBox);
            this.Controls.Add(departmentLabel);
            this.Controls.Add(this.departmentTextBox);
            this.Controls.Add(middleNameLabel);
            this.Controls.Add(this.middleNameTextBox);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.lastNameComboBox);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Name = "Form10";
            this.Text = "Form10";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proektDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proektDataSet2)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioButton1;
        private proektDataSet1 proektDataSet1;
        private System.Windows.Forms.BindingSource workersBindingSource;
        private proektDataSet1TableAdapters.WorkersTableAdapter workersTableAdapter;
        private proektDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox lastNameComboBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox middleNameTextBox;
        private System.Windows.Forms.TextBox departmentTextBox;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private proektDataSet2 proektDataSet2;
        private proektDataSet2TableAdapters.WorkersTableAdapter workersTableAdapter1;
        private proektDataSet2TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
    }
}