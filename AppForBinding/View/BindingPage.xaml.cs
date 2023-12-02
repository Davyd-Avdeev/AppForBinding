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

namespace AppForBinding.View
{
    /// <summary>
    /// Логика взаимодействия для BindingPage.xaml
    /// </summary>
    public partial class BindingPage : Page
    {
        List<BindingObject> objectsList = new List<BindingObject>();
        public BindingPage()
        {
            InitializeComponent();            

            for (int i = 0; i < 4; i++)
            {
                BindingObject bindingField = new BindingObject();
                objectsList.Add(bindingField);

                generalStackPanel.Children.Add(bindingField.stackPanel);
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int count = 0;
            for (int i = objectsList.Count - 1; i >= 0; i--)
            {
                if (objectsList[i].IsChecked() == true) 
                {
                    count++;
                } 
            }

            MessageBox.Show(count.ToString());
            count = 0;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            for (int i = objectsList.Count - 1; i >= 0; i--)
            {
                if (objectsList[i].IsChecked() == true)
                {
                    generalStackPanel.Children.Remove(objectsList[i].stackPanel);
                    objectsList.Remove(objectsList[i]);
                }
            }
        }
    }
}
