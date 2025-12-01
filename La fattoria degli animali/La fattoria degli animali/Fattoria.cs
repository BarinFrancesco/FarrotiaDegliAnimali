using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace La_fattoria_degli_animali
{
    class Fattoria
    {
        public delegate void RiproduciSuono(Animale a);
        public event RiproduciSuono SoundHandler;

        public delegate void AggiuntaPannello(string foto, Animale sender);
        public event AggiuntaPannello Aggiungipannello;

        SoundPlayer Speaker = new SoundPlayer();

        public List<Animale> listaAnimali;
        Cane cane;
        Gatto gatto;
        Mucca mucca;

        public Fattoria()
        {
            listaAnimali = new List<Animale>();

            SoundHandler += Ripetisuono;
        }

        public void RichiediVerso(Animale a)
        {
            SoundHandler?.Invoke(a);
        }

        private void Ripetisuono(Animale a)
        {
            Speaker.SoundLocation = a.Getverso();
            Speaker.Play();
        }

        public void StartingAnimals()
        {
            Aggiungianimale(Specie.Cane, "Bread");
            Aggiungianimale(Specie.Gatto, "Romeo");
            Aggiungianimale(Specie.Mucca, "Giorgia");
        }

        public void Aggiungianimale(Specie tipo, string nome)
        {
            
            switch (tipo)
            {
                case Specie.Cane:
                    listaAnimali.Add(cane = new Cane(nome));
                    CreaPannello(listaAnimali[listaAnimali.Count-1].ImmaginePath, listaAnimali[listaAnimali.Count-1]);
                    break;
                case Specie.Gatto:
                    listaAnimali.Add(gatto = new Gatto(nome));
                    CreaPannello(listaAnimali[listaAnimali.Count - 1].ImmaginePath, listaAnimali[listaAnimali.Count - 1]);
                    break;
                case Specie.Mucca:
                    listaAnimali.Add(mucca = new Mucca(nome));
                    CreaPannello(listaAnimali[listaAnimali.Count - 1].ImmaginePath, listaAnimali[listaAnimali.Count - 1]);
                    break;
                default:
                    break;
            }
        }

        public void CreaPannello (string foto, Animale animale)
        {
            Aggiungipannello?.Invoke(foto, animale);
        }
    }
}
