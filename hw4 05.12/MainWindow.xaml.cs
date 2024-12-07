using System;
using System.Windows;
using System.Windows.Controls;

namespace hw4_05._12
{
    public partial class main_window : Window
    {
        public main_window()
        {
            InitializeComponent();
        }
        private void button_click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                string button_name = button.Content.ToString(); 
                
                switch (button_name)
                {
                    case "Создать":
                        MessageBox.Show("Кнопка 'Создать' нажата");
                        break;
                    case "Изменить":
                        MessageBox.Show("Кнопка 'Изменить' нажата");
                        break;
                    default:
                        break;
                }
            }
        }
    }
}