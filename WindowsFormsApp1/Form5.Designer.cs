
namespace WindowsFormsApp1
{
    partial class Form5
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.proektDataSet = new WindowsFormsApp1.proektDataSet();
            this.proektDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vacationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vacationTableAdapter = new WindowsFormsApp1.proektDataSetTableAdapters.VacationTableAdapter();
            this.proektDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.proektDataSet1 = new WindowsFormsApp1.proektDataSet1();
            this.vacationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vacationsTableAdapter = new WindowsFormsApp1.proektDataSet1TableAdapters.VacationsTableAdapter();
            this.workersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workersTableAdapter = new WindowsFormsApp1.proektDataSet1TableAdapters.WorkersTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.proektDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proektDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proektDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proektDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.workersBindingSource;
            this.comboBox1.DisplayMember = "LastName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(544, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(147, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "FirstName";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(505, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Кому";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(505, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Тема:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(544, 215);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(147, 96);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(62, 218);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(290, 96);
            this.richTextBox2.TabIndex = 8;
            this.richTextBox2.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Комментарий";
            // 
            // proektDataSet
            // 
            this.proektDataSet.DataSetName = "proektDataSet";
            this.proektDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proektDataSetBindingSource
            // 
            this.proektDataSetBindingSource.DataSource = this.proektDataSet;
            this.proektDataSetBindingSource.Position = 0;
            // 
            // vacationBindingSource
            // 
            this.vacationBindingSource.DataMember = "Vacation";
            this.vacationBindingSource.DataSource = this.proektDataSetBindingSource;
            // 
            // vacationTableAdapter
            // 
            this.vacationTableAdapter.ClearBeforeFill = true;
            // 
            // proektDataSetBindingSource1
            // 
            this.proektDataSetBindingSource1.DataSource = this.proektDataSet;
            this.proektDataSetBindingSource1.Position = 0;
            // 
            // proektDataSet1
            // 
            this.proektDataSet1.DataSetName = "proektDataSet1";
            this.proektDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vacationsBindingSource
            // 
            this.vacationsBindingSource.DataMember = "Vacations";
            this.vacationsBindingSource.DataSource = this.proektDataSet1;
            // 
            // vacationsTableAdapter
            // 
            this.vacationsTableAdapter.ClearBeforeFill = true;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(62, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(167, 402);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(277, 402);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "Отправить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form5";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proektDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proektDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proektDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proektDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource proektDataSetBindingSource;
        private proektDataSet proektDataSet;
        private System.Windows.Forms.BindingSource vacationBindingSource;
        private proektDataSetTableAdapters.VacationTableAdapter vacationTableAdapter;
        private System.Windows.Forms.BindingSource proektDataSetBindingSource1;
        private proektDataSet1 proektDataSet1;
        private System.Windows.Forms.BindingSource vacationsBindingSource;
        private proektDataSet1TableAdapters.VacationsTableAdapter vacationsTableAdapter;
        private System.Windows.Forms.BindingSource workersBindingSource;
        private proektDataSet1TableAdapters.WorkersTableAdapter workersTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

