
using System.Windows.Controls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System;
using System.Linq;
using System.Data.OleDb;
using System.Windows.Navigation;
using System.Diagnostics;
using System.Windows.Input;

namespace location
{
    /// <summary>
    /// Interaction logic for ListClient.xaml
    /// </summary>
    public partial class ListClient : UserControl
    {
        private DataRowView rowBeingEdited = null;
        LocationEntities objEntities = new LocationEntities();
        MainWindow MainW;
        string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        string CmdString = string.Empty;
        public ListClient(MainWindow main)
        {
            MainW = main;
            InitializeComponent();
            FillDataGrid();
            
        }
        private void FillDataGrid()
        {

           
            using (SqlConnection con = new SqlConnection(ConString))
            {
                CmdString = "SELECT * FROM Client";
                SqlCommand cmd = new SqlCommand(CmdString, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("Client");
                sda.Fill(dt);
              dtclient.ItemsSource = dt.DefaultView;
              
            }
        }
       

        private void dtclient_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            // updateClient();
            CreateCmdsAndUpdate();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dtclient.ItemsSource = objEntities.Client.ToList();
        }

        public DataTable CreateCmdsAndUpdate()
        {
            using (SqlConnection con = new SqlConnection(ConString))
            {
                SqlCommand cmd = new SqlCommand(CmdString, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("Client");

                con.Open();

              //  DataTable customers = new DataTable("Client");
                sda.Fill(dt);

                // code to modify data in DataTable here

                sda.Update(dt);

                return dt;
            }
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {  
            MainW.Main.Content = new UpdatClient();
        }

        #region editcell
        private void dtclient_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            //DataRowView rowView = e.Row.Item as DataRowView;
            //rowBeingEdited = rowView;
        }


        private void dtclient_CurrentCellChanged_1(object sender, EventArgs e)
        {
            //if (rowBeingEdited != null)
            //{
            //    rowBeingEdited.EndEdit();
            //}
        }
        #endregion

        public void supprimer(int idClient)
        {
            LocationEntities context = new LocationEntities();

            Client clt = context.Client.Find(idClient);
            context.Client.Remove(clt);
            context.SaveChanges();
            //this.mlDataGridView1.Rows.RemoveAt(this.mlDataGridView1.SelectedRows[0].Index); 
            //ds.Tables("user").Rows.RemoveAt(DataGridView1.CurrentRow.Index) 
            /*
             * dataGrid.Items.Clear();

               dataGrid.Items.Refresh();*/
        }

        private void btnDelete_Click_1(object sender, RoutedEventArgs e)
        {
            int empId = (dtclient.SelectedItem as Client).ID;
            Client employee = (from r in objEntities.Client where r.ID == empId select r).SingleOrDefault();
            objEntities.Client.Remove(employee);
            objEntities.SaveChanges();
            dtclient.ItemsSource = objEntities.Client.ToList();
        }
    }
}
