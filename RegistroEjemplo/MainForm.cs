
using RegistroEjemplo.UI.Consultas;
using RegistroEjemplo.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
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

        private void visitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rVisitas registro = new rVisitas();
            registro.MdiParent = this;
            registro.Show();
        }

        private async void VisitatoolStripButton_Click(object sender, EventArgs e)
        {
            VisitatoolStripButton.Enabled = false;
            int i =await  AccessTheWebAsync();
            MessageBox.Show(i.ToString());
            VisitatoolStripButton.Enabled = true;
        }
        async Task<int> AccessTheWebAsync()
        {
            HttpClient client = new HttpClient();

            // GetStringAsync returns a Task<string>. That means that when you await the 
            // task you'll get a string (urlContents).
            Task<string> getStringTask = client.GetStringAsync("http://msdn.microsoft.com");

            // You can do work here that doesn't rely on the string from GetStringAsync.
            //DoIndependentWork();

            // The await operator suspends AccessTheWebAsync. 
            //  - AccessTheWebAsync can't continue until getStringTask is complete. 
            //  - Meanwhile, control returns to the caller of AccessTheWebAsync. 
            //  - Control resumes here when getStringTask is complete.  
            //  - The await operator then retrieves the string result from getStringTask. 
            string urlContents = await getStringTask;

            // The return statement specifies an integer result. 
            // Any methods that are awaiting AccessTheWebAsync retrieve the length value. 
            return urlContents.Length;
        }
        private void visitasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cVisitas consulta = new cVisitas();
            consulta.MdiParent = this;
            consulta.Show();
        }

        private void ciudadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rCiudades rCiudades = new rCiudades();
            rCiudades.MdiParent = this;
            rCiudades.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }
    }
}
