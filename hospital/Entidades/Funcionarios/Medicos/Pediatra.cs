namespace Hospital.Entidades.Funcionarios.Medicos
{
    public class Pediatra : Medico
    {
        public Pediatra (string crm, string dataDeAdmissao, string matricula, string nome, Endereco endereco) : base (crm, dataDeAdmissao, matricula, nome, endereco)
        {
            Nome = nome;
            Crm = crm;
            DataAdimissao = dataDeAdmissao;
            Matricula = matricula;
            Endereco = endereco;
        }
        
    }
}