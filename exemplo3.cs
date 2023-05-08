using System;

class IMC 
{
    static void Main() 
    {
        
        Console.WriteLine("Digite a sua altura: ");

        // Método TryParse para evitar possíveis exceções
        if (!float.TryParse(Console.ReadLine()?.Replace(',', '.'), out float altura))
        {
            Console.WriteLine("Valor inválido para a altura");
            return;
        }

        Console.WriteLine("Digite o seu peso: ");

        // Método TryParse para evitar possíveis exceções
        if (!float.TryParse(Console.ReadLine()?.Replace(',', '.'), out float peso))
        {
            Console.WriteLine("Valor inválido para o peso");
            return;
        }

        // Cálculo do IMC
        double IMC = peso / (altura * altura);

        // Exibição do resultado
        Console.WriteLine("O seu índice de massa corporal é: " + IMC);
    }
}
