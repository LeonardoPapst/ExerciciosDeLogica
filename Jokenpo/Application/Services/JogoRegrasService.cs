using Jokenpo.Application.Services.Interfaces;
using Jokenpo.Domain.Enums;
using Jokenpo.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jokenpo.Application.Services
{
    public class JogoRegrasService : IJogoRegrasService
    {
        public ResultadoModel DeterminarResultado(JogadaEnum jogador1, JogadaEnum jogador2)
        {
            if (jogador1 == jogador2)
                return new ResultadoModel("Empate!", true);

            bool jogador1Vence =
                (jogador1 == JogadaEnum.Tesoura && jogador2 == JogadaEnum.Papel) ||
                (jogador1 == JogadaEnum.Papel && jogador2 == JogadaEnum.Pedra) ||
                (jogador1 == JogadaEnum.Pedra && jogador2 == JogadaEnum.Tesoura);

            return jogador1Vence
                ? new ResultadoModel("Jogador 1 vence!", false)
                : new ResultadoModel("Jogador 2 vence!", false);
        }
    }
}
