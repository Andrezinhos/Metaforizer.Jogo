using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1
{
    class Pergunta
    {
        public string pergunta { get; set; }
        public List<string> respostas { get; set; }
        public int RespostaCorreta { get; set; }
        public Pergunta(string pergunta, List<string> respostas, int respostaCorreta)
        {
            this.pergunta = pergunta;
            this.respostas = respostas;
            RespostaCorreta = respostaCorreta;
        }
        public bool VerificarResposta(int respostaUsuario)
        {
            return respostaUsuario == RespostaCorreta;
        }
    }
}
