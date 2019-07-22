using System;
using System.Collections.Generic;
using System.Text;

namespace PedraPapelTesoura
{
    public struct  Jogadores
    {
       
        public string Nome { get; private set; }
        public string Jogada { get; private set; }
       public Jogadores (string nome, string jogada)
        {
            Nome = nome;
            Jogada = jogada;
        }

}
}
