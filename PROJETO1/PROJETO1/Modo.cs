using System;
using System.Collections.Generic;
using System.Data;
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

        public override void Update()
        {
            if (!input) return;

            string escolhaDificuldade = Console.ReadLine();

            switch (escolhaDificuldade)
            {
                case "1":
                    GameManager.Instance.facil = Easy.Instance;
                    GameManager.Instance.facil.visible = true;
                    GameManager.Instance.facil.input = true;

                    GameManager.Instance.mod.visible = false;
                    GameManager.Instance.mod.input = false;
                    break;
                case "2":
                    GameManager.Instance.medio = Medium.Instance;
                    GameManager.Instance.medio.visible = true;
                    GameManager.Instance.medio.input = true;
                    
                    GameManager.Instance.mod.visible = false;
                    GameManager.Instance.mod.input = false;
                    break;
                case "3":
                    GameManager.Instance.dificil = Hard.Instance;
                    GameManager.Instance.dificil.visible = true;
                    GameManager.Instance.dificil.input = true;

                    GameManager.Instance.mod.visible = false;
                    GameManager.Instance.mod.input = false;
                    break;
                case "4":
                    GameManager.Instance.nemo = Menu.Instance;
                    GameManager.Instance.nemo.visible = true;
                    GameManager.Instance.nemo.input = true;

                    visible = false;
                    input = false;
                    break;
            }
        }
        public override void Draw()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            GameManager.Instance.titulo();
            Console.WriteLine("""
                ESCOLHA A DIFICULDADE: 
                -----------------------
                FÁCIL - 1
                -----------------------
                MÉDIO - 2
                -----------------------
                DIFÍCIL - 3
                -----------------------
                SAIR - 4
                -----------------------
                """);
            
        }
    }
}
