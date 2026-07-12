using Spectre.Console;
namespace MathGame;

public class GameRound
{
    public static void Play (string operationSymbol, int numberA, int numberB, int correctResult)
    {
        AnsiConsole.MarkupLine($"[yellow]{numberA} {operationSymbol} {numberB} = ?[/]");
        int userAnswer = AnsiConsole.Ask<int>("Your Answer:");

        if(userAnswer == correctResult)
        {
            AnsiConsole.MarkupLine("[green]Correct![/]");
        }
        else
        {
            AnsiConsole.MarkupLine($"[red]Incorrect.[/] The correct result was: [bold]{correctResult}[/]");
        }
        AnsiConsole.MarkupLine("[grey]Press any key to continue...[/]");
        Console.ReadKey(true);
    }
}