
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
            this.button_confirmCustomerOrderList = new System.Windows.Forms.Button();
            this.listBox_orderName = new System.Windows.Forms.ListBox();
            this.listBox_quantity = new System.Windows.Forms.ListBox();
            this.listBox_orderCost = new System.Windows.Forms.ListBox();
            this.label_orderName = new System.Windows.Forms.Label();
            this.label_quantity = new System.Windows.Forms.Label();
            this.label_orderCost = new System.Windows.Forms.Label();
            this.label_totalCost = new System.Windows.Forms.Label();
            this.label_totalCostNumber = new System.Windows.Forms.Label();
            this.panel_customerOrderList = new System.Windows.Forms.Panel();
            this.button_deleteOrderList = new System.Windows.Forms.Button();
            this.numericUpDown_cost = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Quantity = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button_enterOrderEntry = new System.Windows.Forms.Button();
            this.label_cost = new System.Windows.Forms.Label();
            this.label_chooseOrder = new System.Windows.Forms.Label();
            this.comboBox_chooseOrder = new System.Windows.Forms.ComboBox();
            this.panel_addOrderEntry = new System.Windows.Forms.Panel();
            this.panel_customerOrderList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_cost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Quantity)).BeginInit();
            this.panel_addOrderEntry.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_confirmCustomerOrderList
            // 
            this.button_confirmCustomerOrderList.BackColor = System.Drawing.Color.Lime;
            this.button_confirmCustomerOrderList.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_confirmCustomerOrderList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_confirmCustomerOrderList.Location = new System.Drawing.Point(14, 63);
            this.button_confirmCustomerOrderList.Margin = new System.Windows.Forms.Padding(2);
            this.button_confirmCustomerOrderList.Name = "button_confirmCustomerOrderList";
            this.button_confirmCustomerOrderList.Size = new System.Drawing.Size(131, 151);
            this.button_confirmCustomerOrderList.TabIndex = 1;
            this.button_confirmCustomerOrderList.Text = "Confirm Order List";
            this.button_confirmCustomerOrderList.UseVisualStyleBackColor = false;
            this.button_confirmCustomerOrderList.Click += new System.EventHandler(this.button_confirmCustomerOrderList_Click);
            // 
            // listBox_orderName
            // 
            this.listBox_orderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_orderName.FormattingEnabled = true;
            this.listBox_orderName.ItemHeight = 15;
            this.listBox_orderName.Location = new System.Drawing.Point(159, 38);
            this.listBox_orderName.Margin = new System.Windows.Forms.Padding(2);
            this.listBox_orderName.Name = "listBox_orderName";
            this.listBox_orderName.Size = new System.Drawing.Size(230, 379);
            this.listBox_orderName.TabIndex = 5;
            this.listBox_orderName.SelectedIndexChanged += new System.EventHandler(this.listBox_orderName_SelectedIndexChanged);
            this.listBox_orderName.DoubleClick += new System.EventHandler(this.listBox_orderName_DoubleClick);
            // 
            // listBox_quantity
            // 
            this.listBox_quantity.Enabled = false;
            this.listBox_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_quantity.FormattingEnabled = true;
            this.listBox_quantity.ItemHeight = 15;
            this.listBox_quantity.Location = new System.Drawing.Point(393, 38);
            this.listBox_quantity.Margin = new System.Windows.Forms.Padding(2);
            this.listBox_quantity.Name = "listBox_quantity";
            this.listBox_quantity.Size = new System.Drawing.Size(32, 379);
            this.listBox_quantity.TabIndex = 6;
            // 
            // listBox_orderCost
            // 
            this.listBox_orderCost.BackColor = System.Drawing.SystemColors.Window;
            this.listBox_orderCost.Enabled = false;
            this.listBox_orderCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_orderCost.FormattingEnabled = true;
            this.listBox_orderCost.ItemHeight = 15;
            this.listBox_orderCost.Location = new System.Drawing.Point(429, 38);
            this.listBox_orderCost.Margin = new System.Windows.Forms.Padding(2);
            this.listBox_orderCost.Name = "listBox_orderCost";
            this.listBox_orderCost.Size = new System.Drawing.Size(45, 379);
            this.listBox_orderCost.TabIndex = 7;
            // 
            // label_orderName
            // 
            this.label_orderName.AutoSize = true;
            this.label_orderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_orderName.Location = new System.Drawing.Point(155, 16);
            this.label_orderName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_orderName.Name = "label_orderName";
            this.label_orderName.Size = new System.Drawing.Size(75, 20);
            this.label_orderName.TabIndex = 8;
            this.label_orderName.Text = "Order(s)";
            // 
            // label_quantity
            // 
            this.label_quantity.AutoSize = true;
            this.label_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_quantity.Location = new System.Drawing.Point(389, 16);
            this.label_quantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_quantity.Name = "label_quantity";
            this.label_quantity.Size = new System.Drawing.Size(19, 20);
            this.label_quantity.TabIndex = 9;
            this.label_quantity.Text = "#";
            // 
            // label_orderCost
            // 
            this.label_orderCost.AutoSize = true;
            this.label_orderCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_orderCost.Location = new System.Drawing.Point(425, 16);
            this.label_orderCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_orderCost.Name = "label_orderCost";
            this.label_orderCost.Size = new System.Drawing.Size(46, 20);
            this.label_orderCost.TabIndex = 10;
            this.label_orderCost.Text = "Cost";
            // 
            // label_totalCost
            // 
            this.label_totalCost.AutoSize = true;
            this.label_totalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_totalCost.Location = new System.Drawing.Point(293, 419);
            this.label_totalCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_totalCost.Name = "label_totalCost";
            this.label_totalCost.Size = new System.Drawing.Size(96, 20);
            this.label_totalCost.TabIndex = 11;
            this.label_totalCost.Text = "Total Cost:";
            // 
            // label_totalCostNumber
            // 
            this.label_totalCostNumber.AutoSize = true;
            this.label_totalCostNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_totalCostNumber.Location = new System.Drawing.Point(393, 419);
            this.label_totalCostNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_totalCostNumber.Name = "label_totalCostNumber";
            this.label_totalCostNumber.Size = new System.Drawing.Size(18, 20);
            this.label_totalCostNumber.TabIndex = 12;
            this.label_totalCostNumber.Text = "0";
            // 
            // panel_customerOrderList
            // 
            this.panel_customerOrderList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_customerOrderList.Controls.Add(this.button_deleteOrderList);
            this.panel_customerOrderList.Controls.Add(this.listBox_orderName);
            this.panel_customerOrderList.Controls.Add(this.label_orderName);
            this.panel_customerOrderList.Controls.Add(this.label_totalCostNumber);
            this.panel_customerOrderList.Controls.Add(this.label_orderCost);
            this.panel_customerOrderList.Controls.Add(this.label_totalCost);
            this.panel_customerOrderList.Controls.Add(this.listBox_quantity);
            this.panel_customerOrderList.Controls.Add(this.button_confirmCustomerOrderList);
            this.panel_customerOrderList.Controls.Add(this.listBox_orderCost);
            this.panel_customerOrderList.Controls.Add(this.label_quantity);
            this.panel_customerOrderList.Location = new System.Drawing.Point(12, 12);
            this.panel_customerOrderList.Name = "panel_customerOrderList";
            this.panel_customerOrderList.Size = new System.Drawing.Size(493, 456);
            this.panel_customerOrderList.TabIndex = 13;
            // 
            // button_deleteOrderList
            // 
            this.button_deleteOrderList.BackColor = System.Drawing.Color.Red;
            this.button_deleteOrderList.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_deleteOrderList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_deleteOrderList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_deleteOrderList.Location = new System.Drawing.Point(14, 241);
            this.button_deleteOrderList.Margin = new System.Windows.Forms.Padding(2);
            this.button_deleteOrderList.Name = "button_deleteOrderList";
            this.button_deleteOrderList.Size = new System.Drawing.Size(131, 151);
            this.button_deleteOrderList.TabIndex = 13;
            this.button_deleteOrderList.Text = "Delete Order List";
            this.button_deleteOrderList.UseVisualStyleBackColor = false;
            this.button_deleteOrderList.Click += new System.EventHandler(this.button_deleteOrderList_Click);
            // 
            // numericUpDown_cost
            // 
            this.numericUpDown_cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_cost.Location = new System.Drawing.Point(203, 196);
            this.numericUpDown_cost.Name = "numericUpDown_cost";
            this.numericUpDown_cost.Size = new System.Drawing.Size(164, 26);
            this.numericUpDown_cost.TabIndex = 20;
            // 
            // numericUpDown_Quantity
            // 
            this.numericUpDown_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_Quantity.Location = new System.Drawing.Point(96, 196);
            this.numericUpDown_Quantity.Name = "numericUpDown_Quantity";
            this.numericUpDown_Quantity.Size = new System.Drawing.Size(51, 26);
            this.numericUpDown_Quantity.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Quantity";
            // 
            // button_enterOrderEntry
            // 
            this.button_enterOrderEntry.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_enterOrderEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_enterOrderEntry.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_enterOrderEntry.Location = new System.Drawing.Point(23, 241);
            this.button_enterOrderEntry.Name = "button_enterOrderEntry";
            this.button_enterOrderEntry.Size = new System.Drawing.Size(344, 101);
            this.button_enterOrderEntry.TabIndex = 17;
            this.button_enterOrderEntry.Text = "Enter Order";
            this.button_enterOrderEntry.UseVisualStyleBackColor = false;
            this.button_enterOrderEntry.Click += new System.EventHandler(this.button_enterOrderEntry_Click);
            // 
            // label_cost
            // 
            this.label_cost.AutoSize = true;
            this.label_cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cost.Location = new System.Drawing.Point(153, 199);
            this.label_cost.Name = "label_cost";
            this.label_cost.Size = new System.Drawing.Size(44, 18);
            this.label_cost.TabIndex = 16;
            this.label_cost.Text = "Cost";
            // 
            // label_chooseOrder
            // 
            this.label_chooseOrder.AutoSize = true;
            this.label_chooseOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_chooseOrder.Location = new System.Drawing.Point(20, 157);
            this.label_chooseOrder.Name = "label_chooseOrder";
            this.label_chooseOrder.Size = new System.Drawing.Size(51, 18);
            this.label_chooseOrder.TabIndex = 15;
            this.label_chooseOrder.Text = "Order";
            // 
            // comboBox_chooseOrder
            // 
            this.comboBox_chooseOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_chooseOrder.FormattingEnabled = true;
            this.comboBox_chooseOrder.Location = new System.Drawing.Point(77, 154);
            this.comboBox_chooseOrder.Name = "comboBox_chooseOrder";
            this.comboBox_chooseOrder.Size = new System.Drawing.Size(290, 26);
            this.comboBox_chooseOrder.TabIndex = 14;
            this.comboBox_chooseOrder.SelectedIndexChanged += new System.EventHandler(this.comboBox_chooseOrder_SelectedIndexChanged);
            // 
            // panel_addOrderEntry
            // 
            this.panel_addOrderEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_addOrderEntry.Controls.Add(this.numericUpDown_Quantity);
            this.panel_addOrderEntry.Controls.Add(this.numericUpDown_cost);
            this.panel_addOrderEntry.Controls.Add(this.comboBox_chooseOrder);
            this.panel_addOrderEntry.Controls.Add(this.label_chooseOrder);
            this.panel_addOrderEntry.Controls.Add(this.label1);
            this.panel_addOrderEntry.Controls.Add(this.label_cost);
            this.panel_addOrderEntry.Controls.Add(this.button_enterOrderEntry);
            this.panel_addOrderEntry.Location = new System.Drawing.Point(511, 12);
            this.panel_addOrderEntry.Name = "panel_addOrderEntry";
            this.panel_addOrderEntry.Size = new System.Drawing.Size(388, 456);
            this.panel_addOrderEntry.TabIndex = 21;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 480);
            this.Controls.Add(this.panel_addOrderEntry);
            this.Controls.Add(this.panel_customerOrderList);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel_customerOrderList.ResumeLayout(false);
            this.panel_customerOrderList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_cost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Quantity)).EndInit();
            this.panel_addOrderEntry.ResumeLayout(false);
            this.panel_addOrderEntry.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_confirmCustomerOrderList;
        private System.Windows.Forms.ListBox listBox_orderName;
        private System.Windows.Forms.ListBox listBox_quantity;
        private System.Windows.Forms.ListBox listBox_orderCost;
        private System.Windows.Forms.Label label_orderName;
        private System.Windows.Forms.Label label_quantity;
        private System.Windows.Forms.Label label_orderCost;
        private System.Windows.Forms.Label label_totalCost;
        private System.Windows.Forms.Panel panel_customerOrderList;
        private System.Windows.Forms.NumericUpDown numericUpDown_cost;
        private System.Windows.Forms.NumericUpDown numericUpDown_Quantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_enterOrderEntry;
        private System.Windows.Forms.Label label_cost;
        private System.Windows.Forms.Label label_chooseOrder;
        private System.Windows.Forms.ComboBox comboBox_chooseOrder;
        private System.Windows.Forms.Panel panel_addOrderEntry;
        public System.Windows.Forms.Label label_totalCostNumber;
        private System.Windows.Forms.Button button_deleteOrderList;
    }
}

