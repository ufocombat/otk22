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
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.orderGroupBox = new System.Windows.Forms.GroupBox();
            this.serviceLabelError = new System.Windows.Forms.Label();
            this.userComboBox = new System.Windows.Forms.ComboBox();
            this.errorNameLabel = new System.Windows.Forms.Label();
            this.serviceLabel = new System.Windows.Forms.Label();
            this.serviceComboBox = new System.Windows.Forms.ComboBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.orderIdLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.amountGroupBox = new System.Windows.Forms.GroupBox();
            this.discountUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.DiscountLabel = new System.Windows.Forms.Label();
            this.buttonPanel.SuspendLayout();
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
            this.buttonPanel.Controls.Add(this.cancelButton);
            this.buttonPanel.Controls.Add(this.saveButton);
            this.buttonPanel.Location = new System.Drawing.Point(-1, 442);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(424, 68);
            this.buttonPanel.TabIndex = 1;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(303, 22);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 28);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveButton.Location = new System.Drawing.Point(212, 22);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 28);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // orderGroupBox
            // 
            this.orderGroupBox.Controls.Add(this.serviceLabelError);
            this.orderGroupBox.Controls.Add(this.userComboBox);
            this.orderGroupBox.Controls.Add(this.errorNameLabel);
            this.orderGroupBox.Controls.Add(this.serviceLabel);
            this.orderGroupBox.Controls.Add(this.serviceComboBox);
            this.orderGroupBox.Controls.Add(this.nameLabel);
            this.orderGroupBox.Controls.Add(this.orderIdLabel);
            this.orderGroupBox.Location = new System.Drawing.Point(12, 12);
            this.orderGroupBox.Name = "orderGroupBox";
            this.orderGroupBox.Size = new System.Drawing.Size(400, 210);
            this.orderGroupBox.TabIndex = 2;
            this.orderGroupBox.TabStop = false;
            this.orderGroupBox.Text = "Общее";
            // 
            // serviceLabelError
            // 
            this.serviceLabelError.AutoSize = true;
            this.serviceLabelError.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.serviceLabelError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(44)))), ((int)(((byte)(31)))));
            this.serviceLabelError.Location = new System.Drawing.Point(26, 180);
            this.serviceLabelError.Name = "serviceLabelError";
            this.serviceLabelError.Size = new System.Drawing.Size(85, 13);
            this.serviceLabelError.TabIndex = 26;
            this.serviceLabelError.Text = "ошибка услуги";
            this.serviceLabelError.Visible = false;
            // 
            // userComboBox
            // 
            this.userComboBox.FormattingEnabled = true;
            this.userComboBox.Location = new System.Drawing.Point(26, 89);
            this.userComboBox.Name = "userComboBox";
            this.userComboBox.Size = new System.Drawing.Size(349, 23);
            this.userComboBox.TabIndex = 25;
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
            this.serviceLabel.Location = new System.Drawing.Point(26, 136);
            this.serviceLabel.Name = "serviceLabel";
            this.serviceLabel.Size = new System.Drawing.Size(44, 15);
            this.serviceLabel.TabIndex = 17;
            this.serviceLabel.Text = "Услуга";
            // 
            // serviceComboBox
            // 
            this.serviceComboBox.FormattingEnabled = true;
            this.serviceComboBox.Location = new System.Drawing.Point(26, 154);
            this.serviceComboBox.Name = "serviceComboBox";
            this.serviceComboBox.Size = new System.Drawing.Size(349, 23);
            this.serviceComboBox.TabIndex = 16;
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
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(233, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(142, 23);
            this.textBox2.TabIndex = 23;
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
            this.amountGroupBox.Controls.Add(this.textBox4);
            this.amountGroupBox.Controls.Add(this.label1);
            this.amountGroupBox.Controls.Add(this.textBox3);
            this.amountGroupBox.Controls.Add(this.textBox2);
            this.amountGroupBox.Controls.Add(this.priceLabel);
            this.amountGroupBox.Controls.Add(this.DiscountLabel);
            this.amountGroupBox.Location = new System.Drawing.Point(12, 244);
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
            this.discountUpDown.TabIndex = 28;
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
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(26, 118);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(142, 23);
            this.textBox4.TabIndex = 26;
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
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(233, 118);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(142, 23);
            this.textBox3.TabIndex = 24;
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
            // OrderForm
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(422, 511);
            this.Controls.Add(this.amountGroupBox);
            this.Controls.Add(this.orderGroupBox);
            this.Controls.Add(this.buttonPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форма заказа";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.buttonPanel.ResumeLayout(false);
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
        private TextBox textBox3;
        private TextBox textBox2;
        private Label priceLabel;
        private Label DiscountLabel;
        private Label label2;
        private TextBox textBox4;
        private Label errorNameLabel;
        private ComboBox userComboBox;
        private Label serviceLabelError;
        private NumericUpDown discountUpDown;
    }
}