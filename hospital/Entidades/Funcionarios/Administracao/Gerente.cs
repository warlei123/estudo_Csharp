namespace Hospital.Entidades.Funcionarios.Administrativo
{   
    public class Gerente : Funcionario
    {
        public string Cra;

        public Gerente(string cra, string dataDeAdmissao, string matricula, string nome, string sexo, string cpf, string dataDeNascimento, Endereco endereco) : base (dataDeAdmissao, matricula, nome, sexo, cpf, dataDeNascimento, endereco)
        {
            Cra = cra;
        }

        void LiberarPagamento()
        {

        }
    }
}