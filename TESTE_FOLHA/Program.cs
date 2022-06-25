using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using API_FOLHA;

namespace TESTE_FOLHA
{
    class Program
    {
        static List<calculosalario> Empregados;

        static void Main(string[] args)
        {
            Empregados = new List<calculosalario>();
            Empregados.Add( new CalculorSalarioFuncionario(1, "JOAO NINGUEM DA SILVA", 160));
            Empregados.Add(new CalculorSalarioFuncionario(2, "MARIA ALGUEM DE OLIVEIRA", 150));
            Empregados.Add(new CalculorSalarioAposentado(3, "JOAO TENORIO"));
            Empregados.Add(new CalculoSalarioEstagiario(4, "JORGE HENRIQUE", 68));

            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Empregados.ForEach(i => i.Imprimir());
            Console.ReadKey();
        }
    }
}
