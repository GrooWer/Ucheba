
namespace WindowsFormsApp1
{
    partial class Form5
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idRealtorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shareOfComissionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.realtorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.session_1DataSet2 = new WindowsFormsApp1.Session_1DataSet2();
            this.realtorTableAdapter = new WindowsFormsApp1.Session_1DataSet2TableAdapters.RealtorTableAdapter();
            this.session_1DataSet3 = new WindowsFormsApp1.Session_1DataSet3();
            this.realtorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.realtorTableAdapter1 = new WindowsFormsApp1.Session_1DataSet3TableAdapters.RealtorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.realtorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.session_1DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.session_1DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.realtorBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(310, 281);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(590, 281);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRealtorDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.shareOfComissionDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.realtorBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(742, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // idRealtorDataGridViewTextBoxColumn
            // 
            this.idRealtorDataGridViewTextBoxColumn.DataPropertyName = "Id_Realtor";
            this.idRealtorDataGridViewTextBoxColumn.HeaderText = "Id_Realtor";
            this.idRealtorDataGridViewTextBoxColumn.Name = "idRealtorDataGridViewTextBoxColumn";
            this.idRealtorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "First_Name";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First_Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "Last_Name";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last_Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // shareOfComissionDataGridViewTextBoxColumn
            // 
            this.shareOfComissionDataGridViewTextBoxColumn.DataPropertyName = "Share_Of_Comission";
            this.shareOfComissionDataGridViewTextBoxColumn.HeaderText = "Share_Of_Comission";
            this.shareOfComissionDataGridViewTextBoxColumn.Name = "shareOfComissionDataGridViewTextBoxColumn";
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
            // realtorBindingSource
            // 
            this.realtorBindingSource.DataMember = "Realtor";
            this.realtorBindingSource.DataSource = this.session_1DataSet2;
            // 
            // session_1DataSet2
            // 
            this.session_1DataSet2.DataSetName = "Session_1DataSet2";
            this.session_1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // realtorTableAdapter
            // 
            this.realtorTableAdapter.ClearBeforeFill = true;
            // 
            // session_1DataSet3
            // 
            this.session_1DataSet3.DataSetName = "Session_1DataSet3";
            this.session_1DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // realtorBindingSource1
            // 
            this.realtorBindingSource1.DataMember = "Realtor";
            this.realtorBindingSource1.DataSource = this.session_1DataSet3;
            // 
            // realtorTableAdapter1
            // 
            this.realtorTableAdapter1.ClearBeforeFill = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.realtorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.session_1DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.session_1DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.realtorBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Session_1DataSet2 session_1DataSet2;
        private System.Windows.Forms.BindingSource realtorBindingSource;
        private Session_1DataSet2TableAdapters.RealtorTableAdapter realtorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRealtorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shareOfComissionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private Session_1DataSet3 session_1DataSet3;
        private System.Windows.Forms.BindingSource realtorBindingSource1;
        private Session_1DataSet3TableAdapters.RealtorTableAdapter realtorTableAdapter1;
    }
}