using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using VikingLotto0515Db;

namespace VikingLotto0515Beolvasas
{
    class Program
    {
        static void Main(string[] args)
        {
            VikingContext db = new VikingContext();

            if (!db.Huzasok.Any())
            {
                string[] sorok = null;
                bool sikeresBeolvasas = true;

                try
                {
                    sorok = File.ReadAllLines(args[0], Encoding.UTF8);
                }
                catch (Exception)
                {
                    sikeresBeolvasas = false;
                    Console.WriteLine("A megadott fájl nem található! >:(");
                }

                if (sikeresBeolvasas)
                {
                    List<Huzas> huzasok = new List<Huzas>();

                    foreach (var sor in sorok)
                    {
                        try
                        {
                            huzasok.Add(new Huzas(sor));
                        }
                        catch (Exception)
                        {
                            //TODO Kiírhatjuk a hibás sorokat.
                        }
                    }

                    db.AddRange(huzasok);
                    db.SaveChanges();

                    Console.WriteLine($"Sikeresen importált sorok száma: {db.Huzasok.Count()} db");
                }
            }
            else
            {
                Console.WriteLine("Az adattábla már létezik");
            }
        }
    }
}
