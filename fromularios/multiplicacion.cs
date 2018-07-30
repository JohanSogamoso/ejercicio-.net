using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fromularios
{
    public partial class multiplicacion : Form
    {
        public multiplicacion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2, multp;

            num1 = int.Parse(textBox1.Text);
            num2 = int.Parse(textBox2.Text);

            multp = num1 * num2;

            label5.Text = multp.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu regresa = new menu();
            regresa.Show();
        }
    }
}
