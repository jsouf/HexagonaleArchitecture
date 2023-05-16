using HexagonaleArchitecture.Domain.DTOs;

namespace HexagonaleArchitecture.Domain.Ports.Secondary
{
    /// <summary>
    /// Port secondaire : ports de sortie de l'hexagone (Domain)
    /// Ce sont les ports de sortie de l’hexagone c’est-à-dire qu’il les utilise pour effectuer des appels vers l’extérieur. 
    /// Ces ports sont aussi des interfaces définies à l’intérieur de l’hexagone toutefois l’implémentation de ces interfaces ne se trouvent pas dans l’hexagone mais à l’extérieur par des adaptateurs secondaires. 
    /// Les objets implémentant les ports secondaires sont fournis à l’hexagone par inversion de dépendances.
    /// Pour résumer, des adaptateurs implémentant les ports secondaires sont fournis à l’hexagone qui les utilise pour effectuer ses appels à l’extérieur.
    /// </summary>
    public interface IPizzaSecondaryPort
    {
        IEnumerable<IPizzaDto> GetAll();
    }
}