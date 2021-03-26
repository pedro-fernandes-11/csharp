using System;
// namespace cria escopos visando organização
namespace Calc1{
    class Area{
        static public float Square(float bas, float alt){
            try{
                if(bas <= 0 || alt <= 0){
                    Console.WriteLine("Você está no namespace 1");
                    throw new Exception("Base ou altura menor ou igual a zero");
                }else{
                    Console.WriteLine("Você está no namespace 1");
                    return bas * alt;
                }
            }catch(Exception e){
                Console.WriteLine("Você está no namespace 1");
                Console.WriteLine("Erro: {0}", e.Message);
                Console.WriteLine("Exceção: {0}", e.GetType());
                return 0;
            }
        }
        static public float Triangle(float bas, float alt){
            try{
                if(bas <= 0 || alt <= 0){
                    Console.WriteLine("Você está no namespace 1");
                    throw new Exception("Base ou altura menor ou igual a zero");
                }else{
                    Console.WriteLine("Você está no namespace 1");
                    return (bas * alt)/2;
                }
            }catch(Exception e){
                Console.WriteLine("Você está no namespace 1");
                Console.WriteLine("Erro: {0}", e.Message);
                Console.WriteLine("Exceção: {0}", e.GetType());
                return 0;
            }
        }
    }
    class Perim{
        static public float Square(float side){
            try{
                if(side <= 0){
                    Console.WriteLine("Você está no namespace 1");
                    throw new Exception("Base ou altura menor ou igual a zero");
                }else{
                    Console.WriteLine("Você está no namespace 1");
                    return side * 4;
                }
            }catch(Exception e){
                Console.WriteLine("Você está no namespace 1");
                Console.WriteLine("Erro: {0}", e.Message);
                Console.WriteLine("Exceção: {0}", e.GetType());
                return 0;
            }
        }
        static public float Tri(float side){
            try{
                if(side <= 0){
                    Console.WriteLine("Você está no namespace 1");
                    throw new Exception("Base ou altura menor ou igual a zero");
                }else{
                    Console.WriteLine("Você está no namespace 1");
                    return side * 2;
                }
            }catch(Exception e){
                Console.WriteLine("Você está no namespace 1");
                Console.WriteLine("Erro: {0}", e.Message);
                Console.WriteLine("Exceção: {0}", e.GetType());
                return 0;
            }
        }
    }
}
namespace Calc2{
    class Area{
        static public float Square(float bas, float alt){
            try{
                if(bas <= 0 || alt <= 0){
                    Console.WriteLine("Você está no namespace 2");
                    throw new Exception("Base ou altura menor ou igual a zero");
                }else{
                    Console.WriteLine("Você está no namespace 2");
                    return bas * alt;
                }
            }catch(Exception e){
                Console.WriteLine("Você está no namespace 2");
                Console.WriteLine("Erro: {0}", e.Message);
                Console.WriteLine("Exceção: {0}", e.GetType());
                return 0;
            }
        }
        static public float Triangle(float bas, float alt){
            try{
                if(bas <= 0 || alt <= 0){
                    Console.WriteLine("Você está no namespace 2");
                    throw new Exception("Base ou altura menor ou igual a zero");
                }else{
                    Console.WriteLine("Você está no namespace 2");
                    return (bas * alt)/2;
                }
            }catch(Exception e){
                Console.WriteLine("Você está no namespace 2");
                Console.WriteLine("Erro: {0}", e.Message);
                Console.WriteLine("Exceção: {0}", e.GetType());
                return 0;
            }
        }
    }
    class Perim{
        static public float Square(float side){
            try{
                if(side <= 0){
                    Console.WriteLine("Você está no namespace 2");
                    throw new Exception("Base ou altura menor ou igual a zero");
                }else{
                    Console.WriteLine("Você está no namespace 2");
                    return side * 4;
                }
            }catch(Exception e){
                Console.WriteLine("Você está no namespace 2");
                Console.WriteLine("Erro: {0}", e.Message);
                Console.WriteLine("Exceção: {0}", e.GetType());
                return 0;
            }
        }
        static public float Tri(float side){
            try{
                if(side <= 0){
                    Console.WriteLine("Você está no namespace 2");
                    throw new Exception("Base ou altura menor ou igual a zero");
                }else{
                    Console.WriteLine("Você está no namespace 2");
                    return side * 2;
                }
            }catch(Exception e){
                Console.WriteLine("Você está no namespace 2");
                Console.WriteLine("Erro: {0}", e.Message);
                Console.WriteLine("Exceção: {0}", e.GetType());
                return 0;
            }
        }
    }
}

