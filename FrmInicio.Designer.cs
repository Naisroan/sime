
namespace sime
{
    partial class FrmInicio
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            this.pnlMesas = new System.Windows.Forms.Panel();
            this.lblMiMesasTitulo = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.miSalir = new sime.CustomControls.ucMenuItem();
            this.miReportes = new sime.CustomControls.ucMenuItem();
            this.miMesas = new sime.CustomControls.ucMenuItem();
            this.miLogo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlBordeMenu = new System.Windows.Forms.Panel();
            this.ucControlBox = new sime.CustomControls.ucControlBox();
            this.pnlMesas.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.miLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMesas
            // 
            this.pnlMesas.AutoScroll = true;
            this.pnlMesas.Controls.Add(this.lblMiMesasTitulo);
            this.pnlMesas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMesas.Location = new System.Drawing.Point(76, 51);
            this.pnlMesas.Name = "pnlMesas";
            this.pnlMesas.Size = new System.Drawing.Size(1203, 676);
            this.pnlMesas.TabIndex = 5;
            // 
            // lblMiMesasTitulo
            // 
            this.lblMiMesasTitulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMiMesasTitulo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMiMesasTitulo.ForeColor = System.Drawing.Color.White;
            this.lblMiMesasTitulo.Location = new System.Drawing.Point(0, 657);
            this.lblMiMesasTitulo.Name = "lblMiMesasTitulo";
            this.lblMiMesasTitulo.Size = new System.Drawing.Size(1203, 19);
            this.lblMiMesasTitulo.TabIndex = 5;
            this.lblMiMesasTitulo.Text = "Mesas";
            this.lblMiMesasTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlMenu.Controls.Add(this.miSalir);
            this.pnlMenu.Controls.Add(this.miReportes);
            this.pnlMenu.Controls.Add(this.miMesas);
            this.pnlMenu.Controls.Add(this.miLogo);
            this.pnlMenu.Controls.Add(this.pnlBordeMenu);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(1, 1);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(75, 726);
            this.pnlMenu.TabIndex = 6;
            // 
            // miSalir
            // 
            this.miSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.miSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.miSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.miSalir.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miSalir.Icono = global::sime.Properties.Resources.power_off_b;
            this.miSalir.Location = new System.Drawing.Point(0, 641);
            this.miSalir.Name = "miSalir";
            this.miSalir.Size = new System.Drawing.Size(74, 85);
            this.miSalir.TabIndex = 6;
            this.miSalir.Tag = "app_salir";
            this.miSalir.Titulo = "Salir";
            // 
            // miReportes
            // 
            this.miReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.miReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.miReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.miReportes.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miReportes.Icono = global::sime.Properties.Resources.clipboard_b;
            this.miReportes.Location = new System.Drawing.Point(0, 135);
            this.miReportes.Name = "miReportes";
            this.miReportes.Size = new System.Drawing.Size(74, 85);
            this.miReportes.TabIndex = 5;
            this.miReportes.Tag = "rep_reportes";
            this.miReportes.Titulo = "Reportes";
            // 
            // miMesas
            // 
            this.miMesas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.miMesas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.miMesas.Dock = System.Windows.Forms.DockStyle.Top;
            this.miMesas.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miMesas.Icono = ((System.Drawing.Image)(resources.GetObject("miMesas.Icono")));
            this.miMesas.Location = new System.Drawing.Point(0, 50);
            this.miMesas.Name = "miMesas";
            this.miMesas.Size = new System.Drawing.Size(74, 85);
            this.miMesas.TabIndex = 4;
            this.miMesas.Tag = "cat_mesas";
            this.miMesas.Titulo = "Mesas";
            // 
            // miLogo
            // 
            this.miLogo.Controls.Add(this.lblTitulo);
            this.miLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.miLogo.Location = new System.Drawing.Point(0, 0);
            this.miLogo.Name = "miLogo";
            this.miLogo.Padding = new System.Windows.Forms.Padding(10);
            this.miLogo.Size = new System.Drawing.Size(74, 50);
            this.miLogo.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(10, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(54, 30);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = " S";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBordeMenu
            // 
            this.pnlBordeMenu.BackColor = System.Drawing.Color.LightCoral;
            this.pnlBordeMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBordeMenu.Location = new System.Drawing.Point(74, 0);
            this.pnlBordeMenu.Name = "pnlBordeMenu";
            this.pnlBordeMenu.Size = new System.Drawing.Size(1, 726);
            this.pnlBordeMenu.TabIndex = 0;
            // 
            // ucControlBox
            // 
            this.ucControlBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ucControlBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucControlBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucControlBox.ForeColor = System.Drawing.Color.White;
            this.ucControlBox.FormularioPadre = this;
            this.ucControlBox.Location = new System.Drawing.Point(76, 1);
            this.ucControlBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucControlBox.Name = "ucControlBox";
            this.ucControlBox.Size = new System.Drawing.Size(1203, 50);
            this.ucControlBox.TabIndex = 4;
            this.ucControlBox.Titulo = "";
            this.ucControlBox.TituloFont = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucControlBox.OnCloseHandler += new System.EventHandler(this.ucControlBox_OnCloseHandler);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1280, 728);
            this.Controls.Add(this.pnlMesas);
            this.Controls.Add(this.ucControlBox);
            this.Controls.Add(this.pnlMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmInicio";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.FrmInicio_Load);
            this.pnlMesas.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.miLogo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.ucControlBox ucControlBox;
        private System.Windows.Forms.Panel pnlMesas;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlBordeMenu;
        private System.Windows.Forms.Panel miLogo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblMiMesasTitulo;
        private CustomControls.ucMenuItem miReportes;
        private CustomControls.ucMenuItem miMesas;
        private CustomControls.ucMenuItem miSalir;
    }
}

