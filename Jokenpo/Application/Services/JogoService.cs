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
    
    internal class JogoService : IJogoService
    {
        private readonly IJogoRegrasService _regrasService;
        public JogoService(IJogoRegrasService regrasService)
        {
            _regrasService = regrasService;
        }
        public ResultadoModel Jogar(JogadaEnum j1, JogadaEnum j2)
        {
            return _regrasService.DeterminarResultado(j1, j2);
        }
        public bool TentarConverterEntrada(string entrada, out JogadaEnum jogada)
        {
            jogada = default;

            return entrada.ToUpper() switch
            {
                "PE" => (jogada = JogadaEnum.Pedra) == JogadaEnum.Pedra,
                "P" => (jogada = JogadaEnum.Papel) == JogadaEnum.Papel,
                "T" => (jogada = JogadaEnum.Tesoura) == JogadaEnum.Tesoura,
                _ => false
            };
        }
    }
}