class Aula54{
    static void Main(){

        Console.WriteLine("--------------\nCalcular área ou perímetro? [a / p]");
        char resposta = char.Parse(Console.ReadLine());
        switch(resposta){
            case 'a':
                Console.WriteLine("--------------\nCalcular quadrado ou triangulo? [q / t]");
                char respostaFiguraArea = char.Parse(Console.ReadLine());
                switch(respostaFiguraArea){
                    case 'q':
                        Console.WriteLine("-------Calculando a area do quadrado-------");

                        Console.Write("Base: ");
                        float v1q = float.Parse(Console.ReadLine());

                        Console.Write("Altura: ");
                        float v2q = float.Parse(Console.ReadLine());

                        Console.WriteLine("--------------\nNamespace 1 ou 2?");
                        int respostaNamespace = int.Parse(Console.ReadLine());
                        if(respostaNamespace == 1){
                            if(Calc1.Area.Square(v1q, v2q) == 0){
                                Console.WriteLine("Ocorreu um erro!");
                            }else{
                                Console.WriteLine("Area do quadrado: {0}", Calc1.Area.Square(v1q, v2q));
                            }
                        }else if(respostaNamespace == 2){
                            if(Calc2.Area.Square(v1q, v2q) == 0){
                            Console.WriteLine("Ocorreu um erro!");
                            }else{
                                Console.WriteLine("Area do quadrado: {0}", Calc2.Area.Square(v1q, v2q));
                            }
                        }
                        
                        break;
                    case 't':
                        Console.WriteLine("-------Calculando a area do triangulo-------");

                        Console.Write("Base: ");
                        float v1t = float.Parse(Console.ReadLine());

                        Console.Write("Altura: ");
                        float v2t = float.Parse(Console.ReadLine());

                        Console.WriteLine("--------------\nNamespace 1 ou 2?");
                        int respostaNamespace1 = int.Parse(Console.ReadLine());
                        if(respostaNamespace1 == 1){
                            if(Calc1.Area.Triangle(v1t, v2t) == 0){
                                Console.WriteLine("Ocorreu um erro!");
                            }else{
                                Console.WriteLine("Area do triangulo: {0}", Calc1.Area.Triangle(v1t, v2t));
                            }
                        }else if(respostaNamespace1 == 2){
                            if(Calc2.Area.Triangle(v1t, v2t) == 0){
                            Console.WriteLine("Ocorreu um erro!");
                            }else{
                                Console.WriteLine("Area do triangulo: {0}", Calc2.Area.Triangle(v1t, v2t));
                            }
                        }

                        break;
                    default: 
                        Console.WriteLine("Resposta invalida");
                        break;
                }
                break;
            case 'p':
                Console.WriteLine("--------------\nCalcular quadrado ou triangulo? [q / t]");
                char respostaFiguraPerim = char.Parse(Console.ReadLine());
                switch(respostaFiguraPerim){
                    case 'q':
                        Console.WriteLine("-------Calculando o perimetro do quadrado-------");

                        Console.Write("Lado: ");
                        float ladoQuadrado = float.Parse(Console.ReadLine());

                        Console.WriteLine("--------------\nNamespace 1 ou 2?");
                        int respostaNamespace = int.Parse(Console.ReadLine());
                        if(respostaNamespace == 1){
                            if(Calc1.Perim.Square(ladoQuadrado) == 0){
                                Console.WriteLine("Ocorreu um erro!");
                            }else{
                                Console.WriteLine("Perimetro do quadrado: {0}", Calc1.Perim.Square(ladoQuadrado));
                            }
                        }else if(respostaNamespace == 2){
                            if(Calc2.Perim.Square(ladoQuadrado) == 0){
                            Console.WriteLine("Ocorreu um erro!");
                            }else{
                                Console.WriteLine("Perimetro do quadrado: {0}", Calc2.Perim.Square(ladoQuadrado));
                            }
                        }
                        
                        break;
                    case 't':
                        Console.WriteLine("-------Calculando o perimetro do triangulo-------");

                        Console.Write("Lado: ");
                        float ladoTriangulo = float.Parse(Console.ReadLine());

                        Console.WriteLine("--------------\nNamespace 1 ou 2?");
                        int respostaNamespace1 = int.Parse(Console.ReadLine());
                        if(respostaNamespace1 == 1){
                            if(Calc1.Perim.Tri(ladoTriangulo) == 0){
                                Console.WriteLine("Ocorreu um erro!");
                            }else{
                                Console.WriteLine("Area do triangulo: {0}", Calc1.Perim.Tri(ladoTriangulo));
                            }
                        }else if(respostaNamespace1 == 2){
                            if(Calc2.Perim.Tri(ladoTriangulo) == 0){
                            Console.WriteLine("Ocorreu um erro!");
                            }else{
                                Console.WriteLine("Area do triangulo: {0}", Calc2.Perim.Tri(ladoTriangulo));
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Resposta invalida");
                        break;
                }
                break;
                default: 
                    Console.WriteLine("Resposta invalida");
                    break;
        }
    }
}