using Spectre.Console;
using MathGame;
using System.Runtime.CompilerServices;


while (true)
{

    MenuOption choice = UserInterface.ShowMenu();
    var (numberA, numberB) = Randomize.GenerateNumbers();
    int correctResult = 0;

    switch (choice)
    {
        case MenuOption.Addition:

            AnsiConsole.MarkupLine("You selected [cyan]Addition[/]!");
            correctResult = Addition.AddNumber(numberA, numberB);
            GameRound.Play("+", numberA, numberB, Addition.AddNumber(numberA, numberB));

            break;

        case MenuOption.Subtraction:

            AnsiConsole.MarkupLine("You selected [cyan]Subtraction[/]!");
            correctResult = Subtraction.SubtracNumber(numberA, numberB);
            GameRound.Play("-", numberA, numberB, Subtraction.SubtracNumber(numberA, numberB));

            break;

        case MenuOption.Division:

            AnsiConsole.MarkupLine("You selected [cyan]Division[/]!");
            var (dividend, divisor) = Randomize.GenerateDivisionNumbers();
            GameRound.Play("/", dividend, divisor, Division.DivNum(dividend, divisor));

            break;
        case MenuOption.Multiplication:
            AnsiConsole.MarkupLine("You selected [cyan]Multiplication[/]!");
            break;
        case MenuOption.Random:
            AnsiConsole.MarkupLine("You selected [cyan]Radom Mode[/]!");
            break;
    }
}



