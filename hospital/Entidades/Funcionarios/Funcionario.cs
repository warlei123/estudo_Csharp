namespace Hospital.Entidades.Funcionarios
{ 
    using Entidades;

    public abstract class Funcionario : Pessoa
    {
        public string DataAdimissao;

        public string Matricula;

        public Funcionario(string dataAdimissao, string matricula, string nome, string sexo, string dataDeNascimento, string cpf, Endereco endereco) : base(nome, sexo, dataDeNascimento, cpf, endereco)
        {
            DataAdimissao = dataAdimissao;
            Matricula = matricula;
        }
    }
}