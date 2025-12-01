using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_fattoria_degli_animali
{
    public class Animale
    {
        string _nome;
        string _immaginePath;
        string _versoPath;

        public string Nome
        {
            get => _nome;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _nome = value;
                } else
                {
                    throw new Exception("Nome non valorizzato");
                }
            }
        }

        public string ImmaginePath
        {
            get => _immaginePath;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _immaginePath = value;
                }
                else
                {
                    throw new Exception("Immagine non valorizzato");
                }
            }
        }

        public string VersoPath
        {
            get => _versoPath;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _versoPath = value;
                }
                else
                {
                    throw new Exception("Verso non valorizzato");
                }
            }
        }

        public Animale(string name, string imaginePath, string soundPath)
        {
            Nome = name;
            ImmaginePath = imaginePath;
            VersoPath = soundPath;
        }

        public string Getverso()
        {
            return _versoPath;
        }
    }
}
