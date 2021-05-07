namespace Hospital.Entidades.Procedimentos.Medico
{
    using Entidades.Funcionarios.Medicos;
    using Entidades.Clientes;
    public class Consulta
    {
        Especialidades Especialidade;

        public double ValorConsulta;

        string Medico;

     
        

        public Consulta(Especialidades especialidade, double valorConsulta, string medico )
        {
            Especialidade = especialidade;
            ValorConsulta = valorConsulta;
            Medico = medico;
            
        }
    }
}