using System;

namespace Weihnachtsbaum.Versuch_1000

{ }
    class Program
    {  
    static void Main (string[]args)

    {
        // Wie hoch soll der Baum werden
        Console.Write(" Schreibe die hoehe des Baumes : ");

        int hoehe = Convert.ToInt32(Console.ReadLine());
        int l = 0;

         l = hoehe;

            for (int i = 0; i < hoehe; i++)
            {
                for (int k = 0; k < (hoehe - 1) - i; k++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                l -= 1;
             }
               
            Console.WriteLine();
            }


         for (int i = 0; i < hoehe % 5; i++)


        {
            for (int k = 0; k < hoehe -3.5; k++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("####");
        }

    }

    }
        
   
   
       
       
    

