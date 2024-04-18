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
        private Dictionary<int, HashSet<int>> graph;
        // hack sent , valori dell'insieme invece il contenitore è formato da un dizionario, lista. 
        // ogmi quadrante ha più o meno 3/4/4 numeri già inseriti 
        //in caso aggiunta di difficoltà, più difficile=meno numeri

    }
}
