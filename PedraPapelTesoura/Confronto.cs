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
            string ganhador = "";
            regrasdojogo regrasDoJogo = new regrasdojogo();
            List<Jogadores> listaVencedores = new List<Jogadores>();
            while (listaJogadores.Count > 0)
            {
                if (listaJogadores.Count == 1 )
                {

                    return ganhador = listaJogadores[0].StringJogador;
                }
                else
                {
                    var teste = listaJogadores[1];
                    listaVencedores.Add(regrasDoJogo.jogo(listaJogadores[0], listaJogadores[1]));
                    listaJogadores.Remove(listaJogadores[0]);
                    listaJogadores.Remove(listaJogadores[1]);

                }


            }
            ConfrontoJogo(listaVencedores);
        }
    }
}
