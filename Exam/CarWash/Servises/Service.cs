using System;
using System.Collections.Generic;
using System.Text;

namespace Exam.CarWash
{
    class Service
    {
        public int Price;
        public DateTime Time;
        public Employee Employee;
        public Client Client;
        public Staff Staff;
        public Service( Employee employee, Client client,Staff staff, DateTime time)
        {
            Time = time;
            Employee = employee;
            Client = client;
            Staff = staff;
        }

        public void Do()
        {
            Staff.Donework++;
            Client.SpendMoney += Price;
            Client.BuyService++;
        }
    }
}
