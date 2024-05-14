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

namespace WinFormsApp1
{
    public partial class FmrMostrar : Form
    {
        private Centralita centralita;
        public FmrMostrar(Centralita centralita)
        {
            InitializeComponent();
            this.centralita = centralita;
        }
    }
}
