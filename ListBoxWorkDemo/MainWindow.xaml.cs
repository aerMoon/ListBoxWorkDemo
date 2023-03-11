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

namespace ListBoxWorkDemo
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, RoutedEventArgs e) //добавление в список
        {
            string data = mainTextBox.Text; //получение строки, содержащейстя в текстбоксе
            if ( data != "") // если в текст боксе было что то (не пустая строка)
            {
                mainListBox.Items.Add(data); // то добавляем это содержимое в качестве нового элемента лист бокса
            }
            mainTextBox.Clear(); // очищаем текст бокс для нового ввода
        }

        private void delButton_Click(object sender, RoutedEventArgs e) //удаление из списка
        {
            // SelectedItem - это ткущий выбранный элемент в списке. компилятор сам за вас его найдет если он есть
            try
            {
                mainListBox.Items.Remove(mainListBox.SelectedItem); // удаление выбранного  элемента
            }
            catch(Exception ex)
            { Console.WriteLine(ex.Message); }
        }

        private void mainListBox_SelectionChanged(object sender, SelectionChangedEventArgs e) //обработка смены выбранного элемента
            //именно с помощью этого метода вы будете менять содержимое своих тексбоксов в зависимости от выбранного имени файла в ПЗ
        {
           
                MessageBox.Show($"вы выбрали элемент: {mainListBox.SelectedItem}");
        }

       
    }
}
