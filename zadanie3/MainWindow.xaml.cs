using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string cifra,posled_text;
        double chislo;
        char simvolitog;
        bool simvol_est = false;
        public MainWindow()
        {
            InitializeComponent();
            //textbox2.Text = "-";
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        { char simv = textbox.Text[textbox.Text.Length - 1];
            if (simv != '+' && simv != '-' && simv != '/' && simv != '*' && simv != '^' && simv != '|')
            {
                cifra += simv;
            }
            else
            if (simvol_est == false)
            {
                switch (simv)
                {
                    case '+':
                        chislo = Convert.ToInt32(cifra);
                        cifra = "";
                        simvolitog = simv;
                        simvol_est = true;
                        break;
                    case '-':
                        chislo = Convert.ToInt32(cifra);
                        cifra = "";
                        simvolitog = simv;
                        simvol_est = true;
                        break;
                    case '/':
                        chislo = Convert.ToInt32(cifra);
                        cifra = "";
                        simvolitog = simv;
                        simvol_est = true;
                        break;
                    case '*':
                        chislo = Convert.ToInt32(cifra);
                        cifra = "";
                        simvolitog = simv;
                        simvol_est = true;
                        break;
                    case '^':
                        chislo = Convert.ToInt32(cifra);
                        cifra = "";
                        simvolitog = simv;
                        simvol_est = true;
                        break;
                    case '|': 
                        chislo = Convert.ToInt32(cifra);
                        cifra = "";
                        simvolitog = simv;
                        simvol_est = true;
                        break;

                }
            }
            else
            {
                textbox.Text = posled_text;
                textbox.SelectionStart = textbox.Text.Length;

            }
           
            posled_text = textbox.Text;


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            textbox.Text += '1';
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            textbox.Text += '2';
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            textbox.Text += '3';
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            textbox.Text += '4';
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            textbox.Text += '5';
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            textbox.Text += '6';
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            textbox.Text += '7';
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            textbox.Text += '8';
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            textbox.Text += '9';
        }

        private void Button_Click_0(object sender, RoutedEventArgs e)
        {
            textbox.Text += '0';
        }

        private void Button_Click_plus(object sender, RoutedEventArgs e)
        {
            textbox.Text += '+';
        }

        private void Button_Click_minus(object sender, RoutedEventArgs e)
        {
            textbox.Text += '-';
        }

        private void Button_Click_umn(object sender, RoutedEventArgs e)
        {
            textbox.Text += '*';
        }

        private void Button_Click_del(object sender, RoutedEventArgs e)
        {
            textbox.Text += '/';
        }

        private void Button_Click_stepen(object sender, RoutedEventArgs e)
        {
            textbox.Text += '^';
        }

        private void Button_Click_koren(object sender, RoutedEventArgs e)
        {
            textbox.Text += '|';
        }

        private void Button_Click_itog(object sender, RoutedEventArgs e)
        {
            if (simvol_est)
            {
                switch (simvolitog)
                {
                    case '+':
                        chislo += Convert.ToInt32(cifra);
                        cifra = "";
                        simvol_est = false;
                        break;
                    case '-':
                        chislo -= Convert.ToInt32(cifra);
                        cifra = "";
                        simvol_est = false;
                        break;
                    case '/':
                        chislo /= Convert.ToInt32(cifra);
                        cifra = "";
                        simvol_est = false;
                        break;
                    case '*':
                        chislo *= Convert.ToInt32(cifra);
                        cifra = "";
                        simvol_est = false;
                        break;
                    case '^':
                        chislo =Math.Pow(chislo,2);
                        cifra = "";
                        simvol_est = false;
                        break;
                    case '|':
                        chislo = Math.Sqrt(chislo);
                        cifra = "";
                        simvol_est = false;
                        break;
                }
                textbox2.Text = chislo.ToString();
                textbox.Text = " ";
                textbox.SelectionStart = textbox.Text.Length;
                simvol_est = false;
                cifra = "";
                simvolitog = ' ';
                chislo = 0;
            }
        }

        private void Button_Click_delet(object sender, RoutedEventArgs e)
        {
            textbox.Text = " ";
            textbox.SelectionStart = textbox.Text.Length;
            simvol_est = false;
            cifra = "";
            simvolitog = ' ';
            chislo = 0;
        }
    }
}
