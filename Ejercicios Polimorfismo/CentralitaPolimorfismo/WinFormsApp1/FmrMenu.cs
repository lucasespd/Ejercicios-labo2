using Biblioteca;
using System.Drawing.Text;

namespace WinFormsApp1
{
    public partial class FmrMenu : Form
    {
        private Centralita centralita;

        public FmrMenu()
        {
            InitializeComponent();
            this.centralita = new Centralita("CentraLL");

        }

        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
            FmrLLamador fmrLlamador = new FmrLLamador(this.centralita);
            fmrLlamador.ShowDialog();


        }
    }
}
