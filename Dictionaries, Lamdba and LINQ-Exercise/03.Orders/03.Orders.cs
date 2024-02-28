
string input = "";

Dictionary<string, (double price, int quantity)> productsCatalog = new();

while ((input = Console.ReadLine()) != "buy")
{
	List<string> products = input.Split().ToList();
	string product = products[0];
	double price = double.Parse(products[1]);
	int quantity = int.Parse(products[2]);

	if (productsCatalog.ContainsKey(product))
	{
		productsCatalog[product] = (price, productsCatalog[product].quantity + quantity);
	}
	else
	{
		productsCatalog.Add(product, (price, quantity));
	}
}
foreach (var product in productsCatalog)
{
	double totalPrice = product.Value.price * product.Value.quantity;
	Console.WriteLine($"{product.Key} -> {totalPrice:f2}");
}
