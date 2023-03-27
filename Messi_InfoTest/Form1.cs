namespace Messi_InfoTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        List<Messi_Candidato> lista = new List<Messi_Candidato>();
        public void Add(Messi_Candidato a)
        {
            lista.Add(a);
        }


        public string[] Visualizza(List<Messi_Candidato> a)
        {
            string[] s = new string[999];
            int n = 0;
            foreach (Messi_Candidato c in lista)
            {
                s[n] = c.ToString();
                n++;        
            }

            return s;
        }

        public void Modifica(string nome, int nmatricola)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Matricola == nmatricola)
                {
                    lista[i].Nome = nome;
                }
            }
        }

        public void Elimina(int nmatricola)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Matricola == nmatricola)
                {
                    lista[i] = null;
                }
            }
        }
        public string[] Idonei()
        {
            string[] z = new string[999];
            int n = 0;
            foreach (Messi_Candidato a in lista)
            {
                bool b = a.isIdoneo();
                if (b == true)
                {
                    z[n] = a.ToString();
                    n++;
                }
            }
            return z;
        }



    }
}   