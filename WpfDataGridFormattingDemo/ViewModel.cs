using System.Collections.Generic;

namespace Demo
{
    internal class ViewModel
    {
        public List<StockItem> Items { get; set; } = new List<StockItem>();

        public ViewModel()
        {
            Items.AddRange(new List<StockItem>
            {
                new StockItem { Name = "Many items", Quantity = 100, IsObsolete = false },
                new StockItem { Name = "Enough items", Quantity = 10, IsObsolete = false },
                new StockItem { Name = "Shortage item", Quantity = 1, IsObsolete = false },
                new StockItem { Name = "Item with error", Quantity = -1, IsObsolete = false },
                new StockItem { Name = "Obsolete item", Quantity = 200, IsObsolete = true },
            });
        }
    }
}
