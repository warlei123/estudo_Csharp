namespace Hospital.Entidades.Funcionarios.Medicos
{
    public class Obstetra : Medico
    {
        public Obstetra(string crm, string dataDeAdmissao, string matricula, string nome, Endereco endereco) : base (crm, dataDeAdmissao, matricula, nome, endereco)
        {
            Nome = nome;
            Crm = crm;
            DataAdimissao = dataDeAdmissao;
            Matricula = matricula;
            Endereco = endereco;
        }
    }
}