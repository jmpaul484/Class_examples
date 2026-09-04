namespace classExamplesLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Hello");
            //}

            //int someNumber = 0;
            //while (someNumber <= 7)
            //{ 
            //    Console.WriteLine("in the while loop");
            //    someNumber++;
            //}

            //string userInput = "q";
            //while (userInput != "q")
            //{
            //    Console.WriteLine("enter q to quit");
            //    userInput = Console.ReadLine();
            //    Console.Clear();
            //    Console.WriteLine($"you entered: {userInput}");
            //}

            //do
            //{
            //    Console.WriteLine("the do loop always runs at least once");
            //    Console.WriteLine("enter q to quit");
            //    userInput = Console.ReadLine();
            //    Console.Clear();
            //    Console.WriteLine($"you entered: {userInput}");
            //} while (userInput != "q");
            ////Console.Clear();
            //Console.WriteLine("have a nice day");
            //Pause

            string userInput = "";
            int firstNumber = 0;
            bool isValid = false;

            do

            {
                Console.WriteLine("Please enter a whole number:");
                userInput = Console.ReadLine();
                Console.WriteLine($"You entered: {userInput}");

                try
                {
                    firstNumber = int.Parse(userInput);
                    isValid = true;
                    Console.WriteLine("Successfully converted to an integer");

                }
                catch (Exception)
                {
                    Console.WriteLine("Error: Please enter a valid whole number.");
                    isValid = false;
                }
            } while (!isValid);
            Console.ReadLine();
        }
    }
}
