using Jokenpo;
using Jokenpo.Application.Services;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        var regra = new JogoRegrasService();
        var jogo = new JogoService(regra);

        var ui = new ConsoleUI(jogo);
        ui.Iniciar();
    }
}