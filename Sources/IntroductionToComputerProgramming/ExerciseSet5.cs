using System.Globalization;
using System.Numerics;

namespace IntroductionToComputerProgramming
{
    internal class ExerciseSet5
    {
        public static void Exercise1()
        {
            string[] data = File.ReadAllText("liczby3.txt").Split("\n");
            int count = 0;

            foreach (string line in data)
            {
                int zeroAmount = line.Count(f => f == '0');
                if (zeroAmount > line.Length - zeroAmount) count++;
            }

            Console.Write(count);
        }

        public static void Exercise2()
        {
            string[] data = File.ReadAllText("liczby3.txt").Split("\n");
            int countTwos = 0, countEights = 0;

            foreach (string line in data)
            {
                if (line != "" && line[line.Length - 1] == '0')
                {
                    countTwos++;

                    if (line[line.Length - 2] == '0' &&
                        line[line.Length - 3] == '0')
                        countEights++;
                }

            }

              Console.Write($"2: {countTwos}, 8: {countEights}");
        }

        public static void Exercise3()
        {
            //BigInteger[] numbers = Array.ConvertAll(
            //    File.ReadAllText("liczby.txt").
            //    Split(Environment.NewLine), s => BigInteger.Parse(s));

            //Console.Write($"Min: {numbers.Max()}\nMin: {numbers.Min()}");

            string[] data = File.ReadAllText("liczby3.txt").Split("\n");
            string min = "", max = "";
            int minLineNumber = int.MaxValue, maxLineNumber = 0;

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == "") continue;

                if (data[i].Length > max.Length)
                {
                    max = data[i];
                    maxLineNumber = i;
                }
                else if (data[i].Length == max.Length)
                {
                    for (int charIndex = 0; charIndex < data[i].Length; charIndex++)
                    {
                        if (data[i][charIndex] == '1' && max[charIndex] == '0')
                        {
                            max = data[i];
                            maxLineNumber = i;
                            break;
                        }
                        else if (data[i][charIndex] == '0' && max[charIndex] == '1') break;
                    }
                }
                else if (data[i].Length < min.Length || min == "")
                {
                    min = data[i];
                    minLineNumber = i;
                } else if (data[i].Length == min.Length)
                {
                    for (int charIndex = 0; charIndex < data[i].Length; charIndex++)
                    {
                        if (data[i][charIndex] == '0' && min[charIndex] == '1')
                        {
                            min = data[i];
                            minLineNumber = i;
                            break;
                        }
                        else if (data[i][charIndex] == '1' && min[charIndex] == '0') break;
                    }
                }
            }

            Console.Write($"min: {minLineNumber + 1}, max: {maxLineNumber + 1}");
        }
    }
}
