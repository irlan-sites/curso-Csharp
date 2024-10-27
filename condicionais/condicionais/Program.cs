namespace condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int horario = 0;

            horario = int.Parse(Console.ReadLine());

            if (horario < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else if (horario < 18)
            {
                Console.WriteLine("Boa tarde!");
            }
            else
            {
                Console.WriteLine("Boa noite!");
            }
        }
    }
}
