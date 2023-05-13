namespace otk22
{
    partial class SetupForm
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.curTimer = new System.Windows.Forms.Timer(this.components);
            this.curDataGridView = new System.Windows.Forms.DataGridView();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rate2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.curDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(12, 12);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(465, 166);
            this.checkedListBox1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 364);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 51);
            this.panel1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(401, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(320, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // curTimer
            // 
            this.curTimer.Interval = 5000;
            this.curTimer.Tick += new System.EventHandler(this.curTimer_Tick);
            // 
            // curDataGridView
            // 
            this.curDataGridView.AllowUserToAddRows = false;
            this.curDataGridView.AllowUserToDeleteRows = false;
            this.curDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.curDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.curDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code,
            this.rate2,
            this.rate});
            this.curDataGridView.Location = new System.Drawing.Point(12, 193);
            this.curDataGridView.Name = "curDataGridView";
            this.curDataGridView.ReadOnly = true;
            this.curDataGridView.RowTemplate.Height = 25;
            this.curDataGridView.Size = new System.Drawing.Size(465, 152);
            this.curDataGridView.TabIndex = 5;
            // 
            // code
            // 
            this.code.DataPropertyName = "code";
            this.code.HeaderText = "Код Валюты";
            this.code.Name = "code";
            this.code.ReadOnly = true;
            // 
            // rate2
            // 
            this.rate2.DataPropertyName = "rate2";
            this.rate2.HeaderText = "Курс в копейках";
            this.rate2.Name = "rate2";
            this.rate2.ReadOnly = true;
            // 
            // rate
            // 
            this.rate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rate.DataPropertyName = "rate";
            this.rate.HeaderText = "Курс к Рублю";
            this.rate.Name = "rate";
            this.rate.ReadOnly = true;
            // 
            // SetupForm
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 411);
            this.Controls.Add(this.curDataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "SetupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настрока ";
            this.Load += new System.EventHandler(this.SetupForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.curDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CheckedListBox checkedListBox1;
        private Panel panel1;
        private Button button2;
        private Button button1;
        private System.Windows.Forms.Timer curTimer;
        private DataGridView curDataGridView;
        private DataGridViewTextBoxColumn code;
        private DataGridViewTextBoxColumn rate2;
        private DataGridViewTextBoxColumn rate;
    }
}