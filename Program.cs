namespace Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Greetings and Salutations");
            Console.WriteLine("To whom are we talking with?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Nice to meet you, {userName}. \nWanna play a game?");
            Console.WriteLine("\nLet's check for palidromes.  Please enter a word.");
            string directive = Console.ReadLine().ToLower();
            Console.WriteLine("you gave us " + directive);
            string drawkcab = "";

            for (int i = 0; i < directive.Length; i++)
            {
                Console.WriteLine (drawkcab += directive[directive.Length -1-i]);
            }
            if (drawkcab != directive)
            {
                Console.WriteLine("Sorry, we got a backwards word, but no Palindrome.");
            }

            else
            {
                Console.WriteLine("Congratulations!  We have a Palindrome!");
            }


        }
    }
}




