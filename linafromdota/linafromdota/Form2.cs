using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace linafromdota
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != -1)
            {
                listBox1.Items.Add("Будет пошито в " + dateTimePicker1.Value.ToString() + " " + listBox2.SelectedItem.ToString());
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > 0)
            {
                int index = listBox1.SelectedIndex;
                string text = listBox1.SelectedItem.ToString();
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                listBox1.Items.Insert(index - 1, text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < listBox2.Items.Count)
            {
                if (listBox1.SelectedIndex > 0)
                {
                    int index = listBox1.SelectedIndex;
                    string text = listBox1.SelectedItem.ToString();
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                    listBox1.Items.Insert(index + 1, text);
                }
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void авторToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
