
namespace StoresOwner
{
    partial class insertUpdateForm
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
            this.txbID = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbQuantity = new System.Windows.Forms.TextBox();
            this.txbPrice = new System.Windows.Forms.TextBox();
            this.txbStore = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblQuantitiy = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblStore = new System.Windows.Forms.Label();
            this.lblCurrentlyAdding = new System.Windows.Forms.Label();
            this.gbxSubTitle = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // txbID
            // 
            this.txbID.Location = new System.Drawing.Point(82, 37);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(137, 20);
            this.txbID.TabIndex = 1;
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(82, 66);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(137, 20);
            this.txbName.TabIndex = 2;
            // 
            // txbQuantity
            // 
            this.txbQuantity.Location = new System.Drawing.Point(82, 92);
            this.txbQuantity.Name = "txbQuantity";
            this.txbQuantity.Size = new System.Drawing.Size(137, 20);
            this.txbQuantity.TabIndex = 3;
            // 
            // txbPrice
            // 
            this.txbPrice.Location = new System.Drawing.Point(82, 118);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(137, 20);
            this.txbPrice.TabIndex = 4;
            // 
            // txbStore
            // 
            this.txbStore.Location = new System.Drawing.Point(82, 144);
            this.txbStore.Name = "txbStore";
            this.txbStore.Size = new System.Drawing.Size(137, 20);
            this.txbStore.TabIndex = 5;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(31, 170);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(188, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "Submit";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(29, 40);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 7;
            this.lblID.Text = "ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(29, 69);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Name";
            // 
            // lblQuantitiy
            // 
            this.lblQuantitiy.AutoSize = true;
            this.lblQuantitiy.Location = new System.Drawing.Point(28, 95);
            this.lblQuantitiy.Name = "lblQuantitiy";
            this.lblQuantitiy.Size = new System.Drawing.Size(46, 13);
            this.lblQuantitiy.TabIndex = 9;
            this.lblQuantitiy.Text = "Quantity";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(29, 121);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "Price";
            // 
            // lblStore
            // 
            this.lblStore.AutoSize = true;
            this.lblStore.Location = new System.Drawing.Point(29, 147);
            this.lblStore.Name = "lblStore";
            this.lblStore.Size = new System.Drawing.Size(32, 13);
            this.lblStore.TabIndex = 11;
            this.lblStore.Text = "Store";
            // 
            // lblCurrentlyAdding
            // 
            this.lblCurrentlyAdding.AutoSize = true;
            this.lblCurrentlyAdding.Location = new System.Drawing.Point(29, 73);
            this.lblCurrentlyAdding.Name = "lblCurrentlyAdding";
            this.lblCurrentlyAdding.Size = new System.Drawing.Size(0, 13);
            this.lblCurrentlyAdding.TabIndex = 12;
            // 
            // gbxSubTitle
            // 
            this.gbxSubTitle.Location = new System.Drawing.Point(12, 12);
            this.gbxSubTitle.Name = "gbxSubTitle";
            this.gbxSubTitle.Size = new System.Drawing.Size(221, 196);
            this.gbxSubTitle.TabIndex = 13;
            this.gbxSubTitle.TabStop = false;
            this.gbxSubTitle.Text = "Item Details";
            // 
            // insertUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 224);
            this.Controls.Add(this.lblCurrentlyAdding);
            this.Controls.Add(this.lblStore);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblQuantitiy);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txbStore);
            this.Controls.Add(this.txbPrice);
            this.Controls.Add(this.txbQuantity);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.txbID);
            this.Controls.Add(this.gbxSubTitle);
            this.Name = "insertUpdateForm";
            this.Text = "insertUpdateForm";
            this.Load += new System.EventHandler(this.insertUpdateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbQuantity;
        private System.Windows.Forms.TextBox txbPrice;
        private System.Windows.Forms.TextBox txbStore;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblQuantitiy;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblStore;
        private System.Windows.Forms.Label lblCurrentlyAdding;
        private System.Windows.Forms.GroupBox gbxSubTitle;
    }
}