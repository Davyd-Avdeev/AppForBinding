using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace AppForBinding.View
{
    class BindingObject
    {
        private CheckBox chkSelect {  get; set; }
        private ComboBox cmbAction { get; set; }
        private TextBox txbAddinationInfo { get; set; }
        private TextBox button { get; set; }
        private ComboBox cbxState { get; set; }
        public StackPanel stackPanel { get; set; }

        public BindingObject()
        {
            chkSelect = new CheckBox();
            chkSelect.Margin = new Thickness(5, 0, 5, 0);
            cmbAction = new ComboBox();
            cmbAction.Width = 140;
            cmbAction.Height = 25;
            cmbAction.Margin = new Thickness(5, 0, 5, 0);
            txbAddinationInfo = new TextBox();
            txbAddinationInfo.Width = 140;
            txbAddinationInfo.Height = 25;
            txbAddinationInfo.Margin = new Thickness(5, 0, 5, 0);
            button = new TextBox();
            button.Width = 140;
            button.Height = 25;
            button.Margin = new Thickness(5, 0, 5, 0);
            cbxState = new ComboBox();
            cbxState.Width = 140;
            cbxState.Height = 25;
            cbxState.Margin = new Thickness(5, 0, 5, 0);
            stackPanel = new StackPanel();
            stackPanel.Orientation = Orientation.Horizontal;
            stackPanel.HorizontalAlignment = HorizontalAlignment.Left;
            stackPanel.VerticalAlignment = VerticalAlignment.Top;
            stackPanel.Margin = new Thickness(0, 10, 0, 0);

            stackPanel.Children.Add(chkSelect);
            stackPanel.Children.Add(cmbAction);
            stackPanel.Children.Add(txbAddinationInfo);
            stackPanel.Children.Add(button);
            stackPanel.Children.Add(cbxState);
        }

        public void IncreaseWidthAction()
        {
            cmbAction.Width = 400;
        }

        public bool? IsChecked()
        {            
            return chkSelect.IsChecked;
        }

    }
}
