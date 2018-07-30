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
    public partial class division : Form
    {
        public division()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal num1, num2, divsn;

            num1 = decimal.Parse(textBox1.Text);
            num2 = decimal.Parse(textBox2.Text);

            divsn = num1 / num2;

            label5.Text = divsn.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu regrasa = new menu();
            regrasa.Show();
        }

        private void division_Load(object sender, EventArgs e)
        {

        }
    }
}
