using System;

namespace JogoMario
{
     class Program
    {
        static void Main(string[] args)
        {
          Personagem mario = new Personagem();
          mario.Nome = "Mario";
          mario.Cor = "Vermelho";
          mario.Altura = 1.55;
          mario.QuantidadeDeCogumelos = 0;
          mario.Tipofisico = "Gordinho";
          mario.PossuiBigode = true;

          Personagem luigi = new Personagem();
          luigi.Nome = "Luigi";
          luigi.Cor = "Verde";
          luigi.Altura = 1.61;
          luigi.QuantidadeDeCogumelos = 0;
          luigi.Tipofisico = "Magro";
          luigi.PossuiBigode = true;

          

          
          Console.WriteLine($"O boné do {mario.Nome} é {mario.Cor}, ele tem {mario.Altura} e ele é {mario.Tipofisico}");
          Console.WriteLine($"O boné do {luigi.Nome} é {luigi.Cor}, ele tem {luigi.Altura} e ele é {luigi.Tipofisico}");

         

        }
    }
  
}
