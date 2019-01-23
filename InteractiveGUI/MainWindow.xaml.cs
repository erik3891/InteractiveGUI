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

namespace InteractiveGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Label0.Content = Controller.GetInstance().PersonCount;
            Index.Content = Controller.GetInstance().PersonIndex;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Index.Content = Controller.GetInstance().PersonIndex;
            Label0.Content = Controller.GetInstance().PersonCount;
            Controller.GetInstance().DeletePerson();
            tekst1.Text = Controller.GetInstance().CurrentPerson.FirstName;
            tekst2.Text = Controller.GetInstance().CurrentPerson.LastName;
            tekst3.Text = Controller.GetInstance().CurrentPerson.Age.ToString();
            tekst3.Text = Controller.GetInstance().CurrentPerson.TelephoneNo;

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Controller.GetInstance().CurrentPerson.FirstName = tekst1.Text;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Index.Content = Controller.GetInstance().PersonIndex;
            Label0.Content = Controller.GetInstance().PersonCount;
            Controller.GetInstance().AddPerson();
            tekst1.Text = Controller.GetInstance().CurrentPerson.FirstName;
            tekst2.Text = Controller.GetInstance().CurrentPerson.LastName;
            tekst3.Text = Controller.GetInstance().CurrentPerson.Age.ToString();
            tekst4.Text = Controller.GetInstance().CurrentPerson.TelephoneNo;

            DP.IsEnabled = true;
            UP.IsEnabled = true;
            DOWN.IsEnabled = true;
            tekst1.IsEnabled = true;
            tekst2.IsEnabled = true;
            tekst3.IsEnabled = true;
            tekst4.IsEnabled = true;
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            Controller.GetInstance().CurrentPerson.LastName = tekst2.Text;
        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {
            if (tekst3.Text == "" )
            {
                Controller.GetInstance().CurrentPerson.Age = 0;
            }
            else
            {
                Controller.GetInstance().CurrentPerson.Age = Int32.Parse(tekst3.Text);
            }
            //Controller.GetInstance().CurrentPerson.Age = Int32.Parse(tekst3.Text);
        }

        private void TextBox_TextChanged_3(object sender, TextChangedEventArgs e)
        {
            Controller.GetInstance().CurrentPerson.TelephoneNo = tekst4.Text;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Controller.GetInstance().NextPerson();
            tekst1.Text = Controller.GetInstance().CurrentPerson.FirstName;
            tekst2.Text = Controller.GetInstance().CurrentPerson.LastName;
            tekst3.Text = Controller.GetInstance().CurrentPerson.Age.ToString();
            tekst4.Text = Controller.GetInstance().CurrentPerson.TelephoneNo;

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Controller.GetInstance().PrevPerson();
            tekst1.Text = Controller.GetInstance().CurrentPerson.FirstName;
            tekst2.Text = Controller.GetInstance().CurrentPerson.LastName;
            tekst3.Text = Controller.GetInstance().CurrentPerson.Age.ToString();
            tekst4.Text = Controller.GetInstance().CurrentPerson.TelephoneNo;
        }
    }
}
