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
using System.Windows.Shapes;

namespace Like1C
{
    /// <summary>
    /// Логика взаимодействия для AddSubject.xaml
    /// </summary>
    public partial class AddSubject : Window
    {
        private Subject subject;
        private List<string> subjects;
        public AddSubject()
        {
            InitializeComponent();
            subjects = new List<string>();
            subject = new Subject();
            BoxItem.Items.Add(TypeOfSubject.Add);
            BoxItem.Items.Add(TypeOfSubject.Remove);
        }

        public AddSubject(List<string> it)
        {
            InitializeComponent();
            subjects = new List<string>();
            foreach (string i in it)
            {
                subjects.Add(i);
            }
            subject = new Subject();
            BoxItem.Items.Add(TypeOfSubject.Add);
            BoxItem.Items.Add(TypeOfSubject.Remove);
        }

        public object CountSubject { get; private set; }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            if (BoxItem.SelectedItem == null || TextItem == null || CountItem == null)
            {
                MessageBox.Show("You write a incorrect values.");
            }
            else
            {
                Subject.Type = (TypeOfSubject)BoxItem.SelectedItem;
                subject.Name = TextItem.Text;
                subject.Count = CountSubject.Text;
                subjects.Add(subject.ToString());

                new MainWindow(subjects).Show();
               
            }
        }
    }
}
