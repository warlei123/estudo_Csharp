namespace Hospital.Entidades.Funcionarios.Medicos
{
    public class Medico : Funcionario
    {
        public string Crm;

        public Especialidades Especialidade;

        public Medico(string crm, Especialidades especialidade, string dataDeAdmissao, string matricula, string nome, string sexo, string cpf,string dataDeNascimento, Endereco endereco) : base (dataDeAdmissao, matricula, nome, sexo, dataDeNascimento, cpf, endereco)
        {
            Crm = crm;
            Especialidade = especialidade;
        }

        public virtual void Operar()
        {
         
        }

        void FazerAlgo()
        {

        }
    }
}