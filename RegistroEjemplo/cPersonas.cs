using RegistroEjemplo.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroEjemplo
{
    public partial class cPersonas : Form
    {
        public cPersonas()
        {
            InitializeComponent();
        }
            
        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Expression<Func<Persona, bool>> filtrar = x => true;
            //Evento del boton buscar
            int id;
            switch (filtrarcomboBox.SelectedIndex)
            {
                //ID
                case 0:
                    id = Convert.ToInt32(CriteriotextBox.Text);
                    filtrar = x => x.Id == id;
                    break;

                // nombre
                case 1:
                    filtrar = x => x.Nombre.Equals(CriteriotextBox.Text);
                    break;
                // cedula
                case 2:
                    filtrar = x => x.Cedula.Equals(CriteriotextBox.Text);
                    break;
                // direccion
                case 3:
                    filtrar = x => x.Direccion.Equals(CriteriotextBox.Text);
                    break;
                //telefono
                case 4:
                    filtrar = x => x.Telefono.Equals(CriteriotextBox.Text);
                    break;
            }

            ConsultadataGridView.DataSource = BLL.PersonaBLL.GetList(filtrar);
        }
    }
}
