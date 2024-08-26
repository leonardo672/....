using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demetry
{
    public partial class Password : Form
    {
        public Password()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox2.Text == "")
            {
                MessageBox.Show("пожалуйста введите имя");
            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("пожалуйста введите пароль");
            }
            else if(textBox2.Text == "Деметрия")
            {
                if (textBox1.Text == "Мир")
                {
                    Основная_Форма x = new Основная_Форма();
                    x.Show();
                }
                else
                {
                    MessageBox.Show("Неправильный пароль", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (textBox1.Text == "Мир")
            {
                if (textBox2.Text == "Деметрия")
                {
                    Основная_Форма x = new Основная_Форма();
                    x.Show();
                }
                else
                {
                    MessageBox.Show("неправильное имя", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Неправильное имя или неправильный пароль", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
