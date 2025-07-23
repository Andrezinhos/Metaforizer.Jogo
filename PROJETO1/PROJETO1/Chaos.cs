using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;

namespace Aula1
{
    public class Chaos : MonoBehavior
    {
        private static Chaos instancia;

        public Chaos()
        {
            Awake();
        }

        public static Chaos Instance => instancia ??= new Chaos();

        public bool jogoRolando = true;

        public int pontos = 0;

        public int chances = 6;

        public void ChaosMode()
        {
            //Lista de palavras
            var palavras = new List<List<string>> 
            {
                new List<string> {"6 - 1 - 2", "3"},
                new List<string> { "LUGAR PARA MORAR", "casa" },
                new List<string> {"2 x 3 x 1", "6"},
                new List<string> { "INSTITUIÇÃO BÁSICA", "escola"},
                new List<string> {"3 x 2", "6"},
                new List<string> { "CLIMA", "chuva" },
                new List<string> {"9 / 3 + 1", "4"},
                new List<string> { "VESTIMENTA", "sapato" },
                new List<string> {"7 - 2 + 1", "6"},
                new List<string> { "TIPO DE PESSOA", "amigo" }
            };

            Thread tempo = new Thread(() => GameManager.Instance.TempoVisual(60));
            tempo.Start();
            Console.SetCursorPosition(0, 0);
            Console.CursorVisible = false;

            while (jogoRolando && !GameManager.Instance.tempoAcabou)
            {
                Console.SetCursorPosition(0, 1);
                Console.WriteLine("CHANCES RESTANTES: " + chances);
                Console.WriteLine("----------------------");
                //Mostra o número de perguntas respondidas
                Console.SetCursorPosition(0, 2);
                Console.WriteLine("PERGUNTAS RESPONDIDAS: " + pontos);
                Console.WriteLine("----------------------");

                Random random = new Random();
                int index = random.Next(palavras.Count);
                var palavraSorteada = palavras[index];

                Console.SetCursorPosition(0, 3);
                Console.WriteLine(palavraSorteada[0]);
                Console.WriteLine("Qual a resposta?: ");
                string respostaJogador = Console.ReadLine().Trim();
                Console.Clear();

                //verifica se a resposta está correta
                if (respostaJogador == palavraSorteada[1])
                {
                    pontos++;
                    Console.Clear();
                    Console.SetCursorPosition(0, 2);
                    Console.WriteLine("PALAVRA CORRETA");
                }
                else
                {
                    chances--;
                    Console.Clear();
                    Console.SetCursorPosition(0, 2);
                    Console.WriteLine("PALAVRA ERRADA");
                }

                Thread.Sleep(1000);
                Console.Clear();

                //Mensagem Final de Jogo
                if (chances == 0)
                {
                    Console.Clear();
                    GameManager.Instance.titulo();
                    Console.WriteLine("ACABOU SUAS CHANCES, VOCÊ NÃO É DIGNO");
                    break;
                }
                else if (pontos == 3)
                {
                    Console.Clear();
                    GameManager.Instance.titulo();
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("PARABÉNS, VOCÊ DERROTOU O DESAFIO SUPREMO");
                    break;
                }

            }

            if (GameManager.Instance.tempoAcabou)
            {
                GameManager.Instance.titulo();
                Console.WriteLine("TEMPO ESGOTADO");
            }

            tempo.Join();
        }

    }
}
