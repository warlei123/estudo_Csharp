namespace Hospital.Entidades.Funcionarios
{ 
    using Entidades;

    public abstract class Funcionario : Pessoa
    {
        public string DataAdimissao;

        public string Matricula;

        public Funcionario(string dataAdimissao, string matricula, string nome, Endereco endereco) : base(nome, endereco)
        {
            DataAdimissao = dataAdimissao;
            Matricula = matricula;
        }
    }
}