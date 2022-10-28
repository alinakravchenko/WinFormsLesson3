namespace WinFormsLesson3
{
    //������������ �����
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2("����� ��� ������������");//������������� ������. ��� �������� ������ �������� ����� FORM2
            f.PubText = "Hello by mother form"; //������������� �������� ��� �������� ������ ��������� ������ FORM2
            f.ShowDialog("Hello from ShowDialog"); //��� ������ ���� DialogResult, ����������� ����������� ���������� ����
            f.Close(); //���������� �������
            Form2 f2 = new Form2("����� � �������������");
            f2.Show(); //��������, �� ������������ ����������� ���������� ����
            f2.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(""); //������ ����� ��������� ����� 
            if (frm2.ShowDialog() == DialogResult.OK) //���� ����� �� ����� ��
            {
                listBox1.Items.Add(frm2.PubText);//���. �� ��-�� ����� �������� � ������
            }
        }
    }
}