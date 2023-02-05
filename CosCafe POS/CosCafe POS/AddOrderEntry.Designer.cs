
namespace CosCafe_POS
{
    partial class AddOrderEntry
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
            this.comboBox_chooseOrder = new System.Windows.Forms.ComboBox();
            this.label_chooseOrder = new System.Windows.Forms.Label();
            this.label_cost = new System.Windows.Forms.Label();
            this.button_enterOrderEntry = new System.Windows.Forms.Button();
            this.label_quantity = new System.Windows.Forms.Label();
            this.numericUpDown_Quantity = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_cost = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_cost)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_chooseOrder
            // 
            this.comboBox_chooseOrder.FormattingEnabled = true;
            this.comboBox_chooseOrder.Location = new System.Drawing.Point(69, 12);
            this.comboBox_chooseOrder.Name = "comboBox_chooseOrder";
            this.comboBox_chooseOrder.Size = new System.Drawing.Size(151, 21);
            this.comboBox_chooseOrder.TabIndex = 0;
            this.comboBox_chooseOrder.SelectedIndexChanged += new System.EventHandler(this.comboBox_chooseOrder_SelectedIndexChanged);
            // 
            // label_chooseOrder
            // 
            this.label_chooseOrder.AutoSize = true;
            this.label_chooseOrder.Location = new System.Drawing.Point(30, 15);
            this.label_chooseOrder.Name = "label_chooseOrder";
            this.label_chooseOrder.Size = new System.Drawing.Size(33, 13);
            this.label_chooseOrder.TabIndex = 1;
            this.label_chooseOrder.Text = "Order";
            // 
            // label_cost
            // 
            this.label_cost.AutoSize = true;
            this.label_cost.Location = new System.Drawing.Point(35, 42);
            this.label_cost.Name = "label_cost";
            this.label_cost.Size = new System.Drawing.Size(28, 13);
            this.label_cost.TabIndex = 2;
            this.label_cost.Text = "Cost";
            // 
            // button_enterOrderEntry
            // 
            this.button_enterOrderEntry.Location = new System.Drawing.Point(12, 106);
            this.button_enterOrderEntry.Name = "button_enterOrderEntry";
            this.button_enterOrderEntry.Size = new System.Drawing.Size(202, 52);
            this.button_enterOrderEntry.TabIndex = 4;
            this.button_enterOrderEntry.Text = "Enter Order";
            this.button_enterOrderEntry.UseVisualStyleBackColor = true;
            this.button_enterOrderEntry.Click += new System.EventHandler(this.button_enterOrderEntry_Click);
            // 
            // label_quantity
            // 
            this.label_quantity.AutoSize = true;
            this.label_quantity.Location = new System.Drawing.Point(17, 68);
            this.label_quantity.Name = "label_quantity";
            this.label_quantity.Size = new System.Drawing.Size(46, 13);
            this.label_quantity.TabIndex = 6;
            this.label_quantity.Text = "Quantity";
            // 
            // numericUpDown_Quantity
            // 
            this.numericUpDown_Quantity.Location = new System.Drawing.Point(70, 66);
            this.numericUpDown_Quantity.Name = "numericUpDown_Quantity";
            this.numericUpDown_Quantity.Size = new System.Drawing.Size(150, 20);
            this.numericUpDown_Quantity.TabIndex = 7;
            // 
            // numericUpDown_cost
            // 
            this.numericUpDown_cost.Location = new System.Drawing.Point(70, 39);
            this.numericUpDown_cost.Name = "numericUpDown_cost";
            this.numericUpDown_cost.Size = new System.Drawing.Size(150, 20);
            this.numericUpDown_cost.TabIndex = 8;
            // 
            // AddOrderEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 170);
            this.Controls.Add(this.numericUpDown_cost);
            this.Controls.Add(this.numericUpDown_Quantity);
            this.Controls.Add(this.label_quantity);
            this.Controls.Add(this.button_enterOrderEntry);
            this.Controls.Add(this.label_cost);
            this.Controls.Add(this.label_chooseOrder);
            this.Controls.Add(this.comboBox_chooseOrder);
            this.Name = "AddOrderEntry";
            this.Text = "AddOrderEntry";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddOrderEntry_FormClosed);
            this.Load += new System.EventHandler(this.AddOrderEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_cost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_chooseOrder;
        private System.Windows.Forms.Label label_chooseOrder;
        private System.Windows.Forms.Label label_cost;
        private System.Windows.Forms.Button button_enterOrderEntry;
        private System.Windows.Forms.Label label_quantity;
        private System.Windows.Forms.NumericUpDown numericUpDown_Quantity;
        private System.Windows.Forms.NumericUpDown numericUpDown_cost;
    }
}