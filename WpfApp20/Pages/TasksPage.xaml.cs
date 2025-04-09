using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp20.Pages
{
    public partial class TasksPage : Page
    {
        private int _number;
        private Func<string, string> _taskCalculate;

        public TasksPage(int number, Func<string, string> taskCalculate)
        {
            InitializeComponent();

            _number = number;
            _taskCalculate = taskCalculate;

            TaskNumberTextBlock.Text = $"Задача №{_number}";
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string result = _taskCalculate(InputLine.Text);
                ResultTextBlock.Text = $"Результат: {result}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}