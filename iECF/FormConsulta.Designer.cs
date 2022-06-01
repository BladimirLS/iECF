namespace iECF
{
    partial class FormConsulta
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.compelecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comp_ElectronicosDataSet1 = new iECF.Comp_ElectronicosDataSet1();
            this.comp_ElectronicosDataSet = new iECF.Comp_ElectronicosDataSet();
            this.ecfEncabezadoIdDocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ecfEncabezadoIdDocTableAdapter = new iECF.Comp_ElectronicosDataSetTableAdapters.EcfEncabezadoIdDocTableAdapter();
            this.recepcionResultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recepcionResultsTableAdapter = new iECF.Comp_ElectronicosDataSetTableAdapters.RecepcionResultsTableAdapter();
            this.compElectronicosDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ecfEncabezadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ecfEncabezadoTableAdapter = new iECF.Comp_ElectronicosDataSetTableAdapters.EcfEncabezadoTableAdapter();
            this.ecfEncabezadoCompradorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ecfEncabezadoCompradorTableAdapter = new iECF.Comp_ElectronicosDataSetTableAdapters.EcfEncabezadoCompradorTableAdapter();
            this.comp_elecTableAdapter = new iECF.Comp_ElectronicosDataSet1TableAdapters.comp_elecTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNCFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaVencimientoSecuenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoIngresosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rNCEmisorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonSocialEmisorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rNCCompradorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonSocialCompradorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroLineaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreItemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoItemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoGravadoTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comp_ElectronicosDataSet5 = new iECF.Comp_ElectronicosDataSet5();
            this.compelecBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comp_elecTableAdapter1 = new iECF.Comp_ElectronicosDataSet5TableAdapters.comp_elecTableAdapter();
            this.comp_ElectronicosDataSet6 = new iECF.Comp_ElectronicosDataSet6();
            this.compelecBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.comp_elecTableAdapter2 = new iECF.Comp_ElectronicosDataSet6TableAdapters.comp_elecTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compelecBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comp_ElectronicosDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comp_ElectronicosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecfEncabezadoIdDocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recepcionResultsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compElectronicosDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecfEncabezadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecfEncabezadoCompradorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comp_ElectronicosDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compelecBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comp_ElectronicosDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compelecBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.eNCFDataGridViewTextBoxColumn,
            this.fechaVencimientoSecuenciaDataGridViewTextBoxColumn,
            this.tipoIngresosDataGridViewTextBoxColumn,
            this.rNCEmisorDataGridViewTextBoxColumn,
            this.razonSocialEmisorDataGridViewTextBoxColumn,
            this.rNCCompradorDataGridViewTextBoxColumn,
            this.razonSocialCompradorDataGridViewTextBoxColumn,
            this.numeroLineaDataGridViewTextBoxColumn,
            this.nombreItemDataGridViewTextBoxColumn,
            this.montoItemDataGridViewTextBoxColumn,
            this.montoGravadoTotalDataGridViewTextBoxColumn,
            this.montoTotalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.compelecBindingSource2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(12, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 390);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // compelecBindingSource
            // 
            this.compelecBindingSource.DataMember = "comp_elec";
            this.compelecBindingSource.DataSource = this.comp_ElectronicosDataSet1;
            // 
            // comp_ElectronicosDataSet1
            // 
            this.comp_ElectronicosDataSet1.DataSetName = "Comp_ElectronicosDataSet1";
            this.comp_ElectronicosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comp_ElectronicosDataSet
            // 
            this.comp_ElectronicosDataSet.DataSetName = "Comp_ElectronicosDataSet";
            this.comp_ElectronicosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ecfEncabezadoIdDocBindingSource
            // 
            this.ecfEncabezadoIdDocBindingSource.DataMember = "EcfEncabezadoIdDoc";
            this.ecfEncabezadoIdDocBindingSource.DataSource = this.comp_ElectronicosDataSet;
            // 
            // ecfEncabezadoIdDocTableAdapter
            // 
            this.ecfEncabezadoIdDocTableAdapter.ClearBeforeFill = true;
            // 
            // recepcionResultsBindingSource
            // 
            this.recepcionResultsBindingSource.DataMember = "RecepcionResults";
            this.recepcionResultsBindingSource.DataSource = this.comp_ElectronicosDataSet;
            // 
            // recepcionResultsTableAdapter
            // 
            this.recepcionResultsTableAdapter.ClearBeforeFill = true;
            // 
            // compElectronicosDataSetBindingSource
            // 
            this.compElectronicosDataSetBindingSource.DataSource = this.comp_ElectronicosDataSet;
            this.compElectronicosDataSetBindingSource.Position = 0;
            // 
            // ecfEncabezadoBindingSource
            // 
            this.ecfEncabezadoBindingSource.DataMember = "EcfEncabezado";
            this.ecfEncabezadoBindingSource.DataSource = this.compElectronicosDataSetBindingSource;
            // 
            // ecfEncabezadoTableAdapter
            // 
            this.ecfEncabezadoTableAdapter.ClearBeforeFill = true;
            // 
            // ecfEncabezadoCompradorBindingSource
            // 
            this.ecfEncabezadoCompradorBindingSource.DataMember = "EcfEncabezadoComprador";
            this.ecfEncabezadoCompradorBindingSource.DataSource = this.compElectronicosDataSetBindingSource;
            // 
            // ecfEncabezadoCompradorTableAdapter
            // 
            this.ecfEncabezadoCompradorTableAdapter.ClearBeforeFill = true;
            // 
            // comp_elecTableAdapter
            // 
            this.comp_elecTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(184, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(304, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "codigo";
            this.codigoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoDataGridViewTextBoxColumn.Width = 125;
            // 
            // eNCFDataGridViewTextBoxColumn
            // 
            this.eNCFDataGridViewTextBoxColumn.DataPropertyName = "ENCF";
            this.eNCFDataGridViewTextBoxColumn.HeaderText = "ENCF";
            this.eNCFDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eNCFDataGridViewTextBoxColumn.Name = "eNCFDataGridViewTextBoxColumn";
            this.eNCFDataGridViewTextBoxColumn.ReadOnly = true;
            this.eNCFDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaVencimientoSecuenciaDataGridViewTextBoxColumn
            // 
            this.fechaVencimientoSecuenciaDataGridViewTextBoxColumn.DataPropertyName = "FechaVencimientoSecuencia";
            this.fechaVencimientoSecuenciaDataGridViewTextBoxColumn.HeaderText = "FechaVencimientoSecuencia";
            this.fechaVencimientoSecuenciaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaVencimientoSecuenciaDataGridViewTextBoxColumn.Name = "fechaVencimientoSecuenciaDataGridViewTextBoxColumn";
            this.fechaVencimientoSecuenciaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaVencimientoSecuenciaDataGridViewTextBoxColumn.Width = 125;
            // 
            // tipoIngresosDataGridViewTextBoxColumn
            // 
            this.tipoIngresosDataGridViewTextBoxColumn.DataPropertyName = "TipoIngresos";
            this.tipoIngresosDataGridViewTextBoxColumn.HeaderText = "TipoIngresos";
            this.tipoIngresosDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipoIngresosDataGridViewTextBoxColumn.Name = "tipoIngresosDataGridViewTextBoxColumn";
            this.tipoIngresosDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoIngresosDataGridViewTextBoxColumn.Width = 125;
            // 
            // rNCEmisorDataGridViewTextBoxColumn
            // 
            this.rNCEmisorDataGridViewTextBoxColumn.DataPropertyName = "RNCEmisor";
            this.rNCEmisorDataGridViewTextBoxColumn.HeaderText = "RNCEmisor";
            this.rNCEmisorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rNCEmisorDataGridViewTextBoxColumn.Name = "rNCEmisorDataGridViewTextBoxColumn";
            this.rNCEmisorDataGridViewTextBoxColumn.ReadOnly = true;
            this.rNCEmisorDataGridViewTextBoxColumn.Width = 125;
            // 
            // razonSocialEmisorDataGridViewTextBoxColumn
            // 
            this.razonSocialEmisorDataGridViewTextBoxColumn.DataPropertyName = "RazonSocialEmisor";
            this.razonSocialEmisorDataGridViewTextBoxColumn.HeaderText = "RazonSocialEmisor";
            this.razonSocialEmisorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.razonSocialEmisorDataGridViewTextBoxColumn.Name = "razonSocialEmisorDataGridViewTextBoxColumn";
            this.razonSocialEmisorDataGridViewTextBoxColumn.ReadOnly = true;
            this.razonSocialEmisorDataGridViewTextBoxColumn.Width = 125;
            // 
            // rNCCompradorDataGridViewTextBoxColumn
            // 
            this.rNCCompradorDataGridViewTextBoxColumn.DataPropertyName = "RNCComprador";
            this.rNCCompradorDataGridViewTextBoxColumn.HeaderText = "RNCComprador";
            this.rNCCompradorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rNCCompradorDataGridViewTextBoxColumn.Name = "rNCCompradorDataGridViewTextBoxColumn";
            this.rNCCompradorDataGridViewTextBoxColumn.ReadOnly = true;
            this.rNCCompradorDataGridViewTextBoxColumn.Width = 125;
            // 
            // razonSocialCompradorDataGridViewTextBoxColumn
            // 
            this.razonSocialCompradorDataGridViewTextBoxColumn.DataPropertyName = "RazonSocialComprador";
            this.razonSocialCompradorDataGridViewTextBoxColumn.HeaderText = "RazonSocialComprador";
            this.razonSocialCompradorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.razonSocialCompradorDataGridViewTextBoxColumn.Name = "razonSocialCompradorDataGridViewTextBoxColumn";
            this.razonSocialCompradorDataGridViewTextBoxColumn.ReadOnly = true;
            this.razonSocialCompradorDataGridViewTextBoxColumn.Width = 125;
            // 
            // numeroLineaDataGridViewTextBoxColumn
            // 
            this.numeroLineaDataGridViewTextBoxColumn.DataPropertyName = "NumeroLinea";
            this.numeroLineaDataGridViewTextBoxColumn.HeaderText = "NumeroLinea";
            this.numeroLineaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeroLineaDataGridViewTextBoxColumn.Name = "numeroLineaDataGridViewTextBoxColumn";
            this.numeroLineaDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeroLineaDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreItemDataGridViewTextBoxColumn
            // 
            this.nombreItemDataGridViewTextBoxColumn.DataPropertyName = "NombreItem";
            this.nombreItemDataGridViewTextBoxColumn.HeaderText = "NombreItem";
            this.nombreItemDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreItemDataGridViewTextBoxColumn.Name = "nombreItemDataGridViewTextBoxColumn";
            this.nombreItemDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreItemDataGridViewTextBoxColumn.Width = 125;
            // 
            // montoItemDataGridViewTextBoxColumn
            // 
            this.montoItemDataGridViewTextBoxColumn.DataPropertyName = "MontoItem";
            this.montoItemDataGridViewTextBoxColumn.HeaderText = "MontoItem";
            this.montoItemDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.montoItemDataGridViewTextBoxColumn.Name = "montoItemDataGridViewTextBoxColumn";
            this.montoItemDataGridViewTextBoxColumn.ReadOnly = true;
            this.montoItemDataGridViewTextBoxColumn.Width = 125;
            // 
            // montoGravadoTotalDataGridViewTextBoxColumn
            // 
            this.montoGravadoTotalDataGridViewTextBoxColumn.DataPropertyName = "MontoGravadoTotal";
            this.montoGravadoTotalDataGridViewTextBoxColumn.HeaderText = "MontoGravadoTotal";
            this.montoGravadoTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.montoGravadoTotalDataGridViewTextBoxColumn.Name = "montoGravadoTotalDataGridViewTextBoxColumn";
            this.montoGravadoTotalDataGridViewTextBoxColumn.ReadOnly = true;
            this.montoGravadoTotalDataGridViewTextBoxColumn.Width = 125;
            // 
            // montoTotalDataGridViewTextBoxColumn
            // 
            this.montoTotalDataGridViewTextBoxColumn.DataPropertyName = "MontoTotal";
            this.montoTotalDataGridViewTextBoxColumn.HeaderText = "MontoTotal";
            this.montoTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.montoTotalDataGridViewTextBoxColumn.Name = "montoTotalDataGridViewTextBoxColumn";
            this.montoTotalDataGridViewTextBoxColumn.ReadOnly = true;
            this.montoTotalDataGridViewTextBoxColumn.Width = 125;
            // 
            // comp_ElectronicosDataSet5
            // 
            this.comp_ElectronicosDataSet5.DataSetName = "Comp_ElectronicosDataSet5";
            this.comp_ElectronicosDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // compelecBindingSource1
            // 
            this.compelecBindingSource1.DataMember = "comp_elec";
            this.compelecBindingSource1.DataSource = this.comp_ElectronicosDataSet5;
            // 
            // comp_elecTableAdapter1
            // 
            this.comp_elecTableAdapter1.ClearBeforeFill = true;
            // 
            // comp_ElectronicosDataSet6
            // 
            this.comp_ElectronicosDataSet6.DataSetName = "Comp_ElectronicosDataSet6";
            this.comp_ElectronicosDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // compelecBindingSource2
            // 
            this.compelecBindingSource2.DataMember = "comp_elec";
            this.compelecBindingSource2.DataSource = this.comp_ElectronicosDataSet6;
            // 
            // comp_elecTableAdapter2
            // 
            this.comp_elecTableAdapter2.ClearBeforeFill = true;
            // 
            // FormConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormConsulta";
            this.Load += new System.EventHandler(this.FormConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compelecBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comp_ElectronicosDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comp_ElectronicosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecfEncabezadoIdDocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recepcionResultsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compElectronicosDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecfEncabezadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecfEncabezadoCompradorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comp_ElectronicosDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compelecBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comp_ElectronicosDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compelecBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Comp_ElectronicosDataSet comp_ElectronicosDataSet;
        private System.Windows.Forms.BindingSource ecfEncabezadoIdDocBindingSource;
        private Comp_ElectronicosDataSetTableAdapters.EcfEncabezadoIdDocTableAdapter ecfEncabezadoIdDocTableAdapter;
        private System.Windows.Forms.BindingSource recepcionResultsBindingSource;
        private Comp_ElectronicosDataSetTableAdapters.RecepcionResultsTableAdapter recepcionResultsTableAdapter;
        private System.Windows.Forms.BindingSource compElectronicosDataSetBindingSource;
        private System.Windows.Forms.BindingSource ecfEncabezadoBindingSource;
        private Comp_ElectronicosDataSetTableAdapters.EcfEncabezadoTableAdapter ecfEncabezadoTableAdapter;
        private System.Windows.Forms.BindingSource ecfEncabezadoCompradorBindingSource;
        private Comp_ElectronicosDataSetTableAdapters.EcfEncabezadoCompradorTableAdapter ecfEncabezadoCompradorTableAdapter;
        private Comp_ElectronicosDataSet1 comp_ElectronicosDataSet1;
        private System.Windows.Forms.BindingSource compelecBindingSource;
        private Comp_ElectronicosDataSet1TableAdapters.comp_elecTableAdapter comp_elecTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNCFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaVencimientoSecuenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoIngresosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rNCEmisorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonSocialEmisorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rNCCompradorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonSocialCompradorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroLineaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreItemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoItemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoGravadoTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoTotalDataGridViewTextBoxColumn;
        private Comp_ElectronicosDataSet5 comp_ElectronicosDataSet5;
        private System.Windows.Forms.BindingSource compelecBindingSource1;
        private Comp_ElectronicosDataSet5TableAdapters.comp_elecTableAdapter comp_elecTableAdapter1;
        private Comp_ElectronicosDataSet6 comp_ElectronicosDataSet6;
        private System.Windows.Forms.BindingSource compelecBindingSource2;
        private Comp_ElectronicosDataSet6TableAdapters.comp_elecTableAdapter comp_elecTableAdapter2;
    }
}