namespace Hospital.Entidades
{
    public class Endereco
    {
        public string Logradouro;

        public string Numero;

        public Endereco(string logradouro, string numero)
        {
            Logradouro = logradouro;
            Numero = numero;
        }
    }
}