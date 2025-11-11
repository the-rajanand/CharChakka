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
    public partial class customer_complaint : Form
    {
        public customer_complaint()
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void populate()
        {
            Conn.Open();
            string query = "select complain from COMPLAINT";
            SqlDataAdapter da = new SqlDataAdapter(query, Conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ComplaintDGV.DataSource = ds.Tables[0];
            Conn.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (Comp_id.Text == "" || Cu_id.Text == "" || Complain.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Conn.Open();
                    string query = "insert into COMPLAINT values(" + Comp_id.Text + "," + Cu_id.Text + ",'" + Complain.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Complaint Successfully Added");
                    Comp_id.Clear();
                    Cu_id.Clear();
                    Complain.Clear();
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
            if (Comp_id.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Conn.Open();
                    string query = "delete from COMPLAINT where comp_id = " + Comp_id.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Complaint Deleted Successfully");
                    Comp_id.Clear();
                    Cu_id.Clear();
                    Complain.Clear();
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
            if (Comp_id.Text == "" || Cu_id.Text == "" || Complain.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Conn.Open();
                    string query = "update COMPLAINT set complain='" + Complain.Text + "' where comp_id="+Comp_id.Text+"";
                    SqlCommand cmd = new SqlCommand(query, Conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Complaint Successfully Updated");
                    Comp_id.Clear();
                    Cu_id.Clear();
                    Complain.Clear();
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

        private void customer_complaint_Load(object sender, EventArgs e)
        {
            populate();
        }
    }
}
