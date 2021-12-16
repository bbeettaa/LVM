using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LVM_Lab_4
{
    public partial class DialogForm : Form
    {
        string message;
        Form1 form1;
        public DialogForm(Form1 f)
        {
            InitializeComponent();
            form1 = f;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form1.EnableWhichOption = true;
            form1.SetMessage(message);
            form1.SetMessage2(WhichOptionChoose());
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            message = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public String WhichOptionChoose()
        {
            if (radioButton1.Checked) return radioButton1.Text;
            if (radioButton2.Checked) return radioButton2.Text;
            if (radioButton3.Checked) return radioButton3.Text;
            if (radioButton4.Checked) return radioButton4.Text;
            if (radioButton5.Checked) return radioButton5.Text;
            if (radioButton6.Checked) return radioButton6.Text;
            return "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult df = MessageBox.Show("YES ?","Message",MessageBoxButtons.RetryCancel,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1,MessageBoxOptions.DefaultDesktopOnly);
            form1.SetDialogResult( df);
        }
    }
}
