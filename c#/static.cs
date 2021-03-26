using System;

class Mat{
    static public double pi = 3.14;
    static public double dobro(double n){
        return n * 2;
    }
}
class Aula49{
    static void Main(){
        int num = 10;

        Console.WriteLine(Mat.dobro(num));
        Console.WriteLine(Mat.dobro(Mat.pi));
    }
}