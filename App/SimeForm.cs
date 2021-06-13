using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sime.App
{
    public class SimeForm : Form
    {
        #region "ENUMERACIONES"

        private enum Alert
        {
            ERROR = 0,
            SUCCESS = 1,
            WARNING = 2,
            INFO = 3
        }

        #endregion

        #region "ATRIBUTOS"

        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        const int CS_DROPSHADOW = 0x20000;

        //        CreateParams cp = base.CreateParams;
        //        cp.ClassStyle |= CS_DROPSHADOW;

        //        return cp;
        //    }
        //}

        protected override void OnPaint(PaintEventArgs e)
        {
            Padding = new Padding(1);
            e.Graphics.DrawRectangle(Pens.Maroon, new Rectangle(0, 0, Width - 1, Height - 1));
        }

        #endregion

        #region "METODOS"

        private string GetCaptionByAlert(Alert alert)
        {
            string caption = "Atención";

            switch (alert)
            {
                case Alert.ERROR:
                    caption = "Ha ocurrido un error";
                    break;
                case Alert.SUCCESS:
                    caption = "¡Éxito!";
                    break;
                case Alert.WARNING:
                    caption = "¡Espere!";
                    break;
                case Alert.INFO:
                    caption = "Atención...";
                    break;
                default:
                    break;
            }

            return caption;
        }

        public DialogResult AlertError(string texto, MessageBoxButtons buttons = MessageBoxButtons.OK)
        {
            return MessageBox.Show(this, texto, GetCaptionByAlert(Alert.ERROR), buttons, MessageBoxIcon.Error);
        }

        public DialogResult AlertSuccess(string texto, MessageBoxButtons buttons = MessageBoxButtons.OK)
        {
            return MessageBox.Show(this, texto, GetCaptionByAlert(Alert.SUCCESS), buttons, MessageBoxIcon.Information);
        }

        public DialogResult AlertWarning(string texto, MessageBoxButtons buttons = MessageBoxButtons.OK)
        {
            return MessageBox.Show(this, texto, GetCaptionByAlert(Alert.WARNING), buttons, MessageBoxIcon.Warning);
        }

        public DialogResult AlertInfo(string texto, MessageBoxButtons buttons = MessageBoxButtons.OK)
        {
            return MessageBox.Show(this, texto, GetCaptionByAlert(Alert.INFO), buttons, MessageBoxIcon.Information);
        }

        public void Exit()
        {
            Close();
            Application.Exit();
        }

        #endregion

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimeForm));
            this.SuspendLayout();
            // 
            // SimeForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SimeForm";
            this.ResumeLayout(false);

        }
    }
}
