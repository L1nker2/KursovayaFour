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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DriversForm f = new DriversForm();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RoutesForm f = new RoutesForm();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ScheduleForm f = new ScheduleForm();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программу разработал студент группы 404-ИС\nСушков Роман Вячеславович");
        }
    }
}
