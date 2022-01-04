using System;
using System.Globalization;

namespace Aula200_Heranca_Contrato.Model.Entities
{
    // class Rectangle : Shape // Sem Interface
    class Rectangle : AbstractShape // Com Interface
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return Width * Height;
        }

        public override string ToString()
        {
            return "Rectangle color = " + Color
                + ", width = " + Width.ToString("F2", CultureInfo.InvariantCulture)
                + ", height = " + Height.ToString("F2", CultureInfo.InvariantCulture)
                + ", area = " + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
