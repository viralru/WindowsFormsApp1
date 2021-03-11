
namespace WindowsFormsApp1
{
    partial class Form11
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
            System.Windows.Forms.Label loginLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label middleNameLabel;
            this.proektDataSet1 = new WindowsFormsApp1.proektDataSet1();
            this.workersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workersTableAdapter = new WindowsFormsApp1.proektDataSet1TableAdapters.WorkersTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.proektDataSet1TableAdapters.TableAdapterManager();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.middleNameTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            lastNameLabel = new System.Windows.Forms.Label();
            loginLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            middleNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.proektDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(100, 43);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(61, 13);
            lastNameLabel.TabIndex = 1;
            lastNameLabel.Text = "Last Name:";
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new System.Drawing.Point(125, 131);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new System.Drawing.Size(36, 13);
            loginLabel.TabIndex = 3;
            loginLabel.Text = "Login:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(105, 159);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(56, 13);
            passwordLabel.TabIndex = 5;
            passwordLabel.Text = "Password:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(101, 74);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(60, 13);
            firstNameLabel.TabIndex = 7;
            firstNameLabel.Text = "First Name:";
            // 
            // middleNameLabel
            // 
            middleNameLabel.AutoSize = true;
            middleNameLabel.Location = new System.Drawing.Point(89, 102);
            middleNameLabel.Name = "middleNameLabel";
            middleNameLabel.Size = new System.Drawing.Size(72, 13);
            middleNameLabel.TabIndex = 9;
            middleNameLabel.Text = "Middle Name:";
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
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workersBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(172, 43);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 2;
           
            // 
            // loginTextBox
            // 
            this.loginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workersBindingSource, "Login", true));
            this.loginTextBox.Location = new System.Drawing.Point(172, 128);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(100, 20);
            this.loginTextBox.TabIndex = 4;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workersBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(172, 156);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 6;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workersBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(172, 71);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextBox.TabIndex = 8;
            // 
            // middleNameTextBox
            // 
            this.middleNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workersBindingSource, "MiddleName", true));
            this.middleNameTextBox.Location = new System.Drawing.Point(172, 99);
            this.middleNameTextBox.Name = "middleNameTextBox";
            this.middleNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.middleNameTextBox.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Зарегистрироваться";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 353);
            this.Controls.Add(this.button1);
            this.Controls.Add(middleNameLabel);
            this.Controls.Add(this.middleNameTextBox);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(loginLabel);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Name = "Form11";
            this.Text = "Form11";
            this.Load += new System.EventHandler(this.Form11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proektDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private proektDataSet1 proektDataSet1;
        private System.Windows.Forms.BindingSource workersBindingSource;
        private proektDataSet1TableAdapters.WorkersTableAdapter workersTableAdapter;
        private proektDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox middleNameTextBox;
        private System.Windows.Forms.Button button1;
    }
}