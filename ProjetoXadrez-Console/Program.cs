using tabuleiro;
using System;
using ProjetoXadrez_Console;
using Xadrez;
namespace projetoXadrez_Console
{
    class program
    {
        static void Main(string[] args)
        {
           
          
                PosicaoXadrez pos = new PosicaoXadrez('c',7);
            Console.WriteLine(pos);

            Console.WriteLine(pos.toPosicao());
            Console.ReadLine();
        }
    }
}