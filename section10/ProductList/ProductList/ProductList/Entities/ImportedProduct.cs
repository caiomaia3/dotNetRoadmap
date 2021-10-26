using System.Globalization;

namespace ProductList.Entities
{
    class ImportedProduct : Product
    {
        public double CustomFee { get; set; }

        public ImportedProduct()
        {

        }
        public ImportedProduct(string name, double price, double customFee) : base(name,price)
        {
            CustomFee = customFee;
        }

        public override string PriceTag()
        {
            return $"{Name} $ {(this.TotalPrice()).ToString("F2", CultureInfo.InvariantCulture)} " +
                $"(Customs fee: $ {CustomFee.ToString("F2",CultureInfo.InvariantCulture)})" ;
        }

        double TotalPrice()
        {
            return Price + CustomFee;
        }
    }
}
