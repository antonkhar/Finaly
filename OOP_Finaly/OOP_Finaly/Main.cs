using System;
using System.Drawing;
using System.Windows.Forms;

namespace OOP_Finaly
{
    public partial class Main : Form
    {
        //Обьявляем свойста

        //Проверка блокирования кнопки изменения
        public static bool Blokchek { get; set; }
        //Координата X
        public static uint X { get; set; }
        //Координата Y
        public static uint Y { get; set; }
        //Проверка, необходимо прибавить или отнять координаты
        public static bool PlusX { get; set; }
        public Main()
        {
            InitializeComponent();
            Blokchek = false;
            PlusX = false;
        }
        private void Main_Load(object sender, EventArgs e)
        {
            //Добавляем текст-помощник в текст-боксы
            textBox1.Text = "Введите длинну изменения X";
            textBox2.Text = "Введите длинну изменения Y";
            textBox1.ForeColor = Color.Gray;
            textBox2.ForeColor = Color.Gray;
        }

        private void MainExit_Click(object sender, EventArgs e)
        {
            //Закрываем данную форму
            this.Close();
        }

        private void MainInput_Click(object sender, EventArgs e)
        {
            //Если не выбрат радиобаттон выдать сообщение
            if (SizeMinus.Checked == false && SizePlus.Checked == false)
            {
                MessageBox.Show("Выберите что необходимо сделать, прибавить или отнять");
            }
            else
            {
                try
                {
                    //Если оба текстбокса не пусты, то приравниваем их к координатам, если они не соответствуют формату выдаем сообщение
                    if ((textBox1.Text != null && textBox2.Text != null))
                    {
                        //Приравниваем, закрываем форму и разблокируем кнопку изменения
                        X = Convert.ToUInt32(textBox1.Text);
                        Y = Convert.ToUInt32(textBox2.Text);
                        Blokchek = true;
                        this.Close();
                    }
                    else
                    {
                        
                        Blokchek = false;
                    }
                }
                catch
                {
                    MessageBox.Show("Введите целое положительное число в оба поля (Size X, Size Y)");
                }
            }
                        
        }

        private void SizePlus_CheckedChanged(object sender, EventArgs e)
        {
            //Если выбран первый радиобаттон приравниваем проверку к true
            if(SizePlus.Checked == true)
            {
                PlusX = true;
            }
        }

        private void SizeMinus_CheckedChanged(object sender, EventArgs e)
        {
            //Если выбран второй радиобаттон приравниваем проверку к false
            if (SizeMinus.Checked == true)
            {
                PlusX = false;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            //Стираем текст-помощник
            textBox1.Text = null;
            textBox1.ForeColor = Color.Black;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            //Стираем текст-помощник
            textBox2.Text = null;
            textBox2.ForeColor = Color.Black;
        }
    }
}
