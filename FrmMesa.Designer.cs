
namespace sime
{
    partial class FrmMesa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMesa));
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.pnlBorder = new System.Windows.Forms.Panel();
            this.pnlMesaAbierta = new System.Windows.Forms.Panel();
            this.pnlListaProductos = new System.Windows.Forms.Panel();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.lblAgregarProducto = new System.Windows.Forms.Label();
            this.pnlProductosConsumidos = new System.Windows.Forms.Panel();
            this.lblProductosConsumidos = new System.Windows.Forms.Label();
            this.lblProdcutos = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.lblSignoPesos = new System.Windows.Forms.Label();
            this.pnlBordeTotal = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDescTotal = new System.Windows.Forms.Label();
            this.ucControlBox = new sime.CustomControls.ucControlBox();
            this.pnlBottom.SuspendLayout();
            this.pnlMesaAbierta.SuspendLayout();
            this.pnlListaProductos.SuspendLayout();
            this.gbFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.pnlProductosConsumidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnVolver);
            this.pnlBottom.Controls.Add(this.btnAcceder);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(1, 669);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1278, 50);
            this.pnlBottom.TabIndex = 3;
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVolver.BackColor = System.Drawing.Color.Gray;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(1009, 9);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(122, 34);
            this.btnVolver.TabIndex = 9;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnAcceder
            // 
            this.btnAcceder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAcceder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAcceder.FlatAppearance.BorderSize = 0;
            this.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceder.ForeColor = System.Drawing.Color.White;
            this.btnAcceder.Location = new System.Drawing.Point(1137, 9);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(122, 34);
            this.btnAcceder.TabIndex = 8;
            this.btnAcceder.Text = "Cerrar mesa";
            this.btnAcceder.UseVisualStyleBackColor = false;
            // 
            // pnlBorder
            // 
            this.pnlBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBorder.Location = new System.Drawing.Point(1, 667);
            this.pnlBorder.Name = "pnlBorder";
            this.pnlBorder.Size = new System.Drawing.Size(1278, 2);
            this.pnlBorder.TabIndex = 4;
            // 
            // pnlMesaAbierta
            // 
            this.pnlMesaAbierta.Controls.Add(this.pnlListaProductos);
            this.pnlMesaAbierta.Controls.Add(this.pnlProductosConsumidos);
            this.pnlMesaAbierta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMesaAbierta.Location = new System.Drawing.Point(1, 51);
            this.pnlMesaAbierta.Name = "pnlMesaAbierta";
            this.pnlMesaAbierta.Size = new System.Drawing.Size(1278, 616);
            this.pnlMesaAbierta.TabIndex = 19;
            // 
            // pnlListaProductos
            // 
            this.pnlListaProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlListaProductos.Controls.Add(this.gbFiltros);
            this.pnlListaProductos.Controls.Add(this.lblFiltro);
            this.pnlListaProductos.Controls.Add(this.dgvInventario);
            this.pnlListaProductos.Controls.Add(this.lblAgregarProducto);
            this.pnlListaProductos.Location = new System.Drawing.Point(3, 8);
            this.pnlListaProductos.Name = "pnlListaProductos";
            this.pnlListaProductos.Size = new System.Drawing.Size(774, 602);
            this.pnlListaProductos.TabIndex = 17;
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.cmbCategoria);
            this.gbFiltros.Controls.Add(this.lblCategoria);
            this.gbFiltros.Location = new System.Drawing.Point(3, 51);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(209, 544);
            this.gbFiltros.TabIndex = 20;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtros";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "Bebidas",
            "Licuados",
            "Comidas"});
            this.cmbCategoria.Location = new System.Drawing.Point(13, 56);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(180, 38);
            this.cmbCategoria.TabIndex = 17;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCategoria.Location = new System.Drawing.Point(9, 32);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(77, 21);
            this.lblCategoria.TabIndex = 18;
            this.lblCategoria.Text = "Categoría";
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFiltro.Location = new System.Drawing.Point(214, 51);
            this.lblFiltro.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(179, 21);
            this.lblFiltro.TabIndex = 19;
            this.lblFiltro.Text = "Resultados de búsqueda";
            // 
            // dgvInventario
            // 
            this.dgvInventario.AllowUserToAddRows = false;
            this.dgvInventario.AllowUserToDeleteRows = false;
            this.dgvInventario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvInventario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInventario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvInventario.ColumnHeadersHeight = 30;
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvInventario.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInventario.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInventario.GridColor = System.Drawing.SystemColors.Control;
            this.dgvInventario.Location = new System.Drawing.Point(218, 76);
            this.dgvInventario.MultiSelect = false;
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.ReadOnly = true;
            this.dgvInventario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvInventario.RowHeadersVisible = false;
            this.dgvInventario.RowTemplate.Height = 30;
            this.dgvInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventario.Size = new System.Drawing.Size(553, 519);
            this.dgvInventario.TabIndex = 16;
            // 
            // lblAgregarProducto
            // 
            this.lblAgregarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAgregarProducto.AutoSize = true;
            this.lblAgregarProducto.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblAgregarProducto.Location = new System.Drawing.Point(12, 11);
            this.lblAgregarProducto.Name = "lblAgregarProducto";
            this.lblAgregarProducto.Size = new System.Drawing.Size(214, 20);
            this.lblAgregarProducto.TabIndex = 2;
            this.lblAgregarProducto.Text = "Buscar producto para agregar";
            // 
            // pnlProductosConsumidos
            // 
            this.pnlProductosConsumidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlProductosConsumidos.Controls.Add(this.lblProductosConsumidos);
            this.pnlProductosConsumidos.Controls.Add(this.lblProdcutos);
            this.pnlProductosConsumidos.Controls.Add(this.dgvProductos);
            this.pnlProductosConsumidos.Controls.Add(this.lblSignoPesos);
            this.pnlProductosConsumidos.Controls.Add(this.pnlBordeTotal);
            this.pnlProductosConsumidos.Controls.Add(this.lblTotal);
            this.pnlProductosConsumidos.Controls.Add(this.lblDescTotal);
            this.pnlProductosConsumidos.Location = new System.Drawing.Point(783, 8);
            this.pnlProductosConsumidos.Name = "pnlProductosConsumidos";
            this.pnlProductosConsumidos.Size = new System.Drawing.Size(492, 602);
            this.pnlProductosConsumidos.TabIndex = 16;
            // 
            // lblProductosConsumidos
            // 
            this.lblProductosConsumidos.AutoSize = true;
            this.lblProductosConsumidos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductosConsumidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblProductosConsumidos.Location = new System.Drawing.Point(10, 52);
            this.lblProductosConsumidos.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblProductosConsumidos.Name = "lblProductosConsumidos";
            this.lblProductosConsumidos.Size = new System.Drawing.Size(309, 21);
            this.lblProductosConsumidos.TabIndex = 21;
            this.lblProductosConsumidos.Text = "Productos pedidos por la mesa hasta ahora";
            // 
            // lblProdcutos
            // 
            this.lblProdcutos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProdcutos.AutoSize = true;
            this.lblProdcutos.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdcutos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblProdcutos.Location = new System.Drawing.Point(10, 11);
            this.lblProdcutos.Name = "lblProdcutos";
            this.lblProdcutos.Size = new System.Drawing.Size(191, 20);
            this.lblProdcutos.TabIndex = 1;
            this.lblProdcutos.Text = "Lista de productos pedidos";
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvProductos.ColumnHeadersHeight = 30;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProductos.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductos.GridColor = System.Drawing.SystemColors.Control;
            this.dgvProductos.Location = new System.Drawing.Point(14, 76);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.RowTemplate.Height = 30;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(462, 407);
            this.dgvProductos.TabIndex = 15;
            // 
            // lblSignoPesos
            // 
            this.lblSignoPesos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSignoPesos.AutoSize = true;
            this.lblSignoPesos.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignoPesos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSignoPesos.Location = new System.Drawing.Point(5, 508);
            this.lblSignoPesos.Name = "lblSignoPesos";
            this.lblSignoPesos.Size = new System.Drawing.Size(42, 50);
            this.lblSignoPesos.TabIndex = 11;
            this.lblSignoPesos.Text = "$";
            // 
            // pnlBordeTotal
            // 
            this.pnlBordeTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBordeTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlBordeTotal.Location = new System.Drawing.Point(14, 561);
            this.pnlBordeTotal.Name = "pnlBordeTotal";
            this.pnlBordeTotal.Size = new System.Drawing.Size(462, 1);
            this.pnlBordeTotal.TabIndex = 14;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotal.Location = new System.Drawing.Point(64, 512);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(425, 50);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "0.0";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDescTotal
            // 
            this.lblDescTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescTotal.AutoSize = true;
            this.lblDescTotal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDescTotal.Location = new System.Drawing.Point(434, 575);
            this.lblDescTotal.Name = "lblDescTotal";
            this.lblDescTotal.Size = new System.Drawing.Size(42, 20);
            this.lblDescTotal.TabIndex = 13;
            this.lblDescTotal.Text = "Total";
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
            this.ucControlBox.Size = new System.Drawing.Size(1278, 50);
            this.ucControlBox.TabIndex = 20;
            this.ucControlBox.Titulo = "TITULO";
            this.ucControlBox.TituloFont = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucControlBox.OnCloseHandler += new System.EventHandler(this.ucControlBox_OnCloseHandler);
            // 
            // FrmMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pnlMesaAbierta);
            this.Controls.Add(this.pnlBorder);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.ucControlBox);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMesa";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMesa";
            this.Load += new System.EventHandler(this.FrmMesa_Load);
            this.pnlBottom.ResumeLayout(false);
            this.pnlMesaAbierta.ResumeLayout(false);
            this.pnlListaProductos.ResumeLayout(false);
            this.pnlListaProductos.PerformLayout();
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.pnlProductosConsumidos.ResumeLayout(false);
            this.pnlProductosConsumidos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlBorder;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.Panel pnlMesaAbierta;
        private System.Windows.Forms.Label lblProdcutos;
        private System.Windows.Forms.Panel pnlBordeTotal;
        private System.Windows.Forms.Label lblDescTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSignoPesos;
        private CustomControls.ucControlBox ucControlBox;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Panel pnlProductosConsumidos;
        private System.Windows.Forms.Panel pnlListaProductos;
        private System.Windows.Forms.Label lblAgregarProducto;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.Label lblProductosConsumidos;
    }
}