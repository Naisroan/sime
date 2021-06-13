using sime.App;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sime.Modulos.Catalogos
{
    public partial class FrmMesaDetail : SimeForm
    {
        public FrmMesaDetail()
        {
            InitializeComponent();
        }

        private void FrmMesaDetail_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                AlertError(ex.Message);
            }
        }

        private void ucControlBox_OnCloseHandler(object sender, EventArgs e)
        {
            try
            {
                DialogResult = DialogResult.Cancel;
                Close();
            }
            catch (Exception ex)
            {
                AlertError(ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                C.Mesas.Add(new Model.Mesa()
                {
                    IdMesa = C.Mesas.Count + 1,
                    Nombre = txtNombre.Text,
                    Activa = cmbEstatus.SelectedIndex == 0,
                    Ocupada = cmbOcupada.SelectedIndex == 0,
                    CantidadSillas = (int)txtCantidadSillas.Value
                });

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                AlertError(ex.Message);
            }
        }
    }
}
