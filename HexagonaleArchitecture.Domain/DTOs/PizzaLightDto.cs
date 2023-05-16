using HexagonaleArchitecture.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexagonaleArchitecture.Domain.DTOs
{
    public class PizzaLightDto
    {
        public PizzaKind PizzaKind { get; set; }
        public int AverageSliceCount { get; set; }
    }
}
