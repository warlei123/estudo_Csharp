namespace Hospital
{
    using System;
    using Entidades.Pacientes;
    using Entidades;
    using Entidades.Funcionarios;
    using Entidades.Funcionarios.Medicos;
    using Entidades.Funcionarios.Administrativo;
    class Program
    {
        static void Main(string[] args)
        {
            
            Endereco enderecoJose = new Endereco("Alameda dos anjos", "312-b");
            Endereco enderecoJosias = new Endereco("Alameda dos anjos", "2013");
            Paciente jose = new Paciente ("Jose de Arimateia", enderecoJose, "28/03/2019");
            Anestesista josias = new Anestesista("3291-5", "29/08/1998", "MA-48345", "Boneco Josias", enderecoJosias);


            Console.WriteLine();
            Console.WriteLine(jose.Nome);
            Console.WriteLine(jose.Endereco.Logradouro);
            Console.WriteLine(jose.Endereco.Numero);
            Console.WriteLine(jose.DataInternacao);
            Console.WriteLine();
            Console.WriteLine(josias.Nome);
            Console.WriteLine(josias.Endereco.Logradouro);
            Console.WriteLine(josias.Endereco.Numero);
            Console.WriteLine(josias.Matricula);
            Console.WriteLine(josias.DataAdimissao);
            Console.WriteLine(josias.Crm);
            
        }
    }
}