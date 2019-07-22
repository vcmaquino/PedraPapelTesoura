using System;
using System.Collections.Generic;
using System.Text;

namespace PedraPapelTesoura
{
    public class SelecionarJogadores
    {
        Confronto confronto = new Confronto();
        public void SolicitarJogadores()
        {
            List<Jogadores> listaJogadores = new List<Jogadores>();
            while (listaJogadores.Count < 2)
            {
                string jogada = "";
                string NomeJogador = "";
                Console.WriteLine("Digite nome do jogador");
                 NomeJogador =  Console.ReadLine();
                while (String.IsNullOrEmpty(jogada))
                {
                    Console.WriteLine("Digite 'R' Rock ou 'P' Paper ou 'S' Scissors");
                    jogada = Console.ReadLine();
                    if (jogada.ToUpper() != "R" || jogada.ToUpper() != "S" || jogada.ToUpper() != "P")
                    {
                        Console.WriteLine("Digite novamente a jogada");
                    }
                }
                    listaJogadores.Add(new Jogadores(NomeJogador, jogada));
            }
           
            foreach (var item in listaJogadores)
            {
                Console.WriteLine("jogadores" + item.StringJogada + item.StringJogador);
            }
            confronto.ConfrontoJogo(listaJogadores);

        }
        public void SolicitarJogadoresTorneio()
        {
            string Jogar = "K";
            List<Jogadores> listaJogadoresTorneio = new List<Jogadores>();

            while (Jogar.ToUpper() != "J" && listaJogadoresTorneio.Count % 2 != 0)
            {
                string jogada = "";
                string NomeJogador = "";
                Console.WriteLine("Digite nome do jogador");
                NomeJogador = Console.ReadLine();
                while (String.IsNullOrEmpty(jogada))
                {
                    Console.WriteLine("Digite 'R' Rock ou 'P' Paper ou 'S' Scissors");
                    jogada = Console.ReadLine();
                    if (jogada != "R" && jogada != "S" && jogada != "P")
                    {
                        Console.WriteLine("Digite novamente a jogada");
                    }
                }
                listaJogadoresTorneio.Add(new Jogadores(NomeJogador, jogada));
                Jogar = Console.ReadLine();
            }
            foreach (var item in listaJogadoresTorneio)
            {
                Console.WriteLine("jogadores" + item.StringJogada + item.StringJogador);
            }
            confronto.ConfrontoJogo(listaJogadoresTorneio);
        }
    }
}
