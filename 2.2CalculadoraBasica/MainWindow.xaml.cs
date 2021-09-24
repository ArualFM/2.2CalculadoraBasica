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

namespace _2._2CalculadoraBasica
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string operador;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int operador1 = int.Parse(Operador1TextBox.Text);
            int operador2 = int.Parse(Operador2TextBox.Text);
            int resultado =0;

            switch (operador)
            {
                case "+":
                    resultado = operador1 + operador2;
                    ResultadoTextBox.Text = resultado.ToString();
                    break;
                case "-":
                    resultado = operador1 - operador2;
                    ResultadoTextBox.Text = resultado.ToString();
                    break;
                case "*":
                    resultado = operador1 * operador2;
                    ResultadoTextBox.Text = resultado.ToString();
                    break;
                case "/":

                    if (operador1 !=0 && operador2 != 0)
                    {
                        ResultadoTextBox.Text = resultado.ToString();
                        
                    }
                   else
                    {
                        MessageBox.Show("No se puede introducir un 0 para la división en ningun operador"); 
                    }
                  
                    break;
                default:
                    break;
            }
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            operador = OperadorTextBox.Text;
            switch (operador)
            {
                case "+":
                case "-":
                case "*":
                case "/":
                    CalcularBoton.IsEnabled = true;
                    break;
                default:
                    CalcularBoton.IsEnabled = false;
                    break;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Operador1TextBox.Clear();
            Operador2TextBox.Clear();
            OperadorTextBox.Clear();
            ResultadoTextBox.Clear();

        }

       
    }
}
