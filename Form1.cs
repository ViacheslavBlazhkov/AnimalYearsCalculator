using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalYearsCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void radioButtonCat_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxAnimals.Image = Properties.Resources.cat;
            int humanYears = (15 + (int.Parse(textBoxHY.Text) >= 2 ? 9 + 4 *
                                               (int.Parse(textBoxHY.Text) - 2) : 0));
            if (int.Parse(textBoxHY.Text) < 18)
                textBoxAY.Text = humanYears.ToString();
            else textBoxAY.Text = "Cats do not live that long";
        }

        private void radioButtonDog_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxAnimals.Image = Properties.Resources.dog;
            int humanYears = (15 + (int.Parse(textBoxHY.Text) >= 2 ? 9 + 5 *
                    (int.Parse(textBoxHY.Text) - 2) : 0));
            if (int.Parse(textBoxHY.Text) < 13)
                textBoxAY.Text = humanYears.ToString();
            else textBoxAY.Text = "Dogs do not live that long";
        }

        private void radioButtonHamster_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxAnimals.Image = Properties.Resources.hamster;
            int humanYears = 25 * int.Parse(textBoxHY.Text);
            if (int.Parse(textBoxHY.Text) < 3)
                textBoxAY.Text = humanYears.ToString();
            else textBoxAY.Text = "Hamsters do not live that long";
        }

        private void radioButtonParrot_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxAnimals.Image = Properties.Resources.parrot;
            int humanYears = (int)(4.5 * int.Parse(textBoxHY.Text));
            if (int.Parse(textBoxHY.Text) < 60)
                textBoxAY.Text = humanYears.ToString();
            else textBoxAY.Text = "Parrots do not live that long";
        }

        private void radioButtonRabbit_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxAnimals.Image = Properties.Resources.rabbit;
            int humanYears = 9 * int.Parse(textBoxHY.Text);
            if (int.Parse(textBoxHY.Text) < 9)
                textBoxAY.Text = humanYears.ToString();
            else textBoxAY.Text = "Rabbits do not live that long";
        }

        private void radioButtonTurtle_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxAnimals.Image = Properties.Resources.turtle;
            int humanYears = (int)(3.3 * int.Parse(textBoxHY.Text));
            if (int.Parse(textBoxHY.Text) < 40)
                textBoxAY.Text = humanYears.ToString();
            else textBoxAY.Text = "Turtles do not live that long";
        }
    }
}
