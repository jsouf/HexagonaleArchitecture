using HexagonaleArchitecture.ConsoleApp.Adapters;
using HexagonaleArchitecture.Domain;
using HexagonaleArchitecture.Domain.Ports.Primary;
using HexagonaleArchitecture.Infrastructure.Adapters;

namespace HexagonaleArchitecture.ConsoleApp;

class Program
{
    public static void Main(string[] args)
    {
        var repositoryAdapter = new PizzaSecondaryAdapter();
        var pizzaService = new PizzaService(repositoryAdapter);
        var pizzaCalculator = new PizzaPrimaryPort(pizzaService);
        var consoleAdapter = new ConsolePrimaryAdapter(pizzaCalculator);

        consoleAdapter.ShowAvailablePizzas();

        Console.WriteLine();

        consoleAdapter.LaunchPizzaCalculation();
    }
}