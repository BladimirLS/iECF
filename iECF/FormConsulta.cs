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
    public partial class FormConsulta : Form
    {
        public FormConsulta()
        {
            InitializeComponent();
        }

        private void FormConsulta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'comp_ElectronicosDataSet6.comp_elec' table. You can move, or remove it, as needed.
            this.comp_elecTableAdapter2.Fill(this.comp_ElectronicosDataSet6.comp_elec);


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Comp_ElectronicosEntities1 comp = new Comp_ElectronicosEntities1();
            dataGridView1.DataSource = comp.comp_elec.Where(e => e.ENCF.Contains(textBox1.Text)).ToList();
        }
    }
}
