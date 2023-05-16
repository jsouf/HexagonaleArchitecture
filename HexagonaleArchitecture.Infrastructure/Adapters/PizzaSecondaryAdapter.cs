using HexagonaleArchitecture.Domain.DTOs;
using HexagonaleArchitecture.Domain.Enums;
using HexagonaleArchitecture.Domain.Ports.Secondary;
using HexagonaleArchitecture.Infrastructure.Models;

namespace HexagonaleArchitecture.Infrastructure.Adapters
{
    /// <summary>
    /// Ces adaptateurs font appel aux ports secondaires. Contrairement aux adaptateurs primaires, ils implémentent l’interface correspondant au port secondaires. 
    /// Ils sont injectés dans l’hexagone au moyen de l’inversion de dépendance. L’hexagone peut, alors, y faire appel pour effectuer des traitements.
    /// Concrètement, on utilisera un adaptateur secondaire pour:
    /// - permettre d’effectuer des appels vers l’extérieur de l’hexagone en fournissant à l’adaptateur des données respectant les interfaces correspondant aux ports secondaires.
    /// - l’adaptateur secondaire effectue une conversion de ces données vers un format compréhensible des objets du monde extérieur.
    /// - l’adaptateur secondaire effectue des appels au monde extérieur en utilisant les objets convertis.
    /// </summary>
    public class PizzaSecondaryAdapter : IPizzaSecondaryPort
    {
        /// <summary>
        /// FakeData : liste des pizzas
        /// </summary>
        private readonly List<PizzaInfrastructureModel> pizzaContext = new()
        {
            new PizzaInfrastructureModel { PizzaKind = PizzaKind.Regina, AverageSliceCount = 6, Size = 40 },
            new PizzaInfrastructureModel { PizzaKind = PizzaKind.Pepperoni, AverageSliceCount = 4, Size = 30 },
            new PizzaInfrastructureModel { PizzaKind = PizzaKind.Vegetarian, AverageSliceCount = 7, Size = 35 },
            new PizzaInfrastructureModel { PizzaKind = PizzaKind.Regina, AverageSliceCount = 5, Size = 20 }
        };

        public IEnumerable<IPizzaDto> GetAll()
        {
            // appel API ici

            // mapper Models Infrastructure => Dto
            var pizzas = pizzaContext.Select(pizza => new PizzaDto
            {
                PizzaKind = pizza.PizzaKind,
                AverageSliceCount = pizza.AverageSliceCount,
                Size = pizza.Size
            });

            return pizzas;
        }
    }
}