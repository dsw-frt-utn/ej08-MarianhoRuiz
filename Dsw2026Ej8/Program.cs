using static Dsw2026Ej8.Problema5;

namespace Dsw2026Ej8;

internal class Program
{
    static void Main(string[] args)
    {
        var helper = new ProductHelper();
        Console.WriteLine(helper.ObtenerEtiquetaProducto(123, "Producto A", 10.5m));

        Console.WriteLine(Problema2.CrearResumenVenta(123, "Producto A", 5, 10.5m));

        var p3 = new Problema3();
        var producto = new Problema3.Product(1, "Producto original", 100m);
        Console.WriteLine(p3.CompararCopias(10, producto));

        Console.WriteLine(Problema4.CalcularPromedio(null, null, null));
        Console.WriteLine(Problema4.CalcularPromedio(8, 6, null));

        var p5 = new Problema5();
        Problema5.Sale retail = new Problema5.RetailSale(2000m, 0m);
        Problema5.Sale wholesale = new Problema5.WholesaleSale(2000m, 0m);
        Console.WriteLine(p5.ObtenerImporteFinal(retail));      
        Console.WriteLine(p5.ObtenerImporteFinal(wholesale));   

        Console.WriteLine(Problema6.NormalizarCodigoProducto(" ab 123 x "));
        Console.WriteLine(Problema6.NormalizarCodigoProducto(null));


    }
}
