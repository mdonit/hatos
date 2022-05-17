using System;
using System.Collections.Generic;

namespace VikingLotto0515Db
{
    public class Huzas
    {
        public int Id { get; set; }
        public int Szam1 { get; set; }
        public int Szam2 { get; set; }
        public int Szam3 { get; set; }
        public int Szam4 { get; set; }
        public int Szam5 { get; set; }
        public int Szam6 { get; set; }

        public Huzas()
        {

        }

        public Huzas(string sor)
        { 
            string[] szovegTomb = sor.Trim().Split(";");

            if (szovegTomb.Length == 6)
            {
                int[] szamTomb = new int[6];

                for (int i = 0; i < 6; i++)
                {
                    try
                    {
                        szamTomb[i] = Convert.ToInt32(szovegTomb[i].Trim());
                    }
                    catch (Exception)
                    {
                        throw new Exception("Az adott elem nem alakítható át számmá.");
                    }

                    if (szamTomb[i] < 1 || szamTomb[i] > 48)
                    {
                        throw new Exception("Az adott szám nem 1 és 48 között van.");
                    }
                }

                HashSet<int> szamHalmaz = new HashSet<int>(szamTomb);
                if (szamHalmaz.Count != 6)
                {
                    throw new Exception("A halmazba nem 6 db szám került");
                }

                Szam1 = szamTomb[0];
                Szam2 = szamTomb[1];
                Szam3 = szamTomb[2];
                Szam4 = szamTomb[3];
                Szam5 = szamTomb[4];
                Szam6 = szamTomb[5];
            }
            else
            {
                throw new Exception("A beolvasott sor nem 6db elemet tartalmaz.");
            }
        }
    }
}
