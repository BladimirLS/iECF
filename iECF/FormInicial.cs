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
    public partial class FormInicial : Form
    {
        public FormInicial()
        {
            InitializeComponent();
            WindowState = FormWindowState.Minimized;
            MaximizeBox = false;


        }

        private void FormInicial_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void firmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Firma form = new Firma();
            form.ShowDialog();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsulta form = new FormConsulta();
            form.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
