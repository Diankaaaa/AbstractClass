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
        }

        public Date(DateTime dt) : base(dt)
        {
        }

        public override int inc()
        {
            return day++;
        }
    }
}
