namespace Hospital.Entidades
{
    using Entidades.Clientes;
    public class Paciente : Pessoa
    {
        public string DataInternacao;

        public bool PossuiPlano;

    

    

        

        public Paciente(string nome, string sexo, string dataDeNascimento, bool possuiPlano, string cpf, Endereco endereco, string dataInternacao) : base(nome, sexo, dataDeNascimento, cpf, endereco)
        {

            DataInternacao = dataInternacao;
            PossuiPlano = possuiPlano;

        }



    }
}