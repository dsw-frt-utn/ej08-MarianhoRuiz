using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8;

static partial class ProductHelper
{
    public static string ObtenerEtiquetaProducto(long code,string description, decimal price)
    {
        var aux = FormatearPrecio(price);   

        return $"Codigo:{code}, description:{description}, Precio:{aux}";
    }
}
