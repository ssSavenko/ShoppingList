namespace ShoppingList
{
    partial class ShopppingListView
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
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.NewItemName = new System.Windows.Forms.TextBox();
            this.ProductsList = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Enabled = false;
            this.AddButton.Location = new System.Drawing.Point(186, 246);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(92, 23);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Enabled = false;
            this.DeleteButton.Location = new System.Drawing.Point(12, 275);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(266, 23);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // NewItemName
            // 
            this.NewItemName.Location = new System.Drawing.Point(12, 246);
            this.NewItemName.Name = "NewItemName";
            this.NewItemName.Size = new System.Drawing.Size(168, 22);
            this.NewItemName.TabIndex = 3;
            this.NewItemName.TextChanged += new System.EventHandler(this.NewItemName_TextChanged);
            // 
            // ProductsList
            // 
            this.ProductsList.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ProductsList.FormattingEnabled = true;
            this.ProductsList.Location = new System.Drawing.Point(12, 14);
            this.ProductsList.Margin = new System.Windows.Forms.Padding(5);
            this.ProductsList.MinimumSize = new System.Drawing.Size(266, 208);
            this.ProductsList.Name = "ProductsList";
            this.ProductsList.Size = new System.Drawing.Size(266, 208);
            this.ProductsList.TabIndex = 4;
            this.ProductsList.SelectedIndexChanged += new System.EventHandler(this.ProductsList_SelectedIndexChanged);
            // 
            // ShopppingListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(294, 314);
            this.Controls.Add(this.ProductsList);
            this.Controls.Add(this.NewItemName);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Name = "ShopppingListView";
            this.Text = "Shopping List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.TextBox NewItemName;
        private System.Windows.Forms.CheckedListBox ProductsList;
    }
}

