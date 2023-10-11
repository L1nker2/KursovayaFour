using Azure.Messaging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sushkov
{
    public partial class DriversForm : Form
    {
        public void LoadData()
        {
            using (DriverDbContext context = new DriverDbContext())
            {
                var drivers = context.Drivers.ToList();
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Номер водителя", typeof(int));
                dataTable.Columns.Add("ФИО водителя", typeof(string));
                dataTable.Columns.Add("Телефон водителя", typeof(string));
                foreach (var driver in drivers)
                {
                    dataTable.Rows.Add(driver.Driver_Id, driver.Driver_Fio, driver.Driver_Phone);
                }
                dataGridView1.DataSource = dataTable;
                dataGridView1.ReadOnly = true;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.RowHeadersVisible = false;
            }
        }
        public DriversForm()
        {
            InitializeComponent();
            LoadData();
            panel1.Visible = false;
            panel2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Location = new Point(12, 520);
            panel1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Location = new Point(12, 520);
            panel2.Visible = true;
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            string Fio = row.Cells["ФИО водителя"].Value.ToString();
            string Phone = row.Cells["Телефон водителя"].Value.ToString();
            textBox3.Text = Fio;
            textBox4.Text = Phone;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                string Id = row.Cells["Номер водителя"].Value.ToString();
                DriverDbContext context = new DriverDbContext();
                context.RemoveDriver(int.Parse(Id));
                MessageBox.Show("Удаление прошло успешно");
                LoadData();
            }
            else
            {
                MessageBox.Show("Необходимо выбрать строку!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string Fio = textBox2.Text;
            string Phone = textBox1.Text;
            if (Fio == "" || Phone == "")
            {
                MessageBox.Show("Необходимо заполнить все поля!");
                return;
            }
            DriverDbContext context = new DriverDbContext();
            context.AddDriver(Fio, Phone);
            MessageBox.Show("Добавление прошло успешно");
            panel1.Visible = false;
            textBox2.Text = "";
            textBox1.Text = "";
            LoadData();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string Fio = textBox3.Text;
            string Phone = textBox4.Text;
            if (Fio == "" || Phone == "")
            {
                MessageBox.Show("Необходимо заполнить все поля!");
                return;
            }
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                string Id = row.Cells["Номер водителя"].Value.ToString();
                DriverDbContext context = new DriverDbContext();
                context.EditDriver(int.Parse(Id), Fio, Phone);
                MessageBox.Show("Изменение прошло успешно");
                textBox3.Text = "";
                textBox4.Text = "";
                LoadData();
                panel2.Visible = false;
            }
            else
            {
                MessageBox.Show("Необходимо выбрать строку!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string FindValue = textBox5.Text;
            if (FindValue == "")
            {
                MessageBox.Show("Необходимо ввести значение");
                return;
            }
            using (DriverDbContext context = new())
            {
                List<Driver> rows = context.Drivers.Where(t => t.Driver_Fio == FindValue || t.Driver_Phone == FindValue).ToList();
                dataGridView1.DataSource = rows;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LoadData();
            textBox5.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
