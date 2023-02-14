using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckListBox {
    public partial class Form1 : Form {
        //checkbox DB
        bool cbx01 = Properties.Settings.Default.checkbox01;
        bool cbx02 = Properties.Settings.Default.checkbox02;
        bool cbx03 = Properties.Settings.Default.checkbox03;
        bool cbx04 = Properties.Settings.Default.checkbox04;
        bool cbx05 = Properties.Settings.Default.checkbox05;
        bool cbx06 = Properties.Settings.Default.checkbox06;
        bool cbx07 = Properties.Settings.Default.checkbox07;
        bool cbx08 = Properties.Settings.Default.checkbox08;
        bool cbx09 = Properties.Settings.Default.checkbox09;
        bool cbx10 = Properties.Settings.Default.checkbox10;
        bool cbx11 = Properties.Settings.Default.checkbox11;
        bool cbx12 = Properties.Settings.Default.checkbox12;
        bool cbx13 = Properties.Settings.Default.checkbox13;
        bool cbx14 = Properties.Settings.Default.checkbox14;
        bool cbx15 = Properties.Settings.Default.checkbox15;
        bool cbx16 = Properties.Settings.Default.checkbox16;
        bool cbx17 = Properties.Settings.Default.checkbox17;
        bool cbx18 = Properties.Settings.Default.checkbox18;
        bool cbx19 = Properties.Settings.Default.checkbox19;
        bool cbx20 = Properties.Settings.Default.checkbox20;
        bool cbx21 = Properties.Settings.Default.checkbox21;
        bool cbx22 = Properties.Settings.Default.checkbox22;
        bool cbx23 = Properties.Settings.Default.checkbox23;
        bool cbx24 = Properties.Settings.Default.checkbox24;
        bool cbx25 = Properties.Settings.Default.checkbox25;
        /*bool cbx26 = Properties.Settings.Default.checkbox26;
        bool cbx27 = Properties.Settings.Default.checkbox27;
        bool cbx28 = Properties.Settings.Default.checkbox28;
        bool cbx29 = Properties.Settings.Default.checkbox29;
        bool cbx30 = Properties.Settings.Default.checkbox30;
        bool cbx31 = Properties.Settings.Default.checkbox31;
        bool cbx32 = Properties.Settings.Default.checkbox32;
        bool cbx33 = Properties.Settings.Default.checkbox33;
        bool cbx34 = Properties.Settings.Default.checkbox34;
        bool cbx35 = Properties.Settings.Default.checkbox35;
        bool cbx36 = Properties.Settings.Default.checkbox36;
        bool cbx37 = Properties.Settings.Default.checkbox37;
        bool cbx38 = Properties.Settings.Default.checkbox38;
        bool cbx39 = Properties.Settings.Default.checkbox39;
        bool cbx40 = Properties.Settings.Default.checkbox40;
        bool cbx41 = Properties.Settings.Default.checkbox41;
        bool cbx42 = Properties.Settings.Default.checkbox42;
        bool cbx43 = Properties.Settings.Default.checkbox43;
        bool cbx44 = Properties.Settings.Default.checkbox44;
        bool cbx45 = Properties.Settings.Default.checkbox45;
        bool cbx46 = Properties.Settings.Default.checkbox46;
        bool cbx47 = Properties.Settings.Default.checkbox47;
        bool cbx48 = Properties.Settings.Default.checkbox48;
        bool cbx49 = Properties.Settings.Default.checkbox49;
        bool cbx50 = Properties.Settings.Default.checkbox50;
        bool cbx51 = Properties.Settings.Default.checkbox51;
        bool cbx52 = Properties.Settings.Default.checkbox52;
        bool cbx53 = Properties.Settings.Default.checkbox53;
        bool cbx54 = Properties.Settings.Default.checkbox54;
        bool cbx55 = Properties.Settings.Default.checkbox55;
        bool cbx56 = Properties.Settings.Default.checkbox56;
        bool cbx57 = Properties.Settings.Default.checkbox57;
        bool cbx58 = Properties.Settings.Default.checkbox58;
        bool cbx59 = Properties.Settings.Default.checkbox59;
        bool cbx60 = Properties.Settings.Default.checkbox60;
        bool cbx61 = Properties.Settings.Default.checkbox61;
        bool cbx62 = Properties.Settings.Default.checkbox62;
        bool cbx63 = Properties.Settings.Default.checkbox63;*/

        //-----------------------------------------------------------
        //numberbox DB
        /*      int numb01 = Properties.Settings.Default.num1;
              int numb02 = Properties.Settings.Default.num2;
              int numb03 = Properties.Settings.Default.num3;
              int numb04 = Properties.Settings.Default.num4;
              int numb05 = Properties.Settings.Default.num5;
              int numb06 = Properties.Settings.Default.num6;
              int numb07 = Properties.Settings.Default.num7;
              int numb08 = Properties.Settings.Default.num8;
              int numb09 = Properties.Settings.Default.num9;
              int numb10 = Properties.Settings.Default.num10;
              int numb11 = Properties.Settings.Default.num11;
              int numb12 = Properties.Settings.Default.num12;
              int numb13 = Properties.Settings.Default.num13;
              int numb14 = Properties.Settings.Default.num14;
              int numb15 = Properties.Settings.Default.num15;
              int numb16 = Properties.Settings.Default.num16;
              int numb17 = Properties.Settings.Default.num17;
              int numb18 = Properties.Settings.Default.num18;*/

        //-------------------------------------------------------------
        //textbox DB
        string tbx01 = Properties.Settings.Default.textbox01;
        //string tbx02 = Properties.Settings.Default.textbox02;

        public Form1() {
            InitializeComponent();
            this.MaximizeBox = false;
        }
        private void Form1_Load(object sender, EventArgs e) {
            //checkbox check state
            checkBox1.Checked = cbx01;
            checkBox2.Checked = cbx02;
            checkBox3.Checked = cbx03;
            checkBox4.Checked = cbx04;
            checkBox5.Checked = cbx05;
            checkBox6.Checked = cbx06;
            checkBox7.Checked = cbx07;
            checkBox8.Checked = cbx08;
            checkBox9.Checked = cbx09;
            checkBox10.Checked = cbx10;
            checkBox11.Checked = cbx11;
            checkBox12.Checked = cbx12;
            checkBox13.Checked = cbx13;
            checkBox14.Checked = cbx14;
            checkBox15.Checked = cbx15;
            checkBox16.Checked = cbx16;
            checkBox17.Checked = cbx17;
            checkBox18.Checked = cbx18;
            checkBox19.Checked = cbx19;
            checkBox20.Checked = cbx20;
            //checkBox21.Checked = cbx21;
            //checkBox22.Checked = cbx22;
            checkBox23.Checked = cbx23;
            checkBox24.Checked = cbx24;
            //checkBox25.Checked = cbx25;
            /*            checkBox26.Checked = cbx26;
                        checkBox27.Checked = cbx27;
                        checkBox28.Checked = cbx28;
                        checkBox29.Checked = cbx29;
                        checkBox30.Checked = cbx30;
                        checkBox31.Checked = cbx31;
                        checkBox32.Checked = cbx32;
                        checkBox33.Checked = cbx33;
                        checkBox34.Checked = cbx34;
                        checkBox35.Checked = cbx35;
                        checkBox36.Checked = cbx36;
                        checkBox37.Checked = cbx37;
                        checkBox38.Checked = cbx38;
                        checkBox39.Checked = cbx39;
                        checkBox40.Checked = cbx40;
                        checkBox41.Checked = cbx41;
                        checkBox42.Checked = cbx42;
                        checkBox43.Checked = cbx43;
                        checkBox44.Checked = cbx44;
                        checkBox45.Checked = cbx45;
                        checkBox46.Checked = cbx46;
                        checkBox47.Checked = cbx47;
                        checkBox48.Checked = cbx48;
                        checkBox49.Checked = cbx49;
                        checkBox50.Checked = cbx50;
                        checkBox51.Checked = cbx51;
                        checkBox52.Checked = cbx52;
                        checkBox53.Checked = cbx53;
                        checkBox54.Checked = cbx54;
                        checkBox55.Checked = cbx55;
                        checkBox56.Checked = cbx56;
                        checkBox57.Checked = cbx57;
                        checkBox58.Checked = cbx58;
                        checkBox59.Checked = cbx59;
                        checkBox60.Checked = cbx60;
                        checkBox61.Checked = cbx61;
                        checkBox62.Checked = cbx62;
                        checkBox63.Checked = cbx63;*/

            //---------------------------------------------
            //numberbox check state
        /*  numericUpDown1.Value = numb01;
            numericUpDown2.Value = numb02;
            numericUpDown3.Value = numb03;
            numericUpDown4.Value = numb04;
            numericUpDown5.Value = numb05;
            numericUpDown6.Value = numb06;
            numericUpDown7.Value = numb07;
            numericUpDown8.Value = numb08;
            numericUpDown9.Value = numb09;
            numericUpDown10.Value = numb10;
            numericUpDown11.Value = numb11;
            numericUpDown12.Value = numb12;
            numericUpDown13.Value = numb13;
            numericUpDown14.Value = numb14;
            numericUpDown15.Value = numb15;
            numericUpDown16.Value = numb16;
            numericUpDown17.Value = numb17;
            numericUpDown18.Value = numb18;*/

            //------------------------------------------------
            //textbox check state
            textBox1.Text = tbx01;
        }

        //-----------------------------------------------------
        //button event
        private void button1_Click(object sender, EventArgs e) {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;
            checkBox17.Checked = false;
            checkBox18.Checked = false;
            checkBox19.Checked = false;
            checkBox20.Checked = false;
            //checkBox21.Checked = false;
            //checkBox22.Checked = false;
            checkBox23.Checked = false;
            checkBox24.Checked = false;
            //checkBox25.Checked = false;
        }
        private void button2_Click(object sender, EventArgs e) {

/*            checkBox26.Checked = false;
            checkBox27.Checked = false;
            checkBox28.Checked = false;
            checkBox29.Checked = false;
            checkBox30.Checked = false;
            checkBox31.Checked = false;
            checkBox32.Checked = false;
            checkBox33.Checked = false;
            checkBox34.Checked = false;
            checkBox35.Checked = false;
            checkBox36.Checked = false;
            checkBox37.Checked = false;
            checkBox38.Checked = false;
            checkBox39.Checked = false;
            checkBox40.Checked = false;
            checkBox41.Checked = false;
            checkBox42.Checked = false;
            checkBox43.Checked = false;
            checkBox44.Checked = false;
            checkBox45.Checked = false;
            checkBox46.Checked = false;
            checkBox47.Checked = false;
            checkBox48.Checked = false;
            checkBox49.Checked = false;
            checkBox50.Checked = false;
            checkBox51.Checked = false;
            checkBox52.Checked = false;
            checkBox53.Checked = false;
            checkBox54.Checked = false;
            checkBox55.Checked = false;
            checkBox56.Checked = false;
            checkBox57.Checked = false;
            checkBox58.Checked = false;
            checkBox59.Checked = false;
            checkBox60.Checked = false;
            checkBox61.Checked = false;
            checkBox62.Checked = false;
            checkBox63.Checked = false;*/
        }

        //--------------------------------------------------------------------
        //checkbox event
        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            cbx01 = checkBox1.Checked;
            Properties.Settings.Default.checkbox01 = cbx01;
            Properties.Settings.Default.Save();
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e) {
            cbx02 = checkBox2.Checked;
            Properties.Settings.Default.checkbox02 = cbx02;
            Properties.Settings.Default.Save();
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e) {
            cbx03 = checkBox3.Checked;
            Properties.Settings.Default.checkbox03 = cbx03;
            Properties.Settings.Default.Save();
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e) {
            cbx04 = checkBox4.Checked;
            Properties.Settings.Default.checkbox04 = cbx04;
            Properties.Settings.Default.Save();
        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e) {
            cbx05 = checkBox5.Checked;
            Properties.Settings.Default.checkbox05 = cbx05;
            Properties.Settings.Default.Save();
        }
        private void checkBox6_CheckedChanged(object sender, EventArgs e) {
            cbx06 = checkBox6.Checked;
            Properties.Settings.Default.checkbox06 = cbx06;
            Properties.Settings.Default.Save();
        }
        private void checkBox7_CheckedChanged(object sender, EventArgs e) {
            cbx07 = checkBox7.Checked;
            Properties.Settings.Default.checkbox07 = cbx07;
            Properties.Settings.Default.Save();
        }
        private void checkBox8_CheckedChanged(object sender, EventArgs e) {
            cbx08 = checkBox8.Checked;
            Properties.Settings.Default.checkbox08 = cbx08;
            Properties.Settings.Default.Save();
        }
        private void checkBox9_CheckedChanged(object sender, EventArgs e) {
            cbx09 = checkBox9.Checked;
            Properties.Settings.Default.checkbox09 = cbx09;
            Properties.Settings.Default.Save();
        }
        private void checkBox10_CheckedChanged(object sender, EventArgs e) {
            cbx10 = checkBox10.Checked;
            Properties.Settings.Default.checkbox10 = cbx10;
            Properties.Settings.Default.Save();
        }
        private void checkBox11_CheckedChanged(object sender, EventArgs e) {
            cbx11 = checkBox11.Checked;
            Properties.Settings.Default.checkbox11 = cbx11;
            Properties.Settings.Default.Save();
        }
        private void checkBox12_CheckedChanged(object sender, EventArgs e) {
            cbx12 = checkBox12.Checked;
            Properties.Settings.Default.checkbox12 = cbx12;
            Properties.Settings.Default.Save();
        }
        private void checkBox13_CheckedChanged(object sender, EventArgs e) {
            cbx13 = checkBox13.Checked;
            Properties.Settings.Default.checkbox13 = cbx13;
            Properties.Settings.Default.Save();
        }
        private void checkBox14_CheckedChanged(object sender, EventArgs e) {
            cbx14 = checkBox14.Checked;
            Properties.Settings.Default.checkbox14 = cbx14;
            Properties.Settings.Default.Save();
        }
        private void checkBox15_CheckedChanged(object sender, EventArgs e) {
            cbx15 = checkBox15.Checked;
            Properties.Settings.Default.checkbox15 = cbx15;
            Properties.Settings.Default.Save();
        }
        private void checkBox16_CheckedChanged(object sender, EventArgs e) {
            cbx16 = checkBox16.Checked;
            Properties.Settings.Default.checkbox16 = cbx16;
            Properties.Settings.Default.Save();
        }
        private void checkBox17_CheckedChanged(object sender, EventArgs e) {
            cbx17 = checkBox17.Checked;
            Properties.Settings.Default.checkbox17 = cbx17;
            Properties.Settings.Default.Save();
        }
        private void checkBox18_CheckedChanged(object sender, EventArgs e) {
            cbx18 = checkBox18.Checked;
            Properties.Settings.Default.checkbox18 = cbx18;
            Properties.Settings.Default.Save();
        }
        private void checkBox19_CheckedChanged(object sender, EventArgs e) {
            cbx19 = checkBox19.Checked;
            Properties.Settings.Default.checkbox19 = cbx19;
            Properties.Settings.Default.Save();
        }
        private void checkBox20_CheckedChanged(object sender, EventArgs e) {
            cbx20 = checkBox20.Checked;
            Properties.Settings.Default.checkbox20 = cbx20;
            Properties.Settings.Default.Save();
        }
/*        private void checkBox21_CheckedChanged(object sender, EventArgs e) {
            cbx21 = checkBox21.Checked;
            Properties.Settings.Default.checkbox21 = cbx21;
            Properties.Settings.Default.Save();
        }
        private void checkBox22_CheckedChanged(object sender, EventArgs e) {
            cbx22 = checkBox22.Checked;
            Properties.Settings.Default.checkbox22 = cbx22;
            Properties.Settings.Default.Save();
        }*/
        private void checkBox23_CheckedChanged(object sender, EventArgs e) {
            cbx23 = checkBox23.Checked;
            Properties.Settings.Default.checkbox23 = cbx23;
            Properties.Settings.Default.Save();
        }
        private void checkBox24_CheckedChanged(object sender, EventArgs e) {
            cbx24 = checkBox24.Checked;
            Properties.Settings.Default.checkbox24 = cbx24;
            Properties.Settings.Default.Save();
        }
/*        private void checkBox25_CheckedChanged(object sender, EventArgs e) {
            cbx25 = checkBox25.Checked;
            Properties.Settings.Default.checkbox25 = cbx25;
            Properties.Settings.Default.Save();
        }*/
/*        private void checkBox26_CheckedChanged(object sender, EventArgs e)
        {
            cbx26 = checkBox26.Checked;
            Properties.Settings.Default.checkbox26 = cbx26;
            Properties.Settings.Default.Save();
        }
        private void checkBox27_CheckedChanged(object sender, EventArgs e)
        {
            cbx27 = checkBox27.Checked;
            Properties.Settings.Default.checkbox27 = cbx27;
            Properties.Settings.Default.Save();
        }
        private void checkBox28_CheckedChanged(object sender, EventArgs e)
        {
            cbx28 = checkBox28.Checked;
            Properties.Settings.Default.checkbox28 = cbx28;
            Properties.Settings.Default.Save();
        }
        private void checkBox29_CheckedChanged(object sender, EventArgs e)
        {
            cbx29 = checkBox29.Checked;
            Properties.Settings.Default.checkbox29 = cbx29;
            Properties.Settings.Default.Save();
        }
        private void checkBox30_CheckedChanged(object sender, EventArgs e)
        {
            cbx30 = checkBox30.Checked;
            Properties.Settings.Default.checkbox30 = cbx30;
            Properties.Settings.Default.Save();
        }
        private void checkBox31_CheckedChanged(object sender, EventArgs e)
        {
            cbx31 = checkBox31.Checked;
            Properties.Settings.Default.checkbox31 = cbx31;
            Properties.Settings.Default.Save();
        }
        private void checkBox32_CheckedChanged(object sender, EventArgs e)
        {
            cbx32 = checkBox32.Checked;
            Properties.Settings.Default.checkbox32 = cbx32;
            Properties.Settings.Default.Save();
        }
        private void checkBox33_CheckedChanged(object sender, EventArgs e)
        {
            cbx33 = checkBox33.Checked;
            Properties.Settings.Default.checkbox33 = cbx33;
            Properties.Settings.Default.Save();
        }
        private void checkBox34_CheckedChanged(object sender, EventArgs e)
        {
            cbx34 = checkBox34.Checked;
            Properties.Settings.Default.checkbox34 = cbx34;
            Properties.Settings.Default.Save();
        }
        private void checkBox35_CheckedChanged(object sender, EventArgs e)
        {
            cbx35 = checkBox35.Checked;
            Properties.Settings.Default.checkbox35 = cbx35;
            Properties.Settings.Default.Save();
        }
        private void checkBox36_CheckedChanged(object sender, EventArgs e)
        {
            cbx36 = checkBox36.Checked;
            Properties.Settings.Default.checkbox36 = cbx36;
            Properties.Settings.Default.Save();
        }
        private void checkBox37_CheckedChanged(object sender, EventArgs e)
        {
            cbx37 = checkBox37.Checked;
            Properties.Settings.Default.checkbox37 = cbx37;
            Properties.Settings.Default.Save();
        }
        private void checkBox38_CheckedChanged(object sender, EventArgs e)
        {
            cbx38 = checkBox38.Checked;
            Properties.Settings.Default.checkbox38 = cbx38;
            Properties.Settings.Default.Save();
        }
        private void checkBox39_CheckedChanged(object sender, EventArgs e)
        {
            cbx39 = checkBox39.Checked;
            Properties.Settings.Default.checkbox39 = cbx39;
            Properties.Settings.Default.Save();
        }
        private void checkBox40_CheckedChanged(object sender, EventArgs e)
        {
            cbx40 = checkBox40.Checked;
            Properties.Settings.Default.checkbox40 = cbx40;
            Properties.Settings.Default.Save();
        }
        private void checkBox41_CheckedChanged(object sender, EventArgs e)
        {
            cbx41 = checkBox41.Checked;
            Properties.Settings.Default.checkbox41 = cbx41;
            Properties.Settings.Default.Save();
        }
        private void checkBox42_CheckedChanged(object sender, EventArgs e)
        {
            cbx42 = checkBox42.Checked;
            Properties.Settings.Default.checkbox42 = cbx42;
            Properties.Settings.Default.Save();
        }
        private void checkBox43_CheckedChanged(object sender, EventArgs e)
        {
            cbx43 = checkBox43.Checked;
            Properties.Settings.Default.checkbox43 = cbx43;
            Properties.Settings.Default.Save();
        }
        private void checkBox44_CheckedChanged(object sender, EventArgs e)
        {
            cbx44 = checkBox44.Checked;
            Properties.Settings.Default.checkbox44 = cbx44;
            Properties.Settings.Default.Save();
        }
        private void checkBox45_CheckedChanged(object sender, EventArgs e)
        {
            cbx45 = checkBox45.Checked;
            Properties.Settings.Default.checkbox45 = cbx45;
            Properties.Settings.Default.Save();
        }
        private void checkBox46_CheckedChanged(object sender, EventArgs e)
        {
            cbx46 = checkBox46.Checked;
            Properties.Settings.Default.checkbox46 = cbx46;
            Properties.Settings.Default.Save();
        }
        private void checkBox47_CheckedChanged(object sender, EventArgs e)
        {
            cbx47 = checkBox47.Checked;
            Properties.Settings.Default.checkbox47 = cbx47;
            Properties.Settings.Default.Save();
        }
        private void checkBox48_CheckedChanged(object sender, EventArgs e)
        {
            cbx48 = checkBox48.Checked;
            Properties.Settings.Default.checkbox48 = cbx48;
            Properties.Settings.Default.Save();
        }
        private void checkBox49_CheckedChanged(object sender, EventArgs e)
        {
            cbx49 = checkBox49.Checked;
            Properties.Settings.Default.checkbox49 = cbx49;
            Properties.Settings.Default.Save();
        }
        private void checkBox50_CheckedChanged(object sender, EventArgs e)
        {
            cbx50 = checkBox50.Checked;
            Properties.Settings.Default.checkbox50 = cbx50;
            Properties.Settings.Default.Save();
        }
        private void checkBox51_CheckedChanged(object sender, EventArgs e)
        {
            cbx51 = checkBox51.Checked;
            Properties.Settings.Default.checkbox51 = cbx51;
            Properties.Settings.Default.Save();
        }
        private void checkBox52_CheckedChanged(object sender, EventArgs e)
        {
            cbx52 = checkBox52.Checked;
            Properties.Settings.Default.checkbox52 = cbx52;
            Properties.Settings.Default.Save();
        }
        private void checkBox53_CheckedChanged(object sender, EventArgs e)
        {
            cbx53 = checkBox53.Checked;
            Properties.Settings.Default.checkbox53 = cbx53;
            Properties.Settings.Default.Save();
        }
        private void checkBox54_CheckedChanged(object sender, EventArgs e)
        {
            cbx54 = checkBox54.Checked;
            Properties.Settings.Default.checkbox54 = cbx54;
            Properties.Settings.Default.Save();
        }
        private void checkBox55_CheckedChanged(object sender, EventArgs e)
        {
            cbx55 = checkBox55.Checked;
            Properties.Settings.Default.checkbox55 = cbx55;
            Properties.Settings.Default.Save();
        }
        private void checkBox56_CheckedChanged(object sender, EventArgs e)
        {
            cbx56 = checkBox56.Checked;
            Properties.Settings.Default.checkbox56 = cbx56;
            Properties.Settings.Default.Save();
        }
        private void checkBox57_CheckedChanged(object sender, EventArgs e)
        {
            cbx57 = checkBox57.Checked;
            Properties.Settings.Default.checkbox57 = cbx57;
            Properties.Settings.Default.Save();
        }
        private void checkBox58_CheckedChanged(object sender, EventArgs e)
        {
            cbx58 = checkBox58.Checked;
            Properties.Settings.Default.checkbox58 = cbx58;
            Properties.Settings.Default.Save();
        }
        private void checkBox59_CheckedChanged(object sender, EventArgs e)
        {
            cbx59 = checkBox59.Checked;
            Properties.Settings.Default.checkbox59 = cbx59;
            Properties.Settings.Default.Save();
        }
        private void checkBox60_CheckedChanged(object sender, EventArgs e)
        {
            cbx60 = checkBox60.Checked;
            Properties.Settings.Default.checkbox60 = cbx60;
            Properties.Settings.Default.Save();
        }
        private void checkBox61_CheckedChanged(object sender, EventArgs e)
        {
            cbx61 = checkBox61.Checked;
            Properties.Settings.Default.checkbox61 = cbx61;
            Properties.Settings.Default.Save();
        }
        private void checkBox62_CheckedChanged(object sender, EventArgs e)
        {
            cbx62 = checkBox62.Checked;
            Properties.Settings.Default.checkbox62 = cbx62;
            Properties.Settings.Default.Save();
        }
        private void checkBox63_CheckedChanged(object sender, EventArgs e)
        {
            cbx63 = checkBox63.Checked;
            Properties.Settings.Default.checkbox63 = cbx63;
            Properties.Settings.Default.Save();
        }*/

        //------------------------------------------------------------------------
        //textbox event
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            tbx01 = textBox1.Text;
            Properties.Settings.Default.textbox01 = tbx01;
            Properties.Settings.Default.Save();
        }

        private void label19_Click (object sender, EventArgs e) {

        }
        /*        private void textBox2_TextChanged(object sender, EventArgs e) {
           tbx02 = textBox2.Text;
           Properties.Settings.Default.textbox02 = tbx02;
           Properties.Settings.Default.Save();
       }*/

        //------------------------------------------------------------------------
        //numberbox event
        /*        private void numericUpDown1_ValueChanged(object sender, EventArgs e) {
                    numb01 = (int)numericUpDown1.Value;
                    Properties.Settings.Default.num1 = numb01;
                    Properties.Settings.Default.Save();
                }
                private void numericUpDown2_ValueChanged(object sender, EventArgs e) {
                    numb02 = (int)numericUpDown2.Value;
                    Properties.Settings.Default.num2 = numb02;
                    Properties.Settings.Default.Save();
                }
                private void numericUpDown3_ValueChanged(object sender, EventArgs e) {
                    numb03 = (int)numericUpDown3.Value;
                    Properties.Settings.Default.num3 = numb03;
                    Properties.Settings.Default.Save();
                }
                private void numericUpDown4_ValueChanged(object sender, EventArgs e) {
                    numb04 = (int)numericUpDown4.Value;
                    Properties.Settings.Default.num4 = numb04;
                    Properties.Settings.Default.Save();
                }
                private void numericUpDown5_ValueChanged(object sender, EventArgs e) {
                    numb05 = (int)numericUpDown5.Value;
                    Properties.Settings.Default.num5 = numb05;
                    Properties.Settings.Default.Save();
                }
                private void numericUpDown6_ValueChanged(object sender, EventArgs e) {
                    numb06 = (int)numericUpDown6.Value;
                    Properties.Settings.Default.num6 = numb06;
                    Properties.Settings.Default.Save();
                }
                private void numericUpDown7_ValueChanged(object sender, EventArgs e) {
                    numb07 = (int)numericUpDown7.Value;
                    Properties.Settings.Default.num7 = numb07;
                    Properties.Settings.Default.Save();
                }
                private void numericUpDown8_ValueChanged(object sender, EventArgs e) {
                    numb08 = (int)numericUpDown8.Value;
                    Properties.Settings.Default.num8 = numb08;
                    Properties.Settings.Default.Save();
                }
                private void numericUpDown9_ValueChanged(object sender, EventArgs e) {
                    numb09 = (int)numericUpDown9.Value;
                    Properties.Settings.Default.num9 = numb09;
                    Properties.Settings.Default.Save();
                }
                private void numericUpDown10_ValueChanged(object sender, EventArgs e) {
                    numb10 = (int)numericUpDown10.Value;
                    Properties.Settings.Default.num10 = numb10;
                    Properties.Settings.Default.Save();
                }
                private void numericUpDown11_ValueChanged(object sender, EventArgs e) {
                    numb11 = (int)numericUpDown11.Value;
                    Properties.Settings.Default.num11 = numb11;
                    Properties.Settings.Default.Save();
                }
                private void numericUpDown12_ValueChanged(object sender, EventArgs e) {
                    numb12 = (int)numericUpDown12.Value;
                    Properties.Settings.Default.num12 = numb12;
                    Properties.Settings.Default.Save();
                }
                private void numericUpDown13_ValueChanged(object sender, EventArgs e) {
                    numb13 = (int)numericUpDown13.Value;
                    Properties.Settings.Default.num13 = numb13;
                    Properties.Settings.Default.Save();
                }
                private void numericUpDown14_ValueChanged(object sender, EventArgs e) {
                    numb14 = (int)numericUpDown14.Value;
                    Properties.Settings.Default.num14 = numb14;
                    Properties.Settings.Default.Save();
                }
                private void numericUpDown15_ValueChanged(object sender, EventArgs e) {
                    numb15 = (int)numericUpDown15.Value;
                    Properties.Settings.Default.num15 = numb15;
                    Properties.Settings.Default.Save();
                }
                private void numericUpDown16_ValueChanged(object sender, EventArgs e) {
                    numb16 = (int)numericUpDown16.Value;
                    Properties.Settings.Default.num16 = numb16;
                    Properties.Settings.Default.Save();
                }
                private void numericUpDown17_ValueChanged(object sender, EventArgs e) {
                    numb17 = (int)numericUpDown17.Value;
                    Properties.Settings.Default.num17 = numb17;
                    Properties.Settings.Default.Save();
                }
                private void numericUpDown18_ValueChanged(object sender, EventArgs e) {
                    numb18 = (int)numericUpDown18.Value;
                    Properties.Settings.Default.num18 = numb18;
                    Properties.Settings.Default.Save();
                }*/
    }
}