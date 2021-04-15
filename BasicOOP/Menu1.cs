using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOP
{
    class Menu1
    {
        private float weight, height;

        public float Weight { get => weight; set => weight = value; }
        public float Height { get => height; set => height = value; }

        public float HitungBMI()
        {
            
            height /= 100;
            float result = (float)(weight / Math.Pow(height, 2));
            return result;
        }
    }
}
