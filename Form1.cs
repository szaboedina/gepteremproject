using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GepteremProjekt
{
    public partial class Form1 : Form
    {
        PetrikLajosSzg petrik = new PetrikLajosSzg("petrikgepek.txt");
        int sorokSzama = 0;
        int helyekSzama=0;
        int oldalmeret;
        readonly int buttonSize = 50;

        int aktualisTerem = 0;
        List<Image> kep = new List<Image>();
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load_1(object sender, EventArgs e)
        {
           /* for (int i = 0; i < petrik.Geptermek.Count(); i++)
            {
                if (sorokSzama < petrik.Geptermek[i].SorDb)
                {
                    sorokSzama = petrik.Geptermek[i].SorDb;
                }
                if (helyekSzama < petrik.Geptermek[i].HelyDb)
                {
                    helyekSzama = petrik.Geptermek[i].HelyDb;
                }
            }
            oldalmeret = (int)Math.Min(Math.Floor((double)(panel1.Height / sorokSzama)),
                Math.Floor((double)(panel1.Height / helyekSzama)));
                */
            kep.Add(Image.FromFile(@"Kepek\Pont0.jpg"));
            kep.Add(Image.FromFile(@"Kepek\Pont1.jpg"));
            kep.Add(Image.FromFile(@"Kepek\Pont2.jpg"));
            kep.Add(Image.FromFile(@"Kepek\Pont3.jpg"));
            PanelUpdate();

        }
        void PanelUpdate()
        {

            this.Text = petrik.Geptermek[aktualisTerem].Nev + "(" + petrik.Geptermek[aktualisTerem].atlag() + ")";
            if (aktualisTerem == 0)
            {
                pictureBox1.BackgroundImage = Image.FromFile(@"Kepek\Neumann.jpg");
                vissza.Enabled = true;
                vissza.Show();
                elore.Enabled = true;
                elore.Show();

            }
            if (aktualisTerem == petrik.Geptermek.Count - 3)
            {
                pictureBox1.BackgroundImage = Image.FromFile(@"Kepek\Gordon.jpg");
                vissza.Enabled = true;
                vissza.Show();
                elore.Enabled = true;
                elore.Show();
            }
            if (aktualisTerem == petrik.Geptermek.Count - 2)
            {
                pictureBox1.BackgroundImage = Image.FromFile(@"Kepek\Steve.jpg");
                vissza.Enabled = true;
                vissza.Show();
                elore.Enabled = true;
                elore.Show();
            }
            if (aktualisTerem == petrik.Geptermek.Count - 1)
            {
                pictureBox1.BackgroundImage = Image.FromFile(@"Kepek\Bill.jpg");
                vissza.Enabled = true;
                vissza.Show();
                elore.Enabled = true;
                elore.Show();
            }



            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Clear();
            for (int i = 0; i < petrik.Geptermek[aktualisTerem].Ertekeles.GetLength(1); i++)
            {
                for (int j = 0; j < petrik.Geptermek[aktualisTerem].Ertekeles.GetLength(0); j++)
                {
                    //-- Létrehozás ----------------------------------
                    Button g = new Button();
                    g.BackgroundImage = kep[petrik.Geptermek[aktualisTerem].Ertekeles[j, i]];
                    g.BackgroundImageLayout = ImageLayout.Stretch;
                    g.SetBounds(i * buttonSize, j * buttonSize, buttonSize, buttonSize);
                    //-- eseménykezelés ------------------------------
                    int sor = j;
                    int hely = i;
                    g.Click += (o, e) =>
                    {
                        petrik.Geptermek[aktualisTerem].UjErt(sor, hely);
                        PanelUpdate();
                    };
                    panel1.Controls.Add(g);
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            aktualisTerem--;
            if (aktualisTerem <= 0)
            {
                aktualisTerem = 3;
            }

            PanelUpdate();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Elore_Click(object sender, EventArgs e)
        {
            aktualisTerem++;
            if (aktualisTerem >= 4)
            {
                aktualisTerem = 0;
            }

            PanelUpdate();
        }
    }
}
