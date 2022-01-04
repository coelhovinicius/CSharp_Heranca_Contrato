using Aula200_Heranca_Contrato.Model.Enums;

namespace Aula200_Heranca_Contrato.Model.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
