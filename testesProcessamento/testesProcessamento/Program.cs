using System.Globalization;

namespace testesProcessamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string palavra;
            int num;
            double dec;
            string[] paciente; //nome, idade, altura, sexo

            palavra = Console.ReadLine();
            num = int.Parse(Console.ReadLine());
            dec = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            paciente = Console.ReadLine().Split(' ');
            string nomePaciente = paciente[0];
            int idadePaciente = int.Parse(paciente[1]);
            double alturaPaciente = double.Parse(paciente[2], CultureInfo.InvariantCulture);
            char sexoPaciente = char.Parse(paciente[3]);

            Console.WriteLine($"Voce digitou: \n{palavra}\n{num}\n{dec.ToString(CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Paciente: {nomePaciente}\nIdade: {idadePaciente}\nAltura: {alturaPaciente.ToString(CultureInfo.InvariantCulture)}\nSexo: {sexoPaciente}");
        }
    }
}
