using HexagonaleArchitecture.Domain.Enums;

namespace HexagonaleArchitecture.ConsoleApp.Models
{
    public interface IPizzaAppModel
    {
        public PizzaKind PizzaKind { get; set; }
        public int AverageSliceCount { get; set; }
    }
}
