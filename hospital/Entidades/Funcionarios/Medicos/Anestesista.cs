namespace Hospital.Entidades.Funcionarios.Medicos
{

    public class Anestesista : Medico
    {
        public Anestesista(string crm, string dataDeAdmissao, string matricula, string nome, Endereco endereco) : base(crm, dataDeAdmissao, matricula, nome, endereco)
        {
            Nome = nome;
            Crm = crm;
            DataAdimissao = dataDeAdmissao;
            Matricula = matricula;
            Endereco = endereco;
        }
    }
}