using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otk22.models
{
    internal class Order
    {
        public Int32 id { get; set; }
        public String? userLogin { get; set; }
        public String? status { get; set; }
        public Int32 serviceId { get; set; }
        public Decimal discountPercent { get; set; }

        public Decimal price { get; set; } = 0;  // Цена услуги
        public Decimal amount { get; set; } = 0;  // Сумма заказа
        public Decimal discountAmount { get; set; } = 0; // Сумма скидки
        public Decimal totalAmount { get; set; } = 0; // Итоговая сумма заказа

        public void calcTotalAmount()
        {
            amount = price;
            discountAmount = amount * discountPercent / 100;
            totalAmount = amount - discountAmount;
        }
    }
}