using HexagonaleArchitecture.Domain.DTOs;
using HexagonaleArchitecture.Domain.Enums;
using HexagonaleArchitecture.Domain.Ports.Secondary;
using Moq;

namespace HexagonaleArchitecture.Tests.Fixtures
{
    public class PizzaCalculatorFixture : IDisposable
    {
        public readonly Mock<IPizzaSecondaryPort> repositoryMock;

        public PizzaCalculatorFixture()
        {
            repositoryMock = new Mock<IPizzaSecondaryPort>();
            Init();
        }

        public void Init()
        {
            var pizzaStats = new List<PizzaDto>{
                new PizzaDto { PizzaKind = PizzaKind.Regina, AverageSliceCount = 6},
                new PizzaDto { PizzaKind = PizzaKind.Pepperoni, AverageSliceCount = 4},
                new PizzaDto { PizzaKind = PizzaKind.Vegetarian, AverageSliceCount = 7},
            };

            repositoryMock.Setup(r => r.GetAll()).Returns(pizzaStats);
        }

        public void Dispose() { }
    }
}
