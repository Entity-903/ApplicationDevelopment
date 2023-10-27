using System.Net.Security;

Board board = new Board();
bool game = true;
bool isTurnX = true;


Console.WriteLine("Hello and welcome, to Tic-Tac-Toe! At our company, we presume two things: " +
    "That everyone knows the rules to such a \nclassic game beforehand,  and that you have friends, " +
    "both of which are not included within this program. What you do \nneed to know is what each space is " +
    "represented by, as shown below:" +
    
    "\n\n 1 | 2 | 3" +
      "\n 4 | 5 | 6" +
      "\n 7 | 8 | 9 " +
        
        "\n\nTo place your mark, simply enter the number representing where you would like to go." +
        
        "\n\nLet us begin!" +
        
        "\n\n _ | _ | _" +
          "\n _ | _ | _" +
          "\n _ | _ | _" +
            
            "\n\nX: ");

while (game)
{
    string? userInput = null;
    try
    {
        userInput = Console.ReadLine();
        if (board.isValidPlacement(int.Parse(userInput) - 1))
        {
        board.PlaceMark(int.Parse(userInput) - 1, isTurnX);
        isTurnX = !isTurnX;
        }
        else
        {
            Console.WriteLine("Space already taken!");
        }
    }
    catch
    {
        Console.WriteLine("Invalid Value!");
    }

    board.Display();

    switch (board.CheckWinner())
    {
        //Game continues
        case 0:
            Console.WriteLine((isTurnX ? 'X' : 'O') + ": ");
            break;
        // X wins
        case 1:
            Console.WriteLine("Congratulations, X! You got three in a row!");
            game = false;
            break;
        // O wins
        case 2:
            Console.WriteLine("Congratulations, O! You got three in a row!");
            game = false;
            break;
        //Game ties
        case 3:
            Console.WriteLine("Its a Cat's Game! Both players were evenly matched!");
            game = false;
            break;
    }
}


public class Board
{
    private char[] ticTacToe = { '_', '_', '_', '_', '_', '_', '_', '_', '_' };

    public void Display()
    {
        for (int i = 0; i < 9; i++)
        {
            if (i == 0 || i == 3 || i == 6)
            {
                Console.Write(" " + ticTacToe[i] + " ");
            }
            else if (i == 1 || i == 4 || i == 7)
            {
                Console.Write(" | " + ticTacToe[i]);
            } 
            else
            {
                Console.WriteLine(" | " + ticTacToe[i]);
            }
        }
    }

    public void PlaceMark(int userSelection, bool isTurnX)
    {
        if (ticTacToe[userSelection] == '_')
        {
            if (isTurnX)
            {
                ticTacToe[userSelection] = 'X';
            }
            else
            {
                ticTacToe[userSelection] = 'O';
            }
        }
    }

    public bool isValidPlacement(int userSelection)
    {
        if (ticTacToe[userSelection] == '_')
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void ClearBoard()
    {
        for (int i = 0; i < 9; i++)
        {
            ticTacToe[i] = '_';
        }
    }
    public short CheckWinner()
    {
        // Check columns
        for (int i = 0; i < 3; i++) 
        { 
            if (ticTacToe[i] != '_')
            {
                if (ticTacToe[i] == ticTacToe[i + 3])
                {
                    if (ticTacToe[i] == ticTacToe[i + 6])
                    {
                        if (ticTacToe[i] == 'X')
                        {
                            return 1;
                        } 
                        else
                        { 
                            return 2; 
                        }

                    }
                }
            }
        }

        // Check rows
        for (int i = 0; i < 3; i+=3)
        {
            if (ticTacToe[i] != '_')
            {
                if (ticTacToe[i] == ticTacToe[i + 1])
                {
                    if (ticTacToe[i] == ticTacToe[i + 2])
                    {
                        if (ticTacToe[i] == 'X')
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        // Check diagonals
        
        if (ticTacToe[4] != '_')
        {
            if ((ticTacToe[4] == ticTacToe[0] && ticTacToe[4] == ticTacToe[8]) || (ticTacToe[4] == ticTacToe[2] && ticTacToe[4] == ticTacToe[6]))
            {
                if (ticTacToe[4] == 'X')
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        // Check for Tie
        short count = 0;
        for (int i = 0; i < 9; i++)
        {
            if (ticTacToe[i] != '_')
            {
                count++;
            }
        }

        if (count == 9) { return 3; }

        return 0;
    }
}

// Form the proper appearance of the board via the for loop 

//char test = '1';

//Console.WriteLine(test);

//ushort[] ticTacToe = new ushort[9];

//ticTacToe[0] = 12;

// WriteLine ends in a \n


/*  

1 | 2 | 3
4 | 5 | 6
7 | 8 | 9 

_ | _ | _
_ | _ | _
_ | _ | _ 

X: 5

_ | _ | _
_ | X | _
_ | _ | _ 

O: 1

O | _ | _
_ | X | _
_ | _ | _ 

X: 9

O | _ | _
_ | X | _
_ | _ | X 

*/