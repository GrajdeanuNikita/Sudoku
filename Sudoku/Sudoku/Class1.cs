using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    internal class CGioco 
    {
        private const int SIZE = 9;
        private int[,] tabella;
        private Dictionary<int, HashSet<int>> grafo;
       // public int riga;

        // hack sent , valori dell'insieme invece il contenitore è formato da un dizionario, lista. 
        // ogmi quadrante ha più o meno 3/4/4 numeri già inseriti 
        //in caso aggiunta di difficoltà, più difficile=meno numeri


        public CGioco(int[,] tabella)
        {
            this.tabella = tabella;
            this.grafo = new Dictionary<int, HashSet<int>>();
          //  this.riga = riga;
            CostruttoGrafo();
        }
        public void Risolto()
        {
            if (RisolviSudoku())
            {
                StampaTabella();
            }else
            {
                Console.WriteLine("nessuna soluzione");
            }
        }

        public bool UsoRiga( int riga, int num)
        {
            for(int colonna=0; colonna<SIZE; colonna++)
            {
                if (tabella[colonna, riga] == num)
                {
                    return true;
                }
            }
            return false;
        }

        public bool UsoColonna(int colonna, int num)
        {
            for (int riga = 0; riga < SIZE; riga++)
            {
                if (tabella[riga, colonna] == num)
                {
                    return true;
                }
            }
            return false;
        }

        public bool UsoQuadrante(int rigaI, int colonnaI , int num)
        {
            for( int riga=0; riga < 3; riga++)
            {
                for(int colonna=0; colonna < 3; colonna++)
                {
                    if (tabella[riga+rigaI, colonna+colonnaI] == num)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool Libero(int riga, int colonna, int num)
        { 
            return !UsoRiga(riga, num) && !UsoColonna(colonna, num) &&
                   !UsoQuadrante(riga-riga %3, colonna-colonna %3, num);
        }
        public void CostruttoGrafo()
        {
            for (int i=0; i < SIZE* SIZE; i++)
            {
                grafo[i] = new HashSet<int>();
            }
            for(int riga=0; riga <SIZE; riga++)
            {
                for(int colonna=0; colonna< SIZE; colonna++)
                {
                    if (tabella[riga, colonna]==0)
                    {
                        int cella = riga * SIZE + colonna;

                        for(int num= 1; num<= SIZE; num++)
                        {
                            if(Libero(riga, colonna, num))
                            {
                                int vicino = num - 1;
                                grafo[cella].Add(vicino);
                                grafo[vicino].Add(cella);
                            }
                        }
                    }
                }
            }
        }


        private void StampaTabella()
        {
            for (int i=0; i< SIZE; i++)
            {
                for(int j=0; j<SIZE; j++)
                {
                    Console.Write(tabella[i,j] + "  ");
                }
                Console.WriteLine();
            }
        }
        private bool RisolviSudoku()
        {
            int riga, colonna;

        }

    }
}
