namespace CS311_Project3_AMR
{
    public partial class PizzaPlace : Form
    {
        public PizzaPlace()
        {
            InitializeComponent();
        } //end PizzaPlace

        /**
         * Method used to track prices of sizes and toppings,
         * as well as print the subtotal, tax, and final total of
         * pizza orders and print the summary of the pizza order.
         */
        private void Summarize()
        {   

            string size = cboSize.Text;
            double sizePrice = 0.00;
            string crust = "";
            double toppingsPrice = 0.00;
            
            /*
             * Switch statement to dictate the price of
             * pizza sizes and assign it to variable
             * sizePrice.
             */
            switch (size)
            {
                case "Small":
                    sizePrice = 2.00;
                    break;
                case "Medium":
                    sizePrice = 5.00;
                    break;
                case "Large":
                    sizePrice = 10.00;
                    break;
                case "X-Large":
                    sizePrice = 15.00;
                    break;
                case "Ginormous":
                    sizePrice = 20.00;
                    break;
            } //end switch
         
            /*
             * If-else if-else if statement used to determine
             * which pizza crust was selected that will be printed
             */
            if (rdoThin.Checked == true)
            {
                crust = rdoThin.Text;
            }
            else if (rdoThick.Checked == true)
            {
                crust = rdoThick.Text;
            }
            else if (rdoRegular.Checked == true)
            {
                crust = rdoRegular.Text;
            } //end if-else if-else if statements

            string Summary = "You ordered a " + size + " pizza with " + crust + " crust and the following toppings:\n";
            rtfSummary.Text = Summary;

            /*
             * for loop used to iterate through the entire toppings list, 
             * add prices of selected toppings and print out each selected
             * topping.
             */ 
            for (int i = 0; i < 1; i++)
            {
                if (ckbPepperoni.Checked == true)
                {
                    toppingsPrice += 2.00;
                    rtfSummary.Text += "\u2022Pepperoni\n";
                }

                if (ckbSausage.Checked == true)
                {
                    toppingsPrice += 2.00;
                    rtfSummary.Text += "\u2022Sausage\n";
                }

                if (ckbISpiceItSausage.Checked == true)
                {
                    toppingsPrice += 2.00;
                    rtfSummary.Text += "\u2022Spicy Italian Sausage\n";
                }

                if (ckbCanBacon.Checked == true)
                {
                    toppingsPrice += 2.00;
                    rtfSummary.Text += "\u2022Canadian Bacon\n";
                }

                if (ckbGreenPep.Checked == true)
                {
                    toppingsPrice += 1.00;
                    rtfSummary.Text += "\u2022Green Peppers\n";
                }

                if (ckbBananaPep.Checked == true)
                {
                    toppingsPrice += 1.00;
                    rtfSummary.Text += "\u2022Banana Peppers\n";
                }

                if (ckbJalapeno.Checked == true)
                {
                    toppingsPrice += 1.00;
                    rtfSummary.Text += "\u2022Jalapenos\n";
                }

                if (ckbMushroom.Checked == true)
                {
                    toppingsPrice += 1.00;
                    rtfSummary.Text += "\u2022Mushrooms\n";
                }

                if (ckbOnion.Checked == true)
                {
                    toppingsPrice += 1.00;
                    rtfSummary.Text += "\u2022Onions\n";
                }

                if (ckbGrOlives.Checked == true)
                {
                    toppingsPrice += 1.00;
                    rtfSummary.Text += "\u2022Green Olives\n";
                }

                if (ckbBlOlives.Checked == true)
                {
                    toppingsPrice += 1.00;
                    rtfSummary.Text += "\u2022Black Olives\n";
                }

                if (ckbXCheese.Checked == true)
                {
                    toppingsPrice += 1.00;
                    rtfSummary.Text += "\u2022Extra Cheese\n";
                }
            } //end for loop
            

            double subTotal = sizePrice + toppingsPrice;
            txtSubtotal.Text = subTotal.ToString("C");

            double taxes = subTotal * 0.06;
            txtTax.Text = taxes.ToString("C");

            double total = taxes + subTotal;
            txtTotal.Text = total.ToString("C");

        } //end Summarize

        /*
         * Method used for the user to click the "Calculate"
         * button and allows the summarize method to be implemented.
         */
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Summarize();
        } //btnCalculate_Click
    } //PizzaPlace: Form
} //end namespace