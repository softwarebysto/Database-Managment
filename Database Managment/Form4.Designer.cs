
namespace Database_Managment
{
    partial class Form4
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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.delete = new System.Windows.Forms.PictureBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBase_ManagmentDataSet4 = new Database_Managment.DataBase_ManagmentDataSet4();
            this.add = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mijozningIsmiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mijozningTelefonRaqamiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mijozHaqidaMalumotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientTableAdapter = new Database_Managment.DataBase_ManagmentDataSet4TableAdapters.clientTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBase_ManagmentDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::Database_Managment.Properties.Resources.sotish1;
            this.pictureBox3.Location = new System.Drawing.Point(1249, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(57, 59);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Database_Managment.Properties.Resources.bosh_munyu;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.groupBox1.Location = new System.Drawing.Point(24, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 455);
            this.groupBox1.TabIndex = 10;
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
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Mijoz Haqida Malumot", true));
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(240, 210);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(194, 30);
            this.textBox3.TabIndex = 16;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "client";
            this.clientBindingSource.DataSource = this.dataBase_ManagmentDataSet4;
            // 
            // dataBase_ManagmentDataSet4
            // 
            this.dataBase_ManagmentDataSet4.DataSetName = "DataBase_ManagmentDataSet4";
            this.dataBase_ManagmentDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.label2.Location = new System.Drawing.Point(6, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Mijoz haqida ma`lumot:";
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
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Mijozning Telefon Raqami", true));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(240, 155);
            this.textBox2.MaxLength = 9;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(194, 30);
            this.textBox2.TabIndex = 14;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
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
            this.label1.Location = new System.Drawing.Point(6, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Mijozning telefon raqami:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(155)))), ((int)(((byte)(227)))));
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Mijozning Ismi", true));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(240, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 30);
            this.textBox1.TabIndex = 12;
            this.textBox1.WordWrap = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Mijozning ismi:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mijozningIsmiDataGridViewTextBoxColumn,
            this.mijozningTelefonRaqamiDataGridViewTextBoxColumn,
            this.mijozHaqidaMalumotDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clientBindingSource;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(551, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(711, 455);
            this.dataGridView1.TabIndex = 11;
            // 
            // mijozningIsmiDataGridViewTextBoxColumn
            // 
            this.mijozningIsmiDataGridViewTextBoxColumn.DataPropertyName = "Mijozning Ismi";
            this.mijozningIsmiDataGridViewTextBoxColumn.HeaderText = "Mijozning Ismi";
            this.mijozningIsmiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mijozningIsmiDataGridViewTextBoxColumn.Name = "mijozningIsmiDataGridViewTextBoxColumn";
            // 
            // mijozningTelefonRaqamiDataGridViewTextBoxColumn
            // 
            this.mijozningTelefonRaqamiDataGridViewTextBoxColumn.DataPropertyName = "Mijozning Telefon Raqami";
            this.mijozningTelefonRaqamiDataGridViewTextBoxColumn.HeaderText = "Mijozning Telefon Raqami";
            this.mijozningTelefonRaqamiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mijozningTelefonRaqamiDataGridViewTextBoxColumn.Name = "mijozningTelefonRaqamiDataGridViewTextBoxColumn";
            // 
            // mijozHaqidaMalumotDataGridViewTextBoxColumn
            // 
            this.mijozHaqidaMalumotDataGridViewTextBoxColumn.DataPropertyName = "Mijoz Haqida Malumot";
            this.mijozHaqidaMalumotDataGridViewTextBoxColumn.HeaderText = "Mijoz Haqida Malumot";
            this.mijozHaqidaMalumotDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mijozHaqidaMalumotDataGridViewTextBoxColumn.Name = "mijozHaqidaMalumotDataGridViewTextBoxColumn";
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(155)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(1318, 753);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mijoz qo`shish";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBase_ManagmentDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox delete;
        private System.Windows.Forms.PictureBox add;
        private System.Windows.Forms.PictureBox save;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DataBase_ManagmentDataSet4 dataBase_ManagmentDataSet4;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private DataBase_ManagmentDataSet4TableAdapters.clientTableAdapter clientTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mijozningIsmiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mijozningTelefonRaqamiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mijozHaqidaMalumotDataGridViewTextBoxColumn;
    }
}