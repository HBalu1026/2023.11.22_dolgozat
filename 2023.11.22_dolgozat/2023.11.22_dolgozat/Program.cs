using System;
using System.Xml;
using System.IO;

namespace dolgozat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] utak = File.ReadAllLines("osvenyek.txt");
            string[] dobasok = File.ReadAllLines("dobasok.txt");

            //2
            Console.WriteLine("2. feladat");
            string[] dobasokSplitelt = dobasok[0].Split(' ');
            Console.WriteLine("A dobások száma: " + dobasokSplitelt.Length);
            Console.WriteLine("Az összes ösvény száma: " + utak.Length);
            Console.WriteLine();

            //3
            Console.WriteLine("3. feladat");
            int leghosszabbUt = 0;
            for (int i = 0; i < utak.Length; i++)
            {
                if (utak[i].Length > utak[leghosszabbUt].Length)
                {
                    leghosszabbUt = i;
                }
            }
            leghosszabbUt++;
            Console.WriteLine("Az egyik leghoszabb a(z) " + leghosszabbUt + ". ösvény, hossza: " + utak[leghosszabbUt].Length);
            Console.WriteLine();

            //4
            Console.WriteLine("4. feladat");
            Console.WriteLine("Adja meg az ösvény sorszámát! ");
            int valasztottUt = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                if (valasztottUt < 1 || valasztottUt > 43)
                {
                    Console.WriteLine("Nincs ilyen ösvény! Próbálja újra");
                    valasztottUt = Convert.ToInt32(Console.ReadLine());
                }
                else break;
            }
            Console.WriteLine("Adja meg a játékosok számát!");
            int jatekosokSzama = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                if (jatekosokSzama < 1 || jatekosokSzama > 5)
                {
                    Console.WriteLine("Nem lehet ennyien játszani! Próbálja újra");
                    jatekosokSzama = Convert.ToInt32(Console.ReadLine());
                }
                else break;
            }
            valasztottUt--;
            Console.WriteLine();

            //5
            Console.WriteLine("5. feladat");
            int m = 0;
            int v = 0;
            int e = 0;
            foreach (var mezo in utak[valasztottUt])
            {
                if (mezo == 'M')
                {
                    m++;
                }
                else if (mezo == 'V')
                {
                    v++;
                }
                else if (mezo == 'E')
                {
                    e++;
                }
            }
            Console.WriteLine("M: " + m + " darab");
            Console.WriteLine("V: " + v + " darab");
            Console.WriteLine("E: " + e + " darab");
            Console.WriteLine();

            //6

        }
    }
}
