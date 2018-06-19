using RegistroEjemplo.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroEjemplo.UI.Registros
{
    public partial class rCiudades : Form
    {
        public rCiudades()
        {
            InitializeComponent();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            BLL.RepositorioBase<Ciudades> CiudadesBll = new BLL.RepositorioBase<Ciudades>(new DAL.Contexto());

            int id = Convert.ToInt32(IdnumericUpDown.Value);
            Ciudades ciudad = CiudadesBll.Buscar(id);

            if (ciudad != null)
            {
                 
                nombreTextBox.Text = ciudad.Nombre;
                CantidadtextBox.Text = ciudad.CantidadVisitas.ToString(); 
            }
            else
                MessageBox.Show("No se encontro!", "Fallo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
