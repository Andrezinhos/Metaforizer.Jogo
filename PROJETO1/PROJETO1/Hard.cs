using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace Aula1
{
    public class Hard
    {
        public void HardMode()
        {
            bool jogoRolando = true;

            int pontos = 0;

            //Lista de perguntas

            var perguntas = new List<List<string>>() {
            new List<string> {"5 + 2", "8", "7", "6", "7"},
            new List<string> {"9 - 4", "5", "6", "7", "5"},
            new List<string> {"3 x 2", "5", "4", "6", "6"},
            new List<string> {"8 / 2", "3", "2", "4", "4"},
            new List<string> {"1 + 1 + 2", "3", "4", "6", "4"},
            new List<string> {"6 - 1 - 2", "6", "3", "4", "3"},
            new List<string> {"2 x 3 x 1", "4", "6", "5", "6"},
            new List<string> {"9 / 3 + 1", "5", "2", "4", "4"},
            new List<string> {"7 - 2 + 1", "5", "6", "7", "6"},
            new List<string> {"4 x 1 - 2", "5", "7", "2", "2"},
            new List<string> {"4 x 1 - 2", "5", "7", "2", "2"}
            };

            while (jogoRolando)
            {
                //não tem chances nesse modo

                //Mostra o número de perguntas respondidas
                Console.WriteLine("PERGUNTAS RESPONDIDAS: " + pontos);

                Random random = new Random();
                int index = random.Next(perguntas.Count);
                var pergunta = perguntas[index];

                Console.WriteLine(pergunta[0]);
                Console.WriteLine(pergunta[1]);
                Console.WriteLine(pergunta[2]);
                Console.WriteLine(pergunta[3]);
                Console.WriteLine("Qual a opção correta?: ");
                string respostaJogador = Console.ReadLine().Trim();
                Console.Clear();

                //verifica se a resposta está correta
                if (respostaJogador == pergunta[4])
                {
                    Console.Clear();
                    GameManager.Instance.titulo();
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("CORRETO, PRÓXIMA PERGUNTA");
                    Console.WriteLine("-------------------------");
                    Thread.Sleep(1000);
                }
                else if (respostaJogador != pergunta[4])
                {
                    Console.Clear();
                    GameManager.Instance.titulo();
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("ERRADO, VOCÊ NÃO É DIGNO!");
                    Console.WriteLine("-------------------------");
                    break;
                }

                if (pontos == 10)
                {
                    Console.WriteLine("PARABÉNS, VOCÊ DERROTOU METAFORIZER!");
                    Console.Clear();
                    GameManager.Instance.Menu();
                }

                perguntas.RemoveAt(index);
            }
        }

    }
}
