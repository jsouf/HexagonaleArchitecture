using HexagonaleArchitecture.Domain.Enums;

namespace HexagonaleArchitecture.Domain.DTOs
{
    public interface IPizzaLightDto
    {
        public PizzaKind PizzaKind { get; set; }
        public int AverageSliceCount { get; set; }
    }
}
