using sime.App;
using sime.CustomControls;
using sime.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sime
{
    public partial class FrmMesa : SimeForm
    {
        Mesa Mesa = null;

        DataSet dsProductos = new DataSet();
        DataSet dsInventario = new DataSet();

        public FrmMesa(Mesa mesa)
        {
            InitializeComponent();

            Mesa = mesa;
        }

        private void FrmMesa_Load(object sender, EventArgs e)
        {
            try
            {
                ucControlBox.Titulo = $"Estatus de la mesa <{Mesa.Nombre}>";
                // pnlControlBox.BackColor = ucMesa.GetColorFondoByOcupada(Mesa.Ocupada);

                dsProductos.Tables.Add("datos");

                dsProductos.Tables[0].Columns.Add("Nombre");
                dsProductos.Tables[0].Columns.Add("Cantidad");
                dsProductos.Tables[0].Columns.Add("Total");

                dsProductos.Tables[0].Rows.Add("Cocacola", 1, 36);
                dsProductos.Tables[0].Rows.Add("Cafe", 3, 50);

                dgvProductos.DataSource = dsProductos.Tables[0];
                dgvProductos.Refresh();

                for (int i = 0; i < dsProductos.Tables[0].Rows.Count; i++)
                {
                    lblTotal.Text = Convert.ToString(Convert.ToDecimal(lblTotal.Text) + Convert.ToDecimal(dsProductos.Tables[0].Rows[i]["Total"]));
                }

                dsInventario.Tables.Add("datos");

                dsInventario.Tables[0].Columns.Add("Codigo");
                dsInventario.Tables[0].Columns.Add("Nombre");
                dsInventario.Tables[0].Columns.Add("Precio");

                dsInventario.Tables[0].Rows.Add(1, "Cocacola", 36);
                dsInventario.Tables[0].Rows.Add(2, "Cafe", 25);
                dsInventario.Tables[0].Rows.Add(3, "Licuado de fresa", 30);
                dsInventario.Tables[0].Rows.Add(4, "Licuado de chocolate", 35);

                dgvInventario.DataSource = dsInventario.Tables[0];
                dgvInventario.Refresh();
            }
            catch (Exception ex)
            {
                AlertError(ex.Message);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void ucControlBox_OnCloseHandler(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void dgvInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvInventario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                {
                    return;
                }

                int idProducto = 0;
                string idProductoStr = Convert.ToString(dgvInventario.Rows[e.RowIndex].Cells["Codigo"].Value);

                if (string.IsNullOrEmpty(idProductoStr) || !int.TryParse(idProductoStr, out idProducto))
                {
                    return;
                }

                string nombre = Convert.ToString(dgvInventario.Rows[e.RowIndex].Cells["Nombre"].Value);
                decimal precio = Convert.ToDecimal(dgvInventario.Rows[e.RowIndex].Cells["Precio"].Value);

                dsProductos.Tables[0].Rows.Add(nombre, 1, precio);

                dgvProductos.DataSource = dsProductos.Tables[0];
                dgvProductos.Refresh();

                lblTotal.Text = "0.0";

                for (int i = 0; i < dsProductos.Tables[0].Rows.Count; i++)
                {
                    lblTotal.Text = Convert.ToString(Convert.ToDecimal(lblTotal.Text) + Convert.ToDecimal(dsProductos.Tables[0].Rows[i]["Total"]));
                }
            }
            catch (Exception ex)
            {
                AlertError(ex.Message);
            }
        }
    }
}
