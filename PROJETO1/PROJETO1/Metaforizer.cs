using System;

namespace Aula1
{
    class Metaforizer
    {
        static void Main()
        {
            GameManager.Instance.Menu();
            /*  while (jogoRolando)
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

         */
        }

    }
}
