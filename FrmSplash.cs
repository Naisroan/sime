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
    public partial class FrmSplash : SimeForm
    {
        FrmInicio Inicio = null;
        Timer TimerLoading = null;

        public FrmSplash(FrmInicio inicio)
        {
            InitializeComponent();

            Inicio = inicio;
            TimerLoading = new Timer()
            {
                Interval = 1500,
                Enabled = true
            };
            TimerLoading.Tick += TimerLoading_Tick;
        }

        private void FrmSplash_Load(object sender, EventArgs e)
        {
            // hacer tests de base de datos, archivos, etc
            TimerLoading.Start();
        }

        private void TimerLoading_Tick(object sender, EventArgs e)
        {
            TimerLoading.Stop();
            Close();
        }

    }
}
