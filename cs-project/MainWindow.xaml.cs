using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
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

namespace cs_project
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

        private async void FireBaseConnectionButton_Click(object sender, RoutedEventArgs e)
        {
            // Firebase config
            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = "7t74HzDu1QwwPPOqhYNhAXBedNnV3TpvcSrrwdwE",
                BasePath = "https://csharpdotnet-61e3e-default-rtdb.asia-southeast1.firebasedatabase.app/"
            };

            // Connect firebase
            IFirebaseClient client = new FirebaseClient(config);

            // Get data "name" from firebase
            FirebaseResponse response = await client.GetAsync("name");

            //Show data from Firebase
            string fullname = response.ResultAs<String>();
            MessageBox.Show(fullname);
        }
    }
}
