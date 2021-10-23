using System;
using System.Drawing;
using System.Windows.Forms;

namespace OOP_Finaly
{
    public partial class Form1 : Form
    {
        public int Xpos;
        public int Ypos;
        public Form1()
        {
            InitializeComponent();
            //Ставим квадрат в центр
            LocationButton(button1.Width, button1.Height);
            //Выключаем кнопку, чтобы она была просто квадратом
            button1.Enabled = false;
            //button1.Location = new Point(Xpos, Ypos);
        }

        /// <summary>
        /// Перемещает обьект в центр главной панели в форме
        /// </summary>
        /// <param name="x">Координаты X</param>
        /// <param name="y">Координаты Y</param>
        private void LocationButton(int x, int y)
        {
            //Формулы для нахождения серидины пространства
            Xpos = (panel1.Width - button1.Width) / 2;
            Ypos = ((panel1.Height - button1.Height) / 2);
            //Перемещение квадрата в центр
            button1.Location = new Point(Xpos, Ypos);
        }

        private void FormExit_Click_1(object sender, EventArgs e)
        {
            //При клике закрываем приложение
            Application.Exit();
        }

        private void FormChange_Click_1(object sender, EventArgs e)
        {
            //Если X или Y не равны нулю используем функцию, иначе функция игнорируется
            if (Main.X != 0 || Main.Y != 0)
            {
                //Если проверка радиобаттона тру, то прибавляем координаты, иначе отнимаем
                if (Main.PlusX == true)
                {
                        if ((button1.Width + Main.X) > panel1.Width || (button1.Height + Main.Y) > panel1.Height)
                        {
                            //Если обьект выходит за рабочую зону блокируем кнопку изменения и выводим сообщение
                            Main.Blokchek = false;
                            FormChange.Enabled = Main.Blokchek;
                            MessageBox.Show($" Нельзя изменить размер на такое число: обьект выйдет за рабочую зону! ");
                        }
                        else
                        {
                            //Изменяем обьект, центрируем и сбрасываем координаты, блокируем кнопку изменения
                            button1.Width += Convert.ToInt32(Main.X);
                            button1.Height += Convert.ToInt32(Main.Y);
                            LocationButton(button1.Width, button1.Height);
                            Main.X = 0;
                            Main.Y = 0;
                            Main.Blokchek = false;
                            FormChange.Enabled = Main.Blokchek;
                        }
                }
                else if (Main.PlusX == false)
                {

                    if (button1.Width >= Main.X && button1.Height >= Main.Y)
                    {
                        //Если обьект пытаются уменьшить на число больше его размера блокируем кнопку изменения и выводим сообщение
                        if ((button1.Width - Main.X) > panel1.Width || (button1.Height - Main.Y) > panel1.Height)
                        {
                            Main.Blokchek = false;
                            FormChange.Enabled = Main.Blokchek;
                            MessageBox.Show($" Нельзя изменить размер на такое число: обьект выйдет за рабочую зону! ");
                        }
                        else
                        //Изменяем обьект, центрируем и сбрасываем координаты, блокируем кнопку изменения
                        {
                            button1.Width -= Convert.ToInt32(Main.X);
                            button1.Height -= Convert.ToInt32(Main.Y);
                            LocationButton(button1.Width, button1.Height);
                            Main.X = 0;
                            Main.Y = 0;
                            Main.Blokchek = false;
                            FormChange.Enabled = Main.Blokchek;
                        }
                    }
                    else
                    {   
                        //Если X или Y больше ширины или длинны обьекта соответственно выдаем сообщение 
                        Main.Blokchek = false;
                        FormChange.Enabled = Main.Blokchek;
                        MessageBox.Show($" Вы хотите уменьшить размер обьекта на число, превышающее размер обьекта! ");
                    }
                }
            }
        }

        private void FormInput_Click_1(object sender, EventArgs e)
        {
            //this.Hide(); Если окно нужно будет спрятать
            Main main = new Main();
            main.Show();
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            //Блокируем кнопку изменения если не введены значения X и Y
            if (Main.Blokchek == true)
            {
                FormChange.Enabled = true;
            }
            else
            {
                FormChange.Enabled = false;
            }
        }
    }
}
