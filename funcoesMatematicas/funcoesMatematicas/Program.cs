namespace funcoesMatematicas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            double x = 3.0;
            double y = 4.0;
            double z = -5.0;
            double A, B, C;

            A = Math.Sqrt(x);
            B = Math.Sqrt(y);
            C = Math.Sqrt(25.0);

            Console.WriteLine($"Raíz quadrada de {x} = {A}");
            Console.WriteLine($"Raíz quadrada de {y} = {B}");
            Console.WriteLine($"Raíz quadrada de 25 = {C}");

            A = Math.Pow(x, y);
            B = Math.Pow(x, 2.0);
            C = Math.Pow(5.0, 3.0);

            Console.WriteLine($"{x} elevado a {y} = {A}");
            Console.WriteLine($"{x} elevado ao quadrado = {B}");
            Console.WriteLine($"5 elevado ao cubo = {C}");

            A = Math.Abs(x);
            B = Math.Abs(z);

            Console.WriteLine($"O valor absoluto de {x} = {A}");
            Console.WriteLine($"O valor absoluto de {z} = {B}");
            */

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("  CALCULADORA DE EQUAÇÃO DO 2º GRAU");
            Console.WriteLine("--------------------------------------");

            double a, b, c, delta, x1, x2;

            Console.Write("Digite o valor de a: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de b: ");
            b = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de c: ");
            c = double.Parse(Console.ReadLine());

            delta = Math.Pow(b, 2.0) - 4 * a * c;
            x1 = (-b + Math.Sqrt(delta)) / (2.0*a);
            x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine($"Delta = {delta}\nx1 = {x1:F1}\nx2 = {x2:F1}");
        }
    }
}
