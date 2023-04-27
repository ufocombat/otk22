using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using otk22.db;
using otk22.models;

namespace otk22
{
    public partial class OrderForm : Form
    {
        private Order order;

        public OrderForm(User user, Int32 id=0)
        {
            InitializeComponent();

            if (id == 0) {
                order = new Order() { 
                    userLogin = user.login,
                    discountPercent = 0,
                    serviceId = 0
                };

            }
            else { 
                order = MyDb.getOrderViewById(id); 
            }

            userComboBox.DataSource = MyDb.getUsers();
            serviceComboBox.DataSource = MyDb.getServices();

            order.userLogin = (String)userComboBox.SelectedValue;
            order.serviceId = Convert.ToInt32(serviceComboBox.SelectedValue);

            Service s = MyDb.getServiceById(order.serviceId);
            order.price= s.price;

            order.calcTotalAmount();
        }

        private Boolean orderValidation()
        {
            int errors = 0;

            if (userComboBox.Text.Length <= 0)
            {
                errorNameLabel.Text = "Заполните ФИО клиента";
                errorNameLabel.Visible = true;

                errors++;
            }
            else
            {
                errorNameLabel.Visible = false;
            }

            if (serviceComboBox.Text.Length<= 0)
            {
                serviceLabelError.Text = "Выбирите услугу";
                serviceLabelError.Visible = true;

                errors++;
            }
            else
            {
                serviceLabelError.Visible = false;
            }

            return errors <= 0;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (orderValidation())
            {
                order.userLogin = (String)userComboBox.SelectedValue;
                order.serviceId = Convert.ToInt32(serviceComboBox.SelectedValue);
                order.discountPercent = discountUpDown.Value;

                MyDb.insertOrder(order);
            }
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            discountUpDown.Value = order.discountPercent;
            amountTextBox.Text = order.amount.ToString();
            discountAmountTextBox.Text = order.discountAmount.ToString();
            totalAmountTextBox.Text = order.totalAmount.ToString();
        }

        private void discountUpDown_ValueChanged(object sender, EventArgs e)
        {
            order.discountPercent = discountUpDown.Value;
            order.calcTotalAmount();

            amountTextBox.Text = order.amount.ToString();
            discountAmountTextBox.Text = order.discountAmount.ToString();
            totalAmountTextBox.Text = order.totalAmount.ToString();
        }
    }
}
