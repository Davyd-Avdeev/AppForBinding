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
        public BindingPage()
        {
            InitializeComponent();

            ContentControl cc = new ContentControl();
            cc.Style = (Style)this.TryFindResource("bindingObjectStyle");
            stPanel.Children.Add(cc);

            
        }
    }
}
