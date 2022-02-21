namespace Supermarket
{
    internal class VariablePriceProduct : Product
    {
        public string Measurement { get; set; }
        public float Quantity { get; set; }

        public override decimal ValueToPay()
        {
            return ((Price * (decimal)Quantity)) + (decimal)((decimal)(Tax) * (Price * (decimal)Quantity));
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n     Measurement: {$"{Measurement}",15} " +
                $"\n     Quantity...: {$"{Quantity:N2}",15}" +
                $"\n     Value......: {$"{ValueToPay():C2}",15}";
        }
    }
}
