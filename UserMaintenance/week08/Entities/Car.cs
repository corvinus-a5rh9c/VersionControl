using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserMaintenance.Abstractions;

namespace week08.Entities
{
    class Car : Toy
    {
        protected override void DrawImage(Graphics picture)
        {
            Image imageFile = Image.FromFile("Images/car.png");
            picture.DrawImage(imageFile, new Rectangle(0, 0, Width, Height));
        }
    }
}
