using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;

namespace Aula1
{
    public class Chaos
    {
        private static bool tempoEsgotado = false;
        private static bool tempoComeça = false;
        public void ChaosMode()
        {
            bool jogoRolando = true;
            int tempoLimite = 30;

            int pontos = 0;

            //Lista de perguntas

            var palavras = new List<List<string>>() {
            new List<string> {"ANIMAL DOMÉSTICO", "G", "A", "T", "O"},
            new List<string> {"BRINQUEDO", "B", "O", "L", "A"},
            new List<string> {"MÓVEL", "M", "E", "S", "A"},
            new List<string> {"LUGAR PARA MORAR", "C", "A", "S", "A"},
            new List<string> {"CLIMA", "C", "H", "U", "V", "A"},
            new List<string> {"VESTIMENTA", "S", "A", "P", "A", "T", "O"},
            new List<string> {"OBJETO DE INFORMAÇÃO", "L", "I", "V", "R", "O"},
            new List<string> {"PONTO DE VISTA", "J", "A", "N", "E", "L", "A"},
            new List<string> {"INSTITUIÇÃO", "1 - Horizonte", "2 - Espelho", "3 - Névoa", "1"},
            new List<string> {"TIPO DE PESSOA", "A", "2 - Tempo", "3 - Destino", "2"}
            };

            //tempo do jogo

            static async Task cronometro()
            {
                await Cronometro(30);
            }

            static async Task Cronometro(int segundos)
            {
                for (int i = 0; i > 0; i--)
                {
                    Console.WriteLine($"FALTAM {i} SEGUNDOS");
                    await Task.Delay(1000);
                }  
            }

            while (jogoRolando)
            {
                //não tem chances nesse modo

                //Mostra o número de perguntas respondidas
                Console.WriteLine("PERGUNTAS RESPONDIDAS: " + pontos);

                Random random = new Random();
                int index = random.Next((int)palavras.Count);
                var palavras = palavras[index];

                Console.WriteLine((string)palavras[0]);

                Console.WriteLine("Qual a opção correta?: ");
                string respostaJogador = Console.ReadLine().Trim();
                Console.Clear();

                //verifica se a resposta está correta
                if (respostaJogador == palavras[4])
                {
                    pontos++;
                    Console.Clear();
                    titulo();
                    Console.WriteLine("CORRETO, PRÓXIMA PERGUNTA");
                    Console.WriteLine("-------------------------");
                }
                else if (respostaJogador != palavras[4])
                {
                    Console.Clear();
                    titulo();
                    Console.WriteLine("ERRADO, PRÓXIMA PERGUNTA!");
                    Console.WriteLine("--------------------------");
                }

                //Mensagem Final de Jogo

                if (pontos == 10)
                {
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("PARABÉNS, VOCÊ DERROTOU METAFORIZER!");
                    Thread.Sleep(1000);
                    break;
                }
                if (palavras.Count == 0)
                {
                    Console.WriteLine("BOA, MAS FALTOU ALGUMAS PERGUNTAS: " + pontos);
                    Thread.Sleep(1000);
                    break;
                }

                palavras.RemoveAt(index);
            }

            if (tempoEsgotado)
            {
                Console.WriteLine("ACABOU SEU TEMPO, VOCÊ NÃO É DIGNO");
                Console.WriteLine("PERGUNTAS RESPONDIDAS: " + pontos);
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
