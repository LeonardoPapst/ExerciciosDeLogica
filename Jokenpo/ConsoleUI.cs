using Jokenpo.Application.Services;
using Jokenpo.Application.Services.Interfaces;
using Jokenpo.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jokenpo
{
    public class ConsoleUI
    {
        private readonly IJogoService _jogoService;

        public ConsoleUI(IJogoService jogoService)
        {
            _jogoService = jogoService;
        }

        public void Iniciar()
        {
            while (true)
            {
                MostrarMenu();

                var tecla = Console.ReadKey(true).Key;

                if (tecla == ConsoleKey.Escape)
                {
                    Console.WriteLine("Obrigado por jogar! Até a próxima.");
                    return;
                }

                if (tecla == ConsoleKey.Enter)
                {
                    ExecutarPartida();
                }
                else
                {
                    Console.WriteLine("Opção inválida!");
                }
            }
        }

        private void MostrarMenu()
        {
            Console.WriteLine("Bem-vindo ao Jokenpo!");
            Console.WriteLine("ENTER = Jogar | ESC = Sair");
        }

        private void ExecutarPartida()
        {
            var jogada1 = LerJogada("Jogador 1");
            var jogada2 = LerJogada("Jogador 2");

            var resultado = _jogoService.Jogar(jogada1, jogada2);

            Console.WriteLine(resultado.Mensagem);
            Console.WriteLine("-------------------------------");
        }

        private JogadaEnum LerJogada(string jogador)
        {
            while (true)
            {
                Console.Write($"{jogador}, escolha (PE/P/T): ");
                string entrada = Console.ReadLine()?.Trim();

                if (_jogoService.TentarConverterEntrada(entrada, out JogadaEnum jogada))
                    return jogada;

                Console.WriteLine("Entrada inválida! Tente novamente.");
            }
        }
    }
}
