﻿using HexagonaleArchitecture.Domain.DTOs;
using HexagonaleArchitecture.Domain.Enums;
using HexagonaleArchitecture.Domain.Models;
using HexagonaleArchitecture.Domain.Ports.Secondary;

namespace HexagonaleArchitecture.Domain
{
    public class PizzaService : IPizzaService
    {
        private readonly IPizzaSecondaryPort _pizzaSecondaryPort;

        public PizzaService(IPizzaSecondaryPort pizzaSecondaryPort)
        {
            _pizzaSecondaryPort = pizzaSecondaryPort;
        }

        public int GetPizzaCount(uint personCount, PizzaKind pizzaKind)
        {
            IEnumerable<IPizzaDto> pizzasDTO = _pizzaSecondaryPort.GetAll();
            IPizzaDto foundPizzaDto = pizzasDTO.FirstOrDefault(s => s.PizzaKind.Equals(pizzaKind)) ?? throw new InvalidOperationException("Type de pizza inconnu");

            // automapper : mapping DTO => DomainModel
            IPizzaDomainModel pizzaDomainModel = new PizzaDomainModel
            {
                PizzaKind = foundPizzaDto.PizzaKind,
                AverageSliceCount = foundPizzaDto.AverageSliceCount,
                Size = foundPizzaDto.Size,
            };

            return pizzaDomainModel.CalculatePersonCount(personCount);
        }

        public IList<IPizzaLightDto> GetPizzas()
        {
            IEnumerable<IPizzaDto> pizzasDtos = _pizzaSecondaryPort.GetAll();

            IList<IPizzaDomainModel> pizzasDomainModels = pizzasDtos
                .Select(pizza => new PizzaDomainModel
                {
                    AverageSliceCount = pizza.AverageSliceCount,
                    PizzaKind = pizza.PizzaKind,
                    Size = pizza.Size
                })
                // filter pizzas that can be sold
                .Where(pizza => pizza.IsSalable())
                .ToList<IPizzaDomainModel>();

            var pizzasLightDtos = pizzasDomainModels
                .Select(pizza => new PizzaLightDto
                {
                    AverageSliceCount = pizza.AverageSliceCount,
                    PizzaKind = pizza.PizzaKind
                })
                .ToList<IPizzaLightDto>();

            return pizzasLightDtos;
        }
    }
}
