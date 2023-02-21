namespace WareHouse;

class Shop {
    public string Name { get;set; }
    public List<Stock> Stocks{get;set;}
    public Shop(string name,List<Stock> stocks){
        Name=name;
        Stocks=stocks;
    }
    public void AddStock(Item item, int quantity)
    {
        if (quantity <= 0)
        {
            throw new ArgumentOutOfRangeException($"quantity {quantity} Sorry this quantity is invalid.");
        }

        foreach(Stock stock in Stocks){
            if(stock.Item==item){
                stock.Quantity+=quantity;
                return;
            }
            
        }
        Stocks.Add(new Stock(item,quantity));
    }

    
        
    }
