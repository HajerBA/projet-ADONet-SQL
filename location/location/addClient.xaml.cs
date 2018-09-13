using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace location
{
    /// <summary>
    /// Interaction logic for addClient.xaml
    /// </summary>
    public partial class addClient : UserControl
    {
        public addClient()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string strConnexion = @"Data Source=(LocalDB)\MSSQLLocalDB; Integrated Security=SSPI;Initial Catalog=Location";
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(strConnexion))
                {
                    sqlConnection.Open();
                    Console.WriteLine("Etat de la connexion:" + sqlConnection.State);
                    
                        SqlCommand sqlCommand1 = new SqlCommand("insert into Client VALUES ('" + textNom.Text + "','" + txtPrenom.Text + "','" + txtDN.Text + "', '" + txtAdrs.Text + "'," + txtCP.Text + ",'" + txtVille.Text + "')", sqlConnection);
                        int rowsAffected = sqlCommand1.ExecuteNonQuery();
                        MessageBox.Show("ajout avec succes");
                    
                                      
                       
                } //sqlConnection.Close();
            }
            catch (Exception ev) { Console.WriteLine("Erreur :" + ev.Message); }
           

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            textNom.Text = "";
            txtPrenom.Text = "";
            txtDN.Text = "";
            txtAdrs.Text = "";
            txtCP.Text = "";
            txtVille.Text = "";


        }
    }
}
