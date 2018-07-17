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

namespace RegistroEjemplo.UI.Reportes
{
    public partial class PersonasReportViewer : Form
    {
        private List<Personas> ListaPersonas;
        public PersonasReportViewer(List<Personas> personas)
        {
            this.ListaPersonas = personas;
            InitializeComponent();
        }

        private void ReportViewer_Load(object sender, EventArgs e)
        {
            ListadoPersonas listadoPersonas = new ListadoPersonas();
            listadoPersonas.SetDataSource(ListaPersonas);//pasar lista al reporte

            MycrystalReportViewer.ReportSource = listadoPersonas; //asignar el reporte a visor
            MycrystalReportViewer.Refresh();
        }
    }
}
