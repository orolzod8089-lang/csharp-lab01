using System;
using System.Drawing;
using System.Windows.Forms;

namespace CalculatorApp
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            Form form = new Form();
            form.Text = "Тооцоолуур";
            form.Width = 400;
            form.Height = 350;

            TextBox textBox1 = new TextBox();
            textBox1.Location = new Point(50, 30);
            textBox1.Width = 120;

            TextBox textBox2 = new TextBox();
            textBox2.Location = new Point(200, 30);
            textBox2.Width = 120;

            Button addButton = new Button();
            addButton.Text = "+";
            addButton.Location = new Point(50, 80);
            addButton.Width = 60;

            Button subButton = new Button();
            subButton.Text = "-";
            subButton.Location = new Point(120, 80);
            subButton.Width = 60;

            Button mulButton = new Button();
            mulButton.Text = "*";
            mulButton.Location = new Point(190, 80);
            mulButton.Width = 60;

            Button divButton = new Button();
            divButton.Text = "/";
            divButton.Location = new Point(260, 80);
            divButton.Width = 60;

            Label resultLabel = new Label();
            resultLabel.Location = new Point(50, 150);
            resultLabel.Width = 300;
            resultLabel.Text = "Үр дүн: ";

            addButton.Click += (sender, e) =>
            {
                if (int.TryParse(textBox1.Text, out int a) &&
                    int.TryParse(textBox2.Text, out int b))
                {
                    resultLabel.Text = "Үр дүн: " + (a + b);
                }
                else
                {
                    resultLabel.Text = "Зөв тоо оруулна уу!";
                }
            };

            subButton.Click += (sender, e) =>
            {
                if (int.TryParse(textBox1.Text, out int a) &&
                    int.TryParse(textBox2.Text, out int b))
                {
                    resultLabel.Text = "Үр дүн: " + (a - b);
                }
                else
                {
                    resultLabel.Text = "Зөв тоо оруулна уу!";
                }
            };

            mulButton.Click += (sender, e) =>
            {
                if (int.TryParse(textBox1.Text, out int a) &&
                    int.TryParse(textBox2.Text, out int b))
                {
                    resultLabel.Text = "Үр дүн: " + (a * b);
                }
                else
                {
                    resultLabel.Text = "Зөв тоо оруулна уу!";
                }
            };

            divButton.Click += (sender, e) =>
            {
                if (int.TryParse(textBox1.Text, out int a) &&
                    int.TryParse(textBox2.Text, out int b))
                {
                    if (b == 0)
                    {
                        resultLabel.Text = "0-д хувааж болохгүй!";
                    }
                    else
                    {
                        resultLabel.Text = "Үр дүн: " + ((double)a / b);
                    }
                }
                else
                {
                    resultLabel.Text = "Зөв тоо оруулна уу!";
                }
            };

            form.Controls.Add(textBox1);
            form.Controls.Add(textBox2);
            form.Controls.Add(addButton);
            form.Controls.Add(subButton);
            form.Controls.Add(mulButton);
            form.Controls.Add(divButton);
            form.Controls.Add(resultLabel);

            Application.Run(form);
        }
    }
}