namespace Hospital.Entidades.EstruturaDoHospital
{   
    using Entidades;
    public class Comodos
    {
         public string TipoDoComodo;

        public string NumeroDoComodo;

        public bool Esterializado;

        public Comodos(string tipoDoComodo, string numeroDoComodo, bool esterializado)
        {
            TipoDoComodo = tipoDoComodo;
            NumeroDoComodo = numeroDoComodo;
            Esterializado = esterializado;

        }
    }
}