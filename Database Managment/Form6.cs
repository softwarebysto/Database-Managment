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

namespace Database_Managment
{
    public partial class Form6 : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-6CVJKRS\SQLEXPRESS; Initial Catalog=DataBase_Managment; Integrated Security=True");
        public Form6()
        {
            InitializeComponent();
        }
        private void Form6_Load(object sender, EventArgs e)
        {
            YearLoad();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void YearLoad()
        {
            try
            {
                string query = "select YEAR([Vaqt]) AS [Year] from Selling UNION Select YEAR([Vaqt]) AS [Year] From Spent_Money";
                Con.Open();
                SqlCommand cmd = new SqlCommand(query, Con);
                SqlDataReader rdr;
                rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("Year", typeof(int));
                dt.Load(rdr);
                comboBox1.ValueMember = "Year";
                comboBox1.DataSource = dt;
                Con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void MonthLoad()

        {
            try
            {
                string query = "select MONTH([Vaqt]) as [Month] from Selling where YEAR([Vaqt])=" + comboBox1.SelectedValue.ToString() + " UNION Select MONTH([Vaqt]) as [Month] from Spent_Money where YEAR([Vaqt])=" + comboBox1.SelectedValue.ToString();

                using (SqlCommand cmd = new SqlCommand(query, Con))
                {
                    SqlDataReader rdr;
                    Con.Open();
                    rdr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Columns.Add("Month", typeof(int));
                    dt.Load(rdr);
                    comboBox2.ValueMember = "Month";
                    comboBox2.DataSource = dt;
                    Con.Close();
                    
                }                    
            }
            catch (Exception )
            {
                
            }
            
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            income();
            spent();
            profit();
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
        }
        private void income()
        {
            try
            {
                string queryIncome = "select SUM([Umumiy Narxi]) as [Income] from Selling where MONTH([Vaqt])=" + comboBox2.SelectedValue + "AND YEAR([Vaqt])=" + comboBox1.SelectedValue;
                using (SqlCommand cmd = new SqlCommand(queryIncome, Con))
                {
                    Con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            label4.Text = dr["Income"].ToString()+"$";
                            Con.Close();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void spent()
        {
            try
            {
                string querySpentMoney = "select SUM([Qancha]) as [SpentMoney] from Spent_Money where MONTH([Vaqt])=" + comboBox2.SelectedValue + "AND YEAR([Vaqt])=" + comboBox1.SelectedValue;
                using (SqlCommand cmdSpent = new SqlCommand(querySpentMoney, Con))
                {
                    Con.Open();
                    using (SqlDataReader reader = cmdSpent.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            label3.Text =reader["SpentMoney"].ToString()+"$";
                            Con.Close();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void profit()
        {
            try
            {
                string querySpentMoney = "Select (Select SUM([Umumiy Narxi]) from Selling where MONTH(Vaqt)="+comboBox2.SelectedValue+" and YEAR(Vaqt)="+comboBox1.SelectedValue+") - (select SUM([Qancha]) from Spent_Money where MONTH([Vaqt])="+comboBox2.SelectedValue+" and YEAR(Vaqt)="+comboBox1.SelectedValue+") as Profit";
                using (SqlCommand cmdSpent = new SqlCommand(querySpentMoney, Con))
                {
                    Con.Open();
                    using (SqlDataReader reader = cmdSpent.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            label5.Text = reader["Profit"].ToString() + "$";
                            Con.Close();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MonthLoad();
            comboBox2.Enabled = true;
            label2.Enabled = true;
        }

       

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox7.Visible = true;
        }
    }
}
