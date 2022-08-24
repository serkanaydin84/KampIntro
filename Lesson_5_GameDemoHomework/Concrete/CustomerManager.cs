using Lesson_5_GameDemoHomework.Abstract;
using System;

namespace Lesson_5_GameDemoHomework
{
    class CustomerManager : ICustomerService
    {
        void ICustomerService.Add(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " adlı oyuncu eklendi");
        }

        void ICustomerService.Delete(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " adlı oyuncu silindi");
        }

        void ICustomerService.Update(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " adlı oyuncu güncellendi");
        }
    }
}
