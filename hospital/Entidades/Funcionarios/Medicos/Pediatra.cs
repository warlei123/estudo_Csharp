namespace Hospital.Entidades.Funcionarios.Medicos
{
    public class Pediatra : Medico
    {
        public Pediatra (string crm, string dataDeAdmissao, string matricula, string nome, string sexo,string dataDeNascimento, Endereco endereco) : base(crm, dataDeAdmissao, matricula, nome, sexo,dataDeNascimento, endereco)
        {
            Nome = nome;
            Crm = crm;
            DataAdimissao = dataDeAdmissao;
            Matricula = matricula;
            Endereco = endereco;
        }
        
    }
}