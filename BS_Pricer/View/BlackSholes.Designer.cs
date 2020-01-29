namespace BlackSholesPricer
{
    partial class BlackSholesCalculatorForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_Price = new System.Windows.Forms.Button();
            this.textBox_callOption = new System.Windows.Forms.TextBox();
            this.textBox_putOption = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.maskedTextBox_S = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_r = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_sigma = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_K = new System.Windows.Forms.MaskedTextBox();
            this.label_StockPrice = new System.Windows.Forms.Label();
            this.label_InterestRate = new System.Windows.Forms.Label();
            this.label_Deviation = new System.Windows.Forms.Label();
            this.label_Maturity = new System.Windows.Forms.Label();
            this.label_StrikePrice = new System.Windows.Forms.Label();
            this.label_BS_Calculator = new System.Windows.Forms.Label();
            this.groupBox_Parameters = new System.Windows.Forms.GroupBox();
            this.textBox_t = new System.Windows.Forms.TextBox();
            this.groupBoxPremiums = new System.Windows.Forms.GroupBox();
            this.label_PutOption = new System.Windows.Forms.Label();
            this.label_CallOption = new System.Windows.Forms.Label();
            this.groupBox_Parameters.SuspendLayout();
            this.groupBoxPremiums.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Price
            // 
            this.button_Price.Location = new System.Drawing.Point(19, 224);
            this.button_Price.Name = "button_Price";
            this.button_Price.Size = new System.Drawing.Size(446, 29);
            this.button_Price.TabIndex = 5;
            this.button_Price.Text = "Price";
            this.button_Price.UseVisualStyleBackColor = true;
            this.button_Price.Click += new System.EventHandler(this.button_Price_Click);
            // 
            // textBox_callOption
            // 
            this.textBox_callOption.Location = new System.Drawing.Point(89, 21);
            this.textBox_callOption.Name = "textBox_callOption";
            this.textBox_callOption.ReadOnly = true;
            this.textBox_callOption.Size = new System.Drawing.Size(100, 22);
            this.textBox_callOption.TabIndex = 6;
            // 
            // textBox_putOption
            // 
            this.textBox_putOption.Location = new System.Drawing.Point(332, 21);
            this.textBox_putOption.Name = "textBox_putOption";
            this.textBox_putOption.ReadOnly = true;
            this.textBox_putOption.Size = new System.Drawing.Size(100, 22);
            this.textBox_putOption.TabIndex = 7;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // maskedTextBox_S
            // 
            this.maskedTextBox_S.Location = new System.Drawing.Point(333, 29);
            this.maskedTextBox_S.Mask = "99999.9999";
            this.maskedTextBox_S.Name = "maskedTextBox_S";
            this.maskedTextBox_S.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox_S.TabIndex = 8;
            // 
            // maskedTextBox_r
            // 
            this.maskedTextBox_r.Location = new System.Drawing.Point(333, 141);
            this.maskedTextBox_r.Mask = "99999.9999";
            this.maskedTextBox_r.Name = "maskedTextBox_r";
            this.maskedTextBox_r.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox_r.TabIndex = 9;
            // 
            // maskedTextBox_sigma
            // 
            this.maskedTextBox_sigma.Location = new System.Drawing.Point(333, 113);
            this.maskedTextBox_sigma.Mask = "99999.9999";
            this.maskedTextBox_sigma.Name = "maskedTextBox_sigma";
            this.maskedTextBox_sigma.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox_sigma.TabIndex = 10;
            // 
            // maskedTextBox_K
            // 
            this.maskedTextBox_K.Location = new System.Drawing.Point(333, 57);
            this.maskedTextBox_K.Mask = "99999.9999";
            this.maskedTextBox_K.Name = "maskedTextBox_K";
            this.maskedTextBox_K.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox_K.TabIndex = 12;
            // 
            // label_StockPrice
            // 
            this.label_StockPrice.AutoSize = true;
            this.label_StockPrice.Location = new System.Drawing.Point(6, 32);
            this.label_StockPrice.Name = "label_StockPrice";
            this.label_StockPrice.Size = new System.Drawing.Size(79, 17);
            this.label_StockPrice.TabIndex = 13;
            this.label_StockPrice.Text = "Stock Price";
            // 
            // label_InterestRate
            // 
            this.label_InterestRate.AutoSize = true;
            this.label_InterestRate.Location = new System.Drawing.Point(5, 144);
            this.label_InterestRate.Name = "label_InterestRate";
            this.label_InterestRate.Size = new System.Drawing.Size(145, 17);
            this.label_InterestRate.TabIndex = 14;
            this.label_InterestRate.Text = "Risk-free interest rate";
            // 
            // label_Deviation
            // 
            this.label_Deviation.AutoSize = true;
            this.label_Deviation.Location = new System.Drawing.Point(5, 116);
            this.label_Deviation.Name = "label_Deviation";
            this.label_Deviation.Size = new System.Drawing.Size(250, 17);
            this.label_Deviation.TabIndex = 15;
            this.label_Deviation.Text = "Standard deviation of underlying stock";
            // 
            // label_Maturity
            // 
            this.label_Maturity.AutoSize = true;
            this.label_Maturity.Location = new System.Drawing.Point(5, 88);
            this.label_Maturity.Name = "label_Maturity";
            this.label_Maturity.Size = new System.Drawing.Size(163, 17);
            this.label_Maturity.TabIndex = 16;
            this.label_Maturity.Text = "Time to maturity in years";
            // 
            // label_StrikePrice
            // 
            this.label_StrikePrice.AutoSize = true;
            this.label_StrikePrice.Location = new System.Drawing.Point(6, 60);
            this.label_StrikePrice.Name = "label_StrikePrice";
            this.label_StrikePrice.Size = new System.Drawing.Size(80, 17);
            this.label_StrikePrice.TabIndex = 17;
            this.label_StrikePrice.Text = "Strike Price";
            // 
            // label_BS_Calculator
            // 
            this.label_BS_Calculator.AutoSize = true;
            this.label_BS_Calculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_BS_Calculator.Location = new System.Drawing.Point(36, 9);
            this.label_BS_Calculator.Name = "label_BS_Calculator";
            this.label_BS_Calculator.Size = new System.Drawing.Size(407, 29);
            this.label_BS_Calculator.TabIndex = 18;
            this.label_BS_Calculator.Text = "Black Scholes Option Calculator";
            // 
            // groupBox_Parameters
            // 
            this.groupBox_Parameters.Controls.Add(this.textBox_t);
            this.groupBox_Parameters.Controls.Add(this.label_StockPrice);
            this.groupBox_Parameters.Controls.Add(this.maskedTextBox_S);
            this.groupBox_Parameters.Controls.Add(this.label_StrikePrice);
            this.groupBox_Parameters.Controls.Add(this.maskedTextBox_r);
            this.groupBox_Parameters.Controls.Add(this.label_Maturity);
            this.groupBox_Parameters.Controls.Add(this.maskedTextBox_sigma);
            this.groupBox_Parameters.Controls.Add(this.label_Deviation);
            this.groupBox_Parameters.Controls.Add(this.label_InterestRate);
            this.groupBox_Parameters.Controls.Add(this.maskedTextBox_K);
            this.groupBox_Parameters.Location = new System.Drawing.Point(20, 41);
            this.groupBox_Parameters.Name = "groupBox_Parameters";
            this.groupBox_Parameters.Size = new System.Drawing.Size(445, 177);
            this.groupBox_Parameters.TabIndex = 19;
            this.groupBox_Parameters.TabStop = false;
            this.groupBox_Parameters.Text = "Parameters";
            // 
            // textBox_t
            // 
            this.textBox_t.Location = new System.Drawing.Point(333, 85);
            this.textBox_t.Name = "textBox_t";
            this.textBox_t.Size = new System.Drawing.Size(100, 22);
            this.textBox_t.TabIndex = 18;
            this.textBox_t.Enter += new System.EventHandler(this.textBox_t_Enter);
            // 
            // groupBoxPremiums
            // 
            this.groupBoxPremiums.Controls.Add(this.label_PutOption);
            this.groupBoxPremiums.Controls.Add(this.label_CallOption);
            this.groupBoxPremiums.Controls.Add(this.textBox_callOption);
            this.groupBoxPremiums.Controls.Add(this.textBox_putOption);
            this.groupBoxPremiums.Location = new System.Drawing.Point(22, 259);
            this.groupBoxPremiums.Name = "groupBoxPremiums";
            this.groupBoxPremiums.Size = new System.Drawing.Size(444, 56);
            this.groupBoxPremiums.TabIndex = 20;
            this.groupBoxPremiums.TabStop = false;
            this.groupBoxPremiums.Text = "Premiums";
            // 
            // label_PutOption
            // 
            this.label_PutOption.AutoSize = true;
            this.label_PutOption.Location = new System.Drawing.Point(241, 24);
            this.label_PutOption.Name = "label_PutOption";
            this.label_PutOption.Size = new System.Drawing.Size(75, 17);
            this.label_PutOption.TabIndex = 9;
            this.label_PutOption.Text = "Put Option";
            // 
            // label_CallOption
            // 
            this.label_CallOption.AutoSize = true;
            this.label_CallOption.Location = new System.Drawing.Point(6, 24);
            this.label_CallOption.Name = "label_CallOption";
            this.label_CallOption.Size = new System.Drawing.Size(77, 17);
            this.label_CallOption.TabIndex = 8;
            this.label_CallOption.Text = "Call Option";
            // 
            // BlackSholesCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 323);
            this.Controls.Add(this.groupBoxPremiums);
            this.Controls.Add(this.groupBox_Parameters);
            this.Controls.Add(this.label_BS_Calculator);
            this.Controls.Add(this.button_Price);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BlackSholesCalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BNP Paribas Coding Assignment";
            this.groupBox_Parameters.ResumeLayout(false);
            this.groupBox_Parameters.PerformLayout();
            this.groupBoxPremiums.ResumeLayout(false);
            this.groupBoxPremiums.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_Price;
        private System.Windows.Forms.TextBox textBox_callOption;
        private System.Windows.Forms.TextBox textBox_putOption;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_S;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_r;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_sigma;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_K;
        private System.Windows.Forms.Label label_StockPrice;
        private System.Windows.Forms.Label label_InterestRate;
        private System.Windows.Forms.Label label_Deviation;
        private System.Windows.Forms.Label label_Maturity;
        private System.Windows.Forms.Label label_StrikePrice;
        private System.Windows.Forms.Label label_BS_Calculator;
        private System.Windows.Forms.GroupBox groupBox_Parameters;
        private System.Windows.Forms.GroupBox groupBoxPremiums;
        private System.Windows.Forms.Label label_PutOption;
        private System.Windows.Forms.Label label_CallOption;
        private System.Windows.Forms.TextBox textBox_t;
    }
}

