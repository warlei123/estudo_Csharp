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
    using Entidades.Procedimentos;
    using System.Linq;

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
                    case "1": //Paciente
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
                        Console.WriteLine("Informe o numero do CPF");
                        var cpf = Console.ReadLine();

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


                        pacientes.Add(new Paciente(nome, sexo, dataDeNascimento, cpf, new Endereco(logradouro, numeroCasa, bairro, cidade, estado), dataInternacao));

                        break;

                    case "2": // Medico

                        Console.WriteLine();
                        Console.WriteLine("1- Cadastrar medico");
                        Console.WriteLine("2- Consultar medicos cadastrados");
                        var opcaoMedico = Console.ReadLine();
                        switch (opcaoMedico)
                        {

                            case "1":
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
                                Console.WriteLine("Informe o numero do CPF");
                                var cpfMedico = Console.ReadLine();

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
                                Console.WriteLine("Informe a especialidade");
                                var especialidade = Console.ReadLine().ToLower();

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

                                medicos.Add(new Medico(crm, new Especialidades(especialidade), dataDeAdmissao, matricula, nomeMedico, sexoMedico, dataDeNascimentoMedico, cpfMedico, new Endereco(logradouroMedico, numeroCasaMedico, bairroMedico, cidadeMedico, estadoMedico)));

                                break;
                            case "2":
                                

                                Console.WriteLine("Escolha o tipo de Pesquisa");
                                Console.WriteLine("1- Pesquisar por nome");
                                Console.WriteLine("2- Pesquisar por Especialidade");
                                Console.WriteLine("3- Pesquisar por Matricula");
                                var opcoesPesquisaMedicos = Console.ReadLine();
                                switch (opcoesPesquisaMedicos)
                                {

                                    case "1":
                                        Console.WriteLine("Informe o nome");
                                        var nomeDigitado = Console.ReadLine();
                                        var pesquisa = medicos.Find(medicos => medicos.Nome == nomeDigitado);
                                        Console.WriteLine($"{pesquisa.Nome}  {pesquisa.Crm}");
                                        break;
                                    case "2":
                                        Console.WriteLine("Informe a especialidade");
                                        var pesquisaEspecialidade = Console.ReadLine().ToLower();

                                        var especialidadeMedicas = medicos.Where(m => m.Especialidade.nomeEspecialidade == pesquisaEspecialidade);

                                        foreach (var medico in especialidadeMedicas)
                                        {
                                            Console.WriteLine($"{medico.Especialidade.nomeEspecialidade} {medico.Nome}");
                                        }
                                        break;
                                     case "3":
                                        Console.WriteLine("Informe a matricula");
                                        var matriculaDigitada = Console.ReadLine();
                                        var pesquisaMatricula = medicos.Find(medicos => medicos.Matricula == matriculaDigitada);
                                        Console.WriteLine($"{pesquisaMatricula.Nome}  {pesquisaMatricula.Matricula}");
                                        break;
                                    default:
                                        break;
                                }

                                break;

                            default:
                                break;
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
            Console.WriteLine("2- Gerenciar funcionarios medicos");
            Console.WriteLine("3- Marcar consulta");
            Console.WriteLine("4- Pesquisar Cliente");
            Console.WriteLine("5- Pesquisar medico");

            string opcaoUsuario = Console.ReadLine();
            return opcaoUsuario;

        }
    }
}