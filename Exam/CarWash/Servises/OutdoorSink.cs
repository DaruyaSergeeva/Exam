using System;
using System.Collections.Generic;
using System.Text;

namespace Exam.CarWash.Servises
{
    class OutdoorSink:Service
    {
        public OutdoorSink(Employee employee, Client client, Staff staff, DateTime time) : base(employee,client,time)
        {
            Price = 390;
        }

        public void Message()
        {
            Console.WriteLine("Выполнена услуга 'Наружная мойка'");
        }
    }
}
