using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_fattoria_degli_animali
{
    public class Cane : Animale
    {
        public Cane(string name) : base(name, @"..\..\..\img\Cane.png", @"..\..\..\sound\Cane.wav")
        {
        }
    }
    public class Gatto : Animale
    {
        public Gatto(string name) : base(name, @"..\..\..\img\Gatto.png", @"..\..\..\sound\Gatto.wav")
        {
        }
    }
    public class Mucca : Animale
    {
        public Mucca(string name) : base(name, @"..\..\..\img\Mucca.png", @"..\..\..\sound\Mucca.wav")
        {
        }
    }
}
