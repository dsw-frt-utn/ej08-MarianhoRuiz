using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8;




public class Problema3
{
    public class Product
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

    public string CompararCopias(int originalValue,Product product)
    {
        var copia = originalValue;
        copia += 1;
        var copia2 = product;
        copia2.SetDescription("Nuevo producto");
        return $"{originalValue}-{copia}-{product.GetDescription()}";
    }
}
