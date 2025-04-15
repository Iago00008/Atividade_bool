
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite um número:");
        int num = Convert.ToInt32(Console.ReadLine());

        bool resultado = num % 2 == 0;


        if (resultado)
        {
            Console.WriteLine("O número é par.");
        }

    }
}