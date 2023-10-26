using Animal_Info.BD;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Configuration;
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

namespace Animal_Info.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddPhotoMenu.xaml
    /// </summary>
    public partial class AddPhotoMenu : Page
    {
        public AddPhotoMenu()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Animal animals = new Animal();
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "*.png|*.png|*.jpeg|*.jpeg|*.jpg|*.Jpg"
            };
            if (openFileDialog.ShowDialog().GetValueOrDefault())
            {
                animals.Photo = File.ReadAllBytes(openFileDialog.FileName);
                .Source = new BitmapImage(new Uri(openFileDialog.FileName));

                App.BD.Animal.Add(animals);
                App.BD.SaveChanges();
            }
        }
    }
}
