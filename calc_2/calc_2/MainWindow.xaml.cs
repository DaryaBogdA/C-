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

namespace calc_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double num_1 = 0;
        double num_2 = 0;
        string oper = "";
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btn_num_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string num = button.Content.ToString();
            if (text.Text == "0")
            {
                text.Text = num;
            }
            else
            {
                text.Text += num;
            }



            if (oper == "")
            {
                num_1 = Double.Parse(text.Text);
            }
            else
            {
                num_2 = Double.Parse(text.Text);
            }

            //if (oper == "")
            //{
            //    num_1 = num_1 * 10 + num;
            //    text.Text = num_1.ToString();
            //}
            //else
            //{
            //    num_2 = num_2 * 10 + num;
            //    text.Text = num_2.ToString();
            //}

        }
        

        private void btn_oper_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            oper = button.Content.ToString();
            text.Text = "0";
        }


        double rekurse(double num, int stepen)
        {
            if (stepen == 1) return num;
            if (stepen == 0) return 1;
            return num * rekurse(num, stepen - 1);
        }
        private void btn_result_Click(object sender, RoutedEventArgs e)
        {
            double result = 0;
            switch (oper)
            {
                case "+":
                    result = num_1 + num_2;
                    break;
                case "*":
                    result = num_1 * num_2;
                    break;
                case "-":
                    result = num_1 - num_2;
                    break;
                case "/":
                    result = num_1 / num_2;
                    break;
                case "min":
                    result = num_1 < num_2 ? num_1 : num_2;
                    break;
                case "max":
                    result = num_1 > num_2 ? num_1 : num_2;
                    break;
                case "pow":
                    result = rekurse(num_1, (int)num_2);
                    //result = Math.Pow(num_1, num_2);
                    break;
                case "avg":
                    result =(num_1 + num_1)/2;
                    break;
            }

            text.Text = result.ToString();
            oper = "";
            num_1 = result;
            num_2 = 0;
        }

        private void btn_C_Click(object sender, RoutedEventArgs e)
        {
            num_1 = 0;
            num_2 = 0;
            oper = "";
            text.Text = "0";
        }

        private void btn_CE_Click(object sender, RoutedEventArgs e)
        {
            if (oper == "")
            { 
                num_1 = 0; 
            }
            else
            {
                num_2 = 0;
            }
            text.Text = "0";
        }

        private void btn_backspace_Click(object sender, RoutedEventArgs e)
        {
            text.Text = drop_last_char(text.Text);
            if (oper == "")
            {
                num_1 = Double.Parse(text.Text);
            }
            else
            {
                num_2 = Double.Parse(text.Text);
            }
        }

        private string drop_last_char(string text)
        {
            if(text.Length == 1)
            {
                text = "0";
            }
            else
            {
                text = text.Remove(text.Length - 1, 1);
                if (text[text.Length - 1] == ',')
                {
                    text = text.Remove(text.Length - 1, 1);
                }
            }
            return text;
        }

        private void btn_minu_Click(object sender, RoutedEventArgs e)
        {
            if (oper == "")
            {
                num_1 *= -1;
                text.Text = num_1.ToString();
            }
            else
            {
                num_2 *= -1;
                text.Text = num_2.ToString();
            }
        }

        private void btn_tochka_Click(object sender, RoutedEventArgs e)
        {
            if(oper == "")
            {
                set_tochka(num_1);
            }
            else
            {
                set_tochka(num_2);
            }
        }

        private void set_tochka(double num_1)
        {
            if (text.Text.Contains(',')) return;
            text.Text += ",";
        }
    }
}
