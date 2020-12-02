using System;

namespace AulaDois
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem objetoPersonagem = new Personagem();

            objetoPersonagem.nome = "Kali";
            objetoPersonagem.idade = 19;
            objetoPersonagem.armadura = "Voadora";



            Personagem objetoPersonagem2 = new Personagem();

            objetoPersonagem2.nome = "Kemilly";
            objetoPersonagem2.idade = 20;
            objetoPersonagem2.armadura = "Flash"; 

            Console.WriteLine($"Personagem 1 = {objetoPersonagem.nome} - {objetoPersonagem.Atacar()}");
            Console.WriteLine($"Personagem 2 = {objetoPersonagem2.nome} - {objetoPersonagem2.Defender()}");

        }                         
    }
}
 