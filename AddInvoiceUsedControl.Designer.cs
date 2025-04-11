namespace Waterbill
{
    partial class AddInvoiceUsedControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            CustomerIDInput = new TextBox();
            CustomerNameInput = new TextBox();
            label3 = new Label();
            ThisMonthInput = new TextBox();
            label4 = new Label();
            LastMonthInput = new TextBox();
            label5 = new Label();
            label6 = new Label();
            NumberOfPeopleInput = new TextBox();
            label7 = new Label();
            Calculate = new Button();
            TypeOfCustomerInput = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            resultSubtotal = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            resultTotal = new Label();
            resultEnvFee = new Label();
            resultVATFee = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F);
            label1.Location = new Point(16, 26);
            label1.Name = "label1";
            label1.Size = new Size(266, 50);
            label1.TabIndex = 0;
            label1.Text = "Add an Invoice";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(16, 92);
            label2.Name = "label2";
            label2.Size = new Size(120, 28);
            label2.TabIndex = 1;
            label2.Text = "Customer ID";
            // 
            // CustomerIDInput
            // 
            CustomerIDInput.Location = new Point(16, 123);
            CustomerIDInput.Name = "CustomerIDInput";
            CustomerIDInput.Size = new Size(125, 27);
            CustomerIDInput.TabIndex = 2;
            // 
            // CustomerNameInput
            // 
            CustomerNameInput.Location = new Point(258, 123);
            CustomerNameInput.Name = "CustomerNameInput";
            CustomerNameInput.Size = new Size(125, 27);
            CustomerNameInput.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(238, 92);
            label3.Name = "label3";
            label3.Size = new Size(153, 28);
            label3.TabIndex = 3;
            label3.Text = "Customer Name";
            // 
            // ThisMonthInput
            // 
            ThisMonthInput.Location = new Point(16, 207);
            ThisMonthInput.Name = "ThisMonthInput";
            ThisMonthInput.Size = new Size(125, 27);
            ThisMonthInput.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(16, 176);
            label4.Name = "label4";
            label4.Size = new Size(183, 28);
            label4.TabIndex = 5;
            label4.Text = "This Month number";
            // 
            // LastMonthInput
            // 
            LastMonthInput.Location = new Point(258, 207);
            LastMonthInput.Name = "LastMonthInput";
            LastMonthInput.Size = new Size(125, 27);
            LastMonthInput.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(218, 176);
            label5.Name = "label5";
            label5.Size = new Size(183, 28);
            label5.TabIndex = 7;
            label5.Text = "Last Month number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(16, 271);
            label6.Name = "label6";
            label6.Size = new Size(165, 28);
            label6.TabIndex = 9;
            label6.Text = "Type of Customer";
            // 
            // NumberOfPeopleInput
            // 
            NumberOfPeopleInput.Location = new Point(253, 302);
            NumberOfPeopleInput.Name = "NumberOfPeopleInput";
            NumberOfPeopleInput.Size = new Size(125, 27);
            NumberOfPeopleInput.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(218, 271);
            label7.Name = "label7";
            label7.Size = new Size(173, 28);
            label7.TabIndex = 11;
            label7.Text = "Number of people";
            // 
            // Calculate
            // 
            Calculate.BackColor = Color.FromArgb(128, 255, 128);
            Calculate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Calculate.ForeColor = Color.White;
            Calculate.Location = new Point(199, 348);
            Calculate.Name = "Calculate";
            Calculate.Size = new Size(120, 43);
            Calculate.TabIndex = 13;
            Calculate.Text = "Calculate";
            Calculate.UseVisualStyleBackColor = false;
            Calculate.Click += Calculate_Click;
            // 
            // TypeOfCustomerInput
            // 
            TypeOfCustomerInput.DropDownStyle = ComboBoxStyle.DropDownList;
            TypeOfCustomerInput.FormattingEnabled = true;
            TypeOfCustomerInput.Items.AddRange(new object[] { "Household customer", "Administrative agency, public services", "Production units", "Business services" });
            TypeOfCustomerInput.Location = new Point(16, 302);
            TypeOfCustomerInput.Name = "TypeOfCustomerInput";
            TypeOfCustomerInput.Size = new Size(151, 28);
            TypeOfCustomerInput.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(38, 362);
            label8.Name = "label8";
            label8.Size = new Size(65, 20);
            label8.TabIndex = 15;
            label8.Text = "Subtotal";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(38, 407);
            label9.Name = "label9";
            label9.Size = new Size(55, 20);
            label9.TabIndex = 16;
            label9.Text = "EnvFee";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(38, 452);
            label10.Name = "label10";
            label10.Size = new Size(61, 20);
            label10.TabIndex = 18;
            label10.Text = "VAT Fee";
            // 
            // resultSubtotal
            // 
            resultSubtotal.AutoSize = true;
            resultSubtotal.Location = new Point(109, 362);
            resultSubtotal.Name = "resultSubtotal";
            resultSubtotal.Size = new Size(0, 20);
            resultSubtotal.TabIndex = 17;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(109, 407);
            label12.Name = "label12";
            label12.Size = new Size(0, 20);
            label12.TabIndex = 20;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(109, 452);
            label13.Name = "label13";
            label13.Size = new Size(0, 20);
            label13.TabIndex = 19;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(179, 419);
            label14.Name = "label14";
            label14.Size = new Size(109, 50);
            label14.TabIndex = 22;
            label14.Text = "Total";
  
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(288, 452);
            label15.Name = "label15";
            label15.Size = new Size(0, 20);
            label15.TabIndex = 21;
            // 
            // resultTotal
            // 
            resultTotal.AutoSize = true;
            resultTotal.Location = new Point(316, 443);
            resultTotal.Name = "resultTotal";
            resultTotal.Size = new Size(0, 20);
            resultTotal.TabIndex = 23;
            // 
            // resultEnvFee
            // 
            resultEnvFee.AutoSize = true;
            resultEnvFee.Location = new Point(109, 407);
            resultEnvFee.Name = "resultEnvFee";
            resultEnvFee.Size = new Size(0, 20);
            resultEnvFee.TabIndex = 24;
            // 
            // resultVATFee
            // 
            resultVATFee.AutoSize = true;
            resultVATFee.Location = new Point(109, 452);
            resultVATFee.Name = "resultVATFee";
            resultVATFee.Size = new Size(0, 20);
            resultVATFee.TabIndex = 25;
            // 
            // AddInvoiceUsedControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(resultVATFee);
            Controls.Add(resultEnvFee);
            Controls.Add(resultTotal);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label10);
            Controls.Add(resultSubtotal);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(TypeOfCustomerInput);
            Controls.Add(Calculate);
            Controls.Add(NumberOfPeopleInput);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(LastMonthInput);
            Controls.Add(label5);
            Controls.Add(ThisMonthInput);
            Controls.Add(label4);
            Controls.Add(CustomerNameInput);
            Controls.Add(label3);
            Controls.Add(CustomerIDInput);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddInvoiceUsedControl";
            Size = new Size(401, 524);

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox CustomerIDInput;
        private TextBox CustomerNameInput;
        private Label label3;
        private TextBox ThisMonthInput;
        private Label label4;
        private TextBox LastMonthInput;
        private Label label5;
        private Label label6;
        private TextBox NumberOfPeopleInput;
        private Label label7;
        private Button Calculate;
        private ComboBox TypeOfCustomerInput;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label resultSubtotal;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label resultTotal;
        private Label resultEnvFee;
        private Label resultVATFee;
    }
}
