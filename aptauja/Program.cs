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

        class AptaujasRezultats
        {
            public List<JautajumsUnAtbilde> Saraksts { get; set; }
            public int Kludas()
            {
                int kludas = 0;
                foreach (JautajumsUnAtbilde a in Saraksts)
                {
                    if (a.Rezultats() == "Kļūda")
                    {
                        kludas++;
                    }
                }
                return kludas;
            }
            public int Pareizas()
            {
                int pareizi = 0;
                foreach (JautajumsUnAtbilde a in Saraksts)
                {
                    if (a.Rezultats() == "Pareizi")
                    {
                        pareizi++;
                    }
                }
                return pareizi;
                //return Saraksts.Count(s => s.Rezultats() == "Pareizi");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("APTAUJA");
            Console.WriteLine();

            AptaujasRezultats rezultats = new AptaujasRezultats();
            rezultats.Saraksts = new List<JautajumsUnAtbilde>();

            void AizpilditJautajumu(string jautajums, string pareizaAtbilde)
            {
                JautajumsUnAtbilde j = new JautajumsUnAtbilde();
                j.Jautajums = jautajums;
                j.PareizaAtbilde = pareizaAtbilde;
                rezultats.Saraksts.Add(j);
            }

            AizpilditJautajumu("Kā sauc četrstūrainu figūru?", "kvadrāts");
            AizpilditJautajumu("Cik ir 2+2?", "4");
            AizpilditJautajumu("Kādās krāsās ir Latvijas karogs?", "sarkans, balts, sarkans");

            foreach (JautajumsUnAtbilde j in rezultats.Saraksts)
            {
                Console.WriteLine(j.Jautajums);
                j.Atbilde = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine(j.Rezultats());
            }

            Console.WriteLine("Pareizas atbildes: " + rezultats.Pareizas());
            Console.WriteLine("Kļūdu skaits: " + rezultats.Kludas());
        }
    }

}
