using System;
using System.Collections.Generic;
using System.Text;

namespace PedraPapelTesoura
{
    public class SelecionarJogadores
    {
        Confronto confronto = new Confronto();

        public List<Jogadores> DadosJogadores(List<Jogadores> listaJogadores)
        {
            string jogada = "";
            string NomeJogador = "";
            Console.WriteLine("Digite nome do jogador");
            NomeJogador = Console.ReadLine();
            Console.WriteLine("Digite 'R' Rock ou 'P' Paper ou 'S' Scissors");
            jogada = Console.ReadLine();
            if (jogada.ToUpper() != "R" && jogada.ToUpper() != "S" && jogada.ToUpper() != "P")
            {
                Console.WriteLine("Digite novamente a jogada");
            }
            else
            {
                listaJogadores.Add(new Jogadores(NomeJogador, jogada));

            }
            return listaJogadores;
        }

        public void SolicitarJogadores()
        {
            List<Jogadores> listaJogadores = new List<Jogadores>();
            while (listaJogadores.Count < 2)
            {
                listaJogadores = DadosJogadores(listaJogadores);
            }
           
            foreach (var item in listaJogadores)
            {
                Console.WriteLine("jogador  " + item.Nome +" "+ item.Jogada);
            }
           var Vencedor =  confronto.ConfrontoJogo(listaJogadores);
            Console.WriteLine("O vencedor é   " + Vencedor);
            
        }
        public void SolicitarJogadoresTorneio()
        {
            String resposta = "";
            List<Jogadores> listaJogadoresTorneio = new List<Jogadores>();
            do {
                listaJogadoresTorneio = DadosJogadores(listaJogadoresTorneio);
                Console.WriteLine("Deseja adicionar outro? (S/N)");
             resposta = Console.ReadLine();
            } while (resposta.ToUpper() != "N");
            if( listaJogadoresTorneio.Count % 2 == 0)
            {
                foreach (var item in listaJogadoresTorneio)
                {
                    Console.WriteLine("jogador  " + item.Nome +" "+ item.Jogada);
                }
                var Vencedor = confronto.ConfrontoJogo(listaJogadoresTorneio);
                Console.WriteLine("O vencedor é   " + Vencedor);
            }
            else
            {
                Console.WriteLine("Quantidade de jogadores invalidas, necessario quantidade par de jogadores");
            }
        
        }
    }
}
