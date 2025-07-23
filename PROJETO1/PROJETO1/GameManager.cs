
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1
{
    class GameManager : MonoBehavior
    {
        private static GameManager instancia;

        private GameManager()
        {
            Run();
        }

        public static GameManager Instance => instancia ??= new GameManager();

        public string escolha;
        public bool jogoRolando;
        public void Menu()
        {
            titulo();
            Console.WriteLine("----------------------");
            Console.WriteLine("1 - Iniciar Jogo");
            Console.WriteLine("2 - Créditos");
            Console.WriteLine("3 - Sair");
            Console.WriteLine("----------------------");
            Console.WriteLine("Escolha uma opção:");
            escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    Console.Clear();
                    Modo();
                    break;
                case "2":
                    Console.Clear();
                    Creditos();
                    break;
                case "3":
                    Console.Clear();
                    Stop();
                    break;
            }
        }

        public void Modo()
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
            Console.WriteLine("-----------------------");
            Console.WriteLine("Voltar - 5");
            string escolhaDificuldade = Console.ReadLine();

            switch (escolhaDificuldade)
            {
                case "1":
                    Console.Clear();
                    Easy.Instance.EasyMode();
                    break;
                case "2":
                    Console.Clear();
                    Medium.Instance.MediumMode();
                    break;
                case "3":
                    Console.Clear();
                    Hard.Instance.HardMode();
                    break;
                case "4":
                    Console.Clear();
                    Chaos.Instance.ChaosMode();
                    break;
                case "5":
                    Console.Clear();
                    titulo();
                    Menu();
                    break;
            }
        }

        public void Creditos()
        {
            var tecla = Console.ReadKey(true).Key;

            do
            {
                Console.WriteLine("Jogo criado por André");
                Console.WriteLine("Pressione ESC para sair");
                tecla = Console.ReadKey(true).Key;

            } while (tecla != ConsoleKey.Escape);
            Console.Clear();
            Menu();
        }

        public bool tempoAcabou = false;
        public void TempoVisual(int segundos)
        {
            tempoAcabou = false;
            for (int i = segundos; i >= 0; i--)
            {
                if (!Chaos.Instance.jogoRolando) break;

                Console.SetCursorPosition(0, 0); // volta para o início da linha
                Console.WriteLine("TEMPO RESTANTE: " + i + "   ");    // o espaço extra apaga números antigos
                Thread.Sleep(1000);
            }

            tempoAcabou = true;
        }
        public void titulo()
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

            Console.Write(title);
        }
    }
}
