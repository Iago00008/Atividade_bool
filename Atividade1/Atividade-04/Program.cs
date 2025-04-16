class program
{
    public static void Main()
    {
        Console.WriteLine("Digite uma letra:");
        char letra = Convert.ToChar(Console.ReadLine());

        string vogais = "aeiou";
        bool resultado = vogais.Contains(letra);

        if (resultado)
        {   
            Console.WriteLine("É uma vogal");
        }
        else
        {
            Console.WriteLine("Não é uma vogal.");
        }
    }

}