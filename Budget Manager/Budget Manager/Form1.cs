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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            View v = new View();
            v.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(DateTime.Now.ToString("MMMM") + "-" + DateTime.Now.Year);
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.conn;
            con.Open();

            string sqlQuery = "INSERT into Budget values (@exname,@paid,@amt,@cat,@expensedate,@desc,@MonthYear)";
            SqlCommand s = new SqlCommand(sqlQuery, con);
            s.Parameters.AddWithValue("@exname", txtName.Text);
            s.Parameters.AddWithValue("@paid", cbPaidUsing.Text);
            s.Parameters.AddWithValue("@amt",Convert.ToDouble( txtAmount.Text));
            s.Parameters.AddWithValue("@cat", cbCategory.Text);
            s.Parameters.AddWithValue("@expensedate", mcCalender.SelectionRange.Start);
            s.Parameters.AddWithValue("@desc", txtDescription.Text);
            s.Parameters.AddWithValue("@MonthYear", DateTime.Now.ToString("MMMM") + '-' + DateTime.Now.Year);
            s.Parameters.AddWithValue("@description", txtDescription.Text);
           


            int i = s.ExecuteNonQuery();
            if (i >= 1)
            {
                MessageBox.Show("Record Inserted");
            }
            else
            {
                MessageBox.Show("May Be Some Problem Occure !");
            }

        }
    }
}
