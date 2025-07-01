using System;

namespace Aula1
{
    class Metaforizer
    {
        static void Main()
        {
           
            bool jogoRolando = false;
            titulo();

            Console.WriteLine("Pressione qualquer tecla para jogar");
            Console.ReadLine();
            Console.Clear();
            titulo();

            Console.WriteLine("----------------------");
            Console.WriteLine("1 - Iniciar Jogo");
            Console.WriteLine("2 - Configurações");
            Console.WriteLine("3 - Sair do jogo");
            Console.WriteLine("----------------------");
            Console.WriteLine("Escolha uma opção:");
            string escolha = Console.ReadLine();

            if (escolha == "1")
            {
                Console.Clear();
                titulo();
                Console.WriteLine("-----------------------");
                Console.WriteLine("Escolha a dificuldade: ");
                Console.WriteLine("Fácil - 1");
                Console.WriteLine("-----------------------");
                Console.WriteLine("Médio - 2");
                Console.WriteLine("-----------------------");
                Console.WriteLine("Difícil - 3");
                Console.WriteLine("-----------------------");
                Console.WriteLine("Caótico - 4");
                string escolhaDificuldade = Console.ReadLine();

                switch (escolhaDificuldade)
                {
                    case "1":
                        Easy facil = new Easy();
                        Console.Clear();
                        titulo();
                        facil.EasyMode();
                        break;
                    case "2":
                        Medium medio = new Medium();
                        Console.Clear();
                        titulo();
                        medio.MediumMode();
                        break;
                    case "3":
                        Hard dificil = new Hard();
                        Console.Clear();
                        titulo();
                        dificil.HardMode();
                        break;
                    case "4":
                        Console.Clear();
                        titulo();
                        Chaos.ChaosMode();
                        break;
                }
            }
            else if (escolha == "2")
            {
                Console.WriteLine("Configurações ainda não implementadas. Pressione Enter para voltar ao menu principal.");
                Console.ReadLine();
                Console.Clear();
                titulo();
                Console.WriteLine("1 - Iniciar Jogo");
                Console.WriteLine("2 - Configurações");
                Console.WriteLine("3 - Sair do jogo");
                Console.WriteLine("Escolha uma opção:");
                escolha = Console.ReadLine();
            }
            else if (escolha == "3")
            {
                jogoRolando = false;
                Console.WriteLine("Programa encerrado.");
            }
           
            else
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
                escolha = Console.ReadLine();
            }

            
            while (jogoRolando)
            {
                
                string[,] perguntas = {
            {"Eu fico escondido, mas posso ser visto, se quiser me achar olhe no espelho", "1 - Olho", "2 - Orelha", "3 - Nariz", "1"},
            {"Ando sem pés, falo sem voz, estou em todo lugar, mas não deixo pegadas", "1 - Luz", "2 - Som", "3 - Vento", "3"},
            {"Deito-me no papel como tinta que pensa, e dou forma ao que só existia no silêncio", "1 - Borracha", "2 - Caneta", "3 - Livro", "2"},
            {"Sou corpo de boca aberta, mas só recebo, nunca falo", "1 - Bolsa", "2 - Xícara", "3 - Envelope", "3"},
            {"Carrego o mundo nas costas, mas ele nunca me vê", "1 - Sombra", "2 - Noite", "3 - Coluna", "1"},
            {"Tenho asas que não batem, voo sem vento, e pouso onde ninguém vê", "1 - Papel", "2 - Pensamento", "3 - Poeira", "2"},
            {"Sou silêncio com cheiro, sou tempo que queima, sou pele de planta acesa", "1 - Incenso", "2 - Fumaça", "3 - Vela", "1"},
            {"Sou o segredo que dorme em armários, o eco de passos que ninguém ouviu. Não tenho rosto, mas tenho peso", "1 - Silêncio", "2 - Sono", "3 - Passado", "3"},
            {"Sou chão que nunca se pisa, e teto que nunca cobre. Habito o meio do que não existe", "1 - Horizonte", "2 - Espelho", "3 - Névoa", "1"},
            {"Sou rei que morre a cada instante, mas governa tudo o que é. Nunca volto, mas deixo marcas nos tronos da alma", "1 - Passado", "2 - Tempo", "3 - Destino", "2"}
            };

                Random random = new Random();
                int totalPerguntas = perguntas.GetLength(0);
                int index = random.Next(totalPerguntas);

                Console.WriteLine(perguntas[index, 0]);
                Console.WriteLine(perguntas[index, 1]);
                Console.WriteLine(perguntas[index, 2]);
                Console.WriteLine(perguntas[index, 3]);

                Console.WriteLine("Qual a opção correta?: ");
                string respostaJogador = Console.ReadLine().Trim();

                if (respostaJogador == perguntas[index, 4])
                {
                    Console.WriteLine("CORRETO, PRÓXIMA PERGUNTA");
                    Console.Clear();
                    titulo();
                }
                else
                {
                    Console.WriteLine("ERRADO, VOCÊ NÃO É DIGNO!");
                    break;
                }
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
