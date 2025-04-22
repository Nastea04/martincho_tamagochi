using Microsoft.VisualBasic.Logging;
using System.Net.NetworkInformation;

namespace WinFormsApp1
{

    public partial class Form1 : Form
    {
        int tick = 0;
        int food = 100;
        int sleep = 100;
        int clean = 100;
        int acti = 100;
        public Form1()
        {
            InitializeComponent();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer30sec.Start();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void lblfood_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer30sec_Tick(object sender, EventArgs e)
        {
            tick++;
            if (tick == 30)
            {
                tick = 0;
                food -= 5;
                acti -= 3;
                sleep -= 2;
                clean -= 2;

            }
            if (acti > 100)
            {
                acti = 100;
            }
            if (sleep > 100)
            {
                sleep = 100;
            }
            if (clean > 100)
            {
                clean = 100;
            }
            lblfood.Text = ":" + food.ToString() + "%";
            lblcare.Text = ":" + acti.ToString() + "%";
            lblenergy.Text = ":" + sleep.ToString() + "%";
            lblclean.Text = ":" + clean.ToString() + "%";
           
            if (sleep <= 40)

            {
                Console.Beep(400, 1000);
                pictureBox1.Image = Image.FromFile("C:\\Users\\User\\Music\\WinFormsApp1\\WinFormsApp1\\emotinal damige\\shity.png");
            }
            else if (food <= 30)
            {
                Console.Beep(1200, 1000);

                pictureBox1.Image = Image.FromFile("C:\\Users\\User\\Music\\WinFormsApp1\\WinFormsApp1\\emotinal damige\\sad.png");
            }
            else if (acti <= 40)
            {
                Console.Beep(1200, 1000);

                pictureBox1.Image = Image.FromFile("C:\\Users\\User\\Music\\WinFormsApp1\\WinFormsApp1\\emotinal damige\\sad.png");
            }
            else if (acti <= 70)
            {

                pictureBox1.Image = Image.FromFile("C:\\Users\\User\\Music\\WinFormsApp1\\WinFormsApp1\\emotinal damige\\normal.png");
            }
            else if (acti <= 90)
            {

                pictureBox1.Image = Image.FromFile("C:\\Users\\User\\Music\\WinFormsApp1\\WinFormsApp1\\emotinal damige\\happy.png");
            }
            else if (acti <= 100)
            {

                pictureBox1.Image = Image.FromFile("C:\\Users\\User\\Music\\WinFormsApp1\\WinFormsApp1\\emotinal damige\\sex.png");
            }
            if (food <= 0 || food >= 150 || acti <= 1 || clean <= 1 || sleep <= 0)
            {
                timer30sec.Stop();
                timer.Stop();
                pictureBox1.Image = Image.FromFile("C:\\Users\\User\\Music\\WinFormsApp1\\WinFormsApp1\\emotinal damige\\pnghq.com-skull-and-bones-png-768x809-2918270604.png");
                btnacti.Enabled = false;
                btnclean.Enabled = false;
                btnfood.Enabled = false;
                btnslep.Enabled = false;
                MessageBox.Show("why the fuck do you let your pet die you unhuman purson ");

            }

            //pictureBox1.Image = Image.FromFile("C:\\Users\\User\\Music\\WinFormsApp1\\WinFormsApp1\\emotinal damige\\shity.png");
        }

        private void btnfood_Click(object sender, EventArgs e)
        {
            string txt = cbfood.Text;
            if (txt == "Hot Dog  +5")
            {
                food += 5;
            }
            else if (txt == "McDonalds cheseburger +10")
            {
                food += 10;
            }
            else if (txt == "Oreo +15")
            {
                food += 15;
            }
            else if (txt == "Pizza +18")
            {
                food += 18;
            }
            else if (txt == "Ayran +50")
            {
                food += 50;
            }
            else if (txt == "Broccolli -5")
            {
                food -=5;
            }
            else if (txt == "Happy Meal +20")
            {
                food += 20;
            }
            acti += 2;
            sleep += 5;
            clean -= 3;
            sexbar.Visible = true;
            timer.Interval = 100;
            timer.Start();








        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer30sec.Stop();

            btnacti.Enabled = false;
            btnclean.Enabled = false;
            btnfood.Enabled = false;
            btnslep.Enabled = false;
            sexbar.Increment(1);
            if (sexbar.Value == 100)
            {
                timer.Stop();
                sexbar.Visible = false;
                sexbar.Value = 0;
                btnacti.Enabled = true;
                btnclean.Enabled = true;
                btnfood.Enabled = true;
                btnslep.Enabled = true;
                timer30sec.Start();
                tick = 0;
            }
        }
    }
}
