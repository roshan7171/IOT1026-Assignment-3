namespace Assignment;

public class Pack
{
    private InventoryItem[] _items; // You can use another data structure here if you prefer.
    // You may need another private member variable if you use an array data structure.

    private int _maxCount;
    private float _maxVolume;
    private float _maxWeight;

    // Default constructor sets the maxCount to 10 
    // maxVolume to 20 
    // maxWeight to 30
    public Pack() :this(10, 20, 30) {}

    // This constructor is not complete, but it is a good start.
    public Pack(int maxCount, float maxVolume, float maxWeight)
    {
        _maxCount = maxCount;
        _maxVolume = maxVolume;
        _maxWeight = maxWeight;
        _items[0] = new Sword(); // This generates  NullReferenceException
    }

    // This is called a getter
    public int GetMaxCount()
    {
        return _maxCount;
    }

    public bool Add(InventoryItem item)
    {
        throw new NotImplementedException();
    }

    // Implement this class
    public override string ToString()
    {
        throw new NotImplementedException();
    }
}

public class InventoryItem
{
    // Implement this class
}

// Implement these classes - each inherits from InventoryItem
// 1 line of code each - call base class constructor with appropriate arguments
class Arrow : InventoryItem { }
class Bow : InventoryItem { }
class Rope : InventoryItem { }
class Water : InventoryItem { }
class Food : InventoryItem { }
class Sword : InventoryItem { }
