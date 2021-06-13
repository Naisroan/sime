
namespace sime.CustomControls
{
    partial class ucControlBox
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblOpMinimizar = new System.Windows.Forms.Label();
            this.lblOpCerrar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lblTitulo.Size = new System.Drawing.Size(290, 50);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "TITULO";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            // 
            // lblOpMinimizar
            // 
            this.lblOpMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblOpMinimizar.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold);
            this.lblOpMinimizar.Location = new System.Drawing.Point(290, 0);
            this.lblOpMinimizar.Name = "lblOpMinimizar";
            this.lblOpMinimizar.Size = new System.Drawing.Size(35, 50);
            this.lblOpMinimizar.TabIndex = 4;
            this.lblOpMinimizar.Text = "-";
            this.lblOpMinimizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOpMinimizar.Click += new System.EventHandler(this.lblOpMinimizar_Click);
            this.lblOpMinimizar.MouseEnter += new System.EventHandler(this.lblOpMinimizar_MouseEnter);
            this.lblOpMinimizar.MouseLeave += new System.EventHandler(this.lblOpMinimizar_MouseLeave);
            // 
            // lblOpCerrar
            // 
            this.lblOpCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblOpCerrar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpCerrar.Location = new System.Drawing.Point(325, 0);
            this.lblOpCerrar.Name = "lblOpCerrar";
            this.lblOpCerrar.Size = new System.Drawing.Size(35, 50);
            this.lblOpCerrar.TabIndex = 3;
            this.lblOpCerrar.Text = "X";
            this.lblOpCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOpCerrar.Click += new System.EventHandler(this.lblOpCerrar_Click);
            this.lblOpCerrar.MouseEnter += new System.EventHandler(this.lblOpCerrar_MouseEnter);
            this.lblOpCerrar.MouseLeave += new System.EventHandler(this.lblOpCerrar_MouseLeave);
            // 
            // ucControlBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblOpMinimizar);
            this.Controls.Add(this.lblOpCerrar);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucControlBox";
            this.Size = new System.Drawing.Size(360, 50);
            this.Load += new System.EventHandler(this.ucControlBox_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblOpMinimizar;
        private System.Windows.Forms.Label lblOpCerrar;
    }
}
