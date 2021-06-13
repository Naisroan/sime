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

namespace sime.CustomControls
{
    public partial class ucMesa : UserControl
    {
        #region "CONSTANTES"

        public static Color COLOR_MESA_OCUPADA = Color.Maroon;
        public static Color COLOR_MESA_DESOCUPADA = Color.FromArgb(0, 192, 0);

        public static Color COLOR_FONDO_MESA_OCUPADA = Color.FromArgb(255, 192, 192);
        public static Color COLOR_FONDO_MESA_DESOCUPADA = Color.FromArgb(192, 255, 192);

        public static string TEXTO_MESA_OCUPADA = "Ocupada";
        public static string TEXTO_MESA_DESOCUPADA = "Disponible";

        #endregion

        #region "ATRIBUTOS"

        public Mesa Mesa = null;

        #endregion

        public ucMesa(Mesa mesa)
        {
            InitializeComponent();

            Mesa = mesa;
        }

        private void ucMesa_Load(object sender, EventArgs e)
        {
            try
            {
                lblNombre.Text = Mesa.Nombre;
                lblOcupada.Text = GetTextByOcupada(Mesa.Ocupada);

                BackColor = GetColorFondoByOcupada(Mesa.Ocupada);
                pnlEstado.BackColor = GetColorByOcupada(Mesa.Ocupada);
            }
            catch (Exception ex)
            {
            }
        }

        #region "METODOS"

        public static string GetTextByOcupada(bool ocupada)
        {
            return ocupada ? TEXTO_MESA_OCUPADA : TEXTO_MESA_DESOCUPADA;
        }

        public static Color GetColorFondoByOcupada(bool ocupada)
        {
            return ocupada ? COLOR_FONDO_MESA_OCUPADA : COLOR_FONDO_MESA_DESOCUPADA;
        }

        public static Color GetColorByOcupada(bool ocupada)
        {
            return ocupada ? COLOR_MESA_OCUPADA : COLOR_MESA_DESOCUPADA;
        }

        #endregion
    }
}
