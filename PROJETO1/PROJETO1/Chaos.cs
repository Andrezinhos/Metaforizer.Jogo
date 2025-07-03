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

            int progresso = 0;
            int chances = 6;


            //Lista de palavras
            var palavras = new List<List<string>> 
            {
                new List<string> { "ANIMAL DOMÉSTICO", "gato" },
                new List<string> { "BRINQUEDO", "bola" },
                new List<string> { "MÓVEL", "mesa" },
                new List<string> { "LUGAR PARA MORAR", "casa" },
                new List<string> { "CLIMA", "chuva" },
                new List<string> { "VESTIMENTA", "sapato" },
                new List<string> { "OBJETO DE INFORMAÇÃO", "livro" },
                new List<string> { "PONTO DE VISTA", "janela" },
                new List<string> { "INSTITUIÇÃO BÁSICA", "escola"},
                new List<string> { "TIPO DE PESSOA", "amigo" }
            };

            while (jogoRolando)
            {
                Console.WriteLine("PROGRESSO: " + progresso);

                Console.WriteLine("CHANCES: " + chances);

                Random random = new Random();
                int index = random.Next(palavras.Count);
                var palavraSorteada = palavras[index];
                                
                Console.WriteLine(palavraSorteada[0]);
                Console.WriteLine("Qual é essa palavra?: ");
                string respostaJogador = Console.ReadLine().Trim();
                Console.Clear();
                               
                //verifica se a resposta está correta
                if (respostaJogador == palavraSorteada[1])
                {
                    progresso++;
                    titulo();
                    Console.WriteLine("PALAVRA CORRETA");
                    Console.Clear();
                }
                else 
                {
                    chances--;
                    titulo();
                    Console.WriteLine("PALAVRA ERRADA");
                    Console.Clear();
                }

                //Mensagem Final de Jogo
                if (chances == 0)
                {
                    titulo();
                    Console.WriteLine("ACABOU SUAS CHANCES, VOCÊ NÃO É DIGNO");
                    break;
                } 
                else if (progresso == 3)
                {
                    titulo();
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("PARABÉNS, VOCÊ DERROTOU O DESAFIO SUPREMO");
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
