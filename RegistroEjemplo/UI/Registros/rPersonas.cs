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
    public partial class rPersonas : Form
    {
        public rPersonas()
        {
            InitializeComponent();
        }
       
        //todo: aprender a insertar los objetos desde datasources
        //todo: Poner taborder a los objetos
        private void NuevoButton_Click(object sender, EventArgs e)
        {
            IdnumericUpDown.Value = 0;
            FechadateTimePicker.Value = DateTime.Now;
            NombretextBox.Clear();
            CedulamaskedTextBox.Clear();
            DirecciontextBox.Clear();
            TelefonomaskedTextBox.Clear();
            MyerrorProvider.Clear();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Personas persona;
            bool Paso = false;
             
            if (!Validar()) { 
                MessageBox.Show("Favor revisar todos los campos", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            persona = LlenaClase();

            //Determinar si es Guardar o Modificar
            if (IdnumericUpDown.Value ==0)
                Paso = BLL.PersonasBLL.Guardar(persona) ; 
            else
                //todo: validar que exista.
                Paso =BLL.PersonasBLL.Modificar(persona) ;                 
           
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

            //todo: validar que exista
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
                FechadateTimePicker.Value = persona.Fecha;
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
            persona.Fecha = FechadateTimePicker.Value;
            persona.Nombres = NombretextBox.Text;
            persona.Cedula = CedulamaskedTextBox.Text;
            persona.Direccion = DirecciontextBox.Text;
            persona.Telefono = TelefonomaskedTextBox.Text;

            return persona;
        }

        private bool Validar()
        {
            bool HayErrores = false;
            //todo: quitar los mensajes de los errores que ya no estan.
            
            //todo: Validar que el nombre no se duplique
            if (String.IsNullOrWhiteSpace(TelefonomaskedTextBox.Text))
            {
                MyerrorProvider.SetError(TelefonomaskedTextBox,
                    "No debes dejar el nombre vacio");
                HayErrores = true;
            }

            //todo: validar demas campos
            return HayErrores;
        }
    }
}
