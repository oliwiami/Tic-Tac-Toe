using System;
using System.Linq;
using System.Windows.Forms;

namespace KolkoKrzyzyk
{
    public partial class Form1 : Form
    {
        bool ruch = false;
        int ruchIlosc = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button_Click(object sender, EventArgs e)
        {
            Button przycisk = (Button)sender;
            if (ruch == true)
            {
                przycisk.Text = "X";
            }
            else
            {
                przycisk.Text = "O";
            }
            ruch = !ruch;
            ruchIlosc++;
            przycisk.Enabled = false;
            checkWinner();
        }
        private void checkWinner()
        {
            bool znalezionoZwyciesce = false;
            if ((a1.Text == a2.Text) && (a2.Text == a3.Text) && a1.Text != "")
                znalezionoZwyciesce = true;
            else if ((b1.Text == b2.Text) && (b2.Text == b3.Text) && b1.Text != "")
                znalezionoZwyciesce = true;
            else if ((c1.Text == c2.Text) && (c2.Text == c3.Text) && c1.Text != "")
                znalezionoZwyciesce = true;
            else if ((a1.Text == b1.Text) && (b1.Text == c1.Text) && a1.Text != "")
                znalezionoZwyciesce = true;
            else if ((a2.Text == b2.Text) && (b2.Text == c2.Text) && a2.Text != "")
                znalezionoZwyciesce = true;
            else if ((a3.Text == b3.Text) && (b3.Text == c3.Text) && a3.Text != "")
                znalezionoZwyciesce = true;
            else if ((a1.Text == b2.Text) && (b2.Text == c3.Text) && a1.Text != "")
                znalezionoZwyciesce = true;
            else if ((a3.Text == b2.Text) && (b2.Text == c1.Text) && a3.Text != "")
                znalezionoZwyciesce = true;

            if (znalezionoZwyciesce)
            {
                string zwyciezca = "";
                if (ruch)
                    zwyciezca = "O";
                else
                    zwyciezca = "X";

                MessageBox.Show("The winner is " + zwyciezca + "! Click OK to clean the board.");
                clean();
            }
            else if (ruchIlosc == 9)
            {
                MessageBox.Show("Remis! Click OK to clean the board");
                clean();
            }

        }
        private void wyczysc(object sender, EventArgs e)
        {
            clean();
        }
        private void clean()
        {
            var przyciski = Controls.OfType<Button>();
            foreach (Control przycisk in przyciski)
            {
                przycisk.Enabled = true;
                przycisk.Text = "";
            }
            ruchIlosc = 0;
            ruch = true;

            // wyczysc.Text = "";
        }


    }
}
