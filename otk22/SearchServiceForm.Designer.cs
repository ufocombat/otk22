namespace otk22
{
    partial class SearchServiceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.priceToNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.priceFromNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.serviceDataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.selectButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceToNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceFromNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.priceToNumericUpDown);
            this.panel1.Controls.Add(this.priceFromNumericUpDown);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(593, 77);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Стоимость от";
            // 
            // priceToNumericUpDown
            // 
            this.priceToNumericUpDown.Location = new System.Drawing.Point(450, 40);
            this.priceToNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.priceToNumericUpDown.Name = "priceToNumericUpDown";
            this.priceToNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.priceToNumericUpDown.TabIndex = 8;
            this.priceToNumericUpDown.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.priceToNumericUpDown.ValueChanged += new System.EventHandler(this.serviceChanged);
            // 
            // priceFromNumericUpDown
            // 
            this.priceFromNumericUpDown.Location = new System.Drawing.Point(310, 40);
            this.priceFromNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.priceFromNumericUpDown.Name = "priceFromNumericUpDown";
            this.priceFromNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.priceFromNumericUpDown.TabIndex = 7;
            this.priceFromNumericUpDown.ValueChanged += new System.EventHandler(this.serviceChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(450, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Стоимость до";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название услуги";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(25, 40);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(252, 23);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.TextChanged += new System.EventHandler(this.serviceChanged);
            // 
            // serviceDataGridView
            // 
            this.serviceDataGridView.AllowUserToAddRows = false;
            this.serviceDataGridView.AllowUserToDeleteRows = false;
            this.serviceDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serviceDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(72)))), ((int)(((byte)(141)))));
            this.serviceDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.serviceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serviceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.Price});
            this.serviceDataGridView.Location = new System.Drawing.Point(23, 77);
            this.serviceDataGridView.Name = "serviceDataGridView";
            this.serviceDataGridView.ReadOnly = true;
            this.serviceDataGridView.RowTemplate.Height = 25;
            this.serviceDataGridView.Size = new System.Drawing.Size(545, 403);
            this.serviceDataGridView.TabIndex = 1;
            this.serviceDataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.serviceDataGridView_CellEnter);
            this.serviceDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.serviceDataGridView_CellMouseDoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Услуга";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "price";
            this.Price.HeaderText = "Стоимость";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(131)))), ((int)(((byte)(204)))));
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.selectButton);
            this.panel2.Location = new System.Drawing.Point(1, 509);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(586, 74);
            this.panel2.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(473, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // selectButton
            // 
            this.selectButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.selectButton.Enabled = false;
            this.selectButton.Location = new System.Drawing.Point(366, 23);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(92, 28);
            this.selectButton.TabIndex = 0;
            this.selectButton.Text = "Выбрать";
            this.selectButton.UseVisualStyleBackColor = true;
            // 
            // SearchServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(588, 583);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.serviceDataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "SearchServiceForm";
            this.Text = "Выберите услугу";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceToNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceFromNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox nameTextBox;
        private DataGridView serviceDataGridView;
        private Label label3;
        private Label label2;
        private NumericUpDown priceToNumericUpDown;
        private NumericUpDown priceFromNumericUpDown;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn Price;
        private Panel panel2;
        private Button button2;
        private Button selectButton;
    }
}