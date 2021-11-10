using System;
using System.IO;

namespace WypelnianieBazyDanychZaliczenie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Saving To File...");
            //SaveToFileKompania();
            //SaveToFilePluton();
            //SaveToFileDruzyna();
            Console.WriteLine("Done!");
        }
        static void SaveToFileDruzyna()
        {
            Random rand = new();
            string path = Path.DruzynaPath;
            using StreamWriter sw = new(path);
            int TypeCount = 1;
            int Type = 1;
            int Symbol = 16;
            int PlutonCount = 1;
            int Pluton = 1;
            for (int i = 1; i <= 480; i++)
            {
                sw.WriteLine($"INSERT dbo.Druzyna(DruzynaID, SymbolID, DruzynaRodzajID, Liczebnosc, PlutonID) VALUES ({i}, {Symbol}, {Type}, {rand.Next(3, 16)}, {Pluton});");
                TypeCount++;
                if (TypeCount == 97)
                {
                    TypeCount = 1;
                    Type++;
                    Symbol++;
                }
                PlutonCount++;
                if (PlutonCount == 5)
                {
                    PlutonCount = 1;
                    Pluton++;
                }
            }
        }
        static void SaveToFilePluton()
        {
            string path = Path.PlutonPath;
            using StreamWriter sw = new(path);
            int TypeCount = 1;
            int Type = 1;
            int Symbol = 11;
            int KompaniaCount = 1;
            int Kompania = 1;
            for (int i = 1; i <= 120; i++)
            {
                sw.WriteLine($"INSERT dbo.Pluton(PlutonID, SymbolID, PlutonRodzajID, KompaniaID) VALUES ({i}, {Symbol}, {Type}, {Kompania});");
                TypeCount++;
                if (TypeCount == 25)
                {
                    TypeCount = 1;
                    Type++;
                    Symbol++;
                }
                KompaniaCount++;
                if (KompaniaCount == 5)
                {
                    KompaniaCount = 1;
                    Kompania++;
                }
            }
        }
        static void SaveToFileKompania()
        {
            string path = Path.KompaniaPath;
            using StreamWriter sw = new(path);
            int TypeCount = 1;
            int Type = 1;
            int Symbol = 6;
            int BatalionCount = 1;
            int Batalion = 1;
            for (int i = 1; i <= 30; i++)
            {
                sw.WriteLine($"INSERT dbo.Kompania(KompaniaID, SymbolID, KompaniaRodzajID, BatalionID) VALUES ({i}, {Symbol}, {Type}, {Batalion});");
                TypeCount++;
                if (TypeCount == 7)
                {
                    TypeCount = 1;
                    Type++;
                    Symbol++;
                }
                BatalionCount++;
                if (BatalionCount == 4)
                {
                    BatalionCount = 1;
                    Batalion++;
                }
            }
        }
    }
}
