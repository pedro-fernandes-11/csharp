using System;
class Aula18{
    static void Main(){
        int[,] n = new int[2, 3]{{10, 16, 19}, {8, 60, 47}};
        /*
        10  16  19
        8   60  47
        */
        int i = 0;
        int j = 0;

        for(i = 0;i < 2;i++){
            for(j = 0;j < 3;j++){
                if(j == 0){
                    Console.Write("{"+n[i, j]+", ");
                }else if(j == 2){
                    Console.Write(n[i, j]+"}");
                }else{
                    Console.Write(n[i, j]+", ");
                }
            }
            Console.Write("\n");
        }

    }
}