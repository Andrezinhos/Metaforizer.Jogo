using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1
{
    public class Creditos : MonoBehavior
    {
        private static Creditos instancia;
        private Creditos()
        {
            Run();
        }
        public static Creditos Instance => instancia ??= new Creditos();
        public override void Update()
        {
            if (!input) return;

            var tecla = Console.ReadKey(true).Key;

            if (tecla != ConsoleKey.Escape)
            {
                GameManager.Instance.cred.visible = false;
                GameManager.Instance.cred.input = false;

                GameManager.Instance.nemo.visible = true;
                GameManager.Instance.nemo.input = true;
            }
        }
        public override void Draw()
        {
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("""
                Jogo criado por André
                Pressione ESC para sair
                """);

        }
    }
}
