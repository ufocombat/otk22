namespace otk22
{
    partial class ClientForm
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
            this.ordersGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientMenuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.разлогинитсяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGridView)).BeginInit();
            this.clientMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ordersGridView
            // 
            this.ordersGridView.AllowUserToAddRows = false;
            this.ordersGridView.AllowUserToDeleteRows = false;
            this.ordersGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ordersGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(72)))), ((int)(((byte)(141)))));
            this.ordersGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ordersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.discountPercent,
            this.name});
            this.ordersGridView.Location = new System.Drawing.Point(0, 26);
            this.ordersGridView.MultiSelect = false;
            this.ordersGridView.Name = "ordersGridView";
            this.ordersGridView.ReadOnly = true;
            this.ordersGridView.RowTemplate.Height = 25;
            this.ordersGridView.RowTemplate.ReadOnly = true;
            this.ordersGridView.ShowEditingIcon = false;
            this.ordersGridView.Size = new System.Drawing.Size(800, 399);
            this.ordersGridView.TabIndex = 2;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Заказ Но";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // discountPercent
            // 
            this.discountPercent.DataPropertyName = "discountPercent";
            this.discountPercent.HeaderText = "Скидка (%)";
            this.discountPercent.Name = "discountPercent";
            this.discountPercent.ReadOnly = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Услуга";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // clientMenuStrip
            // 
            this.clientMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.clientMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.clientMenuStrip.Name = "clientMenuStrip";
            this.clientMenuStrip.Size = new System.Drawing.Size(800, 24);
            this.clientMenuStrip.TabIndex = 3;
            this.clientMenuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.разлогинитсяToolStripMenuItem,
            this.toolStripMenuItem1,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // разлогинитсяToolStripMenuItem
            // 
            this.разлогинитсяToolStripMenuItem.Name = "разлогинитсяToolStripMenuItem";
            this.разлогинитсяToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.разлогинитсяToolStripMenuItem.Text = "Разлогинится";
            this.разлогинитсяToolStripMenuItem.Click += new System.EventHandler(this.разлогинитсяToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ordersGridView);
            this.Controls.Add(this.clientMenuStrip);
            this.MainMenuStrip = this.clientMenuStrip;
            this.Name = "ClientForm";
            this.Text = "ОТК - Список заказов клиента";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordersGridView)).EndInit();
            this.clientMenuStrip.ResumeLayout(false);
            this.clientMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView ordersGridView;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn discountPercent;
        private DataGridViewTextBoxColumn name;
        private MenuStrip clientMenuStrip;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem разлогинитсяToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem выходToolStripMenuItem;
    }
}