using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_FOLHA
{
    public class CalculorSalarioFuncionario: calculosalario
    {

        public string Nome { get; set; }
        public long Cod { get; set; }
        public double HorasTrabalhadas { get; set; }

        public CalculorSalarioFuncionario(long Cod, string Nome, double HorasTrabalhadas)
        {
            this.Cod = Cod;
            this.Nome = Nome;
            this.HorasTrabalhadas = HorasTrabalhadas;
        }

        public double Calcular(double SalarioHora)
        {
            double sb = HorasTrabalhadas * SalarioHora;
            return sb;
        }

        public double Imposto(double valor)
        {
            double desconto = valor * 0.15;
            return desconto;
        }

        public void Imprimir()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nHOLERITE - FUNCIONARIO");
            Console.WriteLine("COD : {0}", Cod);
            Console.WriteLine("NOME : {0}", Nome);
            Console.WriteLine("Horas Trabalhadas : {0}", HorasTrabalhadas);
            double bruto = Calcular(160);
            double desconto = Imposto(bruto);
            Console.WriteLine("SAL BRUTO : {0:C2}", bruto);
            Console.WriteLine("IMPOSTO : {0:C2}", desconto);
            Console.WriteLine("SAL LIQ : {0:C2}", bruto - desconto);
        }
    }
}
