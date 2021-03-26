using System;

class Aula08{

    static void Main(){
        int valor1, valor2, tipo, resultado;
        string nome;

        Console.WriteLine("==== CALCULADORA ====");
        Console.WriteLine("\t1 - Soma\n\t2 - Subtração\n\t3 - Multiplicação\n\t4 - Divisão\n\n");
        Console.Write("Digite seu nome: ");
        nome = Console.ReadLine();

        Console.WriteLine("Escolha uma operação: ");
        tipo = int.Parse(Console.ReadLine());
        switch (tipo)
        {
            case 1: 
                Console.WriteLine("\n{0}, você escolheu soma!",nome);
                break;
            case 2: 
                Console.WriteLine("\n{0}, você escolheu subtração!",nome);
                break;
            case 3: 
                Console.WriteLine("\n{0}, você escolheu multiplicação!",nome);
                break;
            case 4: 
                Console.WriteLine("\n{0}, você escolheu divisão!",nome);
                break;
            default:
                Console.WriteLine("\n{0}, você escolheu uma opção inexistente",nome);
                break;
        }

        Console.Write("Digite o primeiro valor: ");
        valor1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o segundo valor: ");
        valor2 = Convert.ToInt32(Console.ReadLine());

        switch (tipo)
        {
            case 1: 
                resultado = valor1 + valor2;
                break;
            case 2: 
                resultado = valor1 - valor2;
                break;
            case 3: 
                resultado = valor1 * valor2;
                break;
            case 4: 
                resultado = valor1 / valor2;
                break;
            default: 
                resultado = 0;
                break;
        }

        Console.WriteLine("\n\nO resultado é {0}", resultado);
    }
}