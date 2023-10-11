using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sushkov
{
    public partial class RoutesForm : Form
    {
        public void LoadData()
        {
            using (RouteDbContext context = new RouteDbContext())
            {
                var routes = context.Routes.ToList();
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Номер маршрута", typeof(int));
                dataTable.Columns.Add("Начальная остановка", typeof(string));
                dataTable.Columns.Add("Конечная остановка", typeof(string));
                dataTable.Columns.Add("Длина маршрута", typeof(string));
                foreach (var route in routes)
                {
                    dataTable.Rows.Add(route.Route_Id, route.Route_Start, route.Route_End, route.Route_Length);
                }
                dataGridView1.DataSource = dataTable;
                dataGridView1.ReadOnly = true;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.RowHeadersVisible = false;
            }
        }
        public RoutesForm()
        {
            InitializeComponent();
            panel1.Visible = false;
            panel2.Visible = false;
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Location = new Point(12, 457);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                string Id = row.Cells["Номер маршрута"].Value.ToString();
                RouteDbContext context = new RouteDbContext();
                context.RemoveRoute(int.Parse(Id));
                MessageBox.Show("Удаление прошло успешно");
                LoadData();
            }
            else
            {
                MessageBox.Show("Необходимо выбрать строку!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel2.Location = new Point(12, 457);
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            string Start = row.Cells["Начальная остановка"].Value.ToString();
            string End = row.Cells["Конечная остановка"].Value.ToString();
            string Length = row.Cells["Длина маршрута"].Value.ToString();
            textBox6.Text = Start;
            textBox5.Text = End;
            textBox4.Text = Length;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string Start = textBox1.Text;
            string End = textBox2.Text;
            string Length = textBox3.Text;
            if (Start == "" || End == "" || Length == "")
            {
                MessageBox.Show("Необходимо заполнить все поля");
                return;
            }
            RouteDbContext context = new RouteDbContext();
            context.AddRoute(Start, End, Length);
            MessageBox.Show("Добавление прошло успешно");
            panel1.Visible = false;
            LoadData();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            string Id = row.Cells["Номер маршрута"].Value.ToString();
            string Start = textBox6.Text;
            string End = textBox5.Text;
            string Length = textBox4.Text;
            if (Start == "" || End == "" || Length == "")
            {
                MessageBox.Show("Необходимо заполнить все поля");
                return;
                panel2.Visible = false;
            }
            using (RouteDbContext context = new RouteDbContext())
            {
                var route = context.Routes.FirstOrDefault(el => el.Route_Id == int.Parse(Id));
                route.Route_Start = Start;
                route.Route_End = End;
                route.Route_Length = Length;
                context.SaveChanges();
                MessageBox.Show("Изменение прошло успешно");
                LoadData();
                panel2.Visible = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string FindValue = textBox7.Text;
            if (FindValue == "")
            {
                MessageBox.Show("Необходимо ввести значение");
                return;
            }
            using (RouteDbContext context = new())
            {
                List<Route> rows = context.Routes.Where(t => t.Route_Start == FindValue || t.Route_End == FindValue || t.Route_Length == FindValue).ToList();
                dataGridView1.DataSource = rows;
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            LoadData();
            textBox7.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
