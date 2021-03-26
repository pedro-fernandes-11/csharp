using System;
class Aula17{
    static void Main(){
        // int n1, n2, n3, n4, n5;
        int[] num = new int[5];
        int[] num1 = new int[3]{55, 77, 99};
        int[] num2 = {66, 88, 90};
        string[] veiculos = new string[3]{"Avião", "Carro", "Navio"};

        num[0] = 7;
        num[1] = 14;
        num[2] = 21;
        num[3] = 28;
        num[4] = 35;

        Console.Write("\nArray num:\n{");
        for(int i = 0;i < num.Length ;i++){
            if(i == (num.Length - 1)){
                Console.Write(num[i]+" }");
            }else{Console.Write(num[i]+", ");}
        }

        Console.Write("\nArray num1:\n{");
        for(int i = 0;i < num1.Length ;i++){
            if(i == (num1.Length - 1)){
                Console.Write(num1[i]+" }");
            }else{Console.Write(num1[i]+", ");}
        }

        Console.Write("\nArray num2:\n{");
        for(int i = 0;i < num2.Length ;i++){
            if(i == (num2.Length - 1)){
                Console.Write(num2[i]+" }");
            }else{Console.Write(num2[i]+", ");}
        }

        Console.Write("\nArray veiculos:\n{");
        for(int i = 0;i < veiculos.Length ;i++){
            if(i == (veiculos.Length - 1)){
                Console.Write(veiculos[i]+" }");
            }else{Console.Write(veiculos[i]+", ");}
        }
    }
}