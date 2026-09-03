//Jonathan Paul
//Fall 2026
//RCET 2261

namespace classExamplesControlFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 7;
            string userInput = "";
            //if (firstNumber < 1)
            //{
            //    Console.WriteLine("bigger then 1!");
            //}
            //else
            //{
            //    Console.WriteLine("not bigger then 1!");
            //}
            //if (firstNumber < 1)
            //{
            //    Console.WriteLine("bigger then 1!");
            //}
            //else if (firstNumber > 1)
            //{
            //    Console.WriteLine("smaller than 1!");
            //}
            //else 
            //{
            //    Console.WriteLine("something else happened!");
            //}
            //Pause

            Console.WriteLine("choose wisely 1, 2, or 3");
            userInput = Console.ReadLine();

            if (userInput == "1")
            {
                Console.WriteLine("you chose 1");
            }
            else if (userInput == "2")
            {
                Console.WriteLine("you chose 2");
            }
            else if (userInput == "3")
            {
                Console.WriteLine("you chose 3");
            }
            else
            {
                Console.WriteLine("you chose something else");
            }

            Console.ReadLine();
        }
    }
}
