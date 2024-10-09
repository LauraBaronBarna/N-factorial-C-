namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine()); // Read input from the console, convert it to an integer, and store it in the variable 'n'
            int fakt = 1; // Initialize an integer variable 'fakt' to 1. This will hold the factorial value
            for (int i = n; i > 1; i--) // Start a loop from 'n' and decrement 'i' by 1 on each iteration until 'i' is greater than 1
                fakt = fakt * i; // On each iteration, multiply the current value of 'fakt' by 'i' and update 'fakt'
            Console.WriteLine(fakt); // Output the final value of 'fakt', which is the factorial of 'n'
        }
    }
}
