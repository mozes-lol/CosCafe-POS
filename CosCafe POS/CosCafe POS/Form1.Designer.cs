
namespace CosCafe_POS
{
    partial class Main
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
            this.label_orderCost = new System.Windows.Forms.Label();
            this.label_totalCost = new System.Windows.Forms.Label();
            this.label_totalCostNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_addOrderDetails
            // 
            this.button_addOrderDetails.Location = new System.Drawing.Point(8, 93);
            this.button_addOrderDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_addOrderDetails.Name = "button_addOrderDetails";
            this.button_addOrderDetails.Size = new System.Drawing.Size(153, 45);
            this.button_addOrderDetails.TabIndex = 0;
            this.button_addOrderDetails.Text = "Add Order";
            this.button_addOrderDetails.UseVisualStyleBackColor = true;
            // 
            // button_confirmCustomerOrderList
            // 
            this.button_confirmCustomerOrderList.BackColor = System.Drawing.Color.MistyRose;
            this.button_confirmCustomerOrderList.Location = new System.Drawing.Point(8, 142);
            this.button_confirmCustomerOrderList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_confirmCustomerOrderList.Name = "button_confirmCustomerOrderList";
            this.button_confirmCustomerOrderList.Size = new System.Drawing.Size(153, 45);
            this.button_confirmCustomerOrderList.TabIndex = 1;
            this.button_confirmCustomerOrderList.Text = "Confirm Order List";
            this.button_confirmCustomerOrderList.UseVisualStyleBackColor = false;
            // 
            // listBox_orderName
            // 
            this.listBox_orderName.FormattingEnabled = true;
            this.listBox_orderName.Location = new System.Drawing.Point(173, 21);
            this.listBox_orderName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox_orderName.Name = "listBox_orderName";
            this.listBox_orderName.Size = new System.Drawing.Size(152, 238);
            this.listBox_orderName.TabIndex = 5;
            this.listBox_orderName.SelectedIndexChanged += new System.EventHandler(this.listBox_orderName_SelectedIndexChanged);
            // 
            // listBox_quantity
            // 
            this.listBox_quantity.FormattingEnabled = true;
            this.listBox_quantity.Location = new System.Drawing.Point(327, 21);
            this.listBox_quantity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox_quantity.Name = "listBox_quantity";
            this.listBox_quantity.Size = new System.Drawing.Size(37, 238);
            this.listBox_quantity.TabIndex = 6;
            // 
            // listBox_orderCost
            // 
            this.listBox_orderCost.FormattingEnabled = true;
            this.listBox_orderCost.Location = new System.Drawing.Point(366, 22);
            this.listBox_orderCost.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox_orderCost.Name = "listBox_orderCost";
            this.listBox_orderCost.Size = new System.Drawing.Size(73, 238);
            this.listBox_orderCost.TabIndex = 7;
            // 
            // label_orderName
            // 
            this.label_orderName.AutoSize = true;
            this.label_orderName.Location = new System.Drawing.Point(170, 6);
            this.label_orderName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_orderName.Name = "label_orderName";
            this.label_orderName.Size = new System.Drawing.Size(44, 13);
            this.label_orderName.TabIndex = 8;
            this.label_orderName.Text = "Order(s)";
            // 
            // label_quantity
            // 
            this.label_quantity.AutoSize = true;
            this.label_quantity.Location = new System.Drawing.Point(324, 6);
            this.label_quantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_quantity.Name = "label_quantity";
            this.label_quantity.Size = new System.Drawing.Size(36, 13);
            this.label_quantity.TabIndex = 9;
            this.label_quantity.Text = "Quan.";
            // 
            // label_orderCost
            // 
            this.label_orderCost.AutoSize = true;
            this.label_orderCost.Location = new System.Drawing.Point(363, 6);
            this.label_orderCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_orderCost.Name = "label_orderCost";
            this.label_orderCost.Size = new System.Drawing.Size(28, 13);
            this.label_orderCost.TabIndex = 10;
            this.label_orderCost.Text = "Cost";
            // 
            // label_totalCost
            // 
            this.label_totalCost.AutoSize = true;
            this.label_totalCost.Location = new System.Drawing.Point(305, 268);
            this.label_totalCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_totalCost.Name = "label_totalCost";
            this.label_totalCost.Size = new System.Drawing.Size(58, 13);
            this.label_totalCost.TabIndex = 11;
            this.label_totalCost.Text = "Total Cost:";
            // 
            // label_totalCostNumber
            // 
            this.label_totalCostNumber.AutoSize = true;
            this.label_totalCostNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_totalCostNumber.Location = new System.Drawing.Point(363, 263);
            this.label_totalCostNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_totalCostNumber.Name = "label_totalCostNumber";
            this.label_totalCostNumber.Size = new System.Drawing.Size(18, 20);
            this.label_totalCostNumber.TabIndex = 12;
            this.label_totalCostNumber.Text = "0";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 292);
            this.Controls.Add(this.label_totalCostNumber);
            this.Controls.Add(this.label_totalCost);
            this.Controls.Add(this.label_orderCost);
            this.Controls.Add(this.label_quantity);
            this.Controls.Add(this.label_orderName);
            this.Controls.Add(this.listBox_orderCost);
            this.Controls.Add(this.listBox_quantity);
            this.Controls.Add(this.listBox_orderName);
            this.Controls.Add(this.button_confirmCustomerOrderList);
            this.Controls.Add(this.button_addOrderDetails);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Main";
            this.Text = "Main";
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
        private System.Windows.Forms.Label label_orderCost;
        private System.Windows.Forms.Label label_totalCost;
        private System.Windows.Forms.Label label_totalCostNumber;
    }
}

