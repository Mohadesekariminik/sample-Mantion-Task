using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_03
{
    public partial class Form1 : Form
    {
        private KillTask killTask;

        public Form1()
        {
            InitializeComponent();
            killTask = new KillTask();



            label3.Text = killTask.DailyTaskAmount.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void calculateDaily_Click(object sender, EventArgs e)
        {
            int dailyKill = Convert.ToInt32(textBox1.Text);
            killTask.Daily(dailyKill);

            MessageBox.Show(killTask.GetGold().ToString());
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
