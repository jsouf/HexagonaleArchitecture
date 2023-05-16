using HexagonaleArchitecture.Domain.Enums;

namespace HexagonaleArchitecture.Domain.DTOs
{
    public class PizzaDto : IPizzaDto
    {
        public PizzaKind PizzaKind { get; set; }
        public int AverageSliceCount { get; set; }
        public int Size { get; set; }
    }
}
