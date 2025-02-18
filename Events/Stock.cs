using Microsoft.VisualBasic;

namespace Events
{

    // Custom event arguments
    public class StockPriceChangedEventArgs : EventArgs
    {
        public int NewPrice { get; set; }
    }

    // Delegate for the stock's price change event
    public delegate void priceChangeEventHandler(object sender, StockPriceChangedEventArgs e);

    class Stock
    {
        internal int Price { get; set; }
        internal string Name { get; set; }
        public event priceChangeEventHandler OnPriceChanged;

        public Stock(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public void ChangePrice(int price)
        {
            if (Price != price)
            {
                Price = price;
                OnPriceChanged?.Invoke(this, new StockPriceChangedEventArgs { NewPrice = price });
            }
        }
    }

    // Investor class subscribes to stock price changes
    class Investor
    {
        public string Name { get; }

        public Investor(string name)
        {
            Name = name;
        }

        public void OnStockPriceChanged(object sender, StockPriceChangedEventArgs e)
        {
            Console.WriteLine($"{Name}: Received notification - New stock price is ₹{e.NewPrice}");
        }
    }
}