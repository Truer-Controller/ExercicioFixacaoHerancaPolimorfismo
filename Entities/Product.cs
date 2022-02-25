using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExercicioFixacaoHerancaPolimorfismo.Entities
{
    class Product
    {
        public string NameProdct { get; set; }
        public double PriceProduct { get; set; }

        public Product()
        {
        }

        public Product(string nameProdct, double priceProduct)
        {
            NameProdct = nameProdct;
            PriceProduct = priceProduct;
        }

    public virtual string PriceTeg()
        {
            return NameProdct 
                + " $ " 
                + PriceProduct.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
