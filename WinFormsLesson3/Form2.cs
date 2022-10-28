using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsLesson3
{
    //дочерняя форма
    public partial class Form2 : Form
    {
        public string PubText //публ.свойство для приёма(и отдачи) данных от/в род.формы FORM1
        {
            get
            {
                return textBox1.Text; 
            }
            set
            {
                lb_outText.Text = value;
            }
        }
        public Form2(string s) //конструктор с переменной типа строка для получения данных род.формы
        {
            InitializeComponent();
            this.Text = s;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public DialogResult ShowDialog(string s)
        {
            lb_DRText.Text = s; //создали лейбл с именем lb_DRText и поместили в него данные из перегрузки ShowDialog
            return ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e) //обработчик кнопки button
        {
            this.DialogResult = DialogResult.OK;
        }

        //private void hScrollBar1_Scroll(object sender, ScrollEventArgs e){ }
    }
}
