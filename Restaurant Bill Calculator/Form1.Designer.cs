namespace Restaurant_Bill_Calculator
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
            this.comboBoxBeverage = new System.Windows.Forms.ComboBox();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.comboBoxMainCourse = new System.Windows.Forms.ComboBox();
            this.comboBoxAppetizer = new System.Windows.Forms.ComboBox();
            this.comboBoxDessert = new System.Windows.Forms.ComboBox();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSubtotalPrice = new System.Windows.Forms.Label();
            this.lblTaxPrice = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxBeverage
            // 
            this.comboBoxBeverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBeverage.FormattingEnabled = true;
            this.comboBoxBeverage.Items.AddRange(new object[] {
            "Soda: $1.95",
            "Tea: $1.50",
            "Coffee: $1.25",
            "Mineral Water: $2.95",
            "Juice: $2.50",
            "Milk: $1.50"});
            this.comboBoxBeverage.Location = new System.Drawing.Point(45, 97);
            this.comboBoxBeverage.Name = "comboBoxBeverage";
            this.comboBoxBeverage.Size = new System.Drawing.Size(175, 28);
            this.comboBoxBeverage.TabIndex = 0;
            this.comboBoxBeverage.Text = "Beverage";
            this.comboBoxBeverage.SelectedIndexChanged += new System.EventHandler(this.AddPrice_SelectedIndexChanged);
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction.Location = new System.Drawing.Point(41, 30);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(528, 20);
            this.lblInstruction.TabIndex = 1;
            this.lblInstruction.Text = "Choose from these ComboBoxes to add an item to the table\'s bill";
            // 
            // comboBoxMainCourse
            // 
            this.comboBoxMainCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMainCourse.FormattingEnabled = true;
            this.comboBoxMainCourse.Items.AddRange(new object[] {
            "Chicken Alfredo: $13.95",
            "Chicken Picatta: $13.95",
            "Turkey Club: $11.95",
            "Lobster Pie: $19.95",
            "Prime Rib: $20.95",
            "Shrimp Scampi: $18.95",
            "Turkey Dinner: $13.95",
            "Stuffed Chicken: $14.95",
            "Seafood Alfredo: $15.95"});
            this.comboBoxMainCourse.Location = new System.Drawing.Point(394, 97);
            this.comboBoxMainCourse.Name = "comboBoxMainCourse";
            this.comboBoxMainCourse.Size = new System.Drawing.Size(175, 28);
            this.comboBoxMainCourse.TabIndex = 2;
            this.comboBoxMainCourse.Text = "Main Course";
            this.comboBoxMainCourse.SelectedIndexChanged += new System.EventHandler(this.AddPrice_SelectedIndexChanged);
            // 
            // comboBoxAppetizer
            // 
            this.comboBoxAppetizer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAppetizer.FormattingEnabled = true;
            this.comboBoxAppetizer.Items.AddRange(new object[] {
            "Buffalo Wings: $5.95",
            "Buffalo Fingers: $6.95",
            "Potato Skins: $8.95",
            "Nachos: $8.95",
            "Mushroom Caps: $10.95",
            "Shrimp Cocktail: $12.95",
            "Chips and Salsa: $6.95 "});
            this.comboBoxAppetizer.Location = new System.Drawing.Point(220, 97);
            this.comboBoxAppetizer.Name = "comboBoxAppetizer";
            this.comboBoxAppetizer.Size = new System.Drawing.Size(175, 28);
            this.comboBoxAppetizer.TabIndex = 3;
            this.comboBoxAppetizer.Text = "Appetizer";
            this.comboBoxAppetizer.SelectedIndexChanged += new System.EventHandler(this.AddPrice_SelectedIndexChanged);
            // 
            // comboBoxDessert
            // 
            this.comboBoxDessert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDessert.FormattingEnabled = true;
            this.comboBoxDessert.Items.AddRange(new object[] {
            "Apple Pie: $5.95",
            "Sundae: $3.95",
            "Carrot Cake: $5.95",
            "Mud Pie: $4.95",
            "Apple Crisp: $5.95"});
            this.comboBoxDessert.Location = new System.Drawing.Point(566, 97);
            this.comboBoxDessert.Name = "comboBoxDessert";
            this.comboBoxDessert.Size = new System.Drawing.Size(175, 28);
            this.comboBoxDessert.TabIndex = 4;
            this.comboBoxDessert.Text = "Dessert";
            this.comboBoxDessert.SelectedIndexChanged += new System.EventHandler(this.AddPrice_SelectedIndexChanged);
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(46, 312);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(57, 20);
            this.lblTax.TabIndex = 5;
            this.lblTax.Text = "Tax: $";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(46, 272);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(97, 20);
            this.lblSubtotal.TabIndex = 6;
            this.lblSubtotal.Text = "Subtotal: $";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(47, 352);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(69, 20);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Total: $";
            // 
            // lblSubtotalPrice
            // 
            this.lblSubtotalPrice.AutoSize = true;
            this.lblSubtotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotalPrice.Location = new System.Drawing.Point(138, 272);
            this.lblSubtotalPrice.Name = "lblSubtotalPrice";
            this.lblSubtotalPrice.Size = new System.Drawing.Size(44, 20);
            this.lblSubtotalPrice.TabIndex = 8;
            this.lblSubtotalPrice.Text = "0.00";
            // 
            // lblTaxPrice
            // 
            this.lblTaxPrice.AutoSize = true;
            this.lblTaxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxPrice.Location = new System.Drawing.Point(97, 312);
            this.lblTaxPrice.Name = "lblTaxPrice";
            this.lblTaxPrice.Size = new System.Drawing.Size(44, 20);
            this.lblTaxPrice.TabIndex = 9;
            this.lblTaxPrice.Text = "0.00";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(113, 352);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(44, 20);
            this.lblTotalPrice.TabIndex = 10;
            this.lblTotalPrice.Text = "0.00";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(557, 329);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(99, 43);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Clear Bill";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblTaxPrice);
            this.Controls.Add(this.lblSubtotalPrice);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.comboBoxDessert);
            this.Controls.Add(this.comboBoxAppetizer);
            this.Controls.Add(this.comboBoxMainCourse);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.comboBoxBeverage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxBeverage;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.ComboBox comboBoxMainCourse;
        private System.Windows.Forms.ComboBox comboBoxAppetizer;
        private System.Windows.Forms.ComboBox comboBoxDessert;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSubtotalPrice;
        private System.Windows.Forms.Label lblTaxPrice;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Button btnReset;
    }
}

