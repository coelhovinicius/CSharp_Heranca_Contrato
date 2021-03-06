using System;
using System.Globalization;

namespace Aula200_Heranca_Contrato.Model.Entities
{
    // class Circle : Shape // Sem Interface
    class Circle : AbstractShape // Com Interface
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override string ToString()
        {
            return "Circle color = " + Color
                + ", radius = " + Radius.ToString("F2", CultureInfo.InvariantCulture)
                + ", area = " + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
