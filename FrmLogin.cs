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

namespace sime
{
    public partial class FrmLogin : SimeForm
    {
        #region "ENUMERACIONES"

        private enum Mensaje
        {
            ERROR = 0,
            WARNING = 1
        }

        #endregion

        #region "ATRIBUTOS"

        FrmInicio Inicio = null;

        #endregion

        public FrmLogin(FrmInicio inicio)
        {
            InitializeComponent();

            Inicio = inicio;
            lblMensaje.Visible = false;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                MostrarMensaje(ex.Message, Mensaje.ERROR);
            }
        }

        #region "BOTONES"

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            try
            {
                btnAcceder.Enabled = false;

                if (!CamposValidos())
                {
                    btnAcceder.Enabled = true;
                    return;
                }

                LimpiarCampos();
                Hide();
                Inicio.Init();
                Inicio.Show();
            }
            catch (Exception ex)
            {
                MostrarMensaje(ex.Message, Mensaje.ERROR);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                Exit();
            }
            catch (Exception ex)
            {
                MostrarMensaje(ex.Message, Mensaje.ERROR);
            }
        }

        #endregion

        #region "METODOS"

        private bool CamposValidos()
        {
            try
            {
                if (string.IsNullOrEmpty(txtUsuario.Text))
                {
                    MostrarMensaje("Ingrese el usuario", Mensaje.WARNING);
                    txtUsuario.Focus();

                    return false;
                }

                if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    MostrarMensaje("Ingrese la contraseña", Mensaje.WARNING);
                    txtPassword.Focus();
                    txtPassword.SelectAll();

                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                MostrarMensaje(ex.Message, Mensaje.ERROR);
                return false;
            }
        }

        private void LimpiarCampos()
        {
            try
            {
                txtUsuario.Text = string.Empty;
                txtPassword.Text = string.Empty;

                btnAcceder.Enabled = true;

                MostrarMensaje(string.Empty, ocultar: true);
            }
            catch (Exception ex)
            {
                AlertError(ex.Message);
            }
        }

        private void MostrarMensaje(string texto, Mensaje mensaje = Mensaje.ERROR, bool ocultar = false)
        {
            lblMensaje.Visible = !ocultar;
            lblMensaje.Text = texto;
            lblMensaje.ForeColor = GetColorByMensaje(mensaje);
        }

        private Color GetColorByMensaje(Mensaje mensaje)
        {
            Color color = Color.Yellow;

            switch (mensaje)
            {
                case Mensaje.ERROR:
                    color = Color.IndianRed;
                    break;
                case Mensaje.WARNING:
                    color = Color.DarkOrange;
                    break;
                default:
                    break;
            }

            return color;
        }

        #endregion
    }
}
