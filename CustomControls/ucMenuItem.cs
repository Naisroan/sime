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

namespace sime.CustomControls
{
    public partial class ucMenuItem : UserControl
    {
        #region "CONSTANTES"

        public static Color COLOR_ON_MOUSE_ENTER = Color.Maroon;

        public static Color COLOR_ON_MOUSE_LEAVE = C.COLOR_CONTROLBOX;

        #endregion

        #region "ATRIBUTOS"

        [Description("Icono del menu"), Category("Data")]
        public Image Icono
        {
            get
            {
                return pbImagen.Image;
            }

            set
            {
                pbImagen.Image = value;
            }
        }

        [Description("Titulo del menu"), Category("Data")]
        public string Titulo
        {
            get
            {
                return lblTitulo.Text;
            }

            set
            {
                lblTitulo.Text = value;
            }
        }

        #endregion

        public ucMenuItem()
        {
            InitializeComponent();
        }

        private void ucMenuItem_Load(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
            }
        }

        #region "EVENTOS"

        private void ucMenuItem_MouseLeave(object sender, EventArgs e)
        {
            pnlImagen.BackColor = COLOR_ON_MOUSE_LEAVE;
            lblTitulo.BackColor = COLOR_ON_MOUSE_LEAVE;
        }

        #endregion

        private void ucMenuItem_MouseEnter(object sender, EventArgs e)
        {
            pnlImagen.BackColor = COLOR_ON_MOUSE_ENTER;
            lblTitulo.BackColor = COLOR_ON_MOUSE_ENTER;
        }
    }
}
