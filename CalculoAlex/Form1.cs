using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoAlex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbForma_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cmbForma.Text)
            {
                case "Circunferencia":
                    ExibirRaio(true);
                    ExibirLado(false);
                    break;
                case "Quadrado":
                    ExibirRaio(false);
                    ExibirLado(true);
                    break;
                case "Triangulo":
                    ExibirRaio(true);
                    ExibirLado(false);
                    cmbTriangulo.Visible = true;
                    break;

            }
            if(cmbForma.Text.Equals("Circunferencia"))
            {
                ExibirRaio(true);
                ExibirLado(false);
            }
            if (cmbForma.Text.Equals("Triangulo"))
            {

            }
        }
        private void ExibirLado(bool visible)
        {
            lblLado.Visible = txtRaio.Visible = visible;
        }

        private void ExibirRaio( bool visible)
        {
            lblRaio.Visible = txtRaio.Visible = visible;
        }
    }
}
