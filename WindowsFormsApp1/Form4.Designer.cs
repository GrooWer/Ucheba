
namespace WindowsFormsApp1
{
    partial class Form4
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idКлиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерТелефонаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.электронаяПочтаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.клиентBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.session1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.session_1DataSet = new WindowsFormsApp1.Session_1DataSet();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.session_1DataSet1 = new WindowsFormsApp1.Session_1DataSet1();
            this.clientTableAdapter = new WindowsFormsApp1.Session_1DataSet1TableAdapters.ClientTableAdapter();
            this.клиентTableAdapter = new WindowsFormsApp1.Session_1DataSetTableAdapters.КлиентTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.session1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.session_1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.session_1DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idКлиентаDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.номерТелефонаDataGridViewTextBoxColumn,
            this.электронаяПочтаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.клиентBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 197);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idКлиентаDataGridViewTextBoxColumn
            // 
            this.idКлиентаDataGridViewTextBoxColumn.DataPropertyName = "Id_Клиента";
            this.idКлиентаDataGridViewTextBoxColumn.HeaderText = "Id_Клиента";
            this.idКлиентаDataGridViewTextBoxColumn.Name = "idКлиентаDataGridViewTextBoxColumn";
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            // 
            // номерТелефонаDataGridViewTextBoxColumn
            // 
            this.номерТелефонаDataGridViewTextBoxColumn.DataPropertyName = "Номер_Телефона";
            this.номерТелефонаDataGridViewTextBoxColumn.HeaderText = "Номер_Телефона";
            this.номерТелефонаDataGridViewTextBoxColumn.Name = "номерТелефонаDataGridViewTextBoxColumn";
            // 
            // электронаяПочтаDataGridViewTextBoxColumn
            // 
            this.электронаяПочтаDataGridViewTextBoxColumn.DataPropertyName = "Электроная_Почта";
            this.электронаяПочтаDataGridViewTextBoxColumn.HeaderText = "Электроная_Почта";
            this.электронаяПочтаDataGridViewTextBoxColumn.Name = "электронаяПочтаDataGridViewTextBoxColumn";
            // 
            // клиентBindingSource
            // 
            this.клиентBindingSource.DataMember = "Клиент";
            this.клиентBindingSource.DataSource = this.session1DataSetBindingSource;
            // 
            // session1DataSetBindingSource
            // 
            this.session1DataSetBindingSource.DataSource = this.session_1DataSet;
            this.session1DataSetBindingSource.Position = 0;
            // 
            // session_1DataSet
            // 
            this.session_1DataSet.DataSetName = "Session_1DataSet";
            this.session_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.session_1DataSet1;
            // 
            // session_1DataSet1
            // 
            this.session_1DataSet1.DataSetName = "Session_1DataSet1";
            this.session_1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // клиентTableAdapter
            // 
            this.клиентTableAdapter.ClearBeforeFill = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.session1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.session_1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.session_1DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource session1DataSetBindingSource;
        private Session_1DataSet session_1DataSet;
        private Session_1DataSet1 session_1DataSet1;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private Session_1DataSet1TableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.BindingSource клиентBindingSource;
        private Session_1DataSetTableAdapters.КлиентTableAdapter клиентTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idКлиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерТелефонаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn электронаяПочтаDataGridViewTextBoxColumn;
    }
}