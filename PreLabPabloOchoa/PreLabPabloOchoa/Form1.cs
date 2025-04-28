using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreLabPabloOchoa
{
    public partial class Form1 : Form
    {
        int cod = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            object[] datos = {
                cod.ToString(),
                textBox1.Text,
                textBox2.Text,
                textBox3.Text,
                textBox4.Text,
                textBox5.Text,
                textBox6.Text,
                textBox7.Text,
                textBox8.Text,
                textBox9.Text,
                textBox10.Text,

            };

            dataGridView1.Rows.Add(datos);
            cod++;


            MessageBox.Show("Cita registrada", "colegio salesiano don bosco"
                , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Creditos v1 = new Creditos();
            v1.Show();
            this.Hide();
        }
    }
}

