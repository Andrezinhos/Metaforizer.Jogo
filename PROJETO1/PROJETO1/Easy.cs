using System;
using System.Collections.Generic;
using System.Threading;

namespace Aula1
{
    //modo fácil do jogo
    public class Easy : MonoBehavior
    {
        private static Easy instancia;

        private Easy() 
        {
            Run();         
        }

        public static Easy Instance => instancia ??= new Easy();

        public string escolha = Console.ReadLine();
        public void EasyMode()
        {
            bool jogoRolando = true;
            
            int vidas = 5;
            int pontos = 0;

            //Lista de perguntas

            var perguntas = new List<List<string>>() {
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

                //Pega Perguntas aleatórias
                Console.WriteLine("CHANCES RESTANTES: " + vidas);
                Console.WriteLine("--------------------------------");
                //Mostra o número de perguntas respondidas
                Console.WriteLine("PERGUNTAS RESPONDIDAS: " + pontos);
                Console.WriteLine("--------------------------------");

                Random random = new Random();
                int index = random.Next(perguntas.Count);
                var pergunta = perguntas[index];

                Console.WriteLine(pergunta[0]);
                Console.WriteLine("Qual a palavra correta?: ");
                string respostaJogador = Console.ReadLine().Trim();
                Console.Clear();

                //verifica se a resposta está correta
                if (respostaJogador == pergunta[1])
                {
                    pontos++;
                    Console.Clear();
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("CORRETO, PRÓXIMA PERGUNTA");
                    Console.WriteLine("-------------------------");
                    Thread.Sleep(800);
                }
                else if (respostaJogador != pergunta[1])
                {
                    vidas--;
                    Console.Clear();
                    Console.WriteLine("--------------------------");
                    Console.WriteLine("ERRADO, PERDEU UMA CHANCE!");
                    Console.WriteLine("--------------------------");
                    Thread.Sleep(800);
                } 

                if (vidas == 0)
                {
                    GameManager.Instance.titulo();
                    Console.WriteLine("ACABOU SUAS CHANCES, VOCÊ NÃO É DIGNO!");
                    break;
                }

                if (pontos == 10)
                {
                    Console.Clear();
                    GameManager.Instance.titulo();
                    Console.WriteLine("PARABÉNS, VOCÊ DERROTOU METAFORIZER!");
                    break;
                }
                perguntas.RemoveAt(index);
            }
        }

    }
}
