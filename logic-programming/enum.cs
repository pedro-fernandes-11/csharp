using System;

class Aula10{
    enum DiasSemana{Domingo, Segunda, Terça, Quarta, Quinta, Sexta, sábado};
    static void Main(){
        
        int dsNum = (int)DiasSemana.Sexta;
        DiasSemana ds = (DiasSemana)0;

        Console.WriteLine(ds);
        Console.WriteLine(dsNum);
    }
}