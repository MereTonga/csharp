using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCD_Ekran
{
    internal class Numerals
    {
        public int[,] One()
        {
            return new int[7, 4]
            {
            { 0,0,1,0},
            { 0,1,1,0},
            { 1,0,1,0},
            { 0,0,1,0},
            { 0,0,1,0},
            { 0,0,1,0},
            { 0,1,1,1} 
            };
        }

        public int[,] Two()
        {
            return new int[7, 4]
            {
            { 0,1,1,0},
            { 1,0,0,1},
            { 0,0,0,1},
            { 0,0,1,0},
            { 0,1,0,0},
            { 1,0,0,0},
            { 1,1,1,1}
            };
        }

        public int[,] Three()
        {
            return new int[7, 4]
            {
            { 0,1,1,0},
            { 1,0,0,1},
            { 0,0,0,1},
            { 0,0,1,0},
            { 0,0,0,1},
            { 1,0,0,1},
            { 0,1,1,0}
            };
        }

        public int[,] Four()
        {
            return new int[7, 4]
            {
            { 0,0,0,1},
            { 0,0,1,1},
            { 0,1,0,1},
            { 1,0,0,1},
            { 1,1,1,1},
            { 0,0,0,1},
            { 0,0,0,1}
            };
        }

        public int[,] Five()
        {
            return new int[7, 4]
            {
            { 1,1,1,1},
            { 1,0,0,0},
            { 1,1,1,0},
            { 0,0,0,1},
            { 0,0,0,1},
            { 1,0,0,1},
            { 0,1,1,0}
            };
        }

        public int[,] Six()
        {
            return new int[7, 4]
            {
            { 0,1,1,0},
            { 1,0,0,1},
            { 1,0,0,0},
            { 1,1,1,0},
            { 1,0,0,1},
            { 1,0,0,1},
            { 0,1,1,0}
            };
        }

        public int[,] Seven()
        {
            return new int[7, 4]
            {
            { 1,1,1,1},
            { 0,0,0,1},
            { 0,0,0,1},
            { 0,0,1,0},
            { 0,1,0,0},
            { 0,1,0,0},
            { 0,1,0,0}
            };
        }

        public int[,] Eight()
        {
            return new int[7, 4]
            {
            { 0,1,1,0},
            { 1,0,0,1},
            { 1,0,0,1},
            { 0,1,1,0},
            { 1,0,0,1},
            { 1,0,0,1},
            { 0,1,1,0}
            };
        }

        public int[,] Nine()
        {
            return new int[7, 4]
            {
            { 0,1,1,0},
            { 1,0,0,1},
            { 1,0,0,1},
            { 0,1,1,1},
            { 0,0,0,1},
            { 1,0,0,1},
            { 0,1,1,0}
            };
        }

        public int[,] Zero()
        {
            return new int[7, 4]
            {
            { 0,1,1,0},
            { 1,0,0,1},
            { 1,0,0,1},
            { 1,0,0,1},
            { 1,0,0,1},
            { 1,0,0,1},
            { 0,1,1,0}
            };
        }
    }
}
