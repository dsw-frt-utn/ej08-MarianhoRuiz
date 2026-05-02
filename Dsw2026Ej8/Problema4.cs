using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8;

static internal class Problema4
{
    static public double CalcularPromedio(int? nota1,int? nota2,int? nota3)
    {
        return (double) (( (nota1 >= 0.0) && (nota1 <= 10.0) ? nota1 : 0.0) + (nota2 >= 0.0 && nota2 <= 10.0 ? nota2 : 0.0) + (nota3 >= 0.0 && nota3 <= 10.0 ? nota3 : 0.0)) / 3.0;
    }
}
