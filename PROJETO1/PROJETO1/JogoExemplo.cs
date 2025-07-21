using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;


namespace Aula1
{
    class JogoExemplo
    {

        

        static char[,] mapa;
        static int largura = 20;
        static int altura = 10;
        static int playerX = 1;
        static int playerY = 1;
        static bool jogando = true;

        public void Main()
        {
            
            Console.Clear();

            //aqui vai entrar o menu de vocês
            jogar();            
        }

        public void jogar()
        {
            iniciarMapa();

            while(jogando)
            {
                Console.Clear();
                desenharMapa();

                var tecla = Console.ReadKey(true).Key;

                atualizarPosicao(tecla);
            }
        }

        static void iniciarMapa()
        {
            mapa = new char[largura, altura]; 

            for (int y = 0; y < altura; y++)
            {
                for (int x = 0; x < largura; x++)
                {
                    //ultima posição do vetor, é tamanho -1
                    if (x == 0 || y == 0 || x == largura -1 || y == altura -1)
                    {
                        //borda do mapa
                        mapa[x, y] = '#';
                    }
                    else
                    {
                        mapa[x, y] = ' ';
                    }
                }
            }
            mapa[playerX, playerY] = '@';
        }

        static void desenharMapa()
        {
            for (int y = 0; y < altura; y++)
            {
                for (int x = 0; x < largura; x++)
                {
                    Console.Write(mapa[x, y]);
                }
                Console.WriteLine();
            }
        }
        Vector2 pos = new Vector2(1, 1);
        public void atualizarPosicao(ConsoleKey tecla)
        {
            int tempX = playerX;
            int tempY = playerY;
            int x = pos.x;
            int y = pos.y;

            switch (tecla)
            {
                case ConsoleKey.A:
                    x = pos.Left;
                    break;
                case ConsoleKey.D:
                    x = pos.Right;
                    break;
                case ConsoleKey.W:
                    y = pos.Up;
                    break;
                case ConsoleKey.S:
                    y = pos.Down;
                    break;
            }

            if (mapa[tempX, tempY] != '#')
            {
                mapa[playerX, playerY] = ' ';
                mapa[tempX, tempY] = '@';
                playerX = tempX;
                playerY = tempY;
            }
        }
    }
}
