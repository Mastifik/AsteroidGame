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


namespace ListWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
        ObservableCollection<Department> departments = new ObservableCollection<Department>();
        Department programmer = new Department(nameof(programmer));
        Department game_desinger = new Department(nameof(game_desinger));
        Department concept_art = new Department(nameof(concept_art));
        

        public MainWindow()
        {
            InitializeComponent();
            List();
        }

        private void List()
        {
            departments.Add(programmer);
            departments.Add(game_desinger);
            departments.Add(concept_art);
            employees.Add(new Employee("Евгений", "Рогов", 30, 1, programmer));
            employees.Add(new Employee("Борис", "Кузнецов", 28, 2, programmer));
            employees.Add(new Employee("Иван", "Митрофанов", 27, 3, concept_art));
            employees.Add(new Employee("Николай", "Белов", 30, 4, game_desinger));
            lbEmployees.ItemsSource = employees;
            lbDepartments.ItemsSource = departments;
        }

        private void lbEmployees_SelectionChanged(object sender,
            System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }

        private void lbDepartments_SelectionChanged(object sender,
            System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }
    }
}
