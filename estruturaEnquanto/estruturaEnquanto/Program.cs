namespace estruturaEnquanto
{
    internal class Program
    {
        static void Main()
        {
            int x;
            x = int.Parse(Console.ReadLine());
            int soma = x;


            while (x != 0)
            {
                x = int.Parse(Console.ReadLine());
                soma += x;
            }
            Console.WriteLine($"A soma entre todos esses números é: {soma}");
        }
    }
}
