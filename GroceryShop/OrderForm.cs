using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GroceryShop
{
    public partial class OrderForm : Form
    {





        string paymentMethod;


        public OrderForm()
        {
            InitializeComponent();
        }


        private void lstBoxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(lstBoxItems.SelectedItem.ToString());

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            int currentQuantity = 1;
            lstBoxBasket.Items.Add(new Item(((Product)lstBoxItems.SelectedItem).Id, ((Product)lstBoxItems.SelectedItem).Name, ((Product)lstBoxItems.SelectedItem).Price, currentQuantity));


        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            lstBoxBasket.Items.Remove(lstBoxBasket.SelectedItem);
        }

        private void lstBoxBasket_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            lstBoxItems.Items.Add(new Product(1, "Pack of Strawberries", "", 2.50m, 50));
            lstBoxItems.Items.Add(new Product(2, "Pack of Bananas", "", 2.50m, 50));
            lstBoxItems.Items.Add(new Product(3, "Hovis White Bread", "", 1.40m, 50));
            lstBoxItems.Items.Add(new Product(4, "Whole Milk", "", 1.65m, 50));
            lstBoxItems.Items.Add(new Product(5, "Twelve Eggs", "", 2.30m, 50));
            lstBoxItems.Items.Add(new Product(6, "Coca Cola", "", 1.95m, 50));
            lstBoxItems.Items.Add(new Product(7, "One Dairy Milk Chocolate Bar", "", 1.25m, 50));
            lstBoxItems.Items.Add(new Product(8, "Six Walkers Crisps", "", 1.75m, 50));

            radioButtonCash.Enabled = false;
            radioButtonCreditCard.Enabled = false;
            txtBoxTotalPrice.Enabled = false;
            txtBoxAmountPaid.Enabled = false;
            txtBoxChange.Enabled = false;
        }

        private void buttonCheckout_Click(object sender, EventArgs e)
        {
            radioButtonCash.Enabled = true;
            radioButtonCreditCard.Enabled = true;
            txtBoxTotalPrice.Enabled = true;
            txtBoxAmountPaid.Enabled = true;
            txtBoxChange.Enabled = true;

            decimal total = 0;

            foreach (Item item in lstBoxBasket.Items)
            {
                total = total + item.totalPrice();
            }
            txtBoxTotalPrice.Text = total.ToString();
            MessageBox.Show("Your Total is: " + total.ToString("c") + "\nThank You For Your Purchase", "THANK YOU");
        }

        private void radioButtonCash_CheckedChanged(object sender, EventArgs e)
        {
            paymentMethod = "Cash";
            labelPaymentMethod.Text = paymentMethod;
        }

        private void radioButtonCreditCard_CheckedChanged(object sender, EventArgs e)
        {
            paymentMethod = "Credit Card";
            labelPaymentMethod.Text = paymentMethod;
        }

        private void btnSubmitOrder_Click(object sender, EventArgs e)
        {
            //TODO : IF STATEMENT FOR SUBMIT BUTTON, IF CASH OR CARD BUTTON HAS BEEN SELECTED THEN ORDER CAN BE SUBMITTED

            if (radioButtonCreditCard.Checked == true || radioButtonCash.Checked == true)
            {
                MessageBox.Show("Your order has been placed successfully", "Sumbit Order");
            }
            else
                MessageBox.Show("Your order has not been placed successfully. You must select a payment method.", "Error");
        }
        private void buttonSaveOrder_Click(object sender, EventArgs e)
        {
            Boolean hasBeenPaid;
            if (radioButtonCash.Checked)
                paymentMethod = "Cash";
            if (radioButtonCreditCard.Checked)
                paymentMethod = "Credit Card";
            if (radioButtonCreditCard.Checked == false && radioButtonCash.Checked == false)
                hasBeenPaid = false;
            else hasBeenPaid = true;



            List<Item> items = new List<Item>();
            foreach (Item i in lstBoxBasket.Items)
                items.Add(i);

            Order currentOrder = new Order(Convert.ToInt32(txtBoxOrderNumber.Text), items, paymentMethod, Convert.ToDecimal(txtBoxTotalPrice.Text), Convert.ToDecimal(txtBoxAmountPaid.Text), Convert.ToDecimal(txtBoxChange.Text), dateTimePicker1.Value, hasBeenPaid);

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
                Stream stream = File.Open(FileName, FileMode.Create);
                BinaryFormatter bformatter = new BinaryFormatter();

                bformatter.Serialize(stream, currentOrder);

                stream.Close();
            }


        }

        public void txtBoxAmountPaid_Enter(object sender, EventArgs e)
        {
            if (txtBoxAmountPaid.Text != "")
            {


                decimal paid = Convert.ToDecimal(txtBoxAmountPaid.Text);
                decimal totalPrice = Convert.ToDecimal(txtBoxTotalPrice.Text);
                decimal change = paid - totalPrice;
                txtBoxChange.Text = change.ToString();
            }
        }

        private void buttonOpenOrders_Click(object sender, EventArgs e)
        {
            Order currentOrder;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
                Stream stream = File.Open(FileName, FileMode.Open);
                BinaryFormatter bformatter = new BinaryFormatter();
                if (stream.Length != 0)
                {
                    while (stream.Position != stream.Length)
                    {

                        currentOrder = (Order)bformatter.Deserialize(stream);
                        txtBoxOrderNumber.Text = currentOrder.OrderNumber.ToString();
                        dateTimePicker1.Value = currentOrder.DateTimeOfOrder;
                        lstBoxBasket.Items.Clear();
                        lstBoxBasket.Items.AddRange(currentOrder.Basket.ToArray());
                        if (currentOrder.PaymentMethod == "Cash")
                        {
                            radioButtonCash.Checked = true;
                            radioButtonCreditCard.Checked = false;
                        }
                        else if (currentOrder.PaymentMethod == "Credit Card")
                        {
                            radioButtonCreditCard.Checked= true;
                            radioButtonCash.Checked= false;
                        }
                        txtBoxTotalPrice.Text = currentOrder.TotalPrice.ToString();
                        txtBoxAmountPaid.Text = currentOrder.AmountPaid.ToString();
                        txtBoxChange.Text = currentOrder.Change.ToString();
                    }
                }
                stream.Close();

                
            }

            }

        private void btnCreateNewOrder_Click(object sender, EventArgs e)
        {
            txtBoxOrderNumber.Text = "";
            dateTimePicker1.Value= DateTime.Now;
            lstBoxBasket.Items.Clear();
            radioButtonCash.Checked=false;
            radioButtonCreditCard.Checked=false;
            txtBoxTotalPrice.Text = "";
            txtBoxAmountPaid.Text = "";
            txtBoxChange.Text = "";
            radioButtonCash.Enabled = false;
            radioButtonCreditCard.Enabled = false;
            txtBoxTotalPrice.Enabled = false;
            txtBoxAmountPaid.Enabled = false;
            txtBoxChange.Enabled = false;

        }

        private void buttonAddProducts_Click(object sender, EventArgs e)
        {
            ProductDialogForm newProductDialogForm = new ProductDialogForm();
            newProductDialogForm.ShowDialog();
            if (newProductDialogForm.DialogResult == DialogResult.OK)
            {
                lstBoxItems.Items.Add(newProductDialogForm.product);
            }
            newProductDialogForm.Close();
        }
    }
    }