using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public void txt1f2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 realizando = new Form4();
            realizando.ShowDialog();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txt1f2.Text = txt1.Text;
            txt2f2.Text = txt2.Text;
            txt3f2.Text = txt3.Text;
            txt4f2.Text = txt4.Text;
            txt5f2.Text = txt5.Text;

            txt1nf2.Text = txt1n.Text;
            txt2nf2.Text = txt2n.Text;
            txt3nf2.Text = txt3n.Text;
            txt4nf2.Text = txt4n.Text;
            txt5nf2.Text = txt5n.Text;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form4 realizando = new Form4();
            realizando.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 realizando = new Form4();
            realizando.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form4 realizando = new Form4();
            realizando.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form4 realizando = new Form4();
            realizando.ShowDialog();
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
