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
    /// Interaction logic for GuildMaster.xaml
    /// </summary>
    public partial class GuildMaster : Window
    {
        public GuildMaster()
        {
            InitializeComponent();
        }

        private void GuildMasterButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Need to make the game first!");
        }
    }
}
