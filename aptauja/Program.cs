using System;
using System.Collections.Generic;

namespace aptauja
{
    class Program
    {
        class JautajumsUnAtbilde
        {
            public string Jautajums { get; set; }
 
            private string atbilde;
            public string Atbilde
            {
                get
                {
                    return atbilde.ToLower();
                }
                set
                {
                    atbilde = value;
                }
            }
            public string PareizaAtbilde { get; set; }
            public string Rezultats()
            {
                return Atbilde == PareizaAtbilde ? "Pareizi" : "Kļūda";
            }
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
                j.Atbilde = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine(j.Rezultats());
                Console.WriteLine();

            }

            Console.WriteLine("Pareizas atbildes: " + pareizaAtbilde.ToString());
            
            Console.WriteLine("Kļūdu skaits: " + kluduSkaits.ToString());
        }

    }

}
