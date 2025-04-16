class Program
{
    public static void Main()
    {
      
        Console.WriteLine("Digite o primeiro número:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o segundo número:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        bool resultado = num1 != num2;

        if (resultado)
        {
            Console.WriteLine("Os dois números são diferentes.");
        }
        
    }
}
