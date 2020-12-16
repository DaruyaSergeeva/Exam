using System;
using System.Collections.Generic;
using System.Text;

namespace Exam.CarWash.Servises
{
    class ComplexWash:Service
    {
        public ComplexWash(Employee employee, Client client, DateTime time) : base(employee, client, time)
        {
            Price = 790;
        }

        public void Message()
        {
            Console.WriteLine("Выполнена услуга 'Комплекс мойка'");
        }
    }
}
