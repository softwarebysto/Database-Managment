
namespace Database_Managment
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kimgaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nimaUchunDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qanchaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vaqtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spentMoneyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBase_ManagmentDataSet6 = new Database_Managment.DataBase_ManagmentDataSet6();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.delete = new System.Windows.Forms.PictureBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.spent_MoneyTableAdapter = new Database_Managment.DataBase_ManagmentDataSet6TableAdapters.Spent_MoneyTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spentMoneyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBase_ManagmentDataSet6)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.kimgaDataGridViewTextBoxColumn,
            this.nimaUchunDataGridViewTextBoxColumn,
            this.qanchaDataGridViewTextBoxColumn,
            this.vaqtDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.spentMoneyBindingSource;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(568, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(711, 455);
            this.dataGridView1.TabIndex = 13;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // kimgaDataGridViewTextBoxColumn
            // 
            this.kimgaDataGridViewTextBoxColumn.DataPropertyName = "Kimga";
            this.kimgaDataGridViewTextBoxColumn.HeaderText = "Kimga";
            this.kimgaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kimgaDataGridViewTextBoxColumn.Name = "kimgaDataGridViewTextBoxColumn";
            // 
            // nimaUchunDataGridViewTextBoxColumn
            // 
            this.nimaUchunDataGridViewTextBoxColumn.DataPropertyName = "Nima Uchun";
            this.nimaUchunDataGridViewTextBoxColumn.HeaderText = "Nima Uchun";
            this.nimaUchunDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nimaUchunDataGridViewTextBoxColumn.Name = "nimaUchunDataGridViewTextBoxColumn";
            // 
            // qanchaDataGridViewTextBoxColumn
            // 
            this.qanchaDataGridViewTextBoxColumn.DataPropertyName = "Qancha";
            this.qanchaDataGridViewTextBoxColumn.HeaderText = "Qancha";
            this.qanchaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.qanchaDataGridViewTextBoxColumn.Name = "qanchaDataGridViewTextBoxColumn";
            // 
            // vaqtDataGridViewTextBoxColumn
            // 
            this.vaqtDataGridViewTextBoxColumn.DataPropertyName = "Vaqt";
            this.vaqtDataGridViewTextBoxColumn.HeaderText = "Vaqt";
            this.vaqtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vaqtDataGridViewTextBoxColumn.Name = "vaqtDataGridViewTextBoxColumn";
            // 
            // spentMoneyBindingSource
            // 
            this.spentMoneyBindingSource.DataMember = "Spent_Money";
            this.spentMoneyBindingSource.DataSource = this.dataBase_ManagmentDataSet6;
            // 
            // dataBase_ManagmentDataSet6
            // 
            this.dataBase_ManagmentDataSet6.DataSetName = "DataBase_ManagmentDataSet6";
            this.dataBase_ManagmentDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.delete);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.add);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.save);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(41, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 455);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mijoz ma`lumotlarini kiritish";
            // 
            // delete
            // 
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.ErrorImage = global::Database_Managment.Properties.Resources.delete;
            this.delete.Image = global::Database_Managment.Properties.Resources.delete;
            this.delete.Location = new System.Drawing.Point(341, 290);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(58, 51);
            this.delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.delete.TabIndex = 22;
            this.delete.TabStop = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(155)))), ((int)(((byte)(227)))));
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spentMoneyBindingSource, "Qancha", true));
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(240, 210);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(194, 30);
            this.textBox3.TabIndex = 16;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // add
            // 
            this.add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add.ErrorImage = global::Database_Managment.Properties.Resources.add;
            this.add.Image = global::Database_Managment.Properties.Resources.add;
            this.add.Location = new System.Drawing.Point(205, 290);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(58, 51);
            this.add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.add.TabIndex = 21;
            this.add.TabStop = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(59, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Qancha";
            // 
            // save
            // 
            this.save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save.ErrorImage = global::Database_Managment.Properties.Resources.save;
            this.save.Image = global::Database_Managment.Properties.Resources.save;
            this.save.Location = new System.Drawing.Point(64, 290);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(58, 51);
            this.save.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.save.TabIndex = 19;
            this.save.TabStop = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(69, 413);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(291, 25);
            this.label9.TabIndex = 20;
            this.label9.Text = "Ma`lumotlarni Excelga Nusxlash";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(155)))), ((int)(((byte)(227)))));
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spentMoneyBindingSource, "Nima Uchun", true));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(240, 155);
            this.textBox2.MaxLength = 9;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(194, 30);
            this.textBox2.TabIndex = 14;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Database_Managment.Properties.Resources.excel;
            this.pictureBox2.Location = new System.Drawing.Point(11, 397);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 52);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(59, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nima Uchun";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(155)))), ((int)(((byte)(227)))));
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spentMoneyBindingSource, "Kimga", true));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(240, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 30);
            this.textBox1.TabIndex = 12;
            this.textBox1.WordWrap = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(59, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Kimga";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Database_Managment.Properties.Resources.bosh_munyu;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(306, 711);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 29);
            this.label18.TabIndex = 25;
            this.label18.Text = "8000";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(21, 714);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(246, 25);
            this.label17.TabIndex = 24;
            this.label17.Text = "Sarflangan Umumiy xarajat";
            // 
            // spent_MoneyTableAdapter
            // 
            this.spent_MoneyTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spentMoneyBindingSource, "Vaqt", true));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(155)))), ((int)(((byte)(227)))));
            this.label3.Location = new System.Drawing.Point(36, 605);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "Kimga";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(155)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(1320, 748);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xarajat";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spentMoneyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBase_ManagmentDataSet6)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox delete;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.PictureBox add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox save;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private DataBase_ManagmentDataSet6 dataBase_ManagmentDataSet6;
        private System.Windows.Forms.BindingSource spentMoneyBindingSource;
        private DataBase_ManagmentDataSet6TableAdapters.Spent_MoneyTableAdapter spent_MoneyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kimgaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nimaUchunDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qanchaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vaqtDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
    }
}