using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace Jint.Phone.Demo
{
    public partial class MainPage : PhoneApplicationPage
    {
        JintEngine engine;

        // Constructor
        public MainPage()
        {
            InitializeComponent();

            engine = new JintEngine();
            engine.SetFunction("alert", new Action<string>(t => MessageBox.Show(t)));
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            /* This is a terrible example of how to write
             * Silverlight, the focus is not on that, but on how to use Jint.
             * Please use MVVM in your own projects
             * */

            string name = userName.Text;

            engine.Run("alert('Hello "+ name +", from dynamically interpereted JavaScript on WP7!')");

        }
    }
}