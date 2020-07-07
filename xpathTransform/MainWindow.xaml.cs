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
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace xpathTransform
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

        private void generateXpath_Click(object sender, RoutedEventArgs e)
        {

            var str1 = this.xpath1.Text;
            if(str1 == "将你的xpath复制到这里")
            {
                return;
            } else
            {
                Match match = Regex.Match(str1, @"/Window.*");
                var a = match.ToString();
                str1 = string.Join("'", a.Split("\\\""));
                if (Regex.IsMatch(str1, @"/Window") == false)
                {
                    this.xpath2.Text = "这不是个有效的xpath";
                    return;
                }
                this.xpath2.Text = "\"" + str1;
            }
        }

        private void generateXpath_Click_1(object sender, RoutedEventArgs e)
        {

            Clipboard.SetText(this.xpath2.Text);
        }
    }
}
