﻿using HexagonaleArchitecture.Domain.Enums;
using HexagonaleArchitecture.Domain.Ports.Primary;

namespace HexagonaleArchitecture.ConsoleApp.Adapters
{
    /// <summary>
    /// Ces adaptateurs font appel directement aux ports primaires de l’hexagone. Comme indiqué précédemment, le port est une interface définie dans l’hexagone. 
    /// L’adaptateur est implémenté à l’extérieur de l’hexagone dans la couche application. L’adaptateur fait appel à l’hexagone en utilisant l’interface fournie par ce dernier.
    /// Concrètement, on passera par un adaptateur primaire pour:
    /// Récupérer les données provenant de l’extérieur
    /// Les adapter pour qu’elles soient compréhensibles pour les interfaces correspondant aux ports primaires
    /// Effectuer l’appel à l’hexagone en utilisant le port primaire et en lui fournissant les données traduites.
    /// </summary>
    public class ConsolePrimaryAdapter
    {
        private readonly IPizzaPrimaryPort pizzaPrimaryPort;

        /// <summary>
        /// Constructeur PrimaryAdapter : ici on injecte le Port comme une propriété pour le manipuler, l'implémentation étant dans la couche Domain
        /// </summary>
        /// <param name="pizzaPrimaryPort"></param>
        public ConsolePrimaryAdapter(IPizzaPrimaryPort pizzaPrimaryPort)
        {
            this.pizzaPrimaryPort = pizzaPrimaryPort;
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

            int pizzaCount = pizzaPrimaryPort.GetPizzaCount(personCount, pizzaKind);

            Console.WriteLine("Il faudra {0} pizza(s).", pizzaCount);
        }
    }
}
