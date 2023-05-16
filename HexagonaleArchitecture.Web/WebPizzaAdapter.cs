using HexagonaleArchitecture.Domain;

namespace HexagonaleArchitecture.Web
{
    public class WebPizzaAdapter
    {
        private IPizzaCalculator pizzaCalculator;

        public WebPizzaAdapter(IPizzaCalculator pizzaCalculator)
        {
            this.pizzaCalculator = pizzaCalculator;
        }

        public void LaunchPizzaCalculation()
        {
            Console.WriteLine("Entrez le nombre de personnes: ?");
            uint personCount = uint.Parse(Console.ReadLine());

            Console.WriteLine(@"Entrez le type de pizza: 
            1-Vegetarian  
            2-Peperoni
            3-Regina");
            int pizzaKindAsInt = int.Parse(Console.ReadLine());
            var pizzaKind = pizzaKindAsInt switch
            {
                1 => PizzaKind.Vegetarian,
                2 => PizzaKind.Pepperoni,
                3 => PizzaKind.Regina,
                _ => throw new InvalidOperationException("Le type de pizza n'a pas été compris"),
            };
            int pizzaCount = this.pizzaCalculator.GetPizzaCount(personCount, pizzaKind);

            Console.WriteLine("Il faudra {0} pizza(s).", pizzaCount);
        }
    }
}
