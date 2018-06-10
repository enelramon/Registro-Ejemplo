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

namespace RegistroEjemplo.UI.Consultas
{
    public partial class cVisitas : Form
    {
        public cVisitas()
        {
            InitializeComponent();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            //Inicializando el filtro en True
            Expression<Func<Visitas, bool>> filtro = p => true;

            int id;
            switch (filtrarcomboBox.SelectedIndex)
            {
                case 1://ID
                    id = Convert.ToInt32(CriteriotextBox.Text);
                    filtro = p => p.VisitaId == id
                    && (p.Fecha >= DesdedateTimePicker.Value && p.Fecha <= HastadateTimePicker.Value);
                    break;
                case 2:// Comentarios
                    filtro = p => p.Comentarios.Contains(CriteriotextBox.Text)
                    && (p.Fecha >= DesdedateTimePicker.Value && p.Fecha <= HastadateTimePicker.Value);
                    break;
                 
            }


            ConsultadataGridView.DataSource = BLL.VisitasBLL.GetList(filtro);
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
