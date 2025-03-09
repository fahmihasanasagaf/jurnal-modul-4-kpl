using System;

namespace jurnalmodul4
{
    class Program
    {
        static void Main(string[] args)
        {
            KodeBuah kodeBuah = new KodeBuah();

            Console.Write("Masukkan nama buah: ");
            string buah = Console.ReadLine();

            string kode = kodeBuah.GetKodeBuah(buah);
            Console.WriteLine($"Kode buah {buah}: {kode}");
        }
    }
}
