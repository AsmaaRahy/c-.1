using System.Data;

namespace Task3
{
    internal class Program
    {


        static void Main(string[] args)
        {
         
            List<int> numbers = new List<int>();

            Console.WriteLine("Enter integers or 'done' when finished:");

            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "done")
                {
                    break;
                }
                int number = int.Parse(input);
                if (numbers.Contains(number))
                {
                    Console.WriteLine("hfhghfg");
                }

            //    try
            //    {
            //        int number = int.Parse(input);

            //        if (numbers.Contains(number))
            //        {
            //            throw new DuplicateNumberException(number);
            //        }

            //        numbers.Add(number);
            //    }
                
            //    catch (DuplicateNumberException ex)
            //    {
            //        Console.WriteLine($"Error: Duplicate number found: {ex.Message}");
            //    }
            //}

            //Console.WriteLine("List of unique numbers:");
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            }
        }
    }

 
   
}
