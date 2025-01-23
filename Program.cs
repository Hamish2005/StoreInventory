namespace SE2250_Lab2;

class Program
{
    static void Main()
    {
        string[,] inventory = {
            {"Laptop", "10", "800"},
            {"Phone", "25", "500"},
            {"Tablet", "15", "300"}
        };
        Console.Write("Enter item name to search: ");
        string item = Console.ReadLine();
        for (int i = 0; i < inventory.GetLength(0); i++)
        {
            if (item == inventory[i, 0])
            {
                Console.WriteLine($"Item Found: {item} | Quantity: {inventory[i,1]}| Price: {inventory[i,2]}");
            }
        }

        
        
        
        
        
    }
}