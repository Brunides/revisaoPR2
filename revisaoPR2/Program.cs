using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        public static void Exercicio1()
        {
            Console.WriteLine("here ex1 will be encoded");
            int[] vet2;
            int n;
           

            vet2 = new int[1000];
            Random rand = new Random();

            for (int i = 0; i < 1000; i++)
            {


                vet2[i] = rand.Next(1, 1000);

            }
            Console.WriteLine("digite um número: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < 1000; i++)
            {
                if (n == vet2[i])
                {
                    Console.WriteLine("o número digitado esta no vetor.");
                    break;

                }

            }





        }
        public static void Exercicio2()
        {
            Console.WriteLine("here ex2 will be encoded");
            int[] vet2;
            int n, cont = 0;


            vet2 = new int[20000];
            Random rand = new Random();

            for (int i = 0; i < 20000; i++)
            {


                vet2[i] = rand.Next(1, 20000);

            }
            Console.WriteLine("digite um número: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < 20000; i++)
            {
                if (n == vet2[i])
                {
                    Console.WriteLine("o número digitado esta no vetor.");
                    cont++;

                }

            }


            Console.WriteLine("o número selecionado aparece no vetor "+ cont + " vezes");


        }
        public static void Exercicio3()
        {
            Console.WriteLine("here ex3 will be encoded");
            int[] vet2;
            int[] vet1; 
            int[] vet3;
          

            vet1 = new int[10];
            vet2 = new int[10];
            vet3 = new int[10];
            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {


                vet2[i] = rand.Next(1, 1000);

            }
           
            for (int i = 0; i < 10; i++)
            {
                if (vet2[i] % 2 == 0)
                {
                    vet1[i] = vet2[i] / 2;
                }
                else
                {
                    vet3[i] = vet2[i] * 3; 
                }

            }

            for (int i = 0; i < 10; i++)
            {


             Console.WriteLine("números pares:{0}", vet1[i]);
                Console.WriteLine("números impares:{0}", vet3[i]);

            }

        }
            public static void Exercicio4()
        {
            Console.WriteLine("here ex4 will be encoded");
            int[] vet2;
            int n, cont = 0;


            vet2 = new int[5000];
            Random rand = new Random();

            for (int i = 0; i < 5000; i++)
            {


                vet2[i] = rand.Next(1, 5000);

            }
            Console.WriteLine("digite um número: ");
       

            for (int i = 0; i < 5000; i++)
            {
                if (vet2[i] % 2 !=0 &&vet2[i] % 3 !=0 &&vet2[i] % 5 !=0 )
                {
                    Console.WriteLine("o número digitado é um número primo.");
                    Console.WriteLine("números primos {0}", vet2[i]);

                }

            }


         

        }
        public static void Exercicio5()
        {
           



        }

        static void Main(string[] args)
        {

            int option;

            do
            {
                Console.WriteLine("===========MENU=========");
                Console.WriteLine("para executar o exercício 1 - digite 1");
                Console.WriteLine("para executar o exercício 2 - digite 2");
                Console.WriteLine("para executar o exercício 3 - digite 3");
                Console.WriteLine("para executar o exercício 4 - digite 4");
                Console.WriteLine("para executar o exercício 5 - digite 5");
                Console.WriteLine("para sair digite 0");

                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 0:
                        Console.WriteLine("Thank you for using my system!");
                        break;
                    case 1:
                        Exercicio1();
                        break;
                    case 2:
                        Exercicio2();
                        break;
                    case 3:
                        Exercicio3();
                        break;
                    case 4:
                        Exercicio4();
                        break;
                    case 5:
                        Exercicio5();
                        break;
                }

            } while (option != 0);

        }
    }
}
