using System;

namespace Projeto{
   class Program{
   
        static void Main(string[] args){
            
            int i = 0;
            int a,b = 0;
            int []vetor = new int[10];

            Random NumRand = new Random();
            


            System.Console.WriteLine("Vector Random:");
            for(i=0; i<10; i++){
                vetor[i] = NumRand.Next(0,1000);
                System.Console.Write(vetor[i] + " ");
            }
            
                System.Console.WriteLine("");
                System.Console.WriteLine("---------------------");    

            for(a = 0; a < 10; a++){
                for(; b < 10; ){
                    if(vetor[a] < vetor[b]){
                        int Valor = vetor[b];
                        vetor[b] = vetor[a];
                        vetor[a] = Valor;
                        b=0;
                    } else{
                        b++;    
                    } 
                            
                    }
                    System.Console.WriteLine("Ordering vector: ");
                    for(i = 0; i <10; i++){                   
                        System.Console.Write(vetor[i] + " ");
                    }  
                    System.Console.WriteLine("");
                    System.Console.WriteLine("---------------------");
                b=0;
            }

            System.Console.WriteLine("");
            System.Console.WriteLine("Ordered vector:");
            for(i = 0; i <10; i++){
                System.Console.Write(vetor[i] + " ");
            }    
            System.Console.WriteLine("---------------------");
          

    

            }

        }

         
    }

















