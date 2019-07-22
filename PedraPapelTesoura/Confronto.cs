using pedrapapeltesoura;
using System;
using System.Collections.Generic;
using System.Text;

namespace PedraPapelTesoura
{
    public class Confronto
    {
        List<Jogadores> listaVencedores = new List<Jogadores>();
        
        public string ConfrontoJogo(List<Jogadores> listaJogadores)
        {
            
            regrasdojogo regrasDoJogo = new regrasdojogo();
            
            while (listaJogadores.Count > 0)
            {
                if (listaJogadores.Count > 1 )
                {
                    Console.WriteLine("Jogador " + listaJogadores[0].Nome + "  Versus  " + "Jogador " + listaJogadores[1].Nome);
                    listaVencedores.Add(regrasDoJogo.jogo(listaJogadores[0], listaJogadores[1]));
                    listaJogadores.Remove(listaJogadores[1]);
                    listaJogadores.Remove(listaJogadores[0]);
                }
                else
                {
                    var vencedor = listaVencedores[0].Nome;
                    listaVencedores.Clear();
                    return vencedor;              
                }

            }
            return ConfrontoJogo(listaVencedores);
        }
    }
}
