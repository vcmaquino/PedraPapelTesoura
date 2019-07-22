using PedraPapelTesoura;
using System;

namespace pedrapapeltesoura
{
    public class regrasdojogo
    {

        public Jogadores jogo(Jogadores Jogador1, Jogadores Jogador2)
        {
            switch (Jogador1.StringJogada.ToUpper())
            {
                case "P":
                    switch (Jogador2.StringJogada.ToUpper())
                    {
                        case "S":
                            Console.WriteLine("Venceu porque tesoura vence papel.");
                            return Jogador2;
                        case "P":
                            Console.WriteLine(" O " + Jogador1.StringJogador + "Venceu por empate");
                            return Jogador1;
                        case "R":
                            Console.WriteLine(" O " + Jogador1.StringJogador + "Venceu papel vence pedra");
                            return Jogador1;
                    }
                    break;
                case "S":
                    switch (Jogador2.StringJogada.ToUpper())
                    {
                        case "S":
                            Console.WriteLine(" O " + Jogador1.StringJogador + "Venceu por empate");
                            return Jogador1;
                        case "P":
                            Console.WriteLine(Jogador1.StringJogador + "Venceu porque tesoura vence papel.");
                            return Jogador1;
                        case "R":
                            Console.WriteLine(Jogador2.StringJogador + "Venceu porque papel vence pedra.");
                            return Jogador2;
                    }
                    break;
                case "R":

                    switch (Jogador2.StringJogada.ToUpper())
                    {
                        case "S":
                            Console.WriteLine(Jogador1.StringJogador + "Venceu porque pedra vence tesoura.");
                            return Jogador1;
                        case "P":
                            Console.WriteLine(Jogador2.StringJogador + "Venceu porque papel vence pedra.");
                            return Jogador2;
                        case "R":
                            Console.WriteLine(" O " + Jogador1.StringJogador + "Venceu por empate");
                            return Jogador1;
                    }
                    break;
            }
            return Jogador1;
        }
    }
}

              
