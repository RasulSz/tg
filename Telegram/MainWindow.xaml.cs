using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Telegram
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();
            DataContext = this;

        }

        private ObservableCollection<Human> People { get;set; } = new()
        {
            new Human(){Name="Rasul"},
            new Human(){Name="Amin"},
            new Human(){Name="Yura"},
        };

        private void send_Click(object sender, RoutedEventArgs e)
        {
                isent.ItemsSource = new List<string>()
            {
                text.Text,
                "",
            };
                text.Text = "";
                botsent.ItemsSource = new List<string>()
            {
                "",
                "Aleykum Salam"
            };
        }

    }
}
