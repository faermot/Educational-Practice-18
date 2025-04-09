using ConsoleApp23.Utils;
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
using WpfApp20.Pages;

namespace WpfApp20
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MainFrame.Navigate(new TasksPage(1, Task1.Calculate));
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown(); // Закрытие приложения
        }

        private void OpenTask1(object sender, MouseButtonEventArgs e)
        {
            MainFrame.Navigate(new TasksPage(1, Task1.Calculate));
        }

        private void OpenTask2(object sender, MouseButtonEventArgs e)
        {
            MainFrame.Navigate(new TasksPage(2, Task2.Calculate));
        }

        private void OpenTask3(object sender, MouseButtonEventArgs e)
        {

        }

        private void OpenTask4(object sender, MouseButtonEventArgs e)
        {

        }

        private void OpenTask5(object sender, MouseButtonEventArgs e)
        {

        }

        private void OpenTask6(object sender, MouseButtonEventArgs e)
        {

        }

        private void OpenTask7(object sender, MouseButtonEventArgs e)
        {

        }

        private void OpenTask8(object sender, MouseButtonEventArgs e)
        {

        }

        private void OpenTask9(object sender, MouseButtonEventArgs e)
        {

        }

        private void OpenTask10(object sender, MouseButtonEventArgs e)
        {

        }

        private void OpenTask11(object sender, MouseButtonEventArgs e)
        {

        }

        private void OpenTask12(object sender, MouseButtonEventArgs e)
        {

        }

        private void OpenTask13(object sender, MouseButtonEventArgs e)
        {

        }

        private void OpenTask14(object sender, MouseButtonEventArgs e)
        {

        }

        private void OpenTask15(object sender, MouseButtonEventArgs e)
        {

        }

        private void OpenTask16(object sender, MouseButtonEventArgs e)
        {

        }

        private void OpenTask17(object sender, MouseButtonEventArgs e)
        {

        }

        private void OpenTask18(object sender, MouseButtonEventArgs e)
        {

        }

        private void OpenTask19(object sender, MouseButtonEventArgs e)
        {
        }

        private void OpenTask20(object sender, MouseButtonEventArgs e)
        {

        }

        private void OpenTask21(object sender, MouseButtonEventArgs e)
        {

        }

        private void OpenTask22(object sender, MouseButtonEventArgs e)
        {

        }

        private void OpenTask23(object sender, MouseButtonEventArgs e)
        {

        }

        private void OpenTask24(object sender, MouseButtonEventArgs e)
        {

        }

        private void OpenTask25(object sender, MouseButtonEventArgs e)
        {

        }

        private void OpenTask26(object sender, MouseButtonEventArgs e)
        {

        }

        private void OpenTask27(object sender, MouseButtonEventArgs e)
        {

        }

        private void OpenTask28(object sender, MouseButtonEventArgs e)
        {

        }

        private void OpenTask29(object sender, MouseButtonEventArgs e)
        {

        }

        private void OpenTask30(object sender, MouseButtonEventArgs e)
        {

        }

        private void DockPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);

            this.DragMove();
        }
    }
}
