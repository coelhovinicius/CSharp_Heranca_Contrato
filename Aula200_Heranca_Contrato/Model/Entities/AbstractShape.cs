using Aula200_Heranca_Contrato.Model.Enums;

namespace Aula200_Heranca_Contrato.Model.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
