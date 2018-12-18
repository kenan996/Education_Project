namespace WindowsFormsApp1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRemove = new System.Windows.Forms.Button();
            this.dgwList = new System.Windows.Forms.DataGridView();
            this.modelIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelColorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this._Turbo_azDataSet = new WindowsFormsApp1._Turbo_azDataSet();
            this.modelsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.txtRengi = new System.Windows.Forms.TextBox();
            this.txtİli = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtQiymeti = new System.Windows.Forms.TextBox();
            this.txtMarkaId = new System.Windows.Forms.TextBox();
            this.lblRengi = new System.Windows.Forms.Label();
            this.lblQiymeti = new System.Windows.Forms.Label();
            this.lblİli = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblMarkaName = new System.Windows.Forms.Label();
            this.lblMarks = new System.Windows.Forms.Label();
            this.cbxMarks = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.turboazDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modelsTableAdapter = new WindowsFormsApp1._Turbo_azDataSetTableAdapters.ModelsTableAdapter();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.txtRengi2 = new System.Windows.Forms.TextBox();
            this.txtİLi2 = new System.Windows.Forms.TextBox();
            this.txtModel2 = new System.Windows.Forms.TextBox();
            this.txtQiymeti2 = new System.Windows.Forms.TextBox();
            this.txtMarkaId2 = new System.Windows.Forms.TextBox();
            this.lblRengi2 = new System.Windows.Forms.Label();
            this.lblQiymeti2 = new System.Windows.Forms.Label();
            this.lbİLi2 = new System.Windows.Forms.Label();
            this.lblModel2 = new System.Windows.Forms.Label();
            this.lblMarkaId2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Turbo_azDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelsBindingSource1)).BeginInit();
            this.gbxAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.turboazDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelsBindingSource)).BeginInit();
            this.gbxUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(23, 9);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(121, 25);
            this.btnRemove.TabIndex = 0;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // dgwList
            // 
            this.dgwList.AllowUserToOrderColumns = true;
            this.dgwList.AutoGenerateColumns = false;
            this.dgwList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.modelIdDataGridViewTextBoxColumn,
            this.modelNameDataGridViewTextBoxColumn,
            this.modelPriceDataGridViewTextBoxColumn,
            this.modelColorDataGridViewTextBoxColumn,
            this.modelYearDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1});
            this.dgwList.DataSource = this.modelsBindingSource2;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgwList.Location = new System.Drawing.Point(3, 56);
            this.dgwList.Name = "dgwList";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgwList.Size = new System.Drawing.Size(753, 150);
            this.dgwList.TabIndex = 4;
            this.dgwList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwList_CellClick_1);
            
            // modelIdDataGridViewTextBoxColumn
            // 
            this.modelIdDataGridViewTextBoxColumn.DataPropertyName = "ModelId";
            this.modelIdDataGridViewTextBoxColumn.HeaderText = "ModelId";
            this.modelIdDataGridViewTextBoxColumn.Name = "modelIdDataGridViewTextBoxColumn";
            this.modelIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelNameDataGridViewTextBoxColumn
            // 
            this.modelNameDataGridViewTextBoxColumn.DataPropertyName = "ModelName";
            this.modelNameDataGridViewTextBoxColumn.HeaderText = "ModelName";
            this.modelNameDataGridViewTextBoxColumn.Name = "modelNameDataGridViewTextBoxColumn";
            // 
            // modelPriceDataGridViewTextBoxColumn
            // 
            this.modelPriceDataGridViewTextBoxColumn.DataPropertyName = "ModelPrice";
            this.modelPriceDataGridViewTextBoxColumn.HeaderText = "ModelPrice";
            this.modelPriceDataGridViewTextBoxColumn.Name = "modelPriceDataGridViewTextBoxColumn";
            // 
            // modelColorDataGridViewTextBoxColumn
            // 
            this.modelColorDataGridViewTextBoxColumn.DataPropertyName = "ModelColor";
            this.modelColorDataGridViewTextBoxColumn.HeaderText = "ModelColor";
            this.modelColorDataGridViewTextBoxColumn.Name = "modelColorDataGridViewTextBoxColumn";
            // 
            // modelYearDataGridViewTextBoxColumn
            // 
            this.modelYearDataGridViewTextBoxColumn.DataPropertyName = "ModelYear";
            this.modelYearDataGridViewTextBoxColumn.HeaderText = "ModelYear";
            this.modelYearDataGridViewTextBoxColumn.Name = "modelYearDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MarkaId";
            this.dataGridViewTextBoxColumn1.HeaderText = "MarkaId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // modelsBindingSource2
            // 
            this.modelsBindingSource2.DataMember = "Models";
            this.modelsBindingSource2.DataSource = this._Turbo_azDataSet;
            // 
            // _Turbo_azDataSet
            // 
            this._Turbo_azDataSet.DataSetName = "_Turbo_azDataSet";
            this._Turbo_azDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // modelsBindingSource1
            // 
            this.modelsBindingSource1.DataMember = "Models";
            // 
            // gbxAdd
            // 
            this.gbxAdd.Controls.Add(this.txtRengi);
            this.gbxAdd.Controls.Add(this.txtİli);
            this.gbxAdd.Controls.Add(this.txtModel);
            this.gbxAdd.Controls.Add(this.txtQiymeti);
            this.gbxAdd.Controls.Add(this.txtMarkaId);
            this.gbxAdd.Controls.Add(this.lblRengi);
            this.gbxAdd.Controls.Add(this.lblQiymeti);
            this.gbxAdd.Controls.Add(this.lblİli);
            this.gbxAdd.Controls.Add(this.lblModel);
            this.gbxAdd.Controls.Add(this.lblMarkaName);
            this.gbxAdd.Location = new System.Drawing.Point(12, 221);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(236, 232);
            this.gbxAdd.TabIndex = 5;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Add Car";
            // 
            // txtRengi
            // 
            this.txtRengi.Location = new System.Drawing.Point(106, 156);
            this.txtRengi.Name = "txtRengi";
            this.txtRengi.Size = new System.Drawing.Size(100, 20);
            this.txtRengi.TabIndex = 7;
            // 
            // txtİli
            // 
            this.txtİli.Location = new System.Drawing.Point(106, 113);
            this.txtİli.Name = "txtİli";
            this.txtİli.Size = new System.Drawing.Size(100, 20);
            this.txtİli.TabIndex = 6;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(106, 71);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 5;
            // 
            // txtQiymeti
            // 
            this.txtQiymeti.Location = new System.Drawing.Point(106, 199);
            this.txtQiymeti.Name = "txtQiymeti";
            this.txtQiymeti.Size = new System.Drawing.Size(100, 20);
            this.txtQiymeti.TabIndex = 4;
            // 
            // txtMarkaId
            // 
            this.txtMarkaId.Location = new System.Drawing.Point(106, 33);
            this.txtMarkaId.Name = "txtMarkaId";
            this.txtMarkaId.Size = new System.Drawing.Size(100, 20);
            this.txtMarkaId.TabIndex = 4;
            // 
            // lblRengi
            // 
            this.lblRengi.AutoSize = true;
            this.lblRengi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRengi.Location = new System.Drawing.Point(51, 156);
            this.lblRengi.Name = "lblRengi";
            this.lblRengi.Size = new System.Drawing.Size(49, 15);
            this.lblRengi.TabIndex = 3;
            this.lblRengi.Text = "Rengi:";
            // 
            // lblQiymeti
            // 
            this.lblQiymeti.AutoSize = true;
            this.lblQiymeti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQiymeti.Location = new System.Drawing.Point(39, 199);
            this.lblQiymeti.Name = "lblQiymeti";
            this.lblQiymeti.Size = new System.Drawing.Size(59, 15);
            this.lblQiymeti.TabIndex = 0;
            this.lblQiymeti.Text = "Qiymeti:";
            // 
            // lblİli
            // 
            this.lblİli.AutoSize = true;
            this.lblİli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblİli.Location = new System.Drawing.Point(73, 114);
            this.lblİli.Name = "lblİli";
            this.lblİli.Size = new System.Drawing.Size(27, 15);
            this.lblİli.TabIndex = 2;
            this.lblİli.Text = "İLi:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.Location = new System.Drawing.Point(49, 71);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(51, 15);
            this.lblModel.TabIndex = 1;
            this.lblModel.Text = "Model:";
            // 
            // lblMarkaName
            // 
            this.lblMarkaName.AutoSize = true;
            this.lblMarkaName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarkaName.Location = new System.Drawing.Point(31, 33);
            this.lblMarkaName.Name = "lblMarkaName";
            this.lblMarkaName.Size = new System.Drawing.Size(67, 15);
            this.lblMarkaName.TabIndex = 0;
            this.lblMarkaName.Text = "Marka Id:";
            // 
            // lblMarks
            // 
            this.lblMarks.AutoSize = true;
            this.lblMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarks.Location = new System.Drawing.Point(254, 9);
            this.lblMarks.Name = "lblMarks";
            this.lblMarks.Size = new System.Drawing.Size(50, 16);
            this.lblMarks.TabIndex = 7;
            this.lblMarks.Text = "Marks";
            // 
            // cbxMarks
            // 
            this.cbxMarks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxMarks.FormattingEnabled = true;
            this.cbxMarks.Location = new System.Drawing.Point(317, 9);
            this.cbxMarks.Name = "cbxMarks";
            this.cbxMarks.Size = new System.Drawing.Size(121, 21);
            this.cbxMarks.TabIndex = 8;
            this.cbxMarks.SelectedIndexChanged += new System.EventHandler(this.cbxMarks_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Red;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.Location = new System.Drawing.Point(254, 420);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 33);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // marksBindingSource
            // 
            this.marksBindingSource.DataMember = "Marks";
            // 
            // modelsBindingSource
            // 
            this.modelsBindingSource.DataMember = "Models";
            // 
            // modelsTableAdapter
            // 
            this.modelsTableAdapter.ClearBeforeFill = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(588, 9);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(113, 21);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(512, 9);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(57, 16);
            this.lblSearch.TabIndex = 11;
            this.lblSearch.Text = "Search";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdate.Location = new System.Drawing.Point(419, 420);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(87, 33);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.txtRengi2);
            this.gbxUpdate.Controls.Add(this.txtİLi2);
            this.gbxUpdate.Controls.Add(this.txtModel2);
            this.gbxUpdate.Controls.Add(this.txtQiymeti2);
            this.gbxUpdate.Controls.Add(this.txtMarkaId2);
            this.gbxUpdate.Controls.Add(this.lblRengi2);
            this.gbxUpdate.Controls.Add(this.lblQiymeti2);
            this.gbxUpdate.Controls.Add(this.lbİLi2);
            this.gbxUpdate.Controls.Add(this.lblModel2);
            this.gbxUpdate.Controls.Add(this.lblMarkaId2);
            this.gbxUpdate.Location = new System.Drawing.Point(510, 230);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(236, 232);
            this.gbxUpdate.TabIndex = 12;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Update Car";
            // 
            // txtRengi2
            // 
            this.txtRengi2.Location = new System.Drawing.Point(106, 155);
            this.txtRengi2.Name = "txtRengi2";
            this.txtRengi2.Size = new System.Drawing.Size(100, 20);
            this.txtRengi2.TabIndex = 7;
            // 
            // txtİLi2
            // 
            this.txtİLi2.Location = new System.Drawing.Point(106, 113);
            this.txtİLi2.Name = "txtİLi2";
            this.txtİLi2.Size = new System.Drawing.Size(100, 20);
            this.txtİLi2.TabIndex = 6;
            // 
            // txtModel2
            // 
            this.txtModel2.Location = new System.Drawing.Point(106, 70);
            this.txtModel2.Name = "txtModel2";
            this.txtModel2.Size = new System.Drawing.Size(100, 20);
            this.txtModel2.TabIndex = 5;
            // 
            // txtQiymeti2
            // 
            this.txtQiymeti2.Location = new System.Drawing.Point(106, 199);
            this.txtQiymeti2.Name = "txtQiymeti2";
            this.txtQiymeti2.Size = new System.Drawing.Size(100, 20);
            this.txtQiymeti2.TabIndex = 4;
            // 
            // txtMarkaId2
            // 
            this.txtMarkaId2.Location = new System.Drawing.Point(106, 33);
            this.txtMarkaId2.Name = "txtMarkaId2";
            this.txtMarkaId2.Size = new System.Drawing.Size(100, 20);
            this.txtMarkaId2.TabIndex = 4;
            // 
            // lblRengi2
            // 
            this.lblRengi2.AutoSize = true;
            this.lblRengi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRengi2.Location = new System.Drawing.Point(51, 156);
            this.lblRengi2.Name = "lblRengi2";
            this.lblRengi2.Size = new System.Drawing.Size(49, 15);
            this.lblRengi2.TabIndex = 3;
            this.lblRengi2.Text = "Rengi:";
            // 
            // lblQiymeti2
            // 
            this.lblQiymeti2.AutoSize = true;
            this.lblQiymeti2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQiymeti2.Location = new System.Drawing.Point(41, 199);
            this.lblQiymeti2.Name = "lblQiymeti2";
            this.lblQiymeti2.Size = new System.Drawing.Size(59, 15);
            this.lblQiymeti2.TabIndex = 0;
            this.lblQiymeti2.Text = "Qiymeti:";
            // 
            // lbİLi2
            // 
            this.lbİLi2.AutoSize = true;
            this.lbİLi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbİLi2.Location = new System.Drawing.Point(73, 114);
            this.lbİLi2.Name = "lbİLi2";
            this.lbİLi2.Size = new System.Drawing.Size(27, 15);
            this.lbİLi2.TabIndex = 2;
            this.lbİLi2.Text = "İLi:";
            // 
            // lblModel2
            // 
            this.lblModel2.AutoSize = true;
            this.lblModel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel2.Location = new System.Drawing.Point(49, 70);
            this.lblModel2.Name = "lblModel2";
            this.lblModel2.Size = new System.Drawing.Size(51, 15);
            this.lblModel2.TabIndex = 1;
            this.lblModel2.Text = "Model:";
            // 
            // lblMarkaId2
            // 
            this.lblMarkaId2.AutoSize = true;
            this.lblMarkaId2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarkaId2.Location = new System.Drawing.Point(33, 29);
            this.lblMarkaId2.Name = "lblMarkaId2";
            this.lblMarkaId2.Size = new System.Drawing.Size(67, 15);
            this.lblMarkaId2.TabIndex = 0;
            this.lblMarkaId2.Text = "Marka Id:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 454);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbxMarks);
            this.Controls.Add(this.lblMarks);
            this.Controls.Add(this.gbxAdd);
            this.Controls.Add(this.dgwList);
            this.Controls.Add(this.btnRemove);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Turbo_azDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelsBindingSource1)).EndInit();
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.turboazDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelsBindingSource)).EndInit();
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridView dgwList;
        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.TextBox txtRengi;
        private System.Windows.Forms.TextBox txtİli;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtMarkaId;
        private System.Windows.Forms.Label lblRengi;
        private System.Windows.Forms.Label lblİli;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblMarkaName;
        private System.Windows.Forms.Label lblMarks;
        private System.Windows.Forms.ComboBox cbxMarks;
        private System.Windows.Forms.TextBox txtQiymeti;
        private System.Windows.Forms.Label lblQiymeti;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.BindingSource turboazDataSetBindingSource;
       
        private System.Windows.Forms.BindingSource marksBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource modelsBindingSource;
        private System.Windows.Forms.BindingSource modelsBindingSource1;
        private _Turbo_azDataSet _Turbo_azDataSet;
        private System.Windows.Forms.BindingSource modelsBindingSource2;
        private _Turbo_azDataSetTableAdapters.ModelsTableAdapter modelsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelColorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.TextBox txtRengi2;
        private System.Windows.Forms.TextBox txtİLi2;
        private System.Windows.Forms.TextBox txtModel2;
        private System.Windows.Forms.TextBox txtQiymeti2;
        private System.Windows.Forms.TextBox txtMarkaId2;
        private System.Windows.Forms.Label lblRengi2;
        private System.Windows.Forms.Label lblQiymeti2;
        private System.Windows.Forms.Label lbİLi2;
        private System.Windows.Forms.Label lblModel2;
        private System.Windows.Forms.Label lblMarkaId2;
    }
}

