namespace _4._Centuries_to_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            int hours = 24 * days;
            double minutes = hours * 60;


            Console.WriteLine($"1 centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
            
            
        }
    }
}