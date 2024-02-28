
string command = "";

List<Box> orderedBoxes = new();

while ((command = Console.ReadLine()) != "end")
{
    string[] products = command.Split();
    int serialNumber = int.Parse(products[0]);
    string itemName = products[1];
    int quantity = int.Parse(products[2]);
    decimal itemPrice = decimal.Parse(products[3]);

    Item newItem = new Item()
    {
        Name = itemName,
        Price = itemPrice,
    };

    Box product = new Box()
    {
       SerialNumber = serialNumber,
       Item = newItem,
       ItemQuantity = quantity,
    };

    orderedBoxes.Add(product); 

}
 orderedBoxes = orderedBoxes.OrderByDescending(x => x.PriceForABox).ToList();

foreach (var box in orderedBoxes)
{
    Console.WriteLine($"{box.SerialNumber}{Environment.NewLine}-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}{Environment.NewLine}-- ${box.PriceForABox:f2}");
}

public class Item
{
    public string Name { get; set; }

    public decimal Price { get; set; }
}

public class Box
{
    public int SerialNumber { get; set; }

    public Item Item { get; set; }

    public int ItemQuantity { get; set; }

    public decimal PriceForABox => ItemQuantity * Item.Price;
}