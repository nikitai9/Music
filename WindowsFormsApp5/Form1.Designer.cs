using System;
using System.Drawing;
using System.Windows.Forms;

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
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Text = "Form1";

            pictureBox.BackgroundImage = Image.FromFile("gif.gif");
            pictureBox.Location = new Point(280, 0);
            pictureBox.Size = new Size(180, 179);
            this.Controls.Add(pictureBox);

            button1.Text ="<";
            button1.Location = new Point(220, 230);
            button1.Size = new Size(50, 50);
            this.Controls.Add(button1);

            button2.BackgroundImage = Image.FromFile("play.png"); ;
            button2.Location = new Point(350, 240);
            button2.Size = new Size(50, 28);
            this.Controls.Add(button2);
        }

        Button button1 = new Button();
        Button button2 = new Button();
        Button button3 = new Button();


        PictureBox pictureBox = new PictureBox();

        #endregion
    }
}

