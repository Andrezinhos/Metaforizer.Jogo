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

        int vidas = 5;
        int pontos = 0;

        //Lista de perguntas
        public List<(string categoria, string resposta)> perguntas = new List<(string, string)> {
            ( "ANIMAL DOMÉSTICO", "gato" ),
            ( "BRINQUEDO", "bola" ),
            ( "MÓVEL", "mesa" ),
            ( "LUGAR PARA MORAR", "casa" ),
            ( "CLIMA", "chuva" ),
            ( "VESTIMENTA", "sapato" ),
            ( "OBJETO DE INFORMAÇÃO", "livro"),
            ( "PONTO DE VISTA", "janela"),
            ( "INSTITUIÇÃO BÁSICA", "escola"),
            ( "TIPO DE PESSOA", "amigo" ),
        };

        static Random random = new Random();
        

        public override void Update()
        {
            Draw();

            int index = random.Next(perguntas.Count);
            var pergunta = perguntas[index];


            string respostaJogador = Console.ReadLine().Trim();
            Console.Clear();

            //verifica se a resposta está correta
            if (respostaJogador == pergunta.resposta)
            {
                pontos++;
                Console.Clear();
                Console.WriteLine("-------------------------");
                Console.WriteLine("CORRETO, PRÓXIMA PERGUNTA");
                Console.WriteLine("-------------------------");
                Thread.Sleep(800);
            }
            else
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
            }

            if (pontos == 10)
            {
                Console.Clear();
                GameManager.Instance.titulo();
                Console.WriteLine("PARABÉNS, VOCÊ DERROTOU METAFORIZER!");
            }
            perguntas.RemoveAt(index);
        }

        public override void Draw()
        {
            Console.SetCursorPosition(0, 0);
            //Pega Perguntas aleatórias
            Console.WriteLine("CHANCES RESTANTES: " + vidas);
            Console.WriteLine("--------------------------------");
            //Mostra o número de perguntas respondidas
            Console.WriteLine("PERGUNTAS RESPONDIDAS: " + pontos);
            Console.WriteLine("--------------------------------");
            Console.WriteLine(pergunta.categoria);
            Console.WriteLine("Qual a palavra correta?: ");



        }

    }
}
