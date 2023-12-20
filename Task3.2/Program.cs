namespace Task3._2
{
    internal class Program
    {
        public class VowelChecker
        {
            public static void CheckVowels(string input)
            {
                bool hasVowels = false;
                foreach (char c in input.ToLower())
                {
                    if ("aeiou".Contains(c))
                    {
                        hasVowels = true;
                        break;
                    }
                }

                if (!hasVowels)
                {
                    throw new Exception("String does not contain any vowels!");
                }
            }

            static void Main(string[] args)
            {
                string[] arr = { "Hello", "World", "12345", "Ok" };

                foreach (string index in arr)
                {
                    try
                    {
                        Console.WriteLine($"Testing string: {index}");
                        CheckVowels(index);
                        Console.WriteLine("String contains vowels.");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
        }
    }
}
