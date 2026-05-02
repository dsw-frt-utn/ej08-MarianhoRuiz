using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8;




public class Problema3
{
    internal class Product
    {
        long code;
        string description;
        decimal price;

        public Product(long code, string description, decimal price)
        {
            this.code = code;
            this.description = description;
            this.price = price;
        }

        public void SetDescription(string description) => this.description = description; 
        public string GetDescription() =>  this.description;
    }

    internal string CompararCopias(int originalValue,Product product)
    {
        var copia = originalValue;
        copia += 1;
        var copia2 = product;
        copia2.SetDescription("Nuevo producto");
        return $"ValorOriginal:{originalValue}-ValorCopia:{copia}-descripcionProducto:{copia2.GetDescription()}";
    }
}
