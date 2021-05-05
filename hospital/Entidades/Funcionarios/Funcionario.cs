namespace Hospital.Entidades.Funcionarios
{ 
    using Entidades;

    public abstract class Funcionario : Pessoa
    {
        public string DataAdimissao;

        public string Matricula;

        public Funcionario(string dataAdimissao, string matricula, string nome, string sexo, string dataDeNascimento,  Endereco endereco) : base(nome, sexo, dataDeNascimento, endereco)
        {
            DataAdimissao = dataAdimissao;
            Matricula = matricula;
        }
    }
}