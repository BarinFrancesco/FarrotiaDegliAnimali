using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace La_fattoria_degli_animali
{
    public enum Specie
    {
        Cane, 
        Gatto,
        Mucca
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Fattoria FattoriaBarin;
        int count;
        int coordinate;

        private void Form1_Load(object sender, EventArgs e)
        {
            FattoriaBarin = new Fattoria();
            FattoriaBarin.Aggiungipannello += Createpanel;
            FattoriaBarin.StartingAnimals();
            count = 0;
            coordinate = 20;
            
        }

        public void Createpanel(string foto, Animale animale)
        {
            PictureBox pic = new PictureBox();
            pic.Name = $"picAnimale{count}";
            pic.Size = new Size(100, 100);
            pic.Location = new Point(coordinate, 100);

            // 2) Imposto l'immagine che gli dai tu
            pic.Image = Image.FromFile(foto);

            // 3) Visualizzazione completa dell'immagine
            pic.SizeMode = PictureBoxSizeMode.StretchImage;

            // 4) Aggiungo l’evento di click
            pic.Click += (s,e) => FattoriaBarin.RichiediVerso(animale);

            // 5) Aggiungo la picturebox al form
            Controls.Add(pic);
            count++;
            coordinate += 120;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(count % 3 == 1)
            {
                FattoriaBarin.RichiediVerso(FattoriaBarin.listaAnimali[0]);
            } else if(count % 3 == 2)
            {
                FattoriaBarin.RichiediVerso(FattoriaBarin.listaAnimali[1]);
            }
            else
            {
                FattoriaBarin.RichiediVerso(FattoriaBarin.listaAnimali[2]);
            }
            count++;
        }

    }
}
