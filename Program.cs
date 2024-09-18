namespace Topic_4._User_input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //New user input
            string name;
            Console.WriteLine("Hello, what is your name?:");
            Console.WriteLine();
            
            
            
            
            
            
            
            
            
            
            double price;
            Console.WriteLine("What is the price?:");
            double.TryParse(Console.ReadLine(), out price);
            Console.WriteLine("The price is " + (price / 5).ToString("C"));
            Console.ReadLine();









        }
    }
}
