namespace Hospital.Entidades.Funcionarios.Administrativo
{   
    public class Gerente : Funcionario
    {
        public string Cra;

        public Gerente(string cra, string dataDeAdmissao, string matricula, string nome, Endereco endereco) : base (dataDeAdmissao, matricula, nome, endereco)
        {
            Cra = cra;
        }

        void LiberarPagamento()
        {

        }
    }
}