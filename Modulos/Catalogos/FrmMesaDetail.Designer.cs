
namespace sime.Modulos.Catalogos
{
    partial class FrmMesaDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMesaDetail));
            this.ucControlBox = new sime.CustomControls.ucControlBox();
            this.pnlBorder = new System.Windows.Forms.Panel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblInstrucciones = new System.Windows.Forms.Label();
            this.lblCantidadSillas = new System.Windows.Forms.Label();
            this.txtCantidadSillas = new System.Windows.Forms.NumericUpDown();
            this.cmbEstatus = new System.Windows.Forms.ComboBox();
            this.lblEstatus = new System.Windows.Forms.Label();
            this.lblOcupada = new System.Windows.Forms.Label();
            this.cmbOcupada = new System.Windows.Forms.ComboBox();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadSillas)).BeginInit();
            this.SuspendLayout();
            // 
            // ucControlBox
            // 
            this.ucControlBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ucControlBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucControlBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucControlBox.ForeColor = System.Drawing.Color.White;
            this.ucControlBox.FormularioPadre = this;
            this.ucControlBox.Location = new System.Drawing.Point(1, 1);
            this.ucControlBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucControlBox.Name = "ucControlBox";
            this.ucControlBox.Size = new System.Drawing.Size(470, 50);
            this.ucControlBox.TabIndex = 0;
            this.ucControlBox.Titulo = "Agregar Mesa";
            this.ucControlBox.TituloFont = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucControlBox.OnCloseHandler += new System.EventHandler(this.ucControlBox_OnCloseHandler);
            // 
            // pnlBorder
            // 
            this.pnlBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBorder.Location = new System.Drawing.Point(1, 300);
            this.pnlBorder.Name = "pnlBorder";
            this.pnlBorder.Size = new System.Drawing.Size(470, 2);
            this.pnlBorder.TabIndex = 6;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.button1);
            this.pnlBottom.Controls.Add(this.btnVolver);
            this.pnlBottom.Controls.Add(this.btnGuardar);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(1, 302);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(470, 60);
            this.pnlBottom.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(208, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 34);
            this.button1.TabIndex = 10;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ucControlBox_OnCloseHandler);
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVolver.BackColor = System.Drawing.Color.Gray;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(80, 13);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(122, 34);
            this.btnVolver.TabIndex = 9;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.ucControlBox_OnCloseHandler);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(336, 13);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(122, 34);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombre.Location = new System.Drawing.Point(12, 138);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(290, 35);
            this.txtNombre.TabIndex = 8;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNombre.Location = new System.Drawing.Point(9, 113);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(146, 21);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre de la mesa";
            // 
            // lblInstrucciones
            // 
            this.lblInstrucciones.AutoSize = true;
            this.lblInstrucciones.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstrucciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblInstrucciones.Location = new System.Drawing.Point(9, 75);
            this.lblInstrucciones.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblInstrucciones.Name = "lblInstrucciones";
            this.lblInstrucciones.Size = new System.Drawing.Size(217, 21);
            this.lblInstrucciones.TabIndex = 9;
            this.lblInstrucciones.Text = "Ingrese los siguientes datos:";
            // 
            // lblCantidadSillas
            // 
            this.lblCantidadSillas.AutoSize = true;
            this.lblCantidadSillas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadSillas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCantidadSillas.Location = new System.Drawing.Point(305, 113);
            this.lblCantidadSillas.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCantidadSillas.Name = "lblCantidadSillas";
            this.lblCantidadSillas.Size = new System.Drawing.Size(110, 21);
            this.lblCantidadSillas.TabIndex = 10;
            this.lblCantidadSillas.Text = "Cantidad sillas";
            // 
            // txtCantidadSillas
            // 
            this.txtCantidadSillas.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadSillas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCantidadSillas.Location = new System.Drawing.Point(308, 138);
            this.txtCantidadSillas.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.txtCantidadSillas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtCantidadSillas.Name = "txtCantidadSillas";
            this.txtCantidadSillas.Size = new System.Drawing.Size(152, 35);
            this.txtCantidadSillas.TabIndex = 12;
            this.txtCantidadSillas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmbEstatus
            // 
            this.cmbEstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstatus.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbEstatus.FormattingEnabled = true;
            this.cmbEstatus.Items.AddRange(new object[] {
            "Habilitada",
            "Deshabilitada"});
            this.cmbEstatus.Location = new System.Drawing.Point(240, 225);
            this.cmbEstatus.Name = "cmbEstatus";
            this.cmbEstatus.Size = new System.Drawing.Size(220, 38);
            this.cmbEstatus.TabIndex = 13;
            // 
            // lblEstatus
            // 
            this.lblEstatus.AutoSize = true;
            this.lblEstatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEstatus.Location = new System.Drawing.Point(237, 200);
            this.lblEstatus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEstatus.Name = "lblEstatus";
            this.lblEstatus.Size = new System.Drawing.Size(59, 21);
            this.lblEstatus.TabIndex = 14;
            this.lblEstatus.Text = "Estatus";
            // 
            // lblOcupada
            // 
            this.lblOcupada.AutoSize = true;
            this.lblOcupada.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOcupada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblOcupada.Location = new System.Drawing.Point(9, 200);
            this.lblOcupada.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblOcupada.Name = "lblOcupada";
            this.lblOcupada.Size = new System.Drawing.Size(79, 21);
            this.lblOcupada.TabIndex = 16;
            this.lblOcupada.Text = "Ocupada?";
            // 
            // cmbOcupada
            // 
            this.cmbOcupada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOcupada.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOcupada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbOcupada.FormattingEnabled = true;
            this.cmbOcupada.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cmbOcupada.Location = new System.Drawing.Point(12, 225);
            this.cmbOcupada.Name = "cmbOcupada";
            this.cmbOcupada.Size = new System.Drawing.Size(220, 38);
            this.cmbOcupada.TabIndex = 15;
            // 
            // FrmMesaDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(472, 363);
            this.Controls.Add(this.lblOcupada);
            this.Controls.Add(this.cmbOcupada);
            this.Controls.Add(this.lblEstatus);
            this.Controls.Add(this.cmbEstatus);
            this.Controls.Add(this.txtCantidadSillas);
            this.Controls.Add(this.lblCantidadSillas);
            this.Controls.Add(this.lblInstrucciones);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.pnlBorder);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.ucControlBox);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMesaDetail";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMesaDetail";
            this.Load += new System.EventHandler(this.FrmMesaDetail_Load);
            this.pnlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadSillas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.ucControlBox ucControlBox;
        private System.Windows.Forms.Panel pnlBorder;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblInstrucciones;
        private System.Windows.Forms.NumericUpDown txtCantidadSillas;
        private System.Windows.Forms.Label lblCantidadSillas;
        private System.Windows.Forms.Label lblOcupada;
        private System.Windows.Forms.ComboBox cmbOcupada;
        private System.Windows.Forms.Label lblEstatus;
        private System.Windows.Forms.ComboBox cmbEstatus;
    }
}