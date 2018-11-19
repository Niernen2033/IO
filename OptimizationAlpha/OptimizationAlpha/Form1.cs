using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OptimizationGlobals;
using DisplayFunction;

namespace OptimizationAlpha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_find_min_Click(object sender, EventArgs e)
        {
            //ODPALA ALGORYTMY SZUKAJĄCE MINIMUM FUNKCJI ORAZ RYSUJE WYKRESY
        }

        private void button_find_max_Click(object sender, EventArgs e)
        {
            //ODPALA ALGORYTMY SZUKAJĄCE MAXIMUM FUNKCJI ORAZ RYSUJE WYKRESY
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            //Location of Texbox with function while resize
            textBox_function.Location = new Point(Convert.ToInt32(this.Width * 0.05), Convert.ToInt32(this.Height * 0.05));
            textBox_function.Width = Convert.ToInt32(this.Width * 0.55);

            //Location of Button finding minimum of function while resize
            button_find_min.Location = new Point(textBox_function.Location.X + textBox_function.Width + Convert.ToInt32(this.Width * 0.025), Convert.ToInt32(this.Height * 0.05));
            button_find_min.Width = Convert.ToInt32(this.Width * 0.15);

            //Location of Button finding maximum of function while resize
            button_find_max.Location = new Point(button_find_min.Location.X + button_find_min.Width + Convert.ToInt32(this.Width * 0.025), Convert.ToInt32(this.Height * 0.05));
            button_find_max.Width = Convert.ToInt32(this.Width * 0.15);

            //Location of 2D button
            button_2d.Location = new Point(Convert.ToInt32(this.Width * 0.05), textBox_function.Location.Y + textBox_function.Height + Convert.ToInt32(this.Height * 0.01));
            button_2d.Width = Convert.ToInt32(this.Width * 0.075);

            //Location of 3D button
            button_3d.Location = new Point(button_2d.Location.X + button_2d.Width, button_2d.Location.Y);
            button_3d.Width = Convert.ToInt32(this.Width * 0.075);

            //Location of 2D chart
            panel_chart.Location = new Point(Convert.ToInt32(this.Width * 0.05), button_2d.Location.Y + button_2d.Height);
            panel_chart.Width = Convert.ToInt32(this.Width * 0.725);
            panel_chart.Height = Convert.ToInt32((this.Height - Convert.ToInt32(this.Height * 0.05) - Convert.ToInt32(this.Height * 0.01) - textBox_function.Height - button_2d.Height) * 0.885);

            //Location of results label
            label_results.Location = new Point(button_find_max.Location.X, button_find_max.Location.Y + Convert.ToInt32(this.Height * 0.1));

            //Location of Button exit
            button_exit.Location = new Point(button_find_max.Location.X, Convert.ToInt32(this.Height - button_exit.Height - this.Height * 0.1));
            button_exit.Width = Convert.ToInt32(this.Width * 0.15);
        }

        private void textBox_function_Text_Click(object sender, EventArgs e)
        {
            if (textBox_function.Text == "Write a function...")
            {
                textBox_function.Text = "";
            }
        }

        private void textBox_function_Leave(object sender, EventArgs e)
        {
            if (textBox_function.Text == "")
            {
                textBox_function.Text = "Write a function...";
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_2d_Click(object sender, EventArgs e)
        {
            //WYKRES 2D na panel_chart
        }

        private void button_3d_Click(object sender, EventArgs e)
        {
            //WYKRES 3D na panel_chart
        }
    }
}
