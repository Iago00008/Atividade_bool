
class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite sua idade:");
        int idade = Convert.ToInt32(Console.ReadLine());
        bool resultado = idade >= 16;
        if (resultado)
        {
            Console.WriteLine("Você pode votar.");
        }
        else 
        {
            Console.WriteLine("Você NÃO pode votar.");
        }
        
    }
}
