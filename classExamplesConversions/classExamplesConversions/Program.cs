namespace classExamplesConversions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String userinput = "";
            int firstnumber;
            int secondnumber;
            int result = 0;
            //asks the user for a whole number and stores it in a variable
            Console.WriteLine("Please give me a whole number:");
            //user inputs a whole number and it is stored in the variable userinput
            userinput = Console.ReadLine();
            //Tells the user what they entered
            Console.WriteLine($"you entered {userinput}");
            firstnumber = int.Parse(userinput);

            //asks the user for a whole number and stores it in a variable
            Console.WriteLine("Please give me a whole number:");
            //user inputs a whole number and it is stored in the variable userinput
            userinput = Console.ReadLine();
            //Tells the user what they entered
            Console.WriteLine($"you entered {userinput}");
            //parse converts the string to an integer and stores it in the variable secondnumber
            secondnumber = int.Parse(userinput);

            result = firstnumber + secondnumber;
            Console.WriteLine($"the result is {firstnumber} + {secondnumber} = {result}");
            //pause
            Console.ReadLine();
        }
    }
}
