using PROVA3_BIM;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        try {
            List<Medico> list = new List<Medico>();
            List<Administrativo> listad = new List<Administrativo>();

            Console.Write("Bem vindo a GURUDEV!");
            Console.Write("Escolha uma opção abaixo\n " +
                "1 - Cadastrar Funcionário\n" +
                "2 - Mostrar Lista de Funcionários\n" +
                "3 - Sair\n");

            int opc = Convert.ToInt32(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    Console.WriteLine("Qual funcionário você irá cadastrar no seu sistema:\n" +
                        "1 - Médico\n" +
                        "2 - Administrativo\n");
                    int opcao = Convert.ToInt32(Console.ReadLine());
                    switch (opcao)
                    {
                        case 1:
                            Console.Write("Digite as informações do seu funcionário:");
                            Console.Write("Nome: ");
                            string nome = Console.ReadLine();
                            Console.Write("CPF: ");
                            string cpf = Console.ReadLine(); 
                            Console.Write("CRM: ");
                            string crm = Console.ReadLine();
                            Console.Write("Especialidade: ");
                            string esp = Console.ReadLine();
                            Console.Write("Matrícula: ");
                            string matri = Console.ReadLine();
                            Console.Write("Data de Nascimento: ");
                            DateTime data = Convert.ToDateTime(Console.ReadLine());
                            Console.Write("Sexo: ");
                            string sx = Console.ReadLine();
                            Console.Write("Salário: ");
                            double sla = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Valor Hora Extra: ");
                            double horaex = Convert.ToDouble(Console.ReadLine());

                            Medico m = new Medico(nome, cpf,matri, data, sx, sla,crm, horaex,esp);
                            list.Add(m);

                            Console.WriteLine($"Salário do médico com o auxilio {m.Auxilio()}");
                            
                            break;
                        case 2:
                            Console.Write("Digite as informações do seu funcionário:");
                            Console.Write("Nome: ");
                            string nomead = Console.ReadLine();
                            Console.Write("CPF: ");
                            string cpfad = Console.ReadLine();
                            Console.Write("Matrícula: ");
                            string matriad = Console.ReadLine();
                            Console.Write("Data de Nascimento: ");
                            DateTime datad = Convert.ToDateTime(Console.ReadLine());
                            Console.Write("Sexo: ");
                            string sxad = Console.ReadLine();
                            Console.Write("Salário: ");
                            double slas = Convert.ToDouble(Console.ReadLine());

                            Administrativo ad = new Administrativo(nomead, cpfad,matriad, datad, sxad,slas);
                            listad.Add(ad);
                     
                            Console.WriteLine($"Salario do Funcionário com Vale-Transporte {ad.SalarioFinalVT()}, e com Vale-Alimentação {ad.ValeAlimentacao()}");
                            break;
                            
                    }
                    break;
                case 2:
                    foreach(Medico md in list)
                    {
                        Console.Write("Lista de Médicos");

                        list = list.OrderBy(x => x.Salario < 2000).ToList();
                        Console.WriteLine($"Nome: {md.Nome}\n" +
                            $"Cpf: {md.Cpf}\n" +
                            $"CRM: {md.CRM}\n" +
                            $"Especialidade: {md.Especialidade}\n" +
                            $"Matricula: {md.Matricula}\n" +
                            $"Data de Nascimento: {md.DataNascimento}\n" +
                            $"Sexo: {md.Sexo}\n" +
                            $"Salário: {md.Salario}");

                        listad = listad.OrderBy(x => x.Salario < 2000).ToList();
                        Console.Write("------------------------------------");
                        Console.Write("Lista de Funcionarios Administrativos");
                        Console.Write($"Nome: {md.Nome}\n" +
                            $"Cpf: {md.Cpf}\n" +
                            $"Matricula: {md.Matricula}\n" +
                            $"Data de Nascimento: {md.DataNascimento}\n" +
                            $"Sexo: {md.Sexo}\n" +
                            $"Salário: {md.Salario}");
                    }

                    break;
                case 3:
                    Console.Write("Até Mais e Obrigado!");
                    break;
            }
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
}