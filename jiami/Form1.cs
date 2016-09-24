using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace jiami
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inFile = textBox1.Text;
            string outFile = inFile + ".ac";
            string password = textBox2.Text;
            DESFile.DESFileClass.EncryptFile(inFile, outFile, password);//加密文件 
            //删除加密前的文件 
            File.Delete(inFile);
            textBox1.Text = string.Empty;
            MessageBox.Show("加密成功"); 
         } 
            private void button3_Click(object sender, EventArgs e)
            {
                OpenFileDialog f = new OpenFileDialog();
                if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    textBox1.Text = f.FileName;
                } 
            }

            private void button2_Click(object sender, EventArgs e)
            {
                string inFile = textBox1.Text;
                string outFile = inFile.Substring(0, inFile.Length - 4);
                string password = textBox2.Text;
                DESFile.DESFileClass.DecryptFile(inFile, outFile, password);//解密文件 
                //删除解密前的文件 
                File.Delete(inFile);
                textBox1.Text = string.Empty;
                MessageBox.Show("解密成功"); 
            }
    }
}
