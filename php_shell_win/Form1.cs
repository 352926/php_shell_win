using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace php_shell_win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.textBox1.Focus();
            this.textBox1.Text = "php> ";
            this.textBox1.Select(this.textBox1.Text.Length, 0);

            //设置Form窗体初始化放在屏幕中间
            this.StartPosition = FormStartPosition.CenterScreen;

            //设置Form窗口透明度
            this.Opacity = 0.6;
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {

                //Console.WriteLine(textBox1.Text[textBox1.Text.Length - 2] == (char)13);
                //Console.WriteLine(textBox1.Text[textBox1.Text.Length - 1] == (char)10);
                //Console.WriteLine(this.textBox1.GetFirstCharIndexFromLine(0));

                //按回车前的光标位置
                int line_last = textBox1.GetFirstCharIndexOfCurrentLine() - 2;
                //int line_first = textBox1.GetFirstCharIndexFromLine(line_last);

                int line_first = line_last;
                char c = textBox1.Text[line_first];
                //c == (char)13
                //Console.WriteLine(line_first+" "+textBox1.Text.Length);
                //Console.WriteLine(textBox1.Text[line_first]);
                //Console.WriteLine(textBox1.Text[0]);
                while (line_first > 0 && c != (char)13)
                {
                    line_first--;
                    c = textBox1.Text[line_first];
                }

                //
                //int line = textBox1.GetLineFromCharIndex(index);
                Console.WriteLine(line_first + " " + line_last);
            }
        }
    }
}
