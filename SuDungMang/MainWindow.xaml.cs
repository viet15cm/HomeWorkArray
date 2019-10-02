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

namespace SuDungMang
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        int sum(int [] array)
        {
            
            int tong = 0;
            for (int i = 0; i < array.Length; i++)
            {
                tong = tong + array[i];
            }
                

            return tong;
        }

        int sumEven(int [] array)
        {
            int tongLe = 0;
            for(int i=0; i< array.Length; i++)
            {
                if(array[i]%2!=0)
                tongLe += array[i];
            }

            return tongLe;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int [] array =  { 7, 5, 6, 9 , 3};

            txbKetQua.Text = sum(array).ToString();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int[] array = { 7, 5, 6, 9, 3 };

            txbKetQua.Text = sumEven(array).ToString();
        }
    }
}
