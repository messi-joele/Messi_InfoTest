using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messi_InfoTest
{
     public  abstract    class Messi_Candidato
    {
        private int messi_matricola;
        private string messi_nome;
        
        public Messi_Candidato(string Messi_nome, int Messi_matricola) 
        {
            
        }
       
        
        private int Matricola
        {
            get { return messi_matricola; }
            set { messi_matricola = value; }
        }

        private string Nome
        {
            get { return messi_nome; }
            set { messi_nome = value; }
        }
        public Messi_Candidato()
        {
            messi_matricola = 0;
            messi_nome = null;
        }

        public Messi_Candidato(int n)
        {
            messi_matricola = n;
            messi_nome = null;
        }
        public Messi_Candidato(string s)
        {
            messi_matricola = 0;
            messi_nome = s;
        }

        public Messi_Candidato(int n, string s)
        {
            messi_matricola = n;
            messi_nome = s;
        }


        public abstract bool isIdoneo();
        
            


        public abstract int punteggio();
        
    }


}
