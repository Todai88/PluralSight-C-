namespace ACM.Win
{
    partial class CustomerWin
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
            this.btn_GetCustomers = new System.Windows.Forms.Button();
            this.grid_Customers = new System.Windows.Forms.DataGridView();
            this.cbx_Customers = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Customers)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_GetCustomers
            // 
            this.btn_GetCustomers.Location = new System.Drawing.Point(513, 12);
            this.btn_GetCustomers.Name = "btn_GetCustomers";
            this.btn_GetCustomers.Size = new System.Drawing.Size(133, 67);
            this.btn_GetCustomers.TabIndex = 0;
            this.btn_GetCustomers.Text = "Get Customers";
            this.btn_GetCustomers.UseVisualStyleBackColor = true;
            this.btn_GetCustomers.Click += new System.EventHandler(this.btn_GetCustomers_Click);
            // 
            // grid_Customers
            // 
            this.grid_Customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Customers.Location = new System.Drawing.Point(12, 86);
            this.grid_Customers.Name = "grid_Customers";
            this.grid_Customers.Size = new System.Drawing.Size(498, 384);
            this.grid_Customers.TabIndex = 1;
            // 
            // cbx_Customers
            // 
            this.cbx_Customers.FormattingEnabled = true;
            this.cbx_Customers.Location = new System.Drawing.Point(12, 36);
            this.cbx_Customers.Name = "cbx_Customers";
            this.cbx_Customers.Size = new System.Drawing.Size(346, 21);
            this.cbx_Customers.TabIndex = 2;
            this.cbx_Customers.SelectedIndexChanged += new System.EventHandler(this.cbx_Customers_SelectedIndexChanged);
            // 
            // CustomerWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 482);
            this.Controls.Add(this.cbx_Customers);
            this.Controls.Add(this.grid_Customers);
            this.Controls.Add(this.btn_GetCustomers);
            this.Name = "CustomerWin";
            this.Text = "CustomerWin";
            this.Load += new System.EventHandler(this.CustomerWin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Customers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_GetCustomers;
        private System.Windows.Forms.DataGridView grid_Customers;
        private System.Windows.Forms.ComboBox cbx_Customers;
    }
}