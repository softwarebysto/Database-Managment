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
    public partial class Form4 : Form
    {
        int  a = 0, b = 0;
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-6CVJKRS\SQLEXPRESS; Initial Catalog=DataBase_Managment;Integrated Security=True");
        public Form4()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
      
        private void save_Click(object sender, EventArgs e)
        {
            a = a + 1;
            if (textBox1.Text.Length > 0 && textBox2.Text.Length >0 && a == 1)
            {
                if (textBox2.Text.Length < 9)
                {
                    MessageBox.Show("Telefon raqami 9 raqamdan iborat bo'lishi kerak!  Misol (901234567)");
                }
                else
                {
                    save.Enabled = false;


                    try
                    {
                        b = 0;
                        clientBindingSource.EndEdit();
                        clientTableAdapter.Update(dataBase_ManagmentDataSet4.client);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                
            }
            else
            {
                MessageBox.Show("Iltimos ma`lumotlarni to'ldiring");
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataBase_ManagmentDataSet4.client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.dataBase_ManagmentDataSet4.client);
            

        }

        private void add_Click(object sender, EventArgs e)
        {
            b = b + 1;
            if (b == 1)
            {
                clientBindingSource.AddNew();
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            clientBindingSource.RemoveCurrent();
            clientTableAdapter.Update(dataBase_ManagmentDataSet4.client);
        
        
    }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            save.Enabled = true;
            a = 0;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            save.Enabled = true;
            a = 0;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            save.Enabled = true;
            a = 0;
        }

        private void label9_Click(object sender, EventArgs e)
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
