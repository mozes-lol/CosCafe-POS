
namespace CosCafe_POS
{
    partial class Form1
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
            this.button_addOrderDetails = new System.Windows.Forms.Button();
            this.button_confirmCustomerOrderList = new System.Windows.Forms.Button();
            this.listBox_orderName = new System.Windows.Forms.ListBox();
            this.listBox_quantity = new System.Windows.Forms.ListBox();
            this.listBox_orderCost = new System.Windows.Forms.ListBox();
            this.label_orderName = new System.Windows.Forms.Label();
            this.label_quantity = new System.Windows.Forms.Label();
            this.label_totalCost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_addOrderDetails
            // 
            this.button_addOrderDetails.Location = new System.Drawing.Point(12, 143);
            this.button_addOrderDetails.Name = "button_addOrderDetails";
            this.button_addOrderDetails.Size = new System.Drawing.Size(229, 69);
            this.button_addOrderDetails.TabIndex = 0;
            this.button_addOrderDetails.Text = "Add Order";
            this.button_addOrderDetails.UseVisualStyleBackColor = true;
            // 
            // button_confirmCustomerOrderList
            // 
            this.button_confirmCustomerOrderList.Location = new System.Drawing.Point(12, 218);
            this.button_confirmCustomerOrderList.Name = "button_confirmCustomerOrderList";
            this.button_confirmCustomerOrderList.Size = new System.Drawing.Size(229, 69);
            this.button_confirmCustomerOrderList.TabIndex = 1;
            this.button_confirmCustomerOrderList.Text = "Confirm Order List";
            this.button_confirmCustomerOrderList.UseVisualStyleBackColor = true;
            // 
            // listBox_orderName
            // 
            this.listBox_orderName.FormattingEnabled = true;
            this.listBox_orderName.ItemHeight = 20;
            this.listBox_orderName.Location = new System.Drawing.Point(258, 32);
            this.listBox_orderName.Name = "listBox_orderName";
            this.listBox_orderName.Size = new System.Drawing.Size(226, 404);
            this.listBox_orderName.TabIndex = 5;
            // 
            // listBox_quantity
            // 
            this.listBox_quantity.FormattingEnabled = true;
            this.listBox_quantity.ItemHeight = 20;
            this.listBox_quantity.Location = new System.Drawing.Point(490, 32);
            this.listBox_quantity.Name = "listBox_quantity";
            this.listBox_quantity.Size = new System.Drawing.Size(53, 404);
            this.listBox_quantity.TabIndex = 6;
            // 
            // listBox_orderCost
            // 
            this.listBox_orderCost.FormattingEnabled = true;
            this.listBox_orderCost.ItemHeight = 20;
            this.listBox_orderCost.Location = new System.Drawing.Point(549, 34);
            this.listBox_orderCost.Name = "listBox_orderCost";
            this.listBox_orderCost.Size = new System.Drawing.Size(108, 404);
            this.listBox_orderCost.TabIndex = 7;
            // 
            // label_orderName
            // 
            this.label_orderName.AutoSize = true;
            this.label_orderName.Location = new System.Drawing.Point(255, 9);
            this.label_orderName.Name = "label_orderName";
            this.label_orderName.Size = new System.Drawing.Size(67, 20);
            this.label_orderName.TabIndex = 8;
            this.label_orderName.Text = "Order(s)";
            // 
            // label_quantity
            // 
            this.label_quantity.AutoSize = true;
            this.label_quantity.Location = new System.Drawing.Point(486, 9);
            this.label_quantity.Name = "label_quantity";
            this.label_quantity.Size = new System.Drawing.Size(52, 20);
            this.label_quantity.TabIndex = 9;
            this.label_quantity.Text = "Quan.";
            // 
            // label_totalCost
            // 
            this.label_totalCost.AutoSize = true;
            this.label_totalCost.Location = new System.Drawing.Point(549, 11);
            this.label_totalCost.Name = "label_totalCost";
            this.label_totalCost.Size = new System.Drawing.Size(81, 20);
            this.label_totalCost.TabIndex = 10;
            this.label_totalCost.Text = "Total Cost";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 450);
            this.Controls.Add(this.label_totalCost);
            this.Controls.Add(this.label_quantity);
            this.Controls.Add(this.label_orderName);
            this.Controls.Add(this.listBox_orderCost);
            this.Controls.Add(this.listBox_quantity);
            this.Controls.Add(this.listBox_orderName);
            this.Controls.Add(this.button_confirmCustomerOrderList);
            this.Controls.Add(this.button_addOrderDetails);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_addOrderDetails;
        private System.Windows.Forms.Button button_confirmCustomerOrderList;
        private System.Windows.Forms.ListBox listBox_orderName;
        private System.Windows.Forms.ListBox listBox_quantity;
        private System.Windows.Forms.ListBox listBox_orderCost;
        private System.Windows.Forms.Label label_orderName;
        private System.Windows.Forms.Label label_quantity;
        private System.Windows.Forms.Label label_totalCost;
    }
}

