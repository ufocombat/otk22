using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using otk22.db;
using otk22.models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

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
            statusComboBox.DataSource = MyDb.getStatuses();

           
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
                 order.status = (String)statusComboBox.SelectedValue;

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

                funcButton.Visible= false;
                saveButton.Location = new Point(255,22);

                order.discountPercent = 0;
                order.userLogin = (String)userComboBox.SelectedValue;
                order.serviceId = Convert.ToInt32(serviceComboBox.SelectedValue);
                order.status = "Новый";
            }
            else
            {
                orderIdLabel.Text = $"Заказ Но. {order.id}";
                saveButton.Text = "Сохранить";

                order = MyDb.getOrderViewById(order.id);

                userComboBox.SelectedValue = order.userLogin;
                serviceComboBox.SelectedValue = order.serviceId;
                statusComboBox.SelectedValue = order.status;
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

        private void funcButton_Click(object sender, EventArgs e)
        {
            funcContextMenuStrip.Show(buttonPanel, new Point(funcButton.Location.X, funcButton.Location.Y-50));
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Удалить заказ {order.id}?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                  == System.Windows.Forms.DialogResult.Yes)
            {
                MyDb.deleteOrderById(order.id);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Архтвировать заказ {order.id}?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                  == System.Windows.Forms.DialogResult.Yes)
            {
                MyDb.archOrderById(order.id);
                this.DialogResult = DialogResult.OK;
            }
        
        }

        private void linkLabel1_MouseClick(object sender, MouseEventArgs e)
        {
            SearchServiceForm serviceForm = new SearchServiceForm();

            if (serviceForm.ShowDialog(this) == DialogResult.OK)
            {
                serviceComboBox.SelectedValue = serviceForm.serviceId;
            }

            serviceForm.Dispose();
        }

        private void userComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelAdress.Text = $"Адрес доставки: {MyDb.getUserAddress((String)userComboBox.SelectedValue)}";
        }

        private void funcContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {

        }

        private void экспортToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var filePath = openFileDialog.FileName;

                if (File.Exists(filePath))
                {
                    MessageBox.Show($"Файл существует", "Внимание");
                }
                else
                {

                    OrderExport orderExort = new OrderExport()
                    {
                        order = order,
                        user = MyDb.getUser(order.userLogin),
                        service = MyDb.getServiceById(order.serviceId),
                        admin = user
                    };

                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        writer.WriteLine(JsonSerializer.Serialize(orderExort));
                    }

                    MessageBox.Show($"Заказ экспортирован в {filePath}");
                }
            }

            // Read a file
            //string readText = File.ReadAllText(fullPath);
        }
    }
}

