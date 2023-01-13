namespace IntroductionToComputerProgramming
{
    public class ExerciseSet3
    {
        static void Exercise1()
        {
            int evenCount = 0;
            Random rnd = new Random();

            for (int i = 0; i < 1000; i++)
            {
                int randomNumber = rnd.Next();

                if (randomNumber % 2 == 0)
                    evenCount += 1;
            }

            Console.WriteLine(evenCount);
        }

        static void Exercise2()
        {
            // factorial is also a result.
            int factorial = int.Parse(Console.ReadLine());

            for (int i = factorial; i > 2; i--)
            {
                factorial *= i - 1;
            }

            Console.WriteLine(factorial);
        }

        static void Exercise3()
        {
            float a = Helper.GetInput<float>("a = ");
            float b = Helper.GetInput<float>("b = ");

            Console.WriteLine(Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)));
        }

        static void Exercise4()
        {
            int SecondsToHours(int seconds)
            {
                return seconds / 60 / 60;
            }
            int SecondsToMinutes(int seconds)
            {
                return seconds / 60;
            }
            int HoursToSeconds(int hours)
            {
                return hours * 60 * 60;
            }
            int MinutesToSeconds(int minutes)
            {
                return minutes * 60;
            }

            int firstTimeInSeconds = Helper.GetInput<int>("First time: ");
            int secondTimeInSeconds = Helper.GetInput<int>("Second time: ");

            int firstTimeHours = SecondsToHours(firstTimeInSeconds);
            int secondTimeHours = SecondsToHours(secondTimeInSeconds);

            int firstTimeMinutes = SecondsToMinutes(firstTimeInSeconds - HoursToSeconds(firstTimeHours));
            int secondTimeMinutes = SecondsToMinutes(secondTimeInSeconds - HoursToSeconds(secondTimeHours));

            int firstTimeSeconds = firstTimeInSeconds - HoursToSeconds(firstTimeHours) - MinutesToSeconds(firstTimeMinutes);
            int secondTimeSeconds = secondTimeInSeconds - HoursToSeconds(secondTimeHours) - MinutesToSeconds(secondTimeMinutes);

            string output = firstTimeInSeconds < secondTimeInSeconds ?
                $"{firstTimeHours}:{firstTimeMinutes}:{firstTimeSeconds} - {secondTimeHours}:{secondTimeMinutes}:{secondTimeSeconds}" :
                $"{secondTimeHours}:{secondTimeMinutes}:{secondTimeSeconds} - {firstTimeHours}:{firstTimeMinutes}:{firstTimeSeconds}";

            Console.WriteLine(output);
        }

        // Exercise5

        static double DegreesToRadians(double degrees)
        {
            return degrees * Math.PI / 180;
        }

        public static void Exercise5()
        {
            double GetSideHeightTriangleArea(double sideLength, double height)
            {
                // Returns area of the triangle calculating it by using it's height.

                return sideLength * height / 2;
            }

            double GetAreaOfTriangle(double a = 0, double b = 0, double c = 0, double alpha = 0, double beta = 0, double gamma = 0, double r = 0, double R = 0)
            {
                // Calculate area of triangle using various equations.

                //// First equation.
                if (alpha == 45 && beta == 45 && gamma == 90)
                {
                    // Handle right triangle.

                    double height = a;
                    if (b != 0) return GetSideHeightTriangleArea(b, height);
                    if (c != 0) return GetSideHeightTriangleArea(c, height);
                }

                //// Second equation.
                if (a != 0 && b != 0 && gamma != 0)
                    return 0.5 * a * b * Math.Sin(gamma);
                if (a != 0 && c != 0 && beta != 0)
                    return 0.5 * a * c * Math.Sin(beta);
                if (b != 0 && c != 0 && alpha != 0)
                    return 0.5 * b * c * Math.Sin(alpha);

                // Third equation.
                if (a != 0 && beta != 0 && gamma != 0 && alpha != 0)
                    return 0.5 * Math.Pow(a, 2) * (Math.Sin(beta) * Math.Sin(gamma) / Math.Sin(alpha));
                if (b != 0 && alpha != 0 && gamma != 0 && beta != 0)
                    return 0.5 * Math.Pow(b, 2) * (Math.Sin(alpha) * Math.Sin(gamma) / Math.Sin(beta));
                if (c != 0 && alpha != 0 && beta != 0 && gamma != 0)
                    return 0.5 * Math.Pow(c, 2) * (Math.Sin(alpha) * Math.Sin(beta) / Math.Sin(gamma));

                // Fourth equation.
                if (a != 0 && b != 0 && c != 0 && R != 0)
                    return a * b * c / (4 * R);

                //// Fifth equation.
                if (a != 0 && b != 0 && c != 0 && r != 0)
                {
                    double p = (a + b + c) / 2;
                    return r * p;
                }

                // Sixth equation.
                if (R != 0 && alpha != 0 && beta != 0 && gamma != 0)
                    return 2 * Math.Pow(R, 2) * Math.Sin(alpha) * Math.Sin(beta) * Math.Sin(gamma);

                // Seventh equation.
                if (a != 0 && b != 0 && c != 0)
                {
                    double p = (a + b + c) / 2;
                    return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                }

                return 0;
            }

            // Test equilateral triangle. Area: ~1.73
            //double a = 2;
            //double b = 2;
            //double c = 2;
            //double alpha = DegreesToRadians(60);
            //double gamma = DegreesToRadians(60);
            //double beta = DegreesToRadians(60);
            //double r = 2 * Math.Sqrt(3) / 6;
            //double R = 4 * Math.Sqrt(3) / 6;

            Console.WriteLine("Enter 0 if you don't have enough information.");

            double a = Helper.GetInput<double>("a = ");
            double b = Helper.GetInput<double>("b = ");
            double c = Helper.GetInput<double>("c = ");
            double alpha = DegreesToRadians(Helper.GetInput<double>("alpha = "));
            double beta = DegreesToRadians(Helper.GetInput<double>("beta = "));
            double gamma = DegreesToRadians(Helper.GetInput<double>("gamma = "));
            double r = Helper.GetInput<double>("r = ");
            double R = Helper.GetInput<double>("R = ");

            double areaOfTriangle = GetAreaOfTriangle(a, b, c, alpha, beta, gamma, r, R);

            if (areaOfTriangle == 0)
            {
                Console.WriteLine("Insufficient information to calculate area of the triangle.");
                return;
            }

            Console.WriteLine($"Area: {areaOfTriangle}");
        }

        // Exercise6

        enum QuadrilateralType
        {
            INVALID,
            SQUARE,
            RECTANGLE,
            RHOMBUS,
            PARALLELOGRAM,
            TRAPEZOID,
            KITE,
            QUADRANGLE
        }

        struct Quadrilateral
        {
            double a, b, c, d, alpha, beta, gamma, delta;

            public Quadrilateral(double a, double b, double c, double d, double alpha, double beta, double gamma, double delta)
            {
                this.a = a;
                this.b = b;
                this.c = c;
                this.d = d;
                this.alpha = alpha;
                this.beta = beta;
                this.gamma = gamma;
                this.delta = delta;
            }

            public double GetAreaOfSquare() { return this.a * this.a; }
            public double GetAreaOfRectangle() { return this.a * this.b; }
            public double GetAreaOfRhombus() { return this.a * this.a * Math.Sin(this.alpha); }
            public double GetAreaOfParallelogram() { return this.a * this.b * Math.Sin(this.gamma); }
            // https://math.stackexchange.com/questions/2019434/area-of-a-trapezoid-without-the-height
            //double GetAreaOfTrapezoid() { }
            //double GetAreaOfKite() { return this.a * this.b * Math.Sin(this.alpha); }
            public double GetAreaOfQuadrilateral()
            {
                return 0.5 * this.a * this.d * Math.Sin(this.alpha) + 0.5 * this.b * this.c * Math.Sin(this.gamma);
            }
        }

        struct QuadrilateralTypeArea
        {
            public QuadrilateralTypes type;
            public double area;

            public QuadrilateralTypeArea(QuadrilateralTypes type, double area)
            {
                this.type = type;
                this.area = area;
            }
        }

        public enum QuadrilateralTypes

        {
            SQUARE,
            RECTANGLE,
            RHOMBUS,
            PARALLELOGRAM,
            TRAPEZOID,
            QUADRANGLE,
            INVALID
        }

        public static void Exercise6()
        {
            QuadrilateralTypeArea GetQuadrilateralTypeAndArea(double a, double b, double c, double d, double alpha, double beta, double gamma, double delta)
            {
                Quadrilateral quadrilateral = new Quadrilateral(a, b, c, d, alpha, beta, gamma, delta);

                switch (Type(a, b, c, d, alpha, beta, gamma, delta))
                {
                    case QuadrilateralTypes.SQUARE:
                        {
                            QuadrilateralTypeArea quadrilateralTypeArea = new QuadrilateralTypeArea(QuadrilateralTypes.SQUARE, quadrilateral.GetAreaOfSquare());
                            return quadrilateralTypeArea;
                        }
                    case QuadrilateralTypes.RECTANGLE:
                        {
                            QuadrilateralTypeArea quadrilateralTypeArea = new QuadrilateralTypeArea(QuadrilateralTypes.RECTANGLE, quadrilateral.GetAreaOfRectangle());
                            return quadrilateralTypeArea;
                        }
                    case QuadrilateralTypes.RHOMBUS:
                        {
                            QuadrilateralTypeArea quadrilateralTypeArea = new QuadrilateralTypeArea(QuadrilateralTypes.RHOMBUS, quadrilateral.GetAreaOfRhombus());
                            return quadrilateralTypeArea;
                        }
                    case QuadrilateralTypes.PARALLELOGRAM:
                        {
                            QuadrilateralTypeArea quadrilateralTypeArea = new QuadrilateralTypeArea(QuadrilateralTypes.PARALLELOGRAM, quadrilateral.GetAreaOfParallelogram());
                            return quadrilateralTypeArea;
                        }
                    case QuadrilateralTypes.QUADRANGLE:
                        {
                            QuadrilateralTypeArea quadrilateralTypeArea = new QuadrilateralTypeArea(QuadrilateralTypes.QUADRANGLE, quadrilateral.GetAreaOfRectangle());
                            return quadrilateralTypeArea;
                        }
                    default:
                        {
                            QuadrilateralTypeArea quadrilateralTypeArea = new QuadrilateralTypeArea(QuadrilateralTypes.INVALID, 0);
                            return quadrilateralTypeArea;
                        }
                }
            }


            static QuadrilateralTypes Type(double a, double b, double c, double d, double alpha, double beta, double gamma, double delta)
            {
                if (alpha != 0 && beta != 0 && gamma != 0 && delta != 0 && a != 0 && b != 0 &&
                    alpha == beta && beta == gamma && gamma == delta && a == b) return QuadrilateralTypes.SQUARE;

                if (alpha != 0 && beta != 0 && gamma != 0 && delta != 0 &&
                    alpha == beta && beta == gamma && gamma == delta) return QuadrilateralTypes.RECTANGLE;

                if (a != 0 && b != 0 && c != 0 && d != 0 &&
                    a == b && b == c && c == d) return QuadrilateralTypes.RHOMBUS;

                if (alpha != 0 && beta != 0 && gamma != 0 && delta != 0 &&
                    alpha == gamma && beta == delta) return QuadrilateralTypes.PARALLELOGRAM;

                if (alpha != 0 && beta != 0 && gamma != 0 && delta != 0 &&
                    alpha + delta == 180 && beta + gamma == 180 || alpha + beta == 180 && gamma + delta == 180) return QuadrilateralTypes.TRAPEZOID;

                if (a != 0 && b != 0 && c != 0 && d != 0 && alpha != 0 && gamma != 0)
                    return QuadrilateralTypes.QUADRANGLE;

                return QuadrilateralTypes.INVALID;
            }

            double a = Helper.GetInput<double>("a = ");
            double b = Helper.GetInput<double>("b = ");
            double c = Helper.GetInput<double>("c = ");
            double d = Helper.GetInput<double>("d = ");
            double alpha = DegreesToRadians(Helper.GetInput<double>("alpha = "));
            double beta = DegreesToRadians(Helper.GetInput<double>("beta = "));
            double gamma = DegreesToRadians(Helper.GetInput<double>("gamma = "));
            double delta = DegreesToRadians(Helper.GetInput<double>("delta = "));

            QuadrilateralTypeArea quadrilateralTypeArea = GetQuadrilateralTypeAndArea(a, b, c, d, alpha, beta, gamma, delta);
            if (quadrilateralTypeArea.type == QuadrilateralTypes.INVALID)
                Console.WriteLine("Invalid quadrilateral.");
            else
                Console.WriteLine($"That is a {Enum.GetName(typeof(QuadrilateralTypes), quadrilateralTypeArea.type)} with area of {quadrilateralTypeArea.area}.");
        }

        // Exercise7

        public enum Animal
        {
            RABBIT,
            SHEEP,
            PIG,
            COW,
            HORSE,
            SMALLDOG,
            BIGDOG,
            FOX,
            WOLF
        }

        public enum UserUsableAnimal
        {
            RABBIT,
            SHEEP,
            PIG,
            COW,
            HORSE,
            SMALLDOG,
            BIGDOG
        }

        public class Player
        {
            public string name { get; }
            public bool won { get; set; } = false;

            public Dictionary<Animal, int> animals { get; set; } = new Dictionary<Animal, int>()
            {
                { Animal.RABBIT, 1 },
                { Animal.SHEEP, 0 },
                { Animal.PIG, 0 },
                { Animal.COW, 0 },
                { Animal.HORSE, 0 },
                { Animal.SMALLDOG, 0 },
                { Animal.BIGDOG, 0 }
            };

            public Player(string name)
            {
                this.name = name;
            }
        }

        public struct Game
        {
            public List<Player> players { get; set; }
            public Dictionary<Animal, int> herd { get; set; }
            public Dictionary<Animal, int> animalValues { get; set; } = new Dictionary<Animal, int>()
            {
                { Animal.RABBIT, 1 },
                { Animal.SHEEP, 6 },
                { Animal.PIG, 12 },
                { Animal.COW, 36 },
                { Animal.HORSE, 72 },
                { Animal.SMALLDOG, 6 },
                { Animal.BIGDOG, 36 }
            };

            public Game(List<Player> players)
            {
                this.players = players;

                herd = new Dictionary<Animal, int>()
                {
                    { Animal.RABBIT, 60 - players.Count() },
                    { Animal.SHEEP, 24 },
                    { Animal.PIG, 20 },
                    { Animal.COW, 12 },
                    { Animal.HORSE, 6 },
                    { Animal.SMALLDOG, 4 },
                    { Animal.BIGDOG, 2 }
                };
            }

            void Trade(Dictionary<Animal, int> source, Dictionary<Animal, int> target, Animal sourceAnimal, Animal targetAnimal, int animalAmount)
            {
                if (animalAmount > source[sourceAnimal])
                    animalAmount = source[sourceAnimal];

                int animalValue = animalValues[sourceAnimal] * animalAmount;

                if (animalValue >= animalValues[targetAnimal] && animalValue % animalValues[targetAnimal] == 0)
                {
                    if (source[sourceAnimal] <= animalAmount)
                    {
                        target[sourceAnimal] += source[sourceAnimal];
                        source[sourceAnimal] = 0;
                    }
                    else
                    {
                        source[sourceAnimal] -= animalAmount;
                        target[sourceAnimal] += animalAmount;
                    }

                    while (target[targetAnimal] != 0 && animalValue >= animalValues[targetAnimal])
                    {
                        animalValue -= animalValues[targetAnimal];
                        target[targetAnimal] -= 1;
                        source[targetAnimal] += 1;
                    }
                }
            }

            public void Trade(Player sourcePlayer, Animal sourceAnimal, Animal targetAnimal, int animalAmount)
            {
                Trade(sourcePlayer.animals, this.herd, sourceAnimal, targetAnimal, animalAmount);
            }

            public void Trade(Player sourcePlayer, Player targetPlayer, Animal sourceAnimal, Animal targetAnimal, int animalAmount)
            {
                Trade(sourcePlayer.animals, targetPlayer.animals, sourceAnimal, targetAnimal, animalAmount);
            }

            void RolledFox(Player player)
            {
                if (player.animals[Animal.SMALLDOG] == 0)
                {
                    this.herd[Animal.RABBIT] += player.animals[Animal.RABBIT] - 1;
                    player.animals[Animal.RABBIT] = 1;
                }
                else
                {
                    player.animals[Animal.SMALLDOG] -= 1;
                    this.herd[Animal.SMALLDOG] += 1;
                }
            }

            void RolledWolf(Player player)
            {
                if (player.animals[Animal.BIGDOG] > 0)
                {
                    player.animals[Animal.BIGDOG] -= 1;
                    this.herd[Animal.BIGDOG] += 1;
                }
                else
                {
                    this.herd[Animal.SHEEP] += player.animals[Animal.SHEEP];
                    this.herd[Animal.PIG] += player.animals[Animal.PIG];
                    this.herd[Animal.COW] += player.animals[Animal.COW];
                    player.animals[Animal.SHEEP] = 0;
                    player.animals[Animal.PIG] = 0;
                    player.animals[Animal.COW] = 0;
                }
            }

            public void CheckWinners()
            {
                foreach (Player player in players)
                {
                    if (player.animals[Animal.RABBIT] > 0 && player.animals[Animal.SHEEP] > 0
                        && player.animals[Animal.PIG] > 0 && player.animals[Animal.COW] > 0
                        && player.animals[Animal.HORSE] > 0)
                    {
                        player.won = true;
                        Console.WriteLine($"\n{player.name} won!");
                    }
                }
            }

            public void RollDices(Player player)
            {
                Animal[] redDicesSides = { Animal.RABBIT, Animal.RABBIT, Animal.RABBIT,
                    Animal.RABBIT, Animal.RABBIT, Animal.RABBIT,
                    Animal.SHEEP, Animal.SHEEP,
                    Animal.PIG, Animal.PIG,
                    Animal.HORSE, Animal.FOX };

                Animal[] greenDiceSides = { Animal.RABBIT, Animal.RABBIT, Animal.RABBIT,
                    Animal.RABBIT, Animal.RABBIT, Animal.RABBIT,
                    Animal.SHEEP, Animal.SHEEP, Animal.SHEEP,
                    Animal.PIG, Animal.COW, Animal.WOLF };

                Random random = new Random();
                int redDiceSideIndex = random.Next(0, redDicesSides.Length);
                int greenDiceSideIndex = random.Next(0, greenDiceSides.Length);

                Animal redDiceAnimal = redDicesSides[redDiceSideIndex];
                Animal greenDiceAnimal = greenDiceSides[greenDiceSideIndex];

                if (redDiceAnimal == Animal.FOX) RolledFox(player);
                if (greenDiceAnimal == Animal.WOLF) RolledWolf(player);

                foreach (Animal animal in (Animal[])Enum.GetValues(typeof(Animal)))
                {
                    // Ignore fox and wolf.
                    if (player.animals.ContainsKey(animal)) {
                        int animalCount = player.animals[animal];
                        if (redDiceAnimal == animal) animalCount++;
                        if (greenDiceAnimal == animal) animalCount++;
                        int numberOfAnimalPairs = animalCount / 2;

                        // Compare number of animals.
                        if (numberOfAnimalPairs <= this.herd[animal])
                        {
                            this.herd[animal] -= numberOfAnimalPairs;
                            player.animals[animal] += numberOfAnimalPairs;
                        } else
                        {
                            player.animals[animal] += this.herd[animal];
                            this.herd[animal] = 0;
                        }
                    }

                }
            }

            public bool ShouldEndTheGame()
            {
                int numberOfPlayersWon = 0;

                foreach (Player player in players)
                    if (player.won) numberOfPlayersWon++;

                return players.Count() - 1 == numberOfPlayersWon;
            }
        }

        public static List<Player> GetPlayerData()
        {
            int numberOfPlayers = Helper.GetInput<int>("Enter amount of players: ");
            var players = new List<Player>();

            for (int i = 0; i < numberOfPlayers; i++)
            {
                string playerName = Helper.GetInput<string>($"Enter name of player {i + 1}: ");
                var player = new Player(playerName);
                players.Add(player);
            }

            return players;
        }

        public static int GetAnimalIndexChoice(string message, Array animalEnumArray)
        {
            Console.WriteLine(message);
            foreach (var animal in animalEnumArray)
                Console.WriteLine($"{(int)animal + 1}. {animal}");
            int animalIndexChoiceInput = Helper.GetInput<int>() - 1;
            return animalIndexChoiceInput;
        }

        public static void PrintGameState(Game game)
        {
            Console.WriteLine($"\n[<animal>, <amount of animal>]\n\nHerd:\n{string.Join(Environment.NewLine, game.herd)}");
            foreach (Player player in game.players)
                Console.WriteLine($"\n{player.name}:\n{string.Join(Environment.NewLine, player.animals)}");
        }

        public static void TradeMenu(Game game, Player currentPlayer)
        {
            Console.WriteLine("\nWith what/whom do you want to trade?\n0. The herd");
            for (int i = 0; i < game.players.Count(); i++)
            {
                if (currentPlayer != game.players[i])
                    Console.WriteLine($"{i + 1}. {game.players[i].name}");
            }

            int tradePartnerIndexInput = Helper.GetInput<int>() - 1;
            if (tradePartnerIndexInput >= -1 && tradePartnerIndexInput < game.players.Count())
            {
                Array animalEnumArray = Enum.GetValues(typeof(UserUsableAnimal));

                int sourceAnimalIndexChoiceInput = GetAnimalIndexChoice("\nWhat animal type do you want to trade?", animalEnumArray);
                if (sourceAnimalIndexChoiceInput < 0 || sourceAnimalIndexChoiceInput >= animalEnumArray.Length)
                    return;

                int targetAnimalIndexChoiceInput = GetAnimalIndexChoice("\nFor what animal type?", animalEnumArray);
                if (targetAnimalIndexChoiceInput < 0 || targetAnimalIndexChoiceInput >= animalEnumArray.Length)
                    return;

                int animalAmount = Helper.GetInput<int>("\nHow many of your animals do you want to trade?\n");
                if (animalAmount > 0)
                {
                    switch (tradePartnerIndexInput)
                    {
                        case -1:
                            game.Trade(currentPlayer, (Animal)sourceAnimalIndexChoiceInput, (Animal)targetAnimalIndexChoiceInput,
                                animalAmount);
                            break;
                        default:
                            game.Trade(currentPlayer, game.players[tradePartnerIndexInput], (Animal)sourceAnimalIndexChoiceInput,
                                (Animal)targetAnimalIndexChoiceInput, animalAmount);
                            break;
                    }

                    Console.WriteLine("\nResult:");
                    PrintGameState(game);
                }
            }
        }

        public static int Menu(Game game, Player currentPlayer)
        {
            int input = Helper.GetInput<int>($"\n{currentPlayer.name}, please select action:\n1. No action \n2. Show game state\n3. Trade\n");

            switch (input)
            {
                case 2:
                    PrintGameState(game);
                    break;
                case 3:
                    TradeMenu(game, currentPlayer);
                    break;
            }

            return input;
        }

        public static void Exercise7()
        {
            Game game = new Game(GetPlayerData());
            bool gameEnded = false;

            do
            {
                foreach (Player player in game.players)
                {
                    if (!player.won)
                    {
                        while (Menu(game, player) != 1) { }

                        game.RollDices(player);
                        PrintGameState(game);
                        game.CheckWinners();

                        if (game.ShouldEndTheGame())
                        {
                            gameEnded = true;
                            break;
                        }
                    }
                }
            } while (!gameEnded);

            Console.WriteLine("\nGame ended! The winners are:");
            foreach (Player player in game.players)
            {
                if (player.won)
                    Console.WriteLine(player.name);
            }
        }
    }
}
