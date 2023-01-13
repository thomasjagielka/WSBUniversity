namespace IntroductionToComputerProgramming
{
    static class Helper
    {
        public static T GetInput<T>(string output = "")
        {
            if (output != "") Console.Write(output);
            object input = Console.ReadLine();

            try
            {
                return (T)Convert.ChangeType(input, typeof(T));
            }
            catch
            {
                Console.WriteLine("Incorrect data. Please try again.");
                return GetInput<T>(output);
            }
        }
    }
}
