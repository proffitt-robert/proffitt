
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
            this.btn_A1 = new System.Windows.Forms.Button();
            this.btn_A2 = new System.Windows.Forms.Button();
            this.btn_A3 = new System.Windows.Forms.Button();
            this.btn_A4 = new System.Windows.Forms.Button();
            this.btn_B1 = new System.Windows.Forms.Button();
            this.btn_B2 = new System.Windows.Forms.Button();
            this.btn_B3 = new System.Windows.Forms.Button();
            this.btn_B4 = new System.Windows.Forms.Button();
            this.btn_C1 = new System.Windows.Forms.Button();
            this.btn_C2 = new System.Windows.Forms.Button();
            this.btn_C3 = new System.Windows.Forms.Button();
            this.btn_C4 = new System.Windows.Forms.Button();
            this.btn_D1 = new System.Windows.Forms.Button();
            this.btn_D2 = new System.Windows.Forms.Button();
            this.btn_D3 = new System.Windows.Forms.Button();
            this.btn_D4 = new System.Windows.Forms.Button();
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
            // btn_A1
            // 
            this.btn_A1.BackColor = System.Drawing.Color.Cyan;
            this.btn_A1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_A1.Location = new System.Drawing.Point(690, 142);
            this.btn_A1.Name = "btn_A1";
            this.btn_A1.Size = new System.Drawing.Size(75, 25);
            this.btn_A1.TabIndex = 11;
            this.btn_A1.Text = "A1";
            this.btn_A1.UseVisualStyleBackColor = false;
            this.btn_A1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_A2
            // 
            this.btn_A2.BackColor = System.Drawing.Color.Cyan;
            this.btn_A2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_A2.Location = new System.Drawing.Point(690, 175);
            this.btn_A2.Name = "btn_A2";
            this.btn_A2.Size = new System.Drawing.Size(75, 25);
            this.btn_A2.TabIndex = 12;
            this.btn_A2.Text = "A2";
            this.btn_A2.UseVisualStyleBackColor = false;
            this.btn_A2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_A3
            // 
            this.btn_A3.BackColor = System.Drawing.Color.Cyan;
            this.btn_A3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_A3.Location = new System.Drawing.Point(690, 206);
            this.btn_A3.Name = "btn_A3";
            this.btn_A3.Size = new System.Drawing.Size(75, 25);
            this.btn_A3.TabIndex = 13;
            this.btn_A3.Text = "A3";
            this.btn_A3.UseVisualStyleBackColor = false;
            this.btn_A3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_A4
            // 
            this.btn_A4.BackColor = System.Drawing.Color.Cyan;
            this.btn_A4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_A4.Location = new System.Drawing.Point(690, 237);
            this.btn_A4.Name = "btn_A4";
            this.btn_A4.Size = new System.Drawing.Size(75, 25);
            this.btn_A4.TabIndex = 14;
            this.btn_A4.Text = "A4";
            this.btn_A4.UseVisualStyleBackColor = false;
            this.btn_A4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_B1
            // 
            this.btn_B1.BackColor = System.Drawing.Color.Cyan;
            this.btn_B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_B1.Location = new System.Drawing.Point(690, 268);
            this.btn_B1.Name = "btn_B1";
            this.btn_B1.Size = new System.Drawing.Size(75, 25);
            this.btn_B1.TabIndex = 15;
            this.btn_B1.Text = "B1";
            this.btn_B1.UseVisualStyleBackColor = false;
            this.btn_B1.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_B2
            // 
            this.btn_B2.BackColor = System.Drawing.Color.Cyan;
            this.btn_B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_B2.Location = new System.Drawing.Point(690, 299);
            this.btn_B2.Name = "btn_B2";
            this.btn_B2.Size = new System.Drawing.Size(75, 25);
            this.btn_B2.TabIndex = 16;
            this.btn_B2.Text = "B2";
            this.btn_B2.UseVisualStyleBackColor = false;
            this.btn_B2.Click += new System.EventHandler(this.button6_Click);
            // 
            // btn_B3
            // 
            this.btn_B3.BackColor = System.Drawing.Color.Cyan;
            this.btn_B3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_B3.Location = new System.Drawing.Point(690, 330);
            this.btn_B3.Name = "btn_B3";
            this.btn_B3.Size = new System.Drawing.Size(75, 26);
            this.btn_B3.TabIndex = 17;
            this.btn_B3.Text = "B3";
            this.btn_B3.UseVisualStyleBackColor = false;
            this.btn_B3.Click += new System.EventHandler(this.button7_Click);
            // 
            // btn_B4
            // 
            this.btn_B4.BackColor = System.Drawing.Color.Cyan;
            this.btn_B4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_B4.Location = new System.Drawing.Point(690, 362);
            this.btn_B4.Name = "btn_B4";
            this.btn_B4.Size = new System.Drawing.Size(75, 26);
            this.btn_B4.TabIndex = 18;
            this.btn_B4.Text = "B4";
            this.btn_B4.UseVisualStyleBackColor = false;
            this.btn_B4.Click += new System.EventHandler(this.button8_Click);
            // 
            // btn_C1
            // 
            this.btn_C1.BackColor = System.Drawing.Color.Cyan;
            this.btn_C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_C1.Location = new System.Drawing.Point(690, 394);
            this.btn_C1.Name = "btn_C1";
            this.btn_C1.Size = new System.Drawing.Size(75, 26);
            this.btn_C1.TabIndex = 19;
            this.btn_C1.Text = "C1";
            this.btn_C1.UseVisualStyleBackColor = false;
            this.btn_C1.Click += new System.EventHandler(this.button9_Click);
            // 
            // btn_C2
            // 
            this.btn_C2.BackColor = System.Drawing.Color.Cyan;
            this.btn_C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_C2.Location = new System.Drawing.Point(690, 426);
            this.btn_C2.Name = "btn_C2";
            this.btn_C2.Size = new System.Drawing.Size(75, 26);
            this.btn_C2.TabIndex = 20;
            this.btn_C2.Text = "C2";
            this.btn_C2.UseVisualStyleBackColor = false;
            this.btn_C2.Click += new System.EventHandler(this.button10_Click);
            // 
            // btn_C3
            // 
            this.btn_C3.BackColor = System.Drawing.Color.Cyan;
            this.btn_C3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_C3.Location = new System.Drawing.Point(690, 458);
            this.btn_C3.Name = "btn_C3";
            this.btn_C3.Size = new System.Drawing.Size(75, 26);
            this.btn_C3.TabIndex = 21;
            this.btn_C3.Text = "C3";
            this.btn_C3.UseVisualStyleBackColor = false;
            this.btn_C3.Click += new System.EventHandler(this.button11_Click);
            // 
            // btn_C4
            // 
            this.btn_C4.BackColor = System.Drawing.Color.Cyan;
            this.btn_C4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_C4.Location = new System.Drawing.Point(690, 490);
            this.btn_C4.Name = "btn_C4";
            this.btn_C4.Size = new System.Drawing.Size(75, 26);
            this.btn_C4.TabIndex = 22;
            this.btn_C4.Text = "C4";
            this.btn_C4.UseVisualStyleBackColor = false;
            this.btn_C4.Click += new System.EventHandler(this.button12_Click);
            // 
            // btn_D1
            // 
            this.btn_D1.BackColor = System.Drawing.Color.Cyan;
            this.btn_D1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_D1.Location = new System.Drawing.Point(690, 522);
            this.btn_D1.Name = "btn_D1";
            this.btn_D1.Size = new System.Drawing.Size(75, 26);
            this.btn_D1.TabIndex = 23;
            this.btn_D1.Text = "D1";
            this.btn_D1.UseVisualStyleBackColor = false;
            this.btn_D1.Click += new System.EventHandler(this.button13_Click);
            // 
            // btn_D2
            // 
            this.btn_D2.BackColor = System.Drawing.Color.Cyan;
            this.btn_D2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_D2.Location = new System.Drawing.Point(690, 554);
            this.btn_D2.Name = "btn_D2";
            this.btn_D2.Size = new System.Drawing.Size(75, 26);
            this.btn_D2.TabIndex = 24;
            this.btn_D2.Text = "D2";
            this.btn_D2.UseVisualStyleBackColor = false;
            this.btn_D2.Click += new System.EventHandler(this.button14_Click);
            // 
            // btn_D3
            // 
            this.btn_D3.BackColor = System.Drawing.Color.Cyan;
            this.btn_D3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_D3.Location = new System.Drawing.Point(690, 586);
            this.btn_D3.Name = "btn_D3";
            this.btn_D3.Size = new System.Drawing.Size(75, 25);
            this.btn_D3.TabIndex = 25;
            this.btn_D3.Text = "D3";
            this.btn_D3.UseVisualStyleBackColor = false;
            this.btn_D3.Click += new System.EventHandler(this.button15_Click);
            // 
            // btn_D4
            // 
            this.btn_D4.BackColor = System.Drawing.Color.Cyan;
            this.btn_D4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_D4.Location = new System.Drawing.Point(690, 617);
            this.btn_D4.Name = "btn_D4";
            this.btn_D4.Size = new System.Drawing.Size(75, 25);
            this.btn_D4.TabIndex = 26;
            this.btn_D4.Text = "D4";
            this.btn_D4.UseVisualStyleBackColor = false;
            this.btn_D4.Click += new System.EventHandler(this.button16_Click);
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
            this.Controls.Add(this.btn_D4);
            this.Controls.Add(this.btn_D3);
            this.Controls.Add(this.btn_D2);
            this.Controls.Add(this.btn_D1);
            this.Controls.Add(this.btn_C4);
            this.Controls.Add(this.btn_C3);
            this.Controls.Add(this.btn_C2);
            this.Controls.Add(this.btn_C1);
            this.Controls.Add(this.btn_B4);
            this.Controls.Add(this.btn_B3);
            this.Controls.Add(this.btn_B2);
            this.Controls.Add(this.btn_B1);
            this.Controls.Add(this.btn_A4);
            this.Controls.Add(this.btn_A3);
            this.Controls.Add(this.btn_A2);
            this.Controls.Add(this.btn_A1);
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
        private System.Windows.Forms.Button btn_A1;
        private System.Windows.Forms.Button btn_A2;
        private System.Windows.Forms.Button btn_A3;
        private System.Windows.Forms.Button btn_A4;
        private System.Windows.Forms.Button btn_B1;
        private System.Windows.Forms.Button btn_B2;
        private System.Windows.Forms.Button btn_B3;
        private System.Windows.Forms.Button btn_B4;
        private System.Windows.Forms.Button btn_C1;
        private System.Windows.Forms.Button btn_C2;
        private System.Windows.Forms.Button btn_C3;
        private System.Windows.Forms.Button btn_C4;
        private System.Windows.Forms.Button btn_D1;
        private System.Windows.Forms.Button btn_D2;
        private System.Windows.Forms.Button btn_D3;
        private System.Windows.Forms.Button btn_D4;
       private System.Windows.Forms.Label lbl_itemName;
        private System.Windows.Forms.Button btn_createSalesReport;
    }
}

