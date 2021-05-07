namespace Hospital
{
    using System;
    using Entidades;
    using Entidades.Clientes;
    using Entidades.Funcionarios;
    using Entidades.Funcionarios.Medicos;
    using Entidades.Funcionarios.Administrativo;
    using Entidades.Procedimentos.Medico;
    using System.Collections.Generic;
    using Entidades.Procedimentos;
    using System.Linq;

    class Program
    {
        public static List<Paciente> pacientes = new List<Paciente>();

        public static List<Medico> medicos = new List<Medico>();
        public static List<Consulta> consultas = new List<Consulta>();

        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();



            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {

                    case "1": //Paciente
                        Console.WriteLine();
                        Console.WriteLine("1- Cadastrar Paciente");
                        Console.WriteLine("2- Pesquisar Pacientes cadastrados");
                        var opcaoPaciente = Console.ReadLine();


                        switch (opcaoPaciente)
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

                                Console.WriteLine("Possui Plano de saude?");
                                var respostaPlanoDigitado = Console.ReadLine().ToLower();
                                bool respostaPlano;


                                if (respostaPlanoDigitado == "s" || respostaPlanoDigitado == "sim")
                                {
                                    respostaPlano = true;
                                }
                                else
                                {
                                    respostaPlano = false;
                                }



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


                                pacientes.Add(new Paciente(nome, sexo, dataDeNascimento,respostaPlano , cpf, new Endereco(logradouro, numeroCasa, bairro, cidade, estado), dataInternacao));
                                break;

                            case "2":


                                Console.WriteLine("Escolha o tipo de Pesquisa");
                                Console.WriteLine("1- Pesquisar por nome");
                                Console.WriteLine("2- Pesquisar por Cpf");
                                var opcoesPesquisaPaciente = Console.ReadLine();
                                switch (opcoesPesquisaPaciente)
                                {

                                    case "1":
                                        Console.WriteLine("Informe o nome");
                                        var nomeDigitado = Console.ReadLine();
                                        if (nomeDigitado != "")
                                        {
                                            var pesquisa = pacientes.Find(pacientes => pacientes.Nome == nomeDigitado);
                                            Console.WriteLine($"{pesquisa.Nome}  {pesquisa.DataInternacao}");
                                        }
                                        else
                                        {
                                            while (nomeDigitado == "")
                                            {
                                                Console.WriteLine("Informe o nome");
                                                nomeDigitado = Console.ReadLine();
                                            }
                                            var pesquisa = pacientes.Find(pacientes => pacientes.Nome == nomeDigitado);
                                            Console.WriteLine($"{pesquisa.Nome}  {pesquisa.DataInternacao}");
                                        }
                                        break;

                                    case "2":
                                        Console.WriteLine("Informe o cpf");
                                        var cpfDigitado = Console.ReadLine();
                                        if (cpfDigitado != "")
                                        {
                                            var pesquisaCpf = pacientes.Find(pacientes => pacientes.Cpf == cpfDigitado);
                                            Console.WriteLine($"{pesquisaCpf.Nome}  {pesquisaCpf.Cpf}");
                                        }
                                        else
                                        {
                                            while (cpfDigitado == "")
                                            {
                                                Console.WriteLine("Informe o cpf");
                                                cpfDigitado = Console.ReadLine();
                                            }
                                            var pesquisaCpf = pacientes.Find(pacientes => pacientes.Cpf == cpfDigitado);
                                            Console.WriteLine($"{pesquisaCpf.Nome}  {pesquisaCpf.Cpf}");

                                        }


                                        break;

                                    default:
                                        break;
                                }
                                break;
                            default:
                                break;
                        }

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
                                        if (nomeDigitado != "")
                                        {
                                            var pesquisa = medicos.Find(medicos => medicos.Nome == nomeDigitado);
                                            Console.WriteLine($"{pesquisa.Nome}  {pesquisa.Crm}");
                                        }
                                        else
                                        {
                                            while (nomeDigitado == "")
                                            {
                                                Console.WriteLine("Informe o nome");
                                                nomeDigitado = Console.ReadLine();
                                            }
                                            var pesquisa = medicos.Find(medicos => medicos.Nome == nomeDigitado);
                                            Console.WriteLine($"{pesquisa.Nome}  {pesquisa.Crm}");
                                        }
                                        break;

                                    case "2":
                                        Console.WriteLine("Informe a especialidade");
                                        var pesquisaEspecialidade = Console.ReadLine().ToLower();
                                        while (pesquisaEspecialidade == "")
                                        {
                                            Console.WriteLine("Informe a especialidade");
                                            pesquisaEspecialidade = Console.ReadLine().ToLower();
                                        }
                                        var especialidadeMedicas = medicos.Where(m => m.Especialidade.nomeEspecialidade == pesquisaEspecialidade);
                                        foreach (var medico in especialidadeMedicas)
                                        {
                                            Console.WriteLine($"{medico.Especialidade.nomeEspecialidade} {medico.Nome}");
                                        }

                                        break;

                                    case "3":
                                        Console.WriteLine("Informe a matricula");
                                        var matriculaDigitada = Console.ReadLine();
                                        while (matriculaDigitada == "")
                                        {
                                            Console.WriteLine("Informe a matricula");
                                            matriculaDigitada = Console.ReadLine();
                                        }
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
                    case "3":// consulta 
                        Console.WriteLine();
                        Console.WriteLine("1- Marcar consulta");
                        Console.WriteLine("2- Desmarcar Comsulta");
                        var opcaoConsulta = Console.ReadLine();
                        switch (opcaoConsulta)
                        {
                            case "1":
                                Console.WriteLine("Informe a especialidade da consulta");
                                var especialidaDaConsulta = Console.ReadLine();
                                while (especialidaDaConsulta == "")
                                {
                                    Console.WriteLine("Informe a especialidade");
                                    especialidaDaConsulta = Console.ReadLine();
                                }
                                var pesquisaEspecialidadeDaConsulta = medicos.Find(medicos => medicos.Especialidade.nomeEspecialidade == especialidaDaConsulta);

                                var medic = pesquisaEspecialidadeDaConsulta.Nome;

                                Console.WriteLine("Informe o cpf");
                                var cpfDigitado = Console.ReadLine();
                                while (cpfDigitado == "")
                                {
                                    Console.WriteLine("Informe o cpf");
                                    cpfDigitado = Console.ReadLine();
                                }
                                var pesquisaCpf = pacientes.Find(pacientes => pacientes.Cpf == cpfDigitado);

                                

                                
                                double valorConsulta = 0;
                               
                                if (pesquisaCpf.PossuiPlano == false)
                                {
                                    if (pesquisaEspecialidadeDaConsulta.Especialidade.nomeEspecialidade == "clinico")
                                    {
                                        valorConsulta = 29.90;
                                    }
                                    if (pesquisaEspecialidadeDaConsulta.Especialidade.nomeEspecialidade == "cirurgiao")
                                    {
                                        valorConsulta = 129.90;
                                    }
                                }
                                else
                                {
                                    valorConsulta = 0;
                                }






                                consultas.Add(new Consulta(pesquisaEspecialidadeDaConsulta.Especialidade, valorConsulta, medic));


                                Console.WriteLine($"A consulta de {pesquisaCpf.Nome} sera com o Dr {medic} {pesquisaEspecialidadeDaConsulta.Especialidade.nomeEspecialidade}  no valo de R${valorConsulta.ToString("N2")}   ");

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
            Console.WriteLine("1- Gerenciar pacientes");
            Console.WriteLine("2- Gerenciar funcionarios medicos");
            Console.WriteLine("3- Marcar consulta");
            Console.WriteLine("4- Pesquisar Cliente");
            Console.WriteLine("5- Pesquisar medico");

            string opcaoUsuario = Console.ReadLine();
            return opcaoUsuario;

        }


    }
}