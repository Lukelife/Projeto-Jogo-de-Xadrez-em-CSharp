﻿using System.Security.Cryptography.X509Certificates;
using tabuleiro;

namespace Xadrez
{
    class Rei : Peca
    {
        public Rei(Cor cor, Tabuleiro tabuleiro) : base(cor, tabuleiro)
        {
        }

        public override string ToString()
        {
            return "R";
        }


    }
}
