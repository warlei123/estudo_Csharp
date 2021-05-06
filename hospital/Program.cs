namespace Hospital
{
    using System;
    using Entidades.Pacientes;
    using Entidades;
    using Entidades.Funcionarios;
    using Entidades.Funcionarios.Medicos;
    using Entidades.Funcionarios.Administrativo;
    using Entidades.Procedimentos.Medicos;
    using System.Collections.Generic;

    class Program
    {
        public static List<Paciente> pacientes = new List<Paciente>();

        public static List<Medico> medicos = new List<Medico>();

        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        Console.WriteLine();
                        Console.WriteLine("Informe o nome completo.");
                        var nome = Console.ReadLine();

                        Console.WriteLine();
                        Console.WriteLine("Informe o genero.");
                        var sexo = Console.ReadLine();

                        Console.WriteLine();
                        Console.WriteLine("Informe a data de nascimento");
                        var dataDeNascimento = Console.ReadLine();

                        Console.WriteLine();
                        Console.WriteLine("Agora o endereço");
                        Console.WriteLine("Informe o nome da rua");
                        var logradouro = Console.ReadLine();

                        Console.WriteLine();
                        Console.WriteLine("Informe o numero da residencia");
                        var numeroCasa = Console.ReadLine();

                        Console.WriteLine();
                        Console.WriteLine("Informe o bairro");
                        var bairro = Console.ReadLine();

                        Console.WriteLine();
                        Console.WriteLine("Informe a cidade");
                        var cidade = Console.ReadLine();

                        Console.WriteLine();
                        Console.WriteLine("Informe o estado");
                        var estado = Console.ReadLine();

                        Console.WriteLine();
                        Console.WriteLine("Informe o dia da internação");
                        var dataInternacao = Console.ReadLine();


                        pacientes.Add(new Paciente(nome, sexo, dataDeNascimento, new Endereco(logradouro, numeroCasa, bairro, cidade, estado), dataInternacao));

                        break;

                    case "2":
                        Console.WriteLine();
                        Console.WriteLine("Informe o nome completo.");
                        var nomeMedico = Console.ReadLine();

                        Console.WriteLine();
                        Console.WriteLine("Informe o genero.");
                        var sexoMedico = Console.ReadLine();

                        Console.WriteLine();
                        Console.WriteLine("Informe a data de nascimento");
                        var dataDeNascimentoMedico = Console.ReadLine();

                        Console.WriteLine();
                        Console.WriteLine("Informe o CRM");
                        var crm = Console.ReadLine();

                        Console.WriteLine();
                        Console.WriteLine("Informe a matricula");
                        var matricula = Console.ReadLine();

                        Console.WriteLine();
                        Console.WriteLine("Informe a data de admissão");
                        var dataDeAdmissao = Console.ReadLine();


                        Console.WriteLine();
                        Console.WriteLine("Agora o endereço");
                        Console.WriteLine("Informe o nome da rua");
                        var logradouroMedico = Console.ReadLine();

                        Console.WriteLine();
                        Console.WriteLine("Informe o numero da residencia");
                        var numeroCasaMedico = Console.ReadLine();

                        Console.WriteLine();
                        Console.WriteLine("Informe o bairro");
                        var bairroMedico = Console.ReadLine();

                        Console.WriteLine();
                        Console.WriteLine("Informe a cidade");
                        var cidadeMedico = Console.ReadLine();

                        Console.WriteLine();
                        Console.WriteLine("Informe o estado");
                        var estadoMedico = Console.ReadLine();

                        medicos.Add(new Medico(crm, dataDeAdmissao, matricula, nomeMedico, sexoMedico, dataDeNascimentoMedico, new Endereco(logradouroMedico, numeroCasaMedico, bairroMedico, cidadeMedico, estadoMedico)));

                        break;

                    case "3":

                        Console.WriteLine("Informe o nome");
                        var pesquisa = Console.ReadLine();
                        foreach (var medico in medicos)
                        {   
                            var i = 0;
                            if(medicos[i].Nome == pesquisa)
                            {
                                Console.WriteLine("achou");
                            }
                            i++;
                            
                        }
                        break;
                    default:
                        Console.WriteLine("erro");
                        break;
                }
                opcaoUsuario = ObterOpcaoUsuario(); 
            }
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Por Favor, Informe o serviço desejado");
            Console.WriteLine("1- Cadastrar paciente");
            Console.WriteLine("2- Cadastrar medico");
            Console.WriteLine("3- Marcar consulta");
            Console.WriteLine("4- Pesquisar Cliente");
            Console.WriteLine("5- Pesquisar medico");

            string opcaoUsuario = Console.ReadLine();
            return opcaoUsuario;

        }
    }
}