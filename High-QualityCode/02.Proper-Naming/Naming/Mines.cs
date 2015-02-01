
namespace Minesweeper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Mines
    {
        public class Points
        {
            string name = string.Empty;
            int points = 0;

            public string Name
            {
                get { return this.name; }
                set { this.name = value; }
            }

            public int Point
            {
                get { return this.points; }
                set { this.points = value; }
            }

            public Points() { }

            public Points(string name, int points)
            {
                this.Name = name;
                this.Point = points;
            }
        }

        static void Main()
        {
            var command = string.Empty;
            char[,] field = RenderPlayground();
            char[,] bombs = SetBombs();
            int counter = 0;
            bool isExplosed = false;
            List<Points> champions = new List<Points>(6);
            int row = 0;
            int col = 0;
            bool isPlaying = true;
            const int MaxValue = 35;
            bool isWinner = false;

            do
            {
                if (isPlaying)
                {
                    Console.WriteLine("Let's play “Mines”. Try your luck to find the fields without mines." +
                    " Command 'top' shows classation, 'restart' starts a new game, 'exit' Exit.");
                    RenderBoard(field);
                    isPlaying = false;
                }
                Console.Write("Place row and col:");
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                    int.TryParse(command[2].ToString(), out col) &&
                        row <= field.GetLength(0) && col <= field.GetLength(1))
                    {
                        command = "turn";
                    }
                }
                switch (command)
                {
                    case "top":
                        CheckClassation(champions);
                        break;
                    case "restart":
                        field = RenderPlayground();
                        bombs = SetBombs();
                        RenderBoard(field);
                        isExplosed = false;
                        isPlaying = false;
                        break;
                    case "exit":
                        Console.WriteLine("Bye, bye!");
                        break;
                    case "turn":
                        if (bombs[row, col] != '*')
                        {
                            if (bombs[row, col] == '-')
                            {
                                PlayerTurn(field, bombs, row, col);
                                counter++;
                            }
                            if (MaxValue == counter)
                            {
                                isWinner = true;
                            }
                            else
                            {
                                RenderBoard(field);
                            }
                        }
                        else
                        {
                            isExplosed = true;
                        }
                        break;
                    default:
                        Console.WriteLine("\nError! Invalid command\n");
                        break;
                }
                if (isExplosed)
                {
                    RenderBoard(bombs);
                    Console.Write("\nHrrrrrr! You are dead with {0} points. " + "Enter your nickname: ", counter);
                    string nickname = Console.ReadLine();
                    Points t = new Points(nickname, counter);
                    if (champions.Count < 5)
                    {
                        champions.Add(t);
                    }
                    else
                    {
                        for (int i = 0; i < champions.Count; i++)
                        {
                            if (champions[i].Point < t.Point)
                            {
                                champions.Insert(i, t);
                                champions.RemoveAt(champions.Count - 1);
                                break;
                            }
                        }
                    }
                    champions.Sort((Points r1, Points r2) => r2.Name.CompareTo(r1.Name));
                    champions.Sort((Points r1, Points r2) => r2.Point.CompareTo(r1.Point));
                    CheckClassation(champions);

                    field = RenderPlayground();
                    bombs = SetBombs();
                    counter = 0;
                    isExplosed = false;
                    isPlaying = true;
                }
                if (isWinner)
                {
                    Console.WriteLine("\nLOOOOOOOOOL! You just open all 35 cells.");
                    RenderBoard(bombs);
                    Console.WriteLine("Enter your name here: ");
                    string imeee = Console.ReadLine();
                    Points to4kii = new Points(imeee, counter);
                    champions.Add(to4kii);
                    CheckClassation(champions);
                    field = RenderPlayground();
                    bombs = SetBombs();
                    counter = 0;
                    isWinner = false;
                    isPlaying = true;
                }
            }
            while (command != "exit");
            Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
            Console.Read();
        }

        private static void CheckClassation(List<Points> points)
        {
            Console.WriteLine("\nPoints:");
            if (points.Count > 0)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} boxes",
                        i + 1, points[i].Name, points[i].Point);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty Classation!\n");
            }
        }

        private static void PlayerTurn(char[,] field,
            char[,] bombs, int row, int col)
        {
            char kolkoBombi = CountSuccessfulMoves(bombs, row, col);
            bombs[row, col] = kolkoBombi;
            field[row, col] = kolkoBombi;
        }

        private static void RenderBoard(char[,] board)
        {
            int row = board.GetLength(0);
            int col = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < row; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < col; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }
                Console.Write("|");
                Console.WriteLine();
            }
            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] RenderPlayground()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] SetBombs()
        {
            int bombRow = 5;
            int bombCol = 10;
            char[,] playground = new char[bombRow, bombCol];

            for (int i = 0; i < bombRow; i++)
            {
                for (int j = 0; j < bombCol; j++)
                {
                    playground[i, j] = '-';
                }
            }

            List<int> r3 = new List<int>();
            while (r3.Count < 15)
            {
                Random random = new Random();
                int asfd = random.Next(50);
                if (!r3.Contains(asfd))
                {
                    r3.Add(asfd);
                }
            }

            foreach (int i2 in r3)
            {
                int col = (i2 / bombCol);
                int row = (i2 % bombCol);
                if (row == 0 && i2 != 0)
                {
                    col--;
                    row = bombCol;
                }
                else
                {
                    row++;
                }
                playground[col, row - 1] = '*';
            }

            return playground;
        }

        private static void Calculate(char[,] field)
        {
            int cols = field.GetLength(0);
            int rows = field.GetLength(1);

            for (int col = 0; col < cols; col++)
            {
                for (int row = 0; row < rows; row++)
                {
                    if (field[col, row] != '*')
                    {
                        char kolkoo = CountSuccessfulMoves(field, col, row);
                        field[col, row] = kolkoo;
                    }
                }
            }
        }

        private static char CountSuccessfulMoves(char[,] field, int row, int col)
        {
            int counter = 0;
            int rows = field.GetLength(0);
            int cols = field.GetLength(1);

            if (row - 1 >= 0)
            {
                if (field[row - 1, col] == '*')
                {
                    counter++;
                }
            }
            if (row + 1 < rows)
            {
                if (field[row + 1, col] == '*')
                {
                    counter++;
                }
            }
            if (col - 1 >= 0)
            {
                if (field[row, col - 1] == '*')
                {
                    counter++;
                }
            }
            if (col + 1 < cols)
            {
                if (field[row, col + 1] == '*')
                {
                    counter++;
                }
            }
            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (field[row - 1, col - 1] == '*')
                {
                    counter++;
                }
            }
            if ((row - 1 >= 0) && (col + 1 < cols))
            {
                if (field[row - 1, col + 1] == '*')
                {
                    counter++;
                }
            }
            if ((row + 1 < rows) && (col - 1 >= 0))
            {
                if (field[row + 1, col - 1] == '*')
                {
                    counter++;
                }
            }
            if ((row + 1 < rows) && (col + 1 < cols))
            {
                if (field[row + 1, col + 1] == '*')
                {
                    counter++;
                }
            }
            return char.Parse(counter.ToString());
        }
    }
}
