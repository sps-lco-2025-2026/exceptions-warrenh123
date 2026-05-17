//MAIN PROGRAM
Dictionary<string, int> items = new Dictionary<string, int>
{
    {"sword", 5},
    {"potion", 10}
};
string item = "";

Console.Write("Please enter item to withdraw: ");

//first try block to see if there is a item in inventory and see if there has been a general inventory error
try
{
    item = Console.ReadLine().ToLower();
    if(!items.ContainsKey(item))
    {
        throw new ItemNotFoundException(item);
    }
    else
    {
        Console.Write($"There are {item}s in inventory, please enter number of items to withdraw: ");
    }
}
catch(ItemNotFoundException ex)
{
    Console.WriteLine(ex);
}
catch(InventoryException)
{
    Console.WriteLine("General error ocurred");
}

//second block to see if there are enough requested items in inventory
try
{
    int numberRequested = int.Parse(Console.ReadLine());
    if(numberRequested > items[item])
    {
        throw new InsufficientQuantityException(item);
    }

    items[item] -= numberRequested;
    Console.WriteLine($"Successfully taken {numberRequested} {item}s");
}
catch(FormatException)
{
    Console.WriteLine("Please enter a number");
}
catch(InsufficientQuantityException ex)
{
   Console.WriteLine(ex);
}
catch(InventoryException)
{
    Console.WriteLine("General error ocurred");
}



//CLASSES
public class InventoryException : Exception
{
    public InventoryException(string message) : base(message) { }
}

public class ItemNotFoundException : InventoryException
{
    public ItemNotFoundException(string item): base($"Cannot withdraw there is no {item} in inventory.") { }
}

public class InsufficientQuantityException : InventoryException
{
    public InsufficientQuantityException(string item): base($"There aren't enough {item}s in inventory.") { }
}