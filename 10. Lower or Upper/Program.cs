namespace _10._Lower_or_Upper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char n = char.Parse(Console.ReadLine());
            bool a = char.IsUpper(n);
            if (a == true)
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }


        }
    }
}