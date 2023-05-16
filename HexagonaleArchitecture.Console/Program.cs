using HexagonaleArchitecture.Adapters;
using HexagonaleArchitecture.Domain;
using HexagonaleArchitecture.Infrastructure.Adapters;

namespace HexagonaleArchitecture.Console;

class Program
{
    public static void Main(string[] args)
    {
        var repositoryAdapter = new RepositoryAdapter();

        var pizzaCalculator = new PizzaCalculator(repositoryAdapter);

        var consoleAdapter = new ConsoleAdapter(pizzaCalculator);

        consoleAdapter.LaunchPizzaCalculation();
    }
}