using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Biblioteca.Provincial;

namespace WinFormsApp1
{
    public partial class FmrLLamador : Form
    {
        private Centralita centralita;
        public FmrLLamador(Centralita centralita)
        {
            InitializeComponent();
            this.centralita = centralita;
        }

        //propiedades
        public Centralita Centralita
        {
            get { return this.centralita; }
        }

        private void FmrLLamador_Load(object sender, EventArgs e)
        {
            // Carga
            cmbFranja.DataSource = Enum.GetValues(typeof(EFranja));
            // Lectura
            EFranja franjas;
            Enum.TryParse<EFranja>(cmbFranja.SelectedValue.ToString(), out franjas);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
