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
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Sql;
using System.Data.SqlTypes;


namespace Restaurant_Code
{
    /// <summary>
    /// Lógica de interacción para Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
            fill_combo_Butler();
            fill_combo_Head_Waiter();
            fill_combo_Waiter();
            fill_combo_Room_Clerk();
            fill_combo_Head_Chef();
            fill_combo_Cook();
            fill_combo_Kitchen_Clerk();
            fill_combo_Dish_Washer();
        }
        string con = @"Data Source=.\SQLEXPRESS; Initial Catalog=projet_restaurant.db; Integrated security=true;";

        /*private SqlConnection myConexion()
        {
            SqlConnection Conexion = new SqlConnection(@"Data Source=DESKTOP-0VMMD6D\SQLEXPRESS; Initial Catalog=projet_restaurant; Integrated security=true;");
            Conexion.Open();
            return Conexion;
        }
    */

        void fill_combo_Butler()
        {
            //Create connection database
            //SqlConnection con = myConexion();
            SqlConnection sql = new SqlConnection(con);
            //Open connection to database
            try
            {
                sql.Open();
                //string Query = "select Name from StaffMember where RoleID = 0";

                SqlCommand command = new SqlCommand("select Name from StaffMember where RoleID = 1", sql);
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read()) {
                    string Name = dr.GetString(1);
                    ComboBox1.Items.Add(Name);
                }
                sql.Close();
            }
            catch
            {
                //MessageBox.Show(e.Message);
            }
        }

        void fill_combo_Head_Waiter()
        {
            //Create connection database
            //SqlConnection con = myConexion();
            SqlConnection sql = new SqlConnection(con);
            //Open connection to database
            try
            {
                sql.Open();
                string Query = "select Name from StaffMember where RoleID = 1";
                SqlCommand command = new SqlCommand(Query, sql);
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    string name = dr.GetString(1);
                    ComboBox2.Items.Add(name);
                }
                sql.Close();
            }
            catch (Exception e)
            {
              //MessageBox.Show(e.Message);
            }
        }

        void fill_combo_Waiter()
        {
            //Create connection database
           // SqlConnection con = myConexion();
            SqlConnection sql = new SqlConnection(con);
            //Open connection to database
            try
            {
                sql.Open();
                string Query = "select Name from StaffMember where RoleID = 2";
                SqlCommand command = new SqlCommand(Query, sql);
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    string Name = dr.GetString(1);
                    ComboBox3.Items.Add(Name);
                }
                sql.Close();
            }
            catch (Exception e)
            {
               // MessageBox.Show(e.Message);
            }
        }

        void fill_combo_Room_Clerk()
        {
            //Create connection database
            //SqlConnection con = myConexion();
            SqlConnection sql = new SqlConnection(con);
            //Open connection to database
            try
            {
                sql.Open();
                string Query = "select Name from StaffMember where RoleID = 3";
                SqlCommand command = new SqlCommand(Query, sql);
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    string Name = dr.GetString(1);
                    ComboBox4.Items.Add(Name);
                }
                sql.Close();
            }
            catch (Exception e)
            {
              //  MessageBox.Show(e.Message);
            }
        }

        void fill_combo_Head_Chef()
        {
            //Create connection database
            //SqlConnection con = myConexion();
            SqlConnection sql = new SqlConnection(con);
            //Open connection to database
            try
            {
                sql.Open();
                string Query = "select Name from StaffMember where RoleID = 4";
                SqlCommand command = new SqlCommand(Query, sql);
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    string Name = dr.GetString(1);
                    ComboBox5.Items.Add(Name);
                }
                sql.Close();
            }
            catch (Exception e)
            {
               // MessageBox.Show(e.Message);
            }
        }

        void fill_combo_Cook()
        {
            //Create connection database
            //SqlConnection con = myConexion();
            SqlConnection sql = new SqlConnection(con);
            //Open connection to database
            try
            {
                sql.Open();
                string Query = "select Name from StaffMember where RoleID = 5";
                SqlCommand command = new SqlCommand(Query, sql);
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    string Name = dr.GetString(1);
                    ComboBox6.Items.Add(Name);
                }
                sql.Close();
            }
            catch (Exception e)
            {
              //  MessageBox.Show(e.Message);
            }
        }

        void fill_combo_Kitchen_Clerk()
        {
            //Create connection database
            //SqlConnection con = myConexion();
            SqlConnection sql = new SqlConnection(con);
            //Open connection to database
            try
            {
                sql.Open();
                string Query = "select Name from StaffMember where RoleID = 6";
                SqlCommand command = new SqlCommand(Query, sql);
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    string Name = dr.GetString(1);
                    ComboBox7.Items.Add(Name);
                }
                sql.Close();
            }
            catch (Exception e)
            {
              //  MessageBox.Show(e.Message);
            }
        }

        void fill_combo_Dish_Washer()
        {
            //Create connection database
            //SqlConnection con = myConexion();
            SqlConnection sql = new SqlConnection(con);
            //Open connection to database
            try
            {
                sql.Open();
                string Query = "select Name from StaffMember where RoleID = 7";
                SqlCommand command = new SqlCommand(Query, sql);
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    string Name = dr.GetString(1);
                    ComboBox8.Items.Add(Name);
                }
                sql.Close();
            }
            catch (Exception e)
            {
               // MessageBox.Show(e.Message);
            }
        }


        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(1);
        }


        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            Window3 window3 = new Window3();

            window3.Show();

            this.Close();
        }
    }
}
