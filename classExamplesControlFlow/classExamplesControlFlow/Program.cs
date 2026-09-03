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
            //if (firstNumber < 1)
            //{
            //    Console.WriteLine("bigger then 1!");
            //}
            //else
            //{
            //    Console.WriteLine("not bigger then 1!");
            //}
            if (firstNumber < 1)
            {
                Console.WriteLine("bigger then 1!");
            }
            else if (firstNumber > 1)
            {
                Console.WriteLine("smaller than 1!");
            }
            else 
            {
                Console.WriteLine("something else happened!");
            }
            //Pause
            Console.ReadLine();
        }
    }
}
