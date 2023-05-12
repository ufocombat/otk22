namespace otk22
{
    partial class OrderForm
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
            this.components = new System.ComponentModel.Container();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.funcButton = new System.Windows.Forms.Button();
            this.funcContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.orderGroupBox = new System.Windows.Forms.GroupBox();
            this.labelAdress = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.statusLabel = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.serviceLabelError = new System.Windows.Forms.Label();
            this.userComboBox = new System.Windows.Forms.ComboBox();
            this.errorNameLabel = new System.Windows.Forms.Label();
            this.serviceLabel = new System.Windows.Forms.Label();
            this.serviceComboBox = new System.Windows.Forms.ComboBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.orderIdLabel = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.amountGroupBox = new System.Windows.Forms.GroupBox();
            this.discountUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.discountAmountTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.totalAmountTextBox = new System.Windows.Forms.TextBox();
            this.DiscountLabel = new System.Windows.Forms.Label();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.экспортToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonPanel.SuspendLayout();
            this.funcContextMenuStrip.SuspendLayout();
            this.orderGroupBox.SuspendLayout();
            this.amountGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.discountUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPanel
            // 
            this.buttonPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(131)))), ((int)(((byte)(204)))));
            this.buttonPanel.Controls.Add(this.funcButton);
            this.buttonPanel.Controls.Add(this.cancelButton);
            this.buttonPanel.Controls.Add(this.saveButton);
            this.buttonPanel.Location = new System.Drawing.Point(-1, 512);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(424, 68);
            this.buttonPanel.TabIndex = 1;
            // 
            // funcButton
            // 
            this.funcButton.ContextMenuStrip = this.funcContextMenuStrip;
            this.funcButton.Location = new System.Drawing.Point(240, 22);
            this.funcButton.Name = "funcButton";
            this.funcButton.Size = new System.Drawing.Size(90, 28);
            this.funcButton.TabIndex = 6;
            this.funcButton.Text = "&Функции ▲";
            this.funcButton.UseVisualStyleBackColor = true;
            this.funcButton.Click += new System.EventHandler(this.funcButton_Click);
            // 
            // funcContextMenuStrip
            // 
            this.funcContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.экспортToolStripMenuItem,
            this.toolStripMenuItem1,
            this.удалитьToolStripMenuItem});
            this.funcContextMenuStrip.Name = "contextMenuStrip1";
            this.funcContextMenuStrip.Size = new System.Drawing.Size(181, 92);
            this.funcContextMenuStrip.Text = "Удалить";
            this.funcContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.funcContextMenuStrip_Opening);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "Архивировать";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(336, 22);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 28);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "О&тмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveButton.Location = new System.Drawing.Point(159, 22);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 28);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "&Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // orderGroupBox
            // 
            this.orderGroupBox.Controls.Add(this.labelAdress);
            this.orderGroupBox.Controls.Add(this.linkLabel1);
            this.orderGroupBox.Controls.Add(this.statusLabel);
            this.orderGroupBox.Controls.Add(this.statusComboBox);
            this.orderGroupBox.Controls.Add(this.serviceLabelError);
            this.orderGroupBox.Controls.Add(this.userComboBox);
            this.orderGroupBox.Controls.Add(this.errorNameLabel);
            this.orderGroupBox.Controls.Add(this.serviceLabel);
            this.orderGroupBox.Controls.Add(this.serviceComboBox);
            this.orderGroupBox.Controls.Add(this.nameLabel);
            this.orderGroupBox.Controls.Add(this.orderIdLabel);
            this.orderGroupBox.Location = new System.Drawing.Point(12, 12);
            this.orderGroupBox.Name = "orderGroupBox";
            this.orderGroupBox.Size = new System.Drawing.Size(400, 298);
            this.orderGroupBox.TabIndex = 2;
            this.orderGroupBox.TabStop = false;
            this.orderGroupBox.Text = "Общее";
            // 
            // labelAdress
            // 
            this.labelAdress.AutoSize = true;
            this.labelAdress.Location = new System.Drawing.Point(27, 263);
            this.labelAdress.Name = "labelAdress";
            this.labelAdress.Size = new System.Drawing.Size(92, 15);
            this.labelAdress.TabIndex = 30;
            this.labelAdress.Text = "Адрес доставки";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(315, 158);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(51, 15);
            this.linkLabel1.TabIndex = 29;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Поиск...";
            this.linkLabel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.linkLabel1_MouseClick);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(27, 207);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(43, 15);
            this.statusLabel.TabIndex = 28;
            this.statusLabel.Text = "Статус";
            // 
            // statusComboBox
            // 
            this.statusComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.statusComboBox.DisplayMember = "description";
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(26, 225);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(349, 23);
            this.statusComboBox.TabIndex = 27;
            this.statusComboBox.UseWaitCursor = true;
            this.statusComboBox.ValueMember = "status";
            // 
            // serviceLabelError
            // 
            this.serviceLabelError.AutoSize = true;
            this.serviceLabelError.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.serviceLabelError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(44)))), ((int)(((byte)(31)))));
            this.serviceLabelError.Location = new System.Drawing.Point(26, 181);
            this.serviceLabelError.Name = "serviceLabelError";
            this.serviceLabelError.Size = new System.Drawing.Size(85, 13);
            this.serviceLabelError.TabIndex = 26;
            this.serviceLabelError.Text = "ошибка услуги";
            this.serviceLabelError.Visible = false;
            // 
            // userComboBox
            // 
            this.userComboBox.DisplayMember = "name";
            this.userComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userComboBox.FormattingEnabled = true;
            this.userComboBox.Location = new System.Drawing.Point(26, 89);
            this.userComboBox.Name = "userComboBox";
            this.userComboBox.Size = new System.Drawing.Size(349, 23);
            this.userComboBox.TabIndex = 0;
            this.userComboBox.ValueMember = "login";
            this.userComboBox.SelectedIndexChanged += new System.EventHandler(this.userComboBox_SelectedIndexChanged);
            // 
            // errorNameLabel
            // 
            this.errorNameLabel.AutoSize = true;
            this.errorNameLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.errorNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(44)))), ((int)(((byte)(31)))));
            this.errorNameLabel.Location = new System.Drawing.Point(26, 115);
            this.errorNameLabel.Name = "errorNameLabel";
            this.errorNameLabel.Size = new System.Drawing.Size(76, 13);
            this.errorNameLabel.TabIndex = 24;
            this.errorNameLabel.Text = "ошибка ФИО";
            this.errorNameLabel.Visible = false;
            // 
            // serviceLabel
            // 
            this.serviceLabel.AutoSize = true;
            this.serviceLabel.Location = new System.Drawing.Point(26, 137);
            this.serviceLabel.Name = "serviceLabel";
            this.serviceLabel.Size = new System.Drawing.Size(44, 15);
            this.serviceLabel.TabIndex = 17;
            this.serviceLabel.Text = "Услуга";
            // 
            // serviceComboBox
            // 
            this.serviceComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.serviceComboBox.DisplayMember = "name";
            this.serviceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serviceComboBox.FormattingEnabled = true;
            this.serviceComboBox.Location = new System.Drawing.Point(26, 155);
            this.serviceComboBox.Name = "serviceComboBox";
            this.serviceComboBox.Size = new System.Drawing.Size(283, 23);
            this.serviceComboBox.TabIndex = 1;
            this.serviceComboBox.ValueMember = "id";
            this.serviceComboBox.SelectedIndexChanged += new System.EventHandler(this.serviceComboBox_SelectedIndexChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(26, 71);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(87, 15);
            this.nameLabel.TabIndex = 12;
            this.nameLabel.Text = "Фио заказчика";
            // 
            // orderIdLabel
            // 
            this.orderIdLabel.AutoSize = true;
            this.orderIdLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.orderIdLabel.Location = new System.Drawing.Point(26, 30);
            this.orderIdLabel.Name = "orderIdLabel";
            this.orderIdLabel.Size = new System.Drawing.Size(100, 21);
            this.orderIdLabel.TabIndex = 11;
            this.orderIdLabel.Text = "Новый заказ";
            // 
            // amountTextBox
            // 
            this.amountTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.amountTextBox.Enabled = false;
            this.amountTextBox.Location = new System.Drawing.Point(233, 58);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(142, 23);
            this.amountTextBox.TabIndex = 23;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(231, 40);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(138, 15);
            this.priceLabel.TabIndex = 22;
            this.priceLabel.Text = "Стоимость услуги (руб)";
            // 
            // amountGroupBox
            // 
            this.amountGroupBox.Controls.Add(this.discountUpDown);
            this.amountGroupBox.Controls.Add(this.label2);
            this.amountGroupBox.Controls.Add(this.discountAmountTextBox);
            this.amountGroupBox.Controls.Add(this.label1);
            this.amountGroupBox.Controls.Add(this.totalAmountTextBox);
            this.amountGroupBox.Controls.Add(this.amountTextBox);
            this.amountGroupBox.Controls.Add(this.priceLabel);
            this.amountGroupBox.Controls.Add(this.DiscountLabel);
            this.amountGroupBox.Location = new System.Drawing.Point(12, 316);
            this.amountGroupBox.Name = "amountGroupBox";
            this.amountGroupBox.Size = new System.Drawing.Size(400, 173);
            this.amountGroupBox.TabIndex = 3;
            this.amountGroupBox.TabStop = false;
            this.amountGroupBox.Text = "Стоимость";
            // 
            // discountUpDown
            // 
            this.discountUpDown.Location = new System.Drawing.Point(26, 58);
            this.discountUpDown.Name = "discountUpDown";
            this.discountUpDown.Size = new System.Drawing.Size(142, 23);
            this.discountUpDown.TabIndex = 2;
            this.discountUpDown.ValueChanged += new System.EventHandler(this.discountUpDown_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 15);
            this.label2.TabIndex = 27;
            this.label2.Text = "Сумма скидки (руб)";
            // 
            // discountAmountTextBox
            // 
            this.discountAmountTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.discountAmountTextBox.Enabled = false;
            this.discountAmountTextBox.Location = new System.Drawing.Point(26, 118);
            this.discountAmountTextBox.Name = "discountAmountTextBox";
            this.discountAmountTextBox.Size = new System.Drawing.Size(142, 23);
            this.discountAmountTextBox.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = "Итого (руб)";
            // 
            // totalAmountTextBox
            // 
            this.totalAmountTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.totalAmountTextBox.Enabled = false;
            this.totalAmountTextBox.Location = new System.Drawing.Point(233, 118);
            this.totalAmountTextBox.Name = "totalAmountTextBox";
            this.totalAmountTextBox.Size = new System.Drawing.Size(142, 23);
            this.totalAmountTextBox.TabIndex = 24;
            // 
            // DiscountLabel
            // 
            this.DiscountLabel.AutoSize = true;
            this.DiscountLabel.Location = new System.Drawing.Point(23, 40);
            this.DiscountLabel.Name = "DiscountLabel";
            this.DiscountLabel.Size = new System.Drawing.Size(67, 15);
            this.DiscountLabel.TabIndex = 21;
            this.DiscountLabel.Text = "Скидка (%)";
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // экспортToolStripMenuItem
            // 
            this.экспортToolStripMenuItem.Name = "экспортToolStripMenuItem";
            this.экспортToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.экспортToolStripMenuItem.Text = "Экспорт";
            this.экспортToolStripMenuItem.Click += new System.EventHandler(this.экспортToolStripMenuItem_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(422, 581);
            this.Controls.Add(this.amountGroupBox);
            this.Controls.Add(this.orderGroupBox);
            this.Controls.Add(this.buttonPanel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(438, 620);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(438, 620);
            this.Name = "OrderForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Форма заказа";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.buttonPanel.ResumeLayout(false);
            this.funcContextMenuStrip.ResumeLayout(false);
            this.orderGroupBox.ResumeLayout(false);
            this.orderGroupBox.PerformLayout();
            this.amountGroupBox.ResumeLayout(false);
            this.amountGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.discountUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel buttonPanel;
        private Button cancelButton;
        private Button saveButton;
        private GroupBox orderGroupBox;
        private Label serviceLabel;
        private ComboBox serviceComboBox;
        private Label nameLabel;
        private Label orderIdLabel;
        private GroupBox amountGroupBox;
        private Label label1;
        private TextBox totalAmountTextBox;
        private TextBox amountTextBox;
        private Label priceLabel;
        private Label DiscountLabel;
        private Label label2;
        private TextBox discountAmountTextBox;
        private Label errorNameLabel;
        private ComboBox userComboBox;
        private Label serviceLabelError;
        private NumericUpDown discountUpDown;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Button funcButton;
        private ContextMenuStrip funcContextMenuStrip;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private Label statusLabel;
        private ComboBox statusComboBox;
        private LinkLabel linkLabel1;
        private Label labelAdress;
        private ToolStripMenuItem экспортToolStripMenuItem;
    }
}