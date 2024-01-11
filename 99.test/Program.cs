namespace _99.test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userkey = int.Parse(Console.ReadLine());

            List<int> list = new List<int>();
            for (int i = 0; i <= userkey; i++)
            {
                list.Add(i);
            }
        }
    }
}
