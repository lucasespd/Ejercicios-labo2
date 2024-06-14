using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vista
{
    public partial class FrmCartelera : Form
    {
        private static string rutaConfiguracion;

        public FrmCartelera()
        {
            InitializeComponent();
        }

        static FrmCartelera()
        {
            rutaConfiguracion = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "configuracion.json");
        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {
            lblTitulo.Text = txtTitulo.Text;
        }

        private void rtxtMensaje_TextChanged(object sender, EventArgs e)
        {
            lblMensaje.Text = rtxtMensaje.Text;
        }

        private void btnColorPanel_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            //colorDialog.Color = this.pnlCartel.BackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                this.pnlCartel.BackColor = colorDialog.Color;
            }
        }

        private void btnColorTitulo_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                this.lblTitulo.ForeColor = colorDialog.Color;
            }
        }

        private void btnColorMensaje_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                this.lblMensaje.ForeColor = colorDialog.Color;
            }
        }

        private void FrmCartelera_Load(object sender, EventArgs e)
        {

        }
    }
}
