namespace Hospital.Entidades.Funcionarios.Medicos
{
    public class Medico : Funcionario
    {
        public string Crm;

        public Medico(string crm, string dataDeAdmissao, string matricula, string nome, string sexo,string dataDeNascimento, Endereco endereco) : base (dataDeAdmissao, matricula, nome, sexo, dataDeNascimento, endereco)
        {
            Crm = crm;
        }

        public virtual void Operar()
        {
         
        }

        void FazerAlgo()
        {

        }
    }
}