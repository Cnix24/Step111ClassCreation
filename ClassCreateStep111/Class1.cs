using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCreateStep111
{
    public class Mathing
    {
        public int inputValue { get; set; }
        public int Multiplier { get; set; }
        public int Adder { get; set; }
        public int Subtractor { get; set; }
        public Mathing(int inputValue)
            {
            Multiplier = inputValue * 10;
            Adder = inputValue + 23;
            Subtractor = inputValue - 9;
            }
    }
}
