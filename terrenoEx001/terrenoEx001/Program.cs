namespace terrenoEx001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Fazer um programa para ler as medidas de largura e comprimento de um terreno
            retangular com uma casa decimal, bem como o valor do metro quadrado do terreno com
            duas casas decimais. Em seguida, o programa deve mostrar o valor da área do terreno
            bem como o valor do preço do terreno, ambos com duas casa decimais.
            */
            double largura, comprimento, metroQuadrado, area, preco;

            Console.Write("Comprimento (m): ");
            comprimento = double.Parse(Console.ReadLine());

            Console.Write("Largura (m): ");
            largura = double.Parse(Console.ReadLine());

            Console.Write("Valor do Metro Quadrado: R$");
            metroQuadrado = double.Parse(Console.ReadLine());

            area = largura * comprimento;
            preco = area * metroQuadrado;

            Console.WriteLine($"Area: {area:F2}m³");
            Console.WriteLine($"Preço: R${preco:F2}");
        }
    }
}
