using System;
using System.Collections.Generic;
using System.Globalization;

namespace Aula1
{
    public class Chaos
    {
        public void ChaosMode()
        {
            bool jogoRolando = true;

            int pontos = 0;

            //Array de Arrays de palavras
            string[][] palavras = new string[][]
            {
                new string[] {"ANIMAL DOMÉSTICO", "GATO" },
                new string[] {"BRINQUEDO", "BOLA" },
                new string[] {"MÓVEL", "MESA" },
                new string[] {"LUGAR PARA MORAR", "CASA" },
                new string[] {"CLIMA", "CHUVA" },
                new string[] {"VESTIMENTA", "SAPATO" },
                new string[] {"OBJETO DE INFORMAÇÃO", "LIVRO" },
                new string[] {"PONTO DE VISTA", "JANELA" },
                new string[] { "INSTITUIÇÃO BÁSICA", "ESCOLA"},
                new string[] { "TIPO DE PESSOA", "AMIGO" }
            };

            while (jogoRolando)
            {
                Random random = new Random();
                int index = random.Next(palavras.Length);
                string[] palavraSorteada = palavras[index];

                int progresso = 0;
                int chances = 6;

                Console.Clear();
                Console.WriteLine("CHANCES: " + chances);
                Console.WriteLine("DICA: " + palavras[0][0]);
                Console.WriteLine("Qual é essa palavra?: ");
                Console.WriteLine("PROGRESSO: " + progresso);
                string respostaJogador = Console.ReadLine().ToUpper();
                Console.Clear();

                bool acertou = false;

                //verifica se a resposta está correta corrigir
                if (respostaJogador == palavras[1])
                {
                    progresso++;
                    Console.Clear();
                }
                else 
                {
                    chances--;
                    Console.WriteLine();
                }




                if (chances == 0)
                {
                    chances--;
                    Console.WriteLine("ACABOU SUAS CHANCES, VOCÊ NÃO É DIGNO");
                    Console.ReadKey();
                }
                

                //Mensagem Final de Jogo

                if (pontos == 3)
                {
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("PARABÉNS, VOCÊ DERROTOU O DESAFIO SUPREMO");
                    Thread.Sleep(1000);
                    break;
                }
             

                
            }
            
        }
        static void titulo()
                {
                    string title = @"
                 ________    _________      __          ________     __        _____      _________     ________       ________      _____
|\        /|    |                |         /  \        |            /  \      |     \         |                /      |             |     \
| \      / |    |                |        /    \       |           /    \     |      \        |               /       |             |      \
|  \    /  |    |______          |       /______\      |______    /      \    |      /        |              /        |______       |      /
|   \__/   |    |                |      /        \     |          \      /    |_____/         |             /         |             |_____/
|          |    |                |     /          \    |           \    /     |     \         |            /          |             |     \ 
|          |    |________        |    /            \   |            \__/      |      \    ____|____       /________   |________     |      \
";

                    Console.WriteLine(title);
                }
    }
}
