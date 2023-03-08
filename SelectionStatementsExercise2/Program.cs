namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {   
            //User inputs
            Console.WriteLine("What is your name?");
                var userName = Console.ReadLine();

            Console.WriteLine($"Hello {userName}, What is your favorite school subject?");
                var schoolSubject = Console.ReadLine();

            //Switch Expression
            switch (schoolSubject.ToLower()) 
            {
                //Math
                case "math":
                case "mathmatics":
                    Console.WriteLine("My brain is mostly math and electricity."); 
                    break;

                //History
                case "history":
                    Console.WriteLine("History doesn't repeat but it does ryhme."); 
                    break;

                //Science
                case "science":
                    Console.WriteLine("I was made by science and powered by Corgi's.");
                    break;

                //Gym
                case "gym":
                    Console.WriteLine("Like every subject, wither you get something out of it depends on how much you put into it.");
                    break;

                //English
                case "english":
                    Console.WriteLine("If you can read this, you are doing at least mediocre in your studies.");
                    break;
                
                //Default
                default:
                    Console.WriteLine("I have never heard of that subject... you are unique.");
                    break;
            }

        }
    }
}