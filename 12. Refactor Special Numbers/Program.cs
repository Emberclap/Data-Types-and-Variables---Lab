namespace _12._Refactor_Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            bool isSpecialNumber = false;
            for (int i = 1; i <= n; i++)
            {
                int sum = 0;
                int number = i;
                
                while (number > 0)
                {
                    int lastNumber = number % 10;
                    sum += lastNumber;
                    number /= 10;
                }
                isSpecialNumber = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{i} -> {isSpecialNumber}");
                
            }
        }
    }
}