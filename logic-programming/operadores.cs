using System;

class Aula05{

    static void Main(){

        int num = 7;
        num++;
        Console.WriteLine("Incrementado: "+num);

        
        // & = And
        // | = Or

        bool res = (19 != 19)|(19 > 18);
        bool res2 = (19 != 19)&(19 > 18);
        Console.WriteLine("Booleano: "+res+"\nBooleano 2: "+res2);
    }
}