using Practico1.modelos;
using Practico1.servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Practico1.views
{
    public partial class V_Usuario : UserControl
    {
        private UsuarioServicio usuarioServicio;
        private BindingList<Usuario> usuarios;

        public V_Usuario()
        {
            InitializeComponent();
            usuarioServicio = new UsuarioServicio();
            usuarios = new BindingList<Usuario>();
            dgvUsuario.DataSource = usuarios;
            CargarUsuarios();
        }

        private async void CargarUsuarios()
        {
            try
            {
                // Llamar al método Index del servicio para obtener la lista de usuarios
                List<Usuario> listaDeUsuarios = await usuarioServicio.Index();

                // Asignar la lista de usuarios al BindingList
                usuarios.Clear();
                foreach (var usuario in listaDeUsuarios)
                {
                    usuarios.Add(usuario);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar usuarios: {ex.Message}");
            }
        }
    }
}
