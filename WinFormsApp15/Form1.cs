namespace WinFormsApp15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBoxInput.Text;   
            int index = s.IndexOf('.');     

            if (index != -1)
            {
                int count = s.Length - index - 1;
                label1.Text = $"Кількість символів після першої крапки: {count}";
            }
            else
            {
                label1.Text = "У рядку немає крапки.";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

