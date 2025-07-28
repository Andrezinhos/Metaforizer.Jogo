using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace Aula1
{
    public class Hard : MonoBehavior
    {
        private static Hard instancia;

        public Hard()
        {
            Run();
        }

        public static Hard Instance => instancia ??= new Hard();

        int pontos = 0;

        static Random random = new Random();

        //Lista de perguntas
        public List<(string conta, string q1, string q2, string q3, string resposta)> perguntas = new List<(string, string, string, string, string)> {
            ("5 + 2", "8", "7", "6", "7"),
            ("9 - 4", "5", "6", "7", "5"),
            ("3 x 2", "5", "4", "6", "6"),
            ("8 / 2", "3", "2", "4", "4"),
            ("1 + 1 + 2", "3", "4", "6", "4"),
            ("6 - 1 - 2", "6", "3", "4", "3"),
            ("2 x 3 x 1", "4", "6", "5", "6"),
            ("9 / 3 + 1", "5", "2", "4", "4"),
            ("7 - 2 + 1", "5", "6", "7", "6"),
            ("4 x 1 - 2", "5", "7", "2", "2"),
            ("4 x 1 - 2", "5", "7", "2", "2")
        };

        int index = 0;

        public override void Update()
        {
            if (!input) return;

            var pergunta = perguntas[index];

            string respostaJogador = Console.ReadLine();

            //verifica se a resposta está correta
            if (respostaJogador == pergunta.resposta)
            {
                GameManager.Instance.titulo();
                Console.WriteLine("-------------------------");
                Console.WriteLine("CORRETO, PRÓXIMA PERGUNTA");
                Console.WriteLine("-------------------------");
                Thread.Sleep(1000);
            }
            else
            {
                GameManager.Instance.titulo();
                Console.WriteLine("-------------------------");
                Console.WriteLine("ERRADO, VOCÊ NÃO É DIGNO!");
                Console.WriteLine("-------------------------");
            }

            perguntas.RemoveAt(index);

            if (pontos == 10)
            {
                GameManager.Instance.titulo();
                Console.WriteLine("PARABÉNS, VOCÊ DERROTOU METAFORIZER!");
            }
            else if (pontos < 10 && perguntas.Count <= 0)
            {
                Console.WriteLine("BOA, MAS FALTOU ALGUMAS PERGUNTAS");
                GameManager.Instance.facil.visible = false;
                GameManager.Instance.facil.input = false;
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

            Console.SetCursorPosition(0, 0);
            Console.WriteLine($"""
                --------------------------
                PERGUNTAS RESPONDIDAS: {pontos}
                --------------------------------
                {pergunta.conta}
                {pergunta.q1}
                {pergunta.q2}
                {pergunta.q3}
                Qual a opção correta?:  
                """);

        }
    }
}

