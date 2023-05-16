using HexagonaleArchitecture.Domain;
using HexagonaleArchitecture.Domain.Enums;
using HexagonaleArchitecture.Tests.Fixtures;

namespace HexagonaleArchitecture.Tests
{

    public class PizzaCalculatorTests : IClassFixture<PizzaCalculatorFixture>
    {
        private readonly PizzaCalculatorFixture _fixture;

        public PizzaCalculatorTests(PizzaCalculatorFixture fixture)
        {
            _fixture = fixture;   
        }

        [Fact]
        public void When_Requesting_PizzaCount_For_One_Person_Then_PizzaCalculator_Shall_Return_Proper_Pizza_Count()
        {
            var pizzaCalculator = new PizzaService(_fixture.repositoryMock.Object);

            int pizzaCount = pizzaCalculator.GetPizzaCount(1, PizzaKind.Regina);
            Assert.Equal(1, pizzaCount);
            pizzaCount = pizzaCalculator.GetPizzaCount(1, PizzaKind.Pepperoni);
            Assert.Equal(1, pizzaCount);
            pizzaCount = pizzaCalculator.GetPizzaCount(1, PizzaKind.Vegetarian);
            Assert.Equal(2, pizzaCount);
        }

        [Fact]
        public void When_Requesting_PizzaCount_For_Several_Persons_Then_PizzaCalculator_Shall_Return_Proper_Pizza_Count()
        {
            var pizzaCalculator = new PizzaService(_fixture.repositoryMock.Object);

            int pizzaCount = pizzaCalculator.GetPizzaCount(3, PizzaKind.Regina);
            Assert.Equal(3, pizzaCount);
            pizzaCount = pizzaCalculator.GetPizzaCount(3, PizzaKind.Pepperoni);
            Assert.Equal(2, pizzaCount);
            pizzaCount = pizzaCalculator.GetPizzaCount(3, PizzaKind.Vegetarian);
            Assert.Equal(4, pizzaCount);
        }   
    }
}