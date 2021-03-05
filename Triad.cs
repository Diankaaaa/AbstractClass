using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    abstract class Triad
    {

        //Время Задание 1.30 Час:Минута:Секунда
        public int hour { get; set; }
        public int minute { get; set; }
        public int second { get; set; }

        //Инициализация времени числами
        //protected Triad(int hour, int minute, int second)
        //{
        //    this.hour = hour;
        //    this.minute = minute;
        //    this.second = second;
        //}

        //Инициализация времени строкой
        //Инициалзация времени секундами
        //Инициализация времени времемнем

        //Дата Задание 1.29
        public int year { get; set; }
        public int month { get; set; }
        public int day { get; set; }

        //Инициализация числами
        protected Triad(int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }

        //Инициализация строкой
        protected Triad(string st)
        {
            string[] mas = st.Split('.');
            this.year = int.Parse(mas[0]);
            this.month = int.Parse(mas[1]);
            this.day = int.Parse(mas[2]);
        }

        //Инициализация датой
        protected Triad(DateTime dt)
        {
            this.year = dt.Year;
            this.month = dt.Month;
            this.day = dt.Day;
        }

        //Метод инкремента
        public abstract int inc();
    }
}
