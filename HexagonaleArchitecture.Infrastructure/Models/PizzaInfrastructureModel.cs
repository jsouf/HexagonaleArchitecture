using HexagonaleArchitecture.Domain.Enums;

namespace HexagonaleArchitecture.Infrastructure.Models
{
    public class PizzaInfrastructureModel
    {
        public PizzaKind PizzaKind { get; set; }
        public int AverageSliceCount { get; set; }
    }
}
