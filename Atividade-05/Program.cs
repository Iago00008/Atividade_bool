class program
{
    public static void Main()
    {
        Console.WriteLine("digite um número:");
        int num = Convert.ToInt32 (Console.ReadLine()); 

        bool resultado = num % 3 == 0;  

        if (resultado) {
            Console.WriteLine("Esse númeor é múltiplo de 3.");

        }
        else
        {
            Console.WriteLine("Esse número não é múltiplo de 3.");

        }
    }
}