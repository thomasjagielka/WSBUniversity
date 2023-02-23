using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToComputerProgramming
{
    internal class ExerciseSet8
    {
        public static bool Exercise1()
        {
            string text = Helper.GetInput<string>();

            for (int i = 0; i < text.Length / 2; i++)
            {
                if (text[i] != text[text.Length - 1 - i])
                    return false;
            }

            return true;
        }

        public static void Exercise2()
        {
            int number = Helper.GetInput<int>();

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                    Console.WriteLine(i);
            }
        }

        public static void Exercise3()
        {
            int number = Helper.GetInput<int>();
            bool isPrime = true;

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                    isPrime = false;
            }

            Console.Write(isPrime);
        }

        public static void Exercise4()
        {
            List<int> RemoveMultiplies(List<int> numbers, int maxNumber)
            {
                List<int> numbersClone = new List<int>(numbers);
                double maxNumberSqrt = Math.Sqrt(maxNumber);

                foreach (int number in numbers)
                {
                    if (number <= maxNumberSqrt)
                    {
                        for (int i = 2; number * i <= maxNumber; i++)
                        {
                            numbersClone.Remove(number * i);
                        }
                    }
                }

                return numbersClone;
            }

            int number = Helper.GetInput<int>();
            List<int> numbers = new List<int>();

            for (int i = 2; i <= number; i++)
                numbers.Add(i);

            List<int> primeNumbers = RemoveMultiplies(numbers, number);
            foreach (int primeNumber in primeNumbers)
            {
                Console.WriteLine(primeNumber);
            }
        }
    }
}
