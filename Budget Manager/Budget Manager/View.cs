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


namespace Budget_Manager
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void View_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select distinct MonthYear from Budget", Properties.Settings.Default.conn);

            DataTable dt = new DataTable();
            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
               cbmonth.Items.Add(dt.Rows[i][0]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.conn;
            con.Open();
            try
            {


                string txt = cbmonth.Text;

                    string query = "select * from Budget where MonthYear=@mon";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add(new SqlParameter("@mon", txt));

                    SqlDataReader dr = cmd.ExecuteReader();


                    using (dr)
                    {
                        DataTable table = new DataTable();
                        table.Load(dr);
                        dgvView.DataSource = table;
                        double amt=0;

                        foreach(DataRow r in table.Rows)
                        {
                            amt =amt+ Convert.ToDouble(r[3]);
                        }
                        txtAmount.Text = amt.ToString();
                    }
                    
                
                    dr.Close();
                    dr.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show("May be some Problem occured in SQL! Please check your input\n" + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }
    }
}
