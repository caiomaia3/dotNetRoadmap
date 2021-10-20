using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace OrderSystem.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
            
        public Client Client { get; set; }

        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {

        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double sum = 0;
            foreach (OrderItem i in Items)
            {
                sum += i.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\nORDER SUMMARY:");

            sb.Append("Order moment: ");
            sb.Append(Moment);
            sb.AppendLine("");

            sb.Append("Order status: ");
            sb.Append(Status);
            sb.AppendLine("");

            sb.Append(Client.Name);
            sb.Append("(");
            sb.Append(Client.Date.ToShortDateString());
            sb.Append(") - ");
            sb.AppendLine(Client.Email);
            sb.AppendLine("Order items: ");
            foreach (OrderItem i in Items)
            {
                sb.Append(i.Product.Name);
                sb.Append(", $");
                sb.Append(i.Price.ToString("F2",CultureInfo.InvariantCulture));
                sb.Append(", Quantity: ");
                sb.Append(i.Quantity);
                sb.Append(", Subtotal: $");
                sb.AppendLine(i.SubTotal().ToString("F2", CultureInfo.InvariantCulture));
            }
            sb.Append("Total price: $");
            sb.AppendLine(this.Total().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();

//Alex Green(15 / 03 / 1985) -alex@gmail.com
//  Order items:
 //           TV, $1000.00, Quantity: 1, Subtotal: $1000.00
//Mouse, $40.00, Quantity: 2, Subtotal: $80.00
//Total price: $1080.00"
        }
    }
}
