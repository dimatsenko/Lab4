using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public abstract class Shape : Point
    {
        public Shape(int x, int y) : base(x, y)
        {
        }

      

        public abstract void Resize(double factor);
        public abstract void Rotate(int angle);
        public abstract void Draw();
    }

}
