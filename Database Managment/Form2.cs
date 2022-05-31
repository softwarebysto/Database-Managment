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
    public partial class Form2 : Form
    {
            
            SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-6CVJKRS\SQLEXPRESS; Initial Catalog=DataBase_Managment;Integrated Security=True");
        public Form2()
        {
            InitializeComponent();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {   

        }
        private void dataload()
        {
            string query = "select * from Base";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        private void cleartextbox()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        //This saves and updates database
        private void save_Click(object sender, EventArgs e)
        {
            try 
            {
                if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && textBox3.Text.Length > 0)
                {
                    float Narxi,total;
                    int Soni;
                    Soni = int.Parse(textBox2.Text);
                    Narxi = float.Parse(textBox3.Text);
                    total = Soni * Narxi;
                    string query = "Insert into Base (Nomi, Soni, Narxi, Total, Vaqt ) values ('" + textBox1.Text + "' ," + textBox2.Text + ","+textBox3.Text+"," + total + ", getdate())";
                    SqlCommand cmd = new SqlCommand(query, Con);                    
                    Con.Open();
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    dataload();
                    cleartextbox();
                }
                else
                {
                    MessageBox.Show("Iltimos ma'lumotlarni to`ldiring!");
                }
            }            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        //Adding new ROW
        private void add_Click(object sender, EventArgs e)
        {
            
            
        }

        private void delete_Click(object sender, EventArgs e)
        {
            
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            save.Enabled = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            save.Enabled = true;            
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

        private void label4_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            save.Enabled = true;            
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }        

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar == '.')
            {
                if (textBox2.Text.Contains('.'))
                {
                    e.Handled = true;
                }

            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) 
            {
                e.Handled = true; 
            }
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

        private void Form2_Load(object sender, EventArgs e)
        {
            dataload();
            
        }
    }
}
