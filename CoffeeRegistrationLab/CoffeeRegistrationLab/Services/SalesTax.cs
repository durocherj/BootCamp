using CoffeeRegistrationLab.Services.Interfaces;

namespace CoffeeRegistrationLab.Services
{
    public class SalesTax : ISalesTax
    {
        public decimal ApplySalesTax(decimal price)
        {
            decimal total = price * 1.06m;
            return total;
        }
    }
}
