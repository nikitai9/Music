using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Media;

namespace WindowsFormsApp5
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";

            pictureBox.BackgroundImage = Image.FromFile("gif.gif");
            pictureBox.Location = new Point(280, 0);
            pictureBox.Size = new Size(180, 179);
            this.Controls.Add(pictureBox);

            button1.Text = "<";
            button1.Location = new Point(220, 230);
            button1.Size = new Size(50, 50);
            button1.Click += button1_Click;
            this.Controls.Add(button1);

            button2.BackgroundImage = Image.FromFile("play.png");
            button2.Location = new Point(350, 240);
            button2.Size = new Size(50, 28);
            button2.Click += button2_Click;
            this.Controls.Add(button2);

            button3.Text = ">";
            button3.Location = new Point(480, 230);
            button3.Size = new Size(50, 50);
            button3.Click += button3_Click;
            this.Controls.Add(button3);

            button4.Text = "+";
            button4.Location = new Point(560, 350);
            button4.Size = new Size(50, 50);
            button4.Click += button4_Click;
            this.Controls.Add(button4);

            button5.Text = "-";
            button5.Location = new Point(560, 400);
            button5.Size = new Size(50, 50);
            this.Controls.Add(button5);

            listBox.Location = new Point(225, 330);
            listBox.Size = new Size(300, 200);
            this.Controls.Add(listBox);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(music[num]);
            simpleSound.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (num > 0)
            {
                num--;
                SetMusic(num);
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (num < PictureCount)
            {
                num++;
                SetMusic(num);
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
        void SetMusic(int indx = 0)
        {
        }
        int PictureCount = 0;
        int num = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "*.**|*.*|*.mp3|*.mp3|*.wav|*.wav";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    PictureCount++;
                    num++;
                    music.Add(dialog.FileName);
                    listBox.Items.Add(dialog.FileName);
                }
            }
        }


        List<string> music = new List<string>();

        Button button1 = new Button();
        Button button2 = new Button();
        Button button3 = new Button();

        Button button4 = new Button();
        Button button5 = new Button();

        ListBox listBox = new ListBox();

        PictureBox pictureBox = new PictureBox();


        #endregion
    }
}

