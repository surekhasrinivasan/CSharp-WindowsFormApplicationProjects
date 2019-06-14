using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsciiAndHexadecimalConverter
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

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = ToHexString(textBox1.Text);
            textBox2.Text = FromHexString(ToHexString(textBox1.Text));
        }
        
        public static string ToHexString(string asciiStr)
        {
            string result = String.Concat(asciiStr.Select(x => ((int)x).ToString("X")));
            return result;
        }

        public static string FromHexString(string hexStr)
        {
            StringBuilder sb = new StringBuilder();
            for (var i = 0; i < hexStr.Length; i += 2)
            {
                var hexChar = hexStr.Substring(i, 2);
                sb.Append((char)Convert.ToByte(hexChar, 16));
            }
            return sb.ToString();
        }
    }
}
