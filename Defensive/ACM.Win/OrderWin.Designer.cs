namespace ACM.Win
{
    partial class OrderWin
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
            this.btn_PlaceOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_PlaceOrder
            // 
            this.btn_PlaceOrder.Location = new System.Drawing.Point(328, 12);
            this.btn_PlaceOrder.Name = "btn_PlaceOrder";
            this.btn_PlaceOrder.Size = new System.Drawing.Size(157, 97);
            this.btn_PlaceOrder.TabIndex = 0;
            this.btn_PlaceOrder.Text = "Place Order";
            this.btn_PlaceOrder.UseVisualStyleBackColor = true;
            this.btn_PlaceOrder.Click += new System.EventHandler(this.btn_PlaceOrder_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(497, 347);
            this.Controls.Add(this.btn_PlaceOrder);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_PlaceOrder;
    }
}

