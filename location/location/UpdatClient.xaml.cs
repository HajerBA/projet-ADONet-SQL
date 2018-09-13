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
using System.Diagnostics;
using System.Windows.Navigation;

namespace location
{
    /// <summary>
    /// Interaction logic for UpdatClient.xaml
    /// </summary>
    public partial class UpdatClient : UserControl
    {
        
        public UpdatClient()
        {
            InitializeComponent();
        }
        public void modifier()
        {
            LocationEntities context = new LocationEntities();
            Client clt = context.Client.Find(labelid.Text);
            
            clt.Nom = textNom.Text;
            context.SaveChanges();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            modifier();

        }

       
    }
}
