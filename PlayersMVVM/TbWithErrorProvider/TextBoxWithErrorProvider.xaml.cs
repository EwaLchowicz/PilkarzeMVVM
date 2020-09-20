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

namespace PlayersMVVM.TbWithErrorProvider
{
    /// <summary>
    /// Logika interakcji dla klasy TextBoxWithErrorProvider.xaml
    /// </summary>
    public partial class TextBoxWithErrorProvider : UserControl
    {

        public string ToolTipText { get; set; } = "Uzupełnij dane";
        public TextBoxWithErrorProvider()
        {
            InitializeComponent();
        }
        /// <param name="errorText"></param>
        public void SetError(string errorText)
        {
            textBlockToolTip.Text = errorText;


            if (textBox.Text == "")
            {
                toolTip.Visibility = Visibility.Visible;
                this.IsNotEmpty = false;
            }
            else
            {
                toolTip.Visibility = Visibility.Hidden;
                this.IsNotEmpty = true;
            }
        }
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextChanged(object sender, TextChangedEventArgs e)
        {
            SetError(ToolTipText);
        }
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxFocus(object sender, RoutedEventArgs e)
        {
            SetError(ToolTipText);
        }

        public static readonly DependencyProperty TextProperty =
       DependencyProperty.Register(
          "Text",
          typeof(string),
          typeof(TextBoxWithErrorProvider),
          new FrameworkPropertyMetadata(null));

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public static readonly DependencyProperty IsNotEmptyProperty =
       DependencyProperty.Register(
          "IsNotEmpty",
          typeof(bool),
          typeof(TextBoxWithErrorProvider),
          new FrameworkPropertyMetadata(null));

        public bool IsNotEmpty
        {
            get { return (bool)GetValue(IsNotEmptyProperty); }
            set { SetValue(IsNotEmptyProperty, value); }
        }

        private void textBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            textBox.Text = string.Empty;
        }
    }
}
