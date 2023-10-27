// See https://aka.ms/new-console-template for more information
using TheCoolestMazeRunner;


Game game = new Game();
char[,] currentMap = game.GetMap();

    Console.WriteLine("Hello Adventurer! What is your name?");
    string? name = Console.ReadLine();
    Console.WriteLine("Welcome " + name + "! Get the treasure and escape!");
    game.DisplayGame();

// The Game Begins
while (game.GetGameStatus())
{
        ConsoleKeyInfo key = Console.ReadKey();
        switch (key.Key)
        {
            case ConsoleKey.UpArrow:
                if (currentMap[game.GetPlayerLocation()[0] - 1, game.GetPlayerLocation()[1]] == 'E')
            {
                game.winner = true;
                game.gameActive = false;
                break;
            }
                if (currentMap[game.GetPlayerLocation()[0] - 1, game.GetPlayerLocation()[1]] == '$')
            {
                game.hasTreasure = true;
                game.CreateExit();
            }
                if (currentMap[game.GetPlayerLocation()[0] - 1, game.GetPlayerLocation()[1]] == 'X')
                {
                    game.UpdateToEmpty(game.GetPlayerLocation());
                    game.SetPlayerLocation(game.GetPlayerLocation()[0] - 1, game.GetPlayerLocation()[1]);
                    game.gameActive = false;
                    break;
                } 
                else if (currentMap[game.GetPlayerLocation()[0] - 1, game.GetPlayerLocation()[1]] != '-' && currentMap[game.GetPlayerLocation()[0] - 1, game.GetPlayerLocation()[1]] != '|')
                {
                    game.UpdateToEmpty(game.GetPlayerLocation());
                    game.SetPlayerLocation(game.GetPlayerLocation()[0] - 1, game.GetPlayerLocation()[1]);
                }
                break;
            case ConsoleKey.DownArrow:
            if (currentMap[game.GetPlayerLocation()[0] + 1, game.GetPlayerLocation()[1]] == 'E')
            {
                game.winner = true;
                game.gameActive = false;
                break;
            }
                if (currentMap[game.GetPlayerLocation()[0] + 1, game.GetPlayerLocation()[1]] == '$')
            {
                game.hasTreasure = true;
                game.CreateExit();
            }
                if (currentMap[game.GetPlayerLocation()[0] + 1, game.GetPlayerLocation()[1]] == 'X')
                {
                    game.UpdateToEmpty(game.GetPlayerLocation());
                    game.SetPlayerLocation(game.GetPlayerLocation()[0] + 1, game.GetPlayerLocation()[1]);
                    game.gameActive = false;
                    break;
                } 
                else if (currentMap[game.GetPlayerLocation()[0] + 1, game.GetPlayerLocation()[1]] != '-' && currentMap[game.GetPlayerLocation()[0] + 1, game.GetPlayerLocation()[1]] != '|')
                {
                    game.UpdateToEmpty(game.GetPlayerLocation());
                    game.SetPlayerLocation(game.GetPlayerLocation()[0] + 1, game.GetPlayerLocation()[1]);
                }
                break;
            case ConsoleKey.LeftArrow:
            if (currentMap[game.GetPlayerLocation()[0], game.GetPlayerLocation()[1] - 1] == 'E')
            {
                game.winner = true;
                game.gameActive = false;
                break;
            }
                if (currentMap[game.GetPlayerLocation()[0], game.GetPlayerLocation()[1] - 1] == '$')
            {
                game.hasTreasure = true;
                game.CreateExit();
            }
                if (currentMap[game.GetPlayerLocation()[0], game.GetPlayerLocation()[1] - 1] == 'X')
                {
                    game.UpdateToEmpty(game.GetPlayerLocation());
                    game.SetPlayerLocation(game.GetPlayerLocation()[0], game.GetPlayerLocation()[1] - 1);
                    game.gameActive = false;
                    break;
            } 
            else if (currentMap[game.GetPlayerLocation()[0], game.GetPlayerLocation()[1] - 1] != '-' && currentMap[game.GetPlayerLocation()[0], game.GetPlayerLocation()[1] - 1] != '|')
                {
                    game.UpdateToEmpty(game.GetPlayerLocation());
                    game.SetPlayerLocation(game.GetPlayerLocation()[0], game.GetPlayerLocation()[1] - 1);
                }
                break;
            case ConsoleKey.RightArrow:
            if (currentMap[game.GetPlayerLocation()[0], game.GetPlayerLocation()[1] + 1] == 'E')
            {
                game.winner = true;
                game.gameActive = false;
                break;
            }
                if (currentMap[game.GetPlayerLocation()[0], game.GetPlayerLocation()[1] + 1] == '$')
            {
                game.hasTreasure = true;
                game.CreateExit();
            }
                if (currentMap[game.GetPlayerLocation()[0], game.GetPlayerLocation()[1] + 1] == 'X')
                {
                    game.UpdateToEmpty(game.GetPlayerLocation());
                    game.SetPlayerLocation(game.GetPlayerLocation()[0], game.GetPlayerLocation()[1] + 1);
                    game.gameActive = false;
                    break;
            } 
            else if (currentMap[game.GetPlayerLocation()[0], game.GetPlayerLocation()[1] + 1] != '-' && currentMap[game.GetPlayerLocation()[0], game.GetPlayerLocation()[1] + 1] != '|')
                {
                    game.UpdateToEmpty(game.GetPlayerLocation());
                    game.SetPlayerLocation(game.GetPlayerLocation()[0], game.GetPlayerLocation()[1] + 1);
                }
                break;
        }

    // Enemy Movement
    int value = new Random().Next(1, 5);
    switch (value)
    {
        case 1:
            // Move Up
            if (currentMap[game.GetEnemyLocation()[0] - 1, game.GetEnemyLocation()[1]] != '-' && 
                currentMap[game.GetEnemyLocation()[0] - 1, game.GetEnemyLocation()[1]] != '|' && 
                currentMap[game.GetEnemyLocation()[0] - 1, game.GetEnemyLocation()[1]] != '$' && 
                currentMap[game.GetEnemyLocation()[0] - 1, game.GetEnemyLocation()[1]] != 'E')
            {
                game.UpdateToEmpty(game.GetEnemyLocation());
                game.SetEnemyLocation(game.GetEnemyLocation()[0] - 1, game.GetEnemyLocation()[1]);
            }
                break;
        case 2:
            //Move Down
            if (currentMap[game.GetEnemyLocation()[0] + 1, game.GetEnemyLocation()[1]] != '-' &&
                currentMap[game.GetEnemyLocation()[0] + 1, game.GetEnemyLocation()[1]] != '|' &&
                currentMap[game.GetEnemyLocation()[0] + 1, game.GetEnemyLocation()[1]] != '$' &&
                currentMap[game.GetEnemyLocation()[0] + 1, game.GetEnemyLocation()[1]] != 'E')
            {
                game.UpdateToEmpty(game.GetEnemyLocation());
                game.SetEnemyLocation(game.GetEnemyLocation()[0] + 1, game.GetEnemyLocation()[1]);
            }
            break;
        case 3:
            //Move Left
            if (currentMap[game.GetEnemyLocation()[0], game.GetEnemyLocation()[1] - 1] != '-' &&
                currentMap[game.GetEnemyLocation()[0], game.GetEnemyLocation()[1] - 1] != '|' &&
                currentMap[game.GetEnemyLocation()[0], game.GetEnemyLocation()[1] - 1] != '$' &&
                currentMap[game.GetEnemyLocation()[0], game.GetEnemyLocation()[1] - 1] != 'E')
            {
                game.UpdateToEmpty(game.GetEnemyLocation());
                game.SetEnemyLocation(game.GetEnemyLocation()[0], game.GetEnemyLocation()[1] - 1);
            }
            break;
        case 4:
            //Move Right
            if (currentMap[game.GetEnemyLocation()[0], game.GetEnemyLocation()[1] + 1] != '-' &&
                currentMap[game.GetEnemyLocation()[0], game.GetEnemyLocation()[1] + 1] != '|' &&
                currentMap[game.GetEnemyLocation()[0], game.GetEnemyLocation()[1] + 1] != '$' &&
                currentMap[game.GetEnemyLocation()[0], game.GetEnemyLocation()[1] + 1] != 'E')
            {
                game.UpdateToEmpty(game.GetEnemyLocation());
                game.SetEnemyLocation(game.GetEnemyLocation()[0], game.GetEnemyLocation()[1] + 1);
            }
            break;
    }



        game.SetMap(game.GetPlayerLocation(), game.GetEnemyLocation());
        game.UpdateTreasure(game.treasureLocation);
        game.DisplayGame();

    if (!game.gameActive && game.winner)
    {
        Console.WriteLine("Congradulations! You have succeeded!");
    } else if (!game.gameActive && !game.winner)
    {
        Console.WriteLine("You have perished!");
    }

}

