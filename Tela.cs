﻿using System;
using System.Globalization;
using tabuleiro;

namespace xadrez_console
{
    class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for(int i = 0; i < tab.linhas; i++)
            {
                for(int j = 0; j < tab.colunas; j++)
                {
                    if (tab.Peca(i, j) == null)
                    {
                        Console.Write("_ ");
                    }
                    else
                    {
                        Console.Write(tab.Peca(i, j) + " ");
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }
}
