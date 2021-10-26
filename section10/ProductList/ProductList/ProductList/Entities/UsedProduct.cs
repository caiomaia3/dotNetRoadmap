using System;
using System.Globalization;

namespace ProductList.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureTime { get; set; }

        public UsedProduct()
        {

        }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            ManufactureTime = manufactureDate;
        }

        public override string PriceTag()
        {
            return $"{Name} (used) $ {Price.ToString("F2", CultureInfo.InvariantCulture)}" +
                $" (Manufacture date: {ManufactureTime.ToShortDateString()})";
        }
    }
}
