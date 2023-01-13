namespace IntroductionToComputerProgramming
{
    internal class ExerciseSet4
    {
        public static void Exercise1()
        {
            using (StreamWriter sw = File.CreateText("my_first_file.txt"))
            {
                sw.Write("Tomasz Jagiełka");
            }
        }

        public static void Exercise2()
        {
            using (StreamReader sw = File.OpenText("my_first_file.txt"))
            {
                Console.WriteLine(sw.ReadLine());
            }
        }
    }
}
