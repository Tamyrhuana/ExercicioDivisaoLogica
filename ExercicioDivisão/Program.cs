namespace ExercicioDivisão
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digito o primeiro número");
            double primeiroNumero = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo número");
            double segundoNumero = Convert.ToDouble(Console.ReadLine());

            double divisao =primeiroNumero / segundoNumero;

            Console.WriteLine("A divisão " + divisao);

        }
    }
}
