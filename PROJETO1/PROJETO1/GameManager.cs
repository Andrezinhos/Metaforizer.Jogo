using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1
{
    class GameManager
    {
        private static GameManager instancia;

        private GameManager() { }

        public static GameManager Instance => instancia ??= new GameManager();

        public string escolha = Console.ReadLine();
        

        public void Start()
        {
            bool jogoRolando = false;

            titulo();
            Console.WriteLine("----------------------");
            Console.WriteLine("1 - Iniciar Jogo");
            Console.WriteLine("2 - Créditos");
            Console.WriteLine("3 - Sair");
            Console.WriteLine("----------------------");
            Console.WriteLine("Escolha uma opção:");
            escolha = Console.ReadLine();
            Console.Clear();

            switch (escolha)
            {
                case "1": Menu();
                    break;
                case "2": Creditos();
                    break;
                case "3": jogoRolando = false;
                    break;
            }
        }

        public void Menu()
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
                    Chaos caos = new Chaos();
                    Console.Clear();
                    titulo();
                    caos.ChaosMode();
                    break;
                case "5":
                    Console.Clear();
                    Start();
                    break;
            }
        }

        public void Creditos()
        {
            var tecla = Console.ReadKey(true).Key;

            do
            {
                titulo();
                Console.WriteLine("Jogo criado por André");
                Console.WriteLine("Pressione ESC para sair");
                tecla = Console.ReadKey(true).Key;

            } while (tecla != ConsoleKey.Escape);
            Console.Clear();
            Start();
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

            Console.WriteLine(title);
        }
    }
}
