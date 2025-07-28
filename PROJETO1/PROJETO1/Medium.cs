using System;
using System.Collections.Generic;
using System.Threading;

namespace Aula1
{
    public class Medium : MonoBehavior
    {
        private static Medium instancia;
        public Medium() 
        {
            Run();
        }
        
        public static Medium Instance => instancia ??= new Medium();

        int vidas = 3;
        int pontos = 0;

        static Random random = new Random();

        public static List<(string charada, string q1, string q2, string q3, string resposta)> perguntas = new List<(string, string, string, string, string)>{
            ("Eu fico escondido, mas posso ser visto, se quiser me achar olhe no espelho", "1 - Olho", "2 - Orelha", "3 - Nariz", "1"),
            ("Ando sem pés, falo sem voz, estou em todo lugar, mas não deixo pegadas", "1 - Luz", "2 - Som", "3 - Vento", "3"),
            ("Deito-me no papel como tinta que pensa, e dou forma ao que só existia no silêncio", "1 - Borracha", "2 - Caneta", "3 - Livro", "2"),
            ("Sou corpo de boca aberta, mas só recebo, nunca falo", "1 - Bolsa", "2 - Xícara", "3 - Envelope", "3"),
            ("Carrego o mundo nas costas, mas ele nunca me vê", "1 - Sombra", "2 - Noite", "3 - Coluna", "1"),
            ("Tenho asas que não batem, voo sem vento, e pouso onde ninguém vê", "1 - Papel", "2 - Pensamento", "3 - Poeira", "2"),
            ("Sou silêncio com cheiro, sou tempo que queima, sou pele de planta acesa", "1 - Incenso", "2 - Fumaça", "3 - Vela", "1"),
            ("Sou o segredo que dorme em armários, o eco de passos que ninguém ouviu. Não tenho rosto, mas tenho peso", "1 - Silêncio", "2 - Sono", "3 - Passado", "3"),
            ("Sou chão que nunca se pisa, e teto que nunca cobre. Habito o meio do que não existe", "1 - Horizonte", "2 - Espelho", "3 - Névoa", "1"),
            ("Sou rei que morre a cada instante, mas governa tudo o que é. Nunca volto, mas deixo marcas nos tronos da alma", "1 - Passado", "2 - Tempo", "3 - Destino", "2")
        };

        int index = 0;

        public override void Update()
        {
            if (!input) return;

            var pergunta = perguntas[index];

            string respostaJogador = Console.ReadLine();
            Console.Clear();

            
            
            //verifica se a resposta está correta
            if (respostaJogador == pergunta.resposta)
            {
                pontos++;
                Console.WriteLine("--------------------------");
                Console.WriteLine("CORRETO, PRÓXIMA PERGUNTA");
                Console.WriteLine("-------------------------");
                Thread.Sleep(1000);
            }
            else
            {
                vidas--;
                Console.WriteLine("--------------------------");
                Console.WriteLine("ERRADO, PERDEU UMA CHANCE!");
                Console.WriteLine("--------------------------");
                Thread.Sleep(1000);
            }

            perguntas.RemoveAt(index);

            if (vidas == 0)
            {
                GameManager.Instance.titulo();
                Console.WriteLine("ACABOU SUAS CHANCES, VOCÊ NÃO É DIGNO!");
                GameManager.Instance.facil.visible = false;
                GameManager.Instance.facil.input = false;
            }

            if (pontos == 10)
            {
                GameManager.Instance.titulo();
                Console.WriteLine("PARABÉNS, VOCÊ DERROTOU METAFORIZER!");
                GameManager.Instance.facil.visible = false;
                GameManager.Instance.facil.input = false;
            }

            if (perguntas.Count > 0)
            {
                int index = random.Next(perguntas.Count);
            }
            else if (pontos < 0 &&  perguntas.Count > 0)
            {
                Console.WriteLine("BOA, MAS FALTOU ALGUMAS PERGUNTAS");
                GameManager.Instance.facil.visible = false;
                GameManager.Instance.facil.input = false;
            }
        }

        public override void Draw()
        {
            if (perguntas.Count == 0) return;
            var pergunta = perguntas[index];

            Console.SetCursorPosition(0, 0);
            Console.WriteLine($"""
                CHANCES RESTANTES: {vidas}
                --------------------------
                PERGUNTAS RESPONDIDAS: {pontos}
                --------------------------------
                {pergunta.charada}
                {pergunta.q1}
                {pergunta.q2}
                {pergunta.q3}
                Qual a opção correta?:  
                """);

        }

    }

}

