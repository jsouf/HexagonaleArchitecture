using HexagonaleArchitecture.Domain.DTOs;
using HexagonaleArchitecture.Domain.Enums;

namespace HexagonaleArchitecture.Domain
{
    public interface IPizzaService
    {
        int GetPizzaCount(uint personCount, PizzaKind pizzaKind);
        IList<IPizzaLightDto> GetPizzas();
    }
}
