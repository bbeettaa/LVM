using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LVM_Lab_2
{
    public partial class Form1 : Form
    {
        bool isRunProgramEnable = true;
        bool isEnterMessageEnable = true;

        bool isShowRunProgramEnable = true;
        bool isShowEnterMessageEnable = true;
        String choosenProgram;

        string userName;
        string compName;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox2.Items.Add("iexplore.exe");
            comboBox2.Items.Add("mspaint.exe");
            comboBox2.Items.Add("WordPad.exe");
            comboBox2.Items.Add("notepad.exe");
            comboBox2.Items.Add("calc.exe");
            comboBox2.Items.Add("charmap.exe");
            comboBox2.Items.Add("xpsrchvw.exe");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Enter a message here.";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(choosenProgram!=null)
            Process.Start(choosenProgram);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            choosenProgram = comboBox2.Text;

            if (isRunProgramEnable)
                isRunProgramEnable = false;
            else
                isRunProgramEnable = true;

            checkBox2.Checked = isRunProgramEnable;

            button4.Enabled = isRunProgramEnable;
            comboBox2.Enabled = isRunProgramEnable;
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (isEnterMessageEnable)
                isEnterMessageEnable  = false;
            else
                isEnterMessageEnable = true;

            checkBox1.Checked = isEnterMessageEnable;

            button1.Enabled = isEnterMessageEnable;
            textBox1.Enabled = isEnterMessageEnable;
        }

        private void checkBox3_Click(object sender, EventArgs e)
        {
            if (isShowRunProgramEnable)
            {
             
                button4.Hide();
                comboBox2.Hide();
                label2.Hide();
                isShowRunProgramEnable = false;
            }
            else
            {
              
                button4.Show();
                comboBox2.Show();
                label2.Show();
                isShowRunProgramEnable = true;
            }
        }

        private void checkBox4_Click(object sender, EventArgs e)
        {
            if (isShowEnterMessageEnable)
            {
                textBox1.Hide();
                button1.Hide();
                button2.Hide();
                button3.Hide();
                
                label1.Hide();
                isShowEnterMessageEnable = false;
            }
            else
            {
                textBox1.Show();
                button1.Show();
                button2.Show();
                button3.Show();
       
                label1.Show();
                isShowEnterMessageEnable = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            userName = Environment.UserName;
            label3.Text = Environment.UserName;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            compName = SystemInformation.ComputerName;
            label4.Text = compName;
        }
    }
}
