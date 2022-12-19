namespace FastFoodRestaurant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
        }

        private void FriesCb_CheckedChanged(object sender, EventArgs e)
        {
            if (FriesCb.Checked == true)
            {
                FriesTb.Enabled = true;
            }
            else if (FriesCb.Checked == false)
            {
                FriesTb.Enabled = false;
                FriesTb.Text = "0";
            }
        }

        private void BurgerCb_CheckedChanged(object sender, EventArgs e)
        {
            if (BurgerCb.Checked == true)
            {
                BurgerTb.Enabled = true;
            }
            else if (BurgerCb.Checked == false)
            {
                BurgerTb.Enabled = false;
                BurgerTb.Text = "0";
            }
        }

        private void PizzaCb_CheckedChanged(object sender, EventArgs e)
        {
            if (PizzaCb.Checked == true)
            {
                PizzaTb.Enabled = true;
            }
            else if (PizzaCb.Checked == false)
            {
                PizzaTb.Enabled = false;
                PizzaTb.Text = "0";
            }
        }

        private void SandwichCb_CheckedChanged(object sender, EventArgs e)
        {
            if (SandwichCb.Checked == true)
            {
                SandwichTb.Enabled = true;
            }
            else if (SandwichCb.Checked == false)
            {
                SandwichTb.Enabled = false;
                SandwichTb.Text = "0";
            }
        }

        private void ChickenCb_CheckedChanged(object sender, EventArgs e)
        {
            if (ChickenCb.Checked == true)
            {
                ChickenTb.Enabled = true;
            }
            else if (ChickenCb.Checked == false)
            {
                ChickenTb.Enabled = false;
                ChickenTb.Text = "0";
            }
        }

        private void SaladCb_CheckedChanged(object sender, EventArgs e)
        {
            if (SaladCb.Checked == true)
            {
                SaladTb.Enabled = true;
            }
            else if (SaladCb.Checked == false)
            {
                SaladTb.Enabled = false;
                SaladTb.Text = "0";
            }
        }

        private void ColaCb_CheckedChanged(object sender, EventArgs e)
        {
            if (ColaCb.Checked == true)
            {
                ColaTb.Enabled = true;
            }
            else if (ColaCb.Checked == false)
            {
                ColaTb.Enabled = false;
                ColaTb.Text = "0";
            }
        }

        private void IceTeaCb_CheckedChanged(object sender, EventArgs e)
        {
            if (IceTeaCb.Checked == true)
            {
                IceTeaTb.Enabled = true;
            }
            else if (IceTeaCb.Checked == false)
            {
                IceTeaTb.Enabled = false;
                IceTeaTb.Text = "0";
            }
        }

        private void WaterCb_CheckedChanged(object sender, EventArgs e)
        {
            if (WaterCb.Checked == true)
            {
                WaterTb.Enabled = true;
            }
            else if (WaterCb.Checked == false)
            {
                WaterTb.Enabled = false;
                WaterTb.Text = "0";
            }
        }

        private void PancakesCb_CheckedChanged(object sender, EventArgs e)
        {
            if (PancakesCb.Checked == true)
            {
                PancakesTb.Enabled = true;
            }
            else if (PancakesCb.Checked == false)
            {
                PancakesTb.Enabled = false;
                PancakesTb.Text = "0";
            }
        }

        private void MagnoliaCb_CheckedChanged(object sender, EventArgs e)
        {
            if (MagnoliaCb.Checked == true)
            {
                MagnoliaTb.Enabled = true;
            }
            else if (MagnoliaCb.Checked == false)
            {
                MagnoliaTb.Enabled = false;
                MagnoliaTb.Text = "0";
            }
        }

        private void BaklavaCb_CheckedChanged(object sender, EventArgs e)
        {
            if (BaklavaCb.Checked == true)
            {
                BaklavaTb.Enabled = true;
            }
            else if (BaklavaCb.Checked == false)
            {
                BaklavaTb.Enabled = false;
                BaklavaTb.Text = "0";
            }
        }

        private void Exitlbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        //Declare unit price to meals and drinks
        double colaUp = 15, iceteaUp = 10, waterUp = 5, pancakesUp = 50, magnoliaUp = 55, baklavaUp = 60;

        //Declare variable to hold total price for each meals and drinks
        double friesTp, burgerTp, pizzaTp, sandwichTp, chickenTp, saladTp, colaTp, iceteaTp, waterTp, pancakesTp, magnoliaTp, baklavaTp;

        double Subtotal = 0, tax, total;

        double friesUp = 25, burgerUp = 90, pizzaUp = 130, sandwichUp = 25, chickenUp = 110, saladUp = 40;

        private void button4_Click(object sender, EventArgs e)
        {
            friesTp = friesUp * Convert.ToDouble(FriesTb.Text);
            burgerTp = burgerUp * Convert.ToDouble(BurgerTb.Text);
            pizzaTp = pizzaUp * Convert.ToDouble(PizzaTb.Text);
            sandwichTp = sandwichUp * Convert.ToDouble(SandwichTb.Text);
            chickenTp = chickenUp * Convert.ToDouble(ChickenTb.Text);
            saladTp = saladUp * Convert.ToDouble(SaladTb.Text);
            colaTp = colaUp * Convert.ToDouble(ColaTb.Text);
            iceteaTp = iceteaUp * Convert.ToDouble(IceTeaTb.Text);
            waterTp = waterUp * Convert.ToDouble(WaterTb.Text);
            pancakesTp = pancakesUp * Convert.ToDouble(PancakesTb.Text);
            magnoliaTp = magnoliaUp * Convert.ToDouble(MagnoliaTb.Text);
            baklavaTp = baklavaUp * Convert.ToDouble(BaklavaTb.Text);

            //Add Products on the Receipt
            ReceiptTb.Clear();
            Subtotal = 0;
            ReceiptTb.AppendText(Environment.NewLine);
            ReceiptTb.AppendText("\tSNACK GARDEN\n\t" + Datelbl.Text + Environment.NewLine);
            ReceiptTb.AppendText("\t**********************************************" + Environment.NewLine);
            if (FriesCb.Checked == true)
            {
                ReceiptTb.AppendText("\tFries: " + friesTp + "TL" + Environment.NewLine);
                Subtotal = Subtotal + friesTp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (BurgerCb.Checked == true)
            {
                ReceiptTb.AppendText("\tBurger: " + burgerTp + "TL" + Environment.NewLine);
                Subtotal = Subtotal + burgerTp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (PizzaCb.Checked == true)
            {
                ReceiptTb.AppendText("\tPizza: " + pizzaTp + "TL" + Environment.NewLine);
                Subtotal = Subtotal + pizzaTp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (SandwichCb.Checked == true)
            {
                ReceiptTb.AppendText("\tSandwich: " + sandwichTp + "TL" + Environment.NewLine);
                Subtotal = Subtotal + sandwichTp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (ChickenCb.Checked == true)
            {
                ReceiptTb.AppendText("\tChicken: " + chickenTp + "TL" + Environment.NewLine);
                Subtotal = Subtotal + chickenTp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (SaladCb.Checked == true)
            {
                ReceiptTb.AppendText("\tSalad: " + saladTp + "TL" + Environment.NewLine);
                Subtotal = Subtotal + saladTp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (ColaCb.Checked == true)
            {
                ReceiptTb.AppendText("\tCola: " + colaTp + "TL" + Environment.NewLine);
                Subtotal = Subtotal + colaTp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (IceTeaCb.Checked == true)
            {
                ReceiptTb.AppendText("\tIce Tea: " + iceteaTp + "TL" + Environment.NewLine);
                Subtotal = Subtotal + iceteaTp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (WaterCb.Checked == true)
            {
                ReceiptTb.AppendText("\tWater: " + waterTp + "TL" + Environment.NewLine);
                Subtotal = Subtotal + waterTp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (PancakesCb.Checked == true)
            {
                ReceiptTb.AppendText("\tPancakes: " + pancakesTp + "TL" + Environment.NewLine);
                Subtotal = Subtotal + pancakesTp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (MagnoliaCb.Checked == true)
            {
                ReceiptTb.AppendText("\tMagnolia: " + magnoliaTp + "TL" + Environment.NewLine);
                Subtotal = Subtotal + magnoliaTp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (BaklavaCb.Checked == true)
            {
                ReceiptTb.AppendText("\tBaklava: " + baklavaTp + "TL" + Environment.NewLine);
                Subtotal = Subtotal + baklavaTp;
                Subtotallbl.Text = "" + Subtotal;
            }

            tax = Subtotal * 0.18; //18% kdv
            total = Subtotal + tax ;
            Subtotallbl.Text = Subtotal + " TL";
            taxlbl.Text = tax + " TL";
            totallbl.Text = total + " TL";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FriesCb.Checked = false;
            BurgerCb.Checked = false;
            PizzaCb.Checked = false;
            SandwichCb.Checked = false;
            ChickenCb.Checked = false;
            SaladCb.Checked = false;
            ColaCb.Checked = false;
            IceTeaCb.Checked = false;
            WaterCb.Checked = false;
            PancakesCb.Checked = false;
            MagnoliaCb.Checked = false;
            BaklavaCb.Checked = false;
            ReceiptTb.Clear();
            Subtotallbl.Text = Convert.ToString(0);
            taxlbl.Text = Convert.ToString(0);
            totallbl.Text = Convert.ToString(0);

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(ReceiptTb.Text + "\nSubtotal: " + Subtotallbl.Text + "\nTax: " + taxlbl.Text + "\nTotal: " + totallbl.Text, new Font("Century Gothic",16,FontStyle.Regular), Brushes.Black, new Point(130));
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void ReceiptTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}