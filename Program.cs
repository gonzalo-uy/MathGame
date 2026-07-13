using Spectre.Console;
using MathGame;
using System.Runtime.CompilerServices;


while (true)
{

    MenuOption choice = UserInterface.ShowMenu();
    var (numberA, numberB) = Randomize.GenerateNumbers();

    switch (choice)
    {
        case MenuOption.Addition:

            AnsiConsole.MarkupLine("You selected [cyan]Addition[/]!");
            GameRound.Play("+", numberA, numberB, Addition.AddNumber(numberA, numberB));

            break;

        case MenuOption.Subtraction:

            AnsiConsole.MarkupLine("You selected [cyan]Subtraction[/]!");
            GameRound.Play("-", numberA, numberB, Subtraction.SubtracNumber(numberA, numberB));

            break;

        case MenuOption.Division:

            AnsiConsole.MarkupLine("You selected [cyan]Division[/]!");
            var (dividend, divisor) = Randomize.GenerateDivisionNumbers();
            GameRound.Play("/", dividend, divisor, Division.DivNum(dividend, divisor));

            break;
        case MenuOption.Multiplication:

            AnsiConsole.MarkupLine("You selected [cyan]Multiplication[/]!");
            GameRound.Play("*", numberA, numberB, Multiplication.MultiplicationNumber(numberA, numberB));

            break;

        case MenuOption.Random:

            AnsiConsole.MarkupLine("You selected [cyan]Radom Mode[/]!");

            Random rMode = new Random();
            int randomChoise = rMode.Next(0, 4);
            switch (randomChoise)
            {
                case 0:

                    AnsiConsole.MarkupLine("You selected [cyan]Addition[/]!");
                    GameRound.Play("+", numberA, numberB, Addition.AddNumber(numberA, numberB));

                    break;

                case 1:

                    AnsiConsole.MarkupLine("You selected [cyan]Subtraction[/]!");
                    GameRound.Play("-", numberA, numberB, Subtraction.SubtracNumber(numberA, numberB));

                    break;

                case 2:

                    AnsiConsole.MarkupLine("You selected [cyan]Division[/]!");
                    var (randDividend, randDivisor) = Randomize.GenerateDivisionNumbers();
                    GameRound.Play("/", randDividend, randDivisor, Division.DivNum(randDividend, randDivisor));

                    break;

                case 3:

                    AnsiConsole.MarkupLine("You selected [cyan]Multiplication[/]!");
                    GameRound.Play("*", numberA, numberB, Multiplication.MultiplicationNumber(numberA, numberB));

                    break;


            }
            break;
    }
}



