namespace Dotnet;

public class Program 
{
    public static void Main()
    {
        //input entrada e output saida de dados

        //output
        Console.WriteLine("-----LOGIN-----");

        //solicitar o nome do usuário
        Console.Write("Digite seu nome: ");
        //input - entrada de dados
        string name = Console.ReadLine();

        Console.Write("Digite sua idade: ");
        //ReadLine não lê string então é necessario usar o Convert para transformar o inteiroem string
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("O Nome do usuário é " + name + " a idade do usuário é " + age + " anos");


    }
}


