using HexagonaleArchitecture.Domain.DTOs;
using HexagonaleArchitecture.Domain.Enums;

namespace HexagonaleArchitecture.Domain.Ports.Primary
{
    public class PizzaPrimaryPort : IPizzaPrimaryPort
    {
        private readonly IPizzaService pizzaService;

        public PizzaPrimaryPort(IPizzaService pizzaService)
        {
            this.pizzaService = pizzaService;
        }

        public int GetPizzaCount(uint personCount, PizzaKind pizzaKind)
        {
            return pizzaService.GetPizzaCount(personCount, pizzaKind);
        }

        public IList<IPizzaLightDto> GetPizzas()
        {
            var pizzas = pizzaService.GetPizzas();

            return pizzas
                .Select(pizza => new PizzaLightDto
                {
                    AverageSliceCount = pizza.AverageSliceCount,
                    PizzaKind = pizza.PizzaKind
                })
                .ToList<IPizzaLightDto>();
        }
    }
}
