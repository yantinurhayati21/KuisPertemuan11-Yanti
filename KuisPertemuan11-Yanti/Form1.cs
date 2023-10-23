using KuisPertemuan11_Yanti.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuisPertemuan11_Yanti
{
    public partial class Form1 : Form
    {
        private PasimController pscontroller;
        public Form1()
        {
            pscontroller = new PasimController();
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form2 mn = new Form2();
            mn.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void segarkan()
        {
            dataGridView1.DataSource = pscontroller.tampil();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
