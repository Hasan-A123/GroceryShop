namespace GroceryShop
{
    partial class OrderForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelOrderDetails = new System.Windows.Forms.Label();
            this.lblOrderNumber = new System.Windows.Forms.Label();
            this.txtBoxOrderNumber = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtBoxDate = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtBoxTime = new System.Windows.Forms.TextBox();
            this.lblItems = new System.Windows.Forms.Label();
            this.lstBoxItems = new System.Windows.Forms.ListBox();
            this.lblBasket = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.lstBoxBasket = new System.Windows.Forms.ListBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.txtBoxTotalPrice = new System.Windows.Forms.TextBox();
            this.lblChange = new System.Windows.Forms.Label();
            this.txtBoxChange = new System.Windows.Forms.TextBox();
            this.btnSubmitOrder = new System.Windows.Forms.Button();
            this.lblAmountPaid = new System.Windows.Forms.Label();
            this.txtBoxAmountPaid = new System.Windows.Forms.TextBox();
            this.radioButtonCash = new System.Windows.Forms.RadioButton();
            this.radioButtonCreditCard = new System.Windows.Forms.RadioButton();
            this.btnCreateNewOrder = new System.Windows.Forms.Button();
            this.buttonCheckout = new System.Windows.Forms.Button();
            this.groupBoxPaymentMethod = new System.Windows.Forms.GroupBox();
            this.labelPaymentMethod = new System.Windows.Forms.Label();
            this.buttonSaveOrder = new System.Windows.Forms.Button();
            this.buttonOpenOrders = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonAddProducts = new System.Windows.Forms.Button();
            this.groupBoxPaymentMethod.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelOrderDetails
            // 
            this.labelOrderDetails.AutoSize = true;
            this.labelOrderDetails.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelOrderDetails.Location = new System.Drawing.Point(24, 13);
            this.labelOrderDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOrderDetails.Name = "labelOrderDetails";
            this.labelOrderDetails.Size = new System.Drawing.Size(138, 28);
            this.labelOrderDetails.TabIndex = 0;
            this.labelOrderDetails.Text = "Order Details";
            // 
            // lblOrderNumber
            // 
            this.lblOrderNumber.AutoSize = true;
            this.lblOrderNumber.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOrderNumber.Location = new System.Drawing.Point(29, 50);
            this.lblOrderNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderNumber.Name = "lblOrderNumber";
            this.lblOrderNumber.Size = new System.Drawing.Size(105, 20);
            this.lblOrderNumber.TabIndex = 1;
            this.lblOrderNumber.Text = "Order Number";
            // 
            // txtBoxOrderNumber
            // 
            this.txtBoxOrderNumber.Location = new System.Drawing.Point(29, 76);
            this.txtBoxOrderNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxOrderNumber.Name = "txtBoxOrderNumber";
            this.txtBoxOrderNumber.Size = new System.Drawing.Size(106, 23);
            this.txtBoxOrderNumber.TabIndex = 2;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDate.Location = new System.Drawing.Point(29, 125);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(41, 20);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Date";
            // 
            // txtBoxDate
            // 
            this.txtBoxDate.Location = new System.Drawing.Point(24, 164);
            this.txtBoxDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxDate.Name = "txtBoxDate";
            this.txtBoxDate.Size = new System.Drawing.Size(106, 23);
            this.txtBoxDate.TabIndex = 6;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTime.Location = new System.Drawing.Point(27, 213);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(42, 20);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "Time";
            // 
            // txtBoxTime
            // 
            this.txtBoxTime.Location = new System.Drawing.Point(24, 245);
            this.txtBoxTime.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxTime.Name = "txtBoxTime";
            this.txtBoxTime.Size = new System.Drawing.Size(106, 23);
            this.txtBoxTime.TabIndex = 8;
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblItems.Location = new System.Drawing.Point(290, 13);
            this.lblItems.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(64, 28);
            this.lblItems.TabIndex = 9;
            this.lblItems.Text = "Items";
            // 
            // lstBoxItems
            // 
            this.lstBoxItems.FormattingEnabled = true;
            this.lstBoxItems.ItemHeight = 15;
            this.lstBoxItems.Location = new System.Drawing.Point(223, 58);
            this.lstBoxItems.Margin = new System.Windows.Forms.Padding(2);
            this.lstBoxItems.Name = "lstBoxItems";
            this.lstBoxItems.Size = new System.Drawing.Size(206, 244);
            this.lstBoxItems.TabIndex = 10;
            this.lstBoxItems.SelectedIndexChanged += new System.EventHandler(this.lstBoxItems_SelectedIndexChanged);
            // 
            // lblBasket
            // 
            this.lblBasket.AutoSize = true;
            this.lblBasket.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBasket.Location = new System.Drawing.Point(574, 13);
            this.lblBasket.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBasket.Name = "lblBasket";
            this.lblBasket.Size = new System.Drawing.Size(75, 28);
            this.lblBasket.TabIndex = 11;
            this.lblBasket.Text = "Basket";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(446, 150);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(81, 31);
            this.btnAddItem.TabIndex = 12;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(784, 146);
            this.btnRemoveItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(81, 39);
            this.btnRemoveItem.TabIndex = 13;
            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // lstBoxBasket
            // 
            this.lstBoxBasket.FormattingEnabled = true;
            this.lstBoxBasket.ItemHeight = 15;
            this.lstBoxBasket.Location = new System.Drawing.Point(556, 50);
            this.lstBoxBasket.Margin = new System.Windows.Forms.Padding(2);
            this.lstBoxBasket.Name = "lstBoxBasket";
            this.lstBoxBasket.Size = new System.Drawing.Size(197, 244);
            this.lstBoxBasket.TabIndex = 14;
            this.lstBoxBasket.SelectedIndexChanged += new System.EventHandler(this.lstBoxBasket_SelectedIndexChanged);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(986, 216);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(61, 15);
            this.lblTotalPrice.TabIndex = 16;
            this.lblTotalPrice.Text = "Total Price";
            // 
            // txtBoxTotalPrice
            // 
            this.txtBoxTotalPrice.Location = new System.Drawing.Point(1093, 214);
            this.txtBoxTotalPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxTotalPrice.Name = "txtBoxTotalPrice";
            this.txtBoxTotalPrice.Size = new System.Drawing.Size(106, 23);
            this.txtBoxTotalPrice.TabIndex = 17;
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Location = new System.Drawing.Point(1000, 298);
            this.lblChange.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(48, 15);
            this.lblChange.TabIndex = 18;
            this.lblChange.Text = "Change";
            // 
            // txtBoxChange
            // 
            this.txtBoxChange.Location = new System.Drawing.Point(1097, 304);
            this.txtBoxChange.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxChange.Name = "txtBoxChange";
            this.txtBoxChange.Size = new System.Drawing.Size(106, 23);
            this.txtBoxChange.TabIndex = 19;
            // 
            // btnSubmitOrder
            // 
            this.btnSubmitOrder.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSubmitOrder.Location = new System.Drawing.Point(965, 403);
            this.btnSubmitOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmitOrder.Name = "btnSubmitOrder";
            this.btnSubmitOrder.Size = new System.Drawing.Size(95, 40);
            this.btnSubmitOrder.TabIndex = 20;
            this.btnSubmitOrder.Text = "Submit Order";
            this.btnSubmitOrder.UseVisualStyleBackColor = true;
            this.btnSubmitOrder.Click += new System.EventHandler(this.btnSubmitOrder_Click);
            // 
            // lblAmountPaid
            // 
            this.lblAmountPaid.AutoSize = true;
            this.lblAmountPaid.Location = new System.Drawing.Point(986, 261);
            this.lblAmountPaid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAmountPaid.Name = "lblAmountPaid";
            this.lblAmountPaid.Size = new System.Drawing.Size(77, 15);
            this.lblAmountPaid.TabIndex = 21;
            this.lblAmountPaid.Text = "Amount Paid";
            // 
            // txtBoxAmountPaid
            // 
            this.txtBoxAmountPaid.Location = new System.Drawing.Point(1097, 261);
            this.txtBoxAmountPaid.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxAmountPaid.Name = "txtBoxAmountPaid";
            this.txtBoxAmountPaid.Size = new System.Drawing.Size(106, 23);
            this.txtBoxAmountPaid.TabIndex = 22;
            this.txtBoxAmountPaid.TextChanged += new System.EventHandler(this.txtBoxAmountPaid_Enter);
            // 
            // radioButtonCash
            // 
            this.radioButtonCash.AutoSize = true;
            this.radioButtonCash.Location = new System.Drawing.Point(10, 32);
            this.radioButtonCash.Name = "radioButtonCash";
            this.radioButtonCash.Size = new System.Drawing.Size(51, 19);
            this.radioButtonCash.TabIndex = 23;
            this.radioButtonCash.TabStop = true;
            this.radioButtonCash.Text = "Cash";
            this.radioButtonCash.UseVisualStyleBackColor = true;
            this.radioButtonCash.CheckedChanged += new System.EventHandler(this.radioButtonCash_CheckedChanged);
            // 
            // radioButtonCreditCard
            // 
            this.radioButtonCreditCard.AutoSize = true;
            this.radioButtonCreditCard.Location = new System.Drawing.Point(108, 32);
            this.radioButtonCreditCard.Name = "radioButtonCreditCard";
            this.radioButtonCreditCard.Size = new System.Drawing.Size(85, 19);
            this.radioButtonCreditCard.TabIndex = 24;
            this.radioButtonCreditCard.TabStop = true;
            this.radioButtonCreditCard.Text = "Credit Card";
            this.radioButtonCreditCard.UseVisualStyleBackColor = true;
            this.radioButtonCreditCard.CheckedChanged += new System.EventHandler(this.radioButtonCreditCard_CheckedChanged);
            // 
            // btnCreateNewOrder
            // 
            this.btnCreateNewOrder.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCreateNewOrder.Location = new System.Drawing.Point(1097, 397);
            this.btnCreateNewOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateNewOrder.Name = "btnCreateNewOrder";
            this.btnCreateNewOrder.Size = new System.Drawing.Size(95, 53);
            this.btnCreateNewOrder.TabIndex = 25;
            this.btnCreateNewOrder.Text = "Create New Order";
            this.btnCreateNewOrder.UseVisualStyleBackColor = true;
            this.btnCreateNewOrder.Click += new System.EventHandler(this.btnCreateNewOrder_Click);
            // 
            // buttonCheckout
            // 
            this.buttonCheckout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCheckout.Location = new System.Drawing.Point(1021, 21);
            this.buttonCheckout.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCheckout.Name = "buttonCheckout";
            this.buttonCheckout.Size = new System.Drawing.Size(149, 47);
            this.buttonCheckout.TabIndex = 26;
            this.buttonCheckout.Text = "Checkout>>";
            this.buttonCheckout.UseVisualStyleBackColor = true;
            this.buttonCheckout.Click += new System.EventHandler(this.buttonCheckout_Click);
            // 
            // groupBoxPaymentMethod
            // 
            this.groupBoxPaymentMethod.Controls.Add(this.radioButtonCash);
            this.groupBoxPaymentMethod.Controls.Add(this.radioButtonCreditCard);
            this.groupBoxPaymentMethod.Location = new System.Drawing.Point(992, 82);
            this.groupBoxPaymentMethod.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxPaymentMethod.Name = "groupBoxPaymentMethod";
            this.groupBoxPaymentMethod.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxPaymentMethod.Size = new System.Drawing.Size(210, 76);
            this.groupBoxPaymentMethod.TabIndex = 27;
            this.groupBoxPaymentMethod.TabStop = false;
            this.groupBoxPaymentMethod.Text = "Payment Method";
            // 
            // labelPaymentMethod
            // 
            this.labelPaymentMethod.AutoSize = true;
            this.labelPaymentMethod.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPaymentMethod.Location = new System.Drawing.Point(1040, 175);
            this.labelPaymentMethod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPaymentMethod.Name = "labelPaymentMethod";
            this.labelPaymentMethod.Size = new System.Drawing.Size(103, 15);
            this.labelPaymentMethod.TabIndex = 28;
            this.labelPaymentMethod.Text = "Payment Method";
            // 
            // buttonSaveOrder
            // 
            this.buttonSaveOrder.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSaveOrder.Location = new System.Drawing.Point(965, 460);
            this.buttonSaveOrder.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSaveOrder.Name = "buttonSaveOrder";
            this.buttonSaveOrder.Size = new System.Drawing.Size(95, 40);
            this.buttonSaveOrder.TabIndex = 29;
            this.buttonSaveOrder.Text = "Save Order";
            this.buttonSaveOrder.UseVisualStyleBackColor = true;
            this.buttonSaveOrder.Click += new System.EventHandler(this.buttonSaveOrder_Click);
            // 
            // buttonOpenOrders
            // 
            this.buttonOpenOrders.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonOpenOrders.Location = new System.Drawing.Point(1085, 460);
            this.buttonOpenOrders.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpenOrders.Name = "buttonOpenOrders";
            this.buttonOpenOrders.Size = new System.Drawing.Size(117, 40);
            this.buttonOpenOrders.TabIndex = 30;
            this.buttonOpenOrders.Text = "Open Orders";
            this.buttonOpenOrders.UseVisualStyleBackColor = true;
            this.buttonOpenOrders.Click += new System.EventHandler(this.buttonOpenOrders_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 304);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 31;
            // 
            // buttonAddProducts
            // 
            this.buttonAddProducts.Location = new System.Drawing.Point(306, 323);
            this.buttonAddProducts.Name = "buttonAddProducts";
            this.buttonAddProducts.Size = new System.Drawing.Size(99, 34);
            this.buttonAddProducts.TabIndex = 32;
            this.buttonAddProducts.Text = "Add Products";
            this.buttonAddProducts.UseVisualStyleBackColor = true;
            this.buttonAddProducts.Click += new System.EventHandler(this.buttonAddProducts_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1221, 508);
            this.Controls.Add(this.buttonAddProducts);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonOpenOrders);
            this.Controls.Add(this.buttonSaveOrder);
            this.Controls.Add(this.labelPaymentMethod);
            this.Controls.Add(this.groupBoxPaymentMethod);
            this.Controls.Add(this.buttonCheckout);
            this.Controls.Add(this.btnCreateNewOrder);
            this.Controls.Add(this.txtBoxAmountPaid);
            this.Controls.Add(this.lblAmountPaid);
            this.Controls.Add(this.btnSubmitOrder);
            this.Controls.Add(this.txtBoxChange);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.txtBoxTotalPrice);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lstBoxBasket);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.lblBasket);
            this.Controls.Add(this.lstBoxItems);
            this.Controls.Add(this.lblItems);
            this.Controls.Add(this.txtBoxTime);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.txtBoxDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtBoxOrderNumber);
            this.Controls.Add(this.lblOrderNumber);
            this.Controls.Add(this.labelOrderDetails);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OrderForm";
            this.Text = "Order Form";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.groupBoxPaymentMethod.ResumeLayout(false);
            this.groupBoxPaymentMethod.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

   

        #endregion

        private Label labelOrderDetails;
        private Label lblOrderNumber;
        private TextBox txtBoxOrderNumber;
        private Label lblDate;
        private TextBox txtBoxDate;
        private Label lblTime;
        private TextBox txtBoxTime;
        private Label lblItems;
        private ListBox lstBoxItems;
        private Label lblBasket;
        private Button btnAddItem;
        private Button btnRemoveItem;
        private ListBox lstBoxBasket;
        private Label lblTotalPrice;
        private TextBox txtBoxTotalPrice;
        private Label lblChange;
        private TextBox txtBoxChange;
        private Button btnSubmitOrder;
        private Label lblAmountPaid;
        private TextBox txtBoxAmountPaid;
        private RadioButton radioButtonCash;
        private RadioButton radioButtonCreditCard;
        private Button btnCreateNewOrder;
        private Button buttonCheckout;
        private GroupBox groupBoxPaymentMethod;
        private Label labelPaymentMethod;
        private Button buttonSaveOrder;
        private Button buttonOpenOrders;
        private DateTimePicker dateTimePicker1;
        private Button buttonAddProducts;
    }
}