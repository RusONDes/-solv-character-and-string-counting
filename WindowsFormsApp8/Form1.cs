using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp8
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "что вы хотите рашифровать ";
            openFileDialog1.Filter = "Все фаилы | *.*|Текстовые фаилы | *.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string patc = openFileDialog1.FileName;
                string[] text = File.ReadAllLines(patc);
                string buffer = File.ReadAllText(patc);
                File.WriteAllText(patc, buffer);
                char[] chars  = buffer.ToCharArray();
                string[] str= buffer.ToString().Split(' ');
                int num = 0;
                for (int i = 0; i < str.Length - 1 ; i++)
                {
                    num++;
                }
                listBox1.Items.Add($"слов  {num}");
                num = 0;
                for (int i = 0; i < chars.Length; i++)
                {
                   
                    if (Char.IsWhiteSpace(chars[i]) )
                    {
                        
                    }
                    else
                    {
                        num++;
                    }
                }
                listBox1.Items.Add($"символы {num}");
                 num= 0;
                foreach (var item in text)
                {
                 num++;
                }
                listBox1.Items.Add($"количество строк {num}");


            }
        }
    }
}
