using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iECF
{
    public partial class Firma : Form
    {
        public Firma()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                FormEcf formEcf = new FormEcf(dataGridView1);

                formEcf.dataGridView1.Rows.Add(new string[]
                {
                    Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString()),
                    Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString()),
                    Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString())
                });
                
                formEcf.txtTipoCf.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                formEcf.txtEncf.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                formEcf.txtFechaVencimiento.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                formEcf.txtRncEmisor.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                formEcf.txtRazonSocialEmisor.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                formEcf.txtRncComprador.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                formEcf.txtRazonSocialComprador.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                formEcf.txtMontoGravado1.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
                formEcf.txtMontoTotal.Text = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
                //AddOwnedForm(formEcf);
                formEcf.Show();
            }

        }

        private void Firma_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'comp_ElectronicosDataSet4.firma_comp' table. You can move, or remove it, as needed.
            this.firma_compTableAdapter.Fill(this.comp_ElectronicosDataSet4.firma_comp);
            // TODO: This line of code loads data into the 'comp_ElectronicosDataSet3.firma_comp_elec' table. You can move, or remove it, as needed.
            this.firma_comp_elecTableAdapter1.Fill(this.comp_ElectronicosDataSet3.firma_comp_elec);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Comp_ElectronicosEntities1 comp = new Comp_ElectronicosEntities1();
            dataGridView1.DataSource = comp.firma_comp_elec.Where(e => e.ENCF.Contains(textBox1.Text)).ToList();

        }
    }
}
