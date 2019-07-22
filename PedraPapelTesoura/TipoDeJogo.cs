using System;
using System.Collections.Generic;
using System.Text;

namespace PedraPapelTesoura
{
    public class TipoDeJogo
    {

        public void SelecioneTipoDeJogo()
        {
            string tipo = "0";
            SelecionarJogadores selecionar = new SelecionarJogadores();
            while (tipo != "1" || tipo != "2")
            {
                Console.WriteLine("Selecione 1 para Jogo e 2 para Torneio");
                tipo = Console.ReadLine();
                if (tipo == "1")
                {
                    selecionar.SolicitarJogadores();
                }
                else if (tipo == "2")
                {
                    selecionar.SolicitarJogadoresTorneio();
                }
                else
                {
                    Console.WriteLine("Selecione um tipo valido");
                }
            }
            
            
        }
    }
}
