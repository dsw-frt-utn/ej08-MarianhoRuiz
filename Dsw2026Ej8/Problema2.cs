using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Dsw2026Ej8;

/*  Problema N° 2
Crear un método público CrearResumenVenta, dentro de una clase Problema2, que
reciba:
● long productCode
● string productDescription
● int quantity
● decimal unitPrice
El método debe crear internamente una clase anónima con los datos:
● Code
● Description
● Quantity
● Total
Debe retornar una cadena con el formato:
Code-Description-Total
Condiciones:
● Total debe calcularse como quantity * unitPrice.
● Si quantity es menor o igual a 0, el total debe ser 0.
● El método debe usar una clase anónima dentro de su implementación.

 */

static internal class Problema2
{
    static public string CrearResumenVenta(long productCode, string productDescription, int quantity, decimal unitPrice)
    {

        var resumenVenta = new { code = productCode, description = productDescription, Quantity = quantity, total = quantity <= 0 ? 0 : quantity * unitPrice };

        return $"{resumenVenta.code}-{resumenVenta.description}-{resumenVenta.total}";
    }









    





}
