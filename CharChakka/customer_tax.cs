using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CharChakka
{
    public partial class customer_tax : Form
    {
        public customer_tax()
        {
            InitializeComponent();
        }
        SqlConnection Conn = new SqlConnection(@"Data Source=RAJ-PC\SQLEXPRESS;Initial Catalog=DBMS_Project;Integrated Security=True");

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            customer_main customer_Main = new customer_main();
            customer_Main.Show();
            this.Hide();
        }

        private void populate()
        {
            Conn.Open();
            string query = "select * from TAX";
            SqlDataAdapter da = new SqlDataAdapter(query, Conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            TaxDGV.DataSource = ds.Tables[0];
            Conn.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (T_id.Text == "" || T_type.Text == "" || Tax.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Conn.Open();
                    string query = "insert into TAX values(" + T_id.Text + ",'" + T_type.Text + "'," + Tax.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, Conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Tax Information Successfully Added");
                    T_id.Clear();
                    T_type.Clear();
                    Tax.Clear();
                    Conn.Close();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Conn.Close();
                }
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (T_id.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Conn.Open();
                    string query = "delete from TAX where tax_id = " + T_id.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Tax Information Deleted Successfully");
                    T_id.Clear();
                    T_type.Clear();
                    Tax.Clear();
                    Conn.Close();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Conn.Close();
                }
            }
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            if (T_id.Text == "" || T_type.Text == "" || Tax.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Conn.Open();
                    string query = "update TAX set tax_type='" + T_type.Text + "',tax=" + Tax.Text + " where tax_id="+T_id+"";
                    SqlCommand cmd = new SqlCommand(query, Conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Tax Information Successfully Updated");
                    T_id.Clear();
                    T_type.Clear();
                    Tax.Clear();
                    Conn.Close();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Conn.Close();
                }
            }
        }

        private void customer_tax_Load(object sender, EventArgs e)
        {
            populate();
        }
    }
}