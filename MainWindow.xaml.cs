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
using System.Reflection;
using System.Reflection.Emit;

namespace Lab_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        static List<object> workers = new List<object>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void App_Loaded(object sender, RoutedEventArgs e)
        {
            Assembly ClassesAssembly;
            ClassesAssembly = Assembly.LoadFile(@"D:\УНИК\4 сем\OOP\Lab_2\classes\class_library\bin\Debug\class_library.dll");
            var ClassesTypesLib = ClassesAssembly.GetTypes().Where(type => type.IsClass).ToList();

            foreach (var currentClass in ClassesTypesLib)
            {
                cmbClasses.Items.Add(currentClass.Name);
            }            

            if (cmbClasses.Items.Count > 0)
            {
                cmbClasses.SelectedIndex = 0;
            }
        }
    }
}
