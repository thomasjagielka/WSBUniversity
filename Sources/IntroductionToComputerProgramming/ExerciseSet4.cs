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
    }
}
