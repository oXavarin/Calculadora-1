using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Boolean presionado, igual = false;
        string operation;
        double num1, num2;

        public MainWindow()
        {
            InitializeComponent();
            punto.Click += Punto_Click;

        }

        private void Punto_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Click(object sender, RoutedEventArgs e)
        {
            if (!presionado)
            {
                Display.Content = "";
                presionado = true;
            }
            Display.Content += (string)((Button)sender).Content;
        }

        private void n0_Click(object sender, RoutedEventArgs e)
        {
            if (!presionado)
            { 
                Display.Content = "0";
            }
            if (Display.Content.ToString() != "0")
            {
                Display.Content += "0";
            }
            else
            {
                Display.Content = "0";
            }
        }

        private void resultado_Click(object sender, RoutedEventArgs e)
        {
            if (!igual)
            {
                num2 = Convert.ToDouble(Display.Content);

            }
            igual = true;

            presionado = false;
            switch (operation)
            {
                case "+":
                    Display.Content = num1 + num2;
                    break;
                case "-":
                    Display.Content = num1 - num2;

                    break;
                case "*":
                    Display.Content = num1 * num2;

                    break;
                case "/":
                    Display.Content = num1 / num2;
                    break;
            }
            num1 = Convert.ToDouble(Display.Content);
        }
        /// ESTOU NESTA PARTE INCOMPLETO (no video 0.3 > 2)
        private void negativo_Click(object sender, RoutedEventArgs e)
        {
            Display.Content = (Convert.ToDouble(Display.Content) * -1).ToString();  
        }

        private void borrar_Click(object sender, RoutedEventArgs e)
        {
            presionado = false;
            igual = false;
            Display.Content = "0";
        }

        private void operacion(object sender, RoutedEventArgs e)
        {
            presionado = false;
            igual = false;
            num1 = Convert.ToDouble(Display.Content);
            operation = (string)((Button)sender).Content;
            Display.Content = "0";
        }

    }
}
