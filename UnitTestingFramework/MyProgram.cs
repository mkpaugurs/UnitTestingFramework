namespace UnitTestingFramework
{
    public static class MyProgram
    {
        static void Main(string[] args)
        {
            ProgramInit();
        }

        static void ProgramInit()
        {
            Console.WriteLine("PRACTICAL TASK: UNIT TESTING FRAMEWORK");
            Console.WriteLine("Provide string and press enter");
            string? testString = Console.ReadLine();

            if (String.IsNullOrEmpty(testString) || testString.Length < 2)
            {
                Console.WriteLine("String cannot be empty or contain one character!");
                ProgramInit();
            }
            else
            {
                PerformToTestString(testString);
            }
        }

        static void PerformToTestString(string testString)
        {
            int numberOfUneqConsChar = CountMaxNumberOfUnequalConsecutiveCharacters(testString);
            Console.WriteLine($"Result of unequal consecutive characters from an input string is {numberOfUneqConsChar}");
        }

        public static int CountMaxNumberOfUnequalConsecutiveCharacters(string testString)
        {
            int maxLength = 1;
            int currentLength = 1;

            for (int i = 1; i < testString.Length; i++)
            {
                if (testString[i] != testString[i - 1])
                {
                    currentLength++;
                }
                else
                {
                    if (currentLength > maxLength)
                        maxLength = currentLength;

                    currentLength = 1;
                }
            }

            if (currentLength > maxLength)
                maxLength = currentLength;

            return maxLength;
        }
    }
}
