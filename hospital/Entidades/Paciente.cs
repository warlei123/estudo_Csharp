namespace Hospital.Entidades.Pacientes
{
    public class Paciente : Pessoa
    {
        public string DataInternacao;

        public Paciente(string nome, Endereco endereco, string dataInternacao) : base(nome, endereco)
        {

            DataInternacao = dataInternacao;
        }



    }
}