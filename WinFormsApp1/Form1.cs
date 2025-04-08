namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = 15;
            number = number + 10;
            number = 36 * 15;
            number = 12 - (42 / 7);
            number += 10;
            number *= 3;
            number = 71 / 3;
            label2.Text = "Результат: " + number.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count = 0;
            count++;
            count--;
            label3.Text = "Результат: " + count.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string result = "hello";
            result += " again " + result;
            label4.Text = "Результат: " + result.ToLower();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool yesNo = false;
            bool anotherBool = true;
            yesNo = !anotherBool;
            label5.Text = "Результат: " + yesNo.ToString();
        }
    }
}