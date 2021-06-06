using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Date : Triad
    {

        //Вычисление даты через заданное количество дней
        //Вычитание заданного количества дней из даты
        //Определение високосности года
        //Присвоение и получение отдельных частей(год, месяц, день)
        //Сравнение дат(равно, до, после)
        //Вычисление количества дней между датами

        public int year { get; set; }
        public int month { get; set; }
        public int day { get; set; }
        public Date(int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }

        public Date(string st) 
        {
            string[] mas = st.Split('.');
            this.year = int.Parse(mas[0]);
            this.month = int.Parse(mas[1]);
            this.day = int.Parse(mas[2]);
        }

        public Date(DateTime dt) 
        {
            this.year = dt.Year;
            this.month = dt.Month;
            this.day = dt.Day;
        }

        public override int inc()
        {
            return this.day += 1; 
        }
        //Определение високосности 
        public string LeapYear(string st)
        {
            string[] mas = st.Split('.');
            this.year = int.Parse(mas[0]);
            this.month = int.Parse(mas[1]);
            this.day = int.Parse(mas[2]);

            int year = int.Parse(mas[0]);
            if((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0))
            {
                return "Високосный год";
            } 
            else
            {
                return "Невисокосный год";
            }
        }
        //Присвоение и получение отдельных частей(год, месяц, день)
        public string AssigningAndReceivingIndividualParts(string st)
        {
            string[] mas = st.Split('.');
            this.year = int.Parse(mas[0]);
            this.month = int.Parse(mas[1]);
            this.day = int.Parse(mas[2]);

            //Обработка исключений
            if((year < 0 || year == 0) && (month > 12 || month < 0 || month == 0) && (day > 31 || day < 0 || day == 0))
            {
                throw new Exception("Вы неправильно ввели ВСЁ!");
            }
            if ((month > 12 || month < 0 || month == 0) && (day > 31 || day < 0 || day == 0))
            {
                throw new Exception("Вы неправильно ввели и месяц и день!");
            }
            if((year < 0 || year == 0) && (day > 31 || day < 0 || day == 0))
            {
                throw new Exception("Вы неправильно ввели год и день!");
            }
            if((year < 0 || year == 0) && (month > 12 || month < 0 || month == 0))
            {
                throw new Exception("Вы неправильно ввели год и месяц!");
            }
            if(year < 0 || year == 0)
            {
                throw new Exception("Вы неправильно ввели год!");
            }
            if (month > 12 || month < 0 || month == 0)
            {
                throw new Exception("Вы неправильно ввели месяц!");
            }
            if (day > 31 || day < 0 || day == 0)
            {
                throw new Exception("Вы неправильно ввели день!");
            }
            else
            {
                string result = "Год: " + mas[0] + " Месяц: " + mas[1] + " День: " + mas[2];
                return result;
            }
        }

        //Сравнение дат(равно, до, после)
        public string CompareDates(DateTime date1, DateTime date2) 
        {
            if(date1 == date2)
            {
                return "Даты равны";
            }
            if(date1  < date2)
            {
                return "<";
            }
            else
            {
                return ">";
            }
        }

        //Вычисление количества дней между датами
        public int NumberOfDaysBetweenDates(DateTime d1, DateTime d2)
        {
            int result = (d2 - d1).Days;
            return result;
        }

        //Вычитание заданного количества дней из даты
        public DateTime SubtractinFromTheDate(DateTime dt, double days)
        {
            DateTime res = dt.AddDays(-days);
            return res;
        }

        public DateTime CalculatingTheDAteAfterAGivenNumberOfDays(DateTime dt, double days)
        {
            DateTime res = dt.AddDays(days);
            return res;
        }
    }
}
