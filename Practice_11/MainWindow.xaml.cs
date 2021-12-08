using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Practice_11
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

        private void FindFirstLine_Click(object sender, RoutedEventArgs e)
        {
            result.Items.Clear();
            string phrase = firstPhrase.Text;
            Regex regex = new Regex(@"a(b{4,})a");
            MatchCollection match = regex.Matches(phrase);
            object[] array = new object[match.Count];
            match.CopyTo(array, 0);
            for (int i = 0; i < match.Count; i++)
            {
                result.Items.Add(match[i]);
            }
        }

        private void FindSecondLine_Click(object sender, RoutedEventArgs e)
        {
            result.Items.Clear();
            string phrase = secondPhrase.Text;
            Regex regex = new Regex(@"a\Db");
            MatchCollection match = regex.Matches(phrase);
            object[] array = new object[match.Count];
            match.CopyTo(array, 0);
            for (int i = 0; i < match.Count; i++)
            {
                result.Items.Add(match[i]);
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" Золотарев М. А.\n Группа: ИСП-34\n Вариант №13", "Разработчик", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
