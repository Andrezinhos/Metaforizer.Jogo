using System;
using System.Collections.Generic;

namespace Aula1
{
    public class Medium
    {
        public void MediumMode()
        {
            bool jogoRolando = true;

            int vidas = 3;
            int pontos = 0;

            //Lista de perguntas

            var perguntas = new List<List<string>>() {
            new List<string> {"Eu fico escondido, mas posso ser visto, se quiser me achar olhe no espelho", "1 - Olho", "2 - Orelha", "3 - Nariz", "1"},
            new List<string> {"Ando sem pés, falo sem voz, estou em todo lugar, mas não deixo pegadas", "1 - Luz", "2 - Som", "3 - Vento", "3"},
            new List<string> {"Deito-me no papel como tinta que pensa, e dou forma ao que só existia no silêncio", "1 - Borracha", "2 - Caneta", "3 - Livro", "2"},
            new List<string> {"Sou corpo de boca aberta, mas só recebo, nunca falo", "1 - Bolsa", "2 - Xícara", "3 - Envelope", "3"},
            new List<string> {"Carrego o mundo nas costas, mas ele nunca me vê", "1 - Sombra", "2 - Noite", "3 - Coluna", "1"},
            new List<string> {"Tenho asas que não batem, voo sem vento, e pouso onde ninguém vê", "1 - Papel", "2 - Pensamento", "3 - Poeira", "2"},
            new List<string> {"Sou silêncio com cheiro, sou tempo que queima, sou pele de planta acesa", "1 - Incenso", "2 - Fumaça", "3 - Vela", "1"},
            new List<string> {"Sou o segredo que dorme em armários, o eco de passos que ninguém ouviu. Não tenho rosto, mas tenho peso", "1 - Silêncio", "2 - Sono", "3 - Passado", "3"},
            new List<string> {"Sou chão que nunca se pisa, e teto que nunca cobre. Habito o meio do que não existe", "1 - Horizonte", "2 - Espelho", "3 - Névoa", "1"},
            new List<string> {"Sou rei que morre a cada instante, mas governa tudo o que é. Nunca volto, mas deixo marcas nos tronos da alma", "1 - Passado", "2 - Tempo", "3 - Destino", "2"}
            };

            while (jogoRolando)
            {

                //Pega Perguntas aleatórias
                Console.WriteLine("CHANCES RESTANTES: " + vidas);
                Console.WriteLine("----------------------");
                //Mostra o número de perguntas respondidas
                Console.WriteLine("PERGUNTAS RESPONDIDAS: " + pontos);
                Console.WriteLine("----------------------");

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
                    pontos++;
                    Console.Clear();
                    titulo();
                    Console.WriteLine("CORRETO, PRÓXIMA PERGUNTA");
                    Console.WriteLine("----------------------");
                    Console.WriteLine(vidas);
                }
                else if (respostaJogador != pergunta[4])
                {
                    vidas--;
                    Console.Clear();
                    titulo();
                    Console.WriteLine("ERRADO, PERDEU UMA CHANCE!");
                    Console.WriteLine("----------------------");
                }

                if (vidas == 0)
                {
                    Console.WriteLine("ACABOU SUAS CHANCES, VOCÊ NÃO É DIGNO!");
                    break;
                }

                if (pontos == 10)
                {
                    Console.WriteLine("PARABÉNS, VOCÊ DERROTOU METAFORIZER!");
                    break;
                }

                perguntas.RemoveAt(index);
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
