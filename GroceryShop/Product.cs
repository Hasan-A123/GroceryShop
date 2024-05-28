
namespace GroceryShop
{
    [Serializable]
    public class Product
    {
        private string name;
        private string description;
        private decimal price;
        private decimal stock;
        private int id;

        public Product(int id,string name, string description, decimal price, decimal stock)
        {
            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.Stock = stock;
            this.id = id;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (value !="")
                name = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                if(value !="")
                description = value;
            }
        }

        public decimal Price
        {
            get
            {
                return price;
            }

            set
            {
                if(value>=0)
                price = value;
            }
        }

        public decimal Stock
        {
            get
            {
                return stock;
            }

            set
            {
                if(value>=0)
                stock = value;
            }
        }

        public int Id
        {
            get => id; 
            
           
        }

        public override string? ToString()
        {
            return Id + " " + Name + " " + Price;
        }
    }
}
