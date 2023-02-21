using WareHouse;

List<Stock> myStocks=new List<Stock>();
myStocks.Add(new Stock(new Item("dog",100.99m),5));
myStocks.Add(new Stock(new Item("cat",111.111m),10));

Shop myShop=new Shop("PetShop",myStocks);

Console.WriteLine("PetShop Stocks List:");
foreach(Stock stock in myStocks){
    Console.WriteLine($"\t Pet Type: {stock.Item.Name} \t quantity: {stock.Quantity} \t total price: {stock.Quantity*stock.Item.Price}");
}