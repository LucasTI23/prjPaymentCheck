using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_FOLHA
{
    public class CalculorSalarioAposentado: calculosalario
    {
        public string Nome { get; set; }
        public long Cod { get; set; }

        public CalculorSalarioAposentado(long Cod, string Nome)
        {
            this.Cod = Cod;
            this.Nome = Nome;
        }

        public double Calcular(double SalarioHora)
        {
            double sb = SalarioHora * 160;
            if (sb > 6050) return 6050;
            else return sb;
        }

        public double Imposto(double valor)
        {
            return valor * 0.01;
        }

        public void Imprimir()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nHOLERITE - APOSENTADO");
            Console.WriteLine("COD : {0}", Cod);
            Console.WriteLine("NOME : {0}", Nome);
            double bruto = Calcular(30);
            double desconto = Imposto(bruto);
            Console.WriteLine("SAL BRUTO : {0:C2}", bruto);
            Console.WriteLine("IMPOSTO : {0:C2}", desconto);
            Console.WriteLine("SAL LIQ : {0:C2}", bruto - desconto);
        }
    }
}
