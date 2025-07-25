using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1
{
    public class Creditos : MonoBehavior
    {
        public override void Update()
        {
            var tecla = Console.ReadKey(true).Key;

            if (tecla != ConsoleKey.Escape)
            {
                GameManager.Instance.nemo.visible = true;
                GameManager.Instance.cred.visible = false;
            }
        }
        public override void Draw()
        {   
            Console.WriteLine("Jogo criado por André");
            Console.WriteLine("Pressione ESC para sair");
        }
    }
}
