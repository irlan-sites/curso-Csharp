using System.Globalization;

namespace testesProcessamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nomeCompleto;
            int quartos;
            double preco;
            string[] dados;

            Console.Write("Digite seu nome completo: ");
            nomeCompleto = Console.ReadLine();

            Console.Write("Quantos quartos existem na sua casa? (Ex: 2): ");
            quartos = int.Parse(Console.ReadLine());

            Console.Write("Digite o preço de algum produto (Ex: 25,90): ");
            preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite seu último nome, sua idade e sua altura: ");
            dados = Console.ReadLine().Split();

            Console.WriteLine($"Seu nome completo é: {nomeCompleto}");
            Console.WriteLine($"Na sua casa existem: {quartos} quartos");
            Console.WriteLine($"O preço que voce digitou foi: R${preco}");
            Console.WriteLine($"Seu último nome é: {dados[0]}\nSua idade é: {dados[1]} anos\nSua altura é: {dados[2]}m");
        }
    }
}
