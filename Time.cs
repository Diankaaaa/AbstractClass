using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Time : Triad
    {
        //Вычисление разницы между двумя моментами времени в секундах
        //Сложение времени и заданного колиества секунд AddingTheTimeAndTheSpecifiedNumberOfSeconds
        //Вычитание из времени заданного количества секунд SubtracingSecondsFromTime
        //Сравнение моментов времени ComparisonOfTimePoints
        //Перевод в секунды TranslationInSeconds
        //Перевод в минуты(с округлением до целой минуты) TranslationInMinutes

        //Время Задание 1.30 Час:Минута:Секунда

        //Инициализация времени числами
        public int hour { get; set; }
        public int minute { get; set; }
        public int second { get; set; }
        public Time(int hour, int minute, int second) 
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }

        //Инициализация времени строкой
        public Time(string stTime) 
        {
            string[] mas = stTime.Split(':');
            this.hour = int.Parse(mas[0]);
            this.minute = int.Parse(mas[1]);
            this.second = int.Parse(mas[2]);
        }
        //Инициалзация времени секундами
        public Time(DateTime sec, int y)
        {
            this.second = sec.Second;
        }
        //Инициализация времени времемнем
        public Time(DateTime dtTime) 
        {
            this.hour = dtTime.Hour;
            this.minute = dtTime.Minute;
            this.second = dtTime.Second;
        }

        //Реализация абстрактного класса
        public override int inc()
        {
            return this.hour += 1;
        }

        //Вычисление разницы между двумя моментами времени в секундах
        public TimeSpan CalculatingDifferenceInSeconds(DateTime A, DateTime B)
        {
            TimeSpan diff = A - B;
            return diff;
        }

        //Сложение времени и заданного колиества секунд
        public DateTime AddingTheTimeAndTheSpecifiedNumberOfSeconds(DateTime a, double s)
        {
            DateTime res = a.AddSeconds(s);
            return res;
        }

        //Вычитание из времени заданного количества секунд SubtracingSecondsFromTime
        public DateTime SubtracingSecondsFromTime(DateTime d, double j)
        {
            DateTime res = d.AddSeconds(-j);
            return res;
        }

        //Сравнение моментов времени ComparisonOfTimePoints
        public string ComparisonOfTimePoints(DateTime time1, DateTime time2)
        {
            if (time1 == time2)
            {
                return "Время равно";
            }
            if (time1 < time2)
            {
                return "<";
            }
            else
            {
                return ">";
            }
        }

        //Перевод в секунды TranslationInSeconds
        public TimeSpan TranslationInSeconds(TimeSpan a)
        {
            double sec = TimeSpan.Parse(a.ToString()).TotalSeconds;
            TimeSpan ts = TimeSpan.Parse(sec.ToString());
            return ts;
            
        }

        //Перевод в минуты(с округлением до целой минуты)
        public TimeSpan TranslationInMinutes(TimeSpan a)
        {
            double sec = TimeSpan.Parse(a.ToString()).TotalMinutes;
            TimeSpan ts = TimeSpan.Parse(sec.ToString());
            return ts;

        }
    }
}
