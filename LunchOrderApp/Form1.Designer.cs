namespace LunchOrderApp
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
            this.hamburgerBtn = new System.Windows.Forms.RadioButton();
            this.pizzaBtn = new System.Windows.Forms.RadioButton();
            this.saladBtn = new System.Windows.Forms.RadioButton();
            this.firstAddon = new System.Windows.Forms.CheckBox();
            this.secondAddon = new System.Windows.Forms.CheckBox();
            this.thirdAddon = new System.Windows.Forms.CheckBox();
            this.subtotalTxt = new System.Windows.Forms.TextBox();
            this.taxTxt = new System.Windows.Forms.TextBox();
            this.orderTotalTxt = new System.Windows.Forms.TextBox();
            this.placeOrderBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // hamburgerBtn
            // 
            this.hamburgerBtn.AutoSize = true;
            this.hamburgerBtn.Location = new System.Drawing.Point(29, 49);
            this.hamburgerBtn.Name = "hamburgerBtn";
            this.hamburgerBtn.Size = new System.Drawing.Size(149, 21);
            this.hamburgerBtn.TabIndex = 0;
            this.hamburgerBtn.TabStop = true;
            this.hamburgerBtn.Text = "Hamburger - $6.95";
            this.hamburgerBtn.UseVisualStyleBackColor = true;
            this.hamburgerBtn.CheckedChanged += new System.EventHandler(this.hamburgerBtn_CheckedChanged);
            // 
            // pizzaBtn
            // 
            this.pizzaBtn.AutoSize = true;
            this.pizzaBtn.Location = new System.Drawing.Point(29, 76);
            this.pizzaBtn.Name = "pizzaBtn";
            this.pizzaBtn.Size = new System.Drawing.Size(112, 21);
            this.pizzaBtn.TabIndex = 1;
            this.pizzaBtn.TabStop = true;
            this.pizzaBtn.Text = "Pizza - $5.95";
            this.pizzaBtn.UseVisualStyleBackColor = true;
            this.pizzaBtn.CheckedChanged += new System.EventHandler(this.pizzaBtn_CheckedChanged);
            // 
            // saladBtn
            // 
            this.saladBtn.AutoSize = true;
            this.saladBtn.Location = new System.Drawing.Point(29, 102);
            this.saladBtn.Name = "saladBtn";
            this.saladBtn.Size = new System.Drawing.Size(114, 21);
            this.saladBtn.TabIndex = 2;
            this.saladBtn.TabStop = true;
            this.saladBtn.Text = "Salad - $4.95";
            this.saladBtn.UseVisualStyleBackColor = true;
            this.saladBtn.CheckedChanged += new System.EventHandler(this.saladBtn_CheckedChanged);
            // 
            // firstAddon
            // 
            this.firstAddon.AutoSize = true;
            this.firstAddon.Location = new System.Drawing.Point(18, 49);
            this.firstAddon.Name = "firstAddon";
            this.firstAddon.Size = new System.Drawing.Size(98, 21);
            this.firstAddon.TabIndex = 3;
            this.firstAddon.Text = "checkBox1";
            this.firstAddon.UseVisualStyleBackColor = true;
            // 
            // secondAddon
            // 
            this.secondAddon.AutoSize = true;
            this.secondAddon.Location = new System.Drawing.Point(18, 76);
            this.secondAddon.Name = "secondAddon";
            this.secondAddon.Size = new System.Drawing.Size(98, 21);
            this.secondAddon.TabIndex = 4;
            this.secondAddon.Text = "checkBox2";
            this.secondAddon.UseVisualStyleBackColor = true;
            // 
            // thirdAddon
            // 
            this.thirdAddon.AutoSize = true;
            this.thirdAddon.Location = new System.Drawing.Point(18, 103);
            this.thirdAddon.Name = "thirdAddon";
            this.thirdAddon.Size = new System.Drawing.Size(98, 21);
            this.thirdAddon.TabIndex = 5;
            this.thirdAddon.Text = "checkBox3";
            this.thirdAddon.UseVisualStyleBackColor = true;
            // 
            // subtotalTxt
            // 
            this.subtotalTxt.Enabled = false;
            this.subtotalTxt.Location = new System.Drawing.Point(105, 29);
            this.subtotalTxt.Name = "subtotalTxt";
            this.subtotalTxt.Size = new System.Drawing.Size(100, 22);
            this.subtotalTxt.TabIndex = 6;
            // 
            // taxTxt
            // 
            this.taxTxt.Enabled = false;
            this.taxTxt.Location = new System.Drawing.Point(105, 64);
            this.taxTxt.Name = "taxTxt";
            this.taxTxt.Size = new System.Drawing.Size(100, 22);
            this.taxTxt.TabIndex = 7;
            // 
            // orderTotalTxt
            // 
            this.orderTotalTxt.Enabled = false;
            this.orderTotalTxt.Location = new System.Drawing.Point(105, 97);
            this.orderTotalTxt.Name = "orderTotalTxt";
            this.orderTotalTxt.Size = new System.Drawing.Size(100, 22);
            this.orderTotalTxt.TabIndex = 8;
            // 
            // placeOrderBtn
            // 
            this.placeOrderBtn.Location = new System.Drawing.Point(279, 217);
            this.placeOrderBtn.Name = "placeOrderBtn";
            this.placeOrderBtn.Size = new System.Drawing.Size(188, 23);
            this.placeOrderBtn.TabIndex = 9;
            this.placeOrderBtn.Text = "Place Order";
            this.placeOrderBtn.UseVisualStyleBackColor = true;
            this.placeOrderBtn.Click += new System.EventHandler(this.placeOrderBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(279, 362);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(188, 23);
            this.exitBtn.TabIndex = 10;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.firstAddon);
            this.groupBox1.Controls.Add(this.secondAddon);
            this.groupBox1.Controls.Add(this.thirdAddon);
            this.groupBox1.Location = new System.Drawing.Point(261, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 153);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add-on Items ($.75/each)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.hamburgerBtn);
            this.groupBox2.Controls.Add(this.pizzaBtn);
            this.groupBox2.Controls.Add(this.saladBtn);
            this.groupBox2.Location = new System.Drawing.Point(29, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 153);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Main Course";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.subtotalTxt);
            this.groupBox3.Controls.Add(this.taxTxt);
            this.groupBox3.Controls.Add(this.orderTotalTxt);
            this.groupBox3.Location = new System.Drawing.Point(29, 217);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(226, 168);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Order Total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subtotal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tax (7.75%):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Order Total:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 421);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.placeOrderBtn);
            this.Name = "Form1";
            this.Text = "Lunch Order";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton hamburgerBtn;
        private System.Windows.Forms.RadioButton pizzaBtn;
        private System.Windows.Forms.RadioButton saladBtn;
        private System.Windows.Forms.CheckBox firstAddon;
        private System.Windows.Forms.CheckBox secondAddon;
        private System.Windows.Forms.CheckBox thirdAddon;
        private System.Windows.Forms.TextBox subtotalTxt;
        private System.Windows.Forms.TextBox taxTxt;
        private System.Windows.Forms.TextBox orderTotalTxt;
        private System.Windows.Forms.Button placeOrderBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

