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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Student> Students { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Students = new List<Student>();
            StudentsDataGrid.ItemsSource = Students;

        }
        public class Student
        {
            public string NameStudent { get; set; }
            public string AgeStudent { get; set; }
            public string BallStudent { get; set; }
        }

        private void AddStudentButton_Click(object sender, RoutedEventArgs e)
        {
            string namestudent = NameStudentTextBox.Text;
            string agestudent = AgeStudentTextBox.Text;
            string ballstudent = BallStudentTextBox.Text;

            Students.Add(new Student
            {
                NameStudent = namestudent,
                AgeStudent = agestudent,
                BallStudent = ballstudent,
            });
            NameStudentTextBox.Clear();
            AgeStudentTextBox.Clear();
            BallStudentTextBox.Clear();

        }
    }
}
