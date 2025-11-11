using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CharChakka
{
    
    public partial class customer_cars : Form
    {
        public customer_cars()
        {
            InitializeComponent();
        }
        SqlConnection Conn = new SqlConnection(@"Data Source=RAJ-PC\SQLEXPRESS;Initial Catalog=DBMS_Project;Integrated Security=True");

        private void populate()
        {
            Conn.Open();
            string query = "select * from VEHICLE";
            SqlDataAdapter da = new SqlDataAdapter(query, Conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            CustomerCarDGV.DataSource = ds.Tables[0];
            Conn.Close();
        }

        private void customer_cars_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            customer_main customer_Main = new customer_main();
            customer_Main.Show();
            this.Hide();
        }
    }
}
