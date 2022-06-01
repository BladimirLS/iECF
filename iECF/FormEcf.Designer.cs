using System.Windows.Forms;

namespace iECF
{
    partial class FormEcf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEcf));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFechaVencimiento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEncf = new System.Windows.Forms.TextBox();
            this.txtTipoCf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRazonSocialComprador = new System.Windows.Forms.TextBox();
            this.txtRncComprador = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRazonSocialEmisor = new System.Windows.Forms.TextBox();
            this.txtRncEmisor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtITBIS = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtMontoExento = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtMontoGravado1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtMontoGravo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Montoitem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtFechaVencimiento);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtEncf);
            this.panel1.Controls.Add(this.txtTipoCf);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 140);
            this.panel1.TabIndex = 0;
            // 
            // txtFechaVencimiento
            // 
            this.txtFechaVencimiento.Location = new System.Drawing.Point(136, 73);
            this.txtFechaVencimiento.Name = "txtFechaVencimiento";
            this.txtFechaVencimiento.ReadOnly = true;
            this.txtFechaVencimiento.Size = new System.Drawing.Size(104, 22);
            this.txtFechaVencimiento.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fecha Vecimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "ENCF";
            // 
            // txtEncf
            // 
            this.txtEncf.Location = new System.Drawing.Point(172, 29);
            this.txtEncf.Name = "txtEncf";
            this.txtEncf.ReadOnly = true;
            this.txtEncf.Size = new System.Drawing.Size(100, 22);
            this.txtEncf.TabIndex = 3;
            this.txtEncf.TextChanged += new System.EventHandler(this.txtEncf_TextChanged);
            // 
            // txtTipoCf
            // 
            this.txtTipoCf.Location = new System.Drawing.Point(66, 29);
            this.txtTipoCf.Name = "txtTipoCf";
            this.txtTipoCf.ReadOnly = true;
            this.txtTipoCf.Size = new System.Drawing.Size(35, 22);
            this.txtTipoCf.TabIndex = 2;
            this.txtTipoCf.TextChanged += new System.EventHandler(this.txtTipoCf_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo CF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ENCF";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtRazonSocialComprador);
            this.panel2.Controls.Add(this.txtRncComprador);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtRazonSocialEmisor);
            this.panel2.Controls.Add(this.txtRncEmisor);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(297, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(391, 140);
            this.panel2.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Razon Social Comprador";
            // 
            // txtRazonSocialComprador
            // 
            this.txtRazonSocialComprador.Location = new System.Drawing.Point(188, 100);
            this.txtRazonSocialComprador.Name = "txtRazonSocialComprador";
            this.txtRazonSocialComprador.ReadOnly = true;
            this.txtRazonSocialComprador.Size = new System.Drawing.Size(185, 22);
            this.txtRazonSocialComprador.TabIndex = 7;
            // 
            // txtRncComprador
            // 
            this.txtRncComprador.Location = new System.Drawing.Point(188, 73);
            this.txtRncComprador.Name = "txtRncComprador";
            this.txtRncComprador.ReadOnly = true;
            this.txtRncComprador.Size = new System.Drawing.Size(185, 22);
            this.txtRncComprador.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "RNC Comprador";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Encabezado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Razon Social Emisor";
            // 
            // txtRazonSocialEmisor
            // 
            this.txtRazonSocialEmisor.Location = new System.Drawing.Point(188, 45);
            this.txtRazonSocialEmisor.Name = "txtRazonSocialEmisor";
            this.txtRazonSocialEmisor.ReadOnly = true;
            this.txtRazonSocialEmisor.Size = new System.Drawing.Size(185, 22);
            this.txtRazonSocialEmisor.TabIndex = 2;
            // 
            // txtRncEmisor
            // 
            this.txtRncEmisor.Location = new System.Drawing.Point(188, 17);
            this.txtRncEmisor.Name = "txtRncEmisor";
            this.txtRncEmisor.ReadOnly = true;
            this.txtRncEmisor.Size = new System.Drawing.Size(185, 22);
            this.txtRncEmisor.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "RNC Emisor";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(12, 172);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(676, 67);
            this.panel3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.item,
            this.Cantidad,
            this.Montoitem});
            this.dataGridView1.Location = new System.Drawing.Point(3, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(670, 64);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtITBIS);
            this.panel5.Controls.Add(this.label18);
            this.panel5.Controls.Add(this.txtMontoTotal);
            this.panel5.Controls.Add(this.label17);
            this.panel5.Controls.Add(this.txtMontoExento);
            this.panel5.Controls.Add(this.label16);
            this.panel5.Controls.Add(this.txtMontoGravado1);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.txtMontoGravo);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Location = new System.Drawing.Point(300, 245);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(388, 223);
            this.panel5.TabIndex = 3;
            // 
            // txtITBIS
            // 
            this.txtITBIS.Location = new System.Drawing.Point(185, 135);
            this.txtITBIS.Name = "txtITBIS";
            this.txtITBIS.ReadOnly = true;
            this.txtITBIS.Size = new System.Drawing.Size(185, 22);
            this.txtITBIS.TabIndex = 21;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(26, 141);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(40, 16);
            this.label18.TabIndex = 20;
            this.label18.Text = "ITBIS";
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.Location = new System.Drawing.Point(185, 171);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.ReadOnly = true;
            this.txtMontoTotal.Size = new System.Drawing.Size(185, 22);
            this.txtMontoTotal.TabIndex = 19;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(26, 180);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 16);
            this.label17.TabIndex = 18;
            this.label17.Text = "Monto Total";
            // 
            // txtMontoExento
            // 
            this.txtMontoExento.Location = new System.Drawing.Point(185, 99);
            this.txtMontoExento.Name = "txtMontoExento";
            this.txtMontoExento.ReadOnly = true;
            this.txtMontoExento.Size = new System.Drawing.Size(185, 22);
            this.txtMontoExento.TabIndex = 17;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(26, 102);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 16);
            this.label16.TabIndex = 16;
            this.label16.Text = "Monto Exento";
            // 
            // txtMontoGravado1
            // 
            this.txtMontoGravado1.Location = new System.Drawing.Point(185, 59);
            this.txtMontoGravado1.Name = "txtMontoGravado1";
            this.txtMontoGravado1.ReadOnly = true;
            this.txtMontoGravado1.Size = new System.Drawing.Size(185, 22);
            this.txtMontoGravado1.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(26, 65);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(139, 16);
            this.label15.TabIndex = 14;
            this.label15.Text = "Monto Total gravado1";
            // 
            // txtMontoGravo
            // 
            this.txtMontoGravo.Location = new System.Drawing.Point(185, 21);
            this.txtMontoGravo.Name = "txtMontoGravo";
            this.txtMontoGravo.ReadOnly = true;
            this.txtMontoGravo.Size = new System.Drawing.Size(185, 22);
            this.txtMontoGravo.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(26, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(134, 16);
            this.label14.TabIndex = 12;
            this.label14.Text = "Monto Total Gravado";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Firmar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // item
            // 
            this.item.HeaderText = "Articulo";
            this.item.MinimumWidth = 6;
            this.item.Name = "item";
            this.item.Width = 125;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 125;
            // 
            // Montoitem
            // 
            this.Montoitem.HeaderText = "monto";
            this.Montoitem.MinimumWidth = 6;
            this.Montoitem.Name = "Montoitem";
            this.Montoitem.Width = 125;
            // 
            // FormEcf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 480);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEcf";
            this.Text = "FormEcf";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox txtFechaVencimiento;
        public System.Windows.Forms.TextBox txtEncf;
        public System.Windows.Forms.TextBox txtRazonSocialComprador;
        public System.Windows.Forms.TextBox txtRncComprador;
        public System.Windows.Forms.TextBox txtRazonSocialEmisor;
        public System.Windows.Forms.TextBox txtRncEmisor;
        public System.Windows.Forms.TextBox txtITBIS;
        public System.Windows.Forms.TextBox txtMontoTotal;
        public System.Windows.Forms.TextBox txtMontoExento;
        public System.Windows.Forms.TextBox txtMontoGravado1;
        public System.Windows.Forms.TextBox txtMontoGravo;
        public TextBox txtTipoCf;
        public DataGridView dataGridView1;
        private DataGridViewTextBoxColumn item;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Montoitem;
    }
}