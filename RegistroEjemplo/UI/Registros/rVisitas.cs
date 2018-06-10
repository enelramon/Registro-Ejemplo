using RegistroEjemplo.DAL;
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
    public partial class rVisitas : Form
    {
        public rVisitas()
        {
            InitializeComponent();
            LlenarComboBox();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdnumericUpDown.Value);
            Visitas visita = BLL.VisitasBLL.Buscar(id);

            if (visita != null)
            {
                LlenarCampos(visita);
            }
            else
                MessageBox.Show("No se encontro!", "Fallo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            IdnumericUpDown.Value = 0;
            fechaDateTimePicker.Value = DateTime.Now;
            comentariosTextBox.Clear();

            detalleDataGridView.DataSource = null;
            MyerrorProvider.Clear();
        }
        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Visitas visita;
            bool Paso = false;

            if (HayErrores())
            {
                MessageBox.Show("Favor revisar todos los campos", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            visita = LlenaClase();

            //Determinar si es Guardar o Modificar
            if (IdnumericUpDown.Value == 0)
                Paso = BLL.VisitasBLL.Guardar(visita);
            else
                //todo: validar que exista.
                Paso = BLL.VisitasBLL.Modificar(visita);

            //Informar el resultado
            if (Paso)
            {
                NuevoButton.PerformClick();
                MessageBox.Show("Guardado!!", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No se pudo guardar!!", "Fallo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdnumericUpDown.Value);

            //todo: validar que exista
            if (BLL.VisitasBLL.Eliminar(id))
                MessageBox.Show("Eliminado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo eliminar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
  
        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            List<VisitasDetalle> detalle = new List<VisitasDetalle>();

            if (detalleDataGridView.DataSource != null)
            {
                detalle = (List<VisitasDetalle>)detalleDataGridView.DataSource;
            }

            //Agregar un nuevo detalle con los datos introducidos.
            detalle.Add(
                new VisitasDetalle(
                    id: 0,
                    visitaId: (int)IdnumericUpDown.Value,
                    ciudadId: (int)CiudadcomboBox.SelectedValue,
                    cantidad: (int)CantidadnumericUpDown.Value
                ));

            //Cargar el detalle al Grid
            detalleDataGridView.DataSource = null;
            detalleDataGridView.DataSource = detalle;
        }

        private void LlenarComboBox()
        {
            Repositorio<Ciudades> repositorio = new Repositorio<Ciudades>(new Contexto());
            CiudadcomboBox.DataSource = repositorio.GetList(c => true);
            CiudadcomboBox.ValueMember = "CiudadId";
            CiudadcomboBox.DisplayMember = "Nombre";
        }

        private Visitas LlenaClase()
        {
            Visitas visita = new Visitas();

            visita.VisitaId = Convert.ToInt32(IdnumericUpDown.Value);
            visita.Fecha = fechaDateTimePicker.Value;
            visita.Comentarios = comentariosTextBox.Text;

            //Agregar cada linea del Grid al detalle
            foreach (DataGridViewRow item in detalleDataGridView.Rows)
            {
                visita.AgregarDetalle(
                    ToInt(item.Cells["Id"].Value),
                    ToInt(item.Cells["VisitaId"].Value),
                    ToInt(item.Cells["CiudadId"].Value),
                    ToInt(item.Cells["Cantidad"].Value)
                  );
            }
            return visita;
        }

        private void LlenarCampos(Visitas visita)
        {
            IdnumericUpDown.Value = visita.VisitaId;
            fechaDateTimePicker.Value = visita.Fecha;
            comentariosTextBox.Text = visita.Comentarios;

            //Cargar el detalle al Grid
            detalleDataGridView.DataSource = visita.Detalle;

            //Ocultar columnas
            detalleDataGridView.Columns["Id"].Visible = false;
            detalleDataGridView.Columns["CiudadId"].Visible = false;
        }
        private void Removerbutton_Click(object sender, EventArgs e)
        {
            if (detalleDataGridView.Rows.Count > 0 
                && detalleDataGridView.CurrentRow != null)
            {
                //convertir el grid en la lista
                List<VisitasDetalle> detalle 
                    = (List<VisitasDetalle>)detalleDataGridView.DataSource;

                //remover la fila
                detalle.RemoveAt(detalleDataGridView.CurrentRow.Index);

                // Cargar el detalle al Grid
                detalleDataGridView.DataSource = null;
                detalleDataGridView.DataSource = detalle;
            }
        }

        private bool HayErrores()
        {
            bool HayErrores = false;

            if (String.IsNullOrWhiteSpace(comentariosTextBox.Text))
            {
                MyerrorProvider.SetError(comentariosTextBox,
                    "No debes dejar el Comentario vacio");
                HayErrores = true;
            }

            if (detalleDataGridView.RowCount == 0)
            {
                MyerrorProvider.SetError(detalleDataGridView,
                    "Es obligatorio seleccionar las ciudades visitadas");
                HayErrores = true;
            }

            return HayErrores;
        }

        private int ToInt(object valor)
        {
            int retorno = 0;

            int.TryParse(valor.ToString(), out retorno);

            return retorno;
        }

       
    }
}
