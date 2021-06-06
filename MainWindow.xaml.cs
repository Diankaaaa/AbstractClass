using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AbstractClass
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //Открытие окна справки
        private void Reference_Click(object sender, RoutedEventArgs e)
        {
            Reference window = new Reference();
            window.ShowDialog();
        }

        //Очистить поле вывода
        private void CLEAR_Click(object sender, RoutedEventArgs e)
        {
            OUTPUT.Text = String.Empty;
        }

        //Вычисление даты через заданное количество дней
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            try
            {
                string d = DATE1.Text;
                double cd = double.Parse(KD.Text);

                Date dt = new Date(d);
                OUTPUT.Text += dt.CalculatingTheDAteAfterAGivenNumberOfDays(DateTime.Parse(d), cd) + Environment.NewLine;
            }
            catch (Exception ex)
            {
                OUTPUT.Text += ex.Message + Environment.NewLine;
            }
        }
        //Вычитание заданного количества дней из даты
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            try
            {
                string date1 = DATE1.Text;
                double kd = double.Parse(KD.Text);

                Date d1 = new Date(date1);
                OUTPUT.Text += d1.SubtractinFromTheDate(DateTime.Parse(date1), kd) + Environment.NewLine;
                
            }
            catch (Exception ex)
            {
                OUTPUT.Text += ex.Message + Environment.NewLine;
            }
        }

        //Определение високосности 
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                string date1 = DATE1.Text;
                Date d1 = new Date(date1);
                string result = d1.LeapYear(date1);
                OUTPUT.Text += result + Environment.NewLine;
            }
            catch (Exception ex)
            {
                OUTPUT.Text += ex.Message + Environment.NewLine;
            }
        }

        //Присвоение и получение отдельных частей(год, месяц, день)
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string date1 = DATE1.Text;
                Date d1 = new Date(date1);
                string res1 = d1.AssigningAndReceivingIndividualParts(date1);
                OUTPUT.Text += res1 + Environment.NewLine;
            }
            catch (Exception ex)
            {
                OUTPUT.Text+=ex.Message + Environment.NewLine;
            }
        }


        //Сравнение дат(равно, до, после)
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                string date1 = DATE1.Text;
                string date2 = DATE2.Text;

                Date d1 = new Date(date1);
                OUTPUT.Text += d1.CompareDates(DateTime.Parse(date1), DateTime.Parse(date2)) + Environment.NewLine;
            }
            catch (Exception ex)
            {
                OUTPUT.Text += ex.Message + Environment.NewLine;
            }
        }

        //Вычисление количества дней между датами
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {
                string date1 = DATE1.Text;
                string date2 = DATE2.Text;

                Date d1 = new Date(date1);
                OUTPUT.Text += d1.NumberOfDaysBetweenDates(DateTime.Parse(date1), DateTime.Parse(date2)) + Environment.NewLine;
            }
            catch (Exception ex)
            {
                OUTPUT.Text += ex.Message + Environment.NewLine;
            }
        }

        //Метод инкремента для даты
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            string d = DATE1.Text;
            Date dt = new Date(d);
            OUTPUT.Text += dt.inc() + Environment.NewLine;
        }


        //Реализация работы с временем

        //Вычисление разницы между двумя моментами времени в секундах
        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            try
            {
                string t1 = Time1.Text;
                string t2 = Time2.Text;
                Time t = new Time(t1);
                OUTPUT.Text += t.CalculatingDifferenceInSeconds(DateTime.Parse(t1), DateTime.Parse(t2)) + Environment.NewLine;
            }catch(Exception ex)
            {
                OUTPUT.Text += ex.Message + Environment.NewLine;
            }
        }


        //Сложение времени и заданного колиества секунд
        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            try
            {
                string t1 = Time1.Text;
                double cd = double.Parse(CD.Text);
                Time t = new Time(t1);
                OUTPUT.Text += t.AddingTheTimeAndTheSpecifiedNumberOfSeconds(DateTime.Parse(t1), cd) + Environment.NewLine;
            }
            catch(Exception ex)
            {
                OUTPUT.Text += ex.Message + Environment.NewLine;
            }
        }
        //Вычитание из времени заданного количества секунд
        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            try
            {
                string t1 = Time1.Text;
                double cd = double.Parse(CD.Text);
                Time t = new Time(t1);
                OUTPUT.Text += t.SubtracingSecondsFromTime(DateTime.Parse(t1), cd) + Environment.NewLine;
            }
            catch (Exception ex)
            {
                OUTPUT.Text += ex.Message + Environment.NewLine;
            }
        }

        //Сравнение моментов времени
        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            try
            {
                string t1 = Time1.Text;
                string t2 = Time2.Text;
                Time t = new Time(t1);
                OUTPUT.Text += t1 + t.ComparisonOfTimePoints(DateTime.Parse(t1), DateTime.Parse(t2)) + t2 + Environment.NewLine;
            }
            catch (Exception ex)
            {
                OUTPUT.Text += ex.Message + Environment.NewLine;
            }
        }

        //Перевод в секунды
        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            try
            {
                string t1 = Time1.Text;
                Time t = new Time(t1);
                OUTPUT.Text += t.TranslationInSeconds(TimeSpan.Parse(t1)) + Environment.NewLine;
            }
            catch (Exception ex)
            {
                OUTPUT.Text += ex.Message + Environment.NewLine;
            }
        }


        //Перевод в минуты
        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            try
            {
                string t1 = Time1.Text;
                Time t = new Time(t1);
                OUTPUT.Text += t.TranslationInMinutes(TimeSpan.Parse(t1)) + Environment.NewLine;
            }
            catch (Exception ex)
            {
                OUTPUT.Text += ex.Message + Environment.NewLine;
            }
        }

        //Метод инкремента
        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            string t1 = Time1.Text;
            Time t = new Time(t1);
            OUTPUT.Text += t.inc() + Environment.NewLine;
        }
    }
}
