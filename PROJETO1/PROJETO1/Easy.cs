using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

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

        int vidas = 5;
        int pontos = 0;

        static Random random = new Random();
        

        //Lista de perguntas
        public static List<(string categoria, string resposta)> perguntas = new List<(string, string)> {
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

        public int index = 0;

        public override void Update()
        {
            if (!input) return;

            var pergunta = perguntas[index];

            string respostaJogador = Console.ReadLine().Trim();
            Console.Clear();
            Console.WriteLine("-------------------------");

            //verifica se a resposta está correta
            if (respostaJogador == pergunta.resposta)
            {
                pontos++;
                Console.WriteLine("CORRETO, PRÓXIMA PERGUNTA");
            }
            else
            {
                vidas--;
                Console.WriteLine("ERRADO, PERDEU UMA CHANCE!");
            }

            Console.WriteLine("-------------------------");
            Thread.Sleep(1500);
            Console.Clear();
            perguntas.RemoveAt(index);

            if (vidas <= 0)
            {
                GameManager.Instance.titulo();
                Console.WriteLine("ACABOU SUAS CHANCES, VOCÊ NÃO É DIGNO!");
                visible = false;
                input = false;
            }

            if (pontos == 10)
            {
                GameManager.Instance.titulo();
                Console.WriteLine("PARABÉNS, VOCÊ DERROTOU METAFORIZER!");
                visible = false;
                input = false;
                GameManager.Instance.mod.visible = true;
                GameManager.Instance.mod.input = true;
            }
            else if (pontos < 10 && perguntas.Count <= 0)
            {
                GameManager.Instance.titulo();
                Console.WriteLine("BOA, MAS FALTOU ALGUMAS PERGUNTAS");
                visible = false;
                input = false;
                GameManager.Instance.mod.visible = true;
                GameManager.Instance.mod.input = true;
            }

            if (perguntas.Count > 0)
            {
                int index = random.Next(perguntas.Count);
            }
        }

        public override void Draw()
        {
            if (perguntas.Count == 0) return;
            var pergunta = perguntas[index];

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"""
                ================================
                CHANCES RESTANTES: {vidas}
                --------------------------------
                PERGUNTAS RESPONDIDAS: {pontos}
                --------------------------------
                {pergunta.categoria}

                Qual a palavra correta?: 
                """);
        }

    }
}
