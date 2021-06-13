
namespace sime.CustomControls
{
    partial class ucMesa
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
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pnlEstado = new System.Windows.Forms.Panel();
            this.lblOcupada = new System.Windows.Forms.Label();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.pnlContenido.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlEstado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContenido
            // 
            this.pnlContenido.BackColor = System.Drawing.Color.Transparent;
            this.pnlContenido.Controls.Add(this.pbImagen);
            this.pnlContenido.Controls.Add(this.pnlEstado);
            this.pnlContenido.Controls.Add(this.pnlTop);
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Location = new System.Drawing.Point(0, 0);
            this.pnlContenido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Size = new System.Drawing.Size(279, 339);
            this.pnlContenido.TabIndex = 0;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Transparent;
            this.pnlTop.Controls.Add(this.lblNombre);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Padding = new System.Windows.Forms.Padding(15);
            this.pnlTop.Size = new System.Drawing.Size(279, 48);
            this.pnlTop.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNombre.Location = new System.Drawing.Point(15, 15);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(249, 18);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "NOMBRE_MESA";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlEstado
            // 
            this.pnlEstado.BackColor = System.Drawing.Color.Maroon;
            this.pnlEstado.Controls.Add(this.lblOcupada);
            this.pnlEstado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlEstado.Location = new System.Drawing.Point(0, 291);
            this.pnlEstado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlEstado.Name = "pnlEstado";
            this.pnlEstado.Padding = new System.Windows.Forms.Padding(15);
            this.pnlEstado.Size = new System.Drawing.Size(279, 48);
            this.pnlEstado.TabIndex = 2;
            // 
            // lblOcupada
            // 
            this.lblOcupada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOcupada.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOcupada.ForeColor = System.Drawing.Color.White;
            this.lblOcupada.Location = new System.Drawing.Point(15, 15);
            this.lblOcupada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOcupada.Name = "lblOcupada";
            this.lblOcupada.Size = new System.Drawing.Size(249, 18);
            this.lblOcupada.TabIndex = 0;
            this.lblOcupada.Text = "ESTADO_MESA";
            this.lblOcupada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbImagen
            // 
            this.pbImagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbImagen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbImagen.Image = global::sime.Properties.Resources.download1;
            this.pbImagen.Location = new System.Drawing.Point(0, 48);
            this.pbImagen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(279, 243);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagen.TabIndex = 0;
            this.pbImagen.TabStop = false;
            // 
            // ucMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.pnlContenido);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucMesa";
            this.Size = new System.Drawing.Size(279, 339);
            this.Tag = "0";
            this.Load += new System.EventHandler(this.ucMesa_Load);
            this.pnlContenido.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlEstado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Panel pnlEstado;
        private System.Windows.Forms.Label lblOcupada;
        public System.Windows.Forms.PictureBox pbImagen;
    }
}
