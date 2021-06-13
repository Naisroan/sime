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

                DataSet ds = new DataSet();
                ds.Tables.Add("datos");

                ds.Tables[0].Columns.Add("Nombre");
                ds.Tables[0].Columns.Add("Cantidad");
                ds.Tables[0].Columns.Add("Total");

                ds.Tables[0].Rows.Add("Cocacola", 1, 36);
                ds.Tables[0].Rows.Add("Cafe", 3, 50);

                dgvProductos.DataSource = ds.Tables[0];
                dgvProductos.Refresh();

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    lblTotal.Text = Convert.ToString(Convert.ToDecimal(lblTotal.Text) + Convert.ToDecimal(ds.Tables[0].Rows[i]["Total"]));
                }

                DataSet dsInventario = new DataSet();
                dsInventario.Tables.Add("datos");

                dsInventario.Tables[0].Columns.Add("Nombre");
                dsInventario.Tables[0].Columns.Add("Precio");

                dsInventario.Tables[0].Rows.Add("Cocacola", 36);
                dsInventario.Tables[0].Rows.Add("Cafe", 25);
                dsInventario.Tables[0].Rows.Add("Licuado de fresa", 30);
                dsInventario.Tables[0].Rows.Add("Licuado de chocolate", 35);

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
    }
}
