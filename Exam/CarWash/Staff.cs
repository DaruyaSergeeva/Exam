using System;
using System.Collections.Generic;
using System.Text;

namespace Exam.CarWash
{   
    public class Staff
    {
        string Position;
        string Name;
        public Employee Employee;
        public int Donework;
        
        public Staff(string name,string position)
        {
            Position = position;
            Name = name;
        }
    
        public int DoneWork()
        {
            if (Employee.WorkDone)
            {
                Donework = Donework + 1;
            }
            return Donework;
        }

        public void GetInfo()
        {
            Console.WriteLine("FIO: " + Name + ". Position: " + Position + ". DoneWork:" + Donework);
        }
    }
}
