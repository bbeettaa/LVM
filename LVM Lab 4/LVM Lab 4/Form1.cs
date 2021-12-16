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
    public partial class Form1 : Form
    {
        String message2="";
        private DialogResult dialogResult;
        public void SetMessage(string mess) { ResultDialogTextBox.Text = mess; }
        public void SetMessage2(string mess) { message2 = mess; }
        public bool EnableWhichOption { set { WhichOption.Enabled = value; } }


        public Form1()
        {
            InitializeComponent();
        }

        public void SetDialogResult(DialogResult df) { ResultDialogTextBox.Text = df.ToString();  }

        private void YesNoCancelButton_Click(object sender, EventArgs e)
        {
            messageShow("Choose one from variants", MessageBoxButtons.YesNoCancel);
        }

        private void AbbortRetryIgnoreButton_Click(object sender, EventArgs e)
        {
            messageShow("Choose one from variants", MessageBoxButtons.AbortRetryIgnore);
        }

        public void messageShow(string message, MessageBoxButtons mbb)
        {
            dialogResult = MessageBox.Show(message, "Message", mbb, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            ResultDialogTextBox.Text = dialogResult.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            String fileName = openFileDialog1.FileName;
            int pos = fileName.LastIndexOf("\\");
            fileName = fileName.Remove(0, pos+1);

            ResultDialogTextBox.Text = fileName;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogForm df = new DialogForm(this);
            df.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WhichOption_Click(object sender, EventArgs e)
        {
   
            ResultDialogTextBox.Text = message2;
        }
    }
}
