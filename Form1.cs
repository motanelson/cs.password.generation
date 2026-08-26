using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.IO;
namespace Winpassgerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void generateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = 50;
            String s = "";
            String ss = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ#____";
            Random rnd = new Random();
            try
            {
                i = int.Parse(textBox2.Text);
                for (int j = 0; j < i; j++)
                {

                    for (int ii = 0; ii < 12; ii++)
                    {
                        s = s + ss[rnd.Next(ss.Length - 3)];
                    }
                    s = s + "\r\n";
                }
                textBox1.Text = s;
            }
            catch (Exception ex) 
            {
                MessageBox.Show("size error");
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "") 
            {
                File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);
            
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "") 
            { 
                textBox1.Text=File.ReadAllText (openFileDialog1.FileName);
            
            
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);

            }
            textBox1.Text = "";
        }
    }
}
