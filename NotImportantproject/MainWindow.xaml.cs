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

namespace NotImportantproject
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Mails_1> mails_s = new List<Mails_1>();
            mails_s.Add(new Mails_1() { Doks = Code.Text, school = school.Text, qual = qual.Text, spec = spec.Text });
            Grid.ItemsSource = mails_s;

        }
        public class Mails_1
        {
            public string Doks { get; set; }


            public string school { get; set; }

            public string qual { get; set; }
            public string spec { get; set; }

        }
    }
 }

