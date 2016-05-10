namespace Braggs_Final
{
    partial class Final
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
            this.Header = new System.Windows.Forms.Label();
            this.Itemslistbox = new System.Windows.Forms.ListBox();
            this.Itemboxlabel = new System.Windows.Forms.Label();
            this.addtocart = new System.Windows.Forms.Button();
            this.Shoppingcartlistboxlabel = new System.Windows.Forms.Label();
            this.shoppingCartListBox = new System.Windows.Forms.ListBox();
            this.makePurchase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.Location = new System.Drawing.Point(35, 28);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(289, 33);
            this.Header.TabIndex = 0;
            this.Header.Text = "Consignment Demo";
            // 
            // Itemslistbox
            // 
            this.Itemslistbox.FormattingEnabled = true;
            this.Itemslistbox.ItemHeight = 18;
            this.Itemslistbox.Location = new System.Drawing.Point(41, 99);
            this.Itemslistbox.Name = "Itemslistbox";
            this.Itemslistbox.Size = new System.Drawing.Size(305, 220);
            this.Itemslistbox.TabIndex = 1;
            // 
            // Itemboxlabel
            // 
            this.Itemboxlabel.AutoSize = true;
            this.Itemboxlabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Itemboxlabel.Location = new System.Drawing.Point(41, 80);
            this.Itemboxlabel.Name = "Itemboxlabel";
            this.Itemboxlabel.Size = new System.Drawing.Size(90, 18);
            this.Itemboxlabel.TabIndex = 2;
            this.Itemboxlabel.Text = "Store items";
            // 
            // addtocart
            // 
            this.addtocart.Location = new System.Drawing.Point(369, 178);
            this.addtocart.Name = "addtocart";
            this.addtocart.Size = new System.Drawing.Size(128, 47);
            this.addtocart.TabIndex = 3;
            this.addtocart.Text = "Add To Cart ->";
            this.addtocart.UseVisualStyleBackColor = true;
            this.addtocart.Click += new System.EventHandler(this.addtocart_Click);
            // 
            // Shoppingcartlistboxlabel
            // 
            this.Shoppingcartlistboxlabel.AutoSize = true;
            this.Shoppingcartlistboxlabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shoppingcartlistboxlabel.Location = new System.Drawing.Point(498, 80);
            this.Shoppingcartlistboxlabel.Name = "Shoppingcartlistboxlabel";
            this.Shoppingcartlistboxlabel.Size = new System.Drawing.Size(114, 18);
            this.Shoppingcartlistboxlabel.TabIndex = 5;
            this.Shoppingcartlistboxlabel.Text = "Shopping Cart";
            // 
            // shoppingCartListBox
            // 
            this.shoppingCartListBox.FormattingEnabled = true;
            this.shoppingCartListBox.ItemHeight = 18;
            this.shoppingCartListBox.Location = new System.Drawing.Point(522, 99);
            this.shoppingCartListBox.Name = "shoppingCartListBox";
            this.shoppingCartListBox.Size = new System.Drawing.Size(305, 220);
            this.shoppingCartListBox.TabIndex = 4;
            // 
            // makePurchase
            // 
            this.makePurchase.Location = new System.Drawing.Point(714, 345);
            this.makePurchase.Name = "makePurchase";
            this.makePurchase.Size = new System.Drawing.Size(113, 43);
            this.makePurchase.TabIndex = 6;
            this.makePurchase.Text = "Purchase";
            this.makePurchase.UseVisualStyleBackColor = true;
            this.makePurchase.Click += new System.EventHandler(this.makePurchase_Click);
            // 
            // Final
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 508);
            this.Controls.Add(this.makePurchase);
            this.Controls.Add(this.Shoppingcartlistboxlabel);
            this.Controls.Add(this.shoppingCartListBox);
            this.Controls.Add(this.addtocart);
            this.Controls.Add(this.Itemboxlabel);
            this.Controls.Add(this.Itemslistbox);
            this.Controls.Add(this.Header);
            this.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Final";
            this.Text = "Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.ListBox Itemslistbox;
        private System.Windows.Forms.Label Itemboxlabel;
        private System.Windows.Forms.Button addtocart;
        private System.Windows.Forms.Label Shoppingcartlistboxlabel;
        private System.Windows.Forms.ListBox shoppingCartListBox;
        private System.Windows.Forms.Button makePurchase;
    }
}

