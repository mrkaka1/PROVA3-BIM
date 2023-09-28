using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROVA3_BIM
{
    internal class Medico : Funcionario
    {

        public string CRM { get; set; }
        public double ValorExtra { get; set; }
        public string Especialidade { get; set; }

        public int AuxilioPericulosidade { get; set; }

        public Medico(string nome, string cpf, string matricula, DateTime dataNascimento,
            string sexo, double salario, string crm, double valorex, string espe) 
            :base(nome, cpf, matricula, dataNascimento, sexo, salario)
        {
            Nome = nome;
            Cpf = cpf;
            Matricula = matricula;
            DataNascimento = dataNascimento;
            Sexo = sexo;
            Salario = salario;
            ValorExtra = valorex;
            Especialidade = espe;
        }
        public double Auxilio()
        {
            double salarioF = 0;
            double porcentagem = 0.22;

           return salarioF = ((porcentagem * Salario) + Salario);
        }


    }
}
