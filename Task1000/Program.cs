namespace Task1000
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // read text
            string input = Console.ReadLine();
            string[] items = input.Split();
            string s1=items[0];
            string s2=items[1];
            int a=int.Parse(s1);
            int b = int.Parse(s2);
            int c = a + b;
            Console.WriteLine(c);
        }
    }
}
