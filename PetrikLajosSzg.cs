using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GepteremProjekt
{
    class PetrikLajosSzg
    {
        private List<Gepterem> geptermek = new List<Gepterem>();

        public List<Gepterem> Geptermek {
            get {
                return geptermek;
            }
        }

        public PetrikLajosSzg(string filenev) {
            try
            {
                using (StreamReader sr = new StreamReader(filenev))
                {
                    while (!sr.EndOfStream)
                    {
                        string nev = sr.ReadLine();
                        string[] sor = sr.ReadLine().Split(';');
                        int sorokSzama = int.Parse(sor[0]);
                        int helyekSzama = int.Parse(sor[1]);
                        int[,] sorok = new int[sorokSzama, helyekSzama];
                        string ujSor = string.Empty;
                        int akarmi = 0;
                        while ((ujSor = sr.ReadLine()) != "")
                        {
                            sor = ujSor.Split(';');
                            for (int i = 0; i < helyekSzama; i++)
                            {
                                sorok[akarmi, i] = int.Parse(sor[i]);
                            }
                            akarmi++;

                        }
                        Geptermek.Add(new Gepterem(nev, sorokSzama, helyekSzama, sorok));
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }


        }


    }

}
