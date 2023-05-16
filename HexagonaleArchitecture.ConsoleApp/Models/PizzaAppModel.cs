using HexagonaleArchitecture.Domain.Enums;

namespace HexagonaleArchitecture.ConsoleApp.Models
{
    public class PizzaAppModel : IPizzaAppModel
    {
        public PizzaKind PizzaKind { get; set; }
        public int AverageSliceCount { get; set; }
    }
}
