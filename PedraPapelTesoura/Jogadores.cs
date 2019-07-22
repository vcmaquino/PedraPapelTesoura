using System;
using System.Collections.Generic;
using System.Text;

namespace PedraPapelTesoura
{
    public struct  Jogadores
    {
       
        public string StringJogador { get; private set; }
        public string StringJogada { get; private set; }
       public Jogadores (string nome, string jogada)
        {
            StringJogador = nome;
            StringJogada = jogada;
        }

}
}
