using sime.App;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace sime.CustomControls
{
    public partial class ucControlBox : UserControl
    {
        #region "CONSTANTES"

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        #endregion

        #region "ATRIBUTOS"

        [DefaultValue(null)]
        [Description("Formulario padre (tipo SimeForm)"), Category("Data")]
        public SimeForm FormularioPadre { get; set; }

        [DefaultValue(null)]
        [Description("Evento que se ejecutará al dar click en la X"), Category("Data")]
        public event EventHandler OnCloseHandler;

        [DefaultValue("Child")]
        [Description("Titulo del Control Box"), Category("Data")]
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

        [Description("Tipo de fuente del titulo del Control Box"), Category("Data")]
        public Font TituloFont
        {
            get
            {
                return lblTitulo.Font;
            }

            set
            {
                lblTitulo.Font = value;
            }
        }

        #endregion

        public ucControlBox()
        {
            InitializeComponent();
            BackColor = C.COLOR_CONTROLBOX;
        }

        private void ucControlBox_Load(object sender, EventArgs e)
        {
            try
            {
                //if (FormularioPadre == null)
                //{
                //    throw new Exception("No se ha establecido la propiedad 'FormularioPadre' del ControlBox");
                //}

                //if (OnCloseHandler == null)
                //{
                //    throw new Exception("No se ha establecido el evento 'OnCloseHandler' del ControlBox");
                //}
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #region "BOTONES"

        private void lblOpCerrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (OnCloseHandler == null)
                {
                    return;
                }

                OnCloseHandler(sender, e);
            }
            catch (Exception ex)
            {
                if (FormularioPadre == null)
                {
                    return;
                }

                FormularioPadre.AlertError(ex.Message);
            }
        }

        private void lblOpMinimizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (FormularioPadre == null)
                {
                    return;
                }

                FormularioPadre.WindowState = FormWindowState.Minimized;
            }
            catch (Exception ex)
            {
                FormularioPadre.AlertError(ex.Message);
            }
        }

        #endregion

        #region "EVENTOS"

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (FormularioPadre == null)
                {
                    return;
                }

                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(FormularioPadre.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            }
            catch (Exception ex)
            {
                FormularioPadre.AlertError(ex.Message);
            }
        }

        private void lblOpCerrar_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                Label lbl = (Label)sender;
                lbl.BackColor = Color.IndianRed;
            }
            catch (Exception ex)
            {
                if (FormularioPadre == null)
                {
                    return;
                }

                FormularioPadre.AlertError(ex.Message);
            }
        }

        private void lblOpCerrar_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                Label lbl = (Label)sender;
                lbl.BackColor = BackColor;
            }
            catch (Exception ex)
            {
                if (FormularioPadre == null)
                {
                    return;
                }

                FormularioPadre.AlertError(ex.Message);
            }
        }

        private void lblOpMinimizar_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                Label lbl = (Label)sender;
                lbl.BackColor = Color.FromArgb(64, 0, 0);
            }
            catch (Exception ex)
            {
                if (FormularioPadre == null)
                {
                    return;
                }

                FormularioPadre.AlertError(ex.Message);
            }
        }

        private void lblOpMinimizar_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                Label lbl = (Label)sender;
                lbl.BackColor = BackColor;
            }
            catch (Exception ex)
            {
                if (FormularioPadre == null)
                {
                    return;
                }

                FormularioPadre.AlertError(ex.Message);
            }
        }

        #endregion
    }
}
