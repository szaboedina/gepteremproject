using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GepteremProjekt
{
    class Gepterem
    {
        private int[,] ertekeles;
        private int helyDb;
        private string nev;
        private int sorDb;

        public Gepterem(string nev, int sorDb, int helyDb, int[,] ertekeles)
        {
            this.nev = nev;
            this.sorDb = sorDb;
            this.helyDb = helyDb;
            this.ertekeles = ertekeles;
        }
        public double atlag()
        {
            double nullaDB = 0;
            double egyesDB = 0;
            double kettesDB = 0;
            double harmasDB = 0;
            for (int i = 0; i < sorDb; i++)
            {
                for (int j = 0; j < helyDb; j++)
                {
                    if (ertekeles[i, j] == 0)
                    {
                        nullaDB++;
                    }
                    if (ertekeles[i, j] == 1)
                    {
                        egyesDB++;
                    }
                    if (ertekeles[i, j] == 2)
                    {
                        kettesDB++;
                    }
                    if (ertekeles[i, j] == 3)
                    {
                        harmasDB++;
                    }
                }
            }

            return Math.Round((egyesDB * 1 + kettesDB * 2 + harmasDB * 3) / (ertekeles.Length - nullaDB), 1);

        }
        public void UjErt(int sor, int hely)
        {
            ertekeles[sor, hely] = (ertekeles[sor, hely] == 3) ? 0 : ++ertekeles[sor, hely];
        }

        public int[,] Ertekeles { get => ertekeles; set => ertekeles = value; }
        public int HelyDb { get => helyDb; set => helyDb = value; }
        public string Nev { get => nev; set => nev = value; }
        public int SorDb { get => sorDb; set => sorDb = value; }
    }

}
