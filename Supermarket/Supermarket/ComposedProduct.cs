namespace Supermarket
{
    public class ComposedProduct : Product
    {
        public float Discount { get; set; }
        public List<Product> Products { get; set; }

        
        public override decimal ValueToPay()
        {

            decimal payroll = 0;
            foreach (Product prod in Products)
            {               
                payroll += prod.ValueToPay() - (prod.ValueToPay() * (decimal)Discount); 
            }

            return payroll;
        }
        public override string ToString()
        {
            string product="";
            foreach (Product prod in Products)
            {
                product+=prod.Description + " ,";
            }

            return $"{Id} {Description}" +
                $"\n     Products...: {product}" +
                $"\n     Discount...: {$"{Discount:P2}",15}" +
                $"\n     Value......: {$"{ValueToPay():C2}",15}";
        }

    }
}
