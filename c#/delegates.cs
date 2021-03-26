using System;
delegate double Op(params double[] array);
delegate double Op1(double num);
class Mat{
    static public double soma(params double[] array){
        double soma = 0;
        for(int i = 0;i < array.Length;i++){
            soma += array[i];
        }
        return soma;
    }
    static public double dobro(double num){
        return num * 2;
    }
    static public double mult(params double[] array){
        double mult = 1;
        for(int i = 0;i < array.Length;i++){
            mult *= array[i];
        }
        return mult;
    }
}
class Aula50{
    static void Main(){

        Op sum = new Op(Mat.soma);
        Op times = new Op(Mat.mult);
        Op1 doublee = new Op1(Mat.dobro);

        Console.WriteLine(sum(3, 4, 5, 6, 1, 23));
        Console.WriteLine(times(5, 6, 2, 3));
        Console.WriteLine(doublee(38));
    }
}