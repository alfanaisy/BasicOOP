using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOP
{
    class Menu2
    {
        private string name;

        public string Name { get => name; set => name = value; }

        public void reprintName()
        {
            int j = 1;
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine("huruf ke " + j + " : " + name[i]);
                j++;
            }
        }
    }
}
