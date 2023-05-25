namespace Таки_да__это_кнопка
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            windowWidth = this.Width;
            button1.MouseEnter += button1_MouseEnter;
            button1.MouseLeave += button1_MouseLeave;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }


        private bool flag1 = false;
        private bool flag2 = false;
        private bool flag3 = false;
        private int windowWidth;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            int minLength = 2; // Минимальная длина текста
            flag3 = textBox.Text.Length >= minLength;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            int minLength = 8; // Минимальная длина текста
            flag1 = textBox.Text.Length >= minLength;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            flag2 = checkBox1.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((!flag2 || !flag1 || !flag3))
            {
                MoveButtonToRandomLocation();
            }
            else
            {
                MessageBox.Show("Поздравляю, к вам на ПК скачались половина всех вирусов");
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            if ((!flag2 || !flag1 || !flag3))
            {
                MoveButtonToRandomLocation();
            }
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            // Можно добавить дополнительные действия при уходе курсора мыши с кнопки
        }

        private void MoveButtonToRandomLocation()
        {
            Random random = new Random();
            int buttonWidth = button1.Width;
            int maxX = windowWidth - buttonWidth;
            int newX = random.Next(0, maxX);
            button1.Location = new Point(newX, button1.Location.Y);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            windowWidth = this.Width; // Задает ширину окна при его загрузке
        }

    }
}