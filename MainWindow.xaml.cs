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

        //Определение високосности 
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string date1 = DATE1.Text;
            Date d1 = new Date(date1);
            string result = d1.LeapYear(date1);
            OUTPUT.Text += result + Environment.NewLine;
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
    }
}
