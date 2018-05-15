
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroEjemplo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void pruebaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Prueba p =new Prueba();
            //p.ShowDialog();
        }

        private void personasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rPersonas registro = new rPersonas();
            registro.MdiParent = this;
            registro.Show();          
        }

        private void PersonastoolStripButton_Click(object sender, EventArgs e)
        {
            personasToolStripMenuItem_Click(sender,e);
        }

        private void personasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cPersonas consulta = new cPersonas();
            consulta.MdiParent = this;
            consulta.Show();
        }
    }
}
