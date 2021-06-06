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
        public abstract int inc();
    }
}
