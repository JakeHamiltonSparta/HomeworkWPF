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
using System.Windows.Shapes;

namespace GameSelectForm
{
    /// <summary>
    /// Interaction logic for RobbersStartForm.xaml
    /// </summary>
    public partial class RobbersStartForm : Window
    {
        public RobbersStartForm()
        {
            InitializeComponent();
        }

        private void RobbersStartButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Game not made yet!");
        }
    }
}
