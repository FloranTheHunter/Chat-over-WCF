using System;
using System.Windows.Forms;

namespace WindowsFormsChat
{
    public partial class Form1 : Form
    {
        private Model model;

        public Form1()
        {
            InitializeComponent();

            Init();
        }

        private void Init()
        {
            model = new Model();
            bindingSource1.DataSource = model;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            try
            {
                RunTestAndFocusToInput();
            }
            catch
            {
                MessageBox.Show("Нет подключения к серверу!");
            }
        }

        private void RunTestAndFocusToInput()
        {
            model.RunTest();
            FocusToInput();
        }

        private void FocusToInput()
        {
            textBoxInputMessage.Focus();
        }

        private void buttonConnectToServer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(model.Name))
            {
                MessageBox.Show("Введите имя");
            }
            else
            {
                try
                {
                    model.Connect();
                    model.InputMessage = "подключился";
                    model.SendMessage();
                    model.InputMessage = "";
                    textBoxInputMessage.Text = model.InputMessage;
                }
                catch
                {
                    MessageBox.Show("Невозможно подключится к серверу!");
                }
            }
        }

        private void buttonSendMessage_Click(object sender, EventArgs e)
        {
            try
            {
                model.InputMessage = textBoxInputMessage.Text;
                model.SendMessage();
                model.InputMessage = "";
                textBoxInputMessage.Text = model.InputMessage;
            }
            catch
            {
                MessageBox.Show("Нет подключения к серверу!");
            }
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Клиент для создания чата", "РБ-Софт", MessageBoxButtons.OK);
        }

        private void textBoxInputMessage_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                // Хоткей на нажатие Ctrl+Enter
                if ((e.Control && e.KeyCode == Keys.Enter))
                {
                    model.InputMessage = textBoxInputMessage.Text;
                    model.SendMessage();
                    model.InputMessage = "";
                    textBoxInputMessage.Text = model.InputMessage;
                    e.SuppressKeyPress = true;
                }
            }
            catch
            {
                MessageBox.Show("Нет подключения к серверу!");
            }
        }
    }
}