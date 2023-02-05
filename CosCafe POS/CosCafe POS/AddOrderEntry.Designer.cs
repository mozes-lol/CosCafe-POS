
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
            this.textBox_cost = new System.Windows.Forms.TextBox();
            this.button_enterOrderEntry = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_chooseOrder
            // 
            this.comboBox_chooseOrder.FormattingEnabled = true;
            this.comboBox_chooseOrder.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBox_chooseOrder.Location = new System.Drawing.Point(51, 12);
            this.comboBox_chooseOrder.Name = "comboBox_chooseOrder";
            this.comboBox_chooseOrder.Size = new System.Drawing.Size(151, 21);
            this.comboBox_chooseOrder.TabIndex = 0;
            // 
            // label_chooseOrder
            // 
            this.label_chooseOrder.AutoSize = true;
            this.label_chooseOrder.Location = new System.Drawing.Point(12, 15);
            this.label_chooseOrder.Name = "label_chooseOrder";
            this.label_chooseOrder.Size = new System.Drawing.Size(33, 13);
            this.label_chooseOrder.TabIndex = 1;
            this.label_chooseOrder.Text = "Order";
            // 
            // label_cost
            // 
            this.label_cost.AutoSize = true;
            this.label_cost.Location = new System.Drawing.Point(12, 51);
            this.label_cost.Name = "label_cost";
            this.label_cost.Size = new System.Drawing.Size(28, 13);
            this.label_cost.TabIndex = 2;
            this.label_cost.Text = "Cost";
            // 
            // textBox_cost
            // 
            this.textBox_cost.Location = new System.Drawing.Point(51, 48);
            this.textBox_cost.Name = "textBox_cost";
            this.textBox_cost.Size = new System.Drawing.Size(151, 20);
            this.textBox_cost.TabIndex = 3;
            // 
            // button_enterOrderEntry
            // 
            this.button_enterOrderEntry.Location = new System.Drawing.Point(15, 89);
            this.button_enterOrderEntry.Name = "button_enterOrderEntry";
            this.button_enterOrderEntry.Size = new System.Drawing.Size(187, 50);
            this.button_enterOrderEntry.TabIndex = 4;
            this.button_enterOrderEntry.Text = "Enter Order";
            this.button_enterOrderEntry.UseVisualStyleBackColor = true;
            // 
            // AddOrderEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 151);
            this.Controls.Add(this.button_enterOrderEntry);
            this.Controls.Add(this.textBox_cost);
            this.Controls.Add(this.label_cost);
            this.Controls.Add(this.label_chooseOrder);
            this.Controls.Add(this.comboBox_chooseOrder);
            this.Name = "AddOrderEntry";
            this.Text = "AddOrderEntry";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddOrderEntry_FormClosed);
            this.Load += new System.EventHandler(this.AddOrderEntry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_chooseOrder;
        private System.Windows.Forms.Label label_chooseOrder;
        private System.Windows.Forms.Label label_cost;
        private System.Windows.Forms.TextBox textBox_cost;
        private System.Windows.Forms.Button button_enterOrderEntry;
    }
}