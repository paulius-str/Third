using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third
{
    internal class Cipher
    {
        private List<int> values = new List<int>();

        public List<int> Values => values;

        public void AddValue(int value)
        {
            values.Add(value);
        }

        public override string ToString()
        {
            string result = "";

            foreach (var value in values)
            {
                result += value.ToString() + " ";
            }

            result = result.Remove(result.Length - 1, 1);

            return result;
        }
    }
}
