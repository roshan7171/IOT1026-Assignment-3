namespace Assignment
{
    public class Pack
    {
        private readonly InventoryItem[] _items;
        private readonly int _maxCount;
        private readonly float _maxVolume;
        private readonly float _maxWeight;
        private int _currentCount;
        private float _currentVolume;
        private float _currentWeight;

        public Pack() : this(10, 20, 30) { }

        public Pack(int maxCount, float maxVolume, float maxWeight)
        {
            _items = new InventoryItem[maxCount];
            _maxCount = maxCount;
            _maxVolume = maxVolume;
            _maxWeight = maxWeight;
        }

        public int GetMaxCount()
        {
            return _maxCount;
        }

        public float GetVolume()
        {
            return _currentVolume;
        }

        public bool Add(InventoryItem item)
        {
            float weight = item.GetWeight();
            float volume = item.GetVolume();
            
           
            if (_currentCount < _maxCount && _currentWeight + weight <= _maxWeight && _currentVolume + volume <= _maxVolume)
            {
                _currentWeight += weight;
                _currentVolume += volume;
                _items[_currentCount++] = item;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            string packContents = "";
            for (int i = 0; i < _currentCount; i++)
            {
                packContents += _items[i].Display() + "\n";
            }
            return packContents;
        }
    }

    public abstract class InventoryItem
    {
        private readonly float _volume;
        private readonly float _weight;

        protected InventoryItem(float volume, float weight)
        {
            if (volume <= 0f || weight <= 0f)
            {
                throw new ArgumentOutOfRangeException($"An item can't have {volume} volume or {weight} weight");
            }
            _volume = volume;
            _weight = weight;
        }

        public abstract string Display();

        public float GetVolume()
        {
            return _volume;
        }

        public float GetWeight()
        {
            return _weight;
        }
    }

    public class Arrow : InventoryItem
    {
        public Arrow() : base(0.5f, 0.1f) { }

        public override string Display()
        {
            return $"An arrow with weight {GetWeight()} and volume {GetVolume()}";
        }
    }

    public class Bow : InventoryItem
    {
        public Bow() : base(1f, 4f) { }

        public override string Display()
        {
            return $"A bow with weight {GetWeight()} and volume {GetVolume()}";
        }
    }

    public class Rope : InventoryItem
    {
        public Rope() : base(1f, 1.5f) { }

        public override string Display()
        {
            return $"A rope with weight {GetWeight()} and volume {GetVolume()}";
        }
    }

    public class Water : InventoryItem
    {
        public Water() : base(2f, 3f) { }

        public override string Display()
        {
            return $"Water with weight {GetWeight()} and volume {GetVolume()}";
        }
    }

    public class Food : InventoryItem
    {
        public Food() : base(1f, 0.5f) { }

        public override string Display()
        {
            return $"Yummy food with weight {GetWeight()} and volume {GetVolume()}";
        }
    }

    public class Sword : InventoryItem
    {
        public Sword() : base(5f, 3f) { }

        public override string Display()
        {
            return $"A sharp sword with weight {GetWeight()} and volume {GetVolume()}";
        }
    }
}
