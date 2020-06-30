using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace FindSurf.Domain.Enumerable
{
    public enum StatusEnum
    {
        [Description("A venda")] Avenda = 1,

        [Description("Vendido")] Vendido = 2,
    }

}
