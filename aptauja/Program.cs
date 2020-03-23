using System;
using System.Collections.Generic;

namespace aptauja
{
    class Program
    {
        class JautajumsUnAtbilde
        {
            public string Jautajums { get; set; }
            public string Atbilde { get; set; }
            public string PareizaAtbilde { get; set; }
        }
       

       static List<JautajumsUnAtbilde> saraksts = new List<JautajumsUnAtbilde>();

        static void Main(string[] args)
        {           
            Console.WriteLine("APTAUJA");
            Console.WriteLine();

            void AizpilditJautajumu(string jautajums, string pareizaAtbilde)
            {
                JautajumsUnAtbilde j = new JautajumsUnAtbilde();
                j.Jautajums = jautajums;
                j.PareizaAtbilde = pareizaAtbilde;
                saraksts.Add(j);
              
            }

            AizpilditJautajumu("Kā sauc četrstūrainu figūru?", "kvadrāts");  
            AizpilditJautajumu("Cik ir 2+2?", "4");         
            AizpilditJautajumu("Kādās krāsās ir Latvijas karogs?", "sarkans, balts, sarkans");

            int kluduSkaits = 0;
            int pareizaAtbilde = 0;

            foreach (JautajumsUnAtbilde j in saraksts)
            {
                Console.WriteLine(j.Jautajums);              
                j.Atbilde = Console.ReadLine().ToLower();
                Console.WriteLine();

                
                if (j.PareizaAtbilde == j.Atbilde)
                {
                    Console.WriteLine("Pareizi!");
                    pareizaAtbilde++;
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Kļūda!");
                    kluduSkaits++;
                    Console.WriteLine();
                }
            }

            Console.WriteLine("Pareizas atbildes: " + pareizaAtbilde.ToString());
            Console.WriteLine("Kļūdu skaits: " + kluduSkaits.ToString());
        }

    }

}
