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
       
        private void NuevoButton_Click(object sender, EventArgs e)
        {
            IdnumericUpDown.Value = 0;
            NombretextBox.Clear();
            CedulamaskedTextBox.Clear();
            DirecciontextBox.Clear();
            TelefonomaskedTextBox.Clear();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Personas persona = LlenaClase();
            bool Paso = false;

            //Determinar si es Guardar o Modificar
            if(IdnumericUpDown.Value ==0)
                Paso = BLL.PersonasBLL.Guardar(persona) ; 
            else
                Paso =BLL.PersonasBLL.Modificar(LlenaClase()) ;                 
           
            //Informar el resultado
            if (Paso )
                MessageBox.Show("Guardado!!","Exito",
                    MessageBoxButtons.OK,MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo guardar!!", "Fallo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
            
        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdnumericUpDown.Value);

            if (BLL.PersonasBLL.Eliminar(id))
                MessageBox.Show("Eliminado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo eliminar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdnumericUpDown.Value);
            Personas persona = BLL.PersonasBLL.Buscar(id);

            if (persona != null)
            {
                NombretextBox.Text = persona.Nombres;
                CedulamaskedTextBox.Text = persona.Cedula;
                DirecciontextBox.Text = persona.Direccion;
                TelefonomaskedTextBox.Text = persona.Telefono;
            }
            else 
                MessageBox.Show("No se encontro!", "Fallo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private Personas LlenaClase()
        {
            Personas persona = new Personas();

            persona.PersonaId = Convert.ToInt32(IdnumericUpDown.Value);
            persona.Nombres = NombretextBox.Text;
            persona.Cedula = CedulamaskedTextBox.Text;
            persona.Direccion = DirecciontextBox.Text;
            persona.Telefono = TelefonomaskedTextBox.Text;

            return persona;
        }
    }
}
