﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Exam.CarWash
{
    public enum Sex
    {
        Male,
        Female
    }
    public class Person
    {
        public string FIO;
        public string LastName;
        public string Name;
        public string Patronymic;
        public Sex Sex;

        public decimal Money;

        public Person(string FIO, Sex sex)
        {

            LastName = FIO.Split(' ')[0];
            Name = FIO.Split(' ')[1];
            Patronymic = FIO.Split(' ')[2];
            Sex = sex;
            //Money = money;
        }

        public decimal GetMoney()
        {
            return Money;
        }

        public virtual void GetInfo()
        {
            Console.WriteLine("FIO: " + LastName + " " + Name + " " + Patronymic + ". Sex:" + Sex );
        }
    }
}

