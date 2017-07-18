using PersonRepository.Interface;
using PersonRepository.Service;
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

namespace PeopleViewer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_GetFromService_Click(object sender, RoutedEventArgs e)
        {
            ClearListBox();

            IPersonRepository repository = new ServiceRepository();
            var people = repository.GetPeople().ToList();

            people.ForEach(person => lbox_People.Items.Add(person.FirstName));
            ShowRepositoryType(repository);

        }

        private void btn_GetFromCSV_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_GetFromSQL_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_ClearData_Click(object sender, RoutedEventArgs e)
        {
            ClearListBox();
        }

        private void ClearListBox()
        {
            lbox_People.Items.Clear();
        }

        private void ShowRepositoryType(IPersonRepository repository)
        {
            MessageBox.Show(string.Format("Repository Type:\n{0}", repository.GetType().ToString()));
        }
    }
}
