namespace Bajnokok_Ligája
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.csapatok_tabControl = new System.Windows.Forms.TabControl();
            this.csapatok_tabPage = new System.Windows.Forms.TabPage();
            this.csoportok_tabPage = new System.Windows.Forms.TabPage();
            this.Bajnokok_Ligaja_dataset = new System.Data.DataSet();
            this.Csoportok = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.Csapatok = new System.Data.DataTable();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.Meccsek = new System.Data.DataTable();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.dataColumn8 = new System.Data.DataColumn();
            this.dataColumn9 = new System.Data.DataColumn();
            this.dataColumn10 = new System.Data.DataColumn();
            this.Csoportok_bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exit_btn = new System.Windows.Forms.Button();
            this.csoportok_dataGridView = new System.Windows.Forms.DataGridView();
            this.csoportnevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.csapatok_dataGridView = new System.Windows.Forms.DataGridView();
            this.Csapatok_bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.csapatokhoz_csoport_bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.csapatidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.csapatnevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Csoport = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.csoportidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meccsek_tabPage = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.meccsek_bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.meccsekhez_csapatok_bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.meccsekhez_csapat2_bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Hazai_Csapat_Neve = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.gol1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.csapat2idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vendeg_Csapat_Neve = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.gol2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filter_comboBox = new System.Windows.Forms.ComboBox();
            this.csapatok_filter_bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.csapatok_tabControl.SuspendLayout();
            this.csapatok_tabPage.SuspendLayout();
            this.csoportok_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bajnokok_Ligaja_dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Csoportok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Csapatok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Meccsek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Csoportok_bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.csoportok_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.csapatok_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Csapatok_bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.csapatokhoz_csoport_bindingSource)).BeginInit();
            this.meccsek_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meccsek_bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meccsekhez_csapatok_bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meccsekhez_csapat2_bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.csapatok_filter_bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // csapatok_tabControl
            // 
            this.csapatok_tabControl.Controls.Add(this.csapatok_tabPage);
            this.csapatok_tabControl.Controls.Add(this.csoportok_tabPage);
            this.csapatok_tabControl.Controls.Add(this.meccsek_tabPage);
            this.csapatok_tabControl.Location = new System.Drawing.Point(12, 12);
            this.csapatok_tabControl.Name = "csapatok_tabControl";
            this.csapatok_tabControl.SelectedIndex = 0;
            this.csapatok_tabControl.Size = new System.Drawing.Size(776, 426);
            this.csapatok_tabControl.TabIndex = 0;
            // 
            // csapatok_tabPage
            // 
            this.csapatok_tabPage.BackColor = System.Drawing.Color.White;
            this.csapatok_tabPage.Controls.Add(this.filter_comboBox);
            this.csapatok_tabPage.Controls.Add(this.csapatok_dataGridView);
            this.csapatok_tabPage.Location = new System.Drawing.Point(4, 22);
            this.csapatok_tabPage.Name = "csapatok_tabPage";
            this.csapatok_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.csapatok_tabPage.Size = new System.Drawing.Size(768, 400);
            this.csapatok_tabPage.TabIndex = 0;
            this.csapatok_tabPage.Text = "Csapatok";
            // 
            // csoportok_tabPage
            // 
            this.csoportok_tabPage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.csoportok_tabPage.Controls.Add(this.csoportok_dataGridView);
            this.csoportok_tabPage.Location = new System.Drawing.Point(4, 22);
            this.csoportok_tabPage.Name = "csoportok_tabPage";
            this.csoportok_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.csoportok_tabPage.Size = new System.Drawing.Size(768, 400);
            this.csoportok_tabPage.TabIndex = 1;
            this.csoportok_tabPage.Text = "Csoportok";
            // 
            // Bajnokok_Ligaja_dataset
            // 
            this.Bajnokok_Ligaja_dataset.DataSetName = "NewDataSet";
            this.Bajnokok_Ligaja_dataset.Tables.AddRange(new System.Data.DataTable[] {
            this.Csoportok,
            this.Csapatok,
            this.Meccsek});
            // 
            // Csoportok
            // 
            this.Csoportok.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2});
            this.Csoportok.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Csoport_PK", new string[] {
                        "Csoport_id"}, true)});
            this.Csoportok.PrimaryKey = new System.Data.DataColumn[] {
        this.dataColumn1};
            this.Csoportok.TableName = "Csoportok";
            // 
            // dataColumn1
            // 
            this.dataColumn1.AllowDBNull = false;
            this.dataColumn1.AutoIncrement = true;
            this.dataColumn1.Caption = "Csoport_id";
            this.dataColumn1.ColumnName = "Csoport_id";
            this.dataColumn1.DataType = typeof(int);
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "Csoport_nev";
            this.dataColumn2.DefaultValue = "-";
            // 
            // Csapatok
            // 
            this.Csapatok.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5});
            this.Csapatok.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Csapatok_PK", new string[] {
                        "Csapat_id"}, true)});
            this.Csapatok.PrimaryKey = new System.Data.DataColumn[] {
        this.dataColumn3};
            this.Csapatok.TableName = "Csapatok";
            // 
            // dataColumn3
            // 
            this.dataColumn3.AllowDBNull = false;
            this.dataColumn3.AutoIncrement = true;
            this.dataColumn3.ColumnName = "Csapat_id";
            this.dataColumn3.DataType = typeof(int);
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "Csapat_nev";
            this.dataColumn4.DefaultValue = "-";
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "Csoport_id";
            this.dataColumn5.DataType = typeof(int);
            this.dataColumn5.DefaultValue = 0;
            // 
            // Meccsek
            // 
            this.Meccsek.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn6,
            this.dataColumn7,
            this.dataColumn8,
            this.dataColumn9,
            this.dataColumn10});
            this.Meccsek.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Meccsek_PK", new string[] {
                        "Meccs_id"}, true)});
            this.Meccsek.PrimaryKey = new System.Data.DataColumn[] {
        this.dataColumn6};
            this.Meccsek.TableName = "Meccsek";
            // 
            // dataColumn6
            // 
            this.dataColumn6.AllowDBNull = false;
            this.dataColumn6.AutoIncrement = true;
            this.dataColumn6.ColumnName = "Meccs_id";
            this.dataColumn6.DataType = typeof(int);
            // 
            // dataColumn7
            // 
            this.dataColumn7.ColumnName = "Csapat1_id";
            this.dataColumn7.DataType = typeof(int);
            this.dataColumn7.DefaultValue = "0";
            // 
            // dataColumn8
            // 
            this.dataColumn8.ColumnName = "Csapat2_id";
            this.dataColumn8.DataType = typeof(int);
            this.dataColumn8.DefaultValue = "0";
            // 
            // dataColumn9
            // 
            this.dataColumn9.ColumnName = "Gol1";
            this.dataColumn9.DataType = typeof(int);
            this.dataColumn9.DefaultValue = "0";
            // 
            // dataColumn10
            // 
            this.dataColumn10.ColumnName = "Gol2";
            this.dataColumn10.DataType = typeof(int);
            this.dataColumn10.DefaultValue = 0;
            // 
            // Csoportok_bindingSource
            // 
            this.Csoportok_bindingSource.DataMember = "Csoportok";
            this.Csoportok_bindingSource.DataSource = this.Bajnokok_Ligaja_dataset;
            this.Csoportok_bindingSource.Filter = "csoport_id > 0";
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(767, 3);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(30, 25);
            this.exit_btn.TabIndex = 1;
            this.exit_btn.Text = "X";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // csoportok_dataGridView
            // 
            this.csoportok_dataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.csoportok_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.csoportok_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.csoportok_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.csoportnevDataGridViewTextBoxColumn});
            this.csoportok_dataGridView.DataSource = this.Csoportok_bindingSource;
            this.csoportok_dataGridView.Location = new System.Drawing.Point(20, 20);
            this.csoportok_dataGridView.Name = "csoportok_dataGridView";
            this.csoportok_dataGridView.RowHeadersVisible = false;
            this.csoportok_dataGridView.Size = new System.Drawing.Size(192, 335);
            this.csoportok_dataGridView.TabIndex = 0;
            // 
            // csoportnevDataGridViewTextBoxColumn
            // 
            this.csoportnevDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.csoportnevDataGridViewTextBoxColumn.DataPropertyName = "Csoport_nev";
            this.csoportnevDataGridViewTextBoxColumn.HeaderText = "Csoport Név";
            this.csoportnevDataGridViewTextBoxColumn.Name = "csoportnevDataGridViewTextBoxColumn";
            // 
            // csapatok_dataGridView
            // 
            this.csapatok_dataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.csapatok_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.csapatok_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.csapatok_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.csapatidDataGridViewTextBoxColumn,
            this.csapatnevDataGridViewTextBoxColumn,
            this.Csoport,
            this.csoportidDataGridViewTextBoxColumn});
            this.csapatok_dataGridView.DataSource = this.Csapatok_bindingSource;
            this.csapatok_dataGridView.Location = new System.Drawing.Point(27, 66);
            this.csapatok_dataGridView.Name = "csapatok_dataGridView";
            this.csapatok_dataGridView.RowHeadersVisible = false;
            this.csapatok_dataGridView.Size = new System.Drawing.Size(204, 305);
            this.csapatok_dataGridView.TabIndex = 0;
            // 
            // Csapatok_bindingSource
            // 
            this.Csapatok_bindingSource.DataMember = "Csapatok";
            this.Csapatok_bindingSource.DataSource = this.Bajnokok_Ligaja_dataset;
            this.Csapatok_bindingSource.Filter = "csapat_id > 0";
            // 
            // csapatokhoz_csoport_bindingSource
            // 
            this.csapatokhoz_csoport_bindingSource.DataMember = "Csoportok";
            this.csapatokhoz_csoport_bindingSource.DataSource = this.Bajnokok_Ligaja_dataset;
            // 
            // csapatidDataGridViewTextBoxColumn
            // 
            this.csapatidDataGridViewTextBoxColumn.DataPropertyName = "Csapat_id";
            this.csapatidDataGridViewTextBoxColumn.HeaderText = "Csapat_id";
            this.csapatidDataGridViewTextBoxColumn.Name = "csapatidDataGridViewTextBoxColumn";
            this.csapatidDataGridViewTextBoxColumn.Visible = false;
            // 
            // csapatnevDataGridViewTextBoxColumn
            // 
            this.csapatnevDataGridViewTextBoxColumn.DataPropertyName = "Csapat_nev";
            this.csapatnevDataGridViewTextBoxColumn.HeaderText = "Csapat Név";
            this.csapatnevDataGridViewTextBoxColumn.Name = "csapatnevDataGridViewTextBoxColumn";
            // 
            // Csoport
            // 
            this.Csoport.DataPropertyName = "Csoport_id";
            this.Csoport.DataSource = this.csapatokhoz_csoport_bindingSource;
            this.Csoport.DisplayMember = "Csoport_nev";
            this.Csoport.HeaderText = "Csoport";
            this.Csoport.Name = "Csoport";
            this.Csoport.ValueMember = "Csoport_id";
            // 
            // csoportidDataGridViewTextBoxColumn
            // 
            this.csoportidDataGridViewTextBoxColumn.DataPropertyName = "Csoport_id";
            this.csoportidDataGridViewTextBoxColumn.HeaderText = "Csoport_id";
            this.csoportidDataGridViewTextBoxColumn.Name = "csoportidDataGridViewTextBoxColumn";
            this.csoportidDataGridViewTextBoxColumn.Visible = false;
            // 
            // meccsek_tabPage
            // 
            this.meccsek_tabPage.BackColor = System.Drawing.Color.White;
            this.meccsek_tabPage.Controls.Add(this.dataGridView1);
            this.meccsek_tabPage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.meccsek_tabPage.Location = new System.Drawing.Point(4, 22);
            this.meccsek_tabPage.Name = "meccsek_tabPage";
            this.meccsek_tabPage.Size = new System.Drawing.Size(768, 400);
            this.meccsek_tabPage.TabIndex = 2;
            this.meccsek_tabPage.Text = "Meccsek";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Hazai_Csapat_Neve,
            this.gol1DataGridViewTextBoxColumn,
            this.csapat2idDataGridViewTextBoxColumn,
            this.Vendeg_Csapat_Neve,
            this.gol2DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.meccsek_bindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(548, 376);
            this.dataGridView1.TabIndex = 0;
            // 
            // meccsek_bindingSource
            // 
            this.meccsek_bindingSource.DataMember = "Meccsek";
            this.meccsek_bindingSource.DataSource = this.Bajnokok_Ligaja_dataset;
            this.meccsek_bindingSource.Filter = "Meccs_id> 0";
            // 
            // meccsekhez_csapatok_bindingSource
            // 
            this.meccsekhez_csapatok_bindingSource.DataMember = "Csapatok";
            this.meccsekhez_csapatok_bindingSource.DataSource = this.Bajnokok_Ligaja_dataset;
            this.meccsekhez_csapatok_bindingSource.Filter = "";
            // 
            // meccsekhez_csapat2_bindingSource
            // 
            this.meccsekhez_csapat2_bindingSource.DataMember = "Csapatok";
            this.meccsekhez_csapat2_bindingSource.DataSource = this.Bajnokok_Ligaja_dataset;
            // 
            // Hazai_Csapat_Neve
            // 
            this.Hazai_Csapat_Neve.DataPropertyName = "Csapat1_id";
            this.Hazai_Csapat_Neve.DataSource = this.meccsekhez_csapatok_bindingSource;
            this.Hazai_Csapat_Neve.DisplayMember = "Csapat_nev";
            this.Hazai_Csapat_Neve.HeaderText = "Hazai Csapat Neve";
            this.Hazai_Csapat_Neve.Name = "Hazai_Csapat_Neve";
            this.Hazai_Csapat_Neve.ValueMember = "Csapat_id";
            // 
            // gol1DataGridViewTextBoxColumn
            // 
            this.gol1DataGridViewTextBoxColumn.DataPropertyName = "Gol1";
            this.gol1DataGridViewTextBoxColumn.HeaderText = "Hazai Csapat Góljai";
            this.gol1DataGridViewTextBoxColumn.Name = "gol1DataGridViewTextBoxColumn";
            // 
            // csapat2idDataGridViewTextBoxColumn
            // 
            this.csapat2idDataGridViewTextBoxColumn.DataPropertyName = "Csapat2_id";
            this.csapat2idDataGridViewTextBoxColumn.HeaderText = "Csapat2_id";
            this.csapat2idDataGridViewTextBoxColumn.Name = "csapat2idDataGridViewTextBoxColumn";
            this.csapat2idDataGridViewTextBoxColumn.Visible = false;
            // 
            // Vendeg_Csapat_Neve
            // 
            this.Vendeg_Csapat_Neve.DataPropertyName = "Csapat2_id";
            this.Vendeg_Csapat_Neve.DataSource = this.meccsekhez_csapat2_bindingSource;
            this.Vendeg_Csapat_Neve.DisplayMember = "Csapat_nev";
            this.Vendeg_Csapat_Neve.HeaderText = "Vendég Csapat Neve";
            this.Vendeg_Csapat_Neve.Name = "Vendeg_Csapat_Neve";
            this.Vendeg_Csapat_Neve.ValueMember = "Csapat_id";
            // 
            // gol2DataGridViewTextBoxColumn
            // 
            this.gol2DataGridViewTextBoxColumn.DataPropertyName = "Gol2";
            this.gol2DataGridViewTextBoxColumn.HeaderText = "Vendég Csapat Góljai";
            this.gol2DataGridViewTextBoxColumn.Name = "gol2DataGridViewTextBoxColumn";
            // 
            // filter_comboBox
            // 
            this.filter_comboBox.DataSource = this.csapatok_filter_bindingSource;
            this.filter_comboBox.DisplayMember = "Csoport_nev";
            this.filter_comboBox.FormattingEnabled = true;
            this.filter_comboBox.Location = new System.Drawing.Point(38, 21);
            this.filter_comboBox.Name = "filter_comboBox";
            this.filter_comboBox.Size = new System.Drawing.Size(121, 21);
            this.filter_comboBox.TabIndex = 1;
            this.filter_comboBox.ValueMember = "Csoport_id";
            // 
            // csapatok_filter_bindingSource
            // 
            this.csapatok_filter_bindingSource.DataMember = "Csoportok";
            this.csapatok_filter_bindingSource.DataSource = this.Bajnokok_Ligaja_dataset;
            this.csapatok_filter_bindingSource.CurrentChanged += new System.EventHandler(this.csapatok_filter_bindingSource_CurrentChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.csapatok_tabControl);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bajnokok Ligája";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.csapatok_tabControl.ResumeLayout(false);
            this.csapatok_tabPage.ResumeLayout(false);
            this.csoportok_tabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Bajnokok_Ligaja_dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Csoportok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Csapatok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Meccsek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Csoportok_bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.csoportok_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.csapatok_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Csapatok_bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.csapatokhoz_csoport_bindingSource)).EndInit();
            this.meccsek_tabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meccsek_bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meccsekhez_csapatok_bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meccsekhez_csapat2_bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.csapatok_filter_bindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl csapatok_tabControl;
        private System.Windows.Forms.TabPage csapatok_tabPage;
        private System.Windows.Forms.TabPage csoportok_tabPage;
        private System.Data.DataSet Bajnokok_Ligaja_dataset;
        private System.Data.DataTable Csoportok;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataTable Csapatok;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataTable Meccsek;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn7;
        private System.Data.DataColumn dataColumn8;
        private System.Data.DataColumn dataColumn9;
        private System.Data.DataColumn dataColumn10;
        private System.Windows.Forms.BindingSource Csoportok_bindingSource;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.DataGridView csoportok_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn csoportnevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView csapatok_dataGridView;
        private System.Windows.Forms.BindingSource Csapatok_bindingSource;
        private System.Windows.Forms.BindingSource csapatokhoz_csoport_bindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn csapatidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn csapatnevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Csoport;
        private System.Windows.Forms.DataGridViewTextBoxColumn csoportidDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage meccsek_tabPage;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource meccsek_bindingSource;
        private System.Windows.Forms.BindingSource meccsekhez_csapatok_bindingSource;
        private System.Windows.Forms.BindingSource meccsekhez_csapat2_bindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn Hazai_Csapat_Neve;
        private System.Windows.Forms.DataGridViewTextBoxColumn gol1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn csapat2idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Vendeg_Csapat_Neve;
        private System.Windows.Forms.DataGridViewTextBoxColumn gol2DataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox filter_comboBox;
        private System.Windows.Forms.BindingSource csapatok_filter_bindingSource;
    }
}

