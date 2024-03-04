namespace Exercise8
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter true or false:");
            string a = Console.ReadLine();
            var result1 = Convert.ToBoolean(a);
            var result2 = Reverse(result1);
            Console.WriteLine("Reverse of your choise is:" + result2);
        }

        public static bool Reverse(bool boolean)
        {
            return !boolean;
        }
    }
}
