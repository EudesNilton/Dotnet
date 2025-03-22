
# Estudos C#

## Variáveis

Aqui está um pouco sobre variáveis:
O que são?

- São como gavetas para armazenar valores que serão reaproveitados ao longo do programa;

Exemplo de variáveis

```csharp
        string name = "Eudes";
        Console.WriteLine(name);

        int age = 27;
        Console.WriteLine(age);

        double value = 300.0;
        Console.WriteLine(value);

        char character = 'a';
        Console.WriteLine(character);
        
        bool boolean = true;
        Console.WriteLine(boolean);
```
## Constantes

Aqui está um pouco sobre constantes:
O que são?

- São bem parecidas com as variáveis porem os valores não podem ser alterados ao longo do código;

Exemplo de Constante

```csharp
        //uma constante não pode ser alterada
        const int number = 100;
        Console.WriteLine("O valor da constante é : " + number);

        //dynamic é uma "variavel" que pode ser alterada tanto o valor quanto o tipo
        // ao longo do codigo

        dynamic variable = 20;
        variable = "Eudes";

        Console.WriteLine(variable);
    ```
## Entrada e saída de dados

Aqui está um pouco sobre input e output:
O que são?

- É usado para receber e devolver dados ao usuário o input a gente utiliza o Console.ReadLine() e para a saida de dados a gente utiliza o Console.WriteLine() ou o Console.Write();

Exemplo de Input e Output

    ```csharp
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

```