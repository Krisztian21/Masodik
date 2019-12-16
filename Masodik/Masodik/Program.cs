using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masodik
{
    class Program
    {
        static void Main(string[] args)
        {
            //42.Feladat
            /*Console.WriteLine("Mennyi adattal dolgozzak?");
            int darabszam = Convert.ToInt32(Console.ReadLine());
            //Létre hozzuk a tömböt
            int[] tomb = new int[darabszam];
            //Feltöltjük
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write($"Kérem a(z) ({i + 1}). számot.");
                int szam = Int32.Parse(Console.ReadLine());
                tomb[i] = szam;
            }
            //Megszámoljuk a páratlan tömb elemeket.
            int paratlanszamok = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] % 2 == 1)
                {
                    paratlanszamok++;
                }
            }
            Console.WriteLine($"A páratlan számok száma: {paratlanszamok}.");
            //Megszámoljuk a páros tömb elemeket.
            int parosszamok = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] % 2 == 0)
                {
                    parosszamok++;
                }
            }
            Console.WriteLine($"A páros számok száma: {parosszamok}.");
            //Páros számok összege
            int parosszamokOsszege = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] % 2 == 0)
                {
                    parosszamokOsszege += tomb[i];
                }
                Console.WriteLine($"A páros számokösszege: {parosszamokOsszege}.");*/

            //44.Feladat
            /*Console.WriteLine("Mennyi adattal dolgozzak?");
            int darabszam = Convert.ToInt32(Console.ReadLine());
            //Létre hozzuk a *
            int[] tomb = new int[darabszam];
            //Feltöltjük
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write($"Kérem a(z) ({i + 1}). számot.");
                int szam = Int32.Parse(Console.ReadLine());
                tomb[i] = szam;
            }
            int parosszamokOsszege = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] % 2 == 0)
                {
                    parosszamokOsszege += tomb[i];
                }
                Console.WriteLine($"A páros számokösszege: {parosszamokOsszege}.")*/

            //45.Feladat
            /*Console.WriteLine("Mennyi adattal dolgozzak?");
            int darabszam = Convert.ToInt32(Console.ReadLine());
            int[] tomb = new int[darabszam];
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write($"Kérem a(z) ({i + 1}). számot.");
                int szam = Convert.ToInt32(Console.ReadLine());
                tomb[i] = szam;
            }
            Console.WriteLine("Kérem a próba számot!");
            int probaszam = Convert.ToInt32(Console.ReadLine());
            int tombindex = -1;
            bool vane = false;
            for (int i = 0; i < tomb.Length; i++)
            {
                tombindex = i + 1;
                vane = true;
                break;
            }
            if(vane)
            {
                Console.WriteLine($"Találtam ilyen számot az {tombindex}. pozicióban.");
            }
            else
            {
                Console.WriteLine($"Nem találtam ilyen számot a pozicióban.");
            }*/

            //46.feladat
            /*Console.WriteLine("Mennyi adattal dolgozzak?");
            int darabszam = Convert.ToInt32(Console.ReadLine());
            int[] tomb = new int[darabszam];
            int db = 0;
            int szam1=0;
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write($"Kérem a(z) ({i + 1}). számot.");
                int szam = Convert.ToInt32(Console.ReadLine());
                tomb[i] = szam;
                szam1 = tomb[i];
                if (szam == szam1)
                {
                    db++;
                    Console.WriteLine($"A(z) {szam} szerepelt már {db}-szer/szor.");
                }
                else
                {
                    Console.WriteLine($"Egyik szám sem szerepelt 2-szer/többször.");
                }
            }*/

            //47.Feladat
            /*int darabszam = Int32.Parse(Console.ReadLine());
            string[] tomb = new string[darabszam];
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.WriteLine("Kérem a nevet!");
                string[] keresztnev = Console.ReadLine();
                tomb[i] = keresztnev;
            }
            Console.WriteLine("Kérem a próbanevet!");
            string probanev=*/

            //48.Feladat
            /*Console.WriteLine("Mennyi adattal dolgozzak?");
            int darabszam = Convert.ToInt32(Console.ReadLine());
            int[] tomb = new int[darabszam];
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write($"Kérem a(z) ({i + 1}). számot.");
                int szam = Convert.ToInt32(Console.ReadLine());
                tomb[i] = szam;
            }
            int maxKulombseg = 0;
            for(int i=0; i<tomb.Length; i++)
            {
                for(int j=0; j<tomb.Length; j++)
                {
                    int kulombseg = tomb[i] - tomb[j];
                    if(maxKulombseg<=kulombseg)
                    {
                        maxKulombseg = kulombseg;
                    }
                }
            }
            Console.WriteLine($"Külömbség: " + maxKulombseg);
            //Tombkiir(tomb);
            Array.Sort(tomb);
            //Tombkiir(tomb);
            Console.WriteLine($"A külömbség: {tomb[tomb.Length-1]-tomb[tomb.Length - 2]}");
            Console.WriteLine($"Külömbség2: {tomb.Max() - tomb.Min()}");*/

            //Új 1.Feladat
            /*Console.WriteLine("Kérem a tömb elem számát: ");
            int elemszam = Int32.Parse(Console.ReadLine());

            int[] tomb =new int[elemszam];

            for(int i=0; i<tomb.Length; i++)
            {
                Console.Write($"Kérem a(z) {i + 1}. számot.");
                tomb[i] = Int32.Parse(Console.ReadLine());
            }
            int maxKulombseg=0;
            for(int i=0; i<tomb.Length - 1; i++)
            {
                int kulombseg = Int32.MaxValue;
                if (maxKulombseg <= kulombseg)
                {
                    maxKulombseg = kulombseg;
                }
            }
            Console.WriteLine($"A maximális külömbség: {maxKulombseg}");*/

            //Új 2.Feladat Felejsd el!
            /*Console.WriteLine("Kérem a tömb elem számát: ");
            int elemszam = Int32.Parse(Console.ReadLine());

            int[] tomb = new int[elemszam];

            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write($"Kérem a(z) {i + 1}. számot.");
                tomb[i] = Int32.Parse(Console.ReadLine());
            }
            int elso = -1;
            int masodik = 0;
            int kulombseg = Int32.MaxValue;
            for(int i=0; i<tomb.Length; i++)
            {
                for(int j=0; j<tomb.Length; j++)
                {

                }
            }*/ngfzghg

            Console.ReadLine();
         }
        /*static void Tombkiir(int[] tomb)
        {
            for(int i=0; i<tomb.Length; i++)
            {
                Console.WriteLine(tomb[i]);
            }*/
        }
     }