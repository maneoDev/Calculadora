using System;
using System.Data;
using System.Windows;
using System.Windows.Data;
using System.Windows.Controls;

namespace Calculadora
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            Input.Text += button.Content.ToString();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            Input.Text = string.Empty;
            Resultado.Content = string.Empty;
        }

        private void Calcular_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var resultado = new DataTable().Compute(Input.Text, null);
                Resultado.Content = "Resultado: " + Convert.ToSingle(resultado);
            }
            catch (Exception ex)
            {
                Resultado.Content = "Error: " + ex.Message;
            }
        }
    }
}
