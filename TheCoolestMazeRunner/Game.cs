using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCoolestMazeRunner
{
    internal class Game
    {
        char[,] map =
            {
            { '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-' },
            { '|', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', '|' },
            { '|', ' ', '|', ' ', '-', ' ', ' ', ' ', '-', ' ', '|', ' ', '|' },
            { '|', ' ', ' ', 'X', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', '|' },
            { '|', ' ', '|', ' ', '-', ' ', ' ', ' ', '-', ' ', '|', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', '|' },
            { '|', ' ', '|', ' ', '-', ' ', ' ', ' ', '-', ' ', '|', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', '|' },
            { '|', ' ', '|', ' ', '-', ' ', ' ', ' ', '-', ' ', '|', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', '|' },
            { '|', ' ', '|', ' ', '-', ' ', ' ', ' ', '-', ' ', '|', ' ', '|' },
            { '|', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', 'P', '|' },
            { '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-' }
            };
        public bool gameActive = true;
        public bool winner = false;
        public bool isPlayerTurn = true;
        public bool hasTreasure = false;
        public int[]? playerLocation = { 11, 11 };
        public int[]? enemyLocation = { 3, 3 };
        public int[]? treasureLocation = { 1, 1 };
        public int[]? exitLocation;

        public char[,] GetMap()
        {
            return map;
        }

        public void DisplayGame()
        {
            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    if (j == 12)
                    {
                        Console.WriteLine(map[i, j]);
                    }
                    else
                    {
                        Console.Write(map[i, j] + " ");
                    }
                }
            }
        }

        public void SetMap(int[] playerLocation, int[] enemyLocation)
        {
            map[playerLocation[0], playerLocation[1]] = 'P';
            map[enemyLocation[0], enemyLocation[1]] = 'X';
        }

        public bool GetGameStatus()
        {
            return gameActive;
        }

        public bool IsPlayerTurn()
        {
            return isPlayerTurn;
        }

        public int[] GetPlayerLocation()
        {
            return playerLocation;
        }

        public void SetPlayerLocation(int row, int column)
        {
            playerLocation = new int[] { row, column };
        }

        public int[] GetEnemyLocation()
        {
            return enemyLocation;
        }

        public void SetEnemyLocation( int row, int column)
        {
            enemyLocation = new int[] { row, column };
        }

        public void UpdatePlayerSymbol(int[] playerLocation)
        {
            map[playerLocation[0], playerLocation[1]] = 'P';
        }

        public void UpdateEnemySymbol(int[] enemyLocation)
        {
            map[enemyLocation[0], enemyLocation[1]] = 'X';
        }

        public void UpdateTreasure(int[] treasureLocation)
        {
            if (!hasTreasure)
            {
                map[treasureLocation[0], treasureLocation[1]] = '$';
            }
        }

        public void UpdateExitSymbol()
        {
            map[exitLocation[0], exitLocation[1]] = 'E';
        }

        public void UpdateToEmpty(int[] emptyCell)
        {
            map[emptyCell[0], emptyCell[1]] = ' ';
        }

        public void CreateExit()
        {
            int row = new Random().Next(1, 12);
            int value = new Random().Next(1, 12);
            int column = 0;
            switch (value)
            {
                case 1:
                    column = 1;
                    break;
                case 2:
                case 3:
                    column = 3;
                    break;
                case 4:
                case 5:
                    column = 5;
                    break;
                case 6:
                case 7:
                    column = 7;
                    break;
                case 8:
                case 9:
                    column = 9;
                    break;
                case 10:
                case 11:
                    column = 11;
                    break;
            }

            exitLocation = new int[] { row, column };
            UpdateExitSymbol();
        }
    }
}
