﻿using HexagonaleArchitecture.Domain.Enums;

namespace HexagonaleArchitecture.Domain.DTOs
{
    public interface IPizzaDto
    {
        public PizzaKind PizzaKind { get; set; }
        public int AverageSliceCount { get; set; }

        /// <summary>
        /// Taille de la pizza, propriété non transférée à la Console
        /// </summary>
        public int Size { get; set; }
    }
}
