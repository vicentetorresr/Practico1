namespace Practico1.views
{
    partial class V_Usuario
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            dgvUsuario = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).BeginInit();
            SuspendLayout();
            // 
            // dgvUsuario
            // 
            dgvUsuario.Anchor = AnchorStyles.Top;
            dgvUsuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuario.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvUsuario.BorderStyle = BorderStyle.Fixed3D;
            dgvUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuario.Location = new Point(3, 79);
            dgvUsuario.Margin = new Padding(3, 4, 3, 4);
            dgvUsuario.Name = "dgvUsuario";
            dgvUsuario.RowHeadersWidth = 51;
            dgvUsuario.RowTemplate.Height = 25;
            dgvUsuario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuario.Size = new Size(949, 417);
            dgvUsuario.TabIndex = 0;
            // 
            // V_Usuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvUsuario);
            Margin = new Padding(3, 4, 3, 4);
            Name = "V_Usuario";
            Size = new Size(952, 496);
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvUsuario;
    }
}
