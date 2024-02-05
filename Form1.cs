using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CheckListBox
{
    public partial class Form1 : Form
    {
        TextBox dynamicTextBox;
        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false; //prevent size optimize
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckBox[] checkBoxes = new CheckBox[] {
                checkBox1, checkBox2, checkBox3, checkBox4, checkBox5, checkBox6, checkBox7, checkBox8, checkBox9, checkBox10, checkBox11, checkBox12, checkBox13, checkBox14, checkBox15, checkBox16, checkBox17, checkBox18, checkBox19, checkBox20, checkBox21, checkBox22, checkBox23, checkBox24, checkBox25, checkBox26
            };
            int checkboxindex = 1;
            foreach (CheckBox arr in checkBoxes)
            {
                arr.Checked = Properties.Settings.Default["checkbox" + checkboxindex.ToString()] as bool? ?? false; // load checkbox states
                checkboxindex++;
            }

            Label[] labels = new Label[] {label1, label2, label3, label4, label5, label6 };
            int labelindex = 1;
            foreach (Label arr in labels)
            {
                arr.Text = Properties.Settings.Default["label" + labelindex.ToString()] as string;
                labelindex++;
            }

            textBox1.Text = Properties.Settings.Default.textbox1;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.textbox1 = textBox1.Text;
            Properties.Settings.Default.Save();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckBox[] checkBoxes = new CheckBox[] {
                checkBox1, checkBox2, checkBox3, checkBox4, checkBox5, checkBox6, checkBox7, checkBox8, checkBox9, checkBox10, checkBox11, checkBox12, checkBox13, checkBox14, checkBox15, checkBox16, checkBox17, checkBox18, checkBox19, checkBox20, checkBox21, checkBox22, checkBox23, checkBox24, checkBox25, checkBox26
            }; // add object when new object
            checkFalse(1, checkBoxes); // change into first number when number changes
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    CheckBox[] checkBoxes = new CheckBox[] {
        //        checkBox22, checkBox23, checkBox24
        //    };
        //    checkFalse(22, checkBoxes); // change into first number when number changes
        //}

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

        private void TextBox_LostFocus(object sender, EventArgs e, Label target)
        {
            if (dynamicTextBox != null)
            {
                if (!string.IsNullOrEmpty(dynamicTextBox.Text))
                {
                    target.Text = dynamicTextBox.Text;
                    Properties.Settings.Default["label" + target.Tag.ToString()] = target.Text;
                    Properties.Settings.Default.Save();
                }
                this.Controls.Remove(dynamicTextBox);
                dynamicTextBox.LostFocus -= (s, args) => TextBox_LostFocus(s, args, target);
                dynamicTextBox = null;
            }
        }

        private void label_Click(object sender, EventArgs e)
        {
            if(dynamicTextBox == null)
            {
                Label self = sender as Label;
                if (self != null)
                {
                    dynamicTextBox = new TextBox();
                    dynamicTextBox.Width = 40;
                    dynamicTextBox.Text = self.Text;
                    dynamicTextBox.Location = new System.Drawing.Point(self.Location.X, self.Location.Y);
                    this.Controls.Add(dynamicTextBox);
                    dynamicTextBox.BringToFront();
                    dynamicTextBox.Focus();
                    dynamicTextBox.LostFocus += (s, args) => TextBox_LostFocus(s, args, self);
                }
            }
        }
    }
}