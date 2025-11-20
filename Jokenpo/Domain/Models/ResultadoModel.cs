using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jokenpo.Domain.Models
{
    public class ResultadoModel
    {
        public string Mensagem { get; }
        public bool Empate { get; }

        public ResultadoModel(string mensagem, bool empate)
        {
            Mensagem = mensagem;
            Empate = empate;
        }
    }
}
