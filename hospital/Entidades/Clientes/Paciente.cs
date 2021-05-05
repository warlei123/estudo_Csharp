namespace Hospital.Entidades.Pacientes
{
    public class Paciente : Pessoa
    {
        public string DataInternacao;

        public Paciente(string nome, string sexo, string dataDeNascimento, Endereco endereco, string dataInternacao) : base(nome, sexo, dataDeNascimento, endereco)
        {

            DataInternacao = dataInternacao;
        }



    }
}