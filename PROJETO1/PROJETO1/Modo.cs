using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1
{
    public class Modo : MonoBehavior
    {
        private static Modo instancia;
        private Modo()
        {
            Run();
        }
        public static Modo Instance => instancia ??= new Modo();

        string escolhaDificuldade = Console.ReadLine();
        public override void Update()
        {

            string escolhaDificuldade = Console.ReadLine();

            switch (escolhaDificuldade)
            {
                case "1":
                    Console.Clear();
                    GameManager.Instance.mod.visible = false;
                    GameManager.Instance.mod.input = false;
                    GameManager.Instance.facil = Easy.Instance;
                    GameManager.Instance.facil.visible = true;
                    GameManager.Instance.facil.input = true;
                    break;
                case "2":
                    Console.Clear();
                    GameManager.Instance.mod.visible = false;
                    GameManager.Instance.mod.input = false;
                    GameManager.Instance.medio = Medium.Instance;
                    GameManager.Instance.medio.visible = true;
                    GameManager.Instance.medio.input = true;
                    break;
                case "3":
                    Console.Clear();
                    GameManager.Instance.mod.visible = false;
                    GameManager.Instance.mod.input = false;
                    GameManager.Instance.facil = Easy.Instance;
                    GameManager.Instance.facil.visible = true;
                    GameManager.Instance.facil.input = true;
                    break;
                case "4":
                    GameManager.Instance.facil.visible = false;
                    GameManager.Instance.medio.visible = false;
                    GameManager.Instance.dificil.visible = false;
                    GameManager.Instance.mod.visible = false;
                    GameManager.Instance.nemo = Menu.Instance;
                    GameManager.Instance.nemo.visible = true;
                    GameManager.Instance.nemo.input = true;
                    break;
            }
        }
        public override void Draw()
        {
            Console.SetCursorPosition(0, 0);
            GameManager.Instance.titulo();
            Console.WriteLine("Escolha a dificuldade: ");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Fácil - 1");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Médio - 2");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Difícil - 3");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Voltar - 4");
            Console.WriteLine("-----------------------");
        }
    }
}
