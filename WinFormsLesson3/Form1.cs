namespace WinFormsLesson3
{
    //родительская форма
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2("Форма без переключения");//использование констр. для передачи данных дочерней формы FORM2
            f.PubText = "Hello by mother form"; //использование свойства для передачи данных дочернего класса FORM2
            f.ShowDialog("Hello from ShowDialog"); //ждёт отвеча вида DialogResult, препятсвует дальнейшему выполнению кода
            f.Close(); //разрушение объекта
            Form2 f2 = new Form2("Форма с переключением");
            f2.Show(); //наоборот, не препятствует дальнейшему выполнению кода
            f2.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(""); //создаём новый экземпляр формы 
            if (frm2.ShowDialog() == DialogResult.OK) //если ответ от формы ОК
            {
                listBox1.Items.Add(frm2.PubText);//доб. из св-ва формы значение в список
            }
        }
    }
}