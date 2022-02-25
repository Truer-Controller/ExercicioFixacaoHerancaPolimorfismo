using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExercicioFixacaoHerancaPolimorfismo.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactoryDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string nameProdct, double priceProduct, DateTime manufactoryDate) : base(nameProdct,priceProduct)
        {
            ManufactoryDate = manufactoryDate;
        }

        public override string PriceTeg()
        {
            return NameProdct 
                + "(used) $ " 
                + PriceProduct.ToString("F2", CultureInfo.InvariantCulture) 
                + "(Manufactory Date: " 
                + ManufactoryDate.ToString("dd/MM/yyyy") 
                + ")";
        }
    }
}
