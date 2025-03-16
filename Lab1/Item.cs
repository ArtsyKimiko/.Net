using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Item
    {
        public int Index { get; }
        public int Value { get; }
        public int Weight { get; }
        public double ValuePerWeight => Value / Weight;

        public Item(int index, int value, int weight)
        {
            Index = index;
            Value = value;
            Weight = weight;
        }

        public override string ToString()
        {
            return $"Item {Index}: Value = {Value}, Weight = {Weight}";
        }
    }    
}
