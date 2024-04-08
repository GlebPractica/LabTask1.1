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
                if (double.Parse(textBox1.Text) > -1 && double.Parse(textBox1.Text) <= 1)
                {
                    listBox1.Items.Clear();
                    Solution solution = new Solution(double.Parse(textBox1.Text));

                    listBox1.Items.Add(solution.ToString());
                    listBox1.Items.Add($"Результат равен {solution.GetResult()}");

                }
                else
                {
                    listBox1.Items.Add("Неверно введен X или N");
                }
                
            }
            catch(Exception ex)
            {
                listBox1.Items.Add(ex.Message);
            }
        }
    }
}
