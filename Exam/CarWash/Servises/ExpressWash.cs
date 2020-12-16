using System;
using System.Collections.Generic;
using System.Text;

namespace Exam.CarWash.Servises
{
    class ExpressWash:Service
    {
        public ExpressWash(Employee employee, Client client, DateTime time) : base(employee, client, time)
        {
            Price = 250;
        }

        public void Message()
        {
            Console.WriteLine("Выполнена услуга 'Экспресс-мойка'");
        }
    }
}
