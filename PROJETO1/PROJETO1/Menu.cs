using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1
{
    public class Menu : MonoBehavior
    {
        private static Menu instancia;
        private Menu()
        {
            Run();
        }
        public static Menu Instance => instancia ??= new Menu();

        

        public override void Update()
        {
            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    Console.Clear();
                    GameManager.Instance.nemo.visible = false;
                    GameManager.Instance.nemo.input = false;
                    GameManager.Instance.mod = Modo.Instance;
                    GameManager.Instance.mod.visible = true;
                    Stop();
                    break;
                case "2":
                    break;
                case "3":
                    Console.Clear();
                    Stop();
                    break;
            }
        }
        public override void Draw()
        {
            Console.SetCursorPosition(0, 0);
            GameManager.Instance.titulo();
            Console.WriteLine("----------------------");
            Console.WriteLine("1 - Iniciar Jogo");
            Console.WriteLine("2 - Créditos");
            Console.WriteLine("3 - Sair");
            Console.WriteLine("----------------------");
            Console.WriteLine("Escolha uma opção:");
        }
    }
}
