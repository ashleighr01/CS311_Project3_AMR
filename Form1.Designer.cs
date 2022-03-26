namespace CS311_Project3_AMR
{
    partial class PizzaPlace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PizzaPlace));
            this.lblPizzaWork = new System.Windows.Forms.Label();
            this.pictPizza = new System.Windows.Forms.PictureBox();
            this.cboSize = new System.Windows.Forms.ComboBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblCrust = new System.Windows.Forms.Label();
            this.grpCrusts = new System.Windows.Forms.GroupBox();
            this.rdoRegular = new System.Windows.Forms.RadioButton();
            this.rdoThick = new System.Windows.Forms.RadioButton();
            this.rdoThin = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Label();
            this.grpToppings = new System.Windows.Forms.GroupBox();
            this.ckbISpiceItSausage = new System.Windows.Forms.CheckBox();
            this.ckbSausage = new System.Windows.Forms.CheckBox();
            this.ckbCanBacon = new System.Windows.Forms.CheckBox();
            this.ckbGreenPep = new System.Windows.Forms.CheckBox();
            this.ckbBananaPep = new System.Windows.Forms.CheckBox();
            this.ckbXCheese = new System.Windows.Forms.CheckBox();
            this.ckbGrOlives = new System.Windows.Forms.CheckBox();
            this.ckbMushroom = new System.Windows.Forms.CheckBox();
            this.ckbJalapeno = new System.Windows.Forms.CheckBox();
            this.ckbPepperoni = new System.Windows.Forms.CheckBox();
            this.ckbOnion = new System.Windows.Forms.CheckBox();
            this.ckbBlOlives = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOrderSum = new System.Windows.Forms.Label();
            this.rtfSummary = new System.Windows.Forms.RichTextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictPizza)).BeginInit();
            this.grpCrusts.SuspendLayout();
            this.grpToppings.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPizzaWork
            // 
            this.lblPizzaWork.AutoSize = true;
            this.lblPizzaWork.Font = new System.Drawing.Font("Verdana", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblPizzaWork.Location = new System.Drawing.Point(235, 12);
            this.lblPizzaWork.Name = "lblPizzaWork";
            this.lblPizzaWork.Size = new System.Drawing.Size(257, 48);
            this.lblPizzaWork.TabIndex = 0;
            this.lblPizzaWork.Text = "PizzaWork";
            // 
            // pictPizza
            // 
            this.pictPizza.Image = ((System.Drawing.Image)(resources.GetObject("pictPizza.Image")));
            this.pictPizza.Location = new System.Drawing.Point(527, 12);
            this.pictPizza.Name = "pictPizza";
            this.pictPizza.Size = new System.Drawing.Size(234, 145);
            this.pictPizza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictPizza.TabIndex = 1;
            this.pictPizza.TabStop = false;
            // 
            // cboSize
            // 
            this.cboSize.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.cboSize.FormattingEnabled = true;
            this.cboSize.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large",
            "X-Large",
            "Ginormous"});
            this.cboSize.Location = new System.Drawing.Point(32, 106);
            this.cboSize.Name = "cboSize";
            this.cboSize.Size = new System.Drawing.Size(182, 34);
            this.cboSize.TabIndex = 2;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Verdana", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblSize.Location = new System.Drawing.Point(32, 69);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(73, 26);
            this.lblSize.TabIndex = 3;
            this.lblSize.Text = "Size:";
            // 
            // lblCrust
            // 
            this.lblCrust.AutoSize = true;
            this.lblCrust.Font = new System.Drawing.Font("Verdana", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblCrust.Location = new System.Drawing.Point(32, 173);
            this.lblCrust.Name = "lblCrust";
            this.lblCrust.Size = new System.Drawing.Size(87, 26);
            this.lblCrust.TabIndex = 4;
            this.lblCrust.Text = "Crust:";
            // 
            // grpCrusts
            // 
            this.grpCrusts.Controls.Add(this.rdoRegular);
            this.grpCrusts.Controls.Add(this.rdoThick);
            this.grpCrusts.Controls.Add(this.rdoThin);
            this.grpCrusts.Location = new System.Drawing.Point(148, 155);
            this.grpCrusts.Name = "grpCrusts";
            this.grpCrusts.Size = new System.Drawing.Size(358, 53);
            this.grpCrusts.TabIndex = 5;
            this.grpCrusts.TabStop = false;
            //this.grpCrusts.Enter += new System.EventHandler(this.grpCrusts_Enter);
            // 
            // rdoRegular
            // 
            this.rdoRegular.AutoSize = true;
            this.rdoRegular.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.rdoRegular.Location = new System.Drawing.Point(216, 16);
            this.rdoRegular.Name = "rdoRegular";
            this.rdoRegular.Size = new System.Drawing.Size(114, 29);
            this.rdoRegular.TabIndex = 2;
            this.rdoRegular.TabStop = true;
            this.rdoRegular.Text = "Regular";
            this.rdoRegular.UseVisualStyleBackColor = true;
            // 
            // rdoThick
            // 
            this.rdoThick.AutoSize = true;
            this.rdoThick.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.rdoThick.Location = new System.Drawing.Point(101, 16);
            this.rdoThick.Name = "rdoThick";
            this.rdoThick.Size = new System.Drawing.Size(89, 29);
            this.rdoThick.TabIndex = 1;
            this.rdoThick.TabStop = true;
            this.rdoThick.Text = "Thick";
            this.rdoThick.UseVisualStyleBackColor = true;
            // 
            // rdoThin
            // 
            this.rdoThin.AutoSize = true;
            this.rdoThin.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.rdoThin.Location = new System.Drawing.Point(6, 16);
            this.rdoThin.Name = "rdoThin";
            this.rdoThin.Size = new System.Drawing.Size(80, 29);
            this.rdoThin.TabIndex = 0;
            this.rdoThin.TabStop = true;
            this.rdoThin.Text = "Thin";
            this.rdoThin.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 6;
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Font = new System.Drawing.Font("Verdana", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblToppings.Location = new System.Drawing.Point(32, 227);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(133, 26);
            this.lblToppings.TabIndex = 7;
            this.lblToppings.Text = "Toppings:";
            // 
            // grpToppings
            // 
            this.grpToppings.Controls.Add(this.ckbISpiceItSausage);
            this.grpToppings.Controls.Add(this.ckbSausage);
            this.grpToppings.Controls.Add(this.ckbCanBacon);
            this.grpToppings.Controls.Add(this.ckbGreenPep);
            this.grpToppings.Controls.Add(this.ckbBananaPep);
            this.grpToppings.Controls.Add(this.ckbXCheese);
            this.grpToppings.Controls.Add(this.ckbGrOlives);
            this.grpToppings.Controls.Add(this.ckbMushroom);
            this.grpToppings.Controls.Add(this.ckbJalapeno);
            this.grpToppings.Controls.Add(this.ckbPepperoni);
            this.grpToppings.Controls.Add(this.ckbOnion);
            this.grpToppings.Controls.Add(this.ckbBlOlives);
            this.grpToppings.Location = new System.Drawing.Point(42, 256);
            this.grpToppings.Name = "grpToppings";
            this.grpToppings.Size = new System.Drawing.Size(697, 179);
            this.grpToppings.TabIndex = 8;
            this.grpToppings.TabStop = false;
            // 
            // ckbISpiceItSausage
            // 
            this.ckbISpiceItSausage.AutoSize = true;
            this.ckbISpiceItSausage.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ckbISpiceItSausage.Location = new System.Drawing.Point(20, 59);
            this.ckbISpiceItSausage.Name = "ckbISpiceItSausage";
            this.ckbISpiceItSausage.Size = new System.Drawing.Size(230, 26);
            this.ckbISpiceItSausage.TabIndex = 11;
            this.ckbISpiceItSausage.Text = "Spicy Italian Sausage";
            this.ckbISpiceItSausage.UseVisualStyleBackColor = true;
            // 
            // ckbSausage
            // 
            this.ckbSausage.AutoSize = true;
            this.ckbSausage.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ckbSausage.Location = new System.Drawing.Point(20, 96);
            this.ckbSausage.Name = "ckbSausage";
            this.ckbSausage.Size = new System.Drawing.Size(112, 26);
            this.ckbSausage.TabIndex = 10;
            this.ckbSausage.Text = "Sausage";
            this.ckbSausage.UseVisualStyleBackColor = true;
            // 
            // ckbCanBacon
            // 
            this.ckbCanBacon.AutoSize = true;
            this.ckbCanBacon.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ckbCanBacon.Location = new System.Drawing.Point(20, 136);
            this.ckbCanBacon.Name = "ckbCanBacon";
            this.ckbCanBacon.Size = new System.Drawing.Size(180, 26);
            this.ckbCanBacon.TabIndex = 9;
            this.ckbCanBacon.Text = "Canadian Bacon";
            this.ckbCanBacon.UseVisualStyleBackColor = true;
            // 
            // ckbGreenPep
            // 
            this.ckbGreenPep.AutoSize = true;
            this.ckbGreenPep.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ckbGreenPep.Location = new System.Drawing.Point(274, 27);
            this.ckbGreenPep.Name = "ckbGreenPep";
            this.ckbGreenPep.Size = new System.Drawing.Size(160, 26);
            this.ckbGreenPep.TabIndex = 8;
            this.ckbGreenPep.Text = "Green Pepper";
            this.ckbGreenPep.UseVisualStyleBackColor = true;
            // 
            // ckbBananaPep
            // 
            this.ckbBananaPep.AutoSize = true;
            this.ckbBananaPep.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ckbBananaPep.Location = new System.Drawing.Point(274, 59);
            this.ckbBananaPep.Name = "ckbBananaPep";
            this.ckbBananaPep.Size = new System.Drawing.Size(172, 26);
            this.ckbBananaPep.TabIndex = 7;
            this.ckbBananaPep.Text = "Banana Pepper";
            this.ckbBananaPep.UseVisualStyleBackColor = true;
            // 
            // ckbXCheese
            // 
            this.ckbXCheese.AutoSize = true;
            this.ckbXCheese.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ckbXCheese.Location = new System.Drawing.Point(516, 136);
            this.ckbXCheese.Name = "ckbXCheese";
            this.ckbXCheese.Size = new System.Drawing.Size(156, 26);
            this.ckbXCheese.TabIndex = 4;
            this.ckbXCheese.Text = "Extra Cheese";
            this.ckbXCheese.UseVisualStyleBackColor = true;
            // 
            // ckbGrOlives
            // 
            this.ckbGrOlives.AutoSize = true;
            this.ckbGrOlives.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ckbGrOlives.Location = new System.Drawing.Point(516, 96);
            this.ckbGrOlives.Name = "ckbGrOlives";
            this.ckbGrOlives.Size = new System.Drawing.Size(152, 26);
            this.ckbGrOlives.TabIndex = 6;
            this.ckbGrOlives.Text = "Green Olives";
            this.ckbGrOlives.UseVisualStyleBackColor = true;
            // 
            // ckbMushroom
            // 
            this.ckbMushroom.AutoSize = true;
            this.ckbMushroom.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ckbMushroom.Location = new System.Drawing.Point(274, 136);
            this.ckbMushroom.Name = "ckbMushroom";
            this.ckbMushroom.Size = new System.Drawing.Size(130, 26);
            this.ckbMushroom.TabIndex = 5;
            this.ckbMushroom.Text = "Mushroom";
            this.ckbMushroom.UseVisualStyleBackColor = true;
            // 
            // ckbJalapeno
            // 
            this.ckbJalapeno.AutoSize = true;
            this.ckbJalapeno.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ckbJalapeno.Location = new System.Drawing.Point(274, 96);
            this.ckbJalapeno.Name = "ckbJalapeno";
            this.ckbJalapeno.Size = new System.Drawing.Size(115, 26);
            this.ckbJalapeno.TabIndex = 3;
            this.ckbJalapeno.Text = "Jalapeno";
            this.ckbJalapeno.UseVisualStyleBackColor = true;
            // 
            // ckbPepperoni
            // 
            this.ckbPepperoni.AutoSize = true;
            this.ckbPepperoni.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ckbPepperoni.Location = new System.Drawing.Point(20, 27);
            this.ckbPepperoni.Name = "ckbPepperoni";
            this.ckbPepperoni.Size = new System.Drawing.Size(126, 26);
            this.ckbPepperoni.TabIndex = 0;
            this.ckbPepperoni.Text = "Pepperoni";
            this.ckbPepperoni.UseVisualStyleBackColor = true;
            // 
            // ckbOnion
            // 
            this.ckbOnion.AutoSize = true;
            this.ckbOnion.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ckbOnion.Location = new System.Drawing.Point(516, 27);
            this.ckbOnion.Name = "ckbOnion";
            this.ckbOnion.Size = new System.Drawing.Size(88, 26);
            this.ckbOnion.TabIndex = 2;
            this.ckbOnion.Text = "Onion";
            this.ckbOnion.UseVisualStyleBackColor = true;
            // 
            // ckbBlOlives
            // 
            this.ckbBlOlives.AutoSize = true;
            this.ckbBlOlives.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ckbBlOlives.Location = new System.Drawing.Point(516, 59);
            this.ckbBlOlives.Name = "ckbBlOlives";
            this.ckbBlOlives.Size = new System.Drawing.Size(145, 26);
            this.ckbBlOlives.TabIndex = 1;
            this.ckbBlOlives.Text = "Black Olives";
            this.ckbBlOlives.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 495);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 9;
            // 
            // lblOrderSum
            // 
            this.lblOrderSum.AutoSize = true;
            this.lblOrderSum.Font = new System.Drawing.Font("Verdana", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblOrderSum.Location = new System.Drawing.Point(45, 457);
            this.lblOrderSum.Name = "lblOrderSum";
            this.lblOrderSum.Size = new System.Drawing.Size(218, 26);
            this.lblOrderSum.TabIndex = 10;
            this.lblOrderSum.Text = "Order Summary:";
            // 
            // rtfSummary
            // 
            this.rtfSummary.Location = new System.Drawing.Point(269, 470);
            this.rtfSummary.Name = "rtfSummary";
            this.rtfSummary.Size = new System.Drawing.Size(566, 174);
            this.rtfSummary.TabIndex = 11;
            this.rtfSummary.Text = "";
            // 
            // btnCalculate
            // 
            this.btnCalculate.AutoSize = true;
            this.btnCalculate.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalculate.Location = new System.Drawing.Point(316, 829);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(146, 39);
            this.btnCalculate.TabIndex = 12;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Verdana", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblSubtotal.Location = new System.Drawing.Point(62, 678);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(114, 25);
            this.lblSubtotal.TabIndex = 13;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Verdana", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblTax.Location = new System.Drawing.Point(62, 731);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(60, 25);
            this.lblTax.TabIndex = 14;
            this.lblTax.Text = "Tax:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Verdana", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(62, 778);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(77, 25);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "Total:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(197, 672);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(150, 31);
            this.txtSubtotal.TabIndex = 16;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(197, 725);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(150, 31);
            this.txtTax.TabIndex = 17;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(197, 772);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(150, 31);
            this.txtTotal.TabIndex = 18;
            // 
            // PizzaPlace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(893, 880);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.rtfSummary);
            this.Controls.Add(this.lblOrderSum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grpToppings);
            this.Controls.Add(this.lblToppings);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpCrusts);
            this.Controls.Add(this.lblCrust);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.cboSize);
            this.Controls.Add(this.pictPizza);
            this.Controls.Add(this.lblPizzaWork);
            this.Name = "PizzaPlace";
            this.Text = "PizzaWork";
            ((System.ComponentModel.ISupportInitialize)(this.pictPizza)).EndInit();
            this.grpCrusts.ResumeLayout(false);
            this.grpCrusts.PerformLayout();
            this.grpToppings.ResumeLayout(false);
            this.grpToppings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblPizzaWork;
        private PictureBox pictPizza;
        private ComboBox cboSize;
        private Label lblSize;
        private Label lblCrust;
        private GroupBox grpCrusts;
        private RadioButton rdoRegular;
        private RadioButton rdoThick;
        private RadioButton rdoThin;
        private Label label1;
        private Label lblToppings;
        private GroupBox grpToppings;
        private CheckBox ckbISpiceItSausage;
        private CheckBox ckbSausage;
        private CheckBox ckbCanBacon;
        private CheckBox ckbGreenPep;
        private CheckBox ckbBananaPep;
        private CheckBox ckbXCheese;
        private CheckBox ckbGrOlives;
        private CheckBox ckbMushroom;
        private CheckBox ckbJalapeno;
        private CheckBox ckbPepperoni;
        private CheckBox ckbOnion;
        private CheckBox ckbBlOlives;
        private Label label2;
        private Label lblOrderSum;
        private RichTextBox rtfSummary;
        private Button btnCalculate;
        private Label lblSubtotal;
        private Label lblTax;
        private Label lblTotal;
        private TextBox txtSubtotal;
        private TextBox txtTax;
        private TextBox txtTotal;
    }
}