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
    public partial class Form3 : Form
    {
        int a,b,textboxChangedTXT;
        double textboxNarx, totalmoney;
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-6CVJKRS\SQLEXPRESS; Initial Catalog=DataBase_Managment; Integrated Security=True");
        public Form3()
        {
            InitializeComponent();
        }

        private void clientsComboBox()
        {
            try
            {
                string query = "use Database_Managment select [Mijozning Ismi] from client";
                Con.Open();
                SqlCommand cmd = new SqlCommand(query,Con);
                SqlDataReader rdr;
                rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("Mijozning Ismi", typeof(string));
                dt.Load(rdr);
                comboBox1.ValueMember = "Mijozning Ismi";
                comboBox1.DataSource = dt;
                Con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SearchClientsComboBox()
        {
            try
            {
                string query = "use Database_Managment select [Mijozning Ismi] from client";
                Con.Open();
                SqlCommand cmd = new SqlCommand(query, Con);
                SqlDataReader rdr;
                rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("Mijozning Ismi", typeof(string));
                dt.Load(rdr);
                comboBox3.ValueMember = "Mijozning Ismi";
                comboBox3.DataSource = dt;
                Con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void comboProduct()
        {
            try
            {
                string query = "use Database_Managment select [Nomi] from base";
                Con.Open();
                SqlCommand cmd = new SqlCommand(query, Con);
                SqlDataReader rdr;
                rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("Nomi", typeof(string));
                dt.Load(rdr);
                comboBox2.ValueMember = "Nomi";
                comboBox2.DataSource = dt;
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            double Soni, Narxi, SoniDB, NarxiDB;
            try
            {
                Soni = double.Parse(textBox1.Text);
                Narxi = double.Parse(textBox2.Text);
                SoniDB = double.Parse(label4.Text);
                NarxiDB = double.Parse(label6.Text);
                if (comboBox1.SelectedValue == null)
                {
                    MessageBox.Show("Mijozlar bo`limda ma`lumot topilmadi. Iltimos mijoz haqida ma`lumot qo`shing");
                }
                else if (comboBox2.SelectedValue == null)
                {
                    MessageBox.Show("Omborxonada mahsulot topilmadi. Iltioms omborga mahsulot qo`shing");
                }
                else if (textBox1.TextLength <= 0)
                {
                    MessageBox.Show("Mahsulot sonini kiriting!");
                }
                else if (textBox2.TextLength <= 0)
                {
                    
                    Soni = double.Parse(textBox1.Text);
                    Narxi = double.Parse(textBox2.Text);
                    SoniDB = double.Parse(label4.Text);
                    NarxiDB = double.Parse(label6.Text);
                }
                else if (Soni > SoniDB)
                {
                    MessageBox.Show("Omborda bu mahsulotdan " + SoniDB + "ta bor. Siz ombordagi mahsulotdan ko`p mahsulot kirita olmaysiz");
                }
                else if (Narxi < NarxiDB)
                {
                    MessageBox.Show("Ombordagi narxi " + NarxiDB + "$. Siz mahsulotni o`z narxidan arzonga sota olmaysiz");
                }
                else
                {
                   
                    a = a + 1;
                    if (a == 1)
                    {
                        save.Enabled = false;
                        try 
                        {
                            b=0;
                            
                            totalmoney = Soni * Narxi;
                            label11.Text = totalmoney.ToString();
                            
                            string insertQuery= "insert into Selling (Kimga, [Mahsulot Nomi], [Mahsulot Soni], [Mahsulot Narxi], [Umumiy Narxi], Vaqt) values("+"'"+label13.Text+"'"+"," + "'" + comboBox2.SelectedValue.ToString()+"'" + ","+textBox1.Text+"," + textBox2.Text + "," + label11.Text + ","+"getdate() )";
                            string query = "use DataBase_Managment update Base set Soni =(Soni-" + textBox1.Text + ")" + " where Nomi= @Nomi";
                            
                            SqlCommand cmd = new SqlCommand(query, Con);
                            
                            SqlCommand insertcommand = new SqlCommand(insertQuery, Con);
                            
                            cmd.Parameters.AddWithValue("@Nomi", comboBox2.SelectedValue.ToString());
                            

                            Con.Open();
                            cmd.ExecuteNonQuery();
                            
                            insertcommand.ExecuteNonQuery();
                            Con.Close();


                            double EskiSoni, YangiSoni, AyrilganSon;
                            EskiSoni = double.Parse(label4.Text);
                            AyrilganSon = double.Parse(textBox1.Text);
                            YangiSoni = EskiSoni - AyrilganSon;

                            label4.Text = YangiSoni.ToString();
                            datagridviewbinding();
                            totalPrice();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    }
                }
           
            }
            catch
            {
                MessageBox.Show("Ma`lumotlarni to`ldiring");
            }
            
         
            

            

        }
        
            private void datagridviewbinding()
            {
                string query = "select * from Selling";
                SqlCommand cmd = new SqlCommand(query,Con);
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = cmd;
                DataTable dt = new DataTable();
                dt.Clear();
                dataAdapter.Fill(dt);
                dataGridView1.DataSource = dt;
                this.dataGridView1.Columns["ID"].Visible = false;

            }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
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
        private void comboindex()
        {
            if(comboBox2.SelectedValue == null)
            {
                MessageBox.Show("Omborda Mahsulot topilmadi iltimos omborga mahsulot qo`shing");
            }
            else
            {
                try
                {
                    string query = "USE DataBase_Managment SELECT Soni,Narxi from base where Nomi=@Nomi";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@Nomi", comboBox2.SelectedValue.ToString());
                    Con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            label4.Text = dr["Soni"].ToString();
                            label6.Text = dr["Narxi"].ToString();
                            Con.Close();
                        }

                    }
                }
                catch (Exception)
                {

                }
            }
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            a = 0;
            comboindex();
            save.Enabled = true;
        }

       

        private void delete_Click(object sender, EventArgs e)
        {
            delete_record();
            restore_to_database();
            datagridviewbinding();
            totalPrice();
        }


        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void delete_record()
        {
            
            try
            {
                SqlCommand cmd = new SqlCommand();
                if (dataGridView1.Rows.Count > 1 && dataGridView1.SelectedRows[0].Index != dataGridView1.Rows.Count - 1)
                {
                    cmd.CommandText = "DELETE FROM Selling WHERE ID=" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "";
                    Con.Open();
                    cmd.Connection = Con;
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);

                    
                    MessageBox.Show("Ma`lumot o`chirildi");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Iltimos o`chirmoqchi bo`lgan mahsulotingizni tanlang");
            }
        }
        private void update_record()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                if (dataGridView1.Rows.Count > 1 && dataGridView1.SelectedRows[0].Index != dataGridView1.Rows.Count - 1)
                {
                    a = int.Parse(textBox1.Text);
                    b = int.Parse(textBox2.Text);
                    totalmoney = a * b;
                    label11.Text = totalmoney.ToString();
                    cmd.CommandText = "UPDATE Selling SET Kimga= '" + comboBox1.SelectedValue.ToString() + "' , [Mahsulot Nomi]='" + comboBox2.SelectedValue.ToString() + "' , [Mahsulot Soni]=" + textBox1.Text + ", [Mahsulot Narxi]=" + textBox2.Text + ", [Umumiy Narxi]=" + totalmoney + ", Vaqt=GETDATE() where ID=" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "";
                    Con.Open();
                    cmd.Connection = Con;
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Ma`lumot yangilandi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                label13.Text = comboBox1.SelectedValue.ToString();
                a = 0;
                save.Enabled = true;
            }
            catch
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                a = 0;
                textboxChangedTXT = int.Parse(textBox1.Text);
                save.Enabled = true;
            }
            catch 
            { 
            
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                a = 0;
                save.Enabled = true;
                textboxNarx = float.Parse(textBox2.Text);
            }
            catch
            {

            }
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            int ombordagiSon, OmbordagiNarx, kiritilganson;
            ombordagiSon = int.Parse(label4.Text);
            OmbordagiNarx = int.Parse(label6.Text);
            kiritilganson = int.Parse(label25.Text);



            if (ombordagiSon < textboxChangedTXT)
            {
                MessageBox.Show("Omborda "+ombordagiSon+" mavjud kechirasiz siz omborda mavjud bo`lgan qiymatdan ko'p mahsulot sota olmaysiz");
            }
            else if (OmbordagiNarx > textboxNarx)
            {
                MessageBox.Show("Ombordagi narxi " + OmbordagiNarx + " kechirasiz siz ombordagi narxidan arzonga sota olmaysiz");
            }
            else
            {
                update_record();
                refresh_restore_to_databas();
                datagridviewbinding();
                totalPrice();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = e.RowIndex;
                DataGridViewRow selectedrow = dataGridView1.Rows[i];
                comboBox1.SelectedValue = selectedrow.Cells[1].Value.ToString();
                comboBox2.SelectedValue = selectedrow.Cells[2].Value.ToString();
                textBox1.Text = selectedrow.Cells[3].Value.ToString();
                label25.Text = selectedrow.Cells[3].Value.ToString();
                label15.Text = selectedrow.Cells[3].Value.ToString();
                textBox2.Text = selectedrow.Cells[4].Value.ToString();
            }
            catch
            {

            }
            
        }

        private void date()
        {
            DateTime now = DateTime.Now;
            label12.Text = DateTime.Now.ToString("yyyy/MM/dd");

        }


        private void Form3_Load(object sender, EventArgs e)
        {

            totalPrice();
            clientsComboBox();
            SearchClientsComboBox();
            comboProduct();
            datagridviewbinding();
            a = 0;
            save.Enabled = true;
            comboindex();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            filter();
            totalPriceOfClint();
            label19.Visible = true;
            label20.Visible = true;
        }

        private void add_Click(object sender, EventArgs e)
        {
            a = 0;
            save.Enabled = true;
            update_record();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            label19.Visible = false;
            label20.Visible = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            datagridviewbinding();
            label19.Visible = false;
            label20.Visible = false;
        }

        private void filter()
        {
             string query = "select * from Selling where Kimga=@Kimga";
            using ( SqlCommand cmd = new SqlCommand(query, Con))
            {
                cmd.Parameters.AddWithValue("@Kimga", comboBox3.SelectedValue.ToString());
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = cmd;
                DataTable dt = new DataTable();
                dt.Clear();
                dataAdapter.Fill(dt);
                dataGridView1.DataSource = dt;
                this.dataGridView1.Columns["ID"].Visible = false;
            }
        }
        private void totalPrice()
        {
            string query = "select sum([Umumiy Narxi]) as Total from Selling ";
            using (SqlCommand cmd = new SqlCommand(query, Con))
            {
                Con.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        label18.Text = dr["Total"].ToString()+"$";
                        Con.Close();
                    }
                }
            }
        }

        private void label22_Click(object sender, EventArgs e)
        {
            label16.Text = "Mijoz xaridlari bo'yicha saralsh: ";
            comboBox3.Visible = true;
            pictureBox5.Visible = true;
            label22.Visible = false;
            label21.Visible = true;
            label23.Visible = false;
            label24.Visible = false;
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
            pictureBox7.Visible = false;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            dataFilter();
            totalPriceOfBetween2Date();
            label19.Visible = true;
            label20.Visible = true;
        }

        private void label21_Click(object sender, EventArgs e)
        {
            label16.Text = "Vaqt oralig'ida saralash ";
            comboBox3.Visible = false;
            pictureBox5.Visible = false;
            label21.Visible = false;
            label22.Visible = true;
            label23.Visible = true;
            label24.Visible = true;
            dateTimePicker1.Visible = true;
            dateTimePicker2.Visible = true;
            pictureBox7.Visible = true;
        }



        private void dataFilter()
        {
            string query = "select * from Selling Where Vaqt between '" + this.dateTimePicker1.Text + "' and '" + this.dateTimePicker2.Text + "'";
            using (SqlCommand cmd = new SqlCommand(query, Con))
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                sqlDataAdapter.SelectCommand = cmd;
                DataTable dt = new DataTable();
                dt.Clear();
                sqlDataAdapter.Fill(dt);
                dataGridView1.DataSource = dt;
                this.dataGridView1.Columns["ID"].Visible = false;
            }
        }

        private void totalPriceOfBetween2Date()
        {
            string query = "select sum([Umumiy Narxi]) as Total from Selling Where Vaqt between '" + this.dateTimePicker1.Text + "' and '" + this.dateTimePicker2.Text + "'";
            using (SqlCommand cmd = new SqlCommand(query, Con))
            {
                cmd.Parameters.AddWithValue("@Kimga", comboBox3.SelectedValue.ToString());
                Con.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        label20.Text = dr["Total"].ToString() + "$";
                        Con.Close();
                    }
                }
            }
        }
        private void totalPriceOfClint()
        {
            string query = "select sum([Umumiy Narxi]) as Total from Selling Where Kimga = @Kimga";
            using (SqlCommand cmd = new SqlCommand(query, Con))
            {
                cmd.Parameters.AddWithValue("@Kimga", comboBox3.SelectedValue.ToString());
                Con.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        label20.Text = dr["Total"].ToString() + "$";
                        Con.Close();
                    }
                }
            }
        }

        private void restore_to_database()
        {
            string query = "use DataBase_Managment update Base set Soni =(Soni+" + textBox1.Text + ")" + " where Nomi= @Nomi";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.Parameters.AddWithValue("@Nomi", comboBox2.SelectedValue.ToString());
            Con.Open();
            cmd.ExecuteNonQuery();
            Con.Close();
            int EskiSoni, YangiSoni, AyrilganSon;
            EskiSoni = int.Parse(label4.Text);
            AyrilganSon = int.Parse(textBox1.Text);
            YangiSoni = EskiSoni + AyrilganSon;
            label4.Text = YangiSoni.ToString();
        }
        private void refresh_restore_to_databas()
        {
            int EskiSoni, YangiSoni,   OmbordagiSon;
            EskiSoni = int.Parse(label15.Text);
            OmbordagiSon = int.Parse(label4.Text);
            
           if (EskiSoni < textboxChangedTXT)
            {
                // Minus from Base
                YangiSoni = textboxChangedTXT - EskiSoni;
                string query = "use DataBase_Managment update Base set Soni =(Soni-" + YangiSoni + ")" + " where Nomi= @Nomi";
                using (SqlCommand cmd = new SqlCommand(query, Con))
                {
                    cmd.Parameters.AddWithValue("@Nomi", comboBox2.SelectedValue.ToString());
                    Con.Open();
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    OmbordagiSon = OmbordagiSon - YangiSoni;
                    label4.Text = OmbordagiSon.ToString();
                }
            }
            else if (EskiSoni == textboxChangedTXT)
            {
                
            }
           else
            {

                // Add to Base
                YangiSoni = EskiSoni - textboxChangedTXT;
                string query = "use DataBase_Managment update Base set Soni =(Soni+" + YangiSoni + ")" + " where Nomi= @Nomi";
                using (SqlCommand cmd = new SqlCommand(query, Con))
                {
                    cmd.Parameters.AddWithValue("@Nomi", comboBox2.SelectedValue.ToString());
                    Con.Open();
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    OmbordagiSon = OmbordagiSon + YangiSoni;
                    label4.Text = OmbordagiSon.ToString();
                }
            }
        }
    }
}
