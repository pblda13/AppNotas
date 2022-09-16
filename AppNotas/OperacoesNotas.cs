using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNotas
{
    class OperacoesNotas
    {
        public double N1 { get; set; }
        public double N2 { get; set; }
        public double N3 { get; set; }
        public double N4 { get; set; }



        public float MaiorNota(float nota1, float nota2, float nota3, float nota4)
        {
            List<float> lista = new List<float> { nota1, nota2, nota3, nota4 };
            float maiorValor = lista.Max();

            return maiorValor;
        }
        public float MenorNota(float nota1, float nota2, float nota3, float nota4)
        {
            List<float> lista = new List<float> { nota1, nota2, nota3, nota4 };
            float maiorValor = lista.Min();

            return maiorValor;
        }

        public float Media(float nota1, float nota2, float nota3, float nota4)
        {
            float media = (nota1 + nota2 + nota3 + nota4) / 4;
            return media;
        }

        public float SomaNotasPares(float nota1, float nota2, float nota3, float nota4)
        {
            List<float> lista = new List<float> { nota1, nota2, nota3, nota4 };
            float resultado = 0;
            foreach (float x in lista)
            {
                if (x % 2 == 0)
                    resultado += x;
            }

            return resultado;
        }

        public float SomaNotasImpares(float nota1, float nota2, float nota3, float nota4)
        {
            List<float> lista = new List<float> { nota1, nota2, nota3, nota4 };
            float resultado = 0;
            foreach (float x in lista)
            {
                if (x % 2 != 0)
                    resultado += x;
            }

            return resultado;
        }

        public float NotaasMaioresOuIgualSete(float nota1, float nota2, float nota3, float nota4)
        {
            List<float> lista = new List<float> { nota1, nota2, nota3, nota4 };
            float resultado = 0;
            foreach (float x in lista)
            {
                if (x >= 7)
                    resultado += 1;
            }

            return resultado;
        }
    }
}