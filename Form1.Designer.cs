namespace rest
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
            this.blyudoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restoranDataSet = new rest.RestoranDataSet();
            this.blyudoTableAdapter = new rest.RestoranDataSetTableAdapters.BlyudoTableAdapter();
            this.receptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restoranDataSet1 = new rest.RestoranDataSet1();
            this.receptTableAdapter = new rest.RestoranDataSet1TableAdapters.ReceptTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cenaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restoranDataSet2 = new rest.RestoranDataSet2();
            this.cenaTableAdapter = new rest.RestoranDataSet2TableAdapters.CenaTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.restoranDataSet3 = new rest.RestoranDataSet3();
            this.otcetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otcetTableAdapter = new rest.RestoranDataSet3TableAdapters.OtcetTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.restoranDataSet4 = new rest.RestoranDataSet4();
            this.blyudoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.blyudoTableAdapter1 = new rest.RestoranDataSet4TableAdapters.BlyudoTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.restoranDataSet5 = new rest.RestoranDataSet5();
            this.otcetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.otcetTableAdapter1 = new rest.RestoranDataSet5TableAdapters.OtcetTableAdapter();
            this.produktDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarixDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restoranDataSet6 = new rest.RestoranDataSet6();
            this.receptBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.receptTableAdapter1 = new rest.RestoranDataSet6TableAdapters.ReceptTableAdapter();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.restoranDataSet7 = new rest.RestoranDataSet7();
            this.receptBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.receptTableAdapter2 = new rest.RestoranDataSet7TableAdapters.ReceptTableAdapter();
            this.restoranDataSet8 = new rest.RestoranDataSet8();
            this.receptBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.receptTableAdapter3 = new rest.RestoranDataSet8TableAdapters.ReceptTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.blyudoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cenaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otcetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blyudoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otcetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // blyudoBindingSource
            // 
            this.blyudoBindingSource.DataMember = "Blyudo";
            this.blyudoBindingSource.DataSource = this.restoranDataSet;
            // 
            // restoranDataSet
            // 
            this.restoranDataSet.DataSetName = "RestoranDataSet";
            this.restoranDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // blyudoTableAdapter
            // 
            this.blyudoTableAdapter.ClearBeforeFill = true;
            // 
            // receptBindingSource
            // 
            this.receptBindingSource.DataMember = "Recept";
            this.receptBindingSource.DataSource = this.restoranDataSet1;
            // 
            // restoranDataSet1
            // 
            this.restoranDataSet1.DataSetName = "RestoranDataSet1";
            this.restoranDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // receptTableAdapter
            // 
            this.receptTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(537, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Porciya";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(612, 48);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(768, 48);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cenaBindingSource
            // 
            this.cenaBindingSource.DataMember = "Cena";
            this.cenaBindingSource.DataSource = this.restoranDataSet2;
            // 
            // restoranDataSet2
            // 
            this.restoranDataSet2.DataSetName = "RestoranDataSet2";
            this.restoranDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cenaTableAdapter
            // 
            this.cenaTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(542, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Produkt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(542, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cena";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(542, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kol";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(612, 94);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(613, 130);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(612, 163);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(768, 116);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 46);
            this.button2.TabIndex = 13;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(543, 203);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(768, 200);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 33);
            this.button3.TabIndex = 15;
            this.button3.Text = "Otcet";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // restoranDataSet3
            // 
            this.restoranDataSet3.DataSetName = "RestoranDataSet3";
            this.restoranDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // otcetBindingSource
            // 
            this.otcetBindingSource.DataMember = "Otcet";
            this.otcetBindingSource.DataSource = this.restoranDataSet3;
            // 
            // otcetTableAdapter
            // 
            this.otcetTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.blyudoBindingSource1;
            this.comboBox1.DisplayMember = "Blyudo";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(36, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(377, 24);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // restoranDataSet4
            // 
            this.restoranDataSet4.DataSetName = "RestoranDataSet4";
            this.restoranDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // blyudoBindingSource1
            // 
            this.blyudoBindingSource1.DataMember = "Blyudo";
            this.blyudoBindingSource1.DataSource = this.restoranDataSet4;
            // 
            // blyudoTableAdapter1
            // 
            this.blyudoTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.produktDataGridViewTextBoxColumn,
            this.cenaDataGridViewTextBoxColumn,
            this.kolDataGridViewTextBoxColumn,
            this.tarixDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.otcetBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(33, 303);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(550, 150);
            this.dataGridView1.TabIndex = 17;
            // 
            // restoranDataSet5
            // 
            this.restoranDataSet5.DataSetName = "RestoranDataSet5";
            this.restoranDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // otcetBindingSource1
            // 
            this.otcetBindingSource1.DataMember = "Otcet";
            this.otcetBindingSource1.DataSource = this.restoranDataSet5;
            // 
            // otcetTableAdapter1
            // 
            this.otcetTableAdapter1.ClearBeforeFill = true;
            // 
            // produktDataGridViewTextBoxColumn
            // 
            this.produktDataGridViewTextBoxColumn.DataPropertyName = "Produkt";
            this.produktDataGridViewTextBoxColumn.HeaderText = "Produkt";
            this.produktDataGridViewTextBoxColumn.Name = "produktDataGridViewTextBoxColumn";
            // 
            // cenaDataGridViewTextBoxColumn
            // 
            this.cenaDataGridViewTextBoxColumn.DataPropertyName = "Cena";
            this.cenaDataGridViewTextBoxColumn.HeaderText = "Cena";
            this.cenaDataGridViewTextBoxColumn.Name = "cenaDataGridViewTextBoxColumn";
            // 
            // kolDataGridViewTextBoxColumn
            // 
            this.kolDataGridViewTextBoxColumn.DataPropertyName = "Kol";
            this.kolDataGridViewTextBoxColumn.HeaderText = "Kol";
            this.kolDataGridViewTextBoxColumn.Name = "kolDataGridViewTextBoxColumn";
            // 
            // tarixDataGridViewTextBoxColumn
            // 
            this.tarixDataGridViewTextBoxColumn.DataPropertyName = "Tarix";
            this.tarixDataGridViewTextBoxColumn.HeaderText = "Tarix";
            this.tarixDataGridViewTextBoxColumn.Name = "tarixDataGridViewTextBoxColumn";
            // 
            // restoranDataSet6
            // 
            this.restoranDataSet6.DataSetName = "RestoranDataSet6";
            this.restoranDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // receptBindingSource1
            // 
            this.receptBindingSource1.DataMember = "Recept";
            this.receptBindingSource1.DataSource = this.restoranDataSet6;
            // 
            // receptTableAdapter1
            // 
            this.receptTableAdapter1.ClearBeforeFill = true;
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.receptBindingSource2;
            this.listBox1.DisplayMember = "Kol";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(247, 83);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(166, 132);
            this.listBox1.TabIndex = 18;
            // 
            // listBox2
            // 
            this.listBox2.DataSource = this.receptBindingSource3;
            this.listBox2.DisplayMember = "Produkt";
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(36, 83);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(156, 132);
            this.listBox2.TabIndex = 19;
            // 
            // restoranDataSet7
            // 
            this.restoranDataSet7.DataSetName = "RestoranDataSet7";
            this.restoranDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // receptBindingSource2
            // 
            this.receptBindingSource2.DataMember = "Recept";
            this.receptBindingSource2.DataSource = this.restoranDataSet7;
            // 
            // receptTableAdapter2
            // 
            this.receptTableAdapter2.ClearBeforeFill = true;
            // 
            // restoranDataSet8
            // 
            this.restoranDataSet8.DataSetName = "RestoranDataSet8";
            this.restoranDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // receptBindingSource3
            // 
            this.receptBindingSource3.DataMember = "Recept";
            this.receptBindingSource3.DataSource = this.restoranDataSet8;
            // 
            // receptTableAdapter3
            // 
            this.receptTableAdapter3.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 604);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.blyudoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cenaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otcetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blyudoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otcetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RestoranDataSet restoranDataSet;
        private System.Windows.Forms.BindingSource blyudoBindingSource;
        private RestoranDataSetTableAdapters.BlyudoTableAdapter blyudoTableAdapter;
        private RestoranDataSet1 restoranDataSet1;
        private System.Windows.Forms.BindingSource receptBindingSource;
        private RestoranDataSet1TableAdapters.ReceptTableAdapter receptTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private RestoranDataSet2 restoranDataSet2;
        private System.Windows.Forms.BindingSource cenaBindingSource;
        private RestoranDataSet2TableAdapters.CenaTableAdapter cenaTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button3;
        private RestoranDataSet3 restoranDataSet3;
        private System.Windows.Forms.BindingSource otcetBindingSource;
        private RestoranDataSet3TableAdapters.OtcetTableAdapter otcetTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private RestoranDataSet4 restoranDataSet4;
        private System.Windows.Forms.BindingSource blyudoBindingSource1;
        private RestoranDataSet4TableAdapters.BlyudoTableAdapter blyudoTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private RestoranDataSet5 restoranDataSet5;
        private System.Windows.Forms.BindingSource otcetBindingSource1;
        private RestoranDataSet5TableAdapters.OtcetTableAdapter otcetTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn produktDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarixDataGridViewTextBoxColumn;
        private RestoranDataSet6 restoranDataSet6;
        private System.Windows.Forms.BindingSource receptBindingSource1;
        private RestoranDataSet6TableAdapters.ReceptTableAdapter receptTableAdapter1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private RestoranDataSet7 restoranDataSet7;
        private System.Windows.Forms.BindingSource receptBindingSource2;
        private RestoranDataSet7TableAdapters.ReceptTableAdapter receptTableAdapter2;
        private RestoranDataSet8 restoranDataSet8;
        private System.Windows.Forms.BindingSource receptBindingSource3;
        private RestoranDataSet8TableAdapters.ReceptTableAdapter receptTableAdapter3;
    }
}

