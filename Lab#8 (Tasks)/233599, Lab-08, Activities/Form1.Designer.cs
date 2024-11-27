namespace Activity_01_Lab
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cname = new System.Windows.Forms.TextBox();
            this.combo_country = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radio_female = new System.Windows.Forms.RadioButton();
            this.radio_Male = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radio_unmarried = new System.Windows.Forms.RadioButton();
            this.radio_married = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.chk_reading = new System.Windows.Forms.CheckBox();
            this.chk_painting = new System.Windows.Forms.CheckBox();
            this.btn_preview = new System.Windows.Forms.Button();
            this.dtgCustomer = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.customerDB1DataSet = new Activity_01_Lab.CustomerDB1DataSet();
            this.table1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_1TableAdapter = new Activity_01_Lab.CustomerDB1DataSetTableAdapters.Table_1TableAdapter();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hobbyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marriedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDB1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Country";
            // 
            // txt_cname
            // 
            this.txt_cname.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cname.Location = new System.Drawing.Point(173, 26);
            this.txt_cname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_cname.Name = "txt_cname";
            this.txt_cname.Size = new System.Drawing.Size(160, 22);
            this.txt_cname.TabIndex = 2;
            // 
            // combo_country
            // 
            this.combo_country.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_country.FormattingEnabled = true;
            this.combo_country.Location = new System.Drawing.Point(173, 71);
            this.combo_country.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combo_country.Name = "combo_country";
            this.combo_country.Size = new System.Drawing.Size(160, 24);
            this.combo_country.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio_female);
            this.groupBox1.Controls.Add(this.radio_Male);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(42, 126);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(291, 65);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // radio_female
            // 
            this.radio_female.AutoSize = true;
            this.radio_female.Location = new System.Drawing.Point(144, 23);
            this.radio_female.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radio_female.Name = "radio_female";
            this.radio_female.Size = new System.Drawing.Size(80, 20);
            this.radio_female.TabIndex = 1;
            this.radio_female.TabStop = true;
            this.radio_female.Text = "Female";
            this.radio_female.UseVisualStyleBackColor = true;
            // 
            // radio_Male
            // 
            this.radio_Male.AutoSize = true;
            this.radio_Male.Location = new System.Drawing.Point(23, 23);
            this.radio_Male.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radio_Male.Name = "radio_Male";
            this.radio_Male.Size = new System.Drawing.Size(62, 20);
            this.radio_Male.TabIndex = 0;
            this.radio_Male.TabStop = true;
            this.radio_Male.Text = "Male";
            this.radio_Male.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radio_unmarried);
            this.groupBox2.Controls.Add(this.radio_married);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(42, 277);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(291, 65);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Status";
            // 
            // radio_unmarried
            // 
            this.radio_unmarried.AutoSize = true;
            this.radio_unmarried.Location = new System.Drawing.Point(144, 23);
            this.radio_unmarried.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radio_unmarried.Name = "radio_unmarried";
            this.radio_unmarried.Size = new System.Drawing.Size(100, 20);
            this.radio_unmarried.TabIndex = 1;
            this.radio_unmarried.TabStop = true;
            this.radio_unmarried.Text = "UnMarried";
            this.radio_unmarried.UseVisualStyleBackColor = true;
            // 
            // radio_married
            // 
            this.radio_married.AutoSize = true;
            this.radio_married.Location = new System.Drawing.Point(23, 23);
            this.radio_married.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radio_married.Name = "radio_married";
            this.radio_married.Size = new System.Drawing.Size(81, 20);
            this.radio_married.TabIndex = 0;
            this.radio_married.TabStop = true;
            this.radio_married.Text = "Married";
            this.radio_married.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 234);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hobby";
            // 
            // chk_reading
            // 
            this.chk_reading.AutoSize = true;
            this.chk_reading.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_reading.Location = new System.Drawing.Point(105, 233);
            this.chk_reading.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chk_reading.Name = "chk_reading";
            this.chk_reading.Size = new System.Drawing.Size(88, 20);
            this.chk_reading.TabIndex = 7;
            this.chk_reading.Text = "Reading";
            this.chk_reading.UseVisualStyleBackColor = true;
            // 
            // chk_painting
            // 
            this.chk_painting.AutoSize = true;
            this.chk_painting.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_painting.Location = new System.Drawing.Point(220, 234);
            this.chk_painting.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chk_painting.Name = "chk_painting";
            this.chk_painting.Size = new System.Drawing.Size(85, 20);
            this.chk_painting.TabIndex = 8;
            this.chk_painting.Text = "Painting";
            this.chk_painting.UseVisualStyleBackColor = true;
            // 
            // btn_preview
            // 
            this.btn_preview.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_preview.Location = new System.Drawing.Point(37, 359);
            this.btn_preview.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(129, 39);
            this.btn_preview.TabIndex = 9;
            this.btn_preview.Text = "Preview";
            this.btn_preview.UseVisualStyleBackColor = true;
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
            // 
            // dtgCustomer
            // 
            this.dtgCustomer.AutoGenerateColumns = false;
            this.dtgCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerNameDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.hobbyDataGridViewTextBoxColumn,
            this.marriedDataGridViewTextBoxColumn});
            this.dtgCustomer.DataSource = this.table1BindingSource;
            this.dtgCustomer.Location = new System.Drawing.Point(379, 26);
            this.dtgCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgCustomer.Name = "dtgCustomer";
            this.dtgCustomer.RowHeadersWidth = 51;
            this.dtgCustomer.Size = new System.Drawing.Size(652, 362);
            this.dtgCustomer.TabIndex = 10;
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(186, 359);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(134, 39);
            this.btn_add.TabIndex = 11;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(118, 418);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(118, 44);
            this.btn_delete.TabIndex = 12;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // customerDB1DataSet
            // 
            this.customerDB1DataSet.DataSetName = "CustomerDB1DataSet";
            this.customerDB1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table1BindingSource
            // 
            this.table1BindingSource.DataMember = "Table_1";
            this.table1BindingSource.DataSource = this.customerDB1DataSet;
            // 
            // table_1TableAdapter
            // 
            this.table_1TableAdapter.ClearBeforeFill = true;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Country";
            this.countryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            this.countryDataGridViewTextBoxColumn.Width = 125;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.Width = 125;
            // 
            // hobbyDataGridViewTextBoxColumn
            // 
            this.hobbyDataGridViewTextBoxColumn.DataPropertyName = "Hobby";
            this.hobbyDataGridViewTextBoxColumn.HeaderText = "Hobby";
            this.hobbyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hobbyDataGridViewTextBoxColumn.Name = "hobbyDataGridViewTextBoxColumn";
            this.hobbyDataGridViewTextBoxColumn.Width = 125;
            // 
            // marriedDataGridViewTextBoxColumn
            // 
            this.marriedDataGridViewTextBoxColumn.DataPropertyName = "Married";
            this.marriedDataGridViewTextBoxColumn.HeaderText = "Married";
            this.marriedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.marriedDataGridViewTextBoxColumn.Name = "marriedDataGridViewTextBoxColumn";
            this.marriedDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 531);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dtgCustomer);
            this.Controls.Add(this.btn_preview);
            this.Controls.Add(this.chk_painting);
            this.Controls.Add(this.chk_reading);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.combo_country);
            this.Controls.Add(this.txt_cname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "v";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDB1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_cname;
        private System.Windows.Forms.ComboBox combo_country;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radio_female;
        private System.Windows.Forms.RadioButton radio_Male;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radio_unmarried;
        private System.Windows.Forms.RadioButton radio_married;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chk_reading;
        private System.Windows.Forms.CheckBox chk_painting;
        private System.Windows.Forms.Button btn_preview;
        private System.Windows.Forms.DataGridView dtgCustomer;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private CustomerDB1DataSet customerDB1DataSet;
        private System.Windows.Forms.BindingSource table1BindingSource;
        private CustomerDB1DataSetTableAdapters.Table_1TableAdapter table_1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hobbyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marriedDataGridViewTextBoxColumn;
    }
}

