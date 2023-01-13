namespace IntroductionToComputerProgramming
{
    internal class ExerciseSet1
    {
        static void Exercise1()
        {
            Console.WriteLine("Hello world!");
        }

        static void Exercise2()
        {
            Console.WriteLine("First line");
            Console.Write("Second line");
        }

        static void Exercise3()
        {
            string name = Console.ReadLine();
            Console.Write($"Hello {name}!");
            // Console.WriteLine("Hello {0}!", name);
        }

        static void Exercise4()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secNum = int.Parse(Console.ReadLine());
            Console.Write(firstNum + secNum);
        }

        static void Exercise5()
        {
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            Console.Write(a * b);
        }

        static void Exercise6()
        {
            float r = float.Parse(Console.ReadLine());
            Console.Write(Math.PI * 4 / 3 * Math.Pow(r, 3));
        }

        static void Exercise7()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secNum = int.Parse(Console.ReadLine());
            Console.Write(firstNum / secNum);
        }

        static void Exercise8()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secNum = int.Parse(Console.ReadLine());
            Console.Write(firstNum % secNum);
        }

        static void Exercise9()
        {
            int firstNum = int.Parse(Console.ReadLine());
            string? result = firstNum % 2 == 0 ? $"NUMBER {firstNum} IS EVEN" : "";
            if (result != "") Console.Write(result);
        }

        static void Exercise10()
        {
            int firstNum = int.Parse(Console.ReadLine());
            string result = firstNum % 2 == 0 ? $"NUMBER {firstNum} IS EVEN" : $"NUMBER {firstNum} IS NOT EVEN";
            Console.Write(result);
        }

        static void Exercise11()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int largestNum = Int32.MinValue;

            if (firstNum > secNum) largestNum = firstNum;
            if (thirdNum > largestNum) largestNum = thirdNum;

            Console.Write(largestNum);
        }

        static void Exercise12()
        {
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());

            string result = Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2) ? "The triangle is right." : "The triangle is not right.";

            Console.Write(result);
        }

        static void Exercise13()
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("c = ");
            int c = int.Parse(Console.ReadLine());

            c -= b;
            c /= a;

            Console.Write($"x = {c}");
        }

        static void Exercise14()
        {
            int num = int.Parse(Console.ReadLine());
            int result;

            if (num > 0) result = 1;
            else if (num == 0) result = 0;
            else result = -1;

            Console.Write(result);
        }

        static void Exercise15()
        {
            for (int i = 0; i <= 1000; i++)
                Console.WriteLine(i);
        }

        static void Exercise16()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            for (int i = a; i <= b; i++)
                Console.WriteLine(i);
        }

        static void Exercise17()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            for (int i = a + 1; i <= b; i += 2)
                Console.WriteLine(i);
        }

        static void Exercise18()
        {
            for (int x = 0; x <= 100; x++)
                Console.WriteLine($"y = {3 * x}");
        }

        static void Exercise19()
        {
            int evenCount = 0;

            for (int i = 0; i < 10; i++)
            {
                if (int.Parse(Console.ReadLine()) % 2 == 0)
                    evenCount++;
            }

            Console.Write(evenCount);
        }

        static void Exercise20()
        {
            int evenCount = 0;

            for (int i = 0; i < 1000; i++)
            {
                if (int.Parse(Console.ReadLine()) % 2 == 0)
                    evenCount++;
            }

            Console.Write(evenCount);
        }

        static void Exercise21()
        {
            //int h = int.Parse(Console.ReadLine());
            //int treeLeafesCount = 0;

            //for (int i = 0; i < h; i++)
            //{
            //    for (int j = 0; j <= treeLeafesCount; j++)
            //    {
            //        Console.Write("*");
            //    }

            //    treeLeafesCount += 1;
            //    Console.WriteLine()
            //}

            int h = int.Parse(Console.ReadLine());

            for (int i = 1; i <= h; i++)
            {
                string leafes = new String('*', i);
                Console.Write($"{leafes}\n");
            }
        }

        static void Exercise22()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                    Console.Write($"{i * j}\t");

                Console.WriteLine();
            }
        }

        static void Exercise23()
        {
            Console.Write("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
        }

        static void Exercise24()
        {
            int evenCount = 0;
            string input;

            do
            {
                input = Console.ReadLine();
                int number;

                if (int.TryParse(input, out number))
                    if (number % 2 == 0) evenCount++;
            } while (input != "STOP");

            Console.Write(evenCount);
        }

        static void Exercise25()
        {
            int sum = 0;
            string input;

            do
            {
                input = Console.ReadLine();
                int number;

                if (int.TryParse(input, out number))
                    sum += number;
            } while (input != "STOP");

            Console.Write(sum);
        }
    }
}
