using HexagonaleArchitecture.Domain.Enums;

namespace HexagonaleArchitecture.Domain.Ports.Primary
{
    /// <summary>
    /// Ce sont les ports d’entrée de l’hexagone, ce qui signifie que la couche application fait appel aux ports primaires de l’hexagone pour effectuer des traitements en utilisant des adaptateurs.
    /// L’hexagone fournit une interface sous la forme d’un port, cette interface est utilisée par un adaptateur pour appeler le traitement métier dans l’hexagone.C’est donc un objet de l’hexagone qui implémente l’interface.
    /// </summary>
    public interface IPizzaPrimaryPort
    {
        int GetPizzaCount(uint personCount, PizzaKind pizzaKind);
    }
}
