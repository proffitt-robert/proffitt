
namespace VendoMatic
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_InsertBills = new System.Windows.Forms.Label();
            this.btn_1Dollar = new System.Windows.Forms.Button();
            this.btn_2dollar = new System.Windows.Forms.Button();
            this.btn_5dollar = new System.Windows.Forms.Button();
            this.btn_10dollar = new System.Windows.Forms.Button();
            this.btn_getChange = new System.Windows.Forms.Button();
            this.lbl_itemPrice = new System.Windows.Forms.Label();
            this.lbl_itemQuantity = new System.Windows.Forms.Label();
            this.lbl_Balance = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.lbl_itemName = new System.Windows.Forms.Label();
            this.btn_createSalesReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VendoMatic.Properties.Resources.cooltext377489643981791;
            this.pictureBox1.Location = new System.Drawing.Point(212, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(812, 83);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_InsertBills
            // 
            this.lbl_InsertBills.AutoSize = true;
            this.lbl_InsertBills.BackColor = System.Drawing.Color.Green;
            this.lbl_InsertBills.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_InsertBills.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InsertBills.Location = new System.Drawing.Point(837, 268);
            this.lbl_InsertBills.Name = "lbl_InsertBills";
            this.lbl_InsertBills.Size = new System.Drawing.Size(160, 22);
            this.lbl_InsertBills.TabIndex = 2;
            this.lbl_InsertBills.Text = "Insert Bills Below";
            // 
            // btn_1Dollar
            // 
            this.btn_1Dollar.BackColor = System.Drawing.Color.Green;
            this.btn_1Dollar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1Dollar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_1Dollar.Location = new System.Drawing.Point(847, 299);
            this.btn_1Dollar.Name = "btn_1Dollar";
            this.btn_1Dollar.Size = new System.Drawing.Size(70, 52);
            this.btn_1Dollar.TabIndex = 3;
            this.btn_1Dollar.Text = "$1";
            this.btn_1Dollar.UseVisualStyleBackColor = false;
            this.btn_1Dollar.Click += new System.EventHandler(this.btn_1Dollar_Click);
            // 
            // btn_2dollar
            // 
            this.btn_2dollar.BackColor = System.Drawing.Color.Green;
            this.btn_2dollar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2dollar.Location = new System.Drawing.Point(937, 299);
            this.btn_2dollar.Name = "btn_2dollar";
            this.btn_2dollar.Size = new System.Drawing.Size(70, 52);
            this.btn_2dollar.TabIndex = 4;
            this.btn_2dollar.Text = "$2";
            this.btn_2dollar.UseVisualStyleBackColor = false;
            this.btn_2dollar.Click += new System.EventHandler(this.btn_2dollar_Click);
            // 
            // btn_5dollar
            // 
            this.btn_5dollar.BackColor = System.Drawing.Color.Green;
            this.btn_5dollar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_5dollar.Location = new System.Drawing.Point(847, 357);
            this.btn_5dollar.Name = "btn_5dollar";
            this.btn_5dollar.Size = new System.Drawing.Size(70, 52);
            this.btn_5dollar.TabIndex = 5;
            this.btn_5dollar.Text = "$5";
            this.btn_5dollar.UseVisualStyleBackColor = false;
            this.btn_5dollar.Click += new System.EventHandler(this.btn_5dollar_Click);
            // 
            // btn_10dollar
            // 
            this.btn_10dollar.BackColor = System.Drawing.Color.Green;
            this.btn_10dollar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_10dollar.Location = new System.Drawing.Point(937, 357);
            this.btn_10dollar.Name = "btn_10dollar";
            this.btn_10dollar.Size = new System.Drawing.Size(70, 52);
            this.btn_10dollar.TabIndex = 6;
            this.btn_10dollar.Text = "$10";
            this.btn_10dollar.UseVisualStyleBackColor = false;
            this.btn_10dollar.Click += new System.EventHandler(this.btn_10dollar_Click);
            // 
            // btn_getChange
            // 
            this.btn_getChange.BackColor = System.Drawing.Color.Red;
            this.btn_getChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_getChange.Location = new System.Drawing.Point(847, 483);
            this.btn_getChange.Name = "btn_getChange";
            this.btn_getChange.Size = new System.Drawing.Size(160, 39);
            this.btn_getChange.TabIndex = 7;
            this.btn_getChange.Text = "Get Change";
            this.btn_getChange.UseVisualStyleBackColor = false;
            this.btn_getChange.Click += new System.EventHandler(this.btn_getChange_Click);
            // 
            // lbl_itemPrice
            // 
            this.lbl_itemPrice.AutoSize = true;
            this.lbl_itemPrice.BackColor = System.Drawing.Color.Orange;
            this.lbl_itemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemPrice.Location = new System.Drawing.Point(387, 133);
            this.lbl_itemPrice.Name = "lbl_itemPrice";
            this.lbl_itemPrice.Size = new System.Drawing.Size(0, 32);
            this.lbl_itemPrice.TabIndex = 8;
            // 
            // lbl_itemQuantity
            // 
            this.lbl_itemQuantity.AutoSize = true;
            this.lbl_itemQuantity.BackColor = System.Drawing.Color.Orange;
            this.lbl_itemQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemQuantity.Location = new System.Drawing.Point(508, 133);
            this.lbl_itemQuantity.Name = "lbl_itemQuantity";
            this.lbl_itemQuantity.Size = new System.Drawing.Size(0, 32);
            this.lbl_itemQuantity.TabIndex = 9;
            // 
            // lbl_Balance
            // 
            this.lbl_Balance.AutoSize = true;
            this.lbl_Balance.BackColor = System.Drawing.Color.Green;
            this.lbl_Balance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Balance.Location = new System.Drawing.Point(847, 430);
            this.lbl_Balance.Name = "lbl_Balance";
            this.lbl_Balance.Size = new System.Drawing.Size(61, 22);
            this.lbl_Balance.TabIndex = 10;
            this.lbl_Balance.Text = "label5";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cyan;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(690, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 11;
            this.button1.Text = "A1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Cyan;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(690, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 25);
            this.button2.TabIndex = 12;
            this.button2.Text = "A2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Cyan;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(690, 206);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 25);
            this.button3.TabIndex = 13;
            this.button3.Text = "A3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Cyan;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(690, 237);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 25);
            this.button4.TabIndex = 14;
            this.button4.Text = "A4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Cyan;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(690, 268);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 25);
            this.button5.TabIndex = 15;
            this.button5.Text = "B1";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Cyan;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(690, 299);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 25);
            this.button6.TabIndex = 16;
            this.button6.Text = "B2";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Cyan;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(690, 330);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 26);
            this.button7.TabIndex = 17;
            this.button7.Text = "B3";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Cyan;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(690, 362);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 26);
            this.button8.TabIndex = 18;
            this.button8.Text = "B4";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Cyan;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(690, 394);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 26);
            this.button9.TabIndex = 19;
            this.button9.Text = "C1";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Cyan;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(690, 426);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 26);
            this.button10.TabIndex = 20;
            this.button10.Text = "C2";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Cyan;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(690, 458);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 26);
            this.button11.TabIndex = 21;
            this.button11.Text = "C3";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Cyan;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(690, 490);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 26);
            this.button12.TabIndex = 22;
            this.button12.Text = "C4";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Cyan;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(690, 522);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 26);
            this.button13.TabIndex = 23;
            this.button13.Text = "D1";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Cyan;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(690, 554);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 26);
            this.button14.TabIndex = 24;
            this.button14.Text = "D2";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Cyan;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(690, 586);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 25);
            this.button15.TabIndex = 25;
            this.button15.Text = "D3";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.Cyan;
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(690, 617);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 25);
            this.button16.TabIndex = 26;
            this.button16.Text = "D4";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // lbl_itemName
            // 
            this.lbl_itemName.AutoSize = true;
            this.lbl_itemName.BackColor = System.Drawing.Color.Orange;
            this.lbl_itemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemName.Location = new System.Drawing.Point(12, 133);
            this.lbl_itemName.Name = "lbl_itemName";
            this.lbl_itemName.Size = new System.Drawing.Size(0, 32);
            this.lbl_itemName.TabIndex = 0;
            // 
            // btn_createSalesReport
            // 
            this.btn_createSalesReport.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_createSalesReport.Location = new System.Drawing.Point(973, 660);
            this.btn_createSalesReport.Name = "btn_createSalesReport";
            this.btn_createSalesReport.Size = new System.Drawing.Size(82, 52);
            this.btn_createSalesReport.TabIndex = 27;
            this.btn_createSalesReport.UseVisualStyleBackColor = false;
            this.btn_createSalesReport.Click += new System.EventHandler(this.btn_createSalesReport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1067, 724);
            this.Controls.Add(this.btn_createSalesReport);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_Balance);
            this.Controls.Add(this.lbl_itemQuantity);
            this.Controls.Add(this.lbl_itemPrice);
            this.Controls.Add(this.btn_getChange);
            this.Controls.Add(this.btn_10dollar);
            this.Controls.Add(this.btn_5dollar);
            this.Controls.Add(this.btn_2dollar);
            this.Controls.Add(this.btn_1Dollar);
            this.Controls.Add(this.lbl_InsertBills);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_itemName);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_InsertBills;
        private System.Windows.Forms.Button btn_1Dollar;
        private System.Windows.Forms.Button btn_2dollar;
        private System.Windows.Forms.Button btn_5dollar;
        private System.Windows.Forms.Button btn_10dollar;
        private System.Windows.Forms.Button btn_getChange;
        private System.Windows.Forms.Label lbl_itemPrice;
        private System.Windows.Forms.Label lbl_itemQuantity;
        private System.Windows.Forms.Label lbl_Balance;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
       private System.Windows.Forms.Label lbl_itemName;
        private System.Windows.Forms.Button btn_createSalesReport;
    }
}

