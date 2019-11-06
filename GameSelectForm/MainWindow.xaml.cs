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

namespace GameSelectForm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string gameName;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void GameButton_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            gameName = (string)btn.Content;
            switch (gameName)
            {
                case "Guild Master":
                    GuildMaster gm = new GuildMaster();
                    gm.Show();
                    this.Close();
                    break;

                case "Robbers":
                    RobbersStartForm rb = new RobbersStartForm();
                    rb.Show();
                    this.Close();
                    break;

                case "Turtle Game":
                    TurtleGameStartForm tg = new TurtleGameStartForm();
                    tg.Show();
                    this.Close();
                    break;
            }
        }
    }
}
