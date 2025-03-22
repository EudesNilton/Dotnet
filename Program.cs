namespace Dotnet;

public class Program 
{
    public static void Main()
    {
        //uma constante não pode ser alterada
        const int number = 100;
        Console.WriteLine("O valor da constante é : " + number);

        //dynamic é uma "variavel" que pode ser alterada tanto o valor quanto o tipo
        // ao longo do codigo

        dynamic variable = 20;
        variable = "Eudes";

        Console.WriteLine(variable);
    
    }
}


