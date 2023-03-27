using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messi_InfoTest
{
    public abstract class Messi_Disoccupato : Messi_Candidato
    {
        private int messi_voto;
        private bool messi_lode;
        public Messi_Disoccupato(int n, bool b, int matricola, string nome) : base(matricola, nome)
        {
            messi_voto = n;
            messi_lode = b;
        }

        public Messi_Disoccupato()
        {
            messi_voto = 0;
            messi_lode = false;
        }
        public   int Voto
        {
            get { return messi_voto ; }
            set
            {
                if (value >= 0 && value <= 110)
                    messi_voto = value;
                else
                    throw new Exception("Voto non valido");

            }
        }
        public bool Lode
        {
            get { return messi_lode; }
            set
            {
                if (messi_voto == 110)
                {
                    try
                    {
                        messi_lode = value;
                    }
                    catch
                    {
                        throw new Exception("Lode non valida");
                    }
                }
                else
                    throw new Exception("Lode non disponibile");
            }
        }
        public Messi_Disoccupato(int n, bool s)
        {
            messi_voto = n;
            messi_lode = s;
        }

        public override int punteggio()
        {
            int a = (messi_voto * 100) / 110;
            if (messi_lode == true)
                a += 5;

            return a;
        }

        public override bool isIdoneo()
        {
            if (punteggio() >= 72)
                return true;

            return false;
        }

        public override string ToString()
        {
            string s = messi_voto + ", " + messi_lode + ", ";
            return s;
        }
        public bool Equals(Messi_Disoccupato x)
        {
            if (x == null)
                return false;
            if (this == x)
                return true;
            if (this.Matricola == x.Matricola || this.Nome == x.Nome || this.Voto == x.Voto || this.Lode == x.Lode)
                return true;
            else
                return false;
        }
        public int CompareTo(Messi_Disoccupato dis)
        {
            if (dis == null) return 1;

            return punteggio().CompareTo(dis.punteggio());
        }
        public override bool CompareTo(Messi_Candidato k)
        {
            if (this.punteggio() == k.punteggio())
                return true;
            else
                return false;
        }
    }
        
        
    }
   

