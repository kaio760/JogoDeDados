using System;
using System.Diagnostics.Eventing.Reader;
using System.Drawing.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Jogo_dados___1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void but_start_Click(object sender, EventArgs e)
        {
            //dados com numero e imagem aleatorio
            Random random = new Random();
            int objetoAleatorio = random.Next(1, 7);
            Random random1 = new Random();
            int numeroRobo = random.Next(1, 7);
            switch (objetoAleatorio)
            {
                case 1:
                    Pb_1.Image = Properties.Resources.R__1_1;
                    break;
                case 2:
                    Pb_1.Image = Properties.Resources.dado_2;
                    break;
                case 3:
                    Pb_1.Image = Properties.Resources.dado_3;
                    break;
                case 4:
                    Pb_1.Image = Properties.Resources.dado_4;
                    break;
                case 5:
                    Pb_1.Image = Properties.Resources.dado_5;
                    break;
                case 6:
                    Pb_1.Image = Properties.Resources.dado_6;
                    break;
            }

            // Atualiza a imagem do robô
            switch (numeroRobo)
            {
                case 1:
                    Pb_2.Image = Properties.Resources.R__1_1;
                    break;
                case 2:
                    Pb_2.Image = Properties.Resources.dado_2;
                    break;
                case 3:
                    Pb_2.Image = Properties.Resources.dado_3;
                    break;
                case 4:
                    Pb_2.Image = Properties.Resources.dado_4;
                    break;
                case 5:
                    Pb_2.Image = Properties.Resources.dado_5;
                    break;
                case 6:
                    Pb_2.Image = Properties.Resources.dado_6;
                    break;
            }
            int ponto1 = int.Parse(lblPonto1.Text);
            int ponto2 = int.Parse(lblPonto2.Text);

            if (ponto2 > ponto1)
            {
                ponto2 = ponto2 + 1;
            }
            else
            {
                ponto1 = ponto1 + 1;
            }
            lblPonto1.Text = "" + ponto1;
            lblPonto2.Text = "" + ponto2;

        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsPunctuation(e.KeyChar))
                e.Handled = true;
            if (char.IsNumber(e.KeyChar))
                e.Handled = true;
            if (Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void Pb_1_Click(object sender, EventArgs e)
        {

        }

        private void but_stop_Click(object sender, EventArgs e)
        {
            int ponto1 = int.Parse(lblPonto1.Text);
            int ponto2 = int.Parse(lblPonto2.Text);

            if (ponto1 > ponto2)
            {
                MessageBox.Show($"{txt_nome} venceu");
            }
            else if (ponto1 == ponto2)
            {
                MessageBox.Show("Empate");
            }
            else
            {
                MessageBox.Show("O Robo ganhou");
            }
        }
    }
}