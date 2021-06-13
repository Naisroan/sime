
namespace sime.CustomControls
{
    partial class ucMenuItem
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
            this.pnlImagen = new System.Windows.Forms.Panel();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlImagen
            // 
            this.pnlImagen.Controls.Add(this.pbImagen);
            this.pnlImagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlImagen.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlImagen.Enabled = false;
            this.pnlImagen.Location = new System.Drawing.Point(0, 0);
            this.pnlImagen.Name = "pnlImagen";
            this.pnlImagen.Padding = new System.Windows.Forms.Padding(15);
            this.pnlImagen.Size = new System.Drawing.Size(74, 61);
            this.pnlImagen.TabIndex = 0;
            this.pnlImagen.MouseEnter += new System.EventHandler(this.ucMenuItem_MouseEnter);
            this.pnlImagen.MouseLeave += new System.EventHandler(this.ucMenuItem_MouseLeave);
            // 
            // pbImagen
            // 
            this.pbImagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbImagen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbImagen.Image = global::sime.Properties.Resources.tablets_b;
            this.pbImagen.Location = new System.Drawing.Point(15, 15);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(44, 31);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagen.TabIndex = 0;
            this.pbImagen.TabStop = false;
            this.pbImagen.MouseEnter += new System.EventHandler(this.ucMenuItem_MouseEnter);
            this.pbImagen.MouseLeave += new System.EventHandler(this.ucMenuItem_MouseLeave);
            // 
            // lblTitulo
            // 
            this.lblTitulo.CausesValidation = false;
            this.lblTitulo.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 61);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(74, 24);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Titulo";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitulo.MouseEnter += new System.EventHandler(this.ucMenuItem_MouseEnter);
            this.lblTitulo.MouseLeave += new System.EventHandler(this.ucMenuItem_MouseLeave);
            // 
            // ucMenuItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlImagen);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ucMenuItem";
            this.Size = new System.Drawing.Size(74, 85);
            this.Load += new System.EventHandler(this.ucMenuItem_Load);
            this.MouseEnter += new System.EventHandler(this.ucMenuItem_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ucMenuItem_MouseLeave);
            this.pnlImagen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlImagen;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Label lblTitulo;
    }
}
