using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_FOLHA
{
    public class CalculoSalarioEstagiario: calculosalario
    {
        public string Nome { get; set; }
        public long Cod { get; set; }
        public double Ajuda { get; set; }

        public CalculoSalarioEstagiario(long Cod, string Nome,
           double Ajuda)
        {
            this.Cod = Cod;
            this.Nome = Nome;
            this.Ajuda = Ajuda;
        }

        public double Calcular(double SalarioHora)
        {
            double sb = SalarioHora * 80;
            if (sb > 1212) return 1212;
            else return sb + Ajuda;
        }
        public double Imposto(double valor)
        {
            return 0;
        }
        public void Imprimir()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nHOLERITE - ESTAGIARIO");
            Console.WriteLine("COD : {0}", Cod);
            Console.WriteLine("NOME : {0}", Nome);
            Console.WriteLine("AJUDA : {0}", Ajuda);
            double bruto = Calcular(160);
            double desconto = Imposto(bruto);
            Console.WriteLine("SAL BRUTO : {0:C2}", bruto);
            Console.WriteLine("IMPOSTO : {0:C2}", desconto);
            Console.WriteLine("SAl LIQ : {0:C2}\n", bruto - desconto);
        }
    }
}