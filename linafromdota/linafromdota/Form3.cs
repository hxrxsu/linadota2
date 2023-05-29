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
    public partial class Партии : Form
    {
        public Партии()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != -1)
            {
                listBox1.Items.Add("Партия будет пошыита в " + dateTimePicker1.Value.ToString() + " " + listBox2.SelectedItem.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
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
    }
}
