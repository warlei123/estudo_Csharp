namespace Hospital.Entidades
{
    public class Endereco
    {
        public string Logradouro;

        public string Numero;

        public string Bairro;

        public string Cidade;

        public string Estado;

        public Endereco(string logradouro, string numero, string bairro, string cidade, string estado)
        {
            Logradouro = logradouro;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
        }
    }
}