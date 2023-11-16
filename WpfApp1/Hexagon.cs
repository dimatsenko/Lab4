using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Hexagon : Shape
    {
        public int SideLength { get; set; }
        public int RotationAngle { get; set; }

        public Hexagon(int x, int y, int sideLength) : base(x, y)
        {
            SideLength = sideLength;
        }

        public override void Resize(double factor)
        {
            SideLength = (int)(SideLength * factor);
        }

        public override void Rotate(int angle)
        {
            // Implement rotation logic for a quadrilateral
            RotationAngle += angle;
            Console.WriteLine($"Rotating the quadrilateral by {angle} degrees. New angle: {RotationAngle} degrees.");
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing a hexagon.");
        }
    }
}