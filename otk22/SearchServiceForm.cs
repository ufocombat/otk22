using otk22.db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otk22
{
    public partial class SearchServiceForm : Form
    {
        public Int32 serviceId = -1;

        public SearchServiceForm()
        {
            InitializeComponent();
            serviceDataGridView.DataSource = MyDb.getAllServices();
        }

        private void serviceChanged(object sender, EventArgs e)
        {
           serviceDataGridView.DataSource = MyDb.getServicesFilter(nameTextBox.Text, priceFromNumericUpDown.Value, priceToNumericUpDown.Value);
        }

        private void serviceDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                serviceId = Convert.ToInt32(serviceDataGridView.Rows[e.RowIndex].Cells[0].Value);
            }
            catch
            {

            }
            selectButton.Enabled= serviceId>0;
        }

        private void serviceDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
