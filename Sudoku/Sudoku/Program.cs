using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] tabella = GeneraSudoku();
            CGioco risolvi = new CGioco(tabella);
            
        }
    }
}
