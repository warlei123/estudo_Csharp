namespace Hospital.Entidades.Funcionarios.Medicos
{
    public class Obstetra : Medico
    {
        public Obstetra(string crm, string dataDeAdmissao, string matricula, string nome,string sexo,string dataDeNascimento, Endereco endereco) : base(crm, dataDeAdmissao, matricula, nome, sexo,dataDeNascimento, endereco)
        {
            Nome = nome;
            Crm = crm;
            DataAdimissao = dataDeAdmissao;
            Matricula = matricula;
            Endereco = endereco;
        }
    }
}