namespace Queue_using_arrays
{
    partial class Order
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            this.logo = new System.Windows.Forms.PictureBox();
            this.heading = new System.Windows.Forms.Label();
            this.confirmOrderText = new System.Windows.Forms.Label();
            this.collectOrderText = new System.Windows.Forms.Label();
            this.orderNumber = new System.Windows.Forms.Label();
            this.orderReadyText = new System.Windows.Forms.Label();
            this.lastOrderPlacedText = new System.Windows.Forms.Label();
            this.lastOrderPlaced = new System.Windows.Forms.Label();
            this.lastOrderCollectedText = new System.Windows.Forms.Label();
            this.lastOrderCollected = new System.Windows.Forms.Label();
            this.placeOrderBtn = new System.Windows.Forms.Button();
            this.collectOrderBtn = new System.Windows.Forms.Button();
            this.orderReadyTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.Image = global::Queue_using_arrays.Properties.Resources.McWonalds_Logo;
            this.logo.Location = new System.Drawing.Point(52, 27);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(172, 158);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // heading
            // 
            this.heading.AutoSize = true;
            this.heading.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading.Location = new System.Drawing.Point(270, 82);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(524, 46);
            this.heading.TabIndex = 1;
            this.heading.Text = "McWonald\'s order collection";
            // 
            // confirmOrderText
            // 
            this.confirmOrderText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmOrderText.Location = new System.Drawing.Point(143, 224);
            this.confirmOrderText.Name = "confirmOrderText";
            this.confirmOrderText.Size = new System.Drawing.Size(341, 138);
            this.confirmOrderText.TabIndex = 2;
            this.confirmOrderText.Text = "Press this button to confirm your order. This will generate a three digit code th" +
    "at will be needed when your order is ready.";
            // 
            // collectOrderText
            // 
            this.collectOrderText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.collectOrderText.Location = new System.Drawing.Point(143, 590);
            this.collectOrderText.Name = "collectOrderText";
            this.collectOrderText.Size = new System.Drawing.Size(341, 64);
            this.collectOrderText.TabIndex = 3;
            this.collectOrderText.Text = "Press this button to collect the order displayed as ready.";
            // 
            // orderNumber
            // 
            this.orderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderNumber.ForeColor = System.Drawing.Color.Green;
            this.orderNumber.Location = new System.Drawing.Point(515, 373);
            this.orderNumber.Name = "orderNumber";
            this.orderNumber.Size = new System.Drawing.Size(306, 146);
            this.orderNumber.TabIndex = 4;
            this.orderNumber.Text = "-";
            this.orderNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // orderReadyText
            // 
            this.orderReadyText.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderReadyText.ForeColor = System.Drawing.Color.Green;
            this.orderReadyText.Location = new System.Drawing.Point(36, 373);
            this.orderReadyText.Name = "orderReadyText";
            this.orderReadyText.Size = new System.Drawing.Size(496, 146);
            this.orderReadyText.TabIndex = 5;
            this.orderReadyText.Text = "Order ready:";
            this.orderReadyText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lastOrderPlacedText
            // 
            this.lastOrderPlacedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastOrderPlacedText.Location = new System.Drawing.Point(587, 294);
            this.lastOrderPlacedText.Name = "lastOrderPlacedText";
            this.lastOrderPlacedText.Size = new System.Drawing.Size(128, 21);
            this.lastOrderPlacedText.TabIndex = 6;
            this.lastOrderPlacedText.Text = "Last order placed";
            // 
            // lastOrderPlaced
            // 
            this.lastOrderPlaced.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastOrderPlaced.Location = new System.Drawing.Point(721, 294);
            this.lastOrderPlaced.Name = "lastOrderPlaced";
            this.lastOrderPlaced.Size = new System.Drawing.Size(128, 21);
            this.lastOrderPlaced.TabIndex = 7;
            this.lastOrderPlaced.Text = "-";
            // 
            // lastOrderCollectedText
            // 
            this.lastOrderCollectedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastOrderCollectedText.Location = new System.Drawing.Point(566, 633);
            this.lastOrderCollectedText.Name = "lastOrderCollectedText";
            this.lastOrderCollectedText.Size = new System.Drawing.Size(159, 21);
            this.lastOrderCollectedText.TabIndex = 8;
            this.lastOrderCollectedText.Text = "Last order collected";
            // 
            // lastOrderCollected
            // 
            this.lastOrderCollected.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastOrderCollected.Location = new System.Drawing.Point(721, 633);
            this.lastOrderCollected.Name = "lastOrderCollected";
            this.lastOrderCollected.Size = new System.Drawing.Size(128, 21);
            this.lastOrderCollected.TabIndex = 9;
            this.lastOrderCollected.Text = "-";
            // 
            // placeOrderBtn
            // 
            this.placeOrderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeOrderBtn.Location = new System.Drawing.Point(599, 233);
            this.placeOrderBtn.Name = "placeOrderBtn";
            this.placeOrderBtn.Size = new System.Drawing.Size(146, 48);
            this.placeOrderBtn.TabIndex = 10;
            this.placeOrderBtn.Text = "Place order";
            this.placeOrderBtn.UseVisualStyleBackColor = true;
            this.placeOrderBtn.Click += new System.EventHandler(this.placeOrderBtn_Click);
            // 
            // collectOrderBtn
            // 
            this.collectOrderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.collectOrderBtn.Location = new System.Drawing.Point(599, 578);
            this.collectOrderBtn.Name = "collectOrderBtn";
            this.collectOrderBtn.Size = new System.Drawing.Size(146, 48);
            this.collectOrderBtn.TabIndex = 11;
            this.collectOrderBtn.Text = "Collect order";
            this.collectOrderBtn.UseVisualStyleBackColor = true;
            this.collectOrderBtn.Click += new System.EventHandler(this.collectOrderBtn_Click);
            // 
            // orderReadyTimer
            // 
            this.orderReadyTimer.Enabled = true;
            this.orderReadyTimer.Interval = 5000;
            this.orderReadyTimer.Tick += new System.EventHandler(this.orderReadyTimer_Tick);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 698);
            this.Controls.Add(this.collectOrderBtn);
            this.Controls.Add(this.placeOrderBtn);
            this.Controls.Add(this.lastOrderCollected);
            this.Controls.Add(this.lastOrderCollectedText);
            this.Controls.Add(this.lastOrderPlaced);
            this.Controls.Add(this.lastOrderPlacedText);
            this.Controls.Add(this.orderReadyText);
            this.Controls.Add(this.orderNumber);
            this.Controls.Add(this.collectOrderText);
            this.Controls.Add(this.confirmOrderText);
            this.Controls.Add(this.heading);
            this.Controls.Add(this.logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Order";
            this.Text = "McWonalds orders";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label heading;
        private System.Windows.Forms.Label confirmOrderText;
        private System.Windows.Forms.Label collectOrderText;
        private System.Windows.Forms.Label orderNumber;
        private System.Windows.Forms.Label orderReadyText;
        private System.Windows.Forms.Label lastOrderPlacedText;
        private System.Windows.Forms.Label lastOrderPlaced;
        private System.Windows.Forms.Label lastOrderCollectedText;
        private System.Windows.Forms.Label lastOrderCollected;
        private System.Windows.Forms.Button placeOrderBtn;
        private System.Windows.Forms.Button collectOrderBtn;
        private System.Windows.Forms.Timer orderReadyTimer;
    }
}

