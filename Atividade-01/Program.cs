
class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite um número:");
        int num = Convert.ToInt32(Console.ReadLine());

        bool resultado = num >= 0;

        if (resultado)
        {
            Console.WriteLine("Este número e Positivo.");
        }

    }
}