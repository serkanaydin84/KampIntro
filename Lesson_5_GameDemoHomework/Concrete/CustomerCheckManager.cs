using System;
using System.Collections.Generic;
using System.Text;
using Lesson_5_GameDemoHomework.Abstract;

namespace Lesson_5_GameDemoHomework.Concrete
{
    class CustomerCheckManager : ICustomerCheckService
    {
        public bool EDevletValidation(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " adlı oyuncu doğrulandı");
            return true;
        }
    }
}