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

namespace Практика_3
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



        private void StudentDataGrid_Click(object sender, RoutedEventArgs e)
        {
            string studentName = StudentNameTextBox.Text;
            string ageName = StudentAgeTextBox.Text;
            string credniball = StudentCredniBallTextBox.Text;

            Students.Add(new Student
            {
                StudentName = studentName,
                AgeName = ageName,
                CredniBall = credniball,
            });

            StudentNameTextBox.Clear();
            StudentAgeTextBox.Clear();
            StudentCredniBallTextBox.Clear();

        }
    }
    public class Student
    {
        public string StudentName { get; set; }
        public string AgeName { get; set; }
        public string CredniBall { get; set; }
    }
}



