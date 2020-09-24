using System;

namespace Fibunacci.PerezDamas
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            do{
                Console.Clear();
                Console.WriteLine("Welcome to my Program \n \nWhat do u wanna do? \n \n1. Create a Fibonacci´s Algoritm \n2. EXIT");
                option = Convert.ToInt32(Console.ReadLine());

                switch(option)
                {
                    case 1:
                        int option2 = 0;
                        do{
                            Console.Clear();
                            Console.WriteLine("How many times do u want algoritm to repeat? ");
                            int rep = Convert.ToInt32(Console.ReadLine()) + 1;
                            Console.WriteLine(" \n \nEnter to Watch ur result...");
                            Console.ReadKey();
                            Console.WriteLine($"El Ultimo Resultado de tu Algoritmo es: {suma(0,1,rep)}");
                            Console.ReadKey();
                            do{
                                Console.Clear();
                                Console.WriteLine(" \nWhat do u wanna do now? \n \n1.Create another algoritm \n2.Back to the mother menú");
                                option2 = Convert.ToInt32(Console.ReadLine());
                                if(option2 != 1 && option2 != 2)
                                    Console.WriteLine("The selected option does not exist, ENTER and try again...");
                            }while(option2 != 1 && option2 != 2);
                        }while(option2 != 2);                    
                        break;
                    case 2:
                        Console.WriteLine("Thanks for ussing my program! I guees it was usefully for u! ;)");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine(" \nThe selected option does not exist, ENTER and try again...");
                        Console.ReadKey();
                        break;
                }
            }while(option != 2);
        }
        private static int suma(int a, int b, int c)
        {
            if(c<1){
                Console.WriteLine($"{c} ");
                return c;
            }
            else{
                c --;
                if(c == 0){
                    int n = a;
                    int m = b;

                    a = m;
                    b = n+m;
                }
                Console.WriteLine($"Valor de C = {c}, Valor de a = {a}, Valor de b = {b}");
                int r = b + suma(a,b,c);
                Console.WriteLine($"{r} ");
                return r;
            }
        }
    }
}