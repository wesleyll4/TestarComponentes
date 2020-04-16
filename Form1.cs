using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace WindowsFormsApp2
    {
    public partial class Form1 : Form
        {
        public Form1()
            {
            InitializeComponent();
            TipoBom.Text = "uF";
            TipoMedido.Text = "uF";
            tolerancia.Text = "20";
            }
        private void valormedido_TextChanged(object sender, EventArgs e)
            {
            if (System.Text.RegularExpressions.Regex.IsMatch(valormedido.Text, "[^0-9-.]"))
                {
                valormedido.Text = 0.ToString();
                }
            }
        private void valorbom_TextChanged(object sender, EventArgs e)
            {
            if (System.Text.RegularExpressions.Regex.IsMatch(valorbom.Text, "[^0-9-.]"))
                {
                valorbom.Text = 0.ToString();
                }
            }
        private void tolerancia_TextChanged(object sender, EventArgs e)
            {
            if (System.Text.RegularExpressions.Regex.IsMatch(tolerancia.Text, "[^0-9-.]"))
                {
                tolerancia.Text = 0.ToString();
                }
            }


        private void button1_Click(object sender, EventArgs e)
            {
            Componente Novo = new Componente();

            Novo.ValorMedido = double.Parse(valormedido.Text, CultureInfo.InvariantCulture);
            Novo.ValorBom = double.Parse(valorbom.Text, CultureInfo.InvariantCulture);
            Novo.Tipo = TipoMedido.Text;
            Novo.Vbtipo = TipoBom.Text;
            Novo.Porcentagem = double.Parse(tolerancia.Text);

            Novo.Transformar();

            double BomPorcentagem = Novo.ValorPorcentagemB();
            Novo.Max = BomPorcentagem + Novo.ValorBom;
            Novo.Min = Novo.ValorBom - BomPorcentagem;

            if (Novo.ValorMedido >= Novo.Min && Novo.ValorMedido <= Novo.Max)
                {
                Status.Text = "Componente OK";
                Status.ForeColor = System.Drawing.Color.Green;
                }
            else
                {
                Status.Text = "Valor fora do permitido";
                Status.ForeColor = System.Drawing.Color.Red;
                }
            Novo.Voltar();

            textBox2.Text = Novo.ValorBom.ToString();
            textBox3.Text = Novo.ValorMedido.ToString();
            Minimo.Text = Novo.Min.ToString() + " " + TipoMedido.Text;
            Maximo.Text = Novo.Max.ToString() + " " + TipoMedido.Text;
            }
        }

    }

