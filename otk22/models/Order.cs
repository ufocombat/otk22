using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otk22.models
{
    internal class Order
    {
        public Int32 id;
        public String? userLogin;
        public String? status;
        public Int32 serviceId;
        public Decimal discountPercent;

        public Decimal price = 0; // Цена услуги
        public Decimal amount = 0; // Сумма заказа
        public Decimal discountAmount = 0; // Сумма скидки
        public Decimal totalAmount = 0; // Итоговая сумма заказа

        public void calcTotalAmount()
        {
            amount = price;
            discountAmount = amount * discountPercent / 100;
            totalAmount = amount - discountAmount;
        }
    }
}