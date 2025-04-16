
class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite sua idade:");
        int idade = Convert.ToInt32(Console.ReadLine());

        if (idade >= 16)
        {
            Console.WriteLine("Você pode votar.");
        }
        else if (idade <= 15)
        {
            Console.WriteLine("Você NÃO pode votar.");
        }
        
    }
}
