using System.Diagnostics.Eventing.Reader;

namespace Bilgi_Yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru = 0, yanlýs = 0;


        private void button5_Click(object sender, EventArgs e)
        {
            soruno++;
            lblSoruNo.Text = soruno.ToString();
            button5.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            pictureBox1.Visible = false ;
            pictureBox2.Visible = false ;
            switch (soruno)
            {
                case 1:
                    richTextBox1.Text = "Cumhuriyet kaç yýlýnda ilan edilmiþtir?";
                    button1.Text = "1920";
                    button2.Text = "1921";
                    button3.Text = "1922";
                    button4.Text = "1923";
                    label4.Text = "1923";
                    break;
                case 2:
                    richTextBox1.Text = "Türkiye'nin baþkenti hangisidir?";
                    button1.Text = "Ýstanbul";
                    button2.Text = "Ankara";
                    button3.Text = "Ýzmir";
                    button4.Text = "Bursa";
                    label4.Text = "Ankara";
                    break;
                case 3:
                    richTextBox1.Text = "Ýstanbul'u kim fethetmiþtir?";
                    button1.Text = "2.Mehmet";
                    button2.Text = "1.Beyazid";
                    button3.Text = "2.Murat";
                    button4.Text = "1.Mehmet";
                    label4.Text = "2.Mehmet";
                    break;
                case 4: richTextBox1.Text = "Oyun bitti";
                    button5.Text = "Kapat";
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = true;
                    break;
                case 5: Application.Exit(); break;

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button5.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            label5.Text = button1.Text;
            if (label5.Text == label4.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            if (label5.Text != label4.Text)
            {
                yanlýs++;
                lblYanlýs.Text = yanlýs.ToString();
                pictureBox2.Visible = true;
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            button5.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            label5.Text = button2.Text;
            if (label5.Text == label4.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            if (label5.Text != label4.Text)
            {
                yanlýs++;
                lblYanlýs.Text = yanlýs.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button5.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            label5.Text = button3.Text;
            if (label5.Text == label4.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            if (label5.Text != label4.Text)
            {
                yanlýs++;
                lblYanlýs.Text = yanlýs.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button5.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            label5.Text = button4.Text;
            if (label5.Text == label4.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            if (label5.Text != label4.Text)
            {
                yanlýs++;
                lblYanlýs.Text = yanlýs.ToString();
                pictureBox2.Visible = true;
            }
        }
    }
}