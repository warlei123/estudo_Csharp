namespace JogoMario
{
    public class Personagem
    {
        private string nome;
        private string cor;
        private int quantidadeDeCogumelos;
        private double altura;
        private string tipoFisico;
        private bool possuiBigode;
        
        public Personagem()
        {
            
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Cor    
        {
            get {return cor;}
            set {cor = value;}
        }

        public int QuantidadeDeCogumelos
        {
            get { return quantidadeDeCogumelos;}
            set { quantidadeDeCogumelos = value;}
        }

        public double Altura
        {
            get {return altura;}
            set {altura = value;}

        }

        public string Tipofisico
        {
            get {return tipoFisico;}
            set {tipoFisico = value;}
        }

        public bool PossuiBigode
        {
            get {return possuiBigode;}
            set {possuiBigode = value;}

        }

        void pular()
        {

        }
        // void pegarCogumelo(Cogumelo cogumelo)
        // {

        // }

        // BolaFogo AtirarFogo()
        // {

        // }

        ~Personagem()
        {

        }
        
        public override bool Equals(object obj)
        {
            if (obj is Personagem)
            {
                Personagem p = obj as Personagem;
                return this.nome.Equals(p.nome);
            }
            return false;
        }


        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return $"Nome do personagem: {this.nome}";
        }
    }
}