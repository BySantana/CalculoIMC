using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula71_Imc
{
    internal class IMC
    {
        double Altura { get; set; }
        double Peso { get; set; }

        public IMC(double altura, double peso)
        {
            Altura = altura;
            Peso = peso;
        }

        public double CalcularImc()
        {
            return Peso / (Altura * Altura);
        }
        public string MostrarClassificacao(double imc)
        {
            if(imc < 18.5)
            {
                return "Magreza";
            }else if(imc >= 18.5 && imc <= 24.9)
            {
                return "Normal";
            }
            else if(imc >= 25 && imc <= 29.9)
            {
                return "Sobrepeso";
            }else if(imc >= 30 && imc < 39.9)
            {
                return "Normal";
            }
            else
            {
                return "Obesidade grave";
            }
        }
    }
}
