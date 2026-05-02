namespace Dsw2026Ej8;

internal class Program
{
    static void Main(string[] args)
    {
        // Prueba de la clase ProductHelper a ver si funciona

        var productHelper = ProductHelper.ObtenerEtiquetaProducto(123,"pruebas",1250M);
        Console.WriteLine(productHelper);
    }
}
