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

namespace RegistroEjemplo
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        //Esta es la clase en donde va la programacion del formulario del registro
        // aqui llamamos toda la programacion logica creada en la BLL

        private void Nuevo_Click(object sender, EventArgs e)
        {
            //Este es el evento click del boton nuevo, este metodo limpia la ventana.
            IDnumericUpDown.Value = 0;
            NombretextBox.Clear();
            CedulamaskedTextBox.Clear();
            DirecciontextBox.Clear();
            TelefonomaskedTextBox.Clear();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            //Este es el evento del boton guardar, aqui se llama el metodo guardar creado en la BLL de PersonaBLL y el metodo modificar

            Persona persona = LlenaClase();

            if(IDnumericUpDown.Value ==0)
            {
                if(BLL.PersonaBLL.Guardar(persona))
                {
                    MessageBox.Show("Guardado!!");
                }
                else
                {
                    MessageBox.Show("No se pudo guardar!!");
                }
            }
            else
            {
                if (BLL.PersonaBLL.Modificar(LlenaClase()))
                {
                    MessageBox.Show("Modificado!!");
                }
                else
                {
                    MessageBox.Show("No se pudo Modificar!!");
                }
            }
        }

        private Persona LlenaClase()
        {
            //Este es el metodo para llenar la clase persona 
            Persona persona = new Persona();
            persona.Id = Convert.ToInt32(IDnumericUpDown.Value);
            persona.Nombre = NombretextBox.Text;
            persona.Cedula = CedulamaskedTextBox.Text;
            persona.Direccion = DirecciontextBox.Text;
            persona.Telefono = TelefonomaskedTextBox.Text;
            return persona;
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            //El evento para eliminar una persona de la base de datos
            int id = Convert.ToInt32(IDnumericUpDown.Value);
            if (BLL.PersonaBLL.Eliminar(id))
            {
                MessageBox.Show("Eliminado!!");
            }
            else
            {
                MessageBox.Show("No se pudo eliminar!!");
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            //Este evento busca en la base de datos y lo agrega a los campos
            
            int id = Convert.ToInt32(IDnumericUpDown.Value);
            var persona = BLL.PersonaBLL.Buscar(id);
            if (persona != null)
            {
                NombretextBox.Text = persona.Nombre;
                CedulamaskedTextBox.Text = persona.Cedula;
                DirecciontextBox.Text = persona.Direccion;
                TelefonomaskedTextBox.Text = persona.Telefono;
            }
            else
            {
                MessageBox.Show("No se encontro!");
            }

        }

        private void Consultabutton_Click(object sender, EventArgs e)
        {
            cPersonas abrir = new cPersonas();
             abrir.Show();
        }
    }
}
