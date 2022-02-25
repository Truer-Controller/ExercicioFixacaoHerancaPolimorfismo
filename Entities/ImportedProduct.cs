using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExercicioFixacaoHerancaPolimorfismo.Entities
{
    class ImportedProduct : Product
    {
        public double CustomFree { get; set; }


        public ImportedProduct()
        {               
        }

        public ImportedProduct(string nameProdct, double priceProduct, double customFree) : base(nameProdct, priceProduct)
        {
            CustomFree = customFree;
        }

        public double TotalPrice()
        {
            return PriceProduct + CustomFree;
        }
        public override string PriceTeg()
        {
            return NameProdct
                + " $ "
                + TotalPrice().ToString("F2", CultureInfo.InvariantCulture)
                + " (Customs fee: $ "
                + CustomFree.ToString("F2", CultureInfo.InvariantCulture)
                + ")";
        }
    }
}
