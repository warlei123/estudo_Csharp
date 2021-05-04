namespace Hospital.Entidades
{
    public abstract class Pessoa
    {
        public string Nome;

        string sexo;

        public Endereco Endereco;

        public Pessoa(string nome, Endereco endereco)
        {
            Nome = nome;
            Endereco = endereco;
        }
    }
}