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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Form1_Load
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "dsning01@gmail.com" && this.textBox2.Text == "55375b4cd4041119fa49d75013c9151f")
            {
                MessageBox.Show("Login success, redirecting...", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Invaild username or password, please try again.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "dsning01@gmail.com";
            this.textBox2.Text = "55375b4cd4041119fa49d75013c9151f";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.textBox2.Text = "DO NOT touch me!";
            
        }
    }
}
