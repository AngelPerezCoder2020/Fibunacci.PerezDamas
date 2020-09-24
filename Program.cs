using System;

namespace Fibunacci.PerezDamas
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            Console.Clear();
            Console.WriteLine("Welcome to my Program \n \nWhat do u wanna do? \n \n1. Create a Fibonacci´s Algoritm \n2.EXIT");
            option = Convert.ToInt32(Console.ReadLine());

            switch(option)
            {
                case 1:
                    do{
                        Console.Clear();
                        Console.WriteLine("How many times do u want algoritm to repeat? ");
                        int rep = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(" \n \nEnter to Watch ur result...");
                        Console.ReadKey();
                        Console.WriteLine($"El Ultimo Resultado de tu Algoritmo es: {suma(0,1,rep)}");
                        Console.ReadKey();
                        do{
                            Console.WriteLine(" \nWhat do u wanna do now? \n \n1.Create another algoritm \n2.Back to the mother menú");
                            option = Convert.ToInt32(Console.ReadLine());
                            if(option != 1 && option != 2)
                                Console.WriteLine("The selected option does not exist, ENTER and try again...");
                        }while(option != 1 && option != 2);
                    }while(option != 2);                    
                    break;
                case 2:
                    Console.WriteLine("Thanks for ussing my program! I guees it was usefully for u! ;)");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("The selected option does not exist, ENTER and try again...");
                    Console.ReadKey();
                    break;
            }
        }
        private static int suma(int a, int b, int c)
        {
            if(c==0){
                Console.WriteLine($"{c} ");
                return c;
            }
            else{
                c --;
                int n = a;
                int m = b;

                a = m;
                b = n+m;

                int r = b + suma(a,b,c);
                Console.WriteLine($"{r} ");
                return r;
            }
        }
    }
}