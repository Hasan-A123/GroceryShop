
namespace GroceryShop
{
    [Serializable]
    public class Item
    {
        private int id;
        private string name;
        private decimal price;
        private int quantity;

        public Item(int id,string name, decimal price, int quantity)
        {
            this.id = id;
            this.Price = price;
            this.Quantity = quantity;
            this.Name = name;
        }

        public int Id
        {
            get => id; 
        
               
            
        }
        public decimal Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public decimal totalPrice() { 
            return Price * Quantity; 
        }

        public override string? ToString()
        {
            return Id + " " + Name + " " + Price + " " + Quantity;
        }
    }
}
