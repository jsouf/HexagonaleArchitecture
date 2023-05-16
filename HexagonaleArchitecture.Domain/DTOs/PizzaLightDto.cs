using HexagonaleArchitecture.Domain.Enums;

namespace HexagonaleArchitecture.Domain.DTOs
{
    public class PizzaLightDto : IPizzaLightDto
    {
        public PizzaKind PizzaKind { get; set; }
        public int AverageSliceCount { get; set; }
    }
}
