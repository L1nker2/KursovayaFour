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
    public partial class ScheduleForm : Form
    {
        public void LoadData()
        {
            using (ScheduleDbContext context = new ScheduleDbContext())
            {
                var schedules = context.Schedules.ToList();
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Номер расписания", typeof(int));
                dataTable.Columns.Add("День недели", typeof(string));
                dataTable.Columns.Add("Начало смены", typeof(string));
                dataTable.Columns.Add("Конец смены", typeof(string));
                dataTable.Columns.Add("Маршрут", typeof(int));
                dataTable.Columns.Add("Водитель", typeof(string));
                using (DriverDbContext context1 = new DriverDbContext())
                {
                    using (RouteDbContext context2 = new RouteDbContext())
                    {
                        foreach (var schedule in schedules)
                        {
                            var route = context2.Routes.FirstOrDefault(el => el.Route_Id == schedule.Route_Id);
                            var driver = context1.Drivers.FirstOrDefault(el => el.Driver_Id == schedule.Driver_Id);
                            dataTable.Rows.Add(schedule.Schedule_Id, schedule.Schedule_Day, schedule.Schedule_Start_Time, schedule.Schedule_End_Time, route.Route_Id, driver.Driver_Fio);
                        }
                        var drivers = context1.Drivers.ToList();
                        var routes = context2.Routes.ToList();
                        foreach (var route in routes)
                        {
                            comboBox3.Items.Add(route.Route_Id);
                            comboBox4.Items.Add(route.Route_Id);
                        }
                        foreach (var driver in drivers)
                        {
                            comboBox2.Items.Add(driver.Driver_Fio);
                            comboBox5.Items.Add(driver.Driver_Fio);
                        }
                    }
                }
                dataGridView1.DataSource = dataTable;
                dataGridView1.ReadOnly = true;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.RowHeadersVisible = false;
            }
        }
        public ScheduleForm()
        {
            InitializeComponent();
            panel1.Visible = false;
            panel2.Visible = false;
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Location = new Point(12, 471);
            button8.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                string Id = row.Cells["Номер расписания"].Value.ToString();
                ScheduleDbContext context = new ScheduleDbContext();
                context.RemoveSchedule(int.Parse(Id));
                MessageBox.Show("Удаление прошло успешно");
                LoadData();
            }
            else
            {
                MessageBox.Show("Необходисо выбрать строку");
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel2.Location = new Point(12, 471);
            button8.Visible = false;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                string Id = row.Cells["Номер расписания"].Value.ToString();
                string Start = row.Cells["Начало смены"].Value.ToString();
                string End = row.Cells["Конец смены"].Value.ToString();
                textBox3.Text = End;
                textBox4.Text = Start;
            }
            else
            {
                MessageBox.Show("Необходисо выбрать строку");
                return;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string Date = comboBox1.SelectedItem.ToString();
            string Start = textBox1.Text;
            string End = textBox2.Text;
            string Route = comboBox3.SelectedItem.ToString();//
            string Driver = comboBox2.SelectedItem.ToString();
            using (DriverDbContext context = new DriverDbContext())
            {
                var driver = context.Drivers.FirstOrDefault(el => el.Driver_Fio == Driver);
                ScheduleDbContext context1 = new ScheduleDbContext();
                context1.AddSchedule(Date, Start, End, int.Parse(Route), driver.Driver_Id);
            }
            MessageBox.Show("Добавление прошло успешно");
            LoadData();
            panel1.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            string Id = row.Cells["Номер расписания"].Value.ToString();
            string Date = comboBox6.SelectedItem.ToString();
            string Start = textBox4.Text;
            string End = textBox3.Text;
            string Route = comboBox4.SelectedItem.ToString();
            string Driver = comboBox5.SelectedItem.ToString();
            using (DriverDbContext context = new DriverDbContext())
            {
                var driver = context.Drivers.FirstOrDefault(el => el.Driver_Fio == Driver);
                ScheduleDbContext context1 = new ScheduleDbContext();
                context1.EditSchedule(int.Parse(Id), Date, Start, End, int.Parse(Route), driver.Driver_Id);
                MessageBox.Show("Изменение прошло успешно");
                LoadData();
                panel2.Visible = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string FindValue = comboBox7.SelectedItem.ToString();
            using (ScheduleDbContext context = new())
            {
                List<Schedule> rows = context.Schedules.Where(t => t.Schedule_Day == FindValue).ToList();
                dataGridView1.DataSource = rows;
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
