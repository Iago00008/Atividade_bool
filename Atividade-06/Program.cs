class program
{
    public static void Main()
    {
        Console.WriteLine("Digite a Nota do aluno:");
        double nota = Convert.ToDouble(Console.ReadLine());

        bool resultado = nota >= 7;

        if (resultado)
        {
            Console.WriteLine("O aluno foi aprovado.");
        }
        else
        {
            Console.WriteLine("O aluno foi reprovado.");

        }
    }
}