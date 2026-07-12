using Spectre.Console;

//Math operations menu
while (true)
{
    Console.Clear();
    var choice = AnsiConsole.Prompt(
        new SelectionPrompt<MenuOption>()
        .Title("Slect a game mode:")
        .AddChoices(Enum.GetValues<MenuOption>()));
    
     var choiceLevel = AnsiConsole.Prompt(
         new SelectionPrompt<LevelOption>()
        .Title("Slect a level mode:")
        .AddChoices(Enum.GetValues<LevelOption>()));

    switch (choice)
    {
        case MenuOption.Adition:
            break;
        case MenuOption.Subtraction:
            break;
        case MenuOption.Division:
            break;
        case MenuOption.Multiplication:
            break;
        case MenuOption:
            break;
    }
}

//Level Menu

   

enum MenuOption { Adition, Subtraction, Division, Multiplication, Random };
enum LevelOption {Easy, Normal, Hard};