/*

- - - - - - - - - - - - -
| $ |       +       |   |
|   +   -   |   -   +   |
|   | E     +       |   |
|   +   -   |   -   +   |
|   |       +       |   |
|   +   -   |   -   +   |
|   |       +       |   |
|   +   -   |   -   +   |
|   |       +       |   |
|   +   -   |   -   +   |
|   |       +       | P |
- - - - - - - - - - - - -

Upon switch:

- - - - - - - - - - - - -
| $ +       |       +   |
|   |   -   +   -   |   |
|   + E     |       +   |
|   |   -   +   -   |   |
|   +       |       +   |
|   |   -   +   -   |   |
|   +       |       +   |
|   |   -   +   -   |   |
|   +       |       +   |
|   |   -   +   -   |   |
|   +       |       + P |
- - - - - - - - - - - - - 
Player: P
Exit: E
Enemy: X
Potential Wall: +
Treasure: $

Player on Wall: ⓟ
Enemy on Wall: ⓧ

Basic Board:
- - - - - - - - - - - - -
| $         |           |
|   |   -       -   |   |
|     X     |           |
|   |   -       -   |   |
|           |           |
|   |   -       -   |   |
|           |           |
|   |   -       -   |   |
|           |           |
|   |   -       -   |   |
|           |         P |
- - - - - - - - - - - - - 


*/