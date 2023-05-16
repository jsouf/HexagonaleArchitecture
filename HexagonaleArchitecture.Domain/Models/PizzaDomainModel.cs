using HexagonaleArchitecture.Domain.Enums;

namespace HexagonaleArchitecture.Domain.Models
{
    internal class PizzaDomainModel : IPizzaDomainModel
    {
        private const double sliceCountPerPizza = 6;

        public PizzaKind PizzaKind { get; set; }
        public int AverageSliceCount { get; set; }
        public int Size { get; set; }

        public int CalculatePersonCount(uint personCount)
        {
            double pizzaCount = ((double)AverageSliceCount * personCount) / sliceCountPerPizza;

            return (int)Math.Ceiling(pizzaCount);
        }
    }
}
