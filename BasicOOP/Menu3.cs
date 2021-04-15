using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOP
{
    class Menu3
    {
        private string name;

        public string Name { get => name; set => name = value; }

        public void getEvenChar()
        {
            for (int i = 0; i < name.Length; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(name[i]);
                }
            }
        }
    }
}
