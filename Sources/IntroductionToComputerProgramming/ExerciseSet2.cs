namespace IntroductionToComputerProgramming
{
    internal class ExerciseSet2
    {
        static void Exercise1()
        {
            int[] numbers = new int[10];

            for (int i = 0; i < 10; i++)
                numbers[i] = int.Parse(Console.ReadLine());

            for (int i = 9; i >= 0; i--)
                Console.WriteLine(numbers[i]);
        }

        static void Exercise2()
        {
            int[] numbers = new int[10];

            for (int i = 0; i < 10; i++)
                numbers[i] = int.Parse(Console.ReadLine());

            for (int i = 0; i < 10; i++)
                if (numbers[i] % 2 == 0)
                    Console.WriteLine(numbers[i]);
        }

        static void Exercise3()
        {
            int[] numbers = new int[10];

            for (int i = 0; i < 10; i++)
                numbers[i] = int.Parse(Console.ReadLine());

            for (int i = 0; i < 10; i += 2)
                Console.WriteLine(numbers[i]);
        }

        static void Exercise4()
        {
            string[] names = new string[10];

            for (int i = 0; i < 10; i++)
                names[i] = Console.ReadLine();

            Console.Write("Welcome:");
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write($" {names[i]} {i + 1}");

                if (i != names.Length - 1) Console.Write(",");
                else Console.Write(".");
            }
        }

        static void Exercise5()
        {
            float[] numbers = new float[10];

            for (int i = 0; i < 10; i++)
                numbers[i] = float.Parse(Console.ReadLine());

            Console.Write(numbers.Average());
        }
        static void Exercise6()
        {
            int[] numbers = new int[10];

            for (int i = 0; i < 10; i++)
                numbers[i] = int.Parse(Console.ReadLine());

            Console.Write(numbers.Average());
        }

        static void Exercise7()
        {
            List<float> list = new List<float>();
            string input;

            do
            {
                input = Console.ReadLine();
                float number;

                if (float.TryParse(input, out number))
                    list.Add(number);
            } while (input != "STOP");

            Console.Write(list.Average());
        }

        static void Exercise8()
        {
            List<float> list = new List<float>();
            string input;

            do
            {
                input = Console.ReadLine();
                float number;

                if (float.TryParse(input, out number))
                    list.Add(number);
            } while (input != "STOP");

            Console.Write(list.Average());
        }

        static void Exercise9()
        {
            List<float> list = new List<float>();
            string input;

            do
            {
                input = Console.ReadLine();
                float number;

                if (float.TryParse(input, out number))
                    if (number > 0) list.Add(number);
            } while (float.Parse(input) > 0);

            Console.Write(list.Average());
        }

        static void Exercise10()
        {
            static void PrintBoard(char[,] board)
            {
                for (int x = 0; x < board.GetLength(0); x++)
                {
                    for (int y = 0; y < board.GetLength(1); y++)
                        Console.Write($"{board[x, y]} ");

                    Console.WriteLine();
                }
            }

            static void InsertIntoBoard(char[,] board, int position, char symbol)
            {
                board[position / board.GetLength(0), position % board.GetLength(0)] = symbol;
            }

            static bool IsBoardFull(char[,] board)
            {
                int numOfElements = 0;

                for (int x = 0; x < board.GetLength(0); x++)
                {
                    for (int y = 0; y < board.GetLength(1); y++)
                        if (board[x, y] != 0) numOfElements++;
                }

                return numOfElements == board.Length ? true : false;
            }

            char playerSymbol = 'O';
            char[,] board = new char[3, 3];

            while (!IsBoardFull(board))
            {
                int position = int.Parse(Console.ReadLine());

                InsertIntoBoard(board, position, playerSymbol);
                PrintBoard(board);

                playerSymbol = playerSymbol == 'O' ? 'X' : 'O';
            }
        }

        static void Exercise11()
        {
            static void PrintBoard(char[,] board)
            {
                for (int x = 0; x < board.GetLength(0); x++)
                {
                    for (int y = 0; y < board.GetLength(1); y++)
                        Console.Write($"{board[x, y]} ");

                    Console.WriteLine();
                }
            }

            static void InsertIntoBoard(char[,] board, int position, char symbol)
            {
                board[position / board.GetLength(0), position % board.GetLength(0)] = symbol;
            }

            static bool IsBoardFull(char[,] board)
            {
                int numOfElements = 0;

                for (int x = 0; x < board.GetLength(0); x++)
                {
                    for (int y = 0; y < board.GetLength(1); y++)
                        if (board[x, y] != 0) numOfElements++;
                }

                return numOfElements == board.Length ? true : false;
            }

            static bool IsPositionTaken(char[,] board, int position)
            {
                return board[position / board.GetLength(0), position % board.GetLength(0)] != 0;
            }

            char playerSymbol = 'O';
            char[,] board = new char[3, 3];

            while (!IsBoardFull(board))
            {
                int position = int.Parse(Console.ReadLine());

                if (!IsPositionTaken(board, position))
                {
                    InsertIntoBoard(board, position, playerSymbol);
                    PrintBoard(board);
                    playerSymbol = playerSymbol == 'O' ? 'X' : 'O';
                }
                else Console.WriteLine("This position is taken. Please choose another one.");
            }
        }

        static void WriteInColor(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        static int GetPositionFromCoordinates((int p, int q) coordinates)
        {
            return coordinates.p * 3 + coordinates.q;
        }

        public struct Coordinates
        {
            public int p;
            public int q;

            public Coordinates(int p, int q)
            {
                this.p = p;
                this.q = q;
            }
        }

        class Board
        {
            // Board structure ([p, q]):
            // [0, 0] [0, 1] [0, 2]
            // [1, 0] [1, 1] [1, 2]
            // [2, 0] [2, 1] [2, 2]

            // Board position structure (position number):
            // 0 1 2
            // 3 4 5
            // 6 7 8

            public char[,] board = new char[3, 3];

            public bool IsFull()
            {
                int numOfElements = 0;

                for (int p = 0; p < board.GetLength(0); p++)
                {
                    for (int q = 0; q < board.GetLength(1); q++)
                        if (board[p, q] != 0) numOfElements++;
                }

                return numOfElements == board.Length;
            }

            public void Print()
            {
                Console.WriteLine();

                for (int p = 0; p < board.GetLength(0); p++)
                {
                    for (int q = 0; q < board.GetLength(1); q++)
                        if (board[p, q] == 0)
                            WriteInColor($"{GetPositionFromCoordinates((p, q)) + 1} ", ConsoleColor.DarkGray);
                        else
                            Console.Write($"{board[p, q]} ");

                    Console.WriteLine();
                }

                Console.WriteLine();
            }

            public Coordinates GetCoordinatesFromPosition(int position)
            {
                Coordinates coordinates = new Coordinates(position / board.GetLength(0), position % board.GetLength(1));
                return coordinates;
            }

            public void InsertInto(int position, char symbol)
            {
                Coordinates coordinates = GetCoordinatesFromPosition(position);
                board[coordinates.p, coordinates.q] = symbol;
            }

            public char GetPlayerSymbolFromPosition(int position)
            {
                Coordinates coordinates = GetCoordinatesFromPosition(position);
                return board[coordinates.p, coordinates.q];
            }

            public bool IsPositionTaken(int position)
            {
                return GetPlayerSymbolFromPosition(position) != '\0';
            }

            public char GetWinner()
            {
                bool IsPlayerSymbolInCombinationSame((int, int, int) combination)
                {
                    char playerSymbolInFirstPosition = GetPlayerSymbolFromPosition(combination.Item1);

                    return playerSymbolInFirstPosition == GetPlayerSymbolFromPosition(combination.Item2)
                            && playerSymbolInFirstPosition == GetPlayerSymbolFromPosition(combination.Item3);
                }

                (int, int, int)[] winningCombinations = new[] {
                    // Rows.
                    (0, 1, 2), (3, 4, 5), (6, 7, 8),

                    // Columns.
                    (0, 3, 6), (1, 4, 7), (2, 5, 8),

                    // Diagonals.
                    (0, 4, 8), (2, 4, 6)
                };

                foreach (var winningCombination in winningCombinations)
                {
                    if (IsPlayerSymbolInCombinationSame(winningCombination))
                        return GetPlayerSymbolFromPosition(winningCombination.Item1);
                }

                return '\0';
            }
        }

        static void Exercise12()
        {
            Board board = new Board();
            char playerSymbol = 'O';

            board.Print();

            while (!board.IsFull())
            {
                int position;
                do
                {
                    Console.Write($"Please enter position in the range <1, 9> for "); WriteInColor($"{playerSymbol}", ConsoleColor.Cyan); Console.Write(": ");
                } while (!int.TryParse(Console.ReadLine(), out position) || position < 1 || position > 9);

                // The program actually counts positions from in the range <0; 8>.
                position -= 1;

                if (!board.IsPositionTaken(position))
                {
                    board.InsertInto(position, playerSymbol);
                    board.Print();

                    char winner = board.GetWinner();
                    if (winner != '\0')
                    {
                        WriteInColor($"The winner is {winner}! Thank you for playing!", ConsoleColor.DarkYellow);
                        Console.ReadKey();
                        Environment.Exit(0);
                    }

                    playerSymbol = playerSymbol == 'O' ? 'X' : 'O';
                }
                else WriteInColor("This position is taken. Please choose another one.\n\n", ConsoleColor.Red);
            }

            WriteInColor($"The result is a draw. Thank you for playing!", ConsoleColor.DarkYellow);
        }

        static void Exercise13()
        {
            bool IsPowerTwoRecursive(int number)
            {
                if (number == 1) return true;
                else if (number % 2 == 1) return false;

                return IsPowerTwoRecursive(number / 2);
            }

            bool IsPowerTwo(int number)
            {
                while (number % 2 == 0)
                    number /= 2;

                if (number == 1)
                    return true;

                return false;
            }

            int input = int.Parse(Console.ReadLine());
            string message = IsPowerTwo(input) ? "YES" : "NO";
            Console.WriteLine(message);
        }

        static void Exercise14()
        {
            int[] numbers = new int[10];

            for (int i = 0; i < 10; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 0) return;
                numbers[i] = number;
            }

            Console.WriteLine("SUKCES");
        }

        static void Exercise15()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write($"{i} * {j} = ");
                    int input = int.Parse(Console.ReadLine());

                    if (input != i * j)
                        Console.WriteLine("Try again.");
                }
            }

            Console.WriteLine("Success!");
        }

        static void Exercise16()
        {
            bool isInputCorrect = true;

            do
            {
                for (int i = 1; i <= 10; i++)
                {
                    for (int j = 1; j <= 10; j++)
                    {
                        Console.Write($"{i} * {j} = ");

                        int input = int.Parse(Console.ReadLine());
                        isInputCorrect = input == i * j;

                        if (!isInputCorrect)
                        {
                            Console.WriteLine("Try again.");
                            break;
                        }

                    }

                    if (!isInputCorrect) break;
                }
            } while (!isInputCorrect);

            Console.WriteLine("Success!");
        }
    }
}
