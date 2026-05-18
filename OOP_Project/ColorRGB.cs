using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project
{
    internal class ColorRGB
    {
        private int red, green, blue;

        // renklerin 0-255 aralığında olması için (yaptığım araştırma sonucu if-else kullanmak yerine bu metodu kullanmayı tercih ettim)
        public int Red { get { return red; } set { red = Math.Max(0, Math.Min(255, value)); } }
        public int Green { get { return green; } set { green = Math.Max(0, Math.Min(255, value)); } }
        public int Blue { get { return blue; } set { blue = Math.Max(0, Math.Min(255, value)); } }


        // parametresi olmayan bit constructor tanımladım
        public ColorRGB()
        {
            red = green = blue = 0;
        }

        
        public ColorRGB(int red, int green, int blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }

        // renk değerlerinin 0-255 aralığında olması için olan kodu yukarıda yazmıştım, şimdi de random değer için bir fonksiyon yazdım
        public ColorRGB(Random random)
        {
            Red = random.Next(256);
            Green = random.Next(256);
            Blue = random.Next(256);
        }
    }
}
