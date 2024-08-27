using Practico1.modelos;
using Practico1.servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico1.views
{
    public partial class V_Proyecto : UserControl
    {

        private ProyectoServicio proyectoServicio;

        public V_Proyecto()
        {
            InitializeComponent();
            proyectoServicio = new ProyectoServicio();
            CargarProyectos();
        }

        private async void CargarProyectos()
        {
            try
            {
                // Llamar al método Index del servicio para obtener la lista de proyectos
                List<Proyecto> listaDeProyectos = await proyectoServicio.Index();

                // Asignar la lista de proyectos como fuente de datos del DataGridView
                dgvProyecto.DataSource = listaDeProyectos;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar proyectos: {ex.Message}");
            }
        }

        private void dgvProyecto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que la fila seleccionada no sea la fila del encabezado (índice de fila -1)
            if (e.RowIndex >= 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow selectedRow = dgvProyecto.Rows[e.RowIndex];

                // Establecer los valores de las celdas en los campos de texto correspondientes
                txtId.Text = selectedRow.Cells["id"].Value.ToString();
                txtNombre.Text = selectedRow.Cells["name"].Value.ToString();
                txtDescripcion.Text = selectedRow.Cells["description"].Value.ToString();
                txtWorkHours.Text = selectedRow.Cells["workerhours"].Value.ToString();
                txtTotalHour.Text = selectedRow.Cells["totalhours"].Value.ToString();

                // Verifica que los datos de la celda no sean nulos antes de convertirlos a cadena.
                txtId.Text = selectedRow.Cells["id"].Value?.ToString() ?? string.Empty;
                txtNombre.Text = selectedRow.Cells["name"].Value?.ToString() ?? string.Empty;
                txtDescripcion.Text = selectedRow.Cells["description"].Value?.ToString() ?? string.Empty;
                txtWorkHours.Text = selectedRow.Cells["workerhours"].Value?.ToString() ?? string.Empty;
                txtTotalHour.Text = selectedRow.Cells["totalhours"].Value?.ToString() ?? string.Empty;
                showBtn();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            unShow();
            txtId.ResetText();
            txtNombre.ResetText();
            txtDescripcion.ResetText();
            txtWorkHours.ResetText();
            txtTotalHour.ResetText();
        }

        private void showBtn()
        {
            btnIngresar.Enabled = false;
            btnIngresar.Visible = false;

            btnCancelar.Enabled = true;
            btnCancelar.Visible = true;

            btnActualizar.Enabled = true;
            btnActualizar.Visible = true;
        }

        private void unShow()
        {
            btnCancelar.Enabled = false;
            btnCancelar.Visible = false;
            btnActualizar.Enabled = false;
            btnActualizar.Visible = false;

            btnIngresar.Enabled = true;
            btnIngresar.Visible = true;
        }

    }
}
