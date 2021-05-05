namespace Hospital.Entidades
{
    public abstract class Pessoa
    {
        public string Nome;

        public string Sexo;

        public string DataDeNascimento;
        public Endereco Endereco;

        public Pessoa(string nome,string sexo, string dataDeNascimento, Endereco endereco)
        {
            Nome = nome;
            Sexo = sexo;
            DataDeNascimento = dataDeNascimento;
            Endereco = endereco;
        }
    }
}