namespace Lektion230925_GIT
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Ange nr 1: ");
            int nr1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ange nr 2: ");
            int nr2 = Convert.ToInt32(Console.ReadLine());

         
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hej");
            Console.WriteLine("hej aska och john");

            Console.Write("Mata in första talet: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mata in andra talet: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Add(int secondNumber, int firstNumber);


        }












        public int Add(int a, int b)
        {
            int c = a + b;
            return c;
        }















       

    }
    
}