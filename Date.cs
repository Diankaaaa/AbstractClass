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


        public Date(int year, int month, int day) : base(year, month, day)
        {
        }

        public Date(string st) : base(st)
        {
            string[] mas = st.Split('.');
            this.year = int.Parse(mas[0]);
            this.month = int.Parse(mas[1]);
            this.day = int.Parse(mas[2]);
        }

        public Date(DateTime dt) : base(dt)
        {
        }

        public override int inc()
        {
            return day++; 
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
    }
}
