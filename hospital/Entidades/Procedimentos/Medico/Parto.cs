namespace Hospital.Entidades.Procedimentos.Medicos
{
    using Funcionarios.Medicos;
    using Procedimentos;
    using Entidades.EstruturaDoHospital;

    public class Parto : Procedimento
    {
        
        public string RealizarParto(Anestesista anestesista, Obstetra obstetra, Pediatra pediatra )
        {
            Medico[] medicos = new Medico[]{anestesista, obstetra , pediatra};
            Comodos comodos = new Comodos("Sala de Parto", "201", true);
            if(medicos.Length == 3 || comodos.Esterializado != true)
            {
                return $"O parto sera realizado na {comodos.TipoDoComodo} {comodos.NumeroDoComodo} Pelo Anestesista {medicos[0].Nome} e Pela Obstetra {medicos[1].Nome}, O pós parto sera administrado pelo Pediatra {medicos[2].Nome}";
            }
            else
            {
                return "O parto não pode ser realizado por falta de medicos";
            }
            
        }
    }
}