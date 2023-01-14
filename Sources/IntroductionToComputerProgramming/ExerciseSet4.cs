using System.IO;

namespace IntroductionToComputerProgramming
{
    internal class ExerciseSet4
    {
        public static void Exercise1()
        {
            File.AppendAllText("my_first_file.txt", "Tomasz Jagiełka");
        }

        public static void Exercise2()
        {
            Console.Write(File.ReadAllText("my_first_file.txt"));
        }

        public static void Exercise3()
        {
            string FILE_NAME = "data.txt";
            if (!File.Exists(FILE_NAME))
                File.AppendAllText(FILE_NAME, "Captain's log" + Environment.NewLine);

            while (Helper.GetInput<string>() != "start") { }

            string input = Helper.GetInput<string>(); 
            using (StreamWriter sw = File.CreateText(FILE_NAME))
            {
                do
                {
                    sw.WriteLine(input);
                    input = Helper.GetInput<string>();
                } while (input != "stop");
            }
        }

        struct Point
        {
            public double x { get; set; }
            public double y { get; set; }

            public Point(double x, double y)
            {
                this.x = x;
                this.y = y;
            }

            public double GetDistance(Point point)
            {
                return Math.Sqrt(Math.Pow(this.x - point.x, 2) + Math.Pow(this.y - point.y, 2));
            }
        }

        struct Trapezoid
        {
            Point topLeft, topRight, bottomLeft, bottomRight;
            double height;

            public Trapezoid(Point topLeft, Point topRight, Point bottomLeft, Point bottomRight, double height)
            {
                this.topLeft = topLeft;
                this.topRight = topRight;
                this.bottomLeft = bottomLeft;
                this.bottomRight = bottomRight;
                this.height = height;
            }

            public double GetArea()
            {
                double a = this.topLeft.GetDistance(this.topRight);
                double b = this.bottomLeft.GetDistance(this.bottomRight);
                Console.WriteLine($"{a}, {b}");
                return 0.5 * (a + b) * this.height;
            }
        }

        public static void Exercise4()
        {
            string[] data = File.ReadAllText("trapezoids.csv").Split(Environment.NewLine);
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] != "")
                {
                    string[] values = data[i].Split(",");

                    Point topLeft = new Point(double.Parse(values[0]), double.Parse(values[1]));
                    Point topRight = new Point(double.Parse(values[2]), double.Parse(values[3]));
                    Point bottomLeft = new Point(double.Parse(values[4]), double.Parse(values[5]));
                    Point bottomRight = new Point(double.Parse(values[6]), double.Parse(values[7]));
                    double height = double.Parse(values[8]);

                    Trapezoid trapezoid = new Trapezoid(topLeft, topRight, bottomLeft, bottomRight, height);

                    Console.WriteLine($"Area of trapezoid {i + 1}: {trapezoid.GetArea()}");
                }
            }
        }
    }
}
