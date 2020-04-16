using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
    {
    class Componente
        {
        public string Tipo { get; set; }
        public double Porcentagem { get; set; }
        public double ValorMedido { get; set; }
        public double ValorBom { get; set; }
        public string Vbtipo { get; set; }
        public double Min { get; set; }
        public double Max { get; set; }
        

        public double ValorPorcentagemB()
            {
            return ValorBom * Porcentagem / 100;
            }
        public double ValorPorcentagemM()
            {
            return ValorMedido * Porcentagem / 100;
            }
        public void Transformar()
            {
            if (Tipo == "uF")
                {
                ValorMedido = ValorMedido * 1000000;
                }
            else if (Tipo == "nF")
                {
                ValorMedido = ValorMedido * 1000;
                }
            if (Vbtipo == "uF")
                {
                ValorBom = ValorBom * 1000000;
                }
            else if (Vbtipo == "nF")
                {
                ValorBom = ValorBom * 1000;
                }
            }
        public void Voltar()
            {
            if (Tipo == "uF")
                {
                ValorMedido = ValorMedido / 1000000;
                Min = Min / 1000000;
                Max = Max / 1000000;
                }
            else if (Tipo == "nF")
                {
                ValorMedido = ValorMedido / 1000;
                Min = Min / 1000;
                Max = Max / 1000;
                }
            if (Vbtipo == "uF")
                {
                ValorBom = ValorBom / 1000000;
                }
            else if (Vbtipo == "nF")
                {
                ValorBom = ValorBom / 1000;

                }
            }


        }
    }
