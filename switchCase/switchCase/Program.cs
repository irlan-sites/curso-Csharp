namespace switchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            string dia;

            switch (x)
            {
                case 1:
                    dia = "Segunda";
                    break;
                case 2:
                    dia = "Terça";
                    break;
                case 3:
                    dia = "Quarta";
                    break;
                case 4:
                    dia = "Quinta";
                    break;
                case 5:
                    dia = "Sexta";
                    break;
                case 6:
                    dia = "Sábado";
                    break;
                case 7:
                    dia = "Domingo";
                    break;
                default:
                    dia = "valor inválido";
                    break;
            }
            Console.WriteLine($"Dia da Semana: {dia}");
        }
    }
}
