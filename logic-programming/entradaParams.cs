using System;
class Aula25{
    static void Main(){
        int num = 10;
        dobrar(ref num); // o metodo nao tem retorno, parametro é alterado utilizando "ref"

        int numTriplicado = triplicar(num);

        Console.WriteLine(num);
        Console.WriteLine(numTriplicado);
    }
    static void dobrar(ref int valor){
        valor *= 2;
    }
    static int triplicar(int valor){
        valor *= 3;
        return valor;
    }
}