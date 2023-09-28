using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROVA3_BIM
{
    internal class Administrativo : Funcionario
    {
       

        public double ValeTransporte = 250;

        public Administrativo(string nome, string cpf, string matricula, DateTime dataNascimento, string sexo, double salario)
            :base(nome,cpf, matricula,dataNascimento,sexo,salario)
        {

        }

        public double ValeAlimentacao()
        {
            double valeAlimentacao = 0.17;
            Salario = Salario - ValeTransporte;
            return (Salario + (valeAlimentacao * Salario));
        }
        public double SalarioFinalVT()
        {
            double valeTransporte = 250;
            return (Salario + valeTransporte);
        }
        
    }
}
