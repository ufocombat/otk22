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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace otk22
{
    public partial class OrderForm : Form
    {
        private Order order = new Order();
        private User user;

        public OrderForm(User user, Int32 id = 0)
        {
            InitializeComponent();

            this.order.id = id;
            this.user = user;

            userComboBox.DataSource = MyDb.getUsers();
            serviceComboBox.DataSource = MyDb.getServices();
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

                if (order.id == 0)
                {
                    MyDb.insertOrder(order);
                }
                else
                {
                    MyDb.updateOrder(order);
                }
            }
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            if (order.id == 0)
            {
                orderIdLabel.Text = "Новый заказ";
                saveButton.Text = "Создать";

                order.discountPercent = 0;
                order.userLogin = (String)userComboBox.SelectedValue;//?
                order.serviceId = Convert.ToInt32(serviceComboBox.SelectedValue);
            }
            else
            {
                orderIdLabel.Text = $"Заказ Но. {order.id}";
                saveButton.Text = "Сохранить";

                order = MyDb.getOrderViewById(order.id);

                userComboBox.SelectedValue = order.userLogin;
                serviceComboBox.SelectedValue = order.serviceId;
            }

            Service s = MyDb.getServiceById(order.serviceId);

            order.price = s.price;
            order.calcTotalAmount();

            discountUpDown.Value = order.discountPercent;
            amountTextBox.Text = order.amount.ToString();
            discountAmountTextBox.Text = order.discountAmount.ToString();
            totalAmountTextBox.Text = order.totalAmount.ToString();

            userComboBox.Focus();
        }

        private void refreshForm()
        {
            amountTextBox.Text = order.amount.ToString();
            discountAmountTextBox.Text = order.discountAmount.ToString();
            totalAmountTextBox.Text = order.totalAmount.ToString();
        }

        private void discountUpDown_ValueChanged(object sender, EventArgs e)
        {
            order.discountPercent = discountUpDown.Value;
            order.calcTotalAmount();

            refreshForm();
        }

        private void serviceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            order.serviceId = Convert.ToInt32(serviceComboBox.SelectedValue);

            Service s = MyDb.getServiceById(order.serviceId);

            order.price = s.price;
            order.calcTotalAmount();

            refreshForm();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            MyDb.deleteOrderById(order.id);
        }
    }
}

