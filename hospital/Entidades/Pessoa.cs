namespace Hospital.Entidades
{
    public abstract class Pessoa
    {
        public string Nome;

        public string Sexo;

        public string DataDeNascimento;

        public string Cpf;

        public Endereco Endereco;

        public Pessoa(string nome,string sexo, string dataDeNascimento,string cpf, Endereco endereco)
        {
            Nome = nome;
            Sexo = sexo;
            DataDeNascimento = dataDeNascimento;
            Cpf = cpf;
            Endereco = endereco;
        }
    }
}