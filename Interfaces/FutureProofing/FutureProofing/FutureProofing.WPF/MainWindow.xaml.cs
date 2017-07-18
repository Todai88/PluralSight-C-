using FutureProofing.BL;
using FutureProofing.BL.Repositories;
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

namespace FutureProofing.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PersonRepository personRepository = new PersonRepository();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Concrete_Click(object sender, RoutedEventArgs e)
        {
            ClearListBox();
            var people = personRepository.GetPeople();
            //people.ForEach(x => lbox_PersonList.Items.Add(x));
            lbox_PersonList.ItemsSource = people;
        }

        private void btn_Interface_Click(object sender, RoutedEventArgs e)
        {
            ClearListBox();
            IEnumerable<Person> people = personRepository.GetPeople();
            lbox_PersonList.ItemsSource = people;
        }

        private void btn_ClearData_Click(object sender, RoutedEventArgs e)
        {
            ClearListBox();
        }

        private void ClearListBox()
        {
            lbox_PersonList.ItemsSource = null; 
        }
    }
}
