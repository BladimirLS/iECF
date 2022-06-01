namespace iECF
{
    partial class Firma
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Firma));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tipoeCFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.firmacompelecBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comp_ElectronicosDataSet3 = new iECF.Comp_ElectronicosDataSet3();
            this.comp_ElectronicosDataSet = new iECF.Comp_ElectronicosDataSet();
            this.compElectronicosDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comp_ElectronicosDataSet2 = new iECF.Comp_ElectronicosDataSet2();
            this.firmacompelecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firma_comp_elecTableAdapter = new iECF.Comp_ElectronicosDataSet2TableAdapters.firma_comp_elecTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.firma_comp_elecTableAdapter1 = new iECF.Comp_ElectronicosDataSet3TableAdapters.firma_comp_elecTableAdapter();
            this.comp_ElectronicosDataSet4 = new iECF.Comp_ElectronicosDataSet4();
            this.firmacompBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firma_compTableAdapter = new iECF.Comp_ElectronicosDataSet4TableAdapters.firma_compTableAdapter();
            this.CantidadItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmacompelecBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comp_ElectronicosDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comp_ElectronicosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compElectronicosDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comp_ElectronicosDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmacompelecBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comp_ElectronicosDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmacompBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipoeCFDataGridViewTextBoxColumn,
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
            this.montoTotalDataGridViewTextBoxColumn,
            this.CantidadItem,
            this.DescripcionItem});
            this.dataGridView1.DataSource = this.firmacompBindingSource;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(772, 338);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tipoeCFDataGridViewTextBoxColumn
            // 
            this.tipoeCFDataGridViewTextBoxColumn.DataPropertyName = "TipoeCF";
            this.tipoeCFDataGridViewTextBoxColumn.HeaderText = "TipoeCF";
            this.tipoeCFDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipoeCFDataGridViewTextBoxColumn.Name = "tipoeCFDataGridViewTextBoxColumn";
            this.tipoeCFDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoeCFDataGridViewTextBoxColumn.Width = 125;
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
            // firmacompelecBindingSource1
            // 
            this.firmacompelecBindingSource1.DataMember = "firma_comp_elec";
            this.firmacompelecBindingSource1.DataSource = this.comp_ElectronicosDataSet3;
            // 
            // comp_ElectronicosDataSet3
            // 
            this.comp_ElectronicosDataSet3.DataSetName = "Comp_ElectronicosDataSet3";
            this.comp_ElectronicosDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comp_ElectronicosDataSet
            // 
            this.comp_ElectronicosDataSet.DataSetName = "Comp_ElectronicosDataSet";
            this.comp_ElectronicosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // compElectronicosDataSetBindingSource
            // 
            this.compElectronicosDataSetBindingSource.DataSource = this.comp_ElectronicosDataSet;
            this.compElectronicosDataSetBindingSource.Position = 0;
            // 
            // comp_ElectronicosDataSet2
            // 
            this.comp_ElectronicosDataSet2.DataSetName = "Comp_ElectronicosDataSet2";
            this.comp_ElectronicosDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // firmacompelecBindingSource
            // 
            this.firmacompelecBindingSource.DataMember = "firma_comp_elec";
            this.firmacompelecBindingSource.DataSource = this.comp_ElectronicosDataSet2;
            // 
            // firma_comp_elecTableAdapter
            // 
            this.firma_comp_elecTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(392, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // firma_comp_elecTableAdapter1
            // 
            this.firma_comp_elecTableAdapter1.ClearBeforeFill = true;
            // 
            // comp_ElectronicosDataSet4
            // 
            this.comp_ElectronicosDataSet4.DataSetName = "Comp_ElectronicosDataSet4";
            this.comp_ElectronicosDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // firmacompBindingSource
            // 
            this.firmacompBindingSource.DataMember = "firma_comp";
            this.firmacompBindingSource.DataSource = this.comp_ElectronicosDataSet4;
            // 
            // firma_compTableAdapter
            // 
            this.firma_compTableAdapter.ClearBeforeFill = true;
            // 
            // CantidadItem
            // 
            this.CantidadItem.DataPropertyName = "CantidadItem";
            this.CantidadItem.HeaderText = "CantidadItem";
            this.CantidadItem.MinimumWidth = 6;
            this.CantidadItem.Name = "CantidadItem";
            this.CantidadItem.ReadOnly = true;
            this.CantidadItem.Width = 125;
            // 
            // DescripcionItem
            // 
            this.DescripcionItem.DataPropertyName = "DescripcionItem";
            this.DescripcionItem.HeaderText = "DescripcionItem";
            this.DescripcionItem.MinimumWidth = 6;
            this.DescripcionItem.Name = "DescripcionItem";
            this.DescripcionItem.ReadOnly = true;
            this.DescripcionItem.Width = 125;
            // 
            // Firma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 485);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Firma";
            this.Text = "Firma";
            this.Load += new System.EventHandler(this.Firma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmacompelecBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comp_ElectronicosDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comp_ElectronicosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compElectronicosDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comp_ElectronicosDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmacompelecBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comp_ElectronicosDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmacompBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource compElectronicosDataSetBindingSource;
        private Comp_ElectronicosDataSet comp_ElectronicosDataSet;
        private Comp_ElectronicosDataSet2 comp_ElectronicosDataSet2;
        private System.Windows.Forms.BindingSource firmacompelecBindingSource;
        private Comp_ElectronicosDataSet2TableAdapters.firma_comp_elecTableAdapter firma_comp_elecTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoeCFDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private Comp_ElectronicosDataSet3 comp_ElectronicosDataSet3;
        private System.Windows.Forms.BindingSource firmacompelecBindingSource1;
        private Comp_ElectronicosDataSet3TableAdapters.firma_comp_elecTableAdapter firma_comp_elecTableAdapter1;
        private Comp_ElectronicosDataSet4 comp_ElectronicosDataSet4;
        private System.Windows.Forms.BindingSource firmacompBindingSource;
        private Comp_ElectronicosDataSet4TableAdapters.firma_compTableAdapter firma_compTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionItem;
    }
}