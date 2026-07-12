using Spectre.Console;

namespace MathGame;

public class UserInterface
{
    public static MenuOption ShowMenu()
    {
        Console.Clear();

        var choice = AnsiConsole.Prompt(
       new SelectionPrompt<MenuOption>()
       .Title("Slect a game mode:")
       .AddChoices(Enum.GetValues<MenuOption>()));

        return choice;
    }
}

public enum MenuOption
{
    Addition,
    Subtraction,
    Division,
    Multiplication,
    Random
};