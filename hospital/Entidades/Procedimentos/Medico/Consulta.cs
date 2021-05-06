namespace Hospital.Entidades.Procedimentos.Medico
{
    using Entidades.Funcionarios.Medicos;
    using Entidades.Clientes;
    public class Consulta
    {
        Especialidades Especialidade;

        public double ValorConsulta;

        Medico medico;

        PlanoDeSaude PlanoDeSaude;
        

        public Consulta(Especialidades especialidade, double ValorConsulta, Medico medico, PlanoDeSaude planoDeSaude )
        {
            
        }
    }
}