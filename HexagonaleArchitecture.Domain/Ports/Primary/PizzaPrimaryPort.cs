﻿using HexagonaleArchitecture.Domain.Enums;

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
    }
}
