using System;
using System.Collections.Generic;
using System.Text;

namespace incident
{
    public delegate void PriceChangedHandle(decimal oldPrice,decimal newPrice);
   
    class Stock
    {
        string symbol;
        decimal price;
        public Stock(string symbol) { this.symbol = symbol; }
        public event PriceChangedHandle PriceChange;
        public decimal Price
        {
            get { return price; }
            set
            {
                if (price == value) return;
                decimal oldPrice = price;
                price = value;
                if (PriceChange != null)
                    PriceChange(oldPrice, price);
            }
        }
    }
    
}
