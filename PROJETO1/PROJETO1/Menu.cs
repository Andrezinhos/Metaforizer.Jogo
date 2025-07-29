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
            if (!input) return;

            string escolha = Console.ReadLine();
            switch (escolha)
            {
                case "1":
                    GameManager.Instance.mod = Modo.Instance;
                    GameManager.Instance.mod.visible = true;
                    GameManager.Instance.mod.input = true;

                    GameManager.Instance.nemo.visible = false;
                    GameManager.Instance.nemo.input = false;
                    break;
                case "2":
                    GameManager.Instance.cred = Creditos.Instance;
                    GameManager.Instance.cred.visible = true;
                    GameManager.Instance.cred.input = true;

                    GameManager.Instance.nemo.visible = false;
                    GameManager.Instance.nemo.input = false;
                    break;
                case "3":
                    Console.Clear();
                    visible = false;
                    input = false;
                    break;
            }
        }
        public override void Draw()
        {
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            GameManager.Instance.titulo();
            Console.WriteLine("""
                ----------------------
                1 - Iniciar Jogo
                2 - Créditos
                3 - Sair
                ----------------------
                Escolha uma opção:
                """);
        }
    }
}
