using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        // Method injection yapılıyor
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        {
            // Başvuru yapanın bilgileri
            //
            krediManager.Hesapla();
            loggerService.Log();
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediManagers)
        {
            foreach (var kredi in krediManagers)
            {
                kredi.Hesapla();
            }
        }
    }
}
