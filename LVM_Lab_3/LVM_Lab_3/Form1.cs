using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LVM_Lab_3
{
    public partial class Form1 : Form
    {
        String messageText = "Hello world!";
        String messageCaption = "message";
        bool isMessageEnable = true;
        public Form1()
        {
            InitializeComponent();

        }

        private void messageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showMessage();
        }

        private void aboutCTRLAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showMessage("Людино-машинна взаємодія. \n10.12.2021\nЛабораторна робота № 3\nПідготував Крупіна Іван Олександрович.","LVM-Lab-3");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkToolStripMenuItem_Click(object sender, EventArgs e)
        {

            isMessageEnable = !checkToolStripMenuItem.Checked;
            checkToolStripMenuItem.Checked = isMessageEnable;


            messageToolStripMenuItem.Enabled = isMessageEnable;
            toolStripButtonMenu.Enabled = isMessageEnable;
        }

        private void showMessage(String messageText = "Hello world!", String messageCaption = "message") {
            MessageBox.Show(messageText, messageCaption);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                fileToolStripMenuItem.DropDownItems.Add("New").Tag = "created"; 
                fileToolStripMenuItem.DropDownItems.Add("Open").Tag = "created";
                fileToolStripMenuItem.DropDownItems.Add("Close").Tag = "created";
            }
            if (e.KeyCode == Keys.D)
            {
                for(int i =0;i< fileToolStripMenuItem.DropDownItems.Count;i++)
                    if (fileToolStripMenuItem.DropDownItems[i].Tag == "created")
                        fileToolStripMenuItem.DropDownItems.Remove(fileToolStripMenuItem.DropDownItems[i--]);
            }
        }
    }
}
