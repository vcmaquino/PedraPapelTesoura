using PedraPapelTesoura;
using System;

namespace pedrapapeltesoura
{
    public class regrasdojogo
    {
        public Jogadores jogo(Jogadores Jogador1, Jogadores Jogador2)
        {
            switch (Jogador1.Jogada.ToUpper())
            {
                case "P":
                    switch (Jogador2.Jogada.ToUpper())
                    {
                        case "S":
                            Console.WriteLine(Jogador2 .Nome + "  Venceu porque tesoura vence papel.");
                            return Jogador2;
                        case "P":
                            Console.WriteLine(" O " + Jogador1.Nome + "  Venceu por empate");
                            return Jogador1;
                        case "R":
                            Console.WriteLine(" O  " + Jogador1.Nome + "  Venceu papel vence pedra");
                            return Jogador1;
                    }
                    break;
                case "S":
                    switch (Jogador2.Jogada.ToUpper())
                    {
                        case "S":
                            Console.WriteLine(" O  " + Jogador1.Nome + "   Venceu por empate");
                            return Jogador1;
                        case "P":
                            Console.WriteLine(Jogador1.Nome + "   Venceu porque tesoura vence papel.");
                            return Jogador1;
                        case "R":
                            Console.WriteLine(Jogador2.Nome + "  Venceu porque pedra vence papel.");
                            return Jogador2;
                    }
                    break;
                case "R":

                    switch (Jogador2.Jogada.ToUpper())
                    {
                        case "S":
                            Console.WriteLine(Jogador1.Nome + "  Venceu porque pedra vence tesoura.");
                            return Jogador1;
                        case "P":
                            Console.WriteLine(Jogador2.Nome + "  Venceu porque papel vence pedra.");
                            return Jogador2;
                        case "R":
                            Console.WriteLine(" O " + Jogador1.Nome + "  Venceu por empate");
                            return Jogador1;
                    }
                    break;
            }
            return Jogador1;
        }
    }
}

              
