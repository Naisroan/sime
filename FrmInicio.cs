using sime.App;
using sime.CustomControls;
using sime.Model;
using sime.Modulos.Catalogos;
using sime.Modulos.Reportes;
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
    public partial class FrmInicio : SimeForm
    {
        #region "ATRIBUTOS"

        FrmLogin Login = null;
        FrmSplash Splash = null;

        #endregion

        public FrmInicio()
        {
            InitializeComponent();

            Login = new FrmLogin(this);
            Splash = new FrmSplash(this);
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {
            try
            {
                Hide();
                EstablecerEventoClickMenus();

                Splash.ShowDialog();
                CargarMesas();

                // Login.ShowDialog();
            }
            catch (Exception ex)
            {
                AlertError(ex.Message);
            }
        }

        #region "METODOS"

        public void Init()
        {
            CargarMesas();
        }

        private void CargarMesas()
        {
            try
            {
                int LIMITE_COLUMNAS = GetLimiteColumas();
                int CONTROL_HEIGHT = 186;

                int width = (pnlMesas.Width / LIMITE_COLUMNAS);
                int height = CONTROL_HEIGHT;

                int xOffset = 0;
                int yOffset = 0;

                int count = 0;
                int rows = 0;

                pnlMesas.Controls.Clear();

                for (int i = 0; i < C.Mesas.Count; i++)
                {
                    Mesa mesa = C.Mesas[i];
                    ucMesa uc = new ucMesa(mesa);

                    xOffset = width * count;

                    uc.Width = width;
                    uc.Height = height;

                    uc.Dock = DockStyle.None;
                    uc.pbImagen.Click += Mesa_Click;
                    uc.Location = new Point(uc.Location.X + xOffset, yOffset);

                    pnlMesas.Controls.Add(uc);

                    count++;

                    if (count >= LIMITE_COLUMNAS)
                    {
                        rows++;
                        count = 0;
                        yOffset = rows * height;
                    }
                }
            }
            catch (Exception ex)
            {
                AlertError(ex.Message);
            }
        }

        private int GetLimiteColumas()
        {
            if (pnlMesas.Width >= 1400)
            {
                return 12;
            }

            if (pnlMesas.Width >= 1200)
            {
                return 8;
            }

            if (pnlMesas.Width >= 992)
            {
                return 6;
            }

            if (pnlMesas.Width >= 768)
            {
                return 4;
            }

            if (pnlMesas.Width >= 576)
            {
                return 2;
            }

            return 1;
        }

        private void EstablecerEventoClickMenus()
        {
            foreach (var ctrl in pnlMenu.Controls)
            {
                if (!(ctrl is ucMenuItem))
                {
                    return;
                }

                ucMenuItem item = (ucMenuItem)ctrl;
                item.Click += pnlMenu_Click;
            }
        }

        #endregion

        #region "EVENTOS"

        public void Mesa_Click(object sender, EventArgs e)
        {
            try
            {
                ucMesa uc = (ucMesa)((PictureBox)sender).Parent.Parent;

                FrmMesa mesa = new FrmMesa(uc.Mesa);
                mesa.ShowDialog();
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
                DialogResult response = AlertWarning("¿Desea salir?", MessageBoxButtons.YesNo);

                if (response == DialogResult.Yes)
                {
                    Splash.Dispose();
                    Login.Dispose();
                    Exit();
                }
            }
            catch (Exception ex)
            {
                AlertError(ex.Message);
            }
        }

        #endregion

        #region "BOTONES-MENU"

        private void pnlMenu_Click(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;

            if (!(sender is ucMenuItem))
            {
                return;
            }

            ucMenuItem item = (ucMenuItem)ctrl;

            switch (item.Titulo)
            {
                default:
                    break;

                case "Mesas":
                    {
                        DialogResult response = (new FrmMesaDetail()).ShowDialog(this);

                        if (response == DialogResult.OK)
                        {
                            CargarMesas();
                        }

                        break;
                    }

                case "Reportes":
                    {
                        DialogResult response = (new FrmReportes()).ShowDialog(this);

                        break;
                    }

                case "Salir":
                    {
                        ucControlBox_OnCloseHandler(null, null);
                        break;
                    }
            }
        }

        #endregion
    }
}
