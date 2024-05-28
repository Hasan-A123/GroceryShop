using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryShop
{
    [Serializable]
    internal class Order
    {
        private int orderNumber;
        private List<Item> basket;
        private string paymentMethod;
        private decimal totalPrice;
        private decimal amountPaid;
        private decimal change;
        private DateTime dateTimeOfOrder;
        private Boolean hasBeenPaid;

        public Order(int orderNumber, List<Item> basket,string paymentMethod, decimal totalPrice, decimal amountPaid, decimal change, DateTime dateTimeOfOrder, bool hasBeenPaid)
        {
            this.OrderNumber = orderNumber;
            this.Basket = basket;
            this.PaymentMethod = paymentMethod;
            this.TotalPrice = totalPrice;
            this.AmountPaid = amountPaid;
            this.Change = change;
            this.DateTimeOfOrder = dateTimeOfOrder;
            this.HasBeenPaid = hasBeenPaid;
        }

        public int OrderNumber
        {
            get
            {
                return orderNumber;
            }

            set
            {
                orderNumber = value;
            }
        }

      

        public decimal TotalPrice
        {
            get
            {
                return totalPrice;
            }

            set
            {
                totalPrice = value;
            }
        }

        public decimal AmountPaid
        {
            get
            {
                return amountPaid;
            }

            set
            {
                amountPaid = value;
            }
        }

        public decimal Change
        {
            get
            {
                return change;
            }

            set
            {
                change = value;
            }
        }

        public DateTime DateTimeOfOrder
        {
            get
            {
                return dateTimeOfOrder;
            }

            set
            {
                dateTimeOfOrder = value;
            }
        }

        public bool HasBeenPaid
        {
            get
            {
                return hasBeenPaid;
            }

            set
            {
                hasBeenPaid = value;
            }
        }

        public string PaymentMethod
        {
            get
            {
                return paymentMethod;
            }

            set
            {
                paymentMethod = value;
            }
        }

        internal List<Item> Basket
        {
            get
            {
                return basket;
            }

            set
            {
                basket = value;
            }
        }

        public override string? ToString()
        {
            return orderNumber.ToString() + " " + totalPrice + " " + dateTimeOfOrder.ToString();
        }

        
    }
}
