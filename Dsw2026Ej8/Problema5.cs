using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Dsw2026Ej8;

public class Problema5
{
    public class Sale
    {
        private decimal amount;
        private decimal discount;

        public Sale(decimal amount, decimal discount)
        {
            this.amount = amount;
            this.discount = discount;
        }

        public decimal Amount { get => amount; set => amount = value; }
        public decimal Discount { get => discount; set => discount = value; }

        /* public decimal GetAmount()
         {
             return Amount;
         }
         public decimal GetDiscount()
         {
             return Discount;
         }
         public void setAmount(decimal amount)
         {
             Amount = amount;
         }
         public void setDiscount(decimal discount)
         {
             Discount = discount;
         }
         */


        public virtual decimal CalculateTotal()
        {
            return Amount - Discount;
        }
    }

    public class RetailSale : Sale
    {
        public RetailSale(decimal amount, decimal discount) : base(amount, discount)
        {
        }

        public override decimal CalculateTotal()
        {
            return this.Amount;
        }
    }

    public class WholesaleSale : Sale
    {
        public WholesaleSale(decimal amount, decimal discount) : base(amount, discount)
        {
        }

        public override decimal CalculateTotal()
        {
            return this.Amount * 0.90m; 
        }
    }



    public decimal ObtenerImporteFinal(Sale sale)
    { 
        var total = sale.CalculateTotal();
        return total;
    }
}
