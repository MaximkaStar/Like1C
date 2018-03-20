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

namespace Like1C
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> subjects;
        public MainWindow(List<string> subject)
        {
            InitializeComponent();
            subject = new List<string>();
            foreach (string i in subject)
            {
                ListSubjects.Items.Add(i);
            }

        }
        public MainWindow()
        {
           InitializeComponent();
           subjects = new List<string>();
        }

        private void AddClick(object sender, RoutedEventArgs e)
        {

            for (int i = 0; i < ListSubjects.Items.Count; i++)
            {
                subjects.Add((string)ListSubjects.Items[i]);
            }
            if (subjects.Count != 0)
            {
                new AddSubject(subjects).Show();
            }
            else
            {
                new AddSubject().Show();
            }
        }
    }
}
