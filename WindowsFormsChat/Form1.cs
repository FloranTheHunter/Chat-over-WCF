using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            model.RunTest();
        }

        private void buttonConnectToServer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(model.Name))
            {
                MessageBox.Show("Введите имя");
            }
            else
            {
                model.Conncet();
            }
        }

        private void buttonSendMessage_Click(object sender, EventArgs e)
        {
            model.SendMessage();

        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Клиент для создания чата","РБ-Софт",MessageBoxButtons.OK);
        }
    }
}
