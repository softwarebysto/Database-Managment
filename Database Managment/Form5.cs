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
    public partial class Form5 : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-6CVJKRS\SQLEXPRESS; Initial Catalog=DataBase_Managment; Integrated Security=True");
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataBase_ManagmentDataSet6.Spent_Money' table. You can move, or remove it, as needed.
            this.spent_MoneyTableAdapter.Fill(this.dataBase_ManagmentDataSet6.Spent_Money);
            TotalSpent();

        }

        private void add_Click(object sender, EventArgs e)
        {
            spentMoneyBindingSource.AddNew();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            spentMoneyBindingSource.RemoveCurrent();
            spent_MoneyTableAdapter.Update(dataBase_ManagmentDataSet6.Spent_Money);
        }

        private void save_Click(object sender, EventArgs e)
        {
            date();
            spentMoneyBindingSource.EndEdit();
            spent_MoneyTableAdapter.Update(dataBase_ManagmentDataSet6.Spent_Money);
            TotalSpent();
        }
        private void date()
        {
            DateTime now = DateTime.Now;
            label3.Text = DateTime.Now.ToString("yyyy/MM/dd");

        }

        private void TotalSpent()
        {

            try
            {
                string query = "select SUM([Qancha]) as[TotalSpent] from Spent_Money";
                SqlCommand cmd = new SqlCommand(query, Con);
                Con.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        label18.Text = dr["TotalSpent"].ToString();
                        Con.Close();
                    }

                }
            }
            catch (Exception)
            {

            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }
       

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }

        private void ExportToExcel()
        {
            dataGridView1.SelectAll();
            DataObject copydata = dataGridView1.GetClipboardContent();
            if (copydata != null) Clipboard.SetDataObject(copydata);
            Microsoft.Office.Interop.Excel.Application xlapp = new Microsoft.Office.Interop.Excel.Application();
            xlapp.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            object miseddata = System.Reflection.Missing.Value;
            workbook = xlapp.Workbooks.Add(miseddata);
            worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range xlr = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[1, 1];
            xlr.Select();
            worksheet.PasteSpecial(xlr, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
