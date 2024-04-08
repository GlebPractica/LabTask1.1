using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Execute_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            try
            {
                Solution solution = new Solution(double.Parse(textBox1.Text), double.Parse(textBox2.Text));

                listBox1.Items.Add(solution.ToString());
                listBox1.Items.Add($"Результат равен {solution.GetResult()}");
            }
            catch(Exception ex)
            {
                listBox1.Items.Add(ex.Message);
            }
        }
    }
}
