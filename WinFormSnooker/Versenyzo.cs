using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormSnooker
{
    class Versenyzo
    {
        readonly ulong id;
        int helyezes;
        string nev;
        string orszag;
        int nyeremeny;

        public ulong Id => id;
        public int Helyezes { get => helyezes; set => helyezes = value; }
        public string Nev { get => nev; set => nev = value; }
        public string Orszag { get => orszag; set => orszag = value; }
        public int Nyeremeny { get => nyeremeny; set => nyeremeny = value; }

        public Versenyzo(ulong beId, int helyezes, string nev, string orszag, int nyeremeny)
        {
            this.id = beId;
            Helyezes = helyezes;
            Nev = nev;
            Orszag = orszag;
            Nyeremeny = nyeremeny;
        }
    }
}
