
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