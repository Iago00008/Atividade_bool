class Program
{
    public static void Main()
    {
      
        Console.WriteLine("Digite sua idade:");
        int idade = Convert.ToInt32(Console.ReadLine());

        bool resultado = idade >= 18;


        if (resultado)
        {
            Console.WriteLine("A pessoa é maior de idade.");
        }
        else
        {
            Console.WriteLine("A pessoa é menor de idade.");
        }
    }
}
