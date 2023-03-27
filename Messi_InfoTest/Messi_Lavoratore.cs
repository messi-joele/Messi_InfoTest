using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messi_InfoTest
{
    public abstract class Messi_Lavoratore : Messi_Candidato
    {
        public int messi_esperienze;

        public Messi_Lavoratore(int esperienze, int matricola, string nome) : base(matricola, nome)
        {
            messi_esperienze = esperienze;

        }
        public Messi_Lavoratore()
        {
            messi_esperienze = 0;
        }
        
        public int Esperienze
        {
            get
            {
                return messi_esperienze;
            }
            set
            {
                if (value >= 0 && value <= 5)
                    messi_esperienze = value;
                else
                    throw new Exception("Numero di esperienze non accettato");
            }
        }



    }
}
