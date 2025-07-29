
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

        public Hard dificil;
        public Medium medio;
        public Easy facil;
        public Creditos cred;
        public Modo mod;
        public Menu nemo;

        public override void Update()
        {
            Draw();
        }

        public override void Start()
        {
            nemo = Menu.Instance;
            nemo.visible = true;
            nemo.input = true;
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

        public override void Draw()
        {
            if (facil != null && facil.visible) facil.Draw();
            if (medio != null && medio.visible) medio.Draw();
            if (dificil != null && dificil.visible) dificil.Draw();
            if (nemo != null && nemo.visible) nemo.Draw();
            if (cred != null && cred.visible) cred.Draw();
            if (mod != null && mod.visible) mod.Draw();
        } 
    }
}
