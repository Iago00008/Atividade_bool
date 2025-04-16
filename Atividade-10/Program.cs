class Program
{
    public static void Main()
    {
       
        string senha = "3543";

        
        Console.WriteLine("Digite a senha:");
        string senhaDigitada = Console.ReadLine();

     
        bool resultado = senhaDigitada == senha;

   
        if (resultado)
        {
            Console.WriteLine("Senha correta.");
        }
        else
        {
            Console.WriteLine("Senha incorreta.");
        }
    }
}
