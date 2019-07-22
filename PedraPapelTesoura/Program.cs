using System;
using System.Collections.Generic;

namespace PedraPapelTesoura
{
    class Program
    {
        static void Main(string[] args)
        {
            TipoDeJogo tipo = new TipoDeJogo();
            tipo.SelecioneTipoDeJogo();
            Console.Read();
        }
    }
}
