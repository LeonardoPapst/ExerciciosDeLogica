using Jokenpo.Domain.Enums;
using Jokenpo.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jokenpo.Application.Services.Interfaces
{
    public interface IJogoService
    {
        public ResultadoModel Jogar(JogadaEnum j1, JogadaEnum j2);
        public bool TentarConverterEntrada(string entrada, out JogadaEnum jogada);
    }
}
