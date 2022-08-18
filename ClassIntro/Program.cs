using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Serkan Aydın";
            kurs1.IzlenmeOrani = 75;
            
            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Sümeyye Aydın";
            kurs2.IzlenmeOrani = 65;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Yusuf Bera Aydın";
            kurs3.IzlenmeOrani = 80;

            // Console.WriteLine(kurs1.KursAdi + " - " + kurs1.Egitmen + " - " + kurs1.IzlenmeOrani.ToString());

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " - " + kurs.Egitmen);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
