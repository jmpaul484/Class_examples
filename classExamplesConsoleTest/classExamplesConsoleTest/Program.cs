namespace classExamplesConsoleTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
                //Console.Beep();
                Console.Beep(100,1000);

                Console.WriteLine("What is your favorite color?");
                //get user input
                userInput = Console.ReadLine();
            Console.WriteLine("I love " + userInput);
                //Pause before close
                Console.ReadLine();

        }
    }
}
