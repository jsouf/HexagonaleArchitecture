using HexagonaleArchitecture.Domain;
using HexagonaleArchitecture.Domain.Enums;

namespace HexagonaleArchitecture.Adapters
{
    public class ConsoleAdapter
    {
        private readonly IPizzaCalculator pizzaCalculator;

        public ConsoleAdapter(IPizzaCalculator pizzaCalculator)
        {
            this.pizzaCalculator = pizzaCalculator;
        }

        public void LaunchPizzaCalculation()
        {
            System.Console.WriteLine("Entrez le nombre de personnes: ?");

#pragma warning disable CS8604 // Existence possible d'un argument de référence null.
            uint personCount = uint.Parse(System.Console.ReadLine());
#pragma warning restore CS8604 // Existence possible d'un argument de référence null.

            System.Console.WriteLine(@"Entrez le type de pizza: 
            1-Vegetarian  
            2-Peperoni
            3-Regina");

#pragma warning disable CS8604 // Existence possible d'un argument de référence null.
            int pizzaKindAsInt = int.Parse(System.Console.ReadLine());
#pragma warning restore CS8604 // Existence possible d'un argument de référence null.

            var pizzaKind = pizzaKindAsInt switch
            {
                1 => PizzaKind.Vegetarian,
                2 => PizzaKind.Pepperoni,
                3 => PizzaKind.Regina,
                _ => throw new InvalidOperationException("Le type de pizza n'a pas été compris"),
            };

            int pizzaCount = pizzaCalculator.GetPizzaCount(personCount, pizzaKind);

            System.Console.WriteLine("Il faudra {0} pizza(s).", pizzaCount);
        }
    }
}
