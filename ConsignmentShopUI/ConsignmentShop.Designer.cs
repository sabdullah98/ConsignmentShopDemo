namespace ConsignmentShopUI
{
    partial class ConsignmentShop
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
            this.headerText = new System.Windows.Forms.Label();
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.itemsListBoxLabel = new System.Windows.Forms.Label();
            this.shoppingCartListBoxLabel = new System.Windows.Forms.Label();
            this.shoppingCartListBox = new System.Windows.Forms.ListBox();
            this.addToCart = new System.Windows.Forms.Button();
            this.makePurchase = new System.Windows.Forms.Button();
            this.vendorListBoxLabel = new System.Windows.Forms.Label();
            this.vendorListBox = new System.Windows.Forms.ListBox();
            this.storeProfitLabel = new System.Windows.Forms.Label();
            this.storeProfitValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerText.Location = new System.Drawing.Point(38, 27);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(411, 38);
            this.headerText.TabIndex = 0;
            this.headerText.Text = "Consignment Shop Demo";
            // 
            // itemsListBox
            // 
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.ItemHeight = 25;
            this.itemsListBox.Location = new System.Drawing.Point(45, 130);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(334, 229);
            this.itemsListBox.TabIndex = 1;
            // 
            // itemsListBoxLabel
            // 
            this.itemsListBoxLabel.AutoSize = true;
            this.itemsListBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsListBoxLabel.Location = new System.Drawing.Point(40, 92);
            this.itemsListBoxLabel.Name = "itemsListBoxLabel";
            this.itemsListBoxLabel.Size = new System.Drawing.Size(122, 25);
            this.itemsListBoxLabel.TabIndex = 2;
            this.itemsListBoxLabel.Text = "Store Items";
            // 
            // shoppingCartListBoxLabel
            // 
            this.shoppingCartListBoxLabel.AutoSize = true;
            this.shoppingCartListBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoppingCartListBoxLabel.Location = new System.Drawing.Point(787, 92);
            this.shoppingCartListBoxLabel.Name = "shoppingCartListBoxLabel";
            this.shoppingCartListBoxLabel.Size = new System.Drawing.Size(151, 25);
            this.shoppingCartListBoxLabel.TabIndex = 4;
            this.shoppingCartListBoxLabel.Text = "Shopping Cart";
            // 
            // shoppingCartListBox
            // 
            this.shoppingCartListBox.FormattingEnabled = true;
            this.shoppingCartListBox.ItemHeight = 25;
            this.shoppingCartListBox.Location = new System.Drawing.Point(792, 130);
            this.shoppingCartListBox.Name = "shoppingCartListBox";
            this.shoppingCartListBox.Size = new System.Drawing.Size(334, 229);
            this.shoppingCartListBox.TabIndex = 3;
            // 
            // addToCart
            // 
            this.addToCart.Location = new System.Drawing.Point(480, 218);
            this.addToCart.Name = "addToCart";
            this.addToCart.Size = new System.Drawing.Size(213, 55);
            this.addToCart.TabIndex = 5;
            this.addToCart.Text = "Add To Cart >>";
            this.addToCart.UseVisualStyleBackColor = true;
            this.addToCart.Click += new System.EventHandler(this.addToCart_Click);
            // 
            // makePurchase
            // 
            this.makePurchase.Location = new System.Drawing.Point(913, 372);
            this.makePurchase.Name = "makePurchase";
            this.makePurchase.Size = new System.Drawing.Size(213, 55);
            this.makePurchase.TabIndex = 6;
            this.makePurchase.Text = "Purchase";
            this.makePurchase.UseVisualStyleBackColor = true;
            this.makePurchase.Click += new System.EventHandler(this.makePurchase_Click);
            // 
            // vendorListBoxLabel
            // 
            this.vendorListBoxLabel.AutoSize = true;
            this.vendorListBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorListBoxLabel.Location = new System.Drawing.Point(40, 433);
            this.vendorListBoxLabel.Name = "vendorListBoxLabel";
            this.vendorListBoxLabel.Size = new System.Drawing.Size(93, 25);
            this.vendorListBoxLabel.TabIndex = 8;
            this.vendorListBoxLabel.Text = "Vendors";
            // 
            // vendorListBox
            // 
            this.vendorListBox.FormattingEnabled = true;
            this.vendorListBox.ItemHeight = 25;
            this.vendorListBox.Location = new System.Drawing.Point(45, 471);
            this.vendorListBox.Name = "vendorListBox";
            this.vendorListBox.Size = new System.Drawing.Size(334, 229);
            this.vendorListBox.TabIndex = 7;
            // 
            // storeProfitLabel
            // 
            this.storeProfitLabel.AutoSize = true;
            this.storeProfitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeProfitLabel.Location = new System.Drawing.Point(787, 471);
            this.storeProfitLabel.Name = "storeProfitLabel";
            this.storeProfitLabel.Size = new System.Drawing.Size(120, 25);
            this.storeProfitLabel.TabIndex = 9;
            this.storeProfitLabel.Text = "Store Profit";
            // 
            // storeProfitValue
            // 
            this.storeProfitValue.AutoSize = true;
            this.storeProfitValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeProfitValue.Location = new System.Drawing.Point(908, 471);
            this.storeProfitValue.Name = "storeProfitValue";
            this.storeProfitValue.Size = new System.Drawing.Size(85, 25);
            this.storeProfitValue.TabIndex = 10;
            this.storeProfitValue.Text = "Rs 0.00";
            // 
            // ConsignmentShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 712);
            this.Controls.Add(this.storeProfitValue);
            this.Controls.Add(this.storeProfitLabel);
            this.Controls.Add(this.vendorListBoxLabel);
            this.Controls.Add(this.vendorListBox);
            this.Controls.Add(this.makePurchase);
            this.Controls.Add(this.addToCart);
            this.Controls.Add(this.shoppingCartListBoxLabel);
            this.Controls.Add(this.shoppingCartListBox);
            this.Controls.Add(this.itemsListBoxLabel);
            this.Controls.Add(this.itemsListBox);
            this.Controls.Add(this.headerText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ConsignmentShop";
            this.Text = "Consignment Shop Demo";
            this.Load += new System.EventHandler(this.ConsignmentShop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerText;
        private System.Windows.Forms.ListBox itemsListBox;
        private System.Windows.Forms.Label itemsListBoxLabel;
        private System.Windows.Forms.Label shoppingCartListBoxLabel;
        private System.Windows.Forms.ListBox shoppingCartListBox;
        private System.Windows.Forms.Button addToCart;
        private System.Windows.Forms.Button makePurchase;
        private System.Windows.Forms.Label vendorListBoxLabel;
        private System.Windows.Forms.ListBox vendorListBox;
        private System.Windows.Forms.Label storeProfitLabel;
        private System.Windows.Forms.Label storeProfitValue;
    }
}

