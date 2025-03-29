namespace Waterbill
{
    partial class Form1
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            ExitInvoiceMenuButton = new Button();
            ManageInvoicesMenuButton = new Button();
            AddInvoiceMenuButton = new Button();
            addInvoiceUsedControl = new AddInvoiceUsedControl();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(ExitInvoiceMenuButton);
            panel1.Controls.Add(ManageInvoicesMenuButton);
            panel1.Controls.Add(AddInvoiceMenuButton);
            panel1.Location = new Point(3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(246, 576);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_2025_03_28_125104;
            pictureBox1.Location = new Point(27, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(185, 184);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // ExitInvoiceMenuButton
            // 
            ExitInvoiceMenuButton.Location = new Point(0, 531);
            ExitInvoiceMenuButton.Name = "ExitInvoiceMenuButton";
            ExitInvoiceMenuButton.Size = new Size(246, 42);
            ExitInvoiceMenuButton.TabIndex = 2;
            ExitInvoiceMenuButton.Text = "Exit";
            ExitInvoiceMenuButton.UseVisualStyleBackColor = true;
            // 
            // ManageInvoicesMenuButton
            // 
            ManageInvoicesMenuButton.Location = new Point(0, 245);
            ManageInvoicesMenuButton.Name = "ManageInvoicesMenuButton";
            ManageInvoicesMenuButton.Size = new Size(246, 50);
            ManageInvoicesMenuButton.TabIndex = 1;
            ManageInvoicesMenuButton.Text = "Manage Invoices";
            ManageInvoicesMenuButton.UseVisualStyleBackColor = true;
            // 
            // AddInvoiceMenuButton
            // 
            AddInvoiceMenuButton.Location = new Point(0, 190);
            AddInvoiceMenuButton.Name = "AddInvoiceMenuButton";
            AddInvoiceMenuButton.Size = new Size(246, 49);
            AddInvoiceMenuButton.TabIndex = 0;
            AddInvoiceMenuButton.Text = "Add Invoice";
            AddInvoiceMenuButton.UseVisualStyleBackColor = true;
            AddInvoiceMenuButton.Click += AddInvoiceMenuButton_Click;
            // 
            // addInvoiceUsedControl
            // 
            addInvoiceUsedControl.Location = new Point(354, 33);
            addInvoiceUsedControl.Name = "addInvoiceUsedControl";
            addInvoiceUsedControl.Size = new Size(411, 459);
            addInvoiceUsedControl.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2025_03_28_125400;
            ClientSize = new Size(943, 575);
            Controls.Add(addInvoiceUsedControl);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button ManageInvoicesMenuButton;
        private Button AddInvoiceMenuButton;
        private Button ExitInvoiceMenuButton;
        private PictureBox pictureBox1;
        private AddInvoiceUsedControl addInvoiceUsedControl;
    }
}
