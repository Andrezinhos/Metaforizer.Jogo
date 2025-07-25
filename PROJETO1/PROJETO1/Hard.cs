using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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

        public override void Update()
        {
            Draw();
        }
        public override void Draw()
        {
            bool jogoRolando = true;

            int pontos = 0;




            //não tem chances nesse modo

            //Mostra o número de perguntas respondidas
            Console.WriteLine("PERGUNTAS RESPONDIDAS: " + pontos);

            Random random = new Random();
            int index = random.Next(perguntas.Count);
            var pergunta = perguntas[index];

            Console.WriteLine(pergunta.conta);
            Console.WriteLine(pergunta.q1);
            Console.WriteLine(pergunta.q2);
            Console.WriteLine(pergunta.q3);
            Console.WriteLine("Qual a opção correta?: ");
            string respostaJogador = Console.ReadLine().Trim();

            //verifica se a resposta está correta
            if (respostaJogador == pergunta.resposta)
            {
                Console.Clear();
                GameManager.Instance.titulo();
                Console.WriteLine("-------------------------");
                Console.WriteLine("CORRETO, PRÓXIMA PERGUNTA");
                Console.WriteLine("-------------------------");
                Thread.Sleep(1000);
            }
            else
            {
                Console.Clear();
                GameManager.Instance.titulo();
                Console.WriteLine("-------------------------");
                Console.WriteLine("ERRADO, VOCÊ NÃO É DIGNO!");
                Console.WriteLine("-------------------------");
            }

            if (pontos == 10)
            {
                Console.Clear();
                GameManager.Instance.titulo();
                Console.WriteLine("PARABÉNS, VOCÊ DERROTOU METAFORIZER!");
            }

            perguntas.RemoveAt(index);
        }
    }
}

