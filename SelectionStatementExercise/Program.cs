namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1,1000);
            int minNumber = 1;
            int maxNumber = 1000;
            int userInput = 0;

            do 
            {
                Console.Write($"Enter a value between {minNumber} and {maxNumber}: ");
                userInput = int.Parse(Console.ReadLine());

                if (userInput < favNumber)
                {
                    minNumber = userInput;
                    Console.WriteLine("Too Low!");
                }
                else if (userInput > favNumber)
                {
                    maxNumber = userInput;
                    Console.WriteLine("Too High!");
                }
                else
                {
                    Console.WriteLine("You Win!");
                }
            } while (userInput != favNumber);
        }
    }
}
