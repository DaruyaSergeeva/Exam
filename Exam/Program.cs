using System;
using Exam.CarWash;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            Client person1 = new Client("Am A A", Sex.Male, 18, new DateTime());
            person1.FIO = "ALEX MOROZOV HA";
            Staff staff1 = new Staff("", "");
            Console.WriteLine(person1.Fio);
            Console.WriteLine(person1.BuyService);
            Console.ReadLine();
        }
    }
}
