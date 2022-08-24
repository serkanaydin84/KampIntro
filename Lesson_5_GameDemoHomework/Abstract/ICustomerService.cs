using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_5_GameDemoHomework.Abstract
{
    interface ICustomerService
    {
        void Add(Customer customer);
        void Update(Customer customer);
        void Delete(Customer customer);
    }
}
