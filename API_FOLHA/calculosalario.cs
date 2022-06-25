using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_FOLHA
{
    public interface calculosalario
    {
        string Nome { get; set; }
        double Calcular(double SalarioHora);
        double Imposto(double valor);
        void Imprimir();
    }
}
