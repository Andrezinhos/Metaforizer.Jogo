using System;

namespace Aula1
{
    class Metaforizer
    {
        static void Main()
        {
            bool rodando = true;

            titulo();

            Console.WriteLine("Pressione Enter");
            Console.ReadLine();

            Console.WriteLine("1 - Iniciar Jogo");
            Console.WriteLine("2 - Configurações");
            Console.WriteLine("3 - Sair do jogo");
            Console.WriteLine("Escolha uma opção:");
            string escolha = Console.ReadLine();

            if (escolha == "2")
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
                rodando = false;
                Console.WriteLine("Programa encerrado.");
            }
            else if (escolha == "1")
            {

            }
            else
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
            }

            while (rodando)
            {
                criarPerguntas();
                Console.ReadLine(); Console.Clear();
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
        static void criarPerguntas()
        {
            string[][] perguntas = {
            ["Ando sem pés, falo sem voz, estou em todo lugar, mas não deixo pegadas.","A-Vento","B-","A" ],
            ["Deito-me no papel como tinta que pensa, e dou forma ao que só existia no silêncio.", "", "", ""],
            ["Sou corpo de boca aberta, mas só recebo, nunca falo.", "", "", ""],
            ["Carrego o mundo nas costas, mas ele nunca me vê.", "", "", ""],
            ["Tenho asas que não batem, voo sem vento, e pouso onde ninguém vê.", "", "", ""],
            ["Sou silêncio com cheiro, sou tempo que queima, sou pele de planta acesa.", "", "", ""],
            ["Sou o segredo que dorme em armários, o eco de passos que ninguém ouviu. Não tenho rosto, mas tenho peso.", "", "", ""],
            ["Sou chão que nunca se pisa, e teto que nunca cobre. Habito o meio do que não existe.", "", "", ""],
            ["Sou rei que morre a cada instante, mas governa tudo o que é. Nunca volto, mas deixo marcas nos tronos da alma.", "", "", ""],
            ["Eu fico escondido, mas posso ser visto, se quiser me achar olhe no espelho", "", "", ""],
            ["Eu fico escondido, mas posso ser visto, se quiser me achar olhe no espelho", "", "", ""]
            };

            Random random = new Random();
            int index = random.Next(perguntas.Length);
            string perguntaAleatoria = perguntas[index][0];
            Console.WriteLine(perguntaAleatoria);


            
        }

    
    
    }
}
