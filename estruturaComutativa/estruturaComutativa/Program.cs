namespace estruturaComutativa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double preco = 50;
            int minutosTotal, minutosExcedidos;

            minutosTotal = int.Parse(Console.ReadLine());
            if (minutosTotal > 100)
            {
                minutosExcedidos = minutosTotal - 100;
                preco += minutosExcedidos * 2.0;
            }

            Console.WriteLine($"Valor a pagar: R$ {preco:F2}");
        }
    }
}
