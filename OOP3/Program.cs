using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Aşağıdaki iki tür tanımlamalar aynı anlama geliyor
            // Dolayısıyla interface ler onu implamente eden class ın metodlarını tutabilir

            // IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();

            // TasitKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            
            // KonutKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();



            // Interface Loglarını tanımlıyoruz
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(tasitKrediManager, fileLoggerService);

            
            
            
            List<IKrediManager> krediManagers = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager };
            // basvuruManager.KrediOnBilgilendirmesiYap(krediManagers);
        }
    }
}
