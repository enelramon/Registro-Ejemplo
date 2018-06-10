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
            //Inicializando el filtro en True
            Expression<Func<Personas, bool>> filtro = x => true;
           
            int id;
            switch (filtrarcomboBox.SelectedIndex)
            {                
                case 0://ID
                    id = Convert.ToInt32(CriteriotextBox.Text);
                    filtro = x => x.PersonaId == id 
                    && (x.Fecha>= DesdedateTimePicker.Value && x.Fecha <= HastadateTimePicker.Value)  ;
                    break;                
                case 1:// nombre
                    filtro = x => x.Nombres.Contains(CriteriotextBox.Text) 
                    && (x.Fecha >= DesdedateTimePicker.Value && x.Fecha <= HastadateTimePicker.Value);
                    break;                
                case 2:// cedula
                    filtro = x => x.Cedula.Equals(CriteriotextBox.Text) 
                    && (x.Fecha >= DesdedateTimePicker.Value && x.Fecha <= HastadateTimePicker.Value);
                    break;                
                case 3:// direccion
                    filtro = x => x.Direccion.Contains(CriteriotextBox.Text) 
                    && (x.Fecha >= DesdedateTimePicker.Value && x.Fecha <= HastadateTimePicker.Value);
                    break;                
                case 4://telefono
                    filtro = x => x.Telefono.Equals(CriteriotextBox.Text) 
                    && (x.Fecha >= DesdedateTimePicker.Value && x.Fecha <= HastadateTimePicker.Value);
                    break;
            }
             

            ConsultadataGridView.DataSource = BLL.PersonasBLL.GetList(filtro);
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
