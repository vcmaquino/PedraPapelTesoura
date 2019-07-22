using pedrapapeltesoura;
using System;
using System.Collections.Generic;
using System.Text;

namespace PedraPapelTesoura
{
    public class Confronto
    {
        public string ConfrontoJogo(List<Jogadores> listaJogadores)
        {
            regrasdojogo regrasDoJogo = new regrasdojogo();
            List<Jogadores> listaVencedores = new List<Jogadores>();
            while (listaJogadores.Count > 0)
            {
                if (listaJogadores.Count == 1 )
                {

                    return listaJogadores[0].StringJogador;
                }
                else
                {
                    listaVencedores.Add(regrasDoJogo.jogo(listaJogadores[0], listaJogadores[1]));
                    listaJogadores.Remove(listaJogadores[0]);
                    listaJogadores.Remove(listaJogadores[0]);

                }


            }
            return ConfrontoJogo(listaVencedores);
        }
    }
}
