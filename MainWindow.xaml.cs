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
        static Assembly ClassesAssembly;
        static List<Type> ClassesTypesLib = new List<Type>();
        static int offset = 1; 
        public MainWindow()
        {
            InitializeComponent();
        }

        private void App_Loaded(object sender, RoutedEventArgs e)
        {
           
            ClassesAssembly = Assembly.LoadFile(@"D:\УНИК\4 сем\OOP\Lab_2\classes\class_library\bin\Debug\class_library.dll");
            ClassesTypesLib = ClassesAssembly.GetTypes().Where(type => type.IsClass).ToList();

            foreach (var currentClass in ClassesTypesLib)
            {
                if (!currentClass.IsAbstract)
                    cmbClasses.Items.Add(currentClass.Name);
            }            

            if (cmbClasses.Items.Count > 0)
            {
                cmbClasses.SelectedIndex = 0;
            }



        }

        int index = 0;
        public void AddFieldsToObject (object obj, Type currentClass)
        {
            var properties = currentClass.GetProperties();
            
            foreach (var property in properties)
            {
                if (property.PropertyType == typeof(int))
                {
                    try
                    {
                        property.SetValue(obj, Int32.Parse(((TextBox)pnlBlocks.Children[index]).Text));
                    }
                    catch
                    {
                        //show message
                    }
                    
                }

                else if (property.PropertyType == typeof(String))
                {
                    try
                    {
                        property.SetValue(obj, ((TextBox)pnlBlocks.Children[index]).Text);
                    }
                    catch
                    {
                        //s msg
                    }
                }

                else if (property.PropertyType == typeof(char))
                {
                    try
                    {
                        property.SetValue(obj, Char.Parse(((TextBox)pnlBlocks.Children[index]).Text));
                    }
                    catch
                    {
                        //s msg
                    }
                }


                else if (property.PropertyType.IsEnum)
                {
                    try
                    {
                        property.SetValue(obj,((ComboBox)pnlBlocks.Children[index]).SelectedIndex);
                    }
                    catch
                    {
                        //s msg
                    }
                }

                else if (property.PropertyType.IsClass)
                {
                    index++;
                    AddFieldsToObject(obj, property.PropertyType);
                    index--;
                }

                index++;

            }

        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {

            var currentClassName = cmbClasses.SelectedItem.ToString();

            foreach (var currentClass in ClassesTypesLib)
            {
                if (currentClassName == currentClass.Name)
                {
                    var newWorker = ClassesAssembly.CreateInstance(currentClass.FullName);
                    if (! (newWorker == null))
                    {
                        AddFieldsToObject(newWorker,currentClass);       
                    }


                }
            }
            //pnlBlocks.Children.Clear(); 
        }

        private void CreateFieldsOnForm(Type currentClass, int leftMargin)
        {
            var properties = currentClass.GetProperties();
            foreach (var property in properties)
            {
                if ((property.PropertyType.IsPrimitive)
                    || (property.PropertyType == typeof(String)))
                {
                    pnlBlocks.Children.Add
                    (new TextBox()
                    { Margin = new Thickness(leftMargin, 5 * offset, 0, 0), Name = "TextBox" + property.Name, Text = property.Name }
                    );
                }

                else if (property.PropertyType.IsEnum)
                {
                    var newComboBox = new ComboBox();
                    newComboBox.Margin = new Thickness(leftMargin, 5*offset, 0, 0);
                    newComboBox.Name = "ComboBox" + property.Name;
                    newComboBox.Text = property.Name;

                    foreach (var enumName in property.PropertyType.GetEnumNames())
                        newComboBox.Items.Add(enumName);

                    newComboBox.SelectedIndex = 0;

                    pnlBlocks.Children.Add(newComboBox);
                }

                else if (property.PropertyType.IsClass) 
                {
                    pnlBlocks.Children.Add(new System.Windows.Controls.Label()
                    {
                        Content = property.PropertyType.Name,
                        Margin = new Thickness(leftMargin, 5 * offset, 0, 0),
                        
                    }) ;
                    offset++;
                    CreateFieldsOnForm(property.PropertyType, leftMargin + 15);

                }
                
                offset++;

            }
        }


        private void CmbClasses_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var currentClassName = cmbClasses.SelectedItem.ToString();

            foreach (var currentClass in ClassesTypesLib)
            {
                if (currentClassName == currentClass.Name)
                {
                    offset = 1;
                    CreateFieldsOnForm(currentClass, 20);
                    //var newWorker = ClassesAssembly.CreateInstance(currentClass.FullName);
                    break;                     
                    
                   
                }
            }

        }
    }
}
