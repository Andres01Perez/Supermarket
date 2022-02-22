namespace Supermarket
{
    public class Invoice : IPay
    {

        List<Product> _products = new List<Product>();

        public Invoice()
        {
        }
        public void AddProduct(Product product1)
        {
            _products.Add(product1);
        }
        public decimal ValueToPay()
        {
            decimal total = 0;
            foreach (Product prod in _products)
            {
                total += prod.ValueToPay();
            }
            return total;
        }
        public override string ToString()
        {

            string payroll = "";
            foreach (Product prod in _products)
            {

                payroll += prod.ToString() + "\n";
            }

            return $"{payroll}                 ================\n" +
                $"TOTAL:         {$"{ValueToPay():C2}",18}";
        }

    }
}
