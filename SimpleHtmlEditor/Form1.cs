using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;



namespace SimpleHtmlEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)//<p>
        {
            if(richTextBox1.SelectionLength > 0)
            {
                string SelectedText ="<p>" + richTextBox1.SelectedText + "</p>";
                richTextBox1.SelectedText = richTextBox1.SelectedText.Replace(richTextBox1.SelectedText.ToString(), SelectedText);
            }
            else
            {
                MessageBox.Show("Select text first!");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)//<h1>
        {
            if (richTextBox1.SelectionLength > 0)
            {
                string SelectedText = "<h1>" + richTextBox1.SelectedText + "</h1>";
                richTextBox1.SelectedText = richTextBox1.SelectedText.Replace(richTextBox1.SelectedText.ToString(), SelectedText);
            }
            else
            {
                MessageBox.Show("Select text first!");
            }


        }

        private void button3_Click(object sender, EventArgs e)//h2
        {
            if(richTextBox1.SelectionLength > 0)
            {
                string SelectedText = "<h2>" + richTextBox1.SelectedText + "</h2>";
                richTextBox1.SelectedText = richTextBox1.SelectedText.Replace(richTextBox1.SelectedText.ToString(), SelectedText);
            }
            else
            {
                MessageBox.Show("Select text first!");
            }

        }

        private void button4_Click(object sender, EventArgs e)//h3
        {
            if (richTextBox1.SelectionLength > 0)
            {
                string SelectedText = "<h3>" + richTextBox1.SelectedText + "</h3>";
                richTextBox1.SelectedText = richTextBox1.SelectedText.Replace(richTextBox1.SelectedText.ToString(), SelectedText);
            }
            else
            {
                MessageBox.Show("Select text first!");
            }

        }

        private void button5_Click(object sender, EventArgs e)//strong
        {
            if (richTextBox1.SelectionLength > 0)
            {
                string SelectedText = "<strong>" + richTextBox1.SelectedText + "</strong>";
                richTextBox1.SelectedText = richTextBox1.SelectedText.Replace(richTextBox1.SelectedText.ToString(), SelectedText);
            }
            else
            {
                MessageBox.Show("Select text first!");
            }

        }

        private void button6_Click(object sender, EventArgs e)//br
        {
            if (richTextBox1.SelectionLength > 0)
            {
                string SelectedText = richTextBox1.SelectedText + "<br>";
                richTextBox1.SelectedText = richTextBox1.SelectedText.Replace(richTextBox1.SelectedText.ToString(), SelectedText);
            }
            else
            {
                MessageBox.Show("Select text first!");
            }
        }

        private void button7_Click(object sender, EventArgs e)//clear textbox
        {
            richTextBox1.Clear();
        }

        private void button8_Click(object sender, EventArgs e)//ul
        {
            if (richTextBox1.SelectionLength > 0)
            {
                string SelectedText = "<ul>" + richTextBox1.SelectedText + "</ul>";
                richTextBox1.SelectedText = richTextBox1.SelectedText.Replace(richTextBox1.SelectedText.ToString(), SelectedText);
            }
            else
            {
                MessageBox.Show("Select text first!");
            }
        }

        private void button9_Click(object sender, EventArgs e)//li
        {
            if (richTextBox1.SelectionLength > 0)
            {
                string SelectedText = "<li>" + richTextBox1.SelectedText + "</li>";
                richTextBox1.SelectedText = richTextBox1.SelectedText.Replace(richTextBox1.SelectedText.ToString(), SelectedText);
            }
            else
            {
                MessageBox.Show("Select text first!");
            }

        }

        private void button10_Click(object sender, EventArgs e)//ol
        {
            if (richTextBox1.SelectionLength > 0)
            {
                string SelectedText = "<ol>" + richTextBox1.SelectedText + "</ol>";
                richTextBox1.SelectedText = richTextBox1.SelectedText.Replace(richTextBox1.SelectedText.ToString(), SelectedText);
            }
            else
            {
                MessageBox.Show("Select text first!");
            }

        }

        private void button11_Click(object sender, EventArgs e)//a href
        {
            if (richTextBox1.SelectionLength > 0)
            {
                string SelectedText = "<a href=\" \" target=\"_blank\">" + richTextBox1.SelectedText + "</a>";
                richTextBox1.SelectedText = richTextBox1.SelectedText.Replace(richTextBox1.SelectedText.ToString(), SelectedText);
            }
            else
            {
                MessageBox.Show("Select text first!");
            }

        }

        private void button12_Click(object sender, EventArgs e)//save to file
        {
            SaveFileDialog saveFile1 = new SaveFileDialog();
            saveFile1.DefaultExt = "*.txt";
            saveFile1.Filter = "TXT Files|*.txt";
            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               saveFile1.FileName.Length > 0)
            {
                richTextBox1.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
            }
        }
    }
}
