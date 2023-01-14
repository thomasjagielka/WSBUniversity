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
    }
}
