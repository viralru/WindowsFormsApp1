
namespace WindowsFormsApp1
{
    partial class Form9
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
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label loginLabel1;
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.proektDataSet1 = new WindowsFormsApp1.proektDataSet1();
            this.workersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workersTableAdapter = new WindowsFormsApp1.proektDataSet1TableAdapters.WorkersTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.proektDataSet1TableAdapters.TableAdapterManager();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.workersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.proektDataSet2 = new WindowsFormsApp1.proektDataSet2();
            this.workersTableAdapter1 = new WindowsFormsApp1.proektDataSet2TableAdapters.WorkersTableAdapter();
            this.tableAdapterManager1 = new WindowsFormsApp1.proektDataSet2TableAdapters.TableAdapterManager();
            this.accessGroupsTableAdapter1 = new WindowsFormsApp1.proektDataSet1TableAdapters.AccessGroupsTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            passwordLabel = new System.Windows.Forms.Label();
            loginLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.proektDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proektDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(52, 112);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(56, 13);
            passwordLabel.TabIndex = 7;
            passwordLabel.Text = "Password:";
            // 
            // loginLabel1
            // 
            loginLabel1.AutoSize = true;
            loginLabel1.Location = new System.Drawing.Point(72, 61);
            loginLabel1.Name = "loginLabel1";
            loginLabel1.Size = new System.Drawing.Size(36, 13);
            loginLabel1.TabIndex = 9;
            loginLabel1.Text = "Login:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(192, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Вход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(282, 144);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(91, 13);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Забыли пароль?";
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(142, 109);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 9;
            // 
            // workersBindingSource1
            // 
            this.workersBindingSource1.DataMember = "Workers";
            this.workersBindingSource1.DataSource = this.proektDataSet2;
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
            // accessGroupsTableAdapter1
            // 
            this.accessGroupsTableAdapter1.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button2.Location = new System.Drawing.Point(-1, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(251, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Вход";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(256, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(254, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Регистрация";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 245);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(loginLabel1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button1);
            this.Name = "Form9";
            this.Text = "Вход";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proektDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proektDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private proektDataSet1 proektDataSet1;
        private System.Windows.Forms.BindingSource workersBindingSource;
        private proektDataSet1TableAdapters.WorkersTableAdapter workersTableAdapter;
        private proektDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox textBox2;
        private proektDataSet2 proektDataSet2;
        private System.Windows.Forms.BindingSource workersBindingSource1;
        private proektDataSet2TableAdapters.WorkersTableAdapter workersTableAdapter1;
        private proektDataSet2TableAdapters.TableAdapterManager tableAdapterManager1;
        private proektDataSet1TableAdapters.AccessGroupsTableAdapter accessGroupsTableAdapter1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}