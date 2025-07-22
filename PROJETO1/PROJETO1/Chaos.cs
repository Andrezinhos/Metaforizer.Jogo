using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace Aula1
{
    public class Chaos : MonoBehavior
    {
        public bool jogoRolando = true;

        public int progresso = 0;
        public int chances = 6;
        public void ChaosMode()
        {
            


            //Lista de palavras
            var palavras = new List<List<string>> 
            {
                new List<string> { "ANIMAL DOMÉSTICO", "gato" },
                new List<string> { "BRINQUEDO", "bola" },
                new List<string> {"3 x 2", "5", "4", "6", "6"},
                new List<string> {"9 / 3 + 1", "5", "2", "4", "4"},
                new List<string> {"Sou silêncio com cheiro, sou tempo que queima, sou pele de planta acesa", "1 - Incenso", "2 - Fumaça", "3 - Vela", "1"},
                new List<string> {"Sou rei que morre a cada instante, mas governa tudo o que é. Nunca volto, mas deixo marcas nos tronos da alma", "1 - Passado", "2 - Tempo", "3 - Destino", "2"},
                new List<string> { "OBJETO DE INFORMAÇÃO", "livro" },
                new List<string> { "PONTO DE VISTA", "janela" },
                new List<string> { "INSTITUIÇÃO BÁSICA", "escola"},
                new List<string> { "TIPO DE PESSOA", "amigo" }
            };

            while (jogoRolando)
            {

                hud();
                tempo();

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
                    GameManager.Instance.titulo();
                    Console.WriteLine("PALAVRA CORRETA");
                    Console.Clear();
                }
                else 
                {
                    chances--;
                    GameManager.Instance.titulo();
                    Console.WriteLine("PALAVRA ERRADA");
                    Console.Clear();
                }

                //Mensagem Final de Jogo
                if (chances == 0)
                {
                    GameManager.Instance.titulo();
                    Console.WriteLine("ACABOU SUAS CHANCES, VOCÊ NÃO É DIGNO");
                    break;
                } 
                else if (progresso == 3)
                {
                    GameManager.Instance.titulo();
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("PARABÉNS, VOCÊ DERROTOU O DESAFIO SUPREMO");
                    break;
                }
                                
            }
            
        }

        public void hud()
        {
            Console.WriteLine("PROGRESSO: " + progresso);
            Console.WriteLine("CHANCES: " + chances);
        }
        public int tempo(int n = 10)
        {
            for (int i = n; i > 0; i--)
            {
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.Write("TEMPO RESTANTE: " + i + "  ");
                Thread.Sleep(1000);
            }
            return 0;
        }
    }
}
