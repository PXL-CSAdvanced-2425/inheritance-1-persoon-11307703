using Persoon.Data;
using Persoon.Models;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Persoon
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

        private void btnLector_Click(object sender, RoutedEventArgs e)
        {
            itemListBox.Items.Clear();
            List<Lector> lectoren = FileImport.ReadLector("Lectoren.csv");
            foreach (Lector l in lectoren)
            {
                itemListBox.Items.Add(l);
            }
        }

        private void btnStudent_Click(object sender, RoutedEventArgs e)
        {
            itemListBox.Items.Clear();
            List<Student> student = FileImport.ReadStudent("Studenten.csv");
            foreach (Student s in student)
            {
                itemListBox.Items.Add(s);
            }
        }

        private void btnPersoon_Click(object sender, RoutedEventArgs e)
        {
            Person selectedPerson = itemListBox.SelectedItem as Person;
            selectedPerson.Email = txtEmail.Text;
            selectedPerson.Info(selectedPerson.Email);

        }
    }
}