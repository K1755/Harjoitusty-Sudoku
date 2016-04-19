using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class Check
    {
        //List<int> check = new List<int>();

        //http://stackoverflow.com/questions/5111434/sudoku-validity-check-algorithm-how-does-this-code-works
        public static bool IsValid(int[] values)
        {
            // bit field (set to zero => no values processed yet)
            int flag = 0;
            foreach (int value in values)
            {
                // value == 0 => reserved for still not filled cells, not to be processed
                if (value != 0)
                {
                    // prepares the bit mask left-shifting 1 of value positions
                    int bit = 1 << value;
                    // checks if the bit is already set, and if so the Sudoku is invalid
                    if ((flag & bit) != 0)
                        return false;
                    // otherwise sets the bit ("value seen")
                    flag |= bit;
                }
            }
            // if we didn't exit before, there are no problems with the given values
            return true;
        }
    }
}
