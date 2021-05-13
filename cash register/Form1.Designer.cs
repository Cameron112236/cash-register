
namespace cash_register
{
    partial class register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(register));
            this.title = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.Label();
            this.vanillaNumber = new System.Windows.Forms.TextBox();
            this.swirlNumber = new System.Windows.Forms.TextBox();
            this.chocolateNumber = new System.Windows.Forms.TextBox();
            this.amountLabel = new System.Windows.Forms.Label();
            this.Calculate = new System.Windows.Forms.Button();
            this.totals = new System.Windows.Forms.Label();
            this.Calculated = new System.Windows.Forms.Label();
            this.change = new System.Windows.Forms.Button();
            this.changeAmount = new System.Windows.Forms.Label();
            this.tenderedAmount = new System.Windows.Forms.TextBox();
            this.changeGiven = new System.Windows.Forms.Label();
            this.createReceipt = new System.Windows.Forms.Button();
            this.recite = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Brown;
            this.title.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(-3, -5);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(807, 39);
            this.title.TabIndex = 0;
            this.title.Text = "Fast Delivery";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Menu
            // 
            this.Menu.AllowDrop = true;
            this.Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.Location = new System.Drawing.Point(12, 50);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(89, 224);
            this.Menu.TabIndex = 1;
            this.Menu.Text = "Ice cream cones:\r\n\r\nVanilla $1.29 each\r\n\r\nChocolate $1.29 each\r\n\r\nSwirl $2.00 eac" +
    "h\r\n\r\n\r\n\r\n";
            // 
            // vanillaNumber
            // 
            this.vanillaNumber.Location = new System.Drawing.Point(135, 118);
            this.vanillaNumber.Name = "vanillaNumber";
            this.vanillaNumber.Size = new System.Drawing.Size(27, 20);
            this.vanillaNumber.TabIndex = 2;
            this.vanillaNumber.Text = "0";
            // 
            // swirlNumber
            // 
            this.swirlNumber.Location = new System.Drawing.Point(135, 239);
            this.swirlNumber.Name = "swirlNumber";
            this.swirlNumber.Size = new System.Drawing.Size(27, 20);
            this.swirlNumber.TabIndex = 3;
            this.swirlNumber.Text = "0";
            // 
            // chocolateNumber
            // 
            this.chocolateNumber.Location = new System.Drawing.Point(135, 181);
            this.chocolateNumber.Name = "chocolateNumber";
            this.chocolateNumber.Size = new System.Drawing.Size(27, 20);
            this.chocolateNumber.TabIndex = 4;
            this.chocolateNumber.Text = "0";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountLabel.Location = new System.Drawing.Point(107, 70);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(73, 20);
            this.amountLabel.TabIndex = 5;
            this.amountLabel.Text = "Amount: ";
            // 
            // Calculate
            // 
            this.Calculate.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculate.Location = new System.Drawing.Point(16, 277);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(146, 44);
            this.Calculate.TabIndex = 6;
            this.Calculate.Text = "Calculate Total";
            this.Calculate.UseVisualStyleBackColor = false;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // totals
            // 
            this.totals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totals.Location = new System.Drawing.Point(222, 70);
            this.totals.Name = "totals";
            this.totals.Size = new System.Drawing.Size(100, 174);
            this.totals.TabIndex = 7;
            this.totals.Text = "Subtotal:\r\n\r\nTax:\r\n\r\nTotal:\r\n\r\nTendered:";
            // 
            // Calculated
            // 
            this.Calculated.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculated.Location = new System.Drawing.Point(382, 70);
            this.Calculated.Name = "Calculated";
            this.Calculated.Size = new System.Drawing.Size(100, 147);
            this.Calculated.TabIndex = 8;
            this.Calculated.Text = "$0\r\n\r\n$0\r\n\r\n$0";
            // 
            // change
            // 
            this.change.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.change.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.change.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change.Location = new System.Drawing.Point(194, 277);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(146, 44);
            this.change.TabIndex = 9;
            this.change.Text = "Calculate Change";
            this.change.UseVisualStyleBackColor = false;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // changeAmount
            // 
            this.changeAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeAmount.Location = new System.Drawing.Point(222, 244);
            this.changeAmount.Name = "changeAmount";
            this.changeAmount.Size = new System.Drawing.Size(100, 23);
            this.changeAmount.TabIndex = 10;
            this.changeAmount.Text = "Change:";
            // 
            // tenderedAmount
            // 
            this.tenderedAmount.Location = new System.Drawing.Point(385, 197);
            this.tenderedAmount.Multiline = true;
            this.tenderedAmount.Name = "tenderedAmount";
            this.tenderedAmount.Size = new System.Drawing.Size(109, 20);
            this.tenderedAmount.TabIndex = 11;
            this.tenderedAmount.Text = "0";
            // 
            // changeGiven
            // 
            this.changeGiven.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeGiven.Location = new System.Drawing.Point(382, 244);
            this.changeGiven.Name = "changeGiven";
            this.changeGiven.Size = new System.Drawing.Size(100, 23);
            this.changeGiven.TabIndex = 12;
            this.changeGiven.Text = "$0";
            // 
            // createReceipt
            // 
            this.createReceipt.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.createReceipt.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.createReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createReceipt.Location = new System.Drawing.Point(375, 277);
            this.createReceipt.Name = "createReceipt";
            this.createReceipt.Size = new System.Drawing.Size(146, 44);
            this.createReceipt.TabIndex = 13;
            this.createReceipt.Text = "Print Receipt";
            this.createReceipt.UseVisualStyleBackColor = false;
            this.createReceipt.Click += new System.EventHandler(this.createReceipt_Click);
            // 
            // recite
            // 
            this.recite.BackColor = System.Drawing.Color.White;
            this.recite.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recite.Location = new System.Drawing.Point(560, 55);
            this.recite.Name = "recite";
            this.recite.Size = new System.Drawing.Size(218, 266);
            this.recite.TabIndex = 18;
            this.recite.Click += new System.EventHandler(this.recite14_Click);
            // 
            // reset
            // 
            this.reset.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.reset.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.Location = new System.Drawing.Point(75, 327);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(419, 55);
            this.reset.TabIndex = 19;
            this.reset.Text = "New Order";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // register
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 399);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.recite);
            this.Controls.Add(this.createReceipt);
            this.Controls.Add(this.changeGiven);
            this.Controls.Add(this.tenderedAmount);
            this.Controls.Add(this.changeAmount);
            this.Controls.Add(this.change);
            this.Controls.Add(this.Calculated);
            this.Controls.Add(this.totals);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.chocolateNumber);
            this.Controls.Add(this.swirlNumber);
            this.Controls.Add(this.vanillaNumber);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "register";
            this.Text = "Cash Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label Menu;
        private System.Windows.Forms.TextBox vanillaNumber;
        private System.Windows.Forms.TextBox swirlNumber;
        private System.Windows.Forms.TextBox chocolateNumber;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Label totals;
        private System.Windows.Forms.Label Calculated;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.Label changeAmount;
        private System.Windows.Forms.TextBox tenderedAmount;
        private System.Windows.Forms.Label changeGiven;
        private System.Windows.Forms.Button createReceipt;
        private System.Windows.Forms.Label recite;
        private System.Windows.Forms.Button reset;
    }
}

