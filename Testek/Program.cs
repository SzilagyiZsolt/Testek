using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testek
{
    internal class Program
    {
        static List<Testek> testek = new List<Testek>();
        static void Main(string[] args)
        {
            testek.Add(new Henger(3,4));
            testek.Add(new Kocka(8));
            testek.Add(new Téglatest(12, 7, 15));
            foreach (var item in testek)
            {
                if(item.GetType()== typeof(Henger)) 
                {
                    Henger henger= (Henger)item;
                    Console.WriteLine($"A henger felszíne: {Math.Round(item.Felszin(),2)} - térfogata: {Math.Round(item.Terfogat(),2)} - magassága: {henger.m} - sugara: {henger.r}");
                }
                else if (item.GetType()== typeof(Kocka))
                {
                    Kocka kocka = (Kocka)item;
                    Console.WriteLine($"A kocka felszíne: {Math.Round(item.Felszin(), 2)} - térfogata: {Math.Round(item.Terfogat(), 2)} - oldala: {kocka.a}");
                }
                else if (item.GetType()== typeof(Téglatest))
                {
                    Téglatest téglatest = (Téglatest)item;
                    Console.WriteLine($"A téglatest felszíne: {Math.Round(item.Felszin(), 2)} - térfogata: {Math.Round(item.Terfogat(), 2)} - A oldala: {téglatest.a} - B oldala: {téglatest.b} - C oldala: {téglatest.c}");
                }
            }
            Console.ReadKey();
        }
    }
}
