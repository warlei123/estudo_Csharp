namespace Hospital.Entidades.Funcionarios.Medicos
{
    public class Medico : Funcionario
    {
        public string Crm;

        public Medico(string crm, string dataDeAdmissao, string matricula, string nome, Endereco endereco) : base (dataDeAdmissao, matricula, nome, endereco)
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