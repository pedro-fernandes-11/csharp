using System;
class Galinha{
    private string nomeGalinha;
    private int numOvo;
    static public int numTotalOvos = 0;
    public Galinha(string _nomeGalinha){
        this.nomeGalinha = _nomeGalinha;
        this.numOvo = 0;
    }
    public Ovo botarOvo(){
        numOvo++;
        numTotalOvos++;
        return new Ovo(numOvo, nomeGalinha);
    }
}
class Ovo{
    private int numOvo;
    private string minhaGalinha;
    public Ovo(int _numOvo, string _minhaGalinha){
        this.numOvo = _numOvo;
        this.minhaGalinha  = _minhaGalinha;
        Console.WriteLine("Ovo criado: {0} - {1}", this.numOvo, this.minhaGalinha);
    }
}
class Aula46{
    static void Main(){
        Galinha g1 = new Galinha("Galinha1");
        Galinha g2 = new Galinha("Galinha2");
        
        g1.botarOvo();
        g1.botarOvo();
        g2.botarOvo();
        g1.botarOvo();
        g1.botarOvo();
        g2.botarOvo();

        Console.WriteLine(Galinha.numTotalOvos);

    }
}