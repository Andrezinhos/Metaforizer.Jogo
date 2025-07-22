using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1
{
    public abstract class MonoBehavior
    {
        private Thread t;
        private bool ativo = true;

        public void Run()
        {
            Awake();
            Start();

            t = new Thread(
                () => {
                    while (ativo)
                    {
                        Update();
                        LateUpdate();
                        Thread.Sleep(800);
                    }

                    OnDestroy();

                }
            );

            t.Start();
        }

        public void Stop()
        {
            this.ativo = false;
            t.Join();
        }

        public void Awake() { }
        public void Start() { }
        public void Update() { }
        public  void LateUpdate() { }
        public void OnDestroy() { }
    }
}
