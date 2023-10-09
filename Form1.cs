using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CheckListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false; //prevent size optimize
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckBox[] checkBoxes = new CheckBox[] {
                checkBox1, checkBox2, checkBox3, checkBox4, checkBox5, checkBox6, checkBox7, checkBox8, checkBox9, checkBox10, checkBox11, checkBox12, checkBox13, checkBox14, checkBox15, checkBox16, checkBox17, checkBox18, checkBox19, checkBox20, checkBox21, checkBox22, checkBox23, checkBox24
            };
            int index = 1;
            foreach (CheckBox arr in checkBoxes)
            {
                arr.Checked = Properties.Settings.Default["checkbox" + index.ToString()] as bool? ?? false; // load checkbox states
                index++;
            }
            textBox1.Text = Properties.Settings.Default.textbox01;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.textbox01 = textBox1.Text;
            Properties.Settings.Default.Save();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckBox[] checkBoxes = new CheckBox[] {
                checkBox1, checkBox2, checkBox3, checkBox4, checkBox5, checkBox6, checkBox7, checkBox8, checkBox9, checkBox10, checkBox11, checkBox12, checkBox13, checkBox14, checkBox15, checkBox16, checkBox17, checkBox18
            };
            checkFalse(1, checkBoxes); // Edit when number changes
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CheckBox[] checkBoxes = new CheckBox[] {
                checkBox19, checkBox20, checkBox21, checkBox22, checkBox23, checkBox24
            };
            checkFalse(19, checkBoxes); // Edit when number changes
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e) // event must be selected
        {
            CheckBox checkbox = (CheckBox)sender;
            Properties.Settings.Default["checkbox" + checkbox.Tag.ToString()] = checkbox.Checked; // tag must be entered
        }

        private void checkFalse(int startIndex, CheckBox[] checkboxes)
        {
            int index = startIndex;
            foreach (CheckBox arr in checkboxes)
            {
                arr.Checked = false;
                index++;
            }
        }
    }
}